using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WhoIsAppTo_server.Classes;

namespace WhoIsAppTo_server.Hubs
{
	public class EventHub : Hub
	{
		public async Task SendMessage(string user, string activity, string category, string time, string place, int participants)
		{
		
			await Clients.All.SendAsync("ReceiveMessage", user, activity, category, time, place, participants);
			EventController eventController = new EventController();
			eventController.AddEvent(user, activity, category, time, place, participants);
	
		}
		
	}
}

