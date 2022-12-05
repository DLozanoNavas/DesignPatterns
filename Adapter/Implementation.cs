using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Adapter
{
    /// <summary>
    /// Source (Adaptee)
    /// </summary>
    public class ExternalSystem
    {
        public  CityFromExternalSystem GetCity()
        {
            return new()
            {
                Name = "Tunja",
                CountryID = "COL",
                Population = 200000
            };
        }
    }

    /// <summary>
    /// Client
    /// </summary>
    public class Client
    {
        ICityAdapter CityAdapter { get; }
        public Client(ICityAdapter cityAdapter)
        {
            CityAdapter = cityAdapter;
        }
        public void UseCity()
        {
            var city = CityAdapter.GetCity();
            Console.WriteLine(JsonConvert.SerializeObject(city));
        }
    }

    /// <summary>
    /// Target
    /// </summary>
    public interface ICityAdapter
    {
        City GetCity();
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class CityAdapter : ICityAdapter
    {
        ExternalSystem ExternalSystem { get; set; }

        public CityAdapter()
        {
            ExternalSystem = new ExternalSystem();
        }
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
    
    /// <summary>
    /// Class Adapter
    /// </summary>
    public class CityClassAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            var cityFromExternalSystem = base.GetCity();
            return new()
            {
                Name = cityFromExternalSystem.Name,
                HabitantsCount = cityFromExternalSystem.Population,
            };
        }
    }


    public class City
    {
        public string Name { get; set; }
        public long HabitantsCount { get; set; }
    }

    public class CityFromExternalSystem
    {
        public string Name { get; set; }
        public string CountryID { get; set; }
        public long Population { get; set; }
    }
}
