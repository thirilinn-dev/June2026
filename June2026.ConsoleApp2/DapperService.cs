using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026.ConsoleApp2
{
    internal class DapperService
    {
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "June2026",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Read() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                List<Student> lst = db.Query<Student>("SELECT * FROM [dbo].[Tbl_Student];").ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine($"Id: {item.StudentID}, Name: {item.StudentName}");
                }
            }

        }

        public void Create() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();

                int result = db.Execute(@"INSERT INTO [dbo].[Tbl_Student]
(
    StudentName,
    FatherName,
    StudentNo,
    Email,
    DateOfBirth,
    MobileNo,
    IsDelete
)
VALUES
('John Smith', 'Robert Smith', 'STU001', 'john.smith@example.com', '2002-05-15', '09123456789', 0),
('Alice Johnson', 'Michael Johnson', 'STU002', 'alice.johnson@example.com', '2003-08-20', '09987654321', 0);");

                Console.WriteLine($"Rows affected: {result}");
            }
        }

        public void Update() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();

                int result = db.Execute(@"UPDATE [dbo].[Tbl_Student]
                    SET DateOfBirth = '2006-09-19'
                    WHERE StudentID = 4");
                Console.WriteLine($"Rows affected: {result}");
            }
        }

        public void Delete() 
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
             
                int result = db.Execute(@"Delete from Tbl_Student where StudentId = 2");
                Console.WriteLine($"Rows affected: {result}");
            }
        }



        public class Student
        {
            public int StudentID { get; set; }

            public string StudentName { get; set; }

            public string FatherName { get; set; }

            public string StudentNo { get; set; }

            public string Email { get; set; }

            public DateTime DateOfBirth { get; set; }

            public string MobileNo { get; set; }

            public int IsDelete { get; set; }

        }
    }
}
