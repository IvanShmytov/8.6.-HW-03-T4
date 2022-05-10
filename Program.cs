namespace FinalTask
{
    using System;

    partial class MainClass
    {
        public static void Main(string[] args)
        {
            string Dirname = @"C:\Users\ivans\Desktop\Students";
            Directory.CreateDirectory(Dirname);
            Student[] students;
            Studentdeserializer SD = new Studentdeserializer();
            students = SD.DesertStuds(@"C:\Users\ivans\source\repos\Modul8Task4\Students (5).dat");
            //foreach (Student item in students)
            //{
            //    item.ReadStudToFile();
            //}
        }

    }
}
