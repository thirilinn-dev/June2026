using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026.ConsoleApp1
{
    internal class AdoDotNetService
    {
        public void Read()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            Console.WriteLine($"connection string: {sb.ConnectionString}");

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection opening...");
            connection.Open();
            Console.WriteLine("Connection opened.");

            string query = @"SELECT [StudentId]
      ,[StudentName]
      ,[FatherName]
      ,[StudentNo]
      ,[Email]
      ,[DateOfBirth]
      ,[MobileNo]
      ,[IsDelete]
  FROM [dbo].[Tbl_Student]";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Console.WriteLine("Connection closing...");
            connection.Close();
            Console.WriteLine("Connection closed.");


            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["StudentId"]);
                Console.WriteLine(item["StudentName"]);
                Console.WriteLine(item["FatherName"]);
                DateTime dtDob = Convert.ToDateTime(item["DateOfBirth"]);
                Console.WriteLine(dtDob.ToString("dd-MMM-yyyy"));

            }
        }

        public void Create()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open ();

            string query = @"INSERT INTO [dbo].[Tbl_Student]
           ([StudentName]
           ,[FatherName]
           ,[StudentNo]
           ,[Email]
           ,[DateOfBirth]
           ,[MobileNo]
           ,[IsDelete])
VALUES
('Thiri Linn', 'Aung Ko', 'STU001', 'thiri.linn@gmail.com', '2003-05-12', '09123456789', 0),
('Kyaw Min', 'U Win Hlaing', 'STU002', 'kyaw.min@gmail.com', '2002-11-20', '09234567890', 0),
('Su Su Mon', 'U Myint Soe', 'STU003', 'susu.mon@gmail.com', '2004-01-08', '09345678901', 0),
('Aye Chan', 'U Than Lwin', 'STU004', 'aye.chan@gmail.com', '2003-08-15', '09456789012', 0),
('Zin Mar', 'U Hla Myint', 'STU005', 'zin.mar@gmail.com', '2002-12-30', '09567890123', 0);";

            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            connection.Close ();
        }

        public void Update()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();

            string query = @"UPDATE [dbo].[Tbl_Student]
SET
    StudentName = 'Su Su Htet',
    FatherName = 'U Soe Win',
    Email = 'susuhtet@gmail.com',
    MobileNo = '09987654321',
    DateOfBirth = '2004-02-10'
WHERE StudentNo = 'STU003';";

            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();

            string query = @"DELETE FROM [dbo].[Tbl_Student]
WHERE StudentNo = 'STU002';";

            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
