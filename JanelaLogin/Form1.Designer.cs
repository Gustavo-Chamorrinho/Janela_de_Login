namespace JanelaLogin
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
            UsuLogin = new TextBox();
            UsuSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // UsuLogin
            // 
            UsuLogin.Anchor = AnchorStyles.None;
            UsuLogin.Location = new Point(279, 145);
            UsuLogin.Multiline = true;
            UsuLogin.Name = "UsuLogin";
            UsuLogin.Size = new Size(239, 33);
            UsuLogin.TabIndex = 1;
            UsuLogin.TextChanged += UsuLogin_TextChanged;
            // 
            // UsuSenha
            // 
            UsuSenha.Anchor = AnchorStyles.None;
            UsuSenha.Location = new Point(279, 237);
            UsuSenha.Multiline = true;
            UsuSenha.Name = "UsuSenha";
            UsuSenha.PasswordChar = '*';
            UsuSenha.Size = new Size(239, 33);
            UsuSenha.TabIndex = 2;
            UsuSenha.TextChanged += UsuSenha_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(279, 122);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "E-MAIL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(279, 214);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "SENHA";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(313, 294);
            button1.Name = "button1";
            button1.Size = new Size(159, 61);
            button1.TabIndex = 5;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(313, 376);
            button2.Name = "button2";
            button2.Size = new Size(159, 41);
            button2.TabIndex = 6;
            button2.Text = "CADASTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 529);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsuSenha);
            Controls.Add(UsuLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APROVE RECEITAS LOGIN";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UsuLogin;
        private TextBox UsuSenha;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}