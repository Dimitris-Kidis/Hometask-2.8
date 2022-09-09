using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2._8.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        [MaxLength(length:20)]
        public string FullName { get; set; }
        [Required]
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<Schedule> Schedules { get; set; }

    }
}
