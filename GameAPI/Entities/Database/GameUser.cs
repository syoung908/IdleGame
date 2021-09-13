using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Database {
    public class GameUser {
        [Key]
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Picture { get; set; }
    }
}
