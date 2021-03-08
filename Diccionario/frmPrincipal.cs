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
                // Creates a new dictionary
                String createNewTable = "create table " + txtManageDictionary.Text + "(" +
                                            "word varchar(50)," +
                                            "meaning varchar(50)" +
                                            ")";

                MySqlCommand cmd = new MySqlCommand(createNewTable, con);
                cmd.ExecuteNonQuery();
                txtManageDictionary.Clear();
                MessageBox.Show("Dictionary " + txtManageDictionary.Text + " created!");
                refreshDictionaries();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Dictionary " + txtManageDictionary.Text + " alerady exists!");
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

            String diccionarioABorrar = "";
            if (lbAvailableDictionaries.SelectedItem != null)
            {
                diccionarioABorrar = lbAvailableDictionaries.SelectedItem.ToString();
                // Deletes a dictionary
                String deleteTable = "drop table " + diccionarioABorrar;

                MySqlCommand cmd = new MySqlCommand(deleteTable, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dictionary " + diccionarioABorrar + " deleted!");
                refreshDictionaries();
            }
            else
            {
                MessageBox.Show("You must select a dictionary");
            }







        }

        private void btnSaveWord_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String wordToFind = txtSearch.Text;


        }
    }
}
