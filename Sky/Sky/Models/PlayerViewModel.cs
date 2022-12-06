using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sky.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sky.Models
{
    public class PlayerViewModel
    {
        public long ID { set; get; }
        [Display(Name = "Tên cầu thủ")]
        [Required(ErrorMessage = "Vui lòng nhập tên cầu thủ")]
        public string Name { set; get; }
        [Display(Name = "Vị trí")]
        public string Type { set; get; }
        [Display(Name = "Số áo")]
        [Required(ErrorMessage = "Vui lòng điền số áo")]
        public int Number { set; get; }
        [Display(Name = "Tên đội bóng")]
        public string NameTeam { set; get; }
    }
}
