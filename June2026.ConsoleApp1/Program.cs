// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Hello, World!");

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


    Console.ReadLine();