using StudentCourseRegistration.Models;

namespace StudentCourseRegistration.Data;

// In-memory storage is used because the activity does not require a database.
public static class StudentStore
{
    private static readonly List<Student> Students =
    [
        new Student { Id = 1, Name = "Aarav Patel", Email = "aarav@example.com", Course = "B.Tech Computer Engineering", Semester = 5 },
        new Student { Id = 2, Name = "Diya Shah", Email = "diya@example.com", Course = "B.Tech Information Technology", Semester = 3 }
    ];

    private static int _nextId = 3;

    public static List<Student> GetAll() => Students;

    public static Student? GetById(int id) => Students.FirstOrDefault(s => s.Id == id);

    public static void Add(Student student)
    {
        student.Id = _nextId++;
        Students.Add(student);
    }
}
