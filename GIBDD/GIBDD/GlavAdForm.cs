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
    public partial class GlavAdForm : Form
    {
        //GlavAdForm glavAdForm;
        private SqlConnection connection;
        private RegForm regForm;
        
            
        public GlavAdForm(SqlConnection connection, RegForm regForm, string v1, string v2,string Lastname, string Firstname, string Patr)
        {
            this.connection = connection;
            this.regForm = regForm;
            InitializeComponent();
            FioLabel.Text = Lastname + " " + Firstname + " " + Patr;
        }
        
        
        public DataSet GetFilledDataSet(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
        public void RefreshOffenderDGV() => OffenderDGV.DataSource = GetFilledDataSet("EXEC DisplayOffender").Tables[0];
        public void RefreshCarDGV() => CarDGV.DataSource = GetFilledDataSet("EXEC DisplayCar").Tables[0];
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GlavAdForm_Load(object sender, EventArgs e)
        {
            RefreshOffenderDGV();
            RefreshCarDGV();
            //RefreshOffenseDGV();
            //RefreshProtocolDGV();
            //RefreshPaymentDGV();
            InitializeComponent();
            //label1.Text = "
        }

        private void NewProtocolButton_Click(object sender, EventArgs e)
        {
            DobOffender newForm = new DobOffender();
            newForm.Show();
            
            
        }
    }
}
