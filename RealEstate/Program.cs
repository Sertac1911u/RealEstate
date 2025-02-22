using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Interfaces.ICrudServices;
using RealEstate.Mappers;
using RealEstate.Services.CrudServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSql"))); //Sql Server kullancak olursak değiştirirsin
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(EstateMapper), typeof(CategoryMapper));
builder.Services.AddScoped<IEstateCrudService, EstateCrudService>();
builder.Services.AddScoped<ICategoryCrudService, CategoryCrudService>();

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
