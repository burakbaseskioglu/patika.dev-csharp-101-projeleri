using System.Collections.Generic;

namespace VotingApp
{
    public class User
    {
        public User(string userName, string fullName)
        {
            //this.Id = id;
            this.UserName = userName;
            this.FullName = fullName;
        }

        //private int id;
        private string userName;
        private string fullName;

        //public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }

    public static class UserDataSource
    {
        public static List<User> UserList;

        static UserDataSource()
        {
            UserList = AddUsers();
        }

        private static List<User> AddUsers()
        {
            return new List<User>()
            {
                new User("a_aydin", "Ali Aydın"),
                new User("fatih_y15", "Fatih Yılmaz"),
                new User("ayse_bekci", "Ayşe Bekçi"),
                new User("fabilgili14", "Fatma Bilgili")
            };
        }
    }
}