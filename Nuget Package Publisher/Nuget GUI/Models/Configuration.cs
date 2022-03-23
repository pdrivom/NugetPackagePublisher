using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuget_GUI.Models
{
    public class Configuration
    {
        private static string ConfigDestination  => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        public string Server { get; set; }
        public string ApiKey { get; set; }
        public List<string> Packages { get; }
        public bool IsEmpty { get => string.IsNullOrEmpty(Server) && string.IsNullOrEmpty(ApiKey); }

        public Configuration()
        {
            Packages = new List<string>();
        }
        public Configuration(string server, string apiKey, List<string> packages)
        {
            Server = server;
            ApiKey = apiKey;
            Packages = packages;    
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public static Configuration Deserialize(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<Configuration>(json);
            }
            catch (Exception)
            {

                return new Configuration();
            }

        }
        public void Save()
        {
            File.WriteAllText(ConfigDestination, Serialize());
        }
        public static Configuration Load()
        {
            if (File.Exists(ConfigDestination))
            {
                var json = File.ReadAllText(ConfigDestination);
                return Deserialize(json);
            }
            else
            {
                return new Configuration();
            }
        }
    }
}
