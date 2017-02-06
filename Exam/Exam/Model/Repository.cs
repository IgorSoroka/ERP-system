using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam.DummyUser;

namespace Exam
{
    //класс репозиторя, для хранения стартовых значений элементов коллекции Users
    public class Repository
    {
        private static ObservableCollection<User> users;

        public static ObservableCollection<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }
        }
        //статический метод, возвращающий коллекцию Users
        public static ObservableCollection<User> CreateUsers()
        {
            users = new ObservableCollection<User>()
            {
               new User(){id = "0", birthday = "11/12/1950", email = "aa@mail.ru", gender = "male",
                    first = "Chuck", last = "Norris",
                    city = "Minsk", street = "First", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 100},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 100},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 100},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 100},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 100} },
                    salary = 5000, workingPosition = "Director",
                    large = "Pictures/bigChuck.jpg", thumbnail = "Pictures/3.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "first", customer = "epam", executionPercentage = 75, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "second", customer = "itransition", executionPercentage = 75, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

               new User(){id = "3", birthday = "09/06/1963", email = "cc@mail.ru", gender = "male",
                    first = "Johnny", last = "Depp",
                    city = "Minsk", street = "Pobediteley", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 40},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 50},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 65},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 80},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 65} },
                    salary = 1100, workingPosition = "Developer",
                    large = "Pictures/bigDepp.jpg", thumbnail = "Pictures/smallDepp.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "first", customer = "epam", executionPercentage = 60, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "third", customer = "itransition", executionPercentage = 50, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

               new User(){id = "4", birthday = "11/11/1974", email = "dd@mail.ru", gender = "male",
                    first = "Leonardo", last = "DiCaprio",
                    city = "Minsk", street = "Masherova", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 50},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 80},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 45},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 70},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 95} },
                    salary = 1000, workingPosition = "Junior Developer",
                    large = "Pictures/bigDiC.jpg", thumbnail = "Pictures/smallDiC.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "first", customer = "epam", executionPercentage = 80, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "fours", customer = "itransition", executionPercentage = 60, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

                new User(){id = "5", birthday = "15/09/1968", email = "ee@mail.ru", gender = "male",
                    first = "Will", last = "Smith",
                    city = "Minsk", street = "Partyzanski", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 70},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 60},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 85},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 30},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 45} },
                    salary = 1050, workingPosition = "Developer",
                    large = "Pictures/bigSmith.jpg", thumbnail = "Pictures/smallSmith.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "first", customer = "epam", executionPercentage = 60, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "third", customer = "itransition", executionPercentage = 70, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

               new User(){id = "6", birthday = "30/07/1947", email = "ff@mail.ru", gender = "male",
                    first = "Arnold", last = "Schwarzenegger",
                    city = "Minsk", street = "Lenina", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 90},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 80},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 85},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 70},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 85} },
                    salary = 1650, workingPosition = "Lead Developer",
                    large = "Pictures/bigShwartz.jpg", thumbnail = "Pictures/smallShwartz.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "fives", customer = "epam", executionPercentage = 80, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "second", customer = "itransition", executionPercentage = 60, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

              new User(){id = "7", birthday = "26/07/1967", email = "gg@mail.ru", gender = "male",
                    first = "Jason", last = "Statham",
                    city = "Minsk", street = "Dzrjinskogo", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 60},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 90},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 85},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 60},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 65} },
                    salary = 1100, workingPosition = "Lead QA engineer",
                    large = "Pictures/bigStatham.jpg", thumbnail = "Pictures/smallStatham.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "fives", customer = "epam", executionPercentage = 60, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "first", customer = "itransition", executionPercentage = 50, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

              new User(){id = "8", birthday = "15/09/1977", email = "kk@mail.ru", gender = "male",
                    first = "Tom", last = "Hardy",
                    city = "Minsk", street = "Zhukova", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 50},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 70},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 65},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 40},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 55} },
                    salary = 750, workingPosition = "QA engineer",
                    large = "Pictures/bigHardy.jpg", thumbnail = "Pictures/smallHardy.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "third", customer = "epam", executionPercentage = 50, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "first", customer = "itransition", executionPercentage = 30, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

              new User(){id = "9", birthday = "19/03/1955", email = "ll@mail.ru", gender = "male",
                    first = "Bruce", last = "Willis",
                    city = "Minsk", street = "Ponomaronko", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 80},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 90},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 75},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 70},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 85} },
                    salary = 1650, workingPosition = "Business analyst",
                    large = "Pictures/bigBruce.jpg", thumbnail = "Pictures/smallBruce.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "third", customer = "epam", executionPercentage = 90, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "first", customer = "itransition", executionPercentage = 70, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

             new User(){id = "10", birthday = "02/07/1990", email = "mm@mail.ru", gender = "female",
                    first = "Margo", last = "Robbie",
                    city = "Minsk", street = "Masherovva", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 70},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 70},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 65},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 80},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 95} },
                    salary = 850, workingPosition = "HR",
                    large = "Pictures/bigRobbie.jpg", thumbnail = "Pictures/smallRobbie.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "fives", customer = "epam", executionPercentage = 80, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "second", customer = "itransition", executionPercentage = 60, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

            new User(){id = "11", birthday = "16/05/1986", email = "tt@mail.ru", gender = "female",
                    first = "Megan", last = "Fox",
                    city = "Minsk", street = "Orlovskaya", zip = "12345",
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 70},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 90},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 85},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 90},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 75} },
                    salary = 1150, workingPosition = "Accountant",
                    large = "Pictures/bigFox.jpg", thumbnail = "Pictures/sallFox.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "fives", customer = "epam", executionPercentage = 60, beginDate = "11/12/2016", endDate = "12/12/2016" },
                             new Project {projectName = "fours", customer = "itransition", executionPercentage = 70, beginDate = "12/12/2016", endDate = "14/12/2016"  } }
                },

                new User(){id = "1", birthday = "12/12/2015", email = "bb@mail.ru", gender = "female",
                    first = "Nataly", last = "Portman",
                    city = "Minsk", street = "Second", zip = "12345", 
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 45},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 65},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 70},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 10},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 100} },
                    salary = 400, workingPosition = "Designer",
                    large = "Pictures/bigPort.jpg", thumbnail = "Pictures/smallPort.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "third", customer = "epam", executionPercentage = 85, beginDate = "13/12/2016", endDate = "14/12/2016" },
                             new Project {projectName = "fours", customer = "itransition", executionPercentage = 85, beginDate = "14/12/2016", endDate = "16/12/2016"  } }
                },                 

                new User(){id = "2", birthday = "12/12/2014", email = "vv@mail.ru", gender = "female",
                    first = "Ann", last = "Hathaway",
                    city = "Minsk", street = "Third", zip = "12345", 
                    data = new ObservableCollection<Ranking> { new Ranking() { Category = "Effectiveness Of Teamwork" , Number = 55},
                                           new Ranking() { Category = "Percentage Successfully Completed Projects" , Number = 15},
                                           new Ranking() { Category = "Effectiveness Leadership Development Team" , Number = 50},
                                           new Ranking() { Category = "Rating Positive Customer Feedback" , Number = 70},
                                           new Ranking() { Category = "Rating Colleagues Reviews" , Number = 20} },
                    salary = 1400, workingPosition = "Designer",
                    large = "Pictures/bigHath.jpg", thumbnail = "Pictures/smallHath.jpg",
                    projects = new ObservableCollection<Project> {new Project {projectName = "fives", customer = "epam", executionPercentage = 95, beginDate = "13/12/2016", endDate = "14/12/2016" },
                             new Project {projectName = "sixes", customer = "itransition", executionPercentage = 95, beginDate = "14/12/2016", endDate = "16/12/2016"  } }
                }                
            };

            foreach (var item in users)
            {
                int count = 0;
                double summ = 0;

                foreach (var singledata in item.data)
                {
                    summ += singledata.Number;
                    count++;
                }

                item.rank = summ / count;
            }

            return users;
        }        
    }
}
