using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SampleDataBind
{

    public class Person
    {
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _name;

        private int _age;
        public int Age { get { return _age; } set { _age = value; } }

     
    }
        
    public class vm
    {
        public  List<ObservableCollection<Person>> _person { get; set; }
        public void LoadPersons ()
        {
            _person = new List<ObservableCollection<Person>>();
            _person.Add(new ObservableCollection<Person>() { new Person() { Name = "Naveen", Age = 27 } });
        }
    }
}

