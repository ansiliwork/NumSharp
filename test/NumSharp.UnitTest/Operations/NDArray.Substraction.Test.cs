using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using NumSharp.Core.Extensions;
using System.Linq;
using NumSharp.Core;

namespace NumSharp.UnitTest.Operations
{
    [TestClass]
    public class NDArraySubstractionTest
    {
        [TestMethod]
        public void DoubleTwo1D_NDArraySubtraction()
        {
            var np1 = new NumPyGeneric<double>().array(new double[] { 3, 5, 7 });
            var np2 = new NumPyGeneric<double>().array(new double[] { 1, 3, 4 });

            // var np3 = np1 - np2;

            // Assert.IsTrue(Enumerable.SequenceEqual(new double[]{2,2,3},np3.Data));
        }

        [TestMethod]
        public void Double1DPlusOffset_NDArraySubtraction()
        {
            var np1 = new NumPyGeneric<double>().array(new double[] { 3, 5, 7 });

            // var np2 = np1 - 3;

            // Assert.IsTrue(Enumerable.SequenceEqual(new double[]{0,2,4},np2.Data));
        }

        [TestMethod]
        public void Complex1DPlusOffset_NDArraySubtraction()
        {
            var np1 = new NumPyGeneric<Complex>().array(new Complex[] { new Complex(6, 8), new Complex(10, 12) });

            // var np2 = np1 - new Complex(2,1);

            // Assert.IsTrue(Enumerable.SequenceEqual(new Complex[]{new Complex(4,7),new Complex(8,11)},np2.Data));
        }

        [TestMethod]
        public void ComplexTwo1D_NDArraySubtraction()
        {
            var np1 = new NumPyGeneric<Complex>().array(new Complex[] { new Complex(6, 8), new Complex(10, 12) });
            var np2 = new NumPyGeneric<Complex>().array(new Complex[] { new Complex(5, 6), new Complex(7, 8) });

            // var np3 = np1 - np2;

            // Assert.IsTrue(Enumerable.SequenceEqual(new Complex[]{new Complex(1,2),new Complex(3,4)},np3.Data));
        }
    }
}
