using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elave_task_todo
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string massaage ):base(massaage) { }
    }
}
