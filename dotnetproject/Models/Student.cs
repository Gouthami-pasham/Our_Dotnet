using System;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Student
/// </summary>
public class Student
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StudentID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int I919 { get; set; }

}
