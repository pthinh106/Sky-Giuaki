﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sky.Entity
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { set; get; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(1024)]
        public string Name { set; get; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
