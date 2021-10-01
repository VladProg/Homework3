using System;

namespace Students
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Let's create new group");
                Console.Write("Group name: ");
                string name = Console.ReadLine();
                Group g = new(name);
                while (true)
                {
                    Console.WriteLine("Let's add new student to this group");
                    Console.Write("Is this good or bad student (g/b)? Or press Enter to finish filling this group: ");
                    string type = Console.ReadLine();
                    if (type == "")
                        break;
                    if (type != "g" && type != "b")
                    {
                        Console.WriteLine("Incorrect type");
                        continue;
                    }
                    Console.Write("Student name: ");
                    name = Console.ReadLine();
                    if (type == "g")
                        g.AddStudent(new GoodStudent(name));
                    else
                        g.AddStudent(new BadStudent(name));
                }
                foreach (Student st in g.students)
                    st.Study();
                Console.WriteLine();
                Console.WriteLine("GetInfo:");
                Console.WriteLine(g.GetInfo());
                Console.WriteLine("GetFullInfo:");
                Console.WriteLine(g.GetFullInfo());
                Console.WriteLine();
            }
        }
    }
}
