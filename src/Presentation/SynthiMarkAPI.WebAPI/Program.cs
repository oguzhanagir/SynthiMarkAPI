using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.MSSqlServer;
using SynthiMarkAPI.Application;
using SynthiMarkAPI.Application.Features.Commands.AppUser.CreateUser;
using SynthiMarkAPI.Infrastructure;
using SynthiMarkAPI.Infrastructure.Filters;
using SynthiMarkAPI.Infrastructure.Services.Storage.Local;
using SynthiMarkAPI.Persistence;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();


builder.Services.AddStorage<LocalStorage>();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
policy.AllowAnyOrigin().AllowAnyHeader().AllowCredentials()));

var log = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt")
            .WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("MSSQL"), sinkOptions: new MSSqlServerSinkOptions()
            {
                TableName = "logs", // Tablo adý
                AutoCreateSqlTable = true, // Otomatik tablo oluþturma
                AutoCreateSqlDatabase = true, // Otomatik veritabaný oluþturma
                BatchPostingLimit = 1, // Verileri anlýk olarak yazmak için
                BatchPeriod = TimeSpan.FromSeconds(1), // Yazma periyodu
                

            }, columnOptions: new ColumnOptions()
            {
                AdditionalColumns = new Collection<SqlColumn>()
                    {
                        new SqlColumn { DataType = SqlDbType.NVarChar, ColumnName = "UserName", AllowNull = true },
                    }
            }).Enrich.FromLogContext()
            .MinimumLevel.Information()
            .CreateLogger(); //todo burada oluþturulan UserName kolonu harici olarak oluþturulmuþtur buna gelen deðer iþaretlenmesi kontrol edilecektir.

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;

});


builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateUserCommandRequest>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer("Admin", options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidAudience = builder.Configuration["Token:Audience"],
        ValidIssuer = builder.Configuration["Token:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
        LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.Now : false

    };
});



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpLogging();

app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var username = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identity.Name : null;

    LogContext.PushProperty("UserName",username);

    await next();
});

app.MapControllers();

app.Run();
