using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Project_Management_System
{

    /// <summary>Extends DbContext class in order to provide database access.</summary>
    class Sql : DbContext
    {
        public Sql() : base(@"Data Source=DESKTOP-J9CCRCR\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True") { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        /// <summary>Initializes the context.</summary>
        /// <param name="modelBuilder">
        ///   <para>DbModelBuilder object</para>
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
