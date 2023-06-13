using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core
{
    public class Singleton<T> where T : class
    {
        public T Instance { get; protected set; }
    }
}
