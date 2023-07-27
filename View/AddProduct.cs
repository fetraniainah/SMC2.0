using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMC2._0.View
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection Connection = null;
            if (Connection == null)
            {
                Connection = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\data.db");
                Connection.Open();
            }
            return Connection;
        }

        public static void AddProducts(string name, decimal price, string note)
        {
            // Insère une nouvelle ligne dans la table "product" avec les valeurs spécifiées
            string sql = "INSERT INTO product (name, price, note) VALUES (@name, @price, @note);";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(sql, GetConnection());
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@price", price);
            sqlite_cmd.Parameters.AddWithValue("@note", note);
            sqlite_cmd.ExecuteNonQuery();

            // Ferme la connexion à la base de données
            GetConnection().Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameProduct.Text))
            {
                if (!string.IsNullOrWhiteSpace(detailProduct.Text))
                {
                    AddProducts(nameProduct.Text, priceProduct.Value, detailProduct.Text);
                    MessageBox.Show("Vous avez ajouter " + nameProduct.Text, "Traitement effectué avec succés !  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameProduct.Clear();
                    detailProduct.Clear();
                }
                else
                {
                    MessageBox.Show("Le champ detail de produit est obligatoire", "Erreur de paramètre d'entrer !  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Le champ nom de produit est obligatoire", "Erreur de paramètre d'entrer !  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
