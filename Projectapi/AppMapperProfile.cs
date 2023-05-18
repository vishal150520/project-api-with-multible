using AutoMapper;
using Projectapi.Data.Entities;
using Projectapi.Dtos;

namespace Projectapi
{
    public class AppMapperProfile:Profile
    {
        public AppMapperProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<CustomerAddressesDto, CustomerAddresses>();
        }

       
    }
}
