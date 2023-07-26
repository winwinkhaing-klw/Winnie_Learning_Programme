using System.ComponentModel.DataAnnotations;

namespace Winnie_Learning_Programme.Models
{
    public class MailModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string From { get; set; }
        [EmailAddress]
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        [Required]
        public string SenderName { get; set; }
    }
}