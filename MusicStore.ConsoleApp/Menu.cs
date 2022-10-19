using MusicStore.ConsoleApp.Services;
using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;
using System.Collections.Generic;

namespace MusicStore.ConsoleApp
{
    public class Menu
    {
        private readonly UserService userService;
        private readonly GenreService genreService;
        private readonly TrackService trackService;
        private readonly ArtistService artistService;
        private readonly OrderService orderService;
        private readonly AlbumService albumService;

        public Menu()
        {
            userService = new UserService();
            trackService = new TrackService();
            artistService = new ArtistService();
            orderService = new OrderService();
            albumService = new AlbumService();
            genreService = new GenreService();
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
                Console.WriteLine("9. Add Track");
                Console.WriteLine("10. Update Track");
                Console.WriteLine("11. Show All Artists");
                Console.WriteLine("12. Show Artist's Albums");
                Console.WriteLine("13. Delete Track");
                Console.WriteLine("14. Create Order");
                Console.WriteLine("15. Update Order");
                Console.WriteLine("16. Show Order By User");
                Console.WriteLine("17. Show All Orders");
                Console.WriteLine("18. Delete Order");
                Console.WriteLine("19. Show All Albums");
                Console.WriteLine("20. Create Album");
                Console.WriteLine("21. Update Album");
                Console.WriteLine("22. Delete Album");
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
                        UpdateUser(); 
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
                        AddTrack();
                        break;
                    case 10:
                        UpdateTrack();
                        break;
                    case 11:
                        ShowAllArtists();
                        break;
                    case 12:
                        ShowArtistAlbums();
                        break;
                    case 13:
                        DeleteTrack();
                        break;
                    case 14:
                        CreateOrder();
                        break;
                    case 15:
                        UpdateOrder();
                        break;
                    case 16:
                        ShowOrdersByUser();
                        break;
                    case 17:
                        ShowAllOrders();
                        break;
                    case 18:
                        DeleteOrder();
                        break;
                    case 19:
                        ShowAllAlbums();
                        break;
                    case 20:
                        CreateAlbum();
                        break;
                    case 21:
                        UpdateAlbum();
                        break;
                    case 22:
                        DeleteAlbum();
                        break;
                    case 0:
                        break;
                }
            } while (input != 0);
        }
        private void UpdateOrder()
        {
            Console.WriteLine("Order Id: ");
            var orderId = int.Parse(Console.ReadLine());
            var order = orderService.GetById(orderId);
            int input = -1;
            do
            {
                Console.WriteLine("What you would like to update? ");
                Console.WriteLine("1. Album");
                Console.WriteLine("2. User");
                Console.WriteLine("0. Nothing");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Write("AlbumId: ");
                        order.AlbumId = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("UserId: ");
                        order.UserId = int.Parse(Console.ReadLine());
                        break;
                }
            } while (input != 0);

            orderService.Update(orderId, order);
        }
        private void UpdateAlbum()
        {
            Console.Write("Album Id: ");
            var albumId = int.Parse(Console.ReadLine());
            var album = albumService.GetById(albumId);
            int input = -1;
            do
            {
                Console.WriteLine("What you would like to update? ");
                Console.WriteLine("1. Add Track To An Album");
                Console.WriteLine("2. Delete Track From An Album");
                Console.WriteLine("3. Name");
                Console.WriteLine("4. Artist");
                Console.WriteLine("5. Price");
                Console.WriteLine("0. Nothing");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AddTrack();
                        break;
                    case 2:
                        DeleteTrack();
                        break;
                    case 3:
                        Console.Write("Name: ");
                        album.Name = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("ArtistId: ");
                        album.ArtistId = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("Price: ");
                        album.Price = int.Parse(Console.ReadLine());
                        break;
                }
            } while (input != 0);

            albumService.Update(albumId, album);
        }
        private void UpdateTrack()
        {
            Console.WriteLine("Track Id: ");
            var trackId = int.Parse(Console.ReadLine());
            var track = trackService.GetById(trackId);
            int input = -1;
            do
            {
                Console.WriteLine("What you would like to update? ");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Album");
                Console.WriteLine("3. Genre");
                Console.WriteLine("4. Duration");
                Console.WriteLine("0. Nothing");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Write("Name: ");
                        track.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("AlbumId: ");
                        track.AlbumId = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("GenreId: ");
                        track.GenreId = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Duration: ");
                        track.Duration = float.Parse(Console.ReadLine());
                        break;
                }
            } while (input != 0);

            trackService.Update(trackId, track);
        }
        private void CreateOrder()
        {
            var orderDto = new OrderDto();
            var albums = albumService.GetAll();
            Console.Write("User Id: ");
            orderDto.UserId = int.Parse(Console.ReadLine());
            Console.Write("Which album you would like to buy: ");
            foreach (var album in albums)
            {
                Console.WriteLine(album.Id + " - " + album.Name);
            }
            Console.Write("Album id: ");
            orderDto.AlbumId = int.Parse(Console.ReadLine());
            orderService.Create(orderDto);
        }
        private void AddTrack()
        {
            var trackDto = new TrackDto();
            var genres = genreService.GetAll();
            var albums = albumService.GetAll();
            Console.Write("Name: ");
            trackDto.Name = Console.ReadLine();
            Console.Write("Duration: ");
            trackDto.Duration = float.Parse(Console.ReadLine());
            Console.WriteLine("What genre is your track: ");
            foreach (var genre in genres)
            {
                Console.WriteLine(genre.Id + " - " + genre.Name);
            }
            Console.Write("Genre id: ");
            trackDto.GenreId = int.Parse(Console.ReadLine());
            Console.WriteLine("Which album do you want to add your track to: ");
            foreach (var album in albums)
            {
                Console.WriteLine(album.Id + " - " + album.Name);
            }
            Console.Write("Album id: ");
            trackDto.AlbumId = int.Parse(Console.ReadLine());
            trackService.Create(trackDto);
        }
        private void ShowAllAlbums()
        {
            var albums = albumService.GetAll();
            foreach (var album in albums)
            {
                Console.WriteLine(album.Name);
            }
        }
        private void ShowOrdersByUser()
        {
            Console.WriteLine("User Id ");
            var userId = int.Parse(Console.ReadLine());
            var orders = orderService.GetOrdersByUser(userId);

            foreach (var order in orders)
            {
                Console.WriteLine($"User {order.User.LastName + " " + order.User.FirstName} bought an album: \"{order.Album.Name}\" ");

            }
        }
        private void ShowAllOrders()
        {
            var orders = orderService.GetAll();
            foreach (var order in orders)
            {
                Console.WriteLine($"User {order.User.LastName + " " + order.User.FirstName} bought an album: \"{order.Album.Name}\" ");
            }
        }
        private void DeleteTrack()
        {
            Console.Write("Track Id: ");
            var trackId = int.Parse(Console.ReadLine());
            trackService.Remove(trackId);
        }
        private void DeleteAlbum()
        {
            Console.WriteLine("Album Id ");
            var albumId = int.Parse(Console.ReadLine());
            albumService.Remove(albumId);
        }
        private void DeleteOrder()
        {
            Console.WriteLine("Order Id ");
            var orderId = int.Parse(Console.ReadLine());
            orderService.Remove(orderId);
        }
        private void ShowArtistAlbums()
        {
            Console.WriteLine("Artist Id: ");
            var artistId = int.Parse(Console.ReadLine());
            var albums = artistService.GetAlbums(artistId);
            foreach (var album in albums)
            {
                Console.WriteLine(album.Name);
            }
        }
        private void ShowAllArtists()
        {
            var artists = artistService.GetAll();
            foreach (var artist in artists)
            {
                Console.WriteLine(artist.Name);
            }
        }
        private void ShowTracksFromAlbum()
        {
            Console.WriteLine("Album Id: ");
            var albumId = int.Parse(Console.ReadLine());
            var tracks = trackService.GetTracksFromAlbum(albumId);
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }
        private void ShowAllTracks()
        {
           var tracks = trackService.GetAll();
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }
        private void ShowTracksByArtist()
        {
            Console.WriteLine("Artist Id: ");
            var artistId = int.Parse(Console.ReadLine());
            var tracks = trackService.GetTracksByArtist(artistId);
            foreach (var track in tracks)
            {
                Console.WriteLine(track.Name);
            }
        }
        private void UpdateUser()
        {
            Console.WriteLine("User Id: ");
            var userId = int.Parse(Console.ReadLine());
            var user = userService.GetById(userId);
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
                        Console.Write("FirstName: ");
                        user.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("LastName: ");
                        user.LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Email: ");
                        user.Email = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Login: ");
                        user.Login = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Adress: ");
                        user.Adress = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("PhoneNumber: ");
                        user.PhoneNumber = Console.ReadLine();
                        break;
                }
            } while (input != 0);

            userService.Update(userId, user);
        }
        private void DeleteUser()
        {
            Console.WriteLine("User Id ");
            var userId = int.Parse(Console.ReadLine());
            userService.Remove(userId);
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
            userService.Create(user);
        }
        private void CreateAlbum()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Price: ");
            var price = decimal.Parse(Console.ReadLine());
            Console.Write("Artist id: ");
            var artistId = int.Parse(Console.ReadLine());

            Console.Write("Do you want to add track to the album [y/n] (no by default): ");
            var addTracksAnswear = Console.ReadLine();
            var genres = genreService.GetAll();

            var tracks = new List<TrackDto>();

            while (addTracksAnswear == "y") 
            {
                var trackDto = new TrackDto();
                Console.Write("Name: ");
                trackDto.Name = Console.ReadLine();
                Console.Write("Duration: ");
                trackDto.Duration = float.Parse(Console.ReadLine());

                foreach (var genre in genres)
                {
                    Console.WriteLine(genre.Id + " - " + genre.Name);
                }
                Console.Write("Genre id: ");
                var genreId = int.Parse(Console.ReadLine());
                trackDto.GenreId = genreId;
                tracks.Add(trackDto);

                Console.Write("One more? [y/n] (no by default): ");
                addTracksAnswear = Console.ReadLine();
            }

            albumService.Create(new AlbumDto
            {
                ArtistId = artistId,
                Name = name,
                Price = price,
                Tracks = tracks
            });
            
        }
        private void ShowUserByEmail()
        {
            Console.WriteLine("User Email: ");
            var userEmail = Console.ReadLine();
            Console.WriteLine(userService.GetUserByEmail(userEmail).FirstName);
        }
        private void ShowAllUsers()
        {
            var users = userService.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }
    }

}   
