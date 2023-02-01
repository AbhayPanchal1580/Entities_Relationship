using EmBillingWebAPI.Infrastructure;
using EmBillingWebAPI.Manager.RolesService;
using EmBillingWebAPI.Manager.UserService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Register Configuration
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Database Service

builder.Services.AddDbContext<EmBillingWebAPI.Infrastructure.DataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
  b => b.MigrationsAssembly("EmBillingWebAPI.API"))); 

//Users---------------------------------------------------
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IUsersRepository,UsersRepository>() ;

//------------------------------------------------------------
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRoleService, RolesService>();

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
