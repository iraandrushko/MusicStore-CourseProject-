using MusicStore.DAL;
using MusicStore.DAL.Enums;
using MusicStore.DAL.Repositories;
using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;

namespace MusicStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Menu().ShowMenu();

            //new ApplicationDbContext().Seed().Dispose();
            //var userRepo = new UserRepository();
            //userRepo.Remove(2);

            new Menu().ShowMenu();

            var userRepo = new UserRepository();
            var cardRepo = new CreditCardRepository();
            var trackRepo = new TrackRepository();

            var tracks = trackRepo.GetTracksFromAlbum(8);
            var t = trackRepo.GetAll();
            var users = userRepo.GetAllUsersWirhCards();
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName, user.LastName);
            }

            //userRepo.Update(1, new UserDto
            //{
            //    FirstName = "Enochi",
            //    LastName = "Lynch",
            //    Email = "mturleyd@tumblr.com",
            //    Adress = "10B Vitriana Street",
            //    PhoneNumber = "380982098706"
            //});

            //userRepo.Create(new UserDto
            //{
            //    FirstName = "Enochi",
            //    LastName = "Lynch",
            //    Email = "mturleyd@tumblr.com",
            //    Adress = "10B Vitriana Street",
            //    PhoneNumber = "380982098706",
            //    Login = "knkk",
            //    Gender = GenderDto.Male,
            //    Password = "hvihv",
            //    PasswordSalt = "knguh",
            //    CreditCard = cardRepo.CreateCard(new CreditCardDto
            //    {
            //        BankName = "ydeazdfghj",
            //        Number = "23456787654321123456789",
            //        ExpirationDate = DateTime.Now.AddDays(345)
            //    })

            //});


            Console.ReadKey();
        }
    }
}