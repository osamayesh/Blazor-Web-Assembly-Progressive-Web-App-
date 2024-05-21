using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp3.Shared.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
