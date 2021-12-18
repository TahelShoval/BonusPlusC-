using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ManangementEntitiesSingleton
    {

        private static readonly Lazy<BonusPlusDBEntities>

        lazy = new Lazy<BonusPlusDBEntities>(() => new BonusPlusDBEntities());

        public static BonusPlusDBEntities Instance { get { return lazy.Value; } }
        private ManangementEntitiesSingleton()
        {
        }
    }
}
