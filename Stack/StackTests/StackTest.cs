using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stack;

namespace StackTests
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Creation()
        {
            Stacc<int> s = new Stacc<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value = s.Pop();
            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Size);
        }

        [Test]
        public void Too_Much_Pop()
        {
            Stacc<int> s = new Stacc<int>(3);
            Assert.Throws<ExpanditureProhibitionException>(() => s.Pop());
        }

        [Test]
        public void Too_Much_Push()
        {
            Stacc<int> s = new Stacc<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.Throws<ExceededSizeException>(() => s.Push(4));
        }

        [Test]
        public void Test_Peek_Element()
        {
            Stacc<int> s = new Stacc<int>(3);
            s.Push(2);
            s.Push(1);
            int value = s.Peek();
            Assert.AreEqual(1, value);
            Assert.AreEqual(2, s.Size);
        }

        [Test]
        public void Test_Peek_Eeception()
        {
            Stacc<int> s = new Stacc<int>(3);
            Assert.Throws<ExpanditureProhibitionException>(() => s.Peek());
        }
    }
}
