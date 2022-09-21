// See https://aka.ms/new-console-template for more information
using PTSLibrary;
using PTSLibrary.DataAccess;
using PTSLibrary.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //Initialize DB connection
        PTSLibrary.GlobalConfig.InitializeConnections();
        Console.WriteLine("Let's test the db connection - Add Project");

        Console.Write("\nEnter Project Name: ");
        string ProjectName = Console.ReadLine();

        Console.Write("\nEnter Project Description: ");
        string ProjectDescription = Console.ReadLine();

        Console.Write("\nEnter Project Tasks: ");
        string ProjectTasks= Console.ReadLine();

        Console.Write("\nEnter Project Level: ");
        string Level = Console.ReadLine();

        Console.Write("\nEnter expected project duration in weeks: ");
        string ProjectDuration = Console.ReadLine();
        int Duration = Int32.Parse(ProjectDuration);

        string github = "";
        string link = "";

        ProjectModel model = new(ProjectName,ProjectDescription, ProjectTasks, Level, Duration,github,link);

        GlobalConfig.connection.Create_Project(model);

        Console.WriteLine("DB Insert was successful!");

        Console.Read();
    }
}