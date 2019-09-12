using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace WhoIsAppTo_server.Hubs
{
	public class TestHub:Hub
	{
		public void Send(string name, string message)
		{
			List<Classes.TestData> testList = new List<Classes.TestData>();

			testList.Add(new Classes.TestData { p1 = "AAA", p2 = "BBB", p3 = "" });
			testList.Add(new Classes.TestData { p1 = "CCC", p2 = "DDD", p3 = "" });

			//Clients.All.sendMessage(testList);
		}
	}
}
