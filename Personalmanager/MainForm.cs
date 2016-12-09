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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void boxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hmm...
        }
        private void boxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hmm...
        }

        void LoadEmployees()
        {
            string connectionStringEmployees = "Server=.;Database=ProjektarbeteDB;Integrated Security=True";
            string employeesQuery = "SELECT * FROM dbo.Employees;";

            SqlConnection connection = new SqlConnection(connectionStringEmployees);
            SqlCommand showUsers = new SqlCommand(employeesQuery, connection);
            SqlDataReader userReader;

            try
            {
                connection.Open();
                userReader = showUsers.ExecuteReader();
                while (userReader.Read())
                {
                    Employee newEmployee = new Employee();
                    newEmployee.id = (int)userReader["ID"];
                    newEmployee.fname = (string)userReader["FirstName"];
                    newEmployee.lname = (string)userReader["LastName"];
                    newEmployee.email = (string)userReader["Email"];
                    newEmployee.role = (int)userReader["Role"];
                    newEmployee.salary = (decimal)userReader["Salary"];
                    newEmployee.date = (DateTime)userReader["Birthdate"];
                    newEmployee.onleave = (bool)userReader["OnLeave"];
                    newEmployee.store = (int)userReader["Store"];
                    employeeListBox.Items.Add(newEmployee);

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void LoadStoresInOtherTab()
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

                    pickStoreBox.Items.Add(newStore);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)employeeListBox.SelectedItem;

            boxFirstname.Text = selectedEmployee.fname;
            boxLastname.Text = selectedEmployee.lname;
            boxEmail.Text = selectedEmployee.email;
            boxRole.SelectedItem = selectedEmployee.role;
            boxSalary.Text = selectedEmployee.salary.ToString();
            boxOnleave.Checked = selectedEmployee.onleave;
            boxBirthdate.Value = selectedEmployee.date;
            boxStore.SelectedItem = selectedEmployee.store;

            int storeID = selectedEmployee.store;

            foreach (Store store in boxStore.Items)
            {
                if (store.id == storeID)
                { boxStore.SelectedItem = store; }
            }

            int roleID = selectedEmployee.role;

            foreach (Role role in boxRole.Items)
            {
                if (role.id == roleID)
                { boxRole.SelectedItem = role; }
            }
        }
        private void pickStoreBox_Load(object sender, EventArgs e)
        {
            //hmm ....
        }

        private void pickStoreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showUsersBox.Items.Clear();

            Store selectedStore = (Store)pickStoreBox.SelectedItem;
            int id = selectedStore.id;

            foreach (Employee emp in employeeListBox.Items)
            {
                Employee anEmployee = new Employee();

                anEmployee.fname = emp.fname;
                anEmployee.lname = emp.lname;
                anEmployee.store = emp.store;
                anEmployee.onleave = emp.onleave;

                string newEmpNameAndSuch = "";
                string avail = "";

                if (anEmployee.onleave == false)
                {
                    avail = "Not available";
                }
                else
                {
                    avail = "Available!";
                }

                anEmployee.salary = emp.salary;
               
                newEmpNameAndSuch = $"{anEmployee.fname} {anEmployee.lname} ({avail})";

                if (anEmployee.store == id)
                {
                    showUsersBox.Items.Add(newEmpNameAndSuch);
                }
                
            }
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEmployees();
                LoadStores();
                LoadStoresInOtherTab();
                LoadRoles();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            employeeListBox.Items.Clear();
            LoadEmployees();
        }

        private void employeesTab_Click(object sender, EventArgs e)
        {

        }
       
        public void buttonAdd_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.ShowDialog();


        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)employeeListBox.SelectedItem;

            var selectedEmployeeIndex = employeeListBox.SelectedIndex;
            try
            {
                string connectionString = "Server = .; Database = ProjektarbeteDB; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);


                bool onleave = boxOnleave.Checked;

                decimal salary;

                string firstName = boxFirstname.Text;

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    MessageBox.Show("Please enter a first name.");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }
                string lastName = boxLastname.Text;
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Please enter a last name.");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }

                foreach (char c in firstName)
                {
                    bool isIt = char.IsDigit(c);
                    if (isIt)
                    {
                        MessageBox.Show("Your names cant contain numbers.");

                        employeeListBox.SelectedIndex = selectedEmployeeIndex;
                        return;
                    }
                }

                foreach (char c in lastName)
                {
                    bool isIt = char.IsDigit(c);
                    if (isIt)
                    {
                        MessageBox.Show("Your names cant contain numbers.");

                        employeeListBox.SelectedIndex = selectedEmployeeIndex;
                        return;
                    }
                }

                string email = boxEmail.Text;
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter an email adress.");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }
                if (!email.Contains("@"))
                {
                    MessageBox.Show("You need a @ sign.");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }
                if (!email.Contains("."))
                {
                    MessageBox.Show("Invalid email adress domain name (i.e kim@skogsmocom instead of kim@skogsmo.com)");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }

                RegexUtilities util = new RegexUtilities();
                string emailCheck = email;


                if (!util.IsValidEmail(emailCheck))
                {
                    MessageBox.Show("Not valid email!");
                }
                

                var roleIndex = boxRole.SelectedIndex;
                var storeIndex = boxStore.SelectedIndex;

                var role = (Role)boxRole.SelectedItem;
                var store = (Store)boxStore.SelectedItem;

                if (!(roleIndex > -1))
                {
                    MessageBox.Show("Pick a role.");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }
                if (!(storeIndex > -1))
                {
                    MessageBox.Show("Pick a store.");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }
                if (!decimal.TryParse(boxSalary.Text, out salary))
                {
                    MessageBox.Show("Enter a valid salary!");

                    employeeListBox.SelectedIndex = selectedEmployeeIndex;
                    return;
                }

                DateTime birthdate = boxBirthdate.Value;
                
                
                //Do the update
                SqlCommand updateCommand = new SqlCommand("UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email, OnLeave = @OnLeave, Role = @Role, Salary = @Salary, Birthdate = @Birthdate, Store = @Store WHERE ID = " + selectedEmployee.id);
                updateCommand.Connection = connection;
                connection.Open();

                SqlParameter FirstNameP = new SqlParameter("@FirstName", SqlDbType.VarChar);
                FirstNameP.Value = firstName;
                SqlParameter LastNameP = new SqlParameter("@LastName", SqlDbType.VarChar);
                LastNameP.Value = lastName;
                SqlParameter EmailP = new SqlParameter("@Email", SqlDbType.VarChar);
                EmailP.Value = email;
                SqlParameter OnLeaveP = new SqlParameter("@OnLeave", SqlDbType.Bit);
                OnLeaveP.Value = onleave;
                SqlParameter RoleP = new SqlParameter("@Role", SqlDbType.Int);
                RoleP.Value = role.id;
                SqlParameter SalaryP = new SqlParameter("@Salary", SqlDbType.Decimal);
                SalaryP.Value = salary;
                SqlParameter BirthdateP = new SqlParameter("@Birthdate", SqlDbType.DateTime);
                BirthdateP.Value = birthdate;
                SqlParameter StoreP = new SqlParameter("@Store", SqlDbType.Int);
                StoreP.Value = store.id;

                updateCommand.Parameters.Add(FirstNameP);
                updateCommand.Parameters.Add(LastNameP);
                updateCommand.Parameters.Add(EmailP);
                updateCommand.Parameters.Add(OnLeaveP);
                updateCommand.Parameters.Add(RoleP);
                updateCommand.Parameters.Add(SalaryP);
                updateCommand.Parameters.Add(BirthdateP);
                updateCommand.Parameters.Add(StoreP);
                updateCommand.ExecuteNonQuery();
                connection.Close();

                //Reselect the employee in the list

                MessageBox.Show("Employee information has been updated successfully!");
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            employeeListBox.Items.Clear();
            LoadEmployees();
            employeeListBox.SelectedIndex = selectedEmployeeIndex;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=ProjektarbeteDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            try {

                

                Employee selectedEmployee = (Employee)employeeListBox.SelectedItem;

                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Employees WHERE ID =" + selectedEmployee.id);
                deleteCommand.Connection = connection;
                var FinalizeDeletion = MessageBox.Show($"Are you sure you want to delete {selectedEmployee.fname}?", "Delete employee", MessageBoxButtons.YesNo);

                if (FinalizeDeletion == DialogResult.Yes)
                {
                    boxFirstname.Clear();
                    boxLastname.Clear();
                    boxEmail.Clear();
                    boxOnleave.Checked = false;
                    boxRole.SelectedItem = 1;
                    boxSalary.Clear();
                    boxBirthdate.ResetText();
                    boxStore.SelectedItem = 1;

                    deleteCommand.ExecuteNonQuery();

                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            employeeListBox.Items.Clear();
            LoadEmployees();
            
            employeeListBox.SelectedIndex = 0;
        }
    }
}
