using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Model
{
    public class DbTools
    {
        private DbTools() //first make the constructor private
        {

        }

        private static NorthwindEntities _northwind; //Create a static private field that you can fill with instance
        public static NorthwindEntities InstanceNorthwind
        {
            //Then create a static public property. If the instance has been taken before, bring it to the property. If the instance hasn't been taken before, get the instance and return it to the property.
            get
            {
                if (_northwind == null)
                {
                    _northwind = new NorthwindEntities();
                }
                return _northwind;
            }
        }
    }
}
