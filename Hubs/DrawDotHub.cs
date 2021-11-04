using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class DrawDotHub : Hub
    {
        public async Task UpdateCanvas(int x, int y, int red, int green, int blue)
        {
            await Clients.All.SendAsync("updateDot", x, y, red, green, blue);
        }

        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }
}