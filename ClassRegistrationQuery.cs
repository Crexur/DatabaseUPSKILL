using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace DatabaseUPSKILL
{
    internal class ClassRegistrationQuery
    {


        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            using (SqlConnection sqlConnect = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
            }

            return true;
        }

        public ClassRegistrationQuery()
        {
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\DatabaseUPSKILL\\Database1.mdf;Integrated Security=True";

            sqlConnect = new SqlConnection(ConnectionString);

            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlDataReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string ConnectionString;

        public string _FirstName;
        public string _MiddleName;
        public string _LastName;
        public string _Gender;
        public string _Program;
        public int _Age;

        public bool DisplayList()
        {
            bool result = true;

            try
            {
                // Declare a string variable named ViewClubMembers and set its value using a Select query statement
                string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";

                // Initialize sqlAdapter with the ViewClubMembers query and sqlConnect
                sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

                // Clear the dataTable
                dataTable.Clear();

                // Fill the dataTable using the sqlAdapter
                sqlAdapter.Fill(dataTable);

                // Set the bindingSource DataSource to the dataTable
                bindingSource.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return result;

            



        }
    }
}
