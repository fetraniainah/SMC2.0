using SMC;
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
    public partial class UpdateForm : Form
    {
        public int ID { get; set; }
        public string ProductNames { get; set; }
        public string ProductNote { get; set; }
        public decimal ProductPrice { get; set; }

        public UpdateForm(string name, decimal price, string note, int iD)
        {
            InitializeComponent();
            ID = iD;
            ProductNames = name;
            ProductNote = note;
            ProductPrice = price;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            nameProduct.Text = ProductNames;
            priceProduct.Value = ProductPrice;
            detailProduct.Text = ProductNote;
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

        public static void UpdateProduct(string name, double price, string note, int productId)
        {

            // Crée une commande SQL pour mettre à jour la ligne correspondant à l'ID de produit donné
            string sql = "UPDATE product SET name = @name, price = @price, note = @note WHERE id = @id;";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(sql, GetConnection());
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@price", price);
            sqlite_cmd.Parameters.AddWithValue("@note", note);
            sqlite_cmd.Parameters.AddWithValue("@id", productId);
            sqlite_cmd.ExecuteNonQuery();

            // Ferme la connexion à la base de données
            GetConnection().Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameProduct.Text))
            {
                if (priceProduct.Value < 1)
                {
                    MessageBox.Show("Le champ prix est invalide", "Eurreur d'entrer de paramètre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(detailProduct.Text))
                    {
                        UpdateProduct(nameProduct.Text, (double)priceProduct.Value, detailProduct.Text, ID);
                        MessageBox.Show("Votre modification est effectué avec succés !", "Traitement succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Le champ detail de produit est obligatoire", "Eurreur d'entrer de paramètre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

            }
            else
            {
                MessageBox.Show("Le champ Nom du produit est obligatoire", "Eurreur d'entrer de paramètre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
