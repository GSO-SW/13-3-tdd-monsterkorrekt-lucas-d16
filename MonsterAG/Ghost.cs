using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class Ghost
    {
        private string name = "Spooky";
        private int size = 1;


        public Ghost(string name)
        {
            this.name = name;
            this.Size = 1;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public string Haunt()
        {
            return name + " sagt: 'Buh'";
        }
    }
}
