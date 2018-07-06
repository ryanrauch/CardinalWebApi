using CardinalWebApiLibrary.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CardinalWebApi.Hubs
{
    public class TabsHub : Hub
    {
        public async Task AddTab(Tab item)
        {
            await Clients.All.SendAsync("AddTab", item.TabId, item.FirstName, item.LastName, item.TimestampOpened);
        }
        public async Task ReceiveMessage(string user, string msg)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, msg);
        }
        public async Task SendMessage(string user, string msg)
        {
            await Clients.All.SendAsync("SendMessage", user, msg);
        }
    }
}
