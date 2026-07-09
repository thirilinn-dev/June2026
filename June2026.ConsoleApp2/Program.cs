// See https://aka.ms/new-console-template for more information
using Dapper;
using June2026.ConsoleApp2;
using Microsoft.Data.SqlClient;
using System.Data;

DapperService dp = new DapperService();
dp.Read();
dp.Create();
dp.Update();
dp.Delete();

