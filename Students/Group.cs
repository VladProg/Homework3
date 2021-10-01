using System.Collections.Generic;

namespace Students
{
    public class Group
    {
        public string name;
        public List<Student> students;
        public Group(string name)
        {
            this.name = name;
            students = new();
        }
        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        public string GetInfo()
        {
            string res = name + ": ";
            bool first = true;
            foreach (Student st in students)
            {
                if (!first)
                    res += ", ";
                first = false;
                res += st.name;
            }
            return res;
        }
        public string GetFullInfo()
        {
            string res = name + ": ";
            bool first = true;
            foreach (Student st in students)
            {
                if (!first)
                    res += ", ";
                first = false;
                res += st.name + " (" + st.state + ")";
            }
            return res;
        }
    }
}
