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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Id_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolzhn_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staj_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sost_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtNaznachDolzhn = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnNaznachDolzhn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_sotr,
            this.Name_sotr,
            this.F_sotr,
            this.O_sotr,
            this.Dolzhn_sotr,
            this.Staj_sotr,
            this.Sost_sotr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dgv.Location = new System.Drawing.Point(12, 87);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1052, 421);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Id_sotr
            // 
            this.Id_sotr.DataPropertyName = "Id_sotr";
            this.Id_sotr.HeaderText = "Код";
            this.Id_sotr.Name = "Id_sotr";
            this.Id_sotr.ReadOnly = true;
            this.Id_sotr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_sotr.Visible = false;
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
            this.Sost_sotr.Width = 150;
            // 
            // BtnBack
            // 
            this.BtnBack.Depth = 0;
            this.BtnBack.Location = new System.Drawing.Point(1070, 532);
            this.BtnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Primary = true;
            this.BtnBack.Size = new System.Drawing.Size(240, 40);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "Введите имя сотрудника";
            this.txtSearch.Location = new System.Drawing.Point(279, 544);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(344, 28);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(594, 532);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(258, 40);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtNaznachDolzhn
            // 
            this.TxtNaznachDolzhn.Depth = 0;
            this.TxtNaznachDolzhn.Hint = "Укажите должность";
            this.TxtNaznachDolzhn.Location = new System.Drawing.Point(1070, 107);
            this.TxtNaznachDolzhn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNaznachDolzhn.Name = "TxtNaznachDolzhn";
            this.TxtNaznachDolzhn.PasswordChar = '\0';
            this.TxtNaznachDolzhn.SelectedText = "";
            this.TxtNaznachDolzhn.SelectionLength = 0;
            this.TxtNaznachDolzhn.SelectionStart = 0;
            this.TxtNaznachDolzhn.Size = new System.Drawing.Size(344, 28);
            this.TxtNaznachDolzhn.TabIndex = 15;
            this.TxtNaznachDolzhn.UseSystemPasswordChar = false;
            // 
            // BtnNaznachDolzhn
            // 
            this.BtnNaznachDolzhn.Depth = 0;
            this.BtnNaznachDolzhn.Location = new System.Drawing.Point(1070, 170);
            this.BtnNaznachDolzhn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNaznachDolzhn.Name = "BtnNaznachDolzhn";
            this.BtnNaznachDolzhn.Primary = true;
            this.BtnNaznachDolzhn.Size = new System.Drawing.Size(240, 40);
            this.BtnNaznachDolzhn.TabIndex = 16;
            this.BtnNaznachDolzhn.Text = "Назначить";
            this.BtnNaznachDolzhn.UseVisualStyleBackColor = true;
            this.BtnNaznachDolzhn.Click += new System.EventHandler(this.BtnNaznachDolzhn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 603);
            this.Controls.Add(this.BtnNaznachDolzhn);
            this.Controls.Add(this.TxtNaznachDolzhn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dgv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 603);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 603);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мониторинг загруженности";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBack;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNaznachDolzhn;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNaznachDolzhn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolzhn_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staj_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sost_sotr;
    }
}