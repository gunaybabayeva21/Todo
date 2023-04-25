using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elave_task_todo
{

    internal class User
    {
        public int Id { get; set; }
        public int _id { get ; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Todo> Todos { get; }

        public User(string name, string surname)
        {
            _id++;
            Id= _id;

            Name= name;
            Surname= surname;

        }

    }
}
