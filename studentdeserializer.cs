namespace FinalTask
{
    using System.Runtime.Serialization.Formatters.Binary;

    partial class MainClass
    {
        public class Studentdeserializer
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
                        Console.WriteLine(e.Message);
                    }
                }
                return studs;
            }


        }

    }
}
