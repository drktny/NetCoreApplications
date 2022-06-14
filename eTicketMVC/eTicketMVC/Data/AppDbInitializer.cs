using eTicketMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMVC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //using Microsoft.Extensions.DependencyInjection;
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the third cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the fourth cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the fifth cinema"
                        }
                    });

                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                            
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the bio of the third actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the bio of the fourth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the bio of the fifth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"

                        },
                    });

                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the bio of the first producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the bio of the second producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the bio of the third producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the bio of the fourth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the bio of the fifth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"

                        },
                    });

                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                            Name = "The Shawshank Redemption",
                            Description = "This is The Shawshank Redemption movie description",
                            Price = 28.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary

                            },new Movie()
                            {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 38.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror

                            },
                            new Movie()
                            {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 38.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror

                            },new Movie()
                            {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 38.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary

                            },
                            new Movie()
                            {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 38.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon

                            },
                            new Movie()
                            {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 38.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama

                            },
                        });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 13
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 13
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 14
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 14
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 15
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 15
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 15
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 16
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 16
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 16
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 17
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 18
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 18
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 18
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
