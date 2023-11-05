using Autofac;
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
    .Replace("{Database}", "DB_NAME")    
    .Replace("{Password}", "DB_SA_PASSWORD");

builder.Services.AddDbContext<SqlContext>(options => 
    options.UseSqlServer());

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new ModuleIOC()));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

var app = builder.Build();

SqlContext dbcontext = app.Services.GetRequiredService<SqlContext>();
dbcontext.Database.Migrate();

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
