using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        public string Email { get; set; }
    }
}