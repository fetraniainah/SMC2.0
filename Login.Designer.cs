namespace SMC2._0
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            guna2CirclePictureBox5 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            username = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox5
            // 
            guna2CirclePictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CirclePictureBox5.Image = Properties.Resources.annuler_64;
            guna2CirclePictureBox5.ImageRotate = 0F;
            guna2CirclePictureBox5.Location = new Point(845, 5);
            guna2CirclePictureBox5.Name = "guna2CirclePictureBox5";
            guna2CirclePictureBox5.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox5.Size = new Size(28, 28);
            guna2CirclePictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox5.TabIndex = 9;
            guna2CirclePictureBox5.TabStop = false;
            guna2CirclePictureBox5.Click += guna2CirclePictureBox5_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(username);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(128, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 407);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top;
            guna2Button1.BorderRadius = 18;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Teal;
            guna2Button1.FocusedColor = Color.FromArgb(0, 192, 192);
            guna2Button1.Font = new Font("Lucida Bright", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(114, 342);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button1.Size = new Size(371, 49);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Se connecter";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top;
            password.BackColor = Color.White;
            password.BorderColor = Color.FromArgb(0, 192, 192);
            password.BorderRadius = 10;
            password.CustomizableEdges = customizableEdges4;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FillColor = Color.FromArgb(224, 224, 224);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(0, 0, 14);
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.IconRight = Properties.Resources._lock;
            password.Location = new Point(81, 263);
            password.Margin = new Padding(4, 3, 4, 3);
            password.Name = "password";
            password.PasswordChar = '●';
            password.PlaceholderForeColor = Color.Teal;
            password.PlaceholderText = "Mot de passe";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges5;
            password.Size = new Size(423, 51);
            password.TabIndex = 5;
            password.TextAlign = HorizontalAlignment.Center;
            password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top;
            username.BackColor = Color.White;
            username.BorderColor = Color.FromArgb(0, 192, 192);
            username.BorderRadius = 10;
            username.CustomizableEdges = customizableEdges6;
            username.DefaultText = "";
            username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username.FillColor = Color.FromArgb(224, 224, 224);
            username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            username.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.FromArgb(0, 0, 14);
            username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            username.IconRight = Properties.Resources.user__1_;
            username.Location = new Point(81, 169);
            username.Margin = new Padding(4, 3, 4, 3);
            username.Name = "username";
            username.PasswordChar = '\0';
            username.PlaceholderForeColor = Color.Teal;
            username.PlaceholderText = "Nom d'utilisateur";
            username.SelectedText = "";
            username.ShadowDecoration.CustomizableEdges = customizableEdges7;
            username.Size = new Size(423, 52);
            username.TabIndex = 4;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.user__1_;
            pictureBox1.Location = new Point(243, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 524);
            Controls.Add(panel1);
            Controls.Add(guna2CirclePictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox5;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}