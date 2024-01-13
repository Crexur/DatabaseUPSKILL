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

       
       



    }
}
