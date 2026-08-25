// Inherits from Employee
public class Manager : Employee
{
    // Extra field, Department
    public string Department;

    // Constructor that takes in all fields from Employee and the Department
    public Manager(string bsn, string name, int age, string employeeID, string department)
        : base(bsn, name, age, employeeID)
    {
        Department = department;
    }

    // Override the ToString method to include Department
    public override string ToString()
    {
        return base.ToString() + $", Department: {Department}";
    }
}