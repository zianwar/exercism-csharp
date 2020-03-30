using System.Linq;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public Student(string name, int grade)
    {
        this.Name = name;
        this.Grade = grade;
    }
}

class StudentsComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if (x.Grade == y.Grade)
        {
            return x.Name.CompareTo(y.Name);
        }
        return x.Grade.CompareTo(y.Grade);
    }
}

public class GradeSchool
{
    private SortedList<Student, int> students = new SortedList<Student, int>(new StudentsComparer());

    public void Add(string student, int grade)
        => students.Add(new Student(student, grade), grade);

    public IEnumerable<string> Roster()
        => students.Select((s) => s.Key.Name).AsEnumerable();

    public IEnumerable<string> Grade(int grade)
        => students
            .Where((s) => s.Key.Grade == grade)
            .Select((s) => s.Key.Name)
            .AsEnumerable();
}