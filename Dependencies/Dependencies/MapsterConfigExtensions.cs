using Application.Helpers;
using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using Domain.Entities;
using Mapster;
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
        public static void UsePasswordHashing(this TypeAdapterConfig config)
        {
            config.ForType<ChangeAcademyPasswordDetailDto, Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());
            config.ForType<AcademiesLoginDetailDto, Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());
            config.ForType<CreateAcademyDetailDto, Academy >()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());
            config.ForType<UpdateAcademyDetailDto,Academy>()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());

            config.ForType<UpdateUserDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());
            config.ForType<CreateUserDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());
            config.ForType<UserLoginDetailDto,User > ()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());
            config.ForType<ChangeUserPasswordDetailDto, User>()
                .Map(dest => dest.Password, src => src.Password.SHA1HashCode());

        }
    }
}
