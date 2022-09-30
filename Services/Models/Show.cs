using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasBeenWatched { get; set; }
    }
}
