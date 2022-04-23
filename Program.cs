using System;
using System.Runtime.Serialization.Formatters.Binary;
class MainClass
{
    public static void Main(string[] args)
    {
        string dirName = @"C:\Users\ivans\Desktop\Students";
        Directory.CreateDirectory(dirName);
        BinaryFormatter form = new BinaryFormatter();
        Student[] studs;
        using (FileStream fs = new FileStream("Students(4).dat", FileMode.OpenOrCreate))
        {
            try
            {
                studs = (Student[])form.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                foreach (var item in studs)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
    [Serializable]
    class Student
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


}
