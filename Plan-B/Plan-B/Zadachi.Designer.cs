namespace Plan_B
{
    partial class Zadachi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.Id_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolzhn_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staj_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtOpisZadacha = new System.Windows.Forms.TextBox();
            this.TxtNameZadacha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNameResourse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNameSotr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnFreeSotr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAllSotr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdSotr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AllowUserToResizeColumns = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.BackgroundColor = System.Drawing.Color.White;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_sotr,
            this.F_sotr,
            this.Name_sotr,
            this.O_sotr,
            this.Dolzhn_sotr,
            this.Staj_sotr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.DGV1.Location = new System.Drawing.Point(37, 131);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV1.Size = new System.Drawing.Size(991, 239);
            this.DGV1.TabIndex = 17;
            this.DGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellClick);
            // 
            // Id_sotr
            // 
            this.Id_sotr.DataPropertyName = "Id_sotr";
            this.Id_sotr.HeaderText = "Код";
            this.Id_sotr.Name = "Id_sotr";
            this.Id_sotr.ReadOnly = true;
            this.Id_sotr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_sotr.Width = 50;
            // 
            // F_sotr
            // 
            this.F_sotr.DataPropertyName = "F_sotr";
            this.F_sotr.HeaderText = "Фамилия";
            this.F_sotr.Name = "F_sotr";
            this.F_sotr.ReadOnly = true;
            this.F_sotr.Width = 130;
            // 
            // Name_sotr
            // 
            this.Name_sotr.DataPropertyName = "I_sotr";
            this.Name_sotr.HeaderText = "Имя";
            this.Name_sotr.Name = "Name_sotr";
            this.Name_sotr.ReadOnly = true;
            this.Name_sotr.Width = 130;
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
            this.Dolzhn_sotr.Width = 150;
            // 
            // Staj_sotr
            // 
            this.Staj_sotr.DataPropertyName = "Staj_sotr";
            this.Staj_sotr.HeaderText = "Стаж";
            this.Staj_sotr.Name = "Staj_sotr";
            this.Staj_sotr.ReadOnly = true;
            this.Staj_sotr.Width = 150;
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.AllowUserToResizeColumns = false;
            this.DGV2.AllowUserToResizeRows = false;
            this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV2.BackgroundColor = System.Drawing.Color.White;
            this.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.DGV2.Location = new System.Drawing.Point(37, 433);
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV2.Size = new System.Drawing.Size(1292, 210);
            this.DGV2.TabIndex = 18;
            this.DGV2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV2_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_postavl_zadachi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_zadacha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Задача";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opis_zadacha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 275;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name_resourse";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ресурс";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_naznach";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата назначения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data_vipoln";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата завершения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status_vipoln";
            this.dataGridViewTextBoxColumn6.HeaderText = "Статус выполнения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // TxtOpisZadacha
            // 
            this.TxtOpisZadacha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtOpisZadacha.ForeColor = System.Drawing.Color.Black;
            this.TxtOpisZadacha.Location = new System.Drawing.Point(111, 747);
            this.TxtOpisZadacha.Multiline = true;
            this.TxtOpisZadacha.Name = "TxtOpisZadacha";
            this.TxtOpisZadacha.Size = new System.Drawing.Size(714, 66);
            this.TxtOpisZadacha.TabIndex = 19;
            // 
            // TxtNameZadacha
            // 
            this.TxtNameZadacha.Depth = 0;
            this.TxtNameZadacha.Hint = "Введите название задачи";
            this.TxtNameZadacha.Location = new System.Drawing.Point(111, 695);
            this.TxtNameZadacha.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNameZadacha.Name = "TxtNameZadacha";
            this.TxtNameZadacha.PasswordChar = '\0';
            this.TxtNameZadacha.SelectedText = "";
            this.TxtNameZadacha.SelectionLength = 0;
            this.TxtNameZadacha.SelectionStart = 0;
            this.TxtNameZadacha.Size = new System.Drawing.Size(359, 28);
            this.TxtNameZadacha.TabIndex = 20;
            this.TxtNameZadacha.UseSystemPasswordChar = false;
            // 
            // TxtNameResourse
            // 
            this.TxtNameResourse.Depth = 0;
            this.TxtNameResourse.Hint = "Введите название ресурса";
            this.TxtNameResourse.Location = new System.Drawing.Point(111, 839);
            this.TxtNameResourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNameResourse.Name = "TxtNameResourse";
            this.TxtNameResourse.PasswordChar = '\0';
            this.TxtNameResourse.SelectedText = "";
            this.TxtNameResourse.SelectionLength = 0;
            this.TxtNameResourse.SelectionStart = 0;
            this.TxtNameResourse.Size = new System.Drawing.Size(359, 28);
            this.TxtNameResourse.TabIndex = 22;
            this.TxtNameResourse.UseSystemPasswordChar = false;
            // 
            // TxtNameSotr
            // 
            this.TxtNameSotr.Depth = 0;
            this.TxtNameSotr.Hint = "Имя сотрудника";
            this.TxtNameSotr.Location = new System.Drawing.Point(598, 839);
            this.TxtNameSotr.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNameSotr.Name = "TxtNameSotr";
            this.TxtNameSotr.PasswordChar = '\0';
            this.TxtNameSotr.SelectedText = "";
            this.TxtNameSotr.SelectionLength = 0;
            this.TxtNameSotr.SelectionStart = 0;
            this.TxtNameSotr.Size = new System.Drawing.Size(227, 28);
            this.TxtNameSotr.TabIndex = 23;
            this.TxtNameSotr.UseSystemPasswordChar = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.Location = new System.Drawing.Point(1159, 747);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(170, 35);
            this.BtnAdd.TabIndex = 24;
            this.BtnAdd.Text = "Назначить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Depth = 0;
            this.BtnUpdate.Location = new System.Drawing.Point(1159, 798);
            this.BtnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Primary = true;
            this.BtnUpdate.Size = new System.Drawing.Size(170, 35);
            this.BtnUpdate.TabIndex = 25;
            this.BtnUpdate.Text = "Обновить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDel
            // 
            this.BtnDel.Depth = 0;
            this.BtnDel.Location = new System.Drawing.Point(1159, 849);
            this.BtnDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Primary = true;
            this.BtnDel.Size = new System.Drawing.Size(170, 35);
            this.BtnDel.TabIndex = 26;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // BtnFreeSotr
            // 
            this.BtnFreeSotr.Depth = 0;
            this.BtnFreeSotr.Location = new System.Drawing.Point(1054, 131);
            this.BtnFreeSotr.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnFreeSotr.Name = "BtnFreeSotr";
            this.BtnFreeSotr.Primary = true;
            this.BtnFreeSotr.Size = new System.Drawing.Size(275, 35);
            this.BtnFreeSotr.TabIndex = 27;
            this.BtnFreeSotr.Text = "Свободные сотрудники";
            this.BtnFreeSotr.UseVisualStyleBackColor = true;
            this.BtnFreeSotr.Click += new System.EventHandler(this.BtnFreeSotr_Click);
            // 
            // BtnAllSotr
            // 
            this.BtnAllSotr.Depth = 0;
            this.BtnAllSotr.Location = new System.Drawing.Point(1054, 191);
            this.BtnAllSotr.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAllSotr.Name = "BtnAllSotr";
            this.BtnAllSotr.Primary = true;
            this.BtnAllSotr.Size = new System.Drawing.Size(275, 35);
            this.BtnAllSotr.TabIndex = 28;
            this.BtnAllSotr.Text = "Все сотрудники";
            this.BtnAllSotr.UseVisualStyleBackColor = true;
            this.BtnAllSotr.Click += new System.EventHandler(this.BtnAllSotr_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(37, 378);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1290, 1);
            this.materialDivider1.TabIndex = 29;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Список сотрудников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Список задач";
            // 
            // TxtIdSotr
            // 
            this.TxtIdSotr.Depth = 0;
            this.TxtIdSotr.Hint = "Код";
            this.TxtIdSotr.Location = new System.Drawing.Point(842, 839);
            this.TxtIdSotr.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdSotr.Name = "TxtIdSotr";
            this.TxtIdSotr.PasswordChar = '\0';
            this.TxtIdSotr.SelectedText = "";
            this.TxtIdSotr.SelectionLength = 0;
            this.TxtIdSotr.SelectionStart = 0;
            this.TxtIdSotr.Size = new System.Drawing.Size(62, 28);
            this.TxtIdSotr.TabIndex = 33;
            this.TxtIdSotr.UseSystemPasswordChar = false;
            this.TxtIdSotr.Visible = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Depth = 0;
            this.BtnBack.Location = new System.Drawing.Point(1052, 261);
            this.BtnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Primary = true;
            this.BtnBack.Size = new System.Drawing.Size(275, 35);
            this.BtnBack.TabIndex = 34;
            this.BtnBack.Text = "В главное меню";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Zadachi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 892);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtIdSotr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.BtnAllSotr);
            this.Controls.Add(this.BtnFreeSotr);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtNameSotr);
            this.Controls.Add(this.TxtNameResourse);
            this.Controls.Add(this.TxtNameZadacha);
            this.Controls.Add(this.TxtOpisZadacha);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.DGV1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 892);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 892);
            this.Name = "Zadachi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задачи";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.TextBox TxtOpisZadacha;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNameZadacha;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNameResourse;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNameSotr;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton BtnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnFreeSotr;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAllSotr;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolzhn_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staj_sotr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdSotr;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBack;
    }
}