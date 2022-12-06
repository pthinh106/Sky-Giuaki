using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sky.Models
{
    public class StadiumViewModel
    {
        public long ID { get; set; }
        [Display(Name = "Tên sân vận động")]
        [Required(ErrorMessage = "Vui lòng điền tên sân vận động")]
        public string Name { get; set; }


    }
}
