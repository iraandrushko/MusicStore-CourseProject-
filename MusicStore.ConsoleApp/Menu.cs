using MusicStore.DAL.Repositories;
using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.ConsoleApp
{
    public class Menu
    {
        private readonly UserRepository userRepo;
        private readonly TrackRepository trackRepo;
        private readonly ArtistRepository artistRepo;
        private readonly OrderRepository orderRepo;
        private readonly CreditCardRepository cardRepo;
        private readonly AlbumRepository albumRepo;

        public Menu()
        {
            userRepo = new UserRepository();
            trackRepo = new TrackRepository();
            artistRepo = new ArtistRepository();
            orderRepo = new OrderRepository();
            cardRepo = new CreditCardRepository();
            albumRepo = new AlbumRepository();
    }
        public void ShowMenu()
        {
            int input = -1;

            do
            {
                Console.WriteLine("\n1. Show All Users");
                Console.WriteLine("2. Show User By Email");
                Console.WriteLine("3. Create User");
                Console.WriteLine("4. Delete User");
                Console.WriteLine("5. Update User");
                Console.WriteLine("6. Show All Tracks");
                Console.WriteLine("7. Show All Tracks By An Artist");
                Console.WriteLine("8. Show All Tracks From Album");
                Console.WriteLine("9. Show All Artists");
                Console.WriteLine("10. Show Artist's Albums");
                Console.WriteLine("11. Delete Track");
                Console.WriteLine("12. Create Order");
                Console.WriteLine("13. Show Order By User");
                Console.WriteLine("14. Show All Orders");
                Console.WriteLine("15. Delete Order");
                Console.WriteLine("16. Show All Albums");
                Console.WriteLine("17. Delete Album");
                Console.WriteLine("0. Exit");
                Console.Write(">> ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        ShowAllUsers();
                        break;
                    case 2:
                        ShowUserByEmail();
                        break;
                    case 3:
                        CreateUser();
                        break;
                    case 4:
                        DeleteUser();
                        break;
                    case 5:
                        UpdateUser(); //notimplemented
                        break;
                    case 6:
                        ShowAllTracks();
                        break;
                    case 7:
                        ShowTracksByArtist();
                        break;
                    case 8:
                        ShowTracksFromAlbum();
                        break;
                    case 9:
                        ShowAllArtists();
                        break;
                    case 10:
                        ShowArtistAlbums();
                        break;
                    case 11:
                        DeleteTrack();
                        break;
                    case 13:
                        ShowOrderByUser();
                        break;
                    case 14:
                        ShowAllOrders();
                        break;
                    case 15:
                        DeleteOrder();
                        break;
                    case 16:
                        ShowAllAlbums();
                        break;
                    case 17:
                        DeleteAlbum();
                        break;
                    case 0:
                        break;
                }
            } while (input != 0);
        }

        private void ShowAllAlbums()
        {
            var albums = albumRepo.GetAll();
            foreach (var album in albums)
            {
                Console.WriteLine(album.Name);
            }
        }
        private void ShowOrderByUser()
        {
            Console.WriteLine("User Id ");
            var orderId = int.Parse(Console.ReadLine());
            var order = orderRepo.GetOrderByUser(orderId);
            Console.WriteLine($"User {order.User.LastName + " " + order.User.FirstName} bought an album: \"{order.Album.Name}\" ");
        }
        private void ShowAllOrders()
        {
            var orders = orderRepo.GetAllOrders();
            foreach (var order in orders)
            {
                Console.WriteLine($"User {order.User.LastName + " " + order.User.FirstName} bought an album: \"{order.Album.Name}\" ");
            }
        }
        private void DeleteTrack()
        {
            Console.WriteLine("Track Id ");
            var trackId = int.Parse(Console.ReadLine());
            trackRepo.Remove(trackId);
        }
        private void DeleteAlbum()
        {
            Console.WriteLine("Album Id ");
            var albumId = int.Parse(Console.ReadLine());
            albumRepo.DeleteAlbum(albumId);
        }
        private void DeleteOrder()
        {
            Console.WriteLine("Order Id ");
            var orderId = int.Parse(Console.ReadLine());
            orderRepo.Remove(orderId);
        }
        private void ShowArtistAlbums()
        {
            Console.WriteLine("Artist Id: ");
            var artistId = int.Parse(Console.ReadLine());
            var albums = artistRepo.GetAlbums(artistId);
            foreach (var album in albums)
            {
                Console.WriteLine(album.Name);
            }
        }
        private void ShowAllArtists()
        {
            var artists = artistRepo.GetAll();
            foreach (var artist in artists)
            {
                Console.WriteLine(artist.Name);
            }
        }
        private void ShowTracksFromAlbum()
        {
            Console.WriteLine("Album Id: ");
            var albumId = int.Parse(Console.ReadLine());
            var tracks = trackRepo.GetTracksFromAlbum(albumId);
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }
        private void ShowAllTracks()
        {
           var tracks = trackRepo.GetAll();
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }
        private void ShowTracksByArtist()
        {
            Console.WriteLine("Artist Id: ");
            var artistId = int.Parse(Console.ReadLine());
            var tracks = trackRepo.GetTracksByArtist(artistId);
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }
        private void UpdateUser()
        {
            int input = -1;
            do
            {
                Console.WriteLine("What you would like to update? ");
                Console.WriteLine("1. FirstName");
                Console.WriteLine("2. LastName");
                Console.WriteLine("3. Email");
                Console.WriteLine("4. Login");
                Console.WriteLine("5. Adress");
                Console.WriteLine("6. PhoneNumber");
                Console.WriteLine("0. Nothing");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        var firstName = Console.ReadLine();
                        break;
                    case 2:
                        var lastName = Console.ReadLine();
                        break;
                    case 3:
                        var email = Console.ReadLine();
                        break;
                    case 4:
                        var login = Console.ReadLine();
                        break;
                    case 5:
                        var adress = Console.ReadLine();
                        break;
                    case 6:
                        var phoneNum = Console.ReadLine();
                        break;
                }
            } while (input != 0);

            
        }

        private void DeleteUser()
        {
            Console.WriteLine("User Id ");
            var userId = int.Parse(Console.ReadLine());
            userRepo.DeleteUser(userId);
        }

        private void CreateUser()
        {
            Console.Write("FirstName: ");
            var firstName = Console.ReadLine();
            Console.Write("LastName: ");
            var lastName = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();
            Console.Write("PasswordSalt: ");
            var passwordSalt = Console.ReadLine();
            Console.Write("Gender: ");
            var gender = Console.ReadLine();
            Console.Write("Adress: ");
            var adress = Console.ReadLine();
            Console.Write("PhoneNumber: ");
            var phoneNum = Console.ReadLine();
            Console.Write("CreditCardNumber: ");
            var cardNum = Console.ReadLine();
            Console.Write("BankName: ");
            var bankName = Console.ReadLine();
            Console.Write("Valid years: ");
            var years = int.Parse(Console.ReadLine());

            var card = new CreditCardDto 
            {
                Number = cardNum,
                BankName = bankName,
                ExpirationDate = DateTime.Now.AddYears(years)
            };
            
            var user = new UserDto
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Login = login,
                Password = password,
                PasswordSalt = passwordSalt,
                Gender = (gender == "male") ? GenderDto.Male : GenderDto.Female,
                Adress = adress,
                PhoneNumber = phoneNum,
                CreditCard = card
        };
            userRepo.Create(user);
        }

        private void ShowUserByEmail()
        {
            Console.WriteLine("User Email: ");
            var userEmail = Console.ReadLine();
            Console.WriteLine(userRepo.GetUserByEmail(userEmail).FirstName);
        }
        private void ShowAllUsers()
        {
            var users = userRepo.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }
    }

}   
