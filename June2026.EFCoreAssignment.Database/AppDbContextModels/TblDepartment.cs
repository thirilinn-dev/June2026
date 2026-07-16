using System;
using System.Collections.Generic;

namespace June2026.EFCoreAssignment.Database.AppDbContextModels;

public partial class TblDepartment
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string Location { get; set; } = null!;
}
