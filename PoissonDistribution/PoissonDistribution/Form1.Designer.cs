namespace PoissonDistribution
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chart = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.numBernoulli = new System.Windows.Forms.NumericUpDown();
            this.numBernoulliLabel = new System.Windows.Forms.Label();
            this.successProbability = new System.Windows.Forms.NumericUpDown();
            this.probabilityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBernoulli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart.Location = new System.Drawing.Point(2, 60);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1375, 547);
            this.chart.TabIndex = 0;
            this.chart.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(1284, 18);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(88, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // numBernoulli
            // 
            this.numBernoulli.Location = new System.Drawing.Point(423, 18);
            this.numBernoulli.Name = "numBernoulli";
            this.numBernoulli.Size = new System.Drawing.Size(120, 23);
            this.numBernoulli.TabIndex = 2;
            // 
            // numBernoulliLabel
            // 
            this.numBernoulliLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numBernoulliLabel.Location = new System.Drawing.Point(144, 18);
            this.numBernoulliLabel.Name = "numBernoulliLabel";
            this.numBernoulliLabel.Size = new System.Drawing.Size(273, 23);
            this.numBernoulliLabel.TabIndex = 3;
            this.numBernoulliLabel.Text = "NUMBER OF BERNOULLI DISTRIBUTIONS:";
            // 
            // successProbability
            // 
            this.successProbability.Location = new System.Drawing.Point(880, 18);
            this.successProbability.Name = "successProbability";
            this.successProbability.Size = new System.Drawing.Size(120, 23);
            this.successProbability.TabIndex = 4;
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.probabilityLabel.Location = new System.Drawing.Point(776, 18);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(98, 22);
            this.probabilityLabel.TabIndex = 5;
            this.probabilityLabel.Text = "PROBABILITY:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 610);
            this.Controls.Add(this.probabilityLabel);
            this.Controls.Add(this.successProbability);
            this.Controls.Add(this.numBernoulliLabel);
            this.Controls.Add(this.numBernoulli);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBernoulli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successProbability)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox chart;
        private Button drawButton;
        private NumericUpDown numBernoulli;
        private Label numBernoulliLabel;
        private NumericUpDown successProbability;
        private Label probabilityLabel;
    }
}