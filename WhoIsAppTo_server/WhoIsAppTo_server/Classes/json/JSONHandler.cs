using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Classes
{
	public static class JSONHandler
	{
		public enum Ressources { EVENTS = 0, USERS = 1, CATEGORIES = 2 }
		private static List<string> paths = new List<string>() {
			@"C:\Users\edocr\Desktop\whoisapp2new\whoisapp22\WhoIsAppTo_server\WhoIsAppTo_server\Classes\json\events.json",
			@"C:\Users\edocr\Desktop\whoisapp2new\whoisapp22\WhoIsAppTo_server\WhoIsAppTo_server\Classes\json\user.json",
			@"C:\Users\edocr\Desktop\whoisapp2new\whoisapp22\WhoIsAppTo_server\WhoIsAppTo_server\Classes\json\category.json"
		};
		private static List<string> keywords = new List<string>()
		{
			"Events",
			"Users",
			"Categories"
		};
		public static List<T> ReadRessources<T>(Ressources ressource)
		{
			string json = ReadJson(paths[((int)ressource)]);
			JObject all = JsonConvert.DeserializeObject<JObject>(json);
			string events = all.GetValue(keywords[((int)ressource)]).ToString();
			return JsonConvert.DeserializeObject<List<T>>(events);
		}

		private static string ReadJson(string path)
		{
			StreamReader streamReader = new StreamReader(path);
			string json = streamReader.ReadToEnd();
			streamReader.Dispose();
			return json;
		}
		public static void AddEvent(TheEvent theEvent)
		{
			List<TheEvent> existingEvents = JSONHandler.ReadRessources<TheEvent>(Ressources.EVENTS);
			existingEvents.Add(theEvent);
			File.WriteAllText(paths[(int)Ressources.EVENTS], "{\n\"Events\" : " + JsonConvert.SerializeObject(existingEvents) + "\n}");
		}
		public static void AddUser(User user)
		{
			List<User> existingUser = JSONHandler.ReadRessources<User>(Ressources.EVENTS);
			existingUser.Add(user);
			File.WriteAllText(paths[(int)Ressources.EVENTS], "{\n\"Users\" : " + JsonConvert.SerializeObject(existingUser) + "\n}");
		}
	}
}


