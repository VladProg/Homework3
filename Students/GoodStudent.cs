namespace Students
{
    public class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            state += "good";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }
}
