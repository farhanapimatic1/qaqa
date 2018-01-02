using System.Collections.Generic;
using System.Text;
using CalculatorService.PCL.Utilities;
using CalculatorService.PCL.Models;
namespace CalculatorService.PCL
{
    public partial class Configuration
    {

        public enum Environments
        {
            PRODUCTION,
            TESTING,
        }
        public enum Servers
        {
            ICALCULATOR,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.ICALCULATOR,"http://Example.org/ICalculator" },
                    }
                },
                { 
                    Environments.TESTING,new Dictionary<Servers, string>
                    {
                        { Servers.ICALCULATOR,"https://apimatic.io" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:ICALCULATOR</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ICALCULATOR)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}