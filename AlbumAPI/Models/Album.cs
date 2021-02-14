using System;
using System.ComponentModel.DataAnnotations;

namespace AlbumAPI.Models
{
    public class Album
    {
        public int Id { get; init; }
        public string Artist { get; set; }
        public string Name { get; set; }

        [Range(1900, 2030)]
        public int ReleaseYear { get; set; }

        public string Category { get; set; }
    }
}
