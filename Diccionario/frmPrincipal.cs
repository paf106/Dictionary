using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diccionario
{
    public partial class Diccionario : Form
    {
        MySqlConnection con;
        ArrayList dictionaries = new ArrayList();
        public Diccionario()
        {
            InitializeComponent();
        }

        public void refreshDictionaries()
        {
            lbAvailableDictionaries.Items.Clear();
            lbDictionary.Items.Clear();
            cbSearchDictionary.Items.Clear();

            String showTables = "show tables";
            MySqlCommand cmd = new MySqlCommand(showTables, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbAvailableDictionaries.Items.Add(reader[0].ToString());
                lbDictionary.Items.Add(reader[0].ToString());
                cbSearchDictionary.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        private void btnCreateDictionary_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtManageDictionary.Text.Equals(""))
                {
                    // Creates a new dictionary
                    String createNewTable = "create table " + txtManageDictionary.Text + "(" +
                                                "word varchar(50)," +
                                                "meaning varchar(50)" +
                                                ")";

                    MySqlCommand cmd = new MySqlCommand(createNewTable, con);
                    cmd.ExecuteNonQuery();

                    txtManageDictionary.Clear();

                    refreshDictionaries();
                    MessageBox.Show("Dictionary " + txtManageDictionary.Text + " created!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You must provide a dictionary name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Dictionary " + txtManageDictionary.Text + " alerady exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Diccionario_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=paf106.ddns.net; Port=9093; Database=db_dictionary; Uid=usuarioDictionary; Password=passwordDictionary;");
            try
            {
                con.Open();
                refreshDictionaries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDictionary_Click(object sender, EventArgs e)
        {
            if (lbAvailableDictionaries.SelectedItem != null)
            {
                String diccionarioABorrar = lbAvailableDictionaries.SelectedItem.ToString();
                // Deletes a dictionary
                String deleteTable = "drop table " + diccionarioABorrar;

                MySqlCommand cmd = new MySqlCommand(deleteTable, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dictionary " + diccionarioABorrar + " deleted!");
                refreshDictionaries();
            }
            else
            {
                MessageBox.Show("You must select a dictionary", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            if (lbDictionary.SelectedItem != null)
            {
                // check selected dictionary
                String selectedDictionary = lbDictionary.SelectedItem.ToString();

                // check fields are not empty
                if (!txtWord.Text.Equals("") && !txtMeaning.Text.Equals(""))
                {
                    // save the word
                    String command = "insert into " + selectedDictionary + " values ('" + txtWord.Text + "','" + txtMeaning.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Word added", "Info");
                }
                else
                {
                    MessageBox.Show("Fields cannot be blank", "Info");
                }
            }
            else
            {
                MessageBox.Show("You must select a dictionary", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvWords.Visible = true;
            DataSet dsResults = new DataSet();
            DataView dv = new DataView();
            String wordToFind = txtSearch.Text;
            String dictionaryToFind = cbSearchDictionary.SelectedItem.ToString();

            String command = "select * from " + dictionaryToFind + " where word like \'%" + wordToFind + "%\'";
            MySqlDataAdapter daWords = new MySqlDataAdapter(command, con);
            daWords.Fill(dsResults, dictionaryToFind);
            dv = dsResults.Tables[dictionaryToFind].DefaultView;
            gvWords.DataSource = dv;


        }

        private void btnEditDictionary_Click(object sender, EventArgs e)
        {
            // Nombre del diccionario a editar
            String diccionarioABorrar = lbAvailableDictionaries.SelectedItem.ToString();

            new frmEditDictionary(con, diccionarioABorrar).ShowDialog();
        }
    }
}
