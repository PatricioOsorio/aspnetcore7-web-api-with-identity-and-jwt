using ApiNet7WithJwtAndIdentity.Context;
using ApiNet7WithJwtAndIdentity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Uso de SQL Server
builder.Services.AddDbContext<AuthIdentityDbContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value);
});

// Inyeccion del identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
  options.Password.RequiredLength = 5;
})
  .AddEntityFrameworkStores<AuthIdentityDbContext>()
  .AddDefaultTokenProviders();

builder.Services.AddTransient<IAuthService, AuthService>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
