using System;
using System.Runtime.Serialization.Formatters.Binary;
class MainClass
{
    public static void Main(string[] args)
    {
        string Dirname = @"C:\Users\ivans\Desktop\Students";
        Directory.CreateDirectory(Dirname);
        BinaryFormatter form = new BinaryFormatter();
        Student[] studs;
        //using (FileStream fs = new FileStream("Students(4).dat", FileMode.OpenOrCreate))
        //{
        //    try
        //    {
        //        studs = (Student[])form.Deserialize(fs);
        //        Console.WriteLine("объект десериализован");
        //        foreach (var item in studs)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.GetType());
        //    }
        //}
        studentdeserializer SD = new studentdeserializer();
        studs = SD.DesertStuds("Students(4).dat");
    }
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student(string name, string group, DateTime date)
        {
            Name = name;
            Group = group;
            DateOfBirth = date;
        }
        public override string ToString()
        {
            string result = $"имя - {Name}\nдата рождения - {DateOfBirth}\nгруппа - {Group}";
            return result;
        }
    }
    public class studentdeserializer
    {
        public Student[] DesertStuds(string filename) 
        {
            BinaryFormatter form = new BinaryFormatter();
            Student[] studs = null;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    studs = (Student[])form.Deserialize(fs);
                    Console.WriteLine("объект десериализован");
                    foreach (var item in studs)
                    {
                        Console.WriteLine(item);
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType());
                }
            }
            return studs;
        }

    }

}
