using AcunMedyaTravelProject.Entities;
using System.ComponentModel;
using System.Data.Entity;

namespace AcunMedyaTravelProject.Context
{
    public class AcunMedyaDbContext:DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Destinations> Destinations { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}