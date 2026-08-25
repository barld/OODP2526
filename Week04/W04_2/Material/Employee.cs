// Employee class inheriting from Person
public class Employee : Person
{
    // Extra field, EmployeeID
    public string EmployeeID;

    // Constructor that takes in all fields from Person and the EmployeeID
    public Employee(string bsn, string name, int age, string employeeID)
        : base(bsn, name, age)
    {
        EmployeeID = employeeID;
    }

    // Override the ShareID method to return the EmployeeID instead of BSN
    public override string GetID()
    {
        return $"{base.GetID}\nEmployeeID: {EmployeeID}";
    }

    // Override the ToString method to include EmployeeID
    public override string ToString()
    {
        return base.ToString() + $", Employee ID: {EmployeeID}";
    }
}