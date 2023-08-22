using FormsApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Repositories
{
    public class WebSiteRepository
    {
        public string DirectoryAddress { get; set; }
        public string JsonDatabase { get; set; }

        public WebSiteRepository()
        {
            DirectoryAddress = "C:\\Users\\Excalibur\\Desktop\\json";
            JsonDatabase = DirectoryAddress + "\\MyAccounts.json";

            bool checkDirectory = Directory.Exists(DirectoryAddress);

            if (checkDirectory == false)
            {
                Directory.CreateDirectory(DirectoryAddress);

                bool checkDatabase = File.Exists(JsonDatabase);

                if (checkDatabase == false)
                {
                    List<WebSiteItem> databaseList = new List<WebSiteItem>();

                    databaseList.Add(new WebSiteItem()
                    {
                        id = Guid.NewGuid(),
                        WebSiteName = "https://outlook.live.com/owa/",
                        UserName = "AtakanTurgut",
                        Password = "123456",
                        Description = string.Empty,
                        CreateDate = DateTime.Now,
                        ChangePasswordDate = DateTime.Now.AddDays(14)
                    });

                    string jsonDatabaseContent = Newtonsoft.Json.JsonConvert.SerializeObject(databaseList);

                    if (File.Exists(JsonDatabase))
                    {
                        // Eğer dosya zaten varsa, yeni öğeyi mevcut verilere ekleyerek güncelle
                        List<WebSiteItem> existingData = GetDataList();
                        existingData.AddRange(databaseList);
                        jsonDatabaseContent = Newtonsoft.Json.JsonConvert.SerializeObject(existingData);
                    }

                    File.WriteAllText(JsonDatabase, jsonDatabaseContent);
                }
            }
        }

        public void Save(WebSiteItem item)
        {
            List<WebSiteItem> databaseList;

            if (File.Exists(JsonDatabase))
            {
                string jsonContent = File.ReadAllText(JsonDatabase);
                databaseList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WebSiteItem>>(jsonContent);
            }
            else
            {
                databaseList = new List<WebSiteItem>();
            }

            databaseList.Add(item);

            string updatedJsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(databaseList);
            File.WriteAllText(JsonDatabase, updatedJsonContent);
        }

        public List<WebSiteItem> GetDataList()
        {
            List<WebSiteItem> databaseList = new List<WebSiteItem>();

            if (File.Exists(JsonDatabase))
            {
                string jsonContent = File.ReadAllText(JsonDatabase);
                databaseList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WebSiteItem>>(jsonContent);
            }

            return databaseList;
        }
    }
}
