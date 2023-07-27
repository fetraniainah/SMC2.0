using Guna.UI2.WinForms;
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
    public partial class ListProduct : UserControl
    {
        public int ID { get; set; }
        public string ProductNames { get; set; }
        public string ProductNote { get; set; }
        public decimal ProductPrice { get; set; }

        public ListProduct()
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
        public static void LoadDataIntoDataGridView(Guna2DataGridView dataGridView)
        {
            string sql = "SELECT * FROM product ORDER BY name ASC";
            using (SQLiteCommand command = new SQLiteCommand(sql, GetConnection()))
            {
                // Exécuter la commande SQL et récupérer les données dans un objet SQLiteDataReader
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    // Ajouter chaque ligne de données dans le DataGridView
                    while (reader.Read())
                    {
                        dataGridView.Rows.Add(reader["id"], reader["name"], reader["price"], reader["note"]);
                    }
                }
            }
        }

        public static void SearchProduct(string searchTerm, DataGridView dataGridView)
        {

            // Crée une commande SQL pour récupérer les données de la table
            string sql = "SELECT * FROM product WHERE name LIKE @searchTerm OR note LIKE @searchTerm ORDER BY name ASC;";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(sql, GetConnection());
            sqlite_cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

            // Exécute la commande SQL et récupère les données dans un objet SQLiteDataReader
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();

            // Vide les lignes existantes du DataGridView
            dataGridView.Rows.Clear();

            // Ajoute chaque ligne de données dans le DataGridView
            while (reader.Read())
            {
                dataGridView.Rows.Add(reader["id"], reader["name"], reader["price"], reader["note"]);
            }

            // Ferme la connexion à la base de données
            GetConnection().Close();
        }

        public void SearchResult(string item)
        {
            guna2DataGridView1.Rows.Clear();

        }



        private void ListProduct_Load(object sender, EventArgs e)
        {
            label1.Text = "Aucun produit sélectionné";
            LoadDataIntoDataGridView(guna2DataGridView1);
        }


        public static void DeleteProduct(int productId)
        {

            // Crée une commande SQL pour supprimer la ligne correspondant à l'ID de produit donné
            string sql = "DELETE FROM product WHERE id = @id;";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(sql, GetConnection());
            sqlite_cmd.Parameters.AddWithValue("@id", productId);
            sqlite_cmd.ExecuteNonQuery();

            // Ferme la connexion à la base de données
            GetConnection().Close();
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DeleteProduct(ID);
                guna2DataGridView1.Rows.Clear();
                LoadDataIntoDataGridView(guna2DataGridView1);
                ID = 0;
                guna2CustomCheckBox1.Checked = false;
                label1.Text = "Aucun produit sélectionné";
                MessageBox.Show("Suppression effectué avec succés", "Traitement succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun produit sélectionné", "Erreur de paramètre d'entrer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    guna2DataGridView1.CurrentCell.Selected = true;
                    string name = guna2DataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                    int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString());
                    string note = guna2DataGridView1.Rows[e.RowIndex].Cells["note"].FormattedValue.ToString();


                    ID = id;
                    ProductNames = name;
                    ProductNote = note;
                    ProductPrice = price;
                    label1.Text = name;
                    if (ID != 0)
                    {
                        guna2CustomCheckBox1.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Aucun produit sélectionné ! ", "Choisissez un produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Aucun produit sélectionné ! ", "Choisissez un produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(ProductNames, ProductPrice, ProductNote, ID);
            if (ID != 0)
            {
                updateForm.ShowDialog();
                guna2CustomCheckBox1.Checked = false;
                label1.Text = "Aucun produit sélectionné";
            }
            else
            {
                MessageBox.Show("Aucun produit sélectionné ! ", "Choisissez un produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            guna2DataGridView1.Rows.Clear();
            LoadDataIntoDataGridView(guna2DataGridView1);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text))
            {
                SearchProduct(search.Text, guna2DataGridView1);
            }
            else
            {
                guna2DataGridView1.Rows.Clear();
                LoadDataIntoDataGridView(guna2DataGridView1);
            }
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
