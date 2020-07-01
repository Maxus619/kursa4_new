namespace kursa4_new
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pAuth = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbWork = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pSelect = new System.Windows.Forms.Panel();
            this.pSell = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnLek = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.uiReg2 = new kursa4_new.UIReg();
            this.uiGraph1 = new kursa4_new.UIGraph();
            this.uiLek1 = new kursa4_new.UILek();
            this.uiSell1 = new kursa4_new.UISell();
            this.panel1.SuspendLayout();
            this.pAuth.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pAuth);
            this.panel1.Controls.Add(this.pSelect);
            this.panel1.Controls.Add(this.pSell);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.btnGraph);
            this.panel1.Controls.Add(this.btnLek);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 476);
            this.panel1.TabIndex = 0;
            // 
            // pAuth
            // 
            this.pAuth.BackColor = System.Drawing.Color.Gainsboro;
            this.pAuth.Controls.Add(this.panel3);
            this.pAuth.Location = new System.Drawing.Point(-4, 20);
            this.pAuth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAuth.Name = "pAuth";
            this.pAuth.Size = new System.Drawing.Size(865, 455);
            this.pAuth.TabIndex = 6;
            this.pAuth.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cbWork);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.mtbPass);
            this.panel3.Controls.Add(this.tbLogin);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(256, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 318);
            this.panel3.TabIndex = 8;
            // 
            // cbWork
            // 
            this.cbWork.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWork.FormattingEnabled = true;
            this.cbWork.Items.AddRange(new object[] {
            "Провизор",
            "Фармацевт"});
            this.cbWork.Location = new System.Drawing.Point(168, 82);
            this.cbWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(161, 30);
            this.cbWork.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 54);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.89474F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Авторизация";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(129, 258);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 38);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // mtbPass
            // 
            this.mtbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPass.Location = new System.Drawing.Point(168, 188);
            this.mtbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.Size = new System.Drawing.Size(161, 29);
            this.mtbPass.TabIndex = 8;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(168, 143);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogin.MaxLength = 14;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(161, 30);
            this.tbLogin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // pSelect
            // 
            this.pSelect.BackColor = System.Drawing.Color.White;
            this.pSelect.Location = new System.Drawing.Point(0, 134);
            this.pSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSelect.Name = "pSelect";
            this.pSelect.Size = new System.Drawing.Size(11, 47);
            this.pSelect.TabIndex = 3;
            // 
            // pSell
            // 
            this.pSell.Location = new System.Drawing.Point(161, 27);
            this.pSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSell.Name = "pSell";
            this.pSell.Size = new System.Drawing.Size(723, 449);
            this.pSell.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(0, 430);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 47);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "   Выйти";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Firebrick;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReg.Location = new System.Drawing.Point(0, 274);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(163, 47);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "   Работники";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.Firebrick;
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGraph.Location = new System.Drawing.Point(0, 228);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(163, 47);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "   График";
            this.btnGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnLek
            // 
            this.btnLek.BackColor = System.Drawing.Color.Firebrick;
            this.btnLek.FlatAppearance.BorderSize = 0;
            this.btnLek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLek.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLek.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLek.Location = new System.Drawing.Point(0, 181);
            this.btnLek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLek.Name = "btnLek";
            this.btnLek.Size = new System.Drawing.Size(163, 47);
            this.btnLek.TabIndex = 2;
            this.btnLek.Text = "   Лекарства";
            this.btnLek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLek.UseVisualStyleBackColor = false;
            this.btnLek.Click += new System.EventHandler(this.btnLek_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.IndianRed;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSell.Location = new System.Drawing.Point(0, 134);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(163, 47);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "   Продажа";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(161, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 21);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(655, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(23, 21);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uiReg2
            // 
            this.uiReg2.Location = new System.Drawing.Point(161, 22);
            this.uiReg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiReg2.Name = "uiReg2";
            this.uiReg2.Size = new System.Drawing.Size(677, 455);
            this.uiReg2.TabIndex = 9;
            // 
            // uiGraph1
            // 
            this.uiGraph1.Location = new System.Drawing.Point(161, 21);
            this.uiGraph1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiGraph1.Name = "uiGraph1";
            this.uiGraph1.Size = new System.Drawing.Size(677, 455);
            this.uiGraph1.TabIndex = 5;
            // 
            // uiLek1
            // 
            this.uiLek1.Location = new System.Drawing.Point(161, 21);
            this.uiLek1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiLek1.Name = "uiLek1";
            this.uiLek1.Size = new System.Drawing.Size(677, 455);
            this.uiLek1.TabIndex = 3;
            // 
            // uiSell1
            // 
            this.uiSell1.Location = new System.Drawing.Point(161, 21);
            this.uiSell1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiSell1.Name = "uiSell1";
            this.uiSell1.Size = new System.Drawing.Size(683, 446);
            this.uiSell1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 476);
            this.Controls.Add(this.uiReg2);
            this.Controls.Add(this.uiGraph1);
            this.Controls.Add(this.uiLek1);
            this.Controls.Add(this.uiSell1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.pAuth.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnLek;
        private System.Windows.Forms.Panel pSell;
        private System.Windows.Forms.Panel pSelect;
        private UISell uiSell1;
        private UILek uiLek1;
        private UIReg uiReg1;
        private UIGraph uiGraph1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pAuth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.ComboBox cbWork;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label4;
        private UIReg uiReg2;
    }
}

