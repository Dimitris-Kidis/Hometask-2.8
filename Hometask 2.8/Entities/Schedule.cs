using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2._8.Entities
{
    public class Schedule : BaseEntity
    {
        [Required]
        [MaxLength(length:100)]
        public string Topic { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
