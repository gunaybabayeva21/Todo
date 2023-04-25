using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elave_task_todo
{
    internal class Todo
    {
        public int _id;
        public int Id { get; set; }
        public string Title { get; set; }

        public bool IsCheck { get; set; }

        public Todo(string title, bool ischeck)
        {
            _id++;
            Id=_id;
            Title= title;
            IsCheck= ischeck;
            
        }



    }
}
