using System.ComponentModel.DataAnnotations;

namespace Shikral.Demo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}