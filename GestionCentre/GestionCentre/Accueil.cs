using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GestionCentre
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

      

       

        
        
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddProf addProf = new AddProf();
            addProf.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Show();
            this.Close();
        }

        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Formation formation = new Formation();
            formation.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddGroupe addGroupe = new AddGroupe();
            addGroupe.Show();
            this.Hide();
        }
    }
}
