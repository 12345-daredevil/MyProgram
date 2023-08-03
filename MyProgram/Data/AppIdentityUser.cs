using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayGames.Data
{
    public class AppIdentityUser : IdentityUser
    {
        public int IdUser { get; set; }
        public DateTime Date { get; set; }

        public AppIdentityUser()
        {
            Date = DateTime.UtcNow;
        }
    }
}
