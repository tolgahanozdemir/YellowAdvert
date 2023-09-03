using FluentValidation.AspNetCore;
using FluentValidation;
using YellowAdvert.Business.DependencyResolver;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.DataAccess.Concrete.EntityFramework;
using YellowAdvert.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using MediatR;
using YellowAdvert.Cqrs.Registration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();
Setup.ConfigureServices(builder.Services);
GenericDependencyResolver.ConfigureServices(builder.Services);
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    options.InstanceName = "ProductAttributes_";
});
builder.Services.AddDbContext<YellowAdvertEfContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"), configure =>
    {
        configure.MigrationsAssembly("YellowAdvert.DataAccess");
    });
});
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
