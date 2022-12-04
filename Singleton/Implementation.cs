using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {


        /// <summary>
        /// Not thread Safe
        /// </summary>
        public static Logger Instance { get { return _instance ??= new Logger(); } } 
        private static Logger? _instance;

        /// <summary>
        /// Thread Safe Logger
        /// </summary>
        public static Logger? LazyInstance => _lazyInstance?.Value; 
        private static readonly Lazy<Logger?>? _lazyInstance = new(() => new Logger());

        private Logger()
        {
                
        }

        public void Log(string message)
        {
        }
    }
}
