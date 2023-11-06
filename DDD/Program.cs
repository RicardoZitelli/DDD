using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using DDD.Application.Mapping;
using DDD.Infrastructure.CrossCutting.IOC;
using DDD.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();

var connectionString = builder
    .Configuration
    .GetConnectionString("DefaultConnection")?
    .Replace("{Server}", Environment.GetEnvironmentVariable("DB_HOST"))
    .Replace("{Port}", Environment.GetEnvironmentVariable("DB_PORT"))
    .Replace("{Database}", Environment.GetEnvironmentVariable("DB_NAME"))
    .Replace("{User_Id}", Environment.GetEnvironmentVariable("DB_SA_USER_ID"))
    .Replace("{Password}", Environment.GetEnvironmentVariable("DB_SA_PASSWORD"));

builder.Services.AddDbContext<SqlContext>(options => 
    options.UseSqlServer(string.IsNullOrWhiteSpace(connectionString) ? "DefaultConnection2" : connectionString));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new ModuleIOC()));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {               
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

var app = builder.Build();

SqlContext dbcontext = app.Services.GetRequiredService<SqlContext>();
dbcontext.Database.Migrate();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowAnyOrigin");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
