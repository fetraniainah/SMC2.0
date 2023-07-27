namespace SMC2._0.View
{
    partial class ListProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            search = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 0, 14);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2CustomCheckBox1);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(guna2CirclePictureBox3);
            panel1.Controls.Add(search);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 18);
            label1.Name = "label1";
            label1.Size = new Size(154, 17);
            label1.TabIndex = 8;
            label1.Text = "Produit selectionné";
            // 
            // guna2CustomCheckBox1
            // 
            guna2CustomCheckBox1.BackColor = Color.FromArgb(224, 224, 224);
            guna2CustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            guna2CustomCheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CustomCheckBox1.CustomizableEdges = customizableEdges1;
            guna2CustomCheckBox1.Enabled = false;
            guna2CustomCheckBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CustomCheckBox1.ForeColor = Color.Cyan;
            guna2CustomCheckBox1.Location = new Point(95, 12);
            guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            guna2CustomCheckBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomCheckBox1.Size = new Size(26, 26);
            guna2CustomCheckBox1.TabIndex = 7;
            guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            guna2CustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            guna2CustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CustomCheckBox1.Click += guna2CustomCheckBox1_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.edit__3_;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(51, 10);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(28, 28);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 6;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // guna2CirclePictureBox3
            // 
            guna2CirclePictureBox3.Image = Properties.Resources.delete;
            guna2CirclePictureBox3.ImageRotate = 0F;
            guna2CirclePictureBox3.Location = new Point(11, 11);
            guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox3.Size = new Size(28, 28);
            guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox3.TabIndex = 5;
            guna2CirclePictureBox3.TabStop = false;
            guna2CirclePictureBox3.Click += guna2CirclePictureBox3_Click;
            // 
            // search
            // 
            search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search.BorderRadius = 13;
            search.CustomizableEdges = customizableEdges5;
            search.DefaultText = "";
            search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search.FillColor = Color.FromArgb(224, 224, 224);
            search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.FromArgb(0, 0, 14);
            search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search.IconRight = Properties.Resources.magnifying_glass;
            search.Location = new Point(303, 9);
            search.Name = "search";
            search.PasswordChar = '\0';
            search.PlaceholderForeColor = Color.Gray;
            search.PlaceholderText = "Rechercher .....";
            search.SelectedText = "";
            search.ShadowDecoration.CustomizableEdges = customizableEdges6;
            search.Size = new Size(432, 32);
            search.TabIndex = 4;
            search.TextChanged += search_TextChanged;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.AllowUserToResizeColumns = false;
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Lucida Fax", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 44;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, price, note });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(17, 71);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle7.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 44;
            guna2DataGridView1.RowTemplate.Height = 45;
            guna2DataGridView1.ShowRowErrors = false;
            guna2DataGridView1.Size = new Size(704, 384);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 44;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 45;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = guna2DataGridView1;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // name
            // 
            dataGridViewCellStyle3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 64);
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "Nom du produit";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            // 
            // price
            // 
            dataGridViewCellStyle4.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 0, 64);
            price.DefaultCellStyle = dataGridViewCellStyle4;
            price.HeaderText = "Prix unitaire";
            price.Name = "price";
            price.ReadOnly = true;
            price.Resizable = DataGridViewTriState.False;
            // 
            // note
            // 
            dataGridViewCellStyle5.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 0, 64);
            note.DefaultCellStyle = dataGridViewCellStyle5;
            note.HeaderText = "Détails";
            note.Name = "note";
            note.ReadOnly = true;
            note.Resizable = DataGridViewTriState.False;
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel1);
            Name = "ListProduct";
            Size = new Size(745, 468);
            Load += ListProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn note;
    }
}
