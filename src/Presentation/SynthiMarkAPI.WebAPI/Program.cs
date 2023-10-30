using FluentValidation.AspNetCore;
using SynthiMarkAPI.Application.ViewModels.Advertisings;
using SynthiMarkAPI.Infrastructure.Filters;
using SynthiMarkAPI.Persistence;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceService();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
policy.AllowAnyOrigin().AllowAnyHeader().AllowCredentials()));

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<VMCreateAdvertising>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
