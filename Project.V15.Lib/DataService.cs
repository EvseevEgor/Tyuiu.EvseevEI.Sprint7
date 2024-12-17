using Newtonsoft.Json;

namespace Project.V15.Lib
{
    public class DataService
    {
        public List<ID> GetID()
        {
            string jsonFilePath = "../../../../egor.json";
            
            string json = File.ReadAllText(jsonFilePath);

            var IDS = JsonConvert.DeserializeObject<List<ID>>(json);
            
            return IDS;
        }
        public List<ID> SearchID(string filterText)
        {
            string jsonFilePath = "../../../../egor.json";

            string json = File.ReadAllText(jsonFilePath);

            var IDss = JsonConvert.DeserializeObject<List<ID>>(json);
            string filterValue = filterText.Trim();
            var IDs = IDss.FindAll(ID =>
            ID.IDNumber.ToString().Contains(filterValue));

            return IDs;
        }


        public List<ID> SortID()
        {
            string jsonFilePath = "../../../../egor.json";

            string json = File.ReadAllText(jsonFilePath);

            var Idn = JsonConvert.DeserializeObject<List<ID>>(json);

            return Idn.OrderBy(c => c.salary).ToList();
        }
    }
}

