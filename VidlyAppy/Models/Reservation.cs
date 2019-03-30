using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyAppy.Models
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBecancelledBy(User user)
        {
            if (user.IsAdmin == true)
                return true;

            if (MadeBy == user)
                return true;

            return false;
        }


    }

    public class User
    {
        public int id { get; set; }
        public bool IsAdmin { get; set; }
    }
}