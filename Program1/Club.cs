
namespace Program1
{
    public class Club
    {
        Member member1;
        Member member2;
        Member member3;

        public Club()
        {
            member1 = new Member("Jose Miguel", 1);
            member2 = new Member("Maria", 5);
            member3 = new Member("Luis", 3);
        }

        
        public string NameOldestMember()
        {
            Member[] members = { member1, member2, member3 };
            return members.OrderByDescending(m => m.getAntiguity()).First().getName();
        }
    }
}
