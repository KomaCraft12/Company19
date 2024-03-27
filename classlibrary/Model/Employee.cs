using System.ComponentModel.DataAnnotations;

namespace classlibrary.Models;

public class Employee
{
    // mysql Employee models file read csv
    // Name
    [Key]
    public string Name { get; set; }
    // age
    public int Age { get; set; }
    // County
    public string County { get; set; }
    // Occupation
    public string Occupation { get; set; }
    // Hobbies
    public string Hobbies { get; set; }
    
    public Employee()
    {
    }
    
    public Employee(string line)
    {
        var values = line.Split(';');
        Name = values[0];
        Age = int.Parse(values[1]);
        County = values[2];
        Occupation = values[3];
        Hobbies = values[4];
    }
    
    public override string ToString()
    {
        return $"{Name} {Age} {County} {Occupation} {Hobbies}";
    }
    
}