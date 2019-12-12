using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stacc<T>
    {
        #region Members
        private T[] stackArray;
        private int maxLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Construtor
        public Stacc(int length)
        {
            maxLength = length;
            stackArray = new T[length];
        }
        #endregion

        public void Push(T value)
        {
            if (Size == maxLength)
            {
                throw new ExceededSizeException();
            }
            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if(Size == 0)
            {
                throw new ExpanditureProhibitionException();
            }
            return stackArray[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
            {
                throw new ExpanditureProhibitionException();
            }

            return stackArray[Size - 1];
        }
    }
}
