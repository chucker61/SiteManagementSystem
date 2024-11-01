using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.AuthenticationDtos
{
    public class UserDtoForRegistration
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; init; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }
        public string? Email { get; init; }
        public string? PhoneNumber { get; init; }
        public int MembershipId { get; init; }
        public int HouseId { get; init; }
    }
}
