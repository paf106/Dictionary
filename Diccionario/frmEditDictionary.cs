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

namespace Diccionario
{
    public partial class frmEditDictionary : Form
    {
        private MySqlConnection con;
        private String dictionaryToEdit;

        public frmEditDictionary()
        {
            InitializeComponent();
        }

        public frmEditDictionary(MySqlConnection con, String dictionaryToEdit)
        {
            InitializeComponent();
            this.con = con;
            this.dictionaryToEdit = dictionaryToEdit;
        }

        private void frmEditDictionary_Load(object sender, EventArgs e)
        {
            lbDictionaryName.Text = dictionaryToEdit;
            DataSet dsResults = new DataSet();
            DataView dv = new DataView();

            String command = "select * from " + dictionaryToEdit;
            MySqlDataAdapter daWords = new MySqlDataAdapter(command, con);
            daWords.Fill(dsResults, dictionaryToEdit);
            dv = dsResults.Tables[dictionaryToEdit].DefaultView;
            gvEditWords.DataSource = dv;
        }

        private void gvEditWords_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                foreach (DataGridViewCell oneCell in gvEditWords.SelectedCells)
                {
                    if (oneCell.Selected)
                        gvEditWords.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
            
        }
    }
}
