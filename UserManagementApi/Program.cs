using Microsoft.AspNetCore.HttpLogging;
using UserManagementApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddControllers();
builder.Services.AddHttpLogging(logging => {
    logging.LoggingFields = HttpLoggingFields.All;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseExceptionHandler("/error");
app.MapControllers();
app.Run();