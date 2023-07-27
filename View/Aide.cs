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
    public partial class Aide : UserControl
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void Aide_Load(object sender, EventArgs e)
        {
            string filePath = "licence.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    richTextBox1.Text += line + "\n";
                }
            }

        }
    }
}
