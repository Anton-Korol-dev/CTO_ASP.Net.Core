using Microsoft.EntityFrameworkCore;
using System;
using WEB1;
using WEB1.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

var services = builder.Services;

var app = builder.Build();

app.MapGet("/", (ApplicationContext db) => db.Clients.ToList());


app.MapGet("/clientsbyphone/{phonenumber}", async (string phonenumber, ApplicationContext db) =>
{
    Clients? clients = await db.Clients.FirstOrDefaultAsync(u => u.PhoneNumber == phonenumber);
    if (clients == null)
    {
        return Results.NotFound(new { message = "Клієнта по номеру телефона не знайдено" });
    }
    return Results.Json(clients);
});

app.MapGet("/clientsbyname/{firstname}", async (string firstname, ApplicationContext db) =>
{
    var clients = await db.Clients.Where(u => u.FirstName == firstname).ToListAsync();
    if (clients == null)
    {
        return Results.NotFound(new { message = "Клієнтів імені не знайдено" });
    }
    return Results.Json(clients);
});


app.MapPost("/addclients", (string firstname, string middlename, string lastname, string phonenumber, ApplicationContext db) =>
{
    Clients clients = new Clients();
    clients.FirstName = firstname;
    clients.MiddleName = middlename;
    clients.LastName = lastname;
    clients.PhoneNumber = phonenumber;
    db.Clients.Add(clients);
    db.SaveChanges();
    return clients;
});

app.Run();