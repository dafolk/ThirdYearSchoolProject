namespace ExpenseManager.view
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOutcome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutcome)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutcome
            // 
            this.lblOutcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblOutcome.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lblOutcome.Image = global::ExpenseManager.Properties.Resources.arrow_down;
            this.lblOutcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutcome.Location = new System.Drawing.Point(454, 140);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(400, 100);
            this.lblOutcome.TabIndex = 5;
            this.lblOutcome.Text = "Outcome";
            this.lblOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncome
            // 
            this.lblIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblIncome.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.lblIncome.Image = global::ExpenseManager.Properties.Resources.arrow_up;
            this.lblIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIncome.Location = new System.Drawing.Point(26, 140);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(400, 100);
            this.lblIncome.TabIndex = 6;
            this.lblIncome.Text = "Income";
            this.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartIncome
            // 
            this.chartIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartIncome.BackColor = System.Drawing.Color.Transparent;
            this.chartIncome.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            chartArea5.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            legend5.Enabled = false;
            legend5.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.chartIncome.Legends.Add(legend5);
            this.chartIncome.Location = new System.Drawing.Point(26, 243);
            this.chartIncome.Name = "chartIncome";
            this.chartIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 4;
            this.chartIncome.Series.Add(series5);
            this.chartIncome.Size = new System.Drawing.Size(400, 400);
            this.chartIncome.TabIndex = 4;
            this.chartIncome.Text = "Income";
            // 
            // chartOutcome
            // 
            this.chartOutcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartOutcome.BackColor = System.Drawing.Color.Transparent;
            this.chartOutcome.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            chartArea6.Name = "ChartArea1";
            this.chartOutcome.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            legend6.Enabled = false;
            legend6.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartOutcome.Legends.Add(legend6);
            this.chartOutcome.Location = new System.Drawing.Point(454, 243);
            this.chartOutcome.Name = "chartOutcome";
            this.chartOutcome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.BorderColor = System.Drawing.Color.White;
            series6.BorderWidth = 0;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartOutcome.Series.Add(series6);
            this.chartOutcome.Size = new System.Drawing.Size(400, 400);
            this.chartOutcome.TabIndex = 3;
            this.chartOutcome.Text = "Usage";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(882, 120);
            this.pnlHeader.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.chartIncome);
            this.Controls.Add(this.chartOutcome);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutcome)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
    }
}