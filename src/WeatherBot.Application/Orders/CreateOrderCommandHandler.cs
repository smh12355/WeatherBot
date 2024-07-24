using MediatR;
using System;
using WeatherBot.Application.Data;
using WeatherBot.Domain.Customers;

namespace WeatherBot.Application.Orders;
public sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateOrderCommandHandler(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var customer = await _context.Customers.FindAsync(
            new Customer(request.CustomerId));
    }
}


