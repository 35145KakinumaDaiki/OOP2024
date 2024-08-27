

using System;

public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime HireDate { get; set; }
    public override string ToString() {
        return string.Format("[ID={0}, Name={1}, HireDate={2}]",Id,Name,HireDate);
    }

   
}




