using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SMC2._0.View
{
    public partial class Profil : UserControl
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(passwordNow.Text))
            {
                if (passwordNow.Text == File.ReadAllText("password.txt"))
                {
                    if (!string.IsNullOrWhiteSpace(passwordNew.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(guna2TextBox1.Text))
                        {
                            File.WriteAllText("username.txt", guna2TextBox1.Text);
                            File.WriteAllText("password.txt", passwordNew.Text);
                            MessageBox.Show("Vous avez changé votre profil ! ", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Veillez renseigner le nom d'utilisateur ! ", "Erreur de paramètre d'entrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veillez renseigner le nouveau mot de passe ! ", "Erreur de paramètre d'entrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Le mot de passe ne correspond pas ! ", "Erreur de paramètre d'entrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veillez renseigner le mot de passe actuelle ! ", "Erreur de paramètre d'entrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
