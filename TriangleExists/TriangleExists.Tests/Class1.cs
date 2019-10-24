using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleExists;

namespace TriangleExists.Tests
{
    [TestFixture]
    public class Class1
    {
        TriangleExistsClass te = new TriangleExistsClass();
        [Test]
        public void Triangle_ExistsTrue()
        {
            Assert.IsTrue(te.TriangleExists(5, 10, 8));
        }

        [Test]
        public void Triangle_ExistsFalse()
        {
            Assert.IsFalse(te.TriangleExists(5, 10, 20));
        }

        [Test]
        public void Triangle_of_one_minus_side_ExistsFalse()
        {
            Assert.IsFalse(te.TriangleExists(-5, 4, 3));
        }

        [Test]
        public void Triangle_of_minus_sides_ExistsFalse()
        {
            Assert.IsFalse(te.TriangleExists(-5, -10, -8));
        }

        [Test]
        public void Triangle_of_two_equal_sides_ExistsTrue()
        {
            Assert.IsTrue(te.TriangleExists(5, 5, 6));
        }

        [Test]
        public void Triangle_of_equal_sides_ExistsTrue()
        {
            Assert.IsTrue(te.TriangleExists(2, 2, 2));
        }

        [Test]
        public void Triangle_of_zero_sides_ExistsFalse()
        {
            Assert.IsFalse(te.TriangleExists(0, 0, 0));
        }

        [Test]
        public void Triangle_of_one_zero_side_ExistsFalse()
        {
            Assert.IsFalse(te.TriangleExists(5, 4, 0));
        }


        [Test]
        public void Triangle_of_double_sides_ExistsTrue()
        {
            Assert.IsTrue(te.TriangleExists((double)5.4, (double)4.1, (double)8.91));
        }

        [Test]
        public void Triangle_of_sum_of_2_sides_equals_3rd_ExistsFalse()
        {
            Assert.IsFalse(te.TriangleExists(5, 6, 11));
        }
    }
}
