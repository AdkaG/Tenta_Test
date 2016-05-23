using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tenta_Test.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1,100)]
        public int Age { get; set; }

        [MaxLength(100)]
        public string Band { get; set; }
        public List<Song> Songs { get; set; }
    }
}