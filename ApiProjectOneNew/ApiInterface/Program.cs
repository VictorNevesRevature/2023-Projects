
namespace ApiInterface;
using BusinessLayer;
using ModelsLayer;
using RepoLayer;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        builder.Services.AddScoped<IBusPostEmployee, BusPostEmployee>();

        builder.Services.AddScoped<IRepoPostEmployee, RepoPostEmployee>();

        builder.Services.AddScoped<IGettingEmployeeInfo, GettingEmployeeInfo>();

        builder.Services.AddScoped<IRepoGettingEmployeeInfo, RepoGettingEmployeeInfo>();
        
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        //builder.Services.AddScoped<IRepoLayer,RepositoryClass>();
        //builder.Services.AddScoped<IBusinessLayer, EmployeeService>();
        //builder.Services.AddScoped<IBusinessLayer, TicketRequests>();
        //builder.Services.AddScoped<IRepoLayer, RepositoryClass>();
        //builder.Services.AddSingleton<IMyLogger, MyLogger>();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
