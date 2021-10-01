namespace Students
{
    public class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state += "bad";
        }
        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }
}
