using Newtonsoft.Json;
using SmartMapperCore.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SmartMapperCore.Util
{
    public class AppFunction
    {
        public static List<TransportJsonModel> getMetrobus()
        {
            string path = @"C:\XamStudioProjects\SmartMapper\SmartMapperCore\JsonFiles\metrobus.json";
            List<TransportJsonModel> transport;
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                transport = JsonConvert.DeserializeObject<List<TransportJsonModel>>(json);
            }
            return transport;
        }

        public static List<TransportJsonModel> getMetro()
        {
            string path = @"C:\XamStudioProjects\SmartMapper\SmartMapperCore\JsonFiles\metro.json";
            List<TransportJsonModel> transport;
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                transport = JsonConvert.DeserializeObject<List<TransportJsonModel>>(json);
            }
            return transport;
        }

        public static List<TransportJsonModel> getMarmaray()
        {
            string path = @"C:\XamStudioProjects\SmartMapper\SmartMapperCore\JsonFiles\marmaray.json";
            List<TransportJsonModel> transport;
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                transport = JsonConvert.DeserializeObject<List<TransportJsonModel>>(json);
            }
            return transport;
        }


        public static List<TransportJsonModel> getTransportFromJson()
        {
            List<TransportJsonModel> listMarmaray = getMarmaray();
            List<TransportJsonModel> listMetro = getMetro();
            List<TransportJsonModel> listMetrobus = getMetrobus();

            List<TransportJsonModel> result = new List<TransportJsonModel>();

            foreach (var metro in listMetro)
            {
                result.Add(metro);
            }

            foreach (var metrobus in listMetrobus)
            {
                result.Add(metrobus);
            }

            foreach (var marmaray in listMarmaray)
            {
                result.Add(marmaray);
            }

            return result;
        }

    }
}
