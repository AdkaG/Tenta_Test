using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tenta_Test.Models
{
    public class MusicContext:DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicContext():base("Music")
        {
            Database.SetInitializer<MusicContext>(new MusicInitialiser());
        }
    }

    internal class MusicInitialiser : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
           var artists = new List<Artist>
                {
                    new Artist()
                    {
                       Age = 24,
                       Name = "Andreas",
                       Band="DummyBand",
                       Songs = new List<Song>()
                       {
                           new Song()
                           {
                               Duration = 3,
                               Genre="Pop",
                               Titel="PopSong"
                           },
                           new Song()
                           {
                               Duration = 4,
                               Genre="R&B",
                               Titel="R&BSong"
                           }
                       }
                    },
                     new Artist()
                    {
                       Age = 17,
                       Name = "BBB",
                       Band="DummyBBBBand",
                       Songs = new List<Song>()
                       {
                           new Song()
                           {
                               Duration = 2,
                               Genre="KaPop",
                               Titel="KaPopTheBest"
                           },
                           new Song()
                           {
                               Duration = 4,
                               Genre="KaPop",
                               Titel="KaPopCool"
                           }
                       }
                    },
                      new Artist()
                    {
                       Age = 33,
                       Name = "Prince",
                       Band="PrinceBand",
                       Songs = new List<Song>()
                       {
                           new Song()
                           {
                               Duration = 5,
                               Genre="Pop",
                               Titel="Purple Rain"
                           },
                           new Song()
                           {
                               Duration = 4,
                               Genre="Pop",
                               Titel="Symbol"
                           }
                       }
                    }
                };
            foreach (var artist in artists)
            {
                context.Artists.Add(artist);
            }
            context.SaveChanges();
        }
    
    }
}