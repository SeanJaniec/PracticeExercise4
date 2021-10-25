using System;
using System.Collections.Generic;
namespace PracticeExercise4
{
    public class Deque<T> : IDeque<T>
    {
        private Deque<T> deque;
        public Deque()
        {
            deque = new Deque<T>();
        }

        public bool IsEmpty => deque.IsEmpty ? true : false;

        public int Length => deque.Length;

        public T Front => deque.Length != 0 ? deque.Front : throw new EmptyQueueException();

        public T Back => deque.Length != 0 ? deque.Back : throw new EmptyQueueException();



        public void AddBack(T item)
        {
            deque.AddBack(item);
        }

        public void AddFront(T item)
        {
            deque.AddFront(item);
        }

        public T RemoveBack()
        {
            

            return deque.RemoveBack();


        }

        public T RemoveFront()
        {
            return deque.RemoveFront();

        }
    }
}

