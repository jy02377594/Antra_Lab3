using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SayHello();
            Student s = new Student();
            s.SayHello();
            s.ShowAge(s.SetAge(21));
            Teacher t = new Teacher();
            t.SayHello();
            t.Explain();
        }
    }
}
