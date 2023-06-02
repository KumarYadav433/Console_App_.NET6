// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//enum DaysOfWeek { a, b, c }

class Sample
{
    //key words
    enum DaysOfWeek { monday, tue, thus }
    const int a = 10;
    private readonly int a1 = 20;
    private readonly int a2;
    public static int st = 111;

    public Sample(int i)
    {
        a2 = i;
    }
    public void m()
    {
        st = 55;
        Console.WriteLine("constant variable:" + " " + a);
        Console.WriteLine("Readonly variable:" + " " + a1);
        Console.WriteLine("Readonly variable from constructor:" + " " + a2);
        Console.WriteLine("static variable:" + " " + st);

    }
    public static void getRef(ref int i, out int j)
    {
        Console.WriteLine("ref:" + " " + i);
        j = 5;
        i = 444;
        Console.WriteLine("out:" + " " + j);
    }

    public static void Enroll(in Student student)
    {
        Console.WriteLine(student.Name + "" + student.Enrolled);

        // With in assigning a new object would throw an error
        // student = new Student();

        // We can still do this with reference types though
        student.Enrolled = true;

    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int i = 3;
        //Console.WriteLine("Enum:"+" "+DaysOfWeek.a);

        Sample s = new Sample(2);
        s.m();
        Sample.getRef(ref i, out int j);
        //const int a = 1;
        //int a1 = 1;
        Console.WriteLine("Out key:" + j);
        Console.WriteLine("ref from main:" + i);

        var student = new Student
        {
            Name = "Susan",
            Enrolled = false
        };


        Sample.Enroll(student);
        Console.WriteLine(student.Name + "" + student.Enrolled);


        Employee e = new Employee();
        Console.WriteLine(e.Sum(10, 30) + " " + e.Sum(10, 40));

        Calculate2 cl= new Calculate2();
        cl.Sum(10, 30);
        cl.Sum2(10, 30);

    }
}

//model
public class Student
{
    public string Name { get; set; }
    public bool Enrolled { get; set; }
}

//interface
interface IEmployee
{
    //public int s1 { get; set; } 
    //public int s2 { get; set; }

    public int Sum(int x, int y);
}

public class Employee : IEmployee
{
    public int Sum(int x, int y)
    {
        return x + y;
    }
}

//abstrast class 
public abstract class Calculate
{
    //public int s1 { get; set; } 
    //public int s2 { get; set; }
    public int x = 11, y = 12;
    public virtual void Sum(int x, int y)
    {
        Console.WriteLine("From abstract");
    }
    public virtual void Sum2(int x, int y)
    {
        Console.WriteLine("From abstract2");
    }
}

//inheritance
public class Calculate2 : Calculate
{
    public override void Sum(int x, int y)
    {
        Console.WriteLine("From class");
    }
}


