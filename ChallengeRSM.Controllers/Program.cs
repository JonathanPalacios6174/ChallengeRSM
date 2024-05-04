using ChallengeRSM.Application.Services;
using ChallengeRSM.Domain.Interface.Repositories;
using ChallengeRSM.Domain.Interface.Services;
using ChallengeRSM.Infrastructure;
using ChallengeRSM.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AdvWorksDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        opt => opt.MigrationsAssembly(typeof(AdvWorksDbContext).Assembly.FullName));
});

builder.Services.AddTransient<ISalesReportRepository, SalesReportRepository >();
builder.Services.AddTransient<ISalesReportService, SalesReportService>();

builder.Services.AddTransient<ITopProductRepository, TopProductRepository>();
builder.Services.AddTransient<ITopProductService, TopProductService>();


var app = builder.Build();

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
