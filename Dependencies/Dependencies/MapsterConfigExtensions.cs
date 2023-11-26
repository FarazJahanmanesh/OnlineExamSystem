using Application.Helpers;
using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using Domain.Entities;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct.Resources;

namespace Dependencies.Dependencies
{
    public static class MapsterConfigExtensions
    {
        public static void ConfigureMappings(this IServiceCollection services)
        {
            TypeAdapterConfig.GlobalSettings.Default.NameMatchingStrategy(NameMatchingStrategy.Flexible);

            TypeAdapterConfig.GlobalSettings.ForType<UserLoginDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            TypeAdapterConfig.GlobalSettings.ForType<CreateUserDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            TypeAdapterConfig.GlobalSettings.ForType<ChangeUserPasswordDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            TypeAdapterConfig.GlobalSettings.ForType<UpdateUserDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());

            TypeAdapterConfig.GlobalSettings.ForType<CreateAcademyDetailDto, Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            TypeAdapterConfig.GlobalSettings.ForType<AcademiesLoginDetailDto, Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            TypeAdapterConfig.GlobalSettings.ForType<ChangeAcademyPasswordDetailDto, Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            TypeAdapterConfig.GlobalSettings.ForType<UpdateAcademyDetailDto, Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA512HashCode());
            
            services.AddSingleton(TypeAdapterConfig.GlobalSettings);
        }
    }
}
