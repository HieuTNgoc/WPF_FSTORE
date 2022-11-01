using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private Asm1PRNContext _Context;
        private String _AdminEmail;
        private String _AdminPassword;
        
        public MemberDAO()
        {
            _Context = DataProvider.Ins.DB;
            var Member = _Context.Members.FirstOrDefault();
            _AdminEmail = _Context.AdminEmail;
            _AdminPassword = _Context.AdminPassword;
        }

        public int countAcc(String email, String password)
        {
            if (email == _AdminEmail && password == _AdminPassword) return -1;
            return _Context.Members.Where(x => x.Email == email && x.Password == password).Count();
        }

        public List<Member> getAll()
        {
            return _Context.Members.ToList();

        }
        //public Member viewInfo(int id)
        //{
        //    return null;
        //}
        //public int delete(Member Member)
        //{
        //    return MemberRepository.Delete(Member);
        //}
        //public int update(int id, Member Member)
        //{
        //    return MemberRepository.Update(id, Member);
        //}
        //public int add(Member Member)
        //{
        //    return MemberRepository.Create(Member);
        //}

    }
}
