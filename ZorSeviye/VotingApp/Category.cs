using System.Collections.Generic;

namespace VotingApp
{
    public class Category
    {
        public Category(string name, int vote)
        {
            this.Name = name;
            this.Vote = vote;
        }

        private string name;
        private int vote;

        public string Name { get => name; set => name = value; }
        public int Vote { get => vote; set => vote = value; }
    }

    public static class CategoryDataSource
    {
        static CategoryDataSource()
        {
            CategoryList = AddCategories();
        }

        public static List<Category> CategoryList;


        private static List<Category> AddCategories()
        {
            return new List<Category>()
            {
                new Category("Film", 10),
                new Category("Müzik", 22),
                new Category("Tech Stack", 5),
                new Category("Spor", 19)
            };
        }
    }
}