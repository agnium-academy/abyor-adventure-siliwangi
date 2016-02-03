using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required]
        public string Nama { get; set; }

        [Required]
        public string Alamat { get; set; }

        [Required]
        public string Umur { get; set; }
    }
}