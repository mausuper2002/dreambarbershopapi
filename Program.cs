using HairSalonBookingApp.Model.Repository;
using HairSalonBookingApp.Model.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;


var builder = WebApplication.CreateBuilder(args);

// Thêm các service vào container.
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddSingleton<UserRepository>(); // Singleton cho user data
builder.Services.AddSingleton<StylistRepository>(); // Singleton cho stylist data
builder.Services.AddControllers();

// Thêm cấu hình xác thực và phân quyền (nếu bạn sử dụng JWT)
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        // Cấu hình JWT cho việc bảo mật
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CustomerPolicy", policy => policy.RequireRole("Customer"));
    options.AddPolicy("ManagerPolicy", policy => policy.RequireRole("Manager"));
});

var app = builder.Build();

// Middleware để dùng authentication và authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
