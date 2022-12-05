using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Adapter
{
    public class City
    {
        public string Name { get; set; }
        public long HabitantsCount { get; set; }
    }

    public class Client
    {
        ICityAdapter CityAdapter { get;  }
        public Client(ICityAdapter cityAdapter)
        {
            CityAdapter = cityAdapter;
        }
       public  void UseCity()
       {
           var city = CityAdapter.GetCity();
           Console.WriteLine(JsonConvert.SerializeObject(city));
       }
    }

    public interface ICityAdapter
    {
        City GetCity();
    }

    public class CityAdapter : ICityAdapter
    {
        ExternalSystem ExternalSystem { get; set; }
        public City GetCity()
        {
            var cityFromExternalSystem = ExternalSystem.GetCity();
            return new()
            {
                Name = cityFromExternalSystem.Name,
                HabitantsCount = cityFromExternalSystem.Population,
            };
        }
    }

    public class ExternalSystem
    {
        public static CityFromExternalSystem GetCity()
        {
            return new()
            {
                Name = "Tunja",
                CountryID = "COL",
                Population = 200000
            };
        }
    }

    public class CityFromExternalSystem
    {
        public string Name { get; set; }
        public string CountryID { get; set; }
        public long Population { get; set; }
    }
}
