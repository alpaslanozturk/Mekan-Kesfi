using AutoMapper;
using MekanKesfi.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MekanKesfi.Dto.Dto.IlcelerDTO;
using static MekanKesfi.Dto.Dto.IllerDTO;
using static MekanKesfi.Dto.Dto.MekanlarDTO;
using static MekanKesfi.Dto.Dto.ReklamlarDTO;
using static MekanKesfi.Dto.Dto.UrunlerDTO;

namespace MekanKesfiWebUI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Urunler, UrunMekanDTO>();

            CreateMap<Reklamlar, ReklamMekanDTO>();

            CreateMap<Iller, IllerAramaDTO>();

            CreateMap<Ilceler, IlcelerAramaDTO>();

            CreateMap<Urunler, UrunMekanDTO>()
                .ForMember(dest => dest.IlceAd, opt =>{ opt.MapFrom(src => src.Mekanlar.Ilceler.IlceAd);})
                .ForMember(dest => dest.IlAd, opt => { opt.MapFrom(src => src.Mekanlar.Ilceler.Iller.IlAd); })
                .ForMember(dest => dest.MekanAd, opt => { opt.MapFrom(src => src.Mekanlar.MekanAd); });

            CreateMap<Mekanlar, MekanlarDetayDTO>()
                .ForMember(dest => dest.IlceAd, opt => { opt.MapFrom(src => src.Ilceler.IlceAd); })
                .ForMember(dest => dest.IlAd, opt => { opt.MapFrom(src => src.Ilceler.Iller.IlAd); })
                .ForMember(dest => dest.MekanSahibiAd, opt => { opt.MapFrom(src => src.Kullanicilar.UserName); })
                .ForMember(dest => dest.FotoList, opt => { opt.MapFrom(src => src.Fotograflar.ToList()); });

            CreateMap<Mekanlar, MekanlarListeDTO>()
                .ForMember(dest => dest.IlceAd, opt => { opt.MapFrom(src => src.Ilceler.IlceAd); })
                .ForMember(dest => dest.IlAd, opt => { opt.MapFrom(src => src.Ilceler.Iller.IlAd); })
                .ForMember(dest => dest.MekanSahibiAd, opt => { opt.MapFrom(src => src.Kullanicilar.UserName); })
                .ForMember(dest => dest.MekanFoto, opt => { opt.MapFrom(src => src.Fotograflar.FirstOrDefault(x=> x.AnaFotograf == true).FotografYol); });

            CreateMap<Urunler, UrunDetayDTO>()
                .ForMember(dest => dest.IlceAd, opt => { opt.MapFrom(src => src.Mekanlar.Ilceler.IlceAd); })
                .ForMember(dest => dest.IlAd, opt => { opt.MapFrom(src => src.Mekanlar.Ilceler.Iller.IlAd); })
                .ForMember(dest => dest.MekanAd, opt => { opt.MapFrom(src => src.Mekanlar.MekanAd); })
                .ForMember(dest => dest.MekanId, opt => { opt.MapFrom(src => src.Mekanlar.MekanId); });

            CreateMap<Iller, SelectListItem>()
                .ForMember(dest => dest.Text, opt => { opt.MapFrom(src => src.IlAd); })
                .ForMember(dest => dest.Value, opt => { opt.MapFrom(src => src.IlId.ToString()); });

            CreateMap<Ilceler, SelectListItem>()
                .ForMember(dest => dest.Text, opt => { opt.MapFrom(src => src.IlceAd); })
                .ForMember(dest => dest.Value, opt => { opt.MapFrom(src => src.IlceId.ToString()); });
        }
    }
}
