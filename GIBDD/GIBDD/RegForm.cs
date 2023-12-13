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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"WIN-349MCH6R7UR",
                InitialCatalog = "KursGIBDD", //Database
                IntegratedSecurity = false,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }
             
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string login = LoginNameTB.Text;
            string password = PasswordTB.Text;
            string connectionString = GetRemoteConnectionString(login, password);
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (Convert.ToInt32(new SqlCommand("SELECT IS_MEMBER('Inspector')", connection).ExecuteScalar()) ==1)
                {
                    string[] passport = LoginNameTB.Text.Split('_');
                    
                    var Lastname = new SqlCommand($"Select last_name from [Inspector] where passport_series = {passport[0]} and passport_number = {passport[1]}", connection).ExecuteScalar();
                    var Firstname = new SqlCommand($"Select first_name from [Inspector] where passport_series = {passport[0]} and passport_number = {passport[1]}", connection).ExecuteScalar();
                    var Patr = new SqlCommand($"Select patronymic from [Inspector] where passport_series = {passport[0]} and passport_number = {passport[1]}", connection).ExecuteScalar();
                    var b = new GlavAdForm(connection, this, passport[0], passport[1], (string)Lastname , (string)Firstname, (string)Patr);
                    var d = new DobOffender(connection, this, passport[0], passport[1], (string)Lastname, (string)Firstname, (string)Patr);

                    b.Show();
                   
                    this.Hide();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Введенные данные неверны! Проверьте правильность введенных логина и/или пароля!", "Ошибка входа", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RegistrationButton_Click_1(object sender, EventArgs e)
        {
            new NewPol().Show();
        }
    }
}
