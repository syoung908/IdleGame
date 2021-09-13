using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Database {
    public class GameUser {
        [Key]
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Picture { get; set; }

        public ICollection<GameConnection> Connections { get; set; }
    }
}
