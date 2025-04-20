using AcunMedyaTravelProject.Entities;
using System.ComponentModel;
using System.Data.Entity;

namespace AcunMedyaTravelProject.Context
{
    public class AcunMedyaDbContext:DbContext
    {
        DbSet<Booking> Bookings { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Sponsor> Sponsors { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }
        DbSet<Slider> Slider { get; set; }
        DbSet<Services> Services { get; set; }
        DbSet<Destinations> Destinations { get; set; }
        DbSet<Subscription> Subscriptions { get; set; }
    }
}