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
    public partial class Formation : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=gestion_centre;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dataReader;
        public Formation()
        {
            InitializeComponent();
            try
            {
                ComboboxItem item;
                connection.Open();
                command = new MySqlCommand("select id_prof, nom, prenom from prof", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    item = new ComboboxItem();
                    item.Text = dataReader[0] + " " + dataReader[1] + " " + dataReader[2];
                    item.Value = dataReader[0];
                    comboBox1.Items.Add(item);

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

        private void prof_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void Formation_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM formation", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "formation");
                dataGridView1.DataSource = ds.Tables["formation"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("saisir tous les champs SVP !!", "champs non saisir", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    command = new MySqlCommand("Insert into formation(nom_formation,prof_id) value ('" + nom.Text + "','" + (comboBox1.SelectedItem as ComboboxItem).Value.ToString() + "')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez ajoutez le nouveau prof avec succè", "Nouveau prof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nom.Text = ""; comboBox1.SelectedItem = null; id.Text = "";



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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM formation", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "formation");
                    dataGridView1.DataSource = ds.Tables["formation"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int formation_id = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Update formation Set nom_formation='" + nom.Text + "', prof_id = '" + (comboBox1.SelectedItem as ComboboxItem).Value.ToString() + "' Where formation_id = '" + formation_id + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez modifier cette formation avec succès", "Modifier formation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nom.Text = "";
                    comboBox1.SelectedItem = null;
                    id.Text = "";
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM formation", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "formation");
                    dataGridView1.DataSource = ds.Tables["formation"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            comboBox1.SelectedItem = 0;//dataGridView1.Rows[rowIndex].Cells[3].Value;
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            nom.Text = "";
            comboBox1.SelectedItem = null;
            id.Text = "";
            search.Text = "";

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer cette formation", "supprimer formation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int formation_id = Convert.ToInt32(id.Text);
                    command = new MySqlCommand("Delete From formation where formation_id='" + formation_id + "'", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vous avez supprimer la formation avec succès", "Supprimer formation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nom.Text = "";
                    comboBox1.SelectedItem = null;
                    id.Text = "";
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM formation", connection);
                    connection.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "formation");
                    dataGridView1.DataSource = ds.Tables["formation"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ereur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String keyword = search.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM formation where formation_id LIKE '%" + keyword + "%' OR nom_formation LIKE '%" + keyword + "%'OR prof_id LIKE '%" + keyword + "%'", connection);
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
