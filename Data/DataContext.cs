using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoanNguyenHuy.Models;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<DoanNguyenHuy.Models.Category> Category { get; set; }

        public DbSet<DoanNguyenHuy.Models.Comment> Comment { get; set; }

        public DbSet<DoanNguyenHuy.Models.News> News { get; set; }
    }
