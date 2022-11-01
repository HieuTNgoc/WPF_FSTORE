using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using SalesWPFApp.ViewModels;
using DataAccess.Repository;
using System.Windows;

namespace SalesWPFApp.ViewModels
{
    public class MemberViewModel : BaseViewModel
    {
        private IMemberRepository _MemberRepository = new MemberRepository();
        private IEnumerable<Member> _MemberList;
        public IEnumerable<Member> MemberList { get => _MemberList; set { _MemberList = value; OnPropertyChanged(); } }
        private Member _SelectedMember;
        public Member SelectedMember { get => _SelectedMember; 
            set { 
                _SelectedMember = value; 
                OnPropertyChanged(); 
                if (SelectedMember != null)
                {
                    Email = SelectedMember.Email;
                    CompanyName = SelectedMember.CompanyName;   
                    City = SelectedMember.City;
                    Country = SelectedMember.Country;
                    Password = SelectedMember.Password;
                }
            } 
        }

        private string _Email;
        public string Email { get => _Email; set { _Email = value;OnPropertyChanged(); } }

        private string _CompanyName;
        public string CompanyName { get => _CompanyName; set { _CompanyName = value; OnPropertyChanged(); } }

        private string _City;
        public string City { get => _City; set { _City = value; OnPropertyChanged(); } }

        private string _Country;
        public string Country { get => _Country; set { _Country = value; OnPropertyChanged(); } }

        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
       
        public MemberViewModel()
        {
            LoadMemberList();

            AddCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(CompanyName) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(Country) || string.IsNullOrEmpty(Password))
                {
                    //MessageBox.Show("Please complete all field data!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                var accCount = _MemberRepository.EmailCount(Email);
                if (accCount != 0)
                {
                    //MessageBox.Show("Email already exists, please try again!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                return true;
            }, (p) => {
                _MemberRepository.Create(new Member {Email = Email, CompanyName = CompanyName,City = City,Country = Country,Password = Password});
                MessageBox.Show($"Account: {Email} is created successfully", "Add Member");
                LoadMemberList();
            });
        }
       
        void LoadMemberList()
        {
            MemberList = _MemberRepository.ReadAll();
        }
        //public void loadCommand()
        //{
        //    searchCommand = new RelayCommand<Object>(p => true, p =>
        //    {


        //    });
        //    createCommand = new RelayCommand<UIElementCollection>(p => true, p =>
        //    {
        //        string email = null;
        //        string companyName = null;
        //        string city = null;
        //        string country = null;
        //        string password = null;
        //        Boolean isAllValid = true;
        //        try
        //        {
        //            foreach (var i in p)
        //            {
        //                TextBox tb = i as TextBox;
        //                if (tb != null)
        //                {

        //                    switch (tb.Name)
        //                    {
        //                        case "email":
        //                            email = tb.Text;
        //                            break;
        //                        case "companyName":
        //                            companyName = tb.Text;
        //                            break;
        //                        case "city":
        //                            city = tb.Text;
        //                            break;
        //                        case "country":
        //                            country = tb.Text;
        //                            break;
        //                        case "password":
        //                            password = tb.Text;
        //                            break;
        //                    }


        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            isAllValid = false;
        //        }
        //        if (isAllValid == true)
        //        {
        //            memberDao.add(new Member(email, companyName, city, country, password));
        //            loadMemberList();
        //        }
        //        else
        //            return;
        //    });
        //    updateCommand = new RelayCommand<UIElementCollection>(p => true, p =>
        //    {
        //        int MemberId = 0;
        //        string email = null;
        //        string companyName = null;
        //        string city = null;
        //        string country = null;
        //        string password = null;
        //        Boolean isAllValid = true;
        //        try
        //        {
        //            foreach (var i in p)
        //            {
        //                TextBox tb = i as TextBox;
        //                if (tb != null)
        //                {

        //                    switch (tb.Name)
        //                    {
        //                        case "MemberId":
        //                            MemberId = Int32.Parse(tb.Text);
        //                            break;
        //                        case "email":
        //                            email = tb.Text;
        //                            break;
        //                        case "companyName":
        //                            companyName = tb.Text;
        //                            break;
        //                        case "city":
        //                            city = tb.Text;
        //                            break;
        //                        case "country":
        //                            country = tb.Text;
        //                            break;
        //                        case "password":
        //                            password = tb.Text;
        //                            break;
        //                    }
        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            isAllValid = false;
        //        }
        //        if (isAllValid == true)
        //        {
        //            memberDao.update(MemberId, new Member(email, companyName, city, country, password));
        //            loadMemberList();
        //        }
        //        else
        //            return;
        //    });
        //    deleteCommand = new RelayCommand<Object>(p => true, p =>
        //    {
        //        Member o = p as Member;
        //        if (o != null)
        //        {
        //            memberDao.delete(o);
        //            loadMemberList();
        //        }
        //        else return;
        //    });
        //}
        //public void loadMemberList()
        //{
        //    memberList.Clear();
        //    List<Member> members = memberDao.getAll();
        //    foreach (Member member in members)
        //        memberList.Add(member);
        //}

    }
}
