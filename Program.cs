using System.Security.Cryptography;

List<Student> students = [
    new Student(1, "Augustine"), 
    new Student(2, "Barak"), 
    new Student(3, "Khadijat"), 
    new Student(4, "Abdul"), 
    new Student(5, "Pelumi"), 
    new Student(6, "Oluwatosin"),
    new Student(7, "Pelumi"),
    new Student(8, "Esther"),
    new Student(9, "Sulaimon")
    ];
List<StudentRecord> studentRecords = [];

foreach (Student student in students)
{
    studentRecords.Add(new StudentRecord(student.Id, new Random().Next(25,100), new Random().Next(25, 100)));
}


var studentGrades = from stud in students
                    join rec in studentRecords on stud.Id equals rec.StudentId
                    select new {
                        stud.Id,
                        stud.FullName,
                        rec.EnglishScore,
                        rec.MathsScore,
                        mathGrade = rec.MathsScore >= 70 ? "A" :
                                   rec.MathsScore >= 50 ? "B" :
                                   rec.MathsScore >= 40 ? "C" :
                                   rec.MathsScore >= 30 ? "D" : "F",
                        englishGrade = rec.EnglishScore >= 70 ? "A" :
                                   rec.EnglishScore >= 50 ? "B" :
                                   rec.EnglishScore >= 40 ? "C" :
                                   rec.EnglishScore >= 30 ? "D" : "F"

                    };

Console.WriteLine("STUDENT GRADES");
Console.WriteLine("Name       Eng Score       Mat Score      Eng Grade       Mat Grade");
foreach (var student in studentGrades)
{
    Console.WriteLine($"{student.FullName}     {student.EnglishScore}           {student.MathsScore}                {student.englishGrade}                    {student.mathGrade}");
}



public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public Student (int id, string fullName)
    {

        Id = id; 
        FullName = fullName; 
    }
}


public class StudentRecord
{
    public int StudentId { get; set; }
    public int EnglishScore { get; set; }
    public int MathsScore { get; set; }

    public StudentRecord (int studentId, int englishScore, int mathsScore)
    {
        StudentId = studentId;
        EnglishScore = englishScore;
        MathsScore = mathsScore;
    }


}

