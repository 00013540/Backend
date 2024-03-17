using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContexts;
using WebApplication1.Interfaces;
using WebApplication1.Profiles;
using WebApplication1.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile_00013540));
builder.Services.AddScoped<ITasksRepository_00013540, TasksRepository_00013540>();
builder.Services.AddDbContext<AppDbContext_00013540>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("TasksDb"));
});

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