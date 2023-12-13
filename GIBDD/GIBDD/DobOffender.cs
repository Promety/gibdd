using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIBDD
{
    public partial class DobOffender : Form
    {
        private SqlConnection connection;
        private RegForm regForm;
        public DobOffender()
        {     
        InitializeComponent();
        }
       
        public DobOffender(SqlConnection connection, RegForm regForm, string v1, string v2, string Lastname, string Firstname, string Patr)
        {
            this.connection = connection;
            this.regForm = regForm;
            InitializeComponent();
            Fiolable.Text = Lastname + " " + Firstname + " " + Patr;
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
