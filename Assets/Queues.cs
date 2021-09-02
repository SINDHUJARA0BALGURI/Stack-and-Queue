using System;
using System.Collections.Generic;
using System.Text;


namespace Queues
{
    public class Queues<T>
    {
        List<T> contents = new List<T>();

        //constructor
        public Queues()
        {

        }
        //gets the number of items in list
        public int Count
        {
            get { return contents.Count;  }
        }

        //enqueue method add item to the queue
        public void Enqueue(T item)
        {
            contents.Add(item);
        }
        //dequeue method removes front items in queue and returns it

        public T Dequeue()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't remove fromn queue");

            }
            else
            {
                //retrieve front of queue,remove and return
                T item = contents[0];
                contents.RemoveAt(0);
                return item;

            }
        }




       
    }

}
