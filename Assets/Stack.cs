using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;


namespace Stacks
{
    public class Stack<T>
    {
        List<T> contents = new List<T>();
        //constructor
        public Stack()
        {

        }
        
        //gets the number of items in stack
        public int Count
        {
            get { return contents.Count; }
        }
        //push method (Pushes the item on the stack)

        public void Push(T item)
        {
            contents.Add(item);

        }
        //pop method (removes the item from the stack )
        public T Pop()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't pop from a stack");
            }
            else
            {
                //retrieve top of stack, remove and return

                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count = 1);
                return item;
            }
        }
        //peek method(peeks at the top item on the stack)
        public T Peek()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException()
            }
        }

    }


}

