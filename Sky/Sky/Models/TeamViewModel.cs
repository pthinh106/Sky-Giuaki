using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sky.Models
{
    public class TeamViewModel
    {
        public long ID { set; get; }
        [Display(Name = "Tên đội bóng")]
        [Required(ErrorMessage = "Vui lòng nhập tên đội bóng")]
        public string Name { set; get; }
        [Display(Name = "Số lượng cầu thủ")]
        public int PlayerTotal { set; get; }
    }
}
