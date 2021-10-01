namespace Students
{
    public abstract class Student
    {
        public string name, state;
        public Student(string name)
        {
            this.name = name;
            state = "";
        }
        public void Relax()
        {
            state += "Relax";
        }
        public void Read()
        {
            state += "Read";
        }
        public void Write()
        {
            state += "Write";
        }
        public abstract void Study();
    }
}
