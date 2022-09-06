namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(23456789, "simon", "hansen", 2930);
            ProjectManager p = new ProjectManager("tue@gmail.com", 03929463, "tue", "jurs", 3921);
            Sweeper s = new Sweeper("patrick", "skovmose", 1029);

            m.Write();
            p.Write();
            s.Write();
        }
    }
}