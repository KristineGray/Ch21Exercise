using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class AbstractEntity
    {
        private int _id;
        private static int ClassID = 0;

        public int ID { get { return _id; } }

        public AbstractEntity()
        {
            ClassID++;
            _id = ClassID;
        }
    }
}
