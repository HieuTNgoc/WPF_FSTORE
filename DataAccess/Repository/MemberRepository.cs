using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private MemberDAO _MemberDAO;



        public MemberRepository()
        {
            _MemberDAO = new MemberDAO();
        }


        public int Login(string email, string password)
        {
            return _MemberDAO.countAcc(email, password);
        }

        public List<Member> ReadAll()
        {
            return _MemberDAO.getAll();
        }
        public int EmailCount(string email)
        {
            return _MemberDAO.countEmail(email);
        }

        public void Create(Member member)
        {
            _MemberDAO.addNew(member);
        }

        public Member GetById(int memberId)
        {
            return _MemberDAO.getById(memberId);
        }

        public void Update(int memberId, Member member)
        {
            _MemberDAO.update(memberId, member);
        }

        //public int Create(Member member)
        //{
        //    _context.Add(member);
        //    return _context.SaveChanges();
        //}

        //public int Delete(Member member)
        //{
        //    _context.Remove(member);
        //    return _context.SaveChanges();
        //}

        //public Member GetMemberByEmail(int email)
        //{
        //    throw new NotImplementedException();
        //}

        //public Member GetMemberById(int memberId)
        //{
        //    throw new NotImplementedException();
        //}



        //public int Update(int id, Member member)
        //{

        //    member.MemberId = id;
        //    Member oldMember = _context.Members.Where(o => o.MemberId == id).FirstOrDefault();
        //    oldMember.MemberId = id;
        //    oldMember.Email = member.Email;
        //    oldMember.CompanyName = member.CompanyName;
        //    oldMember.City = member.City;
        //    oldMember.Country = member.Country;
        //    oldMember.Password = member.Password;
        //    _context.Update(oldMember);
        //    return _context.SaveChanges();
        //}



    }
}
