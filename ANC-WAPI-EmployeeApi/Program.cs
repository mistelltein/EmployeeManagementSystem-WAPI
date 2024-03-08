using ANC_WAPI_EmployeeApi.Data;
using ANC_WAPI_EmployeeApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.GetConnectionString("EmployeeManagement");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("EmployeeManagement")));
builder.Services.AddScoped<EmployeeDatabase>();
builder.Services.AddScoped<EmployeeSoapService>();

var appSettingsSection = builder.Configuration.GetSection("AppSettings");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
