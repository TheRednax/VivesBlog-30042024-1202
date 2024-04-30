using Microsoft.EntityFrameworkCore;
using VivesBlog.Ui.Mvc.Models;

namespace VivesBlog.Ui.Mvc.Core
{
    public class VivesBlogDbContext(DbContextOptions<VivesBlogDbContext> options): DbContext(options)
    {
        public DbSet<Article> Articles => Set<Article>();
        public DbSet<Person> People => Set<Person>();

        public void Seed()
        {
            var people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Person { FirstName = "Jane", LastName = "Doe" },
                new Person { FirstName = "Emily", LastName = "Smith", Email = "emily.smith@example.com" },
                new Person { FirstName = "Michael", LastName = "Brown" },
                new Person { FirstName = "Jessica", LastName = "Johnson" },
                new Person { FirstName = "William", LastName = "Davis", Email = "william.davis@example.com" },
                new Person { FirstName = "Olivia", LastName = "Miller" },
                new Person { FirstName = "Henry", LastName = "Wilson", Email = "henry.wilson@example.com" },
                new Person { FirstName = "Ava", LastName = "Moore" },
                new Person { FirstName = "Sophia", LastName = "Taylor" },
                new Person { FirstName = "James", LastName = "Anderson", Email = "james.anderson@example.com" },
                new Person { FirstName = "Isabella", LastName = "Thomas" },
                new Person { FirstName = "Alexander", LastName = "Jackson" },
                new Person { FirstName = "Mia", LastName = "White", Email = "mia.white@example.com" },
                new Person { FirstName = "Charlotte", LastName = "Harris" },
                new Person { FirstName = "Benjamin", LastName = "Martin", Email = "benjamin.martin@example.com" },
                new Person { FirstName = "Amelia", LastName = "Thompson" },
                new Person { FirstName = "Ethan", LastName = "Garcia" },
                new Person { FirstName = "Harper", LastName = "Martinez" },
                new Person { FirstName = "Lucas", LastName = "Robinson", Email = "lucas.robinson@example.com" }
            };

            People.AddRange(people);

            var bavoAuthor = new Person { FirstName = "Bavo", LastName = "Ketels", Email = "bavo.ketels@vives.be" };
            People.Add(bavoAuthor);

            Articles.AddRange(new List<Article>
            {
                new Article
                {
                    Title = "Understanding C# Records",
                    Author = bavoAuthor,
                    PublishedDate = new DateTime(2023, 10, 5),
                    Description =
                        "An in-depth look at records in C# 9.0 and how they can be used to simplify your data models.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Getting Started with ASP.NET Core",
                    PublishedDate = new DateTime(2023, 9, 15),
                    Description = "A beginner's guide to building web applications using ASP.NET Core and C#.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "C# 10 Features You Need to Know",
                    PublishedDate = new DateTime(2023, 11, 20),
                    Description =
                        "Explore the new features introduced in C# 10 and how they can improve your coding efficiency.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Effective Debugging in Visual Studio",
                    Author = bavoAuthor,
                    PublishedDate = new DateTime(2023, 8, 30),
                    Description =
                        "Learn how to leverage the debugging tools in Visual Studio to quickly find and fix issues in your C# applications.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Asynchronous Programming in C#",
                    PublishedDate = new DateTime(2023, 9, 20),
                    Description =
                        "An overview of async and await keywords in C# for writing efficient asynchronous code.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Implementing SOLID Principles in C#",
                    PublishedDate = new DateTime(2023, 10, 25),
                    Description =
                        "A practical guide to applying SOLID principles to improve the design and maintainability of your C# applications.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Unit Testing Best Practices in C#",
                    Author = bavoAuthor,
                    PublishedDate = new DateTime(2023, 12, 5),
                    Description =
                        "Discover best practices for writing effective unit tests in C# that ensure your code is robust and bug-free.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Exploring .NET 6: What's New for Developers",
                    PublishedDate = new DateTime(2023, 11, 1),
                    Description =
                        "Dive into the new features and improvements in .NET 6 that C# developers should be excited about.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Building RESTful APIs with ASP.NET Core",
                    PublishedDate = new DateTime(2023, 10, 10),
                    Description =
                        "Learn how to design and implement RESTful APIs using ASP.NET Core that are scalable and secure.",
                    Content = "Content of the article goes here..."
                },
                new Article
                {
                    Title = "Mastering LINQ in C# for Data Manipulation",
                    PublishedDate = new DateTime(2023, 11, 15),
                    Description =
                        "An in-depth guide to using LINQ in C# to query and manipulate collections and data sources with ease.",
                    Content = "Content of the article goes here..."
                }
            });

            SaveChanges();
        }
    }
}
