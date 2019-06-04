namespace Plan_B
{
    partial class Sotr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnComplete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnMakeOtchet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_vipoln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_vipoln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblResourseName = new System.Windows.Forms.Label();
            this.LblTaskName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAppointmentDate = new System.Windows.Forms.Label();
            this.LblCompletionDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Depth = 0;
            this.BtnBack.Location = new System.Drawing.Point(886, 530);
            this.BtnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Primary = true;
            this.BtnBack.Size = new System.Drawing.Size(315, 51);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnComplete
            // 
            this.BtnComplete.Depth = 0;
            this.BtnComplete.Location = new System.Drawing.Point(31, 530);
            this.BtnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Primary = true;
            this.BtnComplete.Size = new System.Drawing.Size(315, 51);
            this.BtnComplete.TabIndex = 3;
            this.BtnComplete.Text = "Завершить";
            this.BtnComplete.UseVisualStyleBackColor = true;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // BtnMakeOtchet
            // 
            this.BtnMakeOtchet.Depth = 0;
            this.BtnMakeOtchet.Location = new System.Drawing.Point(457, 530);
            this.BtnMakeOtchet.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMakeOtchet.Name = "BtnMakeOtchet";
            this.BtnMakeOtchet.Primary = true;
            this.BtnMakeOtchet.Size = new System.Drawing.Size(315, 51);
            this.BtnMakeOtchet.TabIndex = 4;
            this.BtnMakeOtchet.Text = "Сформировать отчет";
            this.BtnMakeOtchet.UseVisualStyleBackColor = true;
            this.BtnMakeOtchet.Click += new System.EventHandler(this.BtnMakeOtchet_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Data_vipoln,
            this.Status_vipoln});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dgv.Location = new System.Drawing.Point(31, 111);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1302, 319);
            this.dgv.TabIndex = 19;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
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
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name_resourse";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ресурс";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_naznach";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата назначения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // Data_vipoln
            // 
            this.Data_vipoln.HeaderText = "Дата выполнениния";
            this.Data_vipoln.Name = "Data_vipoln";
            this.Data_vipoln.ReadOnly = true;
            this.Data_vipoln.Width = 130;
            // 
            // Status_vipoln
            // 
            this.Status_vipoln.HeaderText = "Процесс выполнения";
            this.Status_vipoln.Name = "Status_vipoln";
            this.Status_vipoln.ReadOnly = true;
            this.Status_vipoln.Width = 130;
            // 
            // LblResourseName
            // 
            this.LblResourseName.AutoSize = true;
            this.LblResourseName.Location = new System.Drawing.Point(184, 628);
            this.LblResourseName.Name = "LblResourseName";
            this.LblResourseName.Size = new System.Drawing.Size(20, 17);
            this.LblResourseName.TabIndex = 21;
            this.LblResourseName.Text = "   ";
            this.LblResourseName.Visible = false;
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(236, 628);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.Size = new System.Drawing.Size(24, 17);
            this.LblTaskName.TabIndex = 22;
            this.LblTaskName.Text = "    ";
            this.LblTaskName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "    ";
            this.label2.Visible = false;
            // 
            // LblAppointmentDate
            // 
            this.LblAppointmentDate.AutoSize = true;
            this.LblAppointmentDate.Location = new System.Drawing.Point(334, 628);
            this.LblAppointmentDate.Name = "LblAppointmentDate";
            this.LblAppointmentDate.Size = new System.Drawing.Size(24, 17);
            this.LblAppointmentDate.TabIndex = 24;
            this.LblAppointmentDate.Text = "    ";
            this.LblAppointmentDate.Visible = false;
            // 
            // LblCompletionDate
            // 
            this.LblCompletionDate.AutoSize = true;
            this.LblCompletionDate.Location = new System.Drawing.Point(374, 628);
            this.LblCompletionDate.Name = "LblCompletionDate";
            this.LblCompletionDate.Size = new System.Drawing.Size(24, 17);
            this.LblCompletionDate.TabIndex = 25;
            this.LblCompletionDate.Text = "    ";
            this.LblCompletionDate.Visible = false;
            // 
            // Sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1366, 654);
            this.Controls.Add(this.LblCompletionDate);
            this.Controls.Add(this.LblAppointmentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTaskName);
            this.Controls.Add(this.LblResourseName);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.BtnMakeOtchet);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.BtnBack);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 654);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 654);
            this.Name = "Sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страница сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BtnBack;
        private MaterialSkin.Controls.MaterialRaisedButton BtnComplete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnMakeOtchet;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_vipoln;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_vipoln;
        private System.Windows.Forms.Label LblResourseName;
        private System.Windows.Forms.Label LblTaskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAppointmentDate;
        private System.Windows.Forms.Label LblCompletionDate;
    }
}