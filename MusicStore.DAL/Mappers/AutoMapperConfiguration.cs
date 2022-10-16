using AutoMapper;
using MusicStore.DAL.Enums;
using MusicStore.DAL.Models;
using MusicStore.DTO;
using MusicStore.DTO.Enum;

namespace MusicStore.DAL.Mappers
{
    public class AutoMapperConfiguration
    {
        private static MapperConfiguration config;

        public static MapperConfiguration GetMapperConfiguration() 
        {
            if (config == null) 
            {
                config = new MapperConfiguration(cfg =>
                {
                    // User
                    cfg.CreateMap<User, User>()
                        .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<User, UserDto>().ReverseMap();

                    // Track
                    cfg.CreateMap<Track, Track>()
                        .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<Track, TrackDto>().ReverseMap();

                    //Gender
                    cfg.CreateMap<Gender, Gender>()
                      .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<Gender, GenderDto>().ReverseMap();

                    //CreditCard
                    cfg.CreateMap<CreditCard, CreditCard>()
                      .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<CreditCard, CreditCardDto>().ReverseMap();

                    //Album
                    cfg.CreateMap<Album, Album>()
                   .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<Album, AlbumDto>().ReverseMap();

                    //Genre
                    cfg.CreateMap<Genre, Genre>()
                   .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<Genre, GenreDto>().ReverseMap();

                    //Artist
                    cfg.CreateMap<Artist, Artist>()
                   .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<Artist, ArtistDto>().ReverseMap();

                    //Order
                    cfg.CreateMap<Order, Order>()
                   .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

                    cfg.CreateMap<Order, OrderDto>().ReverseMap();

                });
            }

            return config;
        }
    }
}
