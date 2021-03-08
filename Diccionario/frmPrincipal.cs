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
            // Creates a new dictionary
            String createNewTable = "create table " + txtManageDictionary.Text + "(" +
                                        "word varchar(50)," +
                                        "meaning varchar(50)" +
                                        ")";

            MySqlCommand cmd = new MySqlCommand(createNewTable, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dictionary " + txtManageDictionary.Text + " created!");
            refreshDictionaries();
        }

        private void Diccionario_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost; Database=db_dictionary; user id=usuarioDictionary; password=passwordDictionary");
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
            String diccionarioABorrar = lbAvailableDictionaries.SelectedItem.ToString();

        }
    }
}
