namespace SMC2._0.View
{
    partial class AddProduct
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            priceProduct = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            detailProduct = new RichTextBox();
            nameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 0, 14);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 50);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 15);
            label1.Name = "label1";
            label1.Size = new Size(246, 24);
            label1.TabIndex = 0;
            label1.Text = "AJOUTER UN PRODUIT";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(priceProduct);
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(detailProduct);
            panel2.Controls.Add(nameProduct);
            panel2.Location = new Point(120, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 470);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(45, 209);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 12;
            label4.Text = "Détails";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(45, 114);
            label3.Name = "label3";
            label3.Size = new Size(38, 18);
            label3.TabIndex = 11;
            label3.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(45, 19);
            label2.Name = "label2";
            label2.Size = new Size(139, 18);
            label2.TabIndex = 10;
            label2.Text = "Nom du produit";
            label2.Click += label2_Click;
            // 
            // priceProduct
            // 
            priceProduct.BackColor = Color.Transparent;
            priceProduct.BorderColor = Color.FromArgb(0, 0, 64);
            priceProduct.BorderRadius = 9;
            priceProduct.CustomizableEdges = customizableEdges1;
            priceProduct.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceProduct.Location = new Point(16, 146);
            priceProduct.Margin = new Padding(4, 4, 4, 4);
            priceProduct.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            priceProduct.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            priceProduct.Name = "priceProduct";
            priceProduct.ShadowDecoration.CustomizableEdges = customizableEdges2;
            priceProduct.Size = new Size(424, 49);
            priceProduct.TabIndex = 9;
            priceProduct.UpDownButtonFillColor = Color.White;
            priceProduct.UpDownButtonForeColor = Color.Transparent;
            priceProduct.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top;
            guna2Button1.BorderRadius = 18;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Teal;
            guna2Button1.FocusedColor = Color.FromArgb(0, 192, 192);
            guna2Button1.Font = new Font("Lucida Bright", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(45, 401);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(371, 45);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Enregistrer";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // detailProduct
            // 
            detailProduct.Anchor = AnchorStyles.Top;
            detailProduct.BorderStyle = BorderStyle.None;
            detailProduct.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            detailProduct.ForeColor = Color.FromArgb(0, 0, 14);
            detailProduct.Location = new Point(16, 243);
            detailProduct.Name = "detailProduct";
            detailProduct.Size = new Size(423, 134);
            detailProduct.TabIndex = 6;
            detailProduct.Text = "Détails";
            // 
            // nameProduct
            // 
            nameProduct.Anchor = AnchorStyles.Top;
            nameProduct.BorderColor = Color.FromArgb(0, 0, 64);
            nameProduct.BorderRadius = 9;
            nameProduct.CustomizableEdges = customizableEdges5;
            nameProduct.DefaultText = "";
            nameProduct.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameProduct.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameProduct.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameProduct.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameProduct.ForeColor = Color.FromArgb(0, 0, 64);
            nameProduct.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameProduct.Location = new Point(16, 57);
            nameProduct.Margin = new Padding(4, 3, 4, 3);
            nameProduct.Name = "nameProduct";
            nameProduct.PasswordChar = '\0';
            nameProduct.PlaceholderForeColor = Color.FromArgb(0, 0, 64);
            nameProduct.PlaceholderText = "Nom du produit";
            nameProduct.SelectedText = "";
            nameProduct.ShadowDecoration.CustomizableEdges = customizableEdges6;
            nameProduct.Size = new Size(424, 45);
            nameProduct.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = detailProduct;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddProduct";
            Size = new Size(716, 587);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private RichTextBox detailProduct;
        private Guna.UI2.WinForms.Guna2TextBox nameProduct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2NumericUpDown priceProduct;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
