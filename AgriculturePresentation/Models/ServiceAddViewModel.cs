using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Service")]
        [Required(ErrorMessage = "Lütfen bir servis giriniz")]
        public string ServiceName { get; set; }

        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Lütfen bir başlık giriniz.")]
        public string Title { get; set; }
        

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Lütfen bir Açıklama giriniz.")]
        public string Description { get; set; }


        [Display(Name = "İmaj")]
        [Required(ErrorMessage = "Lütfen bir imaj ekleyiniz.")]
        public string Image { get; set; }
    }
}
