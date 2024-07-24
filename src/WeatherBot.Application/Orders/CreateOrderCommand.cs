using MediatR;
using System;

namespace WeatherBot.Application.Orders;
public record CreateOrderCommand(Guid CustomerId) : IRequest;


