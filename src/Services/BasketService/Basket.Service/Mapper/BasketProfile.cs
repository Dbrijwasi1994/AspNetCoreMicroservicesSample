using AutoMapper;
using Basket.Service.Entities;
using EventBus.Messages.Events;

namespace Basket.Service.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, CheckoutEvent>().ReverseMap();
        }
    }
}
