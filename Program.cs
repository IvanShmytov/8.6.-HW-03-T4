using System;

partial class MainClass
{
    public static void Main(string[] args)
    {
        string Dirname = @"C:\Users\ivans\Desktop\Students";
        Directory.CreateDirectory(Dirname);
        Student[] students;
        studentdeserializer SD = new studentdeserializer();
        students = SD.DesertStuds("Students(4).dat");
        //foreach (Student item in students)
        //{
        //    item.ReadStudToFile();
        //}
    }

}
