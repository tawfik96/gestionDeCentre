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
using static GestionCentre.Formation;

namespace GestionCentre
{
    public partial class Etudiant : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=gestion_centre;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dataReader;
        public Etudiant()
        {
            InitializeComponent();
            try
            {
                ComboboxItem item;
                connection.Open();
                command = new MySqlCommand("select formation_id, nom_formation from formation", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    item = new ComboboxItem();
                    item.Text = dataReader[0] + " " + dataReader[1];
                    item.Value = dataReader[0];
                    formation.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                dataReader.Close();
            }
            try
            {
                ComboboxItem item;
                connection.Open();
                command = new MySqlCommand("select groupe_id, nom_groupe from groupe", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    item = new ComboboxItem();
                    item.Text = dataReader[0] + " " + dataReader[1];
                    item.Value = dataReader[0];
                    groupe.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            filiere.Items.Add("info");
            filiere.Items.Add("Systemes embarquées");
            filiere.Items.Add("GTR");
            niveau.Items.Add("1");
            niveau.Items.Add("2");
            niveau.Items.Add("3");

        }

        private void Etudiant_Load(object sender, EventArgs e)
        {

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

        private void Etudiant_Load_1(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM etudiant", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "etudiant");
                dataGridView1.DataSource = ds.Tables["etudiant"];
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

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || formation.SelectedItem == null || groupe.SelectedItem == null || niveau.Text == "" || filiere.Text == "")
            {
                MessageBox.Show("saisir tous les champs SVP !!", "champs non saisir", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {

                    command = new MySqlCommand("Insert into etudiant(nom,prenom,niveau,filiere) value ('" + nom.Text + "','" + prenom.Text + "','" + niveau.Text + "','" + filiere.Text + "')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    int etudiant_id = 0;


                    //MySqlDataReader dataReader;

                    command = new MySqlCommand("select max(etudiant_id) from etudiant", connection);
                    dataReader = command.ExecuteReader();

                    dataReader.Read();
                    etudiant_id = int.Parse(dataReader[0].ToString());
                    connection.Close();
                    connection.Open();
                    command = new MySqlCommand("Insert into inscription(date_inscription,formation_id,groupe_id,etudiant_id) value ('" + DateTime.Now + "','" + (formation.SelectedItem as ComboboxItem).Value.ToString() + "','" + (groupe.SelectedItem as ComboboxItem).Value.ToString() + "'," + etudiant_id + ")", connection);
                    command.ExecuteNonQuery();


                    MessageBox.Show("Vous avez ajoutez le nouveau prof avec succè", "Nouveau prof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    niveau.Text = ""; nom.Text = ""; prenom.Text = ""; filiere.Text = ""; id.Text = "";



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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM etudiant", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "etudiant");
                    dataGridView1.DataSource = ds.Tables["etudiant"];
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
            id.Text = "";
            nom.Text = "";
            prenom.Text = "";
            niveau.Text = "";
            filiere.Text = "";
            formation.SelectedItem = null;
            groupe.SelectedItem = null;
            search.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            nom.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            prenom.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            niveau.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            filiere.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            /*try
            {
                int etudiant_id = int.Parse(id.Text);
                int formation_id, groupe_id;
                connection.Open();
                command = new MySqlCommand("select formation_id,groupe_id from inscription where etudiant_id = " + etudiant_id, connection);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                formation_id = int.Parse(dataReader[0].ToString());
                groupe_id = int.Parse(dataReader[1].ToString());
                MessageBox.Show(formation.Items.ToString());
                connection.Close();
                
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce Etudiant", "supprimer Etudiant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int etudiant_id = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Delete From etudiant where etudiant_id='" + etudiant_id + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez supprimer l'Etudiant avec succès", "Supprimer Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id.Text = "";
                    nom.Text = "";
                    prenom.Text = "";
                    niveau.Text = "";
                    filiere.Text = "";
                    formation.SelectedItem = null;
                    groupe.SelectedItem = null;
                    search.Text = "";
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM etudiant", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "etudiant");
                    dataGridView1.DataSource = ds.Tables["etudiant"];
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

        private void edit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier cet Etudiant", "modifier Etudiant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int etudiant_id = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Update etudiant Set nom='" + nom.Text + "', prenom='"+ prenom.Text + "' ,niveau= '"+niveau.Text+"',filiere = '"+ filiere.Text +"' Where etudiant_id = '" + etudiant_id + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    ////////////
                    connection.Open();
                    command = new MySqlCommand("Update inscription Set formation_id='"+ (formation.SelectedItem as ComboboxItem).Value.ToString()+ "', groupe_id = '"+ (groupe.SelectedItem as ComboboxItem).Value.ToString() + "' Where etudiant_id = '" + etudiant_id + "'", connection); 
                    command.ExecuteNonQuery();
                    ///////////
                    MessageBox.Show("Vous avez modifier cet Etudiant avec succès", "Modifier Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id.Text = "";
                    nom.Text = "";
                    prenom.Text = "";
                    niveau.Text = "";
                    filiere.Text = "";
                    formation.SelectedItem = null;
                    groupe.SelectedItem = null;
                    search.Text = "";
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM etudiant", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "etudiant");
                    dataGridView1.DataSource = ds.Tables["etudiant"];
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String keyword = search.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM etudiant where etudiant_id LIKE '%" + keyword + "%' OR 	nom LIKE '%" + keyword + "%'OR prenom LIKE '%" + keyword + "%'OR niveau LIKE '%" + keyword + "%'OR filiere LIKE '%" + keyword + "%'", connection);
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
