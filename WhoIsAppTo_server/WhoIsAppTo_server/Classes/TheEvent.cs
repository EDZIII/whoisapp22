using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Classes
{
	public class TheEvent
	{
		public string EventID { get; set; }
		public string UserID { get; set; }
		public string UserCredentials { get; set; }
		public string EventDescription { get; set; }
		public string EventCategory { get; set; }
		public string EventTime { get; set; }
		public string EventPlace { get; set; }
		public int EventParticipants { get; set; }
		public int EventJoined { get; set; }
		public string EventCreationTime { get; set; }


		public TheEvent(string eventId, string userId, string user, string activity, string category, string time, string place, int partecipants)
		{
			this.EventID = eventId;
			this.UserID = userId;
			this.UserCredentials = user;
			this.EventDescription = activity;
			this.EventCategory = category;
			this.EventTime = time;
			this.EventPlace = place;
			this.EventParticipants = partecipants;
		}


		public void JoinEvent()
		{
			//diese Methode sollte dann benutzt werden, um sich an einem Event anzumelden
		}

		public void ModifyEvent()
		{
			//hier konnte der User die Events bearbeiten???
		}
	}
}
