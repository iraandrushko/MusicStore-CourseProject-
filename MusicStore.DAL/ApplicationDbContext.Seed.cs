using MusicStore.Common;
using MusicStore.DAL.Enums;
using MusicStore.DAL.Models;
using System;

namespace MusicStore.DAL
{
    public partial class ApplicationDbContext
    {
        public ApplicationDbContext Seed()
        {
            Genre Genre6 = new Genre
            {
                Name = "Country",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Artist Artist6 = new Artist
            {
                Name = "Josh Turner",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album10 = new Album
            {
                Name = "Your Man",
                Price = 45,
                Artist = Artist6,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Tracks.Add(new Track
            {
                Name = "your man",
                Duration = 3.32f,
                Album = Album10,
                Genre = Genre6,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "would you go with me",
                Duration = 3.48f,
                Album = Album10,
                Genre = Genre6,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "baby's gone home to mama",
                Duration = 3.06f,
                Album = Album10,
                Genre = Genre6,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "gravity",
                Duration = 3.40f,
                Album = Album10,
                Genre = Genre6,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });

            Genre Genre5 = new Genre
            {
                Name = "Vocal",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Artist Artist5 = new Artist
            {
                Name = "Damien Leith",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album9 = new Album
            {
                Name = "Now & Then",
                Price = 25,
                Artist = Artist5,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Tracks.Add(new Track
            {
                Name = "got my mind set on you",
                Duration = 3.47f,
                Album = Album9,
                Genre = Genre5,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "here comes the sun",
                Duration = 2.58f,
                Album = Album9,
                Genre = Genre5,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Genre Genre4 = new Genre
            {
                Name = "Hip-Hop",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Artist Artist4 = new Artist
            {
                Name = "RaeSremmurd",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album8 = new Album
            {
                Name = "SremmLife",
                Price = 15,
                Artist = Artist4,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Tracks.Add(new Track
            {
                Name = "this could be us",
                Duration = 3.26f,
                Album = Album8,
                Genre = Genre4,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "come get her",
                Duration = 3.33f,
                Album = Album8,
                Genre = Genre4,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });

            Genre Genre1 = new Genre
            {
                Name = "R&B",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Artist Artist1 = new Artist
            {
                Name = "TheWeeknd",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album1 = new Album
            {
                Name = "My Dear Melanholy",
                Price = 50,
                Artist = Artist1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album2 = new Album
            {
                Name = "After Hours",
                Price = 55,
                Artist = Artist1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Tracks.Add(new Track
            {
                Name = "call out my name",
                Duration = 4.00f,
                Album = Album1,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "wasted times",
                Duration = 3.41f,
                Album = Album1,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "i was never there",
                Duration = 4.02f,
                Album = Album1,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "hurt you",
                Duration = 3.51f,
                Album = Album1,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "in your eyes",
                Duration = 4.00f,
                Album = Album2,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "save your tears",
                Duration = 3.36f,
                Album = Album2,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "too late",
                Duration = 3.59f,
                Album = Album2,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "hardest to love",
                Duration = 3.41f,
                Album = Album2,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "blinding lights",
                Duration = 3.20f,
                Album = Album2,
                Genre = Genre1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });

            Genre Genre2 = new Genre
            {
                Name = "Alternative",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Artist Artist2 = new Artist
            {
                Name = "Benee",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album3 = new Album
            {
                Name = "Fire on Marzz",
                Price = 30,
                Artist = Artist2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album4 = new Album
            {
                Name = "Hey u x",
                Price = 35,
                Artist = Artist2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album5 = new Album
            {
                Name = "Stella & Steve",
                Price = 30,
                Artist = Artist2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Tracks.Add(new Track
            {
                Name = "find an island",
                Duration = 3.13f,
                Album = Album5,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "supalonely",
                Duration = 3.43f,
                Album = Album5,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "monsta",
                Duration = 3.42f,
                Album = Album5,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "blu",
                Duration = 3.22f,
                Album = Album5,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "glitter",
                Duration = 3.00f,
                Album = Album3,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "evil spider",
                Duration = 2.33f,
                Album = Album3,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "afterlife",
                Duration = 3.57f,
                Album = Album3,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "night garden",
                Duration = 3.42f,
                Album = Album4,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "same effect",
                Duration = 4.05f,
                Album = Album4,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "snail",
                Duration = 3.00f,
                Album = Album4,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "a little while",
                Duration = 3.18f,
                Album = Album4,
                Genre = Genre2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });

            Genre Genre3 = new Genre
            {
                Name = "Pop",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Artist Artist3 = new Artist
            {
                Name = "Ruel",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album6 = new Album
            {
                Name = "Bright Lights, Red Eyes",
                Price = 25,
                Artist = Artist3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Album Album7 = new Album
            {
                Name = "Free Time",
                Price = 40,
                Artist = Artist3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            Tracks.Add(new Track
            {
                Name = "courage",
                Duration = 3.28f,
                Album = Album6,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "distance",
                Duration = 2.59f,
                Album = Album6,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "as long as you care",
                Duration = 3.13f,
                Album = Album6,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "say it over",
                Duration = 3.52f,
                Album = Album6,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "up to something",
                Duration = 2.59f,
                Album = Album6,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "don't cry",
                Duration = 3.07f,
                Album = Album7,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "real thing",
                Duration = 3.12f,
                Album = Album7,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "hard sometimes",
                Duration = 4.30f,
                Album = Album7,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "face to face",
                Duration = 3.24f,
                Album = Album7,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });
            Tracks.Add(new Track
            {
                Name = "free time",
                Duration = 3.38f,
                Album = Album7,
                Genre = Genre3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            });


            var guid1 = Guid.NewGuid();
            User user1 = new User
            {
                FirstName = "Terry",
                LastName = "Medhurst",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "atuny0@sohu.com",
                Login = "TerryMed",
                Password = Hashing.GetHashString("9uQFF1Lh", guid1),
                PasswordSalt = guid1,
                Adress = "2A Zhnyvna Street",
                Gender = Gender.Male,
                SecretWord = "binomial",
                PhoneNumber = "380955322468",
                CreditCard = new CreditCard
                {
                    BankName = "monobank",
                    ExpirationDate = DateTime.Now.AddDays(1825),
                    Number = "6546 87463 5246 3546",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,

                }
            };
            var guid2 = Guid.NewGuid();
            User user2 = new User
            {
                FirstName = "Sheldon",
                LastName = "Quigley",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "hbingley1@plala.or.jp",
                Login = "Sheldonchyk33",
                Password = Hashing.GetHashString("CQutx25i8r", guid2),
                PasswordSalt = guid2,
                Adress = "5 Zhytnia Street",
                Gender = Gender.Male,
                SecretWord = "coefficient",
                PhoneNumber = "380975392460",
                CreditCard = new CreditCard
                {
                    BankName = "pryvatbank",
                    ExpirationDate = DateTime.Now.AddDays(1460),
                    Number = "5673 5490 6123 1734",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid3 = Guid.NewGuid();
            User user3 = new User
            {
                FirstName = "Alison",
                LastName = "Reichert",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "jtreleven5@nhs.uk",
                Login = "AliReichert",
                Password = Hashing.GetHashString("9aUTdmmmbH", guid3),
                PasswordSalt = guid3,
                Adress = "11 Yabluneva Street",
                Gender = Gender.Female,
                SecretWord = "interpolation",
                PhoneNumber = "380938163062",
                CreditCard = new CreditCard
                {
                    BankName = "OTPbank",
                    ExpirationDate = DateTime.Now.AddDays(730),
                    Number = "7564 9812 3408 3754",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid4 = Guid.NewGuid();
            User user4 = new User
            {
                FirstName = "Oleta",
                LastName = "Abbott",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "dpettegre6@columbia.edu",
                Login = "Abboleta",
                Password = Hashing.GetHashString("YVmhktgYVS", guid4),
                PasswordSalt = guid4,
                Adress = "33 Yasna Street",
                SecretWord = "quotient",
                Gender = Gender.Female,
                PhoneNumber = "380954025107",
                CreditCard = new CreditCard
                {
                    BankName = "Credobank",
                    ExpirationDate = DateTime.Now,
                    Number = "8643 1295 3020 7780",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid5 = Guid.NewGuid();
            User user5 = new User
            {
                FirstName = "Ewell",
                LastName = "Mueller",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "ggude7@chron.com",
                Login = "Eweller",
                Password = Hashing.GetHashString("MWwlaeWcOoF6", guid5),
                PasswordSalt = guid5,
                Adress = "108 Naukova Street",
                SecretWord = "denominator",
                Gender = Gender.Male,
                PhoneNumber = "380950173927",
                CreditCard = new CreditCard
                {
                    BankName = "Ideabank",
                    ExpirationDate = DateTime.Now.AddDays(1277),
                    Number = "3021 7524 7850 9345",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid6 = Guid.NewGuid();
            User user6 = new User
            {
                FirstName = "Eleanora",
                LastName = "Price",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "umcgourty9@jalbum.net",
                Login = "Eleo1995",
                Password = Hashing.GetHashString("i0xzpX", guid6),
                PasswordSalt = guid6,
                Adress = "3 Nasypna Street",
                SecretWord = "dodecahedron",
                Gender = Gender.Female,
                PhoneNumber = "380920948175",
                CreditCard = new CreditCard
                {
                    BankName = "Abank",
                    ExpirationDate = DateTime.Now,
                    Number = "7649 2300 7601 5324",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid7 = Guid.NewGuid();
            User user7 = new User
            {
                FirstName = "Marcel",
                LastName = "Jones",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "acharlota@liveinternet.ru",
                Login = "JoMarcel",
                Password = Hashing.GetHashString("M9lbMdydMN", guid7),
                PasswordSalt = guid7,
                Adress = "18 Himichna Street",
                Gender = Gender.Male,
                SecretWord = "exponential",
                PhoneNumber = "380973912048",
                CreditCard = new CreditCard
                {
                    BankName = "monobank",
                    ExpirationDate = DateTime.Now,
                    Number = "8247 9080 1320 4521",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid8 = Guid.NewGuid();
            User user8 = new User
            {
                FirstName = "Assunta",
                LastName = "Rath",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "rhallawellb@dropbox.com",
                Login = "AssuntaRath",
                Password = Hashing.GetHashString("esTkitT1r", guid8),
                PasswordSalt = guid8,
                Adress = "35 Tisna Street",
                Gender = Gender.Female,
                SecretWord = "heptagon",
                PhoneNumber = "380972063481",
                CreditCard = new CreditCard
                {
                    BankName = "pryvatbank",
                    ExpirationDate = DateTime.Now,
                    Number = "3975 1030 5647 3090",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid9 = Guid.NewGuid();
            User user9 = new User
            {
                FirstName = "Trace",
                LastName = "Douglas",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "lgribbinc@posterous.com",
                Login = "Douglas777",
                Password = Hashing.GetHashString("ftGj8LZTtv9g", guid9),
                PasswordSalt = guid9,
                Adress = "14 Franka Street",
                Gender = Gender.Male,
                SecretWord = "parallelogram",
                PhoneNumber = "380939567102",
                CreditCard = new CreditCard
                {
                    BankName = "OTPbank",
                    ExpirationDate = DateTime.Now,
                    Number = "2874 2345 1807 5002",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid10 = Guid.NewGuid();
            User user10 = new User
            {
                FirstName = "Enoch",
                LastName = "Lynch",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "mturleyd@tumblr.com",
                Login = "EnoLynch",
                Password = Hashing.GetHashString("GyLnCB8gNIp", guid10),
                PasswordSalt = guid10,
                Adress = "10B Vitriana Street",
                Gender = Gender.Male,
                SecretWord = "pentagon",
                PhoneNumber = "380982098706",
                CreditCard = new CreditCard
                {
                    BankName = "Credobank",
                    ExpirationDate = DateTime.Now,
                    Number = "8365 9008 2137 4508",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid11 = Guid.NewGuid();
            User user11 = new User
            {
                FirstName = "Jeanne",
                LastName = "Halvorson",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "kminchelle@qq.com",
                Login = "Eleo1995",
                Password = Hashing.GetHashString("0lelplR", guid11),
                PasswordSalt = guid11,
                Adress = "11 Pidlisna Street",
                Gender = Gender.Female,
                SecretWord = "polynomial",
                PhoneNumber = "380975027190",
                CreditCard = new CreditCard
                {
                    BankName = "Abank",
                    ExpirationDate = DateTime.Now,
                    Number = "7568 2349 9086 7432",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
            var guid12 = Guid.NewGuid();
            User user12 = new User
            {
                FirstName = "Trycia",
                LastName = "Fadel",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = "dpierrof@vimeo.com",
                Login = "FadelTry",
                Password = Hashing.GetHashString("Vru55Y4tufI4", guid12),
                PasswordSalt = guid12,
                Adress = "6 Svitla Street",
                Gender = Gender.Female,
                SecretWord = "trapezium",
                PhoneNumber = "380976120642",
                CreditCard = new CreditCard
                {
                    BankName = "Ideabank",
                    ExpirationDate = DateTime.Now,
                    Number = "9023 6584 1209 4583",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };

            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);
            Users.Add(user4);
            Users.Add(user5);
            Users.Add(user6);
            Users.Add(user7);
            Users.Add(user8);
            Users.Add(user9);
            Users.Add(user10);
            Users.Add(user11);
            Users.Add(user12);

            Order order1 = new Order
            {
                User = user1,
                Album = Album4,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order2 = new Order
            {
                User = user2,
                Album = Album1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order3 = new Order
            {
                User = user8,
                Album = Album10,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order4 = new Order
            {
                User = user3,
                Album = Album2,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order5 = new Order
            {
                User = user5,
                Album = Album5,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order6 = new Order
            {
                User = user4,
                Album = Album3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order7 = new Order
            {
                User = user6,
                Album = Album6,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order8 = new Order
            {
                User = user9,
                Album = Album8,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order9 = new Order
            {
                User = user7,
                Album = Album9,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Order order10 = new Order
            {
                User = user12,
                Album = Album7,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            Orders.Add(order1);
            Orders.Add(order2);
            Orders.Add(order3);
            Orders.Add(order4);
            Orders.Add(order5);
            Orders.Add(order6);
            Orders.Add(order7);
            Orders.Add(order8);
            Orders.Add(order9);
            Orders.Add(order10);
            this.SaveChanges();

            return this;
        }
    }
}
