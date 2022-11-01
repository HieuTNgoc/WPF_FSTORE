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
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }



        public MemberViewModel()
        {
            LoadMemberList();

            // Add new item
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

            // Edit item
            EditCommand = new RelayCommand<object>((p) => {
                if (SelectedMember==null || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(CompanyName) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(Country) || string.IsNullOrEmpty(Password))
                {
                    //MessageBox.Show("Please complete all field data!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                var accCount = _MemberRepository.EmailCount(Email);
                var acc = _MemberRepository.GetById(SelectedMember.MemberId);
                if (accCount != 0 && Email != acc.Email)
                {
                    //MessageBox.Show("Email already exists, please try again!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                return true;
            }, (p) => {
                _MemberRepository.Update(SelectedMember.MemberId, new Member { Email = Email, CompanyName = CompanyName, City = City, Country = Country, Password = Password });
                MessageBox.Show($"Account: {Email} is Updated successfully", "Update Member");
                LoadMemberList();
            });

            // Remove item
            DeleteCommand = new RelayCommand<object>((p) => {
                if (SelectedMember == null)
                {
                    return false;
                }
                return true;
            }, (p) => {
                _MemberRepository.Remove(SelectedMember.MemberId);
                MessageBox.Show($"Account: {Email} is Removed successfully", "Remove Member");
                LoadMemberList();
            });

        }
       
        void LoadMemberList()
        {
            MemberList = _MemberRepository.ReadAll();
        }

    }
}
