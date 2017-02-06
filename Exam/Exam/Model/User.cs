using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Exam.DummyUser;

namespace Exam
{
    public class DummyUser
    {
        public class User
        {
            public string id { get; set; }

            public string first { get; set; }
            public string last { get; set; }

            public string street { get; set; }
            public string city { get; set; }
            public string zip { get; set; }

            public string large { get; set; }
            public string thumbnail { get; set; }

            public string workingPosition { get; set; }
            public int salary { get; set; }
            public double rank { get; set; }

            public ObservableCollection<Project> projects { get; set; }
            public ObservableCollection<Ranking> data { get; set; }

            public string birthday { get; set; }
            public string gender { get; set; }
            public string email { get; set; }

            public double item1 { get; set; }
            public double item2 { get; set; }
            public double item3 { get; set; }
            public double item4 { get; set; }
            public double item5 { get; set; }

            public Project newProject { get; set; }

            //метод для создания глубокой копии объекта
            public static User CloneUser(User ob)
            {
                User NewUser = new User();

                NewUser.birthday = ob.birthday;
                NewUser.city = ob.city;
                NewUser.data = ob.data;
                NewUser.email = ob.email;
                NewUser.first = ob.first;
                NewUser.gender = ob.gender;
                NewUser.id = ob.id;
                NewUser.large = ob.large;
                NewUser.last = ob.last;
                NewUser.newProject = ob.newProject;
                NewUser.projects = ob.projects;
                NewUser.rank = ob.rank;
                NewUser.salary = ob.salary;
                NewUser.street = ob.street;
                NewUser.thumbnail = ob.thumbnail;
                NewUser.workingPosition = ob.workingPosition;
                NewUser.zip = ob.zip;

                NewUser.item1 = ob.item1;
                NewUser.item2 = ob.item2;
                NewUser.item3 = ob.item3;
                NewUser.item4 = ob.item4;
                NewUser.item5 = ob.item5;

                return NewUser;
            }
        }

        public class Project
        {
            public string projectName { get; set; }
            public string customer { get; set; }
            public string beginDate { get; set; }
            public string endDate { get; set; }
            public int executionPercentage { get; set; }
        }
    }

        // class which represent a data point in the chart
        public class Ranking
        {
            public string Category { get; set; }

            public double Number { get; set; }
        }
}