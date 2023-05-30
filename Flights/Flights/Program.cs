using Flights.controllers;
using Flights.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace Flights;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        var contextOptions  = new DbContextOptionsBuilder<DBContext>()
            .UseSqlite("Data Source=C:\\Andrada\\UBB INFO\\An2Sem2\\ISS\\Flights\\flights.db").Options;
            
        var context = new DBContext(contextOptions);
        Service.Service service = new Service.Service(context);
        ApplicationConfiguration.Initialize();
        LogInController logInController = new LogInController(service);
        Application.Run(new LogIn(logInController));
    }
}