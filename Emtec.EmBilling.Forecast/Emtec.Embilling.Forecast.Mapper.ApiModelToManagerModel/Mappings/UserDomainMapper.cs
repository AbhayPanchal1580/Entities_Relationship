using AutoMapper;
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using Emtec.EmBilling.Forecast.Manager.Models.Domain_Library;


namespace Emtec.Embilling.Forecast.Mapper.ApiModelToManagerModel.Mappings
{
    public class UserDomainMapper : Profile
    {
        public UserDomainMapper()
        {
            CreateMap<User, UserManagerModel>();
        }

    }
}
