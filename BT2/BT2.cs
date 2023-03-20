using System;

namespace BT2
{
    class Student
    {
        private double score { get; set; }
        private string id { get; set; }
        private string name { get; set; }

        public Student() {}

        public Student(double score, string id, string name)
        {
            this.score = score;
            this.id = "SV" + id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Score: {0}", score);
        }
    }

    class subStudent1 : Student
    {
        private int age { get; set; }
        public subStudent1(double score, string id, string name, int age) : base(score, id, name)
        {
            this.age = age;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("Age: {0}", age);
        }
    }

    class subStudent2 : Student
    {
        private string email { get; set; }

        private static int count = 0;

        public subStudent2() : base()
        {
            email = "";
            count++;
        }

        public subStudent2(double score, string id, string name, string email) : base(score, id, name)
        {
            this.email = email;
            count++;
        }

        public static int Count()
        {
            return count;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("Email: {0}", email);

        }
    }

    class BT2
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student(10, "21012864", "Bui Thi Anh Dao");
            subStudent1 student2 = new subStudent1(10, "21012864", "Bui Thi Anh Dao", 19);
            subStudent2 student3 = new subStudent2(10, "21012864", "Bui Thi Anh Dao", "anhdao19623@gmail.com");

            student1.display();
            Console.WriteLine();

            student2.display();
        
            Console.WriteLine();

            student3.display();
            Console.WriteLine(subStudent2.Count());
        
        }
    }
}