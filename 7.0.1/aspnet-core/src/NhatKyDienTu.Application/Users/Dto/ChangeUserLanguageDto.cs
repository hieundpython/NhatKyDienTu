using System.ComponentModel.DataAnnotations;

namespace NhatKyDienTu.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}