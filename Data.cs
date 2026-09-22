using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment4._2
{
    internal class Data
    {
        public static List<Student> students = new List<Student>();

        public static Dictionary<string, string> auth = new Dictionary<string, string>();





        public static void TopStudent()
        {
            const string path = @"C:\MSSA\20483\CCAD23\Assignment4.2\";
            string filename = (path + "TopStudent.txt");
            StreamWriter writer = null;
            float highest = 0;
            Queue<Student> best = new Queue<Student>();

            if (students.Count >= 0)
            {
                foreach (var s in students)
                {
                    if (s.GPA > highest)
                    {
                        best.Clear();
                        highest = s.GPA;
                        best.Enqueue(s);
                    } else if (s.GPA == highest)
                    {
                        best.Enqueue(s);
                    }
                }

                try
                {
                    writer = File.CreateText(filename);
                    writer.WriteLine($"{"ID",-6}{"Name",-15}{"Email",-25}{"GPA",-6}");
                    foreach (var s in best)
                    {
                        writer.WriteLine($"{s.studentID,-6}{s.studentName,-15}{s.Email,-25}{s.GPA,-6}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while writing file: ");
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
        }

    }
}
