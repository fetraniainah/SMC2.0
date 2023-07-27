using Guna.UI2.WinForms;
using SMC;
using SMC2._0.View;

namespace SMC2._0
{
    public partial class Form1 : Form
    {
        public int ID { set; get; }
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new ListProduct(), panel3);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new AddProduct(), panel3);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new ListProduct(), panel3);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new Profil(), panel3);
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click_1(object sender, EventArgs e)
        {
            Routeur routeur = new();
            routeur.GetUserControl(new Aide(), panel3);
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            this.Hide();
        }
    }
}