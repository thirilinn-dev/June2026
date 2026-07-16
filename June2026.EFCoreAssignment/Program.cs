// See https://aka.ms/new-console-template for more information
using June2026.EFCoreAssignment.Database.AppDbContextModels;

Console.WriteLine("Hello, World!");

AppDbContext db = new AppDbContext();
var lst = db.TblStudents.ToList();
var lst1 = db.TblEmployees.ToList();
var lst2 = db.TblStaffs.ToList();
//var lst3 = db.TblDepartments.ToList();
var lst4 = db.TblCourses.ToList();


Console.ReadLine();
