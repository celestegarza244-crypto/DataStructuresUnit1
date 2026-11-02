namespace DataStructuresUnit1.Models;

/// <summary>
/// REFERENCE type (class): every instance is allocated on the managed Heap.
/// Variables of this type only store a reference (pointer) to the object.
/// </summary>
public class Student
{
    public Student(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }

    public string Name { get; set; }

    public double Grade { get; set; }
}

/// <summary>
/// VALUE type (struct): the data lives inline (on the stack when it is a local variable).
/// Assigning it to another variable copies ALL of its data.
/// </summary>
public struct StudentValue
{
    public StudentValue(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }

    public string Name { get; set; }

    public double Grade { get; set; }
}
