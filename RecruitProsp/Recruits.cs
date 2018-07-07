using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RecruitProsp
{
    class Recruits
    {
        public string Name;
        public string Position;
        public string StarRating;
        public int Age;
        public double Speed;
        public int Weight;
        public string State;
        public string School;

        public Recruits next;
    }

    class RecruitList
    {
        private int size;

        public RecruitList()
        {
            size = 0;
            head = null;
        }

        public Recruits head;

        public int Count
        {
            get { return size; }
        }

        public int Add(Recruits newItem)
        {
            Recruits sample = new Recruits();
            sample = newItem;
            sample.next = head;
            head = sample;
            return size++;  
        }

        public Recruits Get(int Position)
        {
            Recruits current = head;

            for (int i = 0; i < Position && current != null; i++)
                current = current.next;
            return current;
        }
    }
}
