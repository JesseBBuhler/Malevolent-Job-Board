using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Malevolent_Job_Board.Models
{
    public class JobBoardContext : DbContext
    {
        public JobBoardContext (DbContextOptions<JobBoardContext> options) : base (options)
        {

        }

        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Application> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<PositionType>().HasData(
                new PositionType { PositionTypeID = 1, PositionTypeDesc = "Full Time"},
                new PositionType { PositionTypeID = 2, PositionTypeDesc = "Part Time" },
                new PositionType { PositionTypeID = 3, PositionTypeDesc = "Internship" },
                new PositionType { PositionTypeID = 4, PositionTypeDesc = "Contract" }
                );

            mb.Entity<Post>().HasData(
                new Post {
                    PostID = 1, 
                    PositionTypeID = 1, 
                    PositionTitle = "Treacherous Second In Command", 
                    Company = "Mordor", 
                    Salary = 150000, 
                    Description = "Sauron is in need of a right hand man to send after the plucky band of adventurers so that he doesn't have to go himself and blow the powerscale way out of balance.  It is imperative that a successful applicant have a tragic backstory that will make them sympathetic to the audience before their inevitable redemption arc."
                },
                new Post
                {
                    PostID = 2,
                    PositionTypeID = 4,
                    PositionTitle = "Bounty Hunter",
                    Company = "The Galactic Empire",
                    Salary = 50000,
                    Description = "I need someone to find and kill Luke before the Emperor finds out that he may or may not actually be dead."
                },
                new Post
                {
                    PostID = 3,
                    PositionTypeID = 3,
                    PositionTitle = "Cthulhu's gopher",
                    Company = "The Unspeakable Void",
                    Salary = 0,
                    Description = "The Great Old One is looking for an intern to summon him from the beyond, perform ritual sacrifices, torment the local moody doctor, and other tasks that he just can't be bothered to do himself.  This is an unpaid internship but applicants will be given the opportunity to learn dark secrets not fit for the mind of man."
                }
                );
        }
        
    }
}
