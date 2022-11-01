using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public int Login(string email, string password);
        public List<Member> ReadAll();
        //public Member GetMemberById(int memberId);
        //public Member GetMemberByEmail(int email);
        //public int Create(Member member);
        //public int Update(int id, Member member);
        //public int Delete(Member member);

    }
}
