using System;
using System.Collections.Generic;

namespace June2026.Database.AppDbContextModels;

public partial class TblCourse
{
    public int Id { get; set; }

    public string CourseName { get; set; } = null!;

    public int Duration { get; set; }

    public decimal Fee { get; set; }
}
