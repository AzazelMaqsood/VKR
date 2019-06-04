namespace Plan_B
{
    partial class Registration
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
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStaj = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(46, 532);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(118, 37);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(170, 532);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(184, 37);
            this.materialRaisedButton2.TabIndex = 19;
            this.materialRaisedButton2.Text = "Регистрация";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Hint = "Введите ваше имя";
            this.txtName.Location = new System.Drawing.Point(46, 108);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(405, 28);
            this.txtName.TabIndex = 20;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtF
            // 
            this.txtF.BackColor = System.Drawing.Color.White;
            this.txtF.Depth = 0;
            this.txtF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtF.Hint = "Введите вашу фамилию";
            this.txtF.Location = new System.Drawing.Point(46, 160);
            this.txtF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtF.Name = "txtF";
            this.txtF.PasswordChar = '\0';
            this.txtF.SelectedText = "";
            this.txtF.SelectionLength = 0;
            this.txtF.SelectionStart = 0;
            this.txtF.Size = new System.Drawing.Size(405, 28);
            this.txtF.TabIndex = 21;
            this.txtF.UseSystemPasswordChar = false;
            // 
            // txtO
            // 
            this.txtO.BackColor = System.Drawing.Color.White;
            this.txtO.Depth = 0;
            this.txtO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtO.Hint = "Введите ваше отчество";
            this.txtO.Location = new System.Drawing.Point(46, 213);
            this.txtO.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtO.Name = "txtO";
            this.txtO.PasswordChar = '\0';
            this.txtO.SelectedText = "";
            this.txtO.SelectionLength = 0;
            this.txtO.SelectionStart = 0;
            this.txtO.Size = new System.Drawing.Size(405, 28);
            this.txtO.TabIndex = 22;
            this.txtO.UseSystemPasswordChar = false;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.Depth = 0;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMail.Hint = "Введите ваш E-mail";
            this.txtMail.Location = new System.Drawing.Point(46, 267);
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(405, 28);
            this.txtMail.TabIndex = 23;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtStaj
            // 
            this.txtStaj.BackColor = System.Drawing.Color.White;
            this.txtStaj.Depth = 0;
            this.txtStaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStaj.Hint = "Укажите ваш стаж";
            this.txtStaj.Location = new System.Drawing.Point(46, 318);
            this.txtStaj.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStaj.Name = "txtStaj";
            this.txtStaj.PasswordChar = '\0';
            this.txtStaj.SelectedText = "";
            this.txtStaj.SelectionLength = 0;
            this.txtStaj.SelectionStart = 0;
            this.txtStaj.Size = new System.Drawing.Size(405, 28);
            this.txtStaj.TabIndex = 24;
            this.txtStaj.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Hint = "Придумайте логин";
            this.txtLogin.Location = new System.Drawing.Point(46, 364);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(405, 28);
            this.txtLogin.TabIndex = 25;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass.Hint = "Придумайте пароль";
            this.txtPass.Location = new System.Drawing.Point(46, 414);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(405, 28);
            this.txtPass.TabIndex = 26;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.Color.White;
            this.txtPass2.Depth = 0;
            this.txtPass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass2.Hint = "Повторите пароль";
            this.txtPass2.Location = new System.Drawing.Point(46, 464);
            this.txtPass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.SelectedText = "";
            this.txtPass2.SelectionLength = 0;
            this.txtPass2.SelectionStart = 0;
            this.txtPass2.Size = new System.Drawing.Size(405, 28);
            this.txtPass2.TabIndex = 27;
            this.txtPass2.UseSystemPasswordChar = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 594);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtStaj);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 594);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(409, 594);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                    Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtO;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStaj;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass2;
    }
}