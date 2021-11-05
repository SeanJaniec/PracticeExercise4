using System;
using System.Collections.Generic;
namespace PracticeExercise4
{
    public class Deque<T> : IDeque<T>
    {
        private LinkedList<T> deque;
        public Deque()
        {
            deque = new LinkedList<T>();
        }

        public bool IsEmpty => deque.Count == 0 ? true : false;

        public int Length => deque.Count;

        public T Front => throw new NotImplementedException();

        public T Back => throw new NotImplementedException();



        public void AddBack(T item)
        {
            deque.AddLast(item);
        }

        public void AddFront(T item)
        {
            deque.AddFirst(item);
        }

        public T RemoveBack()
        {

            throw new NotImplementedException();


        }

        public T RemoveFront()
        {
            throw new NotImplementedException();

        }
    }
}

