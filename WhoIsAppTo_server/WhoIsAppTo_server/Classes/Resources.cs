using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace WhoIsAppTo_server.Classes
{
	public static class Ressources
	{
		public static string JsonPath = @"C:\Users\edocr\Desktop\whoisapp2new\whoisapp22\WhoIsAppTo_server\WhoIsAppTo_server\Classes\db_mockup\dynamicdata.json";

		public static void GetUsers()
		{
			StreamReader streamReader = new StreamReader(JsonPath);
			string json = streamReader.ReadToEnd();
			JObject obj = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(json);
			streamReader.Close();
			JToken user = obj.GetValue("Users");
			JEnumerable<JToken> Users = user.Children();
		}
		public static void GetEvents()
		{
			StreamReader streamReader = new StreamReader(JsonPath);
			string json = streamReader.ReadToEnd();
			JObject obj = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(json);
			streamReader.Close();
			JToken events = obj.GetValue("Events");
			JEnumerable<JToken> Users = events.Children();
		}
		public static void GetCategories()
		{
			StreamReader streamReader = new StreamReader(JsonPath);
			string json = streamReader.ReadToEnd();
			JObject obj = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(json);
			streamReader.Close();
			JToken categories = obj.GetValue("Categories");
			JEnumerable<JToken> Users = categories.Children();
		}
	}
}
