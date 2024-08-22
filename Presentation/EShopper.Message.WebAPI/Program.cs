using EShopper.Message.Application.Features.Mediator.Handlers;
using EShopper.Message.Application.Interfaces;
using EShopper.Message.Persistance.Context;
using EShopper.Message.Persistence.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddMediatR(opts => opts.RegisterServicesFromAssemblyContaining<CreateMessageCommandHandler>());
builder.Services.AddDbContext<MessageContext>(opts =>
{
    opts.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
