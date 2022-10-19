using AutoMapper;
using MusicStore.DAL.Enums;
using MusicStore.DAL.Models;
using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;

namespace MusicStore.ConsoleApp.Mappers
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
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<User, UserDto>().ReverseMap();

                    // Track
                    cfg.CreateMap<Track, Track>()
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<Track, TrackDto>().ReverseMap();

                    //CreditCard
                    cfg.CreateMap<CreditCard, CreditCard>()
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<CreditCard, CreditCardDto>().ReverseMap();

                    //Album
                    cfg.CreateMap<Album, Album>()
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<Album, AlbumDto>().ReverseMap();

                    //Genre
                    cfg.CreateMap<Genre, Genre>()
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<Genre, GenreDto>().ReverseMap();

                    //Artist
                    cfg.CreateMap<Artist, Artist>()
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<Artist, ArtistDto>().ReverseMap();

                    //Order
                    cfg.CreateMap<Order, Order>()
                       .ConfigureUpdateEntity();

                    cfg.CreateMap<Order, OrderDto>().ReverseMap();

                });
            }

            return config;
        }
    }
}
