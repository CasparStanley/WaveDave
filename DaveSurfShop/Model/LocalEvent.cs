using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DaveSurfShop
{
    public class LocalEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime DateAndTime { get; set; }
        [Required]
        public string Location { get; set; }

        public LocalEvent()
        { }

        public LocalEvent(string name, DateTime eventDateTime, string location)
        {
            Name = name;
            DateAndTime = eventDateTime;
            Location = location;
        }
    }
}
