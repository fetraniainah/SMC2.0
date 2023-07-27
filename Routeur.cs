using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC
{
    internal class Routeur
    {

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

        private UserControl childForm = null;
        public  void GetUserControl(UserControl childForm, Panel childPanel)
        {
            if (this.childForm != null)
                if (this.childForm != null)
                {
                    this.childForm.Visible = false;
                }

            this.childForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Visible = true;
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


    }
}
