namespace SMC2._0.View
{
    partial class Aide
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
            panel2 = new Panel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            labelUsername = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 14);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 50);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 16);
            label1.Name = "label1";
            label1.Size = new Size(272, 24);
            label1.TabIndex = 0;
            label1.Text = "PAGE D'AIDE ET LICENCE";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(41, 66);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(645, 446);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.FromArgb(0, 0, 64);
            labelUsername.Location = new Point(21, 530);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(172, 15);
            labelUsername.TabIndex = 11;
            labelUsername.Text = "Contact : +261339157163";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(211, 530);
            label2.Name = "label2";
            label2.Size = new Size(206, 16);
            label2.TabIndex = 12;
            label2.Text = "Email : tahiri.fetra@gmail.com ";
            // 
            // Aide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(labelUsername);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Name = "Aide";
            Size = new Size(708, 561);
            Load += Aide_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label labelUsername;
        private Label label2;
    }
}
