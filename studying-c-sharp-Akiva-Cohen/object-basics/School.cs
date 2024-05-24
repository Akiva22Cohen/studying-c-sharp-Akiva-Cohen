using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace c_sharp_basics_lingar.object_basics
{
    public class Pupil
    {
        public int id;
        public string name;
        public int yearOfBirth;

        public Pupil(int id, string name, int yearOfBirth)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
        }

        public override string ToString()
        {
            return $"Id: {id}\n\tName: {name}\n\tyear of birth: {yearOfBirth}";
        }
    }

    public class Classroom
    {
        public char classCh;
        public Pupil[] pupils;
        public int numOfPupil;
        public string teacher;

        public Classroom(char classCh, int maxPupils, string teacher)
        {
            this.classCh = classCh;
            this.pupils = new Pupil[maxPupils];
            //this.numOfPupil = 0;
            this.teacher = teacher;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < pupils.Length; i++)
                str += pupils[i].ToString() + "\n\n\t";
            return $"classCh: {classCh}\n\tnumOfPupil: {pupils.Length}\n\tteacher: {teacher}\n\tpupils:\n\n\t{str}";
        }
    }

    public class TestClassroom
    {
        static Random rnd = new Random();
        static Classroom[] classroom = new Classroom[3];

        static char[] ch = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        static string[] teachers = { "Johnson", "Smith", "Williams", "Brown" };
        static string[] pupils = { "Alex", "Ben", "Charlie", "Daniel", "Abigail", "Bella", "Clara", "Daisy" };
        
        public static void Demo()
        {
            for (int i = 0; i < classroom.Length; i++)
            {
                classroom[i] = new Classroom(ch[rnd.Next(ch.Length)], 2, teachers[rnd.Next(teachers.Length)]);
                for (int j = 0; j < classroom[i].pupils.Length; j++)
                {
                    classroom[i].pupils[j] = new Pupil(rnd.Next(100, 1000), pupils[rnd.Next(pupils.Length)], rnd.Next(1990, 2015));
                }
                Console.WriteLine(classroom[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
