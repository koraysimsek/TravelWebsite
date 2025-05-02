using System.Collections.Generic;

namespace AcunMedyaTravelProject.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Destinations> Destinations { get; set; }

    }
}