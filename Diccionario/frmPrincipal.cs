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
using System.Data.OleDb;

namespace Diccionario
{
    public partial class Diccionario : Form
    {
        private IDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Diccionario.mdb");
        public Diccionario()
        {
            InitializeComponent();
        }

        public void refreshDictionaries()
        {

        }
        private void btnCreateDictionary_Click(object sender, EventArgs e)
        {
            // Creates a new dictionary
            string createNewTable = "create table "+ txtManageDictionary.Text +"(" +
                                        "word text(50)," +
                                        "meaning text(50)" +
                                        ")";
            OleDbCommand cmd = new OleDbCommand(createNewTable, (OleDbConnection)con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dictionary " + txtManageDictionary.Text + " created!");


        }

        private void Diccionario_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
