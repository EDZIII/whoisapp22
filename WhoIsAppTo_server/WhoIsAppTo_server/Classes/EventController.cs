using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoIsAppTo_server.Classes;

namespace WhoIsAppTo_server.Classes
{
	public class EventController
	{
		[JsonProperty("eventID")]
		public string EventID;
		[JsonProperty("userID")]
		public string UserID;
		[JsonProperty("userCredentials")]
		public string UserCredentials;
		[JsonProperty("eventMessage")]
		public string EventMessage;
		[JsonProperty("eventCategory")]
		public string EventCategory;
		[JsonProperty("eventTime")]
		public string EventTime;
		[JsonProperty("eventPlace")]
		public string EventPlace;
		[JsonProperty("eventPartecipantsRequested")]
		public int EventPartecipantsRequested;
		[JsonProperty("eventPartecipantsJoined")]
		public int EventPartecipantsJoined;

		//public EventController(string user, string activity, string category, string time, string place, int partecipants)
		//{
		//	this.EventID = Guid.NewGuid().ToString();
		//	this.UserID = Guid.NewGuid().ToString();
		//	this.UserCredentials = user;
		//	this.EventMessage = activity;
		//	this.EventCategory = category;
		//	this.EventTime = time;
		//	this.EventPlace = place;
		//	this.EventPartecipantsRequested = partecipants;

		//}
		public EventController()
		{

		}

		public void AddEvent(string user, string activity, string category, string time, string place, int partecipants)
		{
			string EventID = Guid.NewGuid().ToString();
			string UserID = Guid.NewGuid().ToString();
			string eventLogTime = DateTime.Now.ToString();
			TheEvent theEvent = new TheEvent(EventID, UserID, user, activity, category, time, place, partecipants);

			JSONHandler.AddEvent(theEvent);
		}

	}

}