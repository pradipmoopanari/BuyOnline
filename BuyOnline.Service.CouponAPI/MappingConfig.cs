using AutoMapper;
using BuyOnline.Service.CouponAPI.Models;
using BuyOnline.Service.CouponAPI.Models.Dto;

namespace BuyOnline.Service.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
