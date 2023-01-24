using Microsoft.EntityFrameworkCore;
using SACM.Data;

var builder = WebApplication.CreateBuilder(args);

var ConnectionString = builder.Configuration.GetConnectionString("SacmConnection");


builder.Services.AddDbContext<SacmContext>(
    options => options.UseLazyLoadingProxies()
                      .UseMySql(ConnectionString, ServerVersion
                      .AutoDetect(ConnectionString)));

builder.Services.AddControllers().AddNewtonsoftJson(options =>
                                                    options.SerializerSettings.
                                                    ReferenceLoopHandling = Newtonsoft.Json.
                                                    ReferenceLoopHandling.Ignore);

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
