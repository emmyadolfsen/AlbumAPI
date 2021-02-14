using System;
using AlbumAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumAPI.Data
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
    }
}
