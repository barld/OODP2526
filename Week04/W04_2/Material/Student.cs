public class Student : Person
{
    public string StudentID;
    public int YearEnrolled;

    public Student(string bsn, string name, int age, string studentID, int yearEnrolled)
        : base(bsn, name, age)
    {
        StudentID = studentID;
        YearEnrolled = yearEnrolled;
    }

    public int LengthOfStudy(int currentYear)
    {
        return currentYear - YearEnrolled;
    }

    // Override the ShareID method to return the StudentID instead of BSN
    public override string GetID(){
        return $"Student ID: {StudentID}";
    }

    // Override the ToString method to include StudentID
    public override string ToString()
    {
        return base.ToString() + $", Student ID: {StudentID}";
    }
}