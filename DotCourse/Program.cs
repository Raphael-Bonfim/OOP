using DotCourse.ContentContext;

namespace DotCourse;

class Program
{
    static void Main(string[] args)
    {
        var articles = new List<Article>();
        articles.Add(new Article("Article about OOP", "object-oriented"));
        articles.Add(new Article("Article about C#", "csharp"));
        articles.Add(new Article("Article about .NET", "dotnet"));

        foreach (var article in articles)
        {
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);
        }

        var courses = new List<Course>();
        var courseOOP = new Course("OOP Fundamentals", "oop-fundamentals");
        var courseCsharp = new Course("C# Fundamentals", "csharp-fundamentals");
        var courseAspnet = new Course(".NET Fundamentals", "dotnet-fundamentals");

        courses.Add(courseOOP);
        courses.Add(courseCsharp);
        courses.Add(courseAspnet);

        var careers = new List<Career>();
        var careerDotnet = new Career(".NET Specialist", "especialista-dotnet ");
        var careerItem = new CareerItem(1, "Start Here", "", null);
        var careerItem2 = new CareerItem(2, "Learn .NET", "", null);
        var careerItem3 = new CareerItem(3, "Learn OOP", "", null);

        careerDotnet.Items.Add(careerItem);
        careerDotnet.Items.Add(careerItem2);
        careerDotnet.Items.Add(careerItem3);
        careers.Add(careerDotnet);

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);

            foreach (var item in career.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
            }
        }
    }
}
