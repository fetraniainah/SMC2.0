using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMC2._0
{
    public partial class Login : Form
    {
        public string _username;
        public string _password;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string usernameFile = "username.txt";
            string passwordFile = "password.txt";

            if (File.Exists(usernameFile))
            {
                this._username = File.ReadAllText(usernameFile);
                
            }
            else
            {
                using (StreamWriter fichier = File.CreateText(usernameFile))
                {
                    fichier.WriteLine("username");
                }
                MessageBox.Show("Le fichier d'utilisateur a été créé.");
            }

            if (File.Exists(passwordFile))
            {
                this._password = File.ReadAllText(passwordFile);
            }
            else
            {
                using (StreamWriter fichier = File.CreateText(passwordFile))
                {
                    fichier.WriteLine("password");
                }
                MessageBox.Show("Le fichier de mot de passe a été créé.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Veuillez renseigner le nom d'utilisateur !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Veuillez renseigner le mot de passe !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (username.Text != _username)
                {
                    MessageBox.Show("Nom d'utilisateur incorrect !","Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Text != _password)
                {
                    MessageBox.Show("Mot de passe incorrect !", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
