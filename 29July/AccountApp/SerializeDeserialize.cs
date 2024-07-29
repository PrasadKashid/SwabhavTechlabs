using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AccountApp
{
    internal class SerializeDeserialize
    {
        public static void SerializeData(List <Account> account)
        {
            File.WriteAllText("AccountData.json", JsonConvert.SerializeObject(account));
        }

        public static List<Account> DeserializeData()
        {
            string fileName = "AccountData.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                return new List<Account>();
            }
        }
    }
}
