using AutoMapper;
using EventBus.Messages.Events;
using Ordering.Application.Features.Orders.Commands.CheckoutOrder;

namespace Ordering.Service.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, CheckoutEvent>().ReverseMap();
        }
    }
}
