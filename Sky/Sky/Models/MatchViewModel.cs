using Sky.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sky.Models
{
    public class MatchViewModel
    {
        public long? ID { set; get; }
        [Required(ErrorMessage ="Vui lòng chọn đội nhà")]
        [Display(Name ="Đội nhà")]
        public string First { set; get; }
        [Required(ErrorMessage = "Vui lòng chọn đội khách")]
        [Display(Name = "Đội khách")]
        public string Last { set; get; }
        [Display(Name ="Sận vận động")]
        [Required(ErrorMessage = "Vui lòng chọn sân vận động")]
        public string NameStadium { set; get; }
    }
}
