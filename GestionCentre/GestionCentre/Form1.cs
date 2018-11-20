using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCentre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void auth_Click(object sender, EventArgs e)
        {
            //double n1 = Convert.ToDouble(name.Text);
            //double n2 = Convert.ToDouble(password.Text);
            //textR.Text = (n1 + n2).ToString();
            if (name.Text == "" || password.Text == "")
            {
                MessageBox.Show("Saisir tous les champs SVP !!!");

            }
            else
            {
                if (name.Text == "admin" && password.Text == "admin")
                {
                    Accueil accueil = new Accueil();
                    accueil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("le Nom ou le Mot de passe est incorrect !!!\n Resaisir SVP");
                    name.Text = "";
                    password.Text = "";
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
