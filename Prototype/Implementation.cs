using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Prototype
{

    public abstract class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract Person ShallowClone();
        public abstract Person? DeepClone();
    }

    public class Manager: Person
    {
        public Manager(string name) : base(name)
        {
            
        }

        public override Person ShallowClone()
        {
            return (Person)MemberwiseClone();
        }
        public override Person? DeepClone()
        {
            return JsonConvert.DeserializeObject<Manager>(JsonConvert.SerializeObject(this));
        }
    }

    public class Employee: Person
    {
        public Manager Manager { get; set; }
        public Employee(string name, Manager manager) : base(name)
        {
            Manager = manager;
        }
        public override Person ShallowClone()
        {
            return (Person)MemberwiseClone();
        }
        
        public override Person? DeepClone()
        {
            return JsonConvert.DeserializeObject<Employee>(JsonConvert.SerializeObject(this));
        }
    }


}
