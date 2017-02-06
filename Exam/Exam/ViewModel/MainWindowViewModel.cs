using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using static Exam.DummyUser;

namespace Exam
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<DummyUser.User> temp = Repository.CreateUsers();
        View.AddUser win;
        View.ChangeUser newChangeWindow;

        private DummyUser.User selectUser;

        public DummyUser.User SelectUser
        {
            get
            {
                return selectUser;
            }
            set
            {
                selectUser = value;
                OnPropertyChanged("SelectUser");
            }
        }

        ///////////////////////////////////////////////////////////////////

        private DummyUser.User newUser;

        public DummyUser.User NewUser
        {
            get
            {
                if (newUser == null)
                    newUser = new DummyUser.User();
                return newUser;
            }
            set
            {
                newUser = value;
                OnPropertyChanged("NewUser");
            }
        }

        ////////////////////////////////////////////////////////////////////

        private ObservableCollection<DummyUser.User> users;        

        public ObservableCollection<DummyUser.User> Users
        {
            get
            {
                if (users == null)
                    users = temp;
                return users;
            }
            set
            {
                users = value;
                OnPropertyChanged("Users");
            }
        }

        /////////////////////////////////////////////////////////////////////

        private ObservableCollection<string> profession;

        public ObservableCollection<string> Profession
        {
            get
            {
                if (profession == null)
                    profession = Prof();
                return profession;
            }
            set
            {
                profession = value;
                OnPropertyChanged("Profession");
            }
        }

        ////////////////////////////////////////////////////////////////////

        private string selectProf;

        public string SelectProf
        {
            get
            {
                if (selectProf == null)                    
                    selectProf = String.Empty;
                return selectProf;
            }
            set
            {
                selectProf = value;
                OnPropertyChanged("SelectProf");
               
                Users = SearchProfUsers(selectProf);
            }
        }  
        
        /////////////////////////////////////////////////////////////////////     

        private RelayCommand showWinUser;

        public RelayCommand ShowWinUser
        {
            get
            {
                if (showWinUser == null)
                    showWinUser = new RelayCommand(ExecuteShowWinAddUser);
                return showWinUser;
            }
        }       

        private void ExecuteShowWinAddUser(object param)
        {
            win = new View.AddUser();
            win.DataContext = this;
            win.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////

        private RelayCommand addUser;

        public RelayCommand AddUser
        {
            get
            {
                if (addUser == null)
                    addUser = new RelayCommand(ExecuteAddUser, CanExecuteAddUser);
                return addUser;
            }
        }

        private void ExecuteAddUser(object param)
        {
            NewUser.data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = NewUser.item1},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = NewUser.item2},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = NewUser.item3},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = NewUser.item4},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = NewUser.item5} };

            NewUser.projects = new ObservableCollection<Project>();
            temp.Add(NewUser);

            CountRanking(NewUser);
            AllFirmRanking = AllFirm();

            Profession = Prof();
            
            Users = temp;
            NewUser = null;            

            win.Close();
        }

        private bool CanExecuteAddUser(object param)
        {
            if (!String.IsNullOrEmpty(NewUser.birthday) && !String.IsNullOrEmpty(NewUser.city) && !String.IsNullOrEmpty(NewUser.email) &&
                !String.IsNullOrEmpty(NewUser.first) && !String.IsNullOrEmpty(NewUser.gender) && !String.IsNullOrEmpty(NewUser.last) &&
                !String.IsNullOrEmpty(NewUser.street) && !String.IsNullOrEmpty(NewUser.zip) && !String.IsNullOrEmpty(NewUser.workingPosition) &&
                !String.IsNullOrEmpty(NewUser.email) && NewUser.salary > 0 && (NewUser.item1 > 0 && NewUser.item1 <= 100) && (NewUser.item2 > 0 && NewUser.item2 <= 100)
                && (NewUser.item3 > 0 && NewUser.item3 <= 100) && (NewUser.item4 > 0 && NewUser.item4 <= 100) && (NewUser.item5 > 0 && NewUser.item5 <= 100))
                return true;
            else
            {
                return false;
            }
        }

        //////////////////////////////////////////////////////////////////////

        private RelayCommand deleteUser;

        public RelayCommand DeleteUser
        {
            get
            {
                if (deleteUser == null)
                    deleteUser = new RelayCommand(ExecuteDeleteUser, CanExecuteDeleteUser);
                return deleteUser;
            }
        }

        private void ExecuteDeleteUser(object param)
        {
                temp.Remove(SelectUser);
                SelectUser = null;

                Profession = Prof();
                AllFirmRanking = AllFirm(); 
                       
                Users = temp;

                newDeleteWindow.Close();
        }

        private bool CanExecuteDeleteUser(object param)
        {
            if (SelectUser == null)
                return false;
            else
                return true;
        }

        ////////////////////////////////////////////////////////////////////////

        private RelayCommand addPhoto;

        public RelayCommand AddPhoto
        {
            get
            {
                if (addPhoto == null)
                    addPhoto = new RelayCommand(ExecuteAddPhoto);
                return addPhoto;
            }
        }

        private void ExecuteAddPhoto(object param)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                NewUser.large = op.FileName;
                NewUser.thumbnail = op.FileName;
            }
        }

        //////////////////////////////////////////////////////////////////////////////

        private ObservableCollection<Ranking> allFirmRanking;

        public ObservableCollection<Ranking> AllFirmRanking
        {
            get
            {
                if (allFirmRanking == null)
                    allFirmRanking = AllFirm();
                return allFirmRanking;
            }
            set
            {
                allFirmRanking = value;
                OnPropertyChanged("AllFirmRanking");                
            }
        }

        //////////////////////////////////////////////////////////////////////////////

        private RelayCommand showAll;

        public RelayCommand ShowAll
        {
            get
            {
                if (showAll == null)
                    showAll = new RelayCommand(ExecuteShowAll);
                return showAll;
            }
        }

        private void ExecuteShowAll(object param)
        {
            SelectUser = null;          
            Users = temp;            
        }        

        ///////////////////////////////////////////////////////////////////////////////

        private string searchUser;

        public string SearchUser
        {
            get
            {
                if (searchUser == null)
                    searchUser = String.Empty;
                return searchUser;
            }
            set
            {
                searchUser = value;
                OnPropertyChanged("SearchUser");
                Users = SearchProfUsers(searchUser);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////

        private RelayCommand search;

        public RelayCommand Search
        {
            get
            {
                if (search == null)
                    search = new RelayCommand(ExecuteSearch);
                return search;
            }
        }

        private void ExecuteSearch(object param)
        {
            Users = null;
            Users = SearchUsers(searchUser);
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        private DummyUser.User testUser;

        public DummyUser.User TestUser
        {
            get
            {
                if (testUser == null)
                    testUser = new DummyUser.User();
                return testUser;
            }
            set
            {
                testUser = value;
                OnPropertyChanged("TestUser");
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        private RelayCommand newCommand;

        public RelayCommand NewCommand
        {
            get
            {
                if (newCommand == null)
                    newCommand = new RelayCommand(ExecuteNewCommand, CanExecuteNewCommand);
                return newCommand;
            }
        }

        private void ExecuteNewCommand(object param)
        {
            newChangeWindow = new View.ChangeUser();

            testUser = SelectUser;

            testUser = User.CloneUser(SelectUser);

            testUser.item1 = SelectUser.data[0].Number;
            testUser.item2 = SelectUser.data[1].Number;
            testUser.item3 = SelectUser.data[2].Number;
            testUser.item4 = SelectUser.data[3].Number;
            testUser.item5 = SelectUser.data[4].Number;

            newChangeWindow.DataContext = this;
            newChangeWindow.ShowDialog();
        }

        private bool CanExecuteNewCommand(object obj)
        {
            if (SelectUser == null)
                return false;
            else
                return true;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////

        private RelayCommand changeData;

        public RelayCommand ChangeData
        {
            get
            {
                if (changeData == null)
                    changeData = new RelayCommand(ExecuteChangeData);
                return changeData;
            }
        }

        private void ExecuteChangeData(object param)
        {
            TestUser.data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = TestUser.item1},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = TestUser.item2},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = TestUser.item3},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = TestUser.item4},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = TestUser.item5} };

            int index = temp.IndexOf(SelectUser);
            temp.Remove(SelectUser);            

            temp.Insert(index, TestUser);

            CountRanking(TestUser);
            AllFirmRanking = AllFirm();

            Profession = Prof();
            Users = temp;            

            SelectUser = null;
            newChangeWindow.Close();

        }

        private bool CanExecuteChangeUserData(object param)
        {
            if (!String.IsNullOrEmpty(TestUser.birthday) && !String.IsNullOrEmpty(TestUser.city) && !String.IsNullOrEmpty(TestUser.email) &&
                !String.IsNullOrEmpty(TestUser.first) && !String.IsNullOrEmpty(TestUser.gender) && !String.IsNullOrEmpty(TestUser.last) &&
                !String.IsNullOrEmpty(TestUser.street) && !String.IsNullOrEmpty(TestUser.zip) && !String.IsNullOrEmpty(TestUser.workingPosition) &&
                !String.IsNullOrEmpty(TestUser.email) && TestUser.salary > 0 && (TestUser.item1 > 0 && TestUser.item1 <= 100) && (TestUser.item2 > 0 && TestUser.item2 <= 100)
                && (TestUser.item3 > 0 && TestUser.item3 <= 100) && (TestUser.item4 > 0 && TestUser.item4 <= 100) && (TestUser.item5 > 0 && TestUser.item5 <= 100))
                return true;
            else
            {
                return false;
            }
        }        

        ////////////////////////////////////////////////////////////////////////////////
                
        private RelayCommand delCommand;

        public RelayCommand DelCommand
        {
            get
            {
                if (delCommand == null)
                    delCommand = new RelayCommand(ExecuteDelCommand, CanExecuteDeleteCommand);
                return delCommand;
            }
        }

        View.Delete newDeleteWindow;

        private void ExecuteDelCommand(object param)
        {
            newDeleteWindow = new View.Delete();

            newDeleteWindow.DataContext = this;
            newDeleteWindow.ShowDialog();
        }

        private bool CanExecuteDeleteCommand(object param)
        {
            if (SelectUser == null)
                return false;
            else
                return true;
        }

        ///////////////////////////////////////////////////////////////////////////////////

        public ObservableCollection<User> SearchUsers(string search)
        {
            ObservableCollection<User> collection = new ObservableCollection<User>();

            foreach (var item in users)
            {
                string surnameName = String.Format("{0} {1}", item.first, item.last);
                string nameSurname = String.Format("{0} {1}", item.last, item.first);

                string surnameNameLower = surnameName.ToLower();
                string nameSurnameLower = nameSurname.ToLower();
                string name = item.first.ToLower();
                string surname = item.last.ToLower();
                string searchLower = search.ToLower();

                if ((name.Contains(searchLower) || (surname.Contains(searchLower)) || (surnameNameLower.Contains(searchLower)) || (nameSurnameLower.Contains(searchLower))))
                    collection.Add(item);
            }

            return collection;
        }

        private ObservableCollection<User> SearchProfUsers(string search)
        {
            ObservableCollection<User> collection = new ObservableCollection<User>();

            foreach (var item in temp)
            {
                if (item.workingPosition.Contains(search))
                    collection.Add(item);
            }

            return collection;
        }
        /// <summary>
        /// метод, собирающий коллекцию уникальных профессий всех работников фирмы
        /// </summary>
        /// <returns>коллекция профессий</returns>
        public ObservableCollection<string> Prof()
        {
            ObservableCollection<string> prof = new ObservableCollection<string>();

            foreach (var item in temp)
            {
                if (!prof.Contains(item.workingPosition))
                    prof.Add(item.workingPosition);
            }

            return prof;
        }
        /// <summary>
        /// метод, расчитывающий средний рейтинг User'а 
        /// </summary>
        /// <param name="Test">объект класса User</param>
        private void CountRanking(User Test)
        {
            int count = 0;
            double summ = 0;

            foreach (var singledata in Test.data)
            {
                summ += singledata.Number;
                count++;
            }

            Test.rank = summ / count;
        }
        /// <summary>
        /// метод, создающий коллекцию элментов Ranking (Фамилия работника - его средний рейтинг) всех работников фирмы
        /// </summary>
        /// <returns>коллекцию элментов Ranking</returns>
        private ObservableCollection<Ranking> AllFirm()
        {
            ObservableCollection<Ranking> allFirm = new ObservableCollection<Ranking>();

            foreach (var item in temp)
            {
                Ranking newItem = new Ranking() { Category = item.last, Number = item.rank };
                allFirm.Add(newItem);
            }

            return allFirm;
        }
    }
}