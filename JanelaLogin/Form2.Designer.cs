namespace JanelaLogin
{
    partial class Form2
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
            UsuCad = new TextBox();
            SenhaCad = new TextBox();
            ConfirnCad = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // UsuCad
            // 
            UsuCad.Anchor = AnchorStyles.None;
            UsuCad.Location = new Point(301, 137);
            UsuCad.Multiline = true;
            UsuCad.Name = "UsuCad";
            UsuCad.Size = new Size(239, 36);
            UsuCad.TabIndex = 2;
            UsuCad.TextChanged += UsuCad_TextChanged;
            // 
            // SenhaCad
            // 
            SenhaCad.Anchor = AnchorStyles.None;
            SenhaCad.Location = new Point(301, 225);
            SenhaCad.Multiline = true;
            SenhaCad.Name = "SenhaCad";
            SenhaCad.PasswordChar = '*';
            SenhaCad.Size = new Size(239, 36);
            SenhaCad.TabIndex = 3;
            // 
            // ConfirnCad
            // 
            ConfirnCad.Anchor = AnchorStyles.None;
            ConfirnCad.Location = new Point(301, 313);
            ConfirnCad.Multiline = true;
            ConfirnCad.Name = "ConfirnCad";
            ConfirnCad.PasswordChar = '*';
            ConfirnCad.Size = new Size(239, 36);
            ConfirnCad.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(429, 378);
            button1.Name = "button1";
            button1.Size = new Size(111, 55);
            button1.TabIndex = 6;
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
            button2.Location = new Point(301, 378);
            button2.Name = "button2";
            button2.Size = new Size(110, 55);
            button2.TabIndex = 7;
            button2.Text = "CADASTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(301, 114);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "E-MAIL";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(301, 202);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "SENHA";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(301, 290);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 10;
            label3.Text = "CINFIRMAR SENHA";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 520);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ConfirnCad);
            Controls.Add(SenhaCad);
            Controls.Add(UsuCad);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APROVE RECEITAS CADASTRO";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UsuCad;
        private TextBox SenhaCad;
        private TextBox ConfirnCad;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}