using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Excursion.Models
{
    public class ExcursionDbContext : DbContext
    {
        public ExcursionDbContext()
            : base("Name=ExcursionDbContext")
        {
            Database.SetInitializer<ExcursionDbContext>(new DropCreateDatabaseIfModelChanges<ExcursionDbContext>());
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<AnswerSon> AnswerSons { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Coordinate> Coordinates { get; set; }

        public DbSet<Nature> Natures { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Provenace> Provenaces { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionResult> QuestionResults { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<ScenicSpot> ScenicSpots { get; set; }

        public DbSet<Sex> Sexs { get; set; }

        public DbSet<Stage> Stages { get; set; }

        public DbSet<Strategy> Strategys { get; set; }

        public DbSet<Territory> Territorys { get; set; }

        public DbSet<TravelType> TravelTypes { get; set; }

        public DbSet<User> Users { get; set; }
    }
}