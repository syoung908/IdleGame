using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System;
using System.Linq;


namespace API {
    public class GameHub: Hub {
        public GameHub() {
        }

        public override Task OnConnectedAsync() {
            string userId = Context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception) {
            return base.OnDisconnectedAsync(exception);
        }
    }
}