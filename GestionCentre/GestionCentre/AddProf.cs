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
    
    public partial class AddProf : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=gestion_centre;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dataReader;
        public AddProf()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        private void AddProf_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prof", connection);
                connection.Open();        
                DataSet ds = new DataSet();
                adapter.Fill(ds, "prof");
                dataGridView1.DataSource = ds.Tables["prof"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id.Text= dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            cin.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            nom.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            prenom.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            specialite.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }
        

       

        private void search_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                String keyword = search.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prof where id_prof LIKE '%" + keyword + "%' OR nom LIKE '%" + keyword + "%' OR prenom LIKE '%" + keyword + "%' OR CIN LIKE '%" + keyword + "%' OR specialite  LIKE '%" + keyword + "%'", connection);
                connection.Open();
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (cin.Text == "" || nom.Text == "" || prenom.Text == "" || specialite.Text == "")
            {
                MessageBox.Show("saisir tous les champs SVP !!", "champs non saisir", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {

                    command = new MySqlCommand("Insert into prof(CIN,nom,prenom,specialite) value ('" + cin.Text + "','" + nom.Text + "','" + prenom.Text + "','" + specialite.Text + "')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez ajoutez le nouveau prof avec succè", "Nouveau prof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cin.Text = ""; nom.Text = ""; prenom.Text = ""; specialite.Text = ""; id.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                try
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prof", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "prof");
                    dataGridView1.DataSource = ds.Tables["prof"];
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier ce professeur", "modifier prof", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int id_prof = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Update prof Set CIN='" + cin.Text + "', nom = '" + nom.Text + "', prenom = '" + prenom.Text + "', specialite = '" + specialite.Text + "' Where id_prof = '" + id_prof + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez modifier le nouveau prof avec succès", "Modifier prof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cin.Text = ""; nom.Text = ""; prenom.Text = ""; specialite.Text = ""; id.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Modifier prof", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                try
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prof", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "prof");
                    dataGridView1.DataSource = ds.Tables["prof"];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce professeur", "supprimer prof", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {


                try
                {
                    int id_prof = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Delete From prof where id_prof='" + id_prof + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez supprimer le nouveau prof avec succès", "Supprimer prof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cin.Text = ""; nom.Text = ""; prenom.Text = ""; specialite.Text = ""; id.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                try
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prof", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "prof");
                    dataGridView1.DataSource = ds.Tables["prof"];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            search.Text = "";
            cin.Text = ""; nom.Text = ""; prenom.Text = ""; specialite.Text = ""; id.Text = "";

        }
    }
}
