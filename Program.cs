using Microsoft.EntityFrameworkCore;
using SACM.Data;
using SACM.Repositories;
using SACM.Services;

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

//Injeção de dependência
builder.Services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
builder.Services.AddScoped<IEspecialidadeService, EspecialidadeService>();

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
