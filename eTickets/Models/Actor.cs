using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set;}

        [Display(Name= "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name mut be between 3 and 50 chars")]
        public string FullName { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }


        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
