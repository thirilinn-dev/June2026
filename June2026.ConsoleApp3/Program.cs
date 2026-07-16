// See https://aka.ms/new-console-template for more information
using June2026.ConsoleApp3;

Console.WriteLine("Hello, World!");

AppDbContext db = new AppDbContext();


var lst = db.Staffs.ToList();

//foreach (var item in lst)
//{
//  Console.WriteLine(item.Id);
//  Console.WriteLine(item.Name);
//  Console.WriteLine("------------------------");
//}


//var staff1 = db.Staffs.Where(x => x.Id == 1).FirstOrDefault();
//var staff2 = db.Staffs.Where(x => x.Id == 10).FirstOrDefault();

//StaffEntity StaffEntity = new StaffEntity()
//{
//    Name = "Piti"
//};

//db.Staffs.Add(StaffEntity);
//int result = db.SaveChanges();


//var staff3 = db.Staffs.Where(x => x.Id == 1).FirstOrDefault();
//if (staff3 is null)
//{
//    Console.WriteLine("Staff not found.");
//}
//else
//{
//    staff3.Name = "Ko Lynn";
//    db.SaveChanges();
//}

var staff4 = db.Staffs.Where(x =>x.Id == 3).FirstOrDefault();
if (staff4 is null)
{
    Console.WriteLine("Staff not found.");
    return;
}
else
{ 
    db.Staffs.Remove(staff4);
    db.SaveChanges();
}

Console.ReadLine();