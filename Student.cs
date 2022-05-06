partial class MainClass
{
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
        public void ReadStudToFile()
        {
            string File = @$"C:\Users\ivans\Desktop\Students\{Name}"; 
            var fileInfo = new FileInfo(File); 
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine(Name);
                sw.WriteLine(Group);
                sw.WriteLine(DateOfBirth);
            }

        }
    }

}
