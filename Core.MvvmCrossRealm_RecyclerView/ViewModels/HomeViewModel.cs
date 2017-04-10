using Core.MvvmCrossRealm_RecyclerView.Models;
using MvvmCross.Core.ViewModels;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MvvmCrossRealm_RecyclerView.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private IQueryable<Person> _persons;
        public IQueryable<Person> Persons
        {
            get { return _persons; }
            set { SetProperty(ref _persons, value); }
        }

        public void PopulatePersons()
        {
            int loop = 0;

            while(loop < 30)
            {
                var person = new Person { Name = "Person "+ loop};
                Realm.GetInstance().Write(() => 
                {
                    Realm.GetInstance().Add(person, false);
                });
                loop++;
            }
        }

        public void FetchPersons()
        {
            Persons = Realm.GetInstance().All<Person>();
        }
    }
}
