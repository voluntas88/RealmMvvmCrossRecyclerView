using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MvvmCrossRealm_RecyclerView.Models
{
    public class Person : RealmObject
    {
        [PrimaryKey]
        public string ID { set; get; } = Guid.NewGuid().ToString();
        public string Name { set; get; }
    }
}
