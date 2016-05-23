using System.ComponentModel.DataAnnotations;
using Microsoft.SqlServer.Server;
using Tenta_Test.Attributes;

namespace Tenta_Test.Models
{
    public class Song
    {
        public int SongId { get; set; }

        [Required]
        [TitelCheck]
        public string Titel  { get; set; }

        [Range(0,10)]
        public int Duration { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Required]
        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
    }
}