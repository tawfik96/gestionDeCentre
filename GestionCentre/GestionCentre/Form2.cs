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
    public partial class AddGroupe : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=gestion_centre;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dataReader;
        public AddGroupe()
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
       
        private void AddGroupe_Load(object sender, EventArgs e)
        {

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM groupe", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "groupe");
                dataGridView1.DataSource = ds.Tables["groupe"];
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

       

        private void edit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier ce groupe", "modifier groupe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int id_groupe = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Update groupe Set nom_groupe='" + nom.Text + "' Where groupe_id = '" + id_groupe + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez modifier le nouveau prof avec succès", "Modifier prof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nom.Text = ""; id.Text = "";



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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM groupe", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "groupe");
                    dataGridView1.DataSource = ds.Tables["groupe"];

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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            nom.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce groupe", "supprimer groupe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {


                try
                {
                    int groupe_id = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Delete From groupe where groupe_id='" + groupe_id + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez supprimer ce groupe avec succès", "Supprimer groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  nom.Text = ""; id.Text = "";



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

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM groupe", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "groupe");
                    dataGridView1.DataSource = ds.Tables["groupe"];
                    
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

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.Text == "")
            {
                MessageBox.Show("saisir tous les champs SVP !!", "champs non saisir", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    command = new MySqlCommand("Insert into groupe(nom_groupe) value ('" + nom.Text + "')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez ajoutez le nouveau groupe avec succès", "Nouveau groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nom.Text = ""; id.Text = "";



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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM groupe", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "groupe");
                    dataGridView1.DataSource = ds.Tables["groupe"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            id.Text = "";
            search.Text = "";

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String keyword = search.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM groupe where groupe_id LIKE '%" + keyword + "%' OR nom_groupe LIKE '%" + keyword + "%'", connection);
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
    }
}
