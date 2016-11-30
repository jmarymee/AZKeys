using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace AZKeys
{
    public class AZKeysClass
    {
        public void StoreKeys(AZKeys secrets, string filePath)
        {
            XmlSerializer ser = new XmlSerializer(typeof(AZKeys));
            TextWriter writer = new StreamWriter(filePath);

            ser.Serialize(writer, secrets);
            writer.Close();
        }

        public AZKeys GetSecrets(string filePath)
        {
            XmlSerializer ser = new XmlSerializer(typeof(AZKeys));
            FileStream stream = new FileStream(filePath, FileMode.Open);
            AZKeys keys = (AZKeys)ser.Deserialize(stream);
            return keys;
        }
    }

    [Serializable]
    public class AZKeys
    {
        public string azSubscriptionFriendlyName { get; set; }
        public string azSubscription { get; set; }
        public string azStorageAccountName { get; set; }
        public string azStoragePrimaryKey { get; set; }
        public string azStorageSecondaryKey { get; set; }
        public string azStorageBaseURI { get; set; }
        public string SAS { get; set; }
    }
}
