using ApiNet7WithJwtAndIdentity.Context;
using ApiNet7WithJwtAndIdentity.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

builder.Services.AddAuthentication(options =>
{
  options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
  options.TokenValidationParameters = new TokenValidationParameters()
  {
    ValidateActor = true,
    ValidateIssuer = true,
    ValidateAudience = true,
    RequireExpirationTime = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = builder.Configuration.GetSection("JwtSettings:Issuer").Value,
    ValidAudience = builder.Configuration.GetSection("JwtSettings:Audience").Value,
    IssuerSigningKey = new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JwtSettings:Key").Value!)
    ),
  };
});

builder.Services.AddTransient<IAuthService, AuthService>();

// Enable Cors Pt1
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
  var frontEndUrl = configuration.GetValue<string>("FrontEndUrl");


  options.AddDefaultPolicy(builder =>
  {
    builder.WithOrigins(frontEndUrl).AllowAnyHeader().AllowAnyMethod().AllowCredentials();
  });
});

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

// Enable Cors Pt2
app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
