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

namespace Personalmanager
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            LoadRoles();
            LoadStores();
        }
        
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server = .; Database = ProjektarbeteDB; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "INSERT INTO Employees(FirstName, LastName, Email, OnLeave, Role, Salary, Birthdate, Store) VALUES (@FirstName, @LastName, @Email, @OnLeave, @Role, @Salary, @Birthdate, @Store);";
                SqlCommand saveUserCmd = new SqlCommand(query, connection);

                connection.Open();

                bool onleave = boxOnleave.Checked;

                decimal salary;

                string firstName = boxFirstname.Text;

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    MessageBox.Show("Please enter a first name.");
                    return;
                }
                string lastName = boxLastname.Text;
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Please enter a last name.");
                }

                foreach (char c in firstName)
                {
                    bool isIt = char.IsDigit(c);
                    if (isIt)
                    {
                        MessageBox.Show("Your names cant contain numbers.");
                        return;
                    }
                }

                foreach (char c in lastName)
                {
                    bool isIt = char.IsDigit(c);
                    if (isIt)
                    {
                        MessageBox.Show("Your names cant contain numbers.");
                        return;
                    }
                }

                string email = boxEmail.Text;
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter an email adress.");
                    return;
                }
                if (!email.Contains("@"))
                {
                    MessageBox.Show("You need a @ sign.");
                    return;
                }
                if (!email.Contains("."))
                {
                    MessageBox.Show("Invalid email adress domain name (i.e kim@skogsmocom instead of kim@skogsmo.com)");
                    return;
                }

                var roleIndex = boxRole.SelectedIndex;
                var storeIndex = boxStore.SelectedIndex;

                var role = (Role)boxRole.SelectedItem;
                var store = (Store)boxStore.SelectedItem;

                if (!(roleIndex > -1))
                {
                    MessageBox.Show("Pick a role.");
                    return;
                }
                if (!(storeIndex > -1))
                {
                    MessageBox.Show("Pick a store.");
                    return;
                }
                if (!decimal.TryParse(boxSalary.Text, out salary))
                {
                    MessageBox.Show("Enter a valid salary!");
                    return;
                }

                DateTime birthdate = boxBirthdate.Value;

                SqlParameter fnameP = new SqlParameter("@FirstName", SqlDbType.VarChar);
                fnameP.Value = firstName;
                SqlParameter lnameP = new SqlParameter("@LastName", SqlDbType.VarChar);
                lnameP.Value = lastName;
                SqlParameter emailP = new SqlParameter("@Email", SqlDbType.VarChar);
                emailP.Value = email;
                SqlParameter onleaveP = new SqlParameter("@OnLeave", SqlDbType.Bit);
                onleaveP.Value = onleave;
                SqlParameter roleP = new SqlParameter("@Role", SqlDbType.Int);
                roleP.Value = role.id;
                SqlParameter salaryP = new SqlParameter("@Salary", SqlDbType.Decimal);
                salaryP.Value = salary;
                SqlParameter birthdateP = new SqlParameter("@Birthdate", SqlDbType.DateTime);
                birthdateP.Value = birthdate;
                SqlParameter storeP = new SqlParameter("@Store", SqlDbType.Int);
                storeP.Value = store.id;
                
                saveUserCmd.Parameters.Add(fnameP);
                saveUserCmd.Parameters.Add(lnameP);
                saveUserCmd.Parameters.Add(emailP);
                saveUserCmd.Parameters.Add(onleaveP);
                saveUserCmd.Parameters.Add(roleP);
                saveUserCmd.Parameters.Add(salaryP);
                saveUserCmd.Parameters.Add(birthdateP);
                saveUserCmd.Parameters.Add(storeP);

                saveUserCmd.ExecuteNonQuery();

                MessageBox.Show("Employee added!");

                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            
            boxFirstname.Clear();
            boxLastname.Clear();
            boxEmail.Clear();
            boxOnleave.Checked = false;
            boxSalary.Clear();
            boxStore.SelectedItem = 1;
            boxRole.SelectedItem = 1;
            boxBirthdate.Value = new DateTime(1980,1, 1);
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void boxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hmm...
        }
        private void boxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hmm...
        }
        private void LoadRoles()
        {
            string connectionString = "Server = .; Database = ProjektarbeteDB; Integrated Security = True";
            string query = "SELECT * FROM dbo.Roles";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand readRoles = new SqlCommand(query, connection);
            SqlDataReader roleReader;

            try
            {
                connection.Open();
                roleReader = readRoles.ExecuteReader();

                while (roleReader.Read())
                {
                    Role newRole = new Role();

                    newRole.id = roleReader.GetInt32(0);
                    newRole.name = roleReader.GetString(1);

                    boxRole.Items.Add(newRole);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStores()
        {
            string connectionString = "Server = .; Database = ProjektarbeteDB; Integrated Security = True";
            string query = "SELECT * FROM dbo.Stores";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand readStores = new SqlCommand(query, connection);
            SqlDataReader storeReader;

            try
            {
                connection.Open();
                storeReader = readStores.ExecuteReader();

                while (storeReader.Read())
                {
                    Store newStore = new Store();

                    newStore.id = storeReader.GetInt32(0);
                    newStore.name = storeReader.GetString(1);

                    boxStore.Items.Add(newStore);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
