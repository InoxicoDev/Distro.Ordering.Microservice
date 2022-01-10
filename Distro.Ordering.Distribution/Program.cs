using Distro.Domain.Common;
using Distro.Ordering.Application.Services;
using Distro.Ordering.DataAccess;
using Distro.Ordering.DataAccess.Repositories;
using Distro.Ordering.Domain.Contracts;
using Distro.Ordering.Domain.Contracts.Repositories;
using Distro.Ordering.Domain.Events;
using Distro.Seedwork.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// EF Configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));

// DI Configuration (Removed for not to allow for unit of work implimentation)
// builder.Services.AddScoped<IOrderService, OrderService>();
// builder.Services.AddScoped<IRepository<Order>, OrderRepository>();

//Domain Publisher
builder.Services.AddScoped<IDomainEventDispatcher, DomainEventDispatcher>();
builder.Services.AddTransient<IDomainEventHandler<OrderUpdatedDomainEvent>,OrderUpdatedDomainEventHandler>();
builder.Services.AddTransient<IDomainRequestHandler<GetOrderNumberDomainRequest, string>, GetOrderNumberDomainRequestHandler>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();


var app = builder.Build();

//DomainEventPublisher.SetInstance(app.Services.GetRequiredService<IDomainEventDispatcher>());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<DomainEventDispatcherInstantiationMiddleware>();

app.Run();
