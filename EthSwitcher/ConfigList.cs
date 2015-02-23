using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EthSwitcher {
    public class ConfigList {
        public class Config {
            public String Name { get; set; }

            public String IpAddress { get; set; }

            public String Subnet { get; set; }

            public String Gateway { get; set; }

            public String Dns1 { get; set; }

            public String Dns2 { get; set; }
        }

        private static readonly ConfigList Instance = new ConfigList();

        private List<Config>  _cfgList;

        private ConfigList() {
            Load();
        }

        public static ConfigList GetInstance() {
            return Instance;
        }


        public List<Config> GetList() {
            return _cfgList;
        }

        public void Add(String name, String ipAddress, String subnet, String gateway, String dns1, String dns2) {
            var data = new Config();
            data.Name = name;
            data.IpAddress = ipAddress;
            data.Subnet = subnet;
            data.Gateway = gateway;
            data.Dns1 = dns1;
            data.Dns2 = dns2;

            _cfgList.Add(data);
            Save();
        }

        public void Add(Config data) {
            _cfgList.Add(data);
            Save();
        }

        public void Remove(Config cfg) {
            _cfgList.Remove(cfg);
            Save();
        }

        public Config GetItem(int index) {
            try {
                return _cfgList[index];
            } catch (Exception) {
                return null;
            }
        }

        public String[] GetNames() {
            if (_cfgList.Count == 0) return new[] {""};
            String[] str = new string[_cfgList.Count];
            for (int i = 0; i < _cfgList.Count; i++) {
                str[i] = _cfgList[i].Name;
            }
            return str;
        }

        public class SaveData {
            public List<Config> Data { get; set; }
        }

        public void Save() {
            SaveData data = new SaveData();
            data.Data = _cfgList;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SaveData));

            FileStream outStream = new FileStream("settings.xml", FileMode.Create);
            xmlSerializer.Serialize(outStream, data);
            outStream.Close();
        }

        public void Load() {
            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof (SaveData));

                FileStream inStream = new FileStream("settings.xml", FileMode.Open);

                SaveData data = (SaveData) xmlSerializer.Deserialize(inStream);
                inStream.Close();

                _cfgList = data.Data;
            } catch (Exception) {
                _cfgList = new List<Config>();
            }
        }
    }
}
