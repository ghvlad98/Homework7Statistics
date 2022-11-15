namespace PoissonDistribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int convertX(double x, double minX, double maxX, int w)
        {
            if (maxX - minX == 0)
            {
                return 0;
            }

            return (int)(w * (x - minX) / (maxX - minX));
        }

        private int convertY(double y, double minY, double maxY, int h)
        {
            if (maxY - minY == 0)
            {
                return 0;
            }

            return (int)(h - h * (y - minY) / (maxY - minY));
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Form bernoulli = new Form2();
            bernoulli.Text = "Bernoulli";
            Form interArrivals = new Form2();
            interArrivals.Text = "Distribution of arrival times";
            Bitmap b = new Bitmap(bernoulli.Width, bernoulli.Height);
            Bitmap b2 = new Bitmap(interArrivals.Width, interArrivals.Height);
            bernoulli.BackgroundImageLayout = ImageLayout.Center;
            bernoulli.BackgroundImage = b;
            interArrivals.BackgroundImageLayout = ImageLayout.Center;
            interArrivals.BackgroundImage = b2;
            Graphics g = Graphics.FromImage(b);
            Graphics g2 = Graphics.FromImage(b2);
            Random rand = new Random();
            double n = (double)numBernoulli.Value;
            double p = (double)successProbability.Value;
            double successProb = p / n;

            if (p >= n)
            {
                MessageBox.Show("You have to choose a number of success that is less than the number of trials!");
                return;
            }

            double minX = 0;
            double maxX = n;
            double minY = 0;
            double maxY = n;

            Pen pen = new Pen(Color.Orange);
            Pen recPen = new Pen(Color.Black);
            List<double> arrivals = new List<double>();
            List<Point> times = new List<Point>();
            List<Point> path = new List<Point>();
            double y = 0;
            for (int x = 1; x <= n; x++)
            {
                double failProb = rand.NextDouble();
                while (failProb == successProb)
                {
                    failProb = rand.NextDouble();
                }

                if (failProb < successProb)
                {
                    y += 1;
                    double time;
                    if (arrivals.Count == 0)
                    {
                        time = x;
                    } else
                    {
                        time = x - arrivals.Last();
                    }
                    arrivals.Add(x);

                    int timeX = convertX(x, minX, maxX, interArrivals.Width);
                    int timeY = convertY(time, minY, maxY, interArrivals.Height);
                    times.Add(new Point(timeX, timeY));
                }

                int newX = convertX(x, minX, maxX, bernoulli.Width);
                int newY = convertY(y, minY, maxY, bernoulli.Height);
                path.Add(new Point(newX, newY));
            }
            g.DrawRectangle(recPen, 0, 0, bernoulli.Width - 1, bernoulli.Height - 1);
            g.DrawLines(pen, path.ToArray());

            g2.DrawRectangle(recPen, 0, 0, interArrivals.Width - 1, interArrivals.Height - 1);
            g2.DrawLines(pen, times.ToArray());

            bernoulli.Show();
            interArrivals.Show();
        }
    }
}
