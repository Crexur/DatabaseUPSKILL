namespace DatabaseUPSKILL
{
    using Microsoft.Data.SqlClient;
    using System.Windows.Forms;

    public partial class FrmClubRegistration : Form
    {
        private ClassRegistrationQuery classRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;



        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private int RegistrationID()
        {
            count++;
            return count;
        }

        private void RefreshListOfClubMembers()
        {
            classRegistrationQuery.DisplayList();
            dataGridView1.DataSource = classRegistrationQuery.bindingSource;
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            classRegistrationQuery = new ClassRegistrationQuery();
            RefreshListOfClubMembers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string gender = cmbGender.SelectedItem.ToString();
            string program = cmbProgram.Text;

            // Call RegistrationID() method to get ID value
            int id = RegistrationID();

            // Call RegisterStudent() method of ClubRegistrationQuery class
            bool registrationSuccess = classRegistrationQuery.RegisterStudent(id, StudentId, firstName, middleName, lastName, age, gender, program);

            if (registrationSuccess)
            {
                // Registration successful
                MessageBox.Show("Student registered successfully!");
                RefreshListOfClubMembers(); // Refresh the list of club members
            }
            else
            {
                // Registration failed
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }
    }
}

