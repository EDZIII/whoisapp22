using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Classes
{
	public class Category
	{
		public string PrivateKey { get;}
		public string CategoryDescription { get; set; }
		public string CategoryName { get; set; }
		//public ICollection< SubCategory> subCategories { get; set; }

	public void ToJson()
		{
			Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}

		public Category(string json)
		{
			StreamReader streamReader = new StreamReader(@"C: \Users\edocr\Desktop\whoisapp2new\whoisapp22\WhoIsAppTo_server\WhoIsAppTo_server\Classes\db_mockup\category.json");

			Category test = Newtonsoft.Json.JsonConvert.DeserializeObject<Category>(json);
		}
		public void LoadJson()
		{
			using (StreamReader r = new StreamReader(@"C: \Users\edocr\Desktop\whoisapp2new\whoisapp22\WhoIsAppTo_server\WhoIsAppTo_server\Classes\db_mockup\category.json"))
			{
				string json = r.ReadToEnd();
				List<Category> items = JsonConvert.DeserializeObject<List<Category>>(json);
			}
		}
	}
}
