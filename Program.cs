using System.IO;

namespace Assignment4._2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Data.auth.Add("Teacher", "Admin");

            Student Jessie = new Student() { studentID = 1, studentName = "Jessie", GPA = 4.0f };
            Jessie.Email = Jessie.emailGenerator(Jessie.studentName);
            Data.students.Add(Jessie);

            Student Marus = new Student() { studentID = 2, studentName = "Marcus", GPA = 3.7f };
            Marus.Email = Marus.emailGenerator(Marus.studentName);
            Data.students.Add(Marus);

            Student Alicia = new Student() { studentID = 3, studentName = "Alicia", GPA = 2.9f };
            Alicia.Email = Alicia.emailGenerator(Alicia.studentName);
            Data.students.Add(Alicia);

            Student Tommy = new Student() { studentID = 4, studentName = "Tommy", GPA = 3.2f };
            Tommy.Email = Tommy.emailGenerator(Tommy.studentName);
            Data.students.Add(Tommy);

            Student Renne = new Student() { studentID = 5, studentName = "Renee", GPA = 3.8f };
            Renne.Email = Renne.emailGenerator(Renne.studentName);
            Data.students.Add(Renne);


            Application.Run(new Form1());
        }
    }
}