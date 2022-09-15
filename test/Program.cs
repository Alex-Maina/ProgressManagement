// See https://aka.ms/new-console-template for more information
using PTSLibrary;
using PTSLibrary.DataAccess;
using PTSLibrary.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //Initialize DB connection
        PTSLibrary.GlobalConfig.InitializeConnections(true);
        Console.WriteLine("Let's test the db connection - Add Project");

        Console.Write("\nEnter Project Name: ");
        string ProjectName = Console.ReadLine();

        Console.Write("\nEnter Project Description: ");
        string ProjectDescription = Console.ReadLine();

        Console.Write("\nEnter Project Level: ");
        string Level = Console.ReadLine();

        Console.Write("\nEnter expected project duration in weeks: ");
        string ProjectDuration = Console.ReadLine();
        int Duration = Int32.Parse(ProjectDuration);

        string github = "";
        string link = "";

        ProjectModel model = new(ProjectName,ProjectDescription,Level,Duration,github,link);
        Console.WriteLine(model.ProjectID);

        foreach (IDataConnection db in GlobalConfig.Connections)
        {
            db.CreateProject(model);
        }

        Console.Read();
    }
}