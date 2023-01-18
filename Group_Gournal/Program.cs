// See https://aka.ms/new-console-template for more information

    Console.WriteLine("_______Преподаватели_______");

    Teacher Tom = new Teacher("Tom", "Apollo");
    Console.WriteLine("Teacher "+Tom.firstName+" "+Tom.lastName);
    //////////////////////////////
    
    Console.WriteLine("_______Студенты_______");

    Teacher Bill = new Teacher("Bill", "Hill");
    Console.WriteLine("Student " + Bill.firstName + " " + Bill.lastName);
    Students Levi = new Students("Levi", "Comperbill");
    Console.WriteLine("Student "+Levi.firstName + " " + Levi.lastName);
    ///////////////////////////
    
    Console.WriteLine("_______Предметы_______");

    Lesson Math = new Lesson("Math");
    Console.WriteLine("Lesson " + Math.lessonName);
    Lesson Lab = new Lesson("Lab");
    Console.WriteLine("Lesson " + Lab.lessonName);
    Lesson Eng = new Lesson("Eng");
    Console.WriteLine("Lesson " + Eng.lessonName);
    ///////////////////////////


public class Teacher
{
    public string firstName;
    public string lastName;
    public Teacher(string FirstName, string LastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
};
public record Lesson
{
    public string lessonName;
    public Lesson(string LessonName)
    {
        lessonName = LessonName;
    }

};
public record Students
{
    public string firstName;
    public string lastName;
    public Students(string FirstName, string LastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
}
