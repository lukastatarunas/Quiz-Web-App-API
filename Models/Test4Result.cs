using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Test4Result
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public int Result { get; set; }
    }
}
