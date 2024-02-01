
namespace Program1
{
    public class Member
    {
        public Member(string name, int antiquity)
        {
            this.Name = name;
            this.Antiquity = antiquity;
        }

        string Name { get; set; }
        int Antiquity { get; set; }

        public string getName()
        {
            return this.Name;
        }

        public int getAntiguity()
        {
            return this.Antiquity;
        }

    }
}
