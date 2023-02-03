using AutoMapper;
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using Emtec.EmBilling.Forecast.Manager.Models.Domain_Library;

namespace Emtec.EmBilling.Forecast.Api.AutoMapperProfile
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            //Source to destination
            CreateMap<User, UserManagerModel>();

        }
       
    }
}
