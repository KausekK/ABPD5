using System.Runtime.InteropServices.JavaScript;

namespace lab5.Models;

public class Visit
{
    public DateTime  VisitDate { get; set; }
    public int Id { get; set; }
    public string visitDescription { get; set; }
    public int VisitRating { get; set; }

}