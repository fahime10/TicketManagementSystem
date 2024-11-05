using System.ComponentModel.DataAnnotations;

namespace Domain.DTO.Request
{
    public class ChangePasswordRequest
    {
        [Required]
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword{ get; set; }
    }
}
