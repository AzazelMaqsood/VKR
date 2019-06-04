namespace Plan_B
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnMonitoring = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnZadachi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSotr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAbout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(359, 159);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Имя";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Кол-во задач";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(600, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title7.Name = "Name";
            this.chart1.Titles.Add(title7);
            // 
            // BtnMonitoring
            // 
            this.BtnMonitoring.Depth = 0;
            this.BtnMonitoring.Location = new System.Drawing.Point(12, 159);
            this.BtnMonitoring.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMonitoring.Name = "BtnMonitoring";
            this.BtnMonitoring.Primary = true;
            this.BtnMonitoring.Size = new System.Drawing.Size(263, 51);
            this.BtnMonitoring.TabIndex = 1;
            this.BtnMonitoring.Text = "Мониторинг";
            this.BtnMonitoring.UseVisualStyleBackColor = true;
            this.BtnMonitoring.Click += new System.EventHandler(this.BtnMonitoring_Click);
            // 
            // BtnZadachi
            // 
            this.BtnZadachi.Depth = 0;
            this.BtnZadachi.Location = new System.Drawing.Point(12, 242);
            this.BtnZadachi.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnZadachi.Name = "BtnZadachi";
            this.BtnZadachi.Primary = true;
            this.BtnZadachi.Size = new System.Drawing.Size(263, 51);
            this.BtnZadachi.TabIndex = 2;
            this.BtnZadachi.Text = "Назначение задач";
            this.BtnZadachi.UseVisualStyleBackColor = true;
            this.BtnZadachi.Click += new System.EventHandler(this.BtnZadachi_Click);
            // 
            // BtnSotr
            // 
            this.BtnSotr.Depth = 0;
            this.BtnSotr.Location = new System.Drawing.Point(12, 325);
            this.BtnSotr.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSotr.Name = "BtnSotr";
            this.BtnSotr.Primary = true;
            this.BtnSotr.Size = new System.Drawing.Size(263, 51);
            this.BtnSotr.TabIndex = 3;
            this.BtnSotr.Text = "Сотруднику";
            this.BtnSotr.UseVisualStyleBackColor = true;
            this.BtnSotr.Click += new System.EventHandler(this.BtnSotr_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Depth = 0;
            this.BtnAbout.Location = new System.Drawing.Point(12, 408);
            this.BtnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Primary = true;
            this.BtnAbout.Size = new System.Drawing.Size(263, 51);
            this.BtnAbout.TabIndex = 4;
            this.BtnAbout.Text = "О программе";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(474, 108);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(252, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Мониторинг успеваемости";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 506);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnSotr);
            this.Controls.Add(this.BtnZadachi);
            this.Controls.Add(this.BtnMonitoring);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(971, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(971, 506);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnMonitoring;
        private MaterialSkin.Controls.MaterialRaisedButton BtnZadachi;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSotr;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAbout;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}