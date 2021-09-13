using System.ComponentModel.DataAnnotations;


namespace Entities.Database {
    public class GameConnection {
        [Key]
        public string ConnectionId { get; set; }

        public bool Active { get; set; } = false;

        public GameUser GameUser { get; set; }

        public string GameUserId { get; set; }
    }
}
