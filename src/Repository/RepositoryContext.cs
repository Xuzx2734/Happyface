using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Repository
{
    public class RepositoryContext : DbContext
    {

        //public static readonly ILoggerFactory loggerFactory = new LoggerFactory(new[] {
        //      new ConsoleLoggerProvider((_, __) => true, true)
        //});

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {

        }

        public DbSet<ClassModel> Class { get; set; }

        public DbSet<DocModel> Doc { get; set; }

        public DbSet<GroupsModel> Groups { get; set; }

        public DbSet<ParameterModel> Parameter{ get; set; }

        public DbSet<ProjectGroupModel> ProjectGroup { get; set; }

        public DbSet<UserGroupModel> UserGroupl { get; set; }

        public DbSet<UsersModel> Users { get; set; }

        public DbSet<ValuesModel> Valuesl { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassModel>().ToTable("t_class");
            modelBuilder.Entity<DocModel>().ToTable("t_doc");
            modelBuilder.Entity<GroupsModel>().ToTable("t_groups");
            modelBuilder.Entity<ParameterModel>().ToTable("t_parameter");
            modelBuilder.Entity<ProjectModel>().ToTable("t_project");
            modelBuilder.Entity<ProjectGroupModel>().ToTable("t_projectgroup");
            modelBuilder.Entity<UserGroupModel>().ToTable("t_usergroup");
            modelBuilder.Entity<UsersModel>().ToTable("t_users");
            modelBuilder.Entity<ValuesModel>().ToTable("t_values");

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var loggerFactory = new LoggerFactory();
        //    loggerFactory.AddProvider(new EFLoggerProvider());
        //    optionsBuilder.UseLoggerFactory(loggerFactory)
        //        .EnableSensitiveDataLogging();
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
