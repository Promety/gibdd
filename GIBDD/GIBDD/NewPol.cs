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
    public partial class NewPol : Form
    {
        SqlConnection connection;
        public NewPol()
        {
            InitializeComponent();
        }
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"WIN-349MCH6R7UR",
                InitialCatalog = "KursGIBDD", //Database
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckPassportButton_Click_1(object sender, EventArgs e)
        {
            string connectionString = GetRemoteConnectionString("WIN-349MCH6R7UR", "");
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT passport_series, passport_number FROM Inspector " +
     $"WHERE passport_number = {PasssportNumberTB.Text} AND passport_series = {PassportSeriesTB.Text}", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                groupBox1.Enabled = true;
                LoginNameTB.Text = $"{PassportSeriesTB.Text}_{PasssportNumberTB.Text}";
            }
            else
            {
                MessageBox.Show("Записи о вас в базе данных не найдено! Проверьте правильность введенных данных!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }
        }

        private void RegButton_Click_1(object sender, EventArgs e)
        {
            new SqlCommand($"EXEC sp_addlogin '{LoginNameTB.Text}', '{PasswordTB.Text}', 'KursGIBDD'", connection).ExecuteNonQuery();
            new SqlCommand($"USE KursGIBDD", connection).ExecuteNonQuery();
            new SqlCommand($"EXEC sp_adduser '{LoginNameTB.Text}', '{LoginNameTB.Text}'", connection).ExecuteNonQuery();
            new SqlCommand($"EXEC sp_addrolemember 'Inspector', '{LoginNameTB.Text}'", connection).ExecuteNonQuery();
            MessageBox.Show("Регистрация прошла успешно!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }
    }
}


