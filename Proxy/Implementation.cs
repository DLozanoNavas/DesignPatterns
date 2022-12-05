using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /// <summary>
    /// Subject
    /// </summary>
    public interface ICelebrity
    {
        bool GetApproval();
    }

    /// <summary>
    /// RealSubject
    /// </summary>
    public class Celebrity : ICelebrity
    {
        private string Name;

        public Celebrity(string name)
        {
            Name = name;
        }

        public bool GetApproval()
        {
            Console.WriteLine($"Getting Approval from {Name}");
            Thread.Sleep(1000);
            return true;
        }

        public void DisplayCelebrity()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    /// <summary>
    /// Virtual Proxy
    /// </summary>
    public class ManagerProxy : ICelebrity
    {
        private Lazy<Celebrity> _Celebrity;

        public ManagerProxy(string celebrityName)
        {
            _Celebrity = new Lazy<Celebrity>(() => new Celebrity(celebrityName)); // Thread Safe Lazy Initialization
        }

        public bool GetApproval()
        {
            return _Celebrity.Value.GetApproval();
        }
    }

    /// <summary>
    /// Smart / Protection Proxy
    /// </summary>
    public class BodyGuardProxy : ICelebrity
    {
        private ManagerProxy _managerProxy;
        private string _userRole;
        public BodyGuardProxy(string celebrityName, string userRole)
        {
            _userRole = userRole;
            _managerProxy = new ManagerProxy(celebrityName);
        }

        public bool GetApproval()
        {
            if (_userRole != "knownPerson")
                throw new UnauthorizedAccessException();

            return _managerProxy.GetApproval();
        }
    }

}
