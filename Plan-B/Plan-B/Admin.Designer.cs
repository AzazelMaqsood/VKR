namespace Plan_B
{
    partial class Admin
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Id_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolzhn_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staj_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sost_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOtchet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_sotr,
            this.Name_sotr,
            this.F_sotr,
            this.O_sotr,
            this.Dolzhn_sotr,
            this.Staj_sotr,
            this.Sost_sotr});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1087, 421);
            this.dgv.TabIndex = 0;
            // 
            // Id_sotr
            // 
            this.Id_sotr.DataPropertyName = "Id_sotr";
            this.Id_sotr.HeaderText = "Код";
            this.Id_sotr.Name = "Id_sotr";
            this.Id_sotr.ReadOnly = true;
            this.Id_sotr.Width = 50;
            // 
            // Name_sotr
            // 
            this.Name_sotr.DataPropertyName = "I_sotr";
            this.Name_sotr.HeaderText = "Имя";
            this.Name_sotr.Name = "Name_sotr";
            this.Name_sotr.ReadOnly = true;
            this.Name_sotr.Width = 120;
            // 
            // F_sotr
            // 
            this.F_sotr.DataPropertyName = "F_sotr";
            this.F_sotr.HeaderText = "Фамилия";
            this.F_sotr.Name = "F_sotr";
            this.F_sotr.ReadOnly = true;
            this.F_sotr.Width = 120;
            // 
            // O_sotr
            // 
            this.O_sotr.DataPropertyName = "O_sotr";
            this.O_sotr.HeaderText = "Отчество";
            this.O_sotr.Name = "O_sotr";
            this.O_sotr.ReadOnly = true;
            this.O_sotr.Width = 130;
            // 
            // Dolzhn_sotr
            // 
            this.Dolzhn_sotr.DataPropertyName = "Name_dolzhn";
            this.Dolzhn_sotr.HeaderText = "Должность";
            this.Dolzhn_sotr.Name = "Dolzhn_sotr";
            this.Dolzhn_sotr.ReadOnly = true;
            this.Dolzhn_sotr.Width = 130;
            // 
            // Staj_sotr
            // 
            this.Staj_sotr.DataPropertyName = "Staj_sotr";
            this.Staj_sotr.HeaderText = "Стаж";
            this.Staj_sotr.Name = "Staj_sotr";
            this.Staj_sotr.ReadOnly = true;
            this.Staj_sotr.Width = 120;
            // 
            // Sost_sotr
            // 
            this.Sost_sotr.DataPropertyName = "Sost_sotr";
            this.Sost_sotr.HeaderText = "Уровень загруженности";
            this.Sost_sotr.Name = "Sost_sotr";
            this.Sost_sotr.ReadOnly = true;
            this.Sost_sotr.Width = 120;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(942, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOtchet
            // 
            this.btnOtchet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOtchet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtchet.Location = new System.Drawing.Point(12, 439);
            this.btnOtchet.Name = "btnOtchet";
            this.btnOtchet.Size = new System.Drawing.Size(256, 70);
            this.btnOtchet.TabIndex = 2;
            this.btnOtchet.Text = "Сформировать отчет";
            this.btnOtchet.UseVisualStyleBackColor = false;
            this.btnOtchet.Click += new System.EventHandler(this.btnOtchet_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1111, 514);
            this.Controls.Add(this.btnOtchet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страница администратора";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolzhn_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staj_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sost_sotr;
        private System.Windows.Forms.Button btnOtchet;
    }
}