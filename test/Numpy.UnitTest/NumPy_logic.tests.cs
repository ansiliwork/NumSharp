﻿// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Numpy.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Numpy.UnitTest
{
    [TestClass]
    public class NumPy_logicTest : BaseTestCase
    {

        [TestMethod]
        public void allTest()
        {
            // >>> np.all([[True,False],[True,True]])
            // False

            var givenb = np.all(new[,] { { true, false }, { true, true } });
            Assert.AreEqual(false, givenb);

            // >>> np.all([[True,False],[True,True]], axis=0)
            // array([ True, False])

            var given = np.all(new[,] { { true, false }, { true, true } }, axis: new int[] { 0 });
            var expected =
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);

            // >>> np.all([-1, 4, 5])
            // True
            // 

            givenb = np.all(new[] { -1, 4, 5 });
            Assert.AreEqual(true, givenb);

            // >>> np.all([1.0, np.nan])
            // True
            // 

            Assert.IsTrue(np.all(new[] { 1.0, np.nan }));

            // >>> o=np.array([False])
            // >>> z=np.all([-1, 4, 5], out=o)
            // >>> id(z), id(o), z                             
            // (28293632, 28293632, array([ True]))
            // 

            var o = np.array(false).reshape(new Shape());
            var z = np.all(np.array(-1, 4, 5), axis: null, @out: o);
            given = (z);
            expected = "array(True)";
            Assert.AreEqual(expected, given.repr);
            Assert.AreEqual(o.Handle, z.Handle);
        }

        [TestMethod]
        public void anyTest()
        {
            // >>> np.any([[True, False], [True, True]])
            // True
            // 

#if TODO
            var given=  np.any({{True, False}, {True, True}});
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> np.any([[True, False], [False, False]], axis=0)
            // array([ True, False])
            // 

#if TODO
             given=  np.any({{True, False}, {False, False}}, axis=0);
             expected=
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> np.any([-1, 0, 5])
            // True
            // 

#if TODO
             given=  np.any({-1, 0, 5});
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> np.any(np.nan)
            // True
            // 

#if TODO
             given=  np.any(np.nan);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> o=np.array([False])
            // >>> z=np.any([-1, 4, 5], out=o)
            // >>> z, o
            // (array([ True]), array([ True]))
            // >>> # Check now that z is a reference to o
            // >>> z is o
            // True
            // >>> id(z), id(o) # identity of z and o              
            // (191614240, 191614240)
            // 

#if TODO
             given=  o=np.array({False});
             given=  z=np.any({-1, 4, 5}, out=o);
             given=  z, o;
             expected=
                "(array([ True]), array([ True]))";
            Assert.AreEqual(expected, given.repr);
             given=  # Check now that z is a reference to o;
             given=  z is o;
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  id(z), id(o) # identity of z and o              ;
             expected=
                "(191614240, 191614240)";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isfiniteTest()
        {
            // >>> np.isfinite(1)
            // True
            // >>> np.isfinite(0)
            // True
            // >>> np.isfinite(np.nan)
            // False
            // >>> np.isfinite(np.inf)
            // False
            // >>> np.isfinite(np.NINF)
            // False
            // >>> np.isfinite([np.log(-1.),1.,np.log(0)])
            // array([False,  True, False])
            // 

#if TODO
            var given=  np.isfinite(1);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfinite(0);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfinite(np.nan);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfinite(np.inf);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfinite(np.NINF);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfinite({np.log(-1.),1.,np.log(0)});
             expected=
                "array([False,  True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.array([-np.inf, 0., np.inf])
            // >>> y = np.array([2, 2, 2])
            // >>> np.isfinite(x, y)
            // array([0, 1, 0])
            // >>> y
            // array([0, 1, 0])
            // 

#if TODO
             given=  x = np.array({-np.inf, 0., np.inf});
             given=  y = np.array({2, 2, 2});
             given=  np.isfinite(x, y);
             expected=
                "array([0, 1, 0])";
            Assert.AreEqual(expected, given.repr);
             given=  y;
             expected=
                "array([0, 1, 0])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isinfTest()
        {
            // >>> np.isinf(np.inf)
            // True
            // >>> np.isinf(np.nan)
            // False
            // >>> np.isinf(np.NINF)
            // True
            // >>> np.isinf([np.inf, -np.inf, 1.0, np.nan])
            // array([ True,  True, False, False])
            // 

#if TODO
            var given=  np.isinf(np.inf);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isinf(np.nan);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isinf(np.NINF);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isinf({np.inf, -np.inf, 1.0, np.nan});
             expected=
                "array([ True,  True, False, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.array([-np.inf, 0., np.inf])
            // >>> y = np.array([2, 2, 2])
            // >>> np.isinf(x, y)
            // array([1, 0, 1])
            // >>> y
            // array([1, 0, 1])
            // 

#if TODO
             given=  x = np.array({-np.inf, 0., np.inf});
             given=  y = np.array({2, 2, 2});
             given=  np.isinf(x, y);
             expected=
                "array([1, 0, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  y;
             expected=
                "array([1, 0, 1])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isnanTest()
        {
            // >>> np.isnan(np.nan)
            // True
            // >>> np.isnan(np.inf)
            // False
            // >>> np.isnan([np.log(-1.),1.,np.log(0)])
            // array([ True, False, False])
            // 

#if TODO
            var given=  np.isnan(np.nan);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isnan(np.inf);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isnan({np.log(-1.),1.,np.log(0)});
             expected=
                "array([ True, False, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isnatTest()
        {
            // >>> np.isnat(np.datetime64("NaT"))
            // True
            // >>> np.isnat(np.datetime64("2016-01-01"))
            // False
            // >>> np.isnat(np.array(["NaT", "2016-01-01"], dtype="datetime64[ns]"))
            // array([ True, False])
            // 

#if TODO
            var given=  np.isnat(np.datetime64("NaT"));
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isnat(np.datetime64("2016-01-01"));
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isnat(np.array({"NaT", "2016-01-01"}, dtype="datetime64{ns}"));
             expected=
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isneginfTest()
        {
            // >>> np.isneginf(np.NINF)
            // array(True, dtype=bool)
            // >>> np.isneginf(np.inf)
            // array(False, dtype=bool)
            // >>> np.isneginf(np.PINF)
            // array(False, dtype=bool)
            // >>> np.isneginf([-np.inf, 0., np.inf])
            // array([ True, False, False])
            // 

#if TODO
            var given=  np.isneginf(np.NINF);
            var expected=
                "array(True, dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isneginf(np.inf);
             expected=
                "array(False, dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isneginf(np.PINF);
             expected=
                "array(False, dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isneginf({-np.inf, 0., np.inf});
             expected=
                "array([ True, False, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.array([-np.inf, 0., np.inf])
            // >>> y = np.array([2, 2, 2])
            // >>> np.isneginf(x, y)
            // array([1, 0, 0])
            // >>> y
            // array([1, 0, 0])
            // 

#if TODO
             given=  x = np.array({-np.inf, 0., np.inf});
             given=  y = np.array({2, 2, 2});
             given=  np.isneginf(x, y);
             expected=
                "array([1, 0, 0])";
            Assert.AreEqual(expected, given.repr);
             given=  y;
             expected=
                "array([1, 0, 0])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isposinfTest()
        {
            // >>> np.isposinf(np.PINF)
            // array(True, dtype=bool)
            // >>> np.isposinf(np.inf)
            // array(True, dtype=bool)
            // >>> np.isposinf(np.NINF)
            // array(False, dtype=bool)
            // >>> np.isposinf([-np.inf, 0., np.inf])
            // array([False, False,  True])
            // 

#if TODO
            var given=  np.isposinf(np.PINF);
            var expected=
                "array(True, dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isposinf(np.inf);
             expected=
                "array(True, dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isposinf(np.NINF);
             expected=
                "array(False, dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isposinf({-np.inf, 0., np.inf});
             expected=
                "array([False, False,  True])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.array([-np.inf, 0., np.inf])
            // >>> y = np.array([2, 2, 2])
            // >>> np.isposinf(x, y)
            // array([0, 0, 1])
            // >>> y
            // array([0, 0, 1])
            // 

#if TODO
             given=  x = np.array({-np.inf, 0., np.inf});
             given=  y = np.array({2, 2, 2});
             given=  np.isposinf(x, y);
             expected=
                "array([0, 0, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  y;
             expected=
                "array([0, 0, 1])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void iscomplexTest()
        {
            // >>> np.iscomplex([1+1j, 1+0j, 4.5, 3, 2, 2j])
            // array([ True, False, False, False, False,  True])
            // 

#if TODO
            var given=  np.iscomplex({1+1j, 1+0j, 4.5, 3, 2, 2j});
            var expected=
                "array([ True, False, False, False, False,  True])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void iscomplexobjTest()
        {
            // >>> np.iscomplexobj(1)
            // False
            // >>> np.iscomplexobj(1+0j)
            // True
            // >>> np.iscomplexobj([3, 1+0j, True])
            // True
            // 

#if TODO
            var given=  np.iscomplexobj(1);
            var expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.iscomplexobj(1+0j);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.iscomplexobj({3, 1+0j, True});
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isfortranTest()
        {
            // np.array allows to specify whether the array is written in C-contiguous
            // order (last index varies the fastest), or FORTRAN-contiguous order in
            // memory (first index varies the fastest).

            // >>> a = np.array([[1, 2, 3], [4, 5, 6]], order='C')
            // >>> a
            // array([[1, 2, 3],
            //        [4, 5, 6]])
            // >>> np.isfortran(a)
            // False
            // 

#if TODO
            var given=  a = np.array({{1, 2, 3}, {4, 5, 6}}, order='C');
             given=  a;
            var expected=
                "array([[1, 2, 3],\n" +
                "       [4, 5, 6]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfortran(a);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> b = np.array([[1, 2, 3], [4, 5, 6]], order='FORTRAN')
            // >>> b
            // array([[1, 2, 3],
            //        [4, 5, 6]])
            // >>> np.isfortran(b)
            // True
            // 

#if TODO
             given=  b = np.array({{1, 2, 3}, {4, 5, 6}}, order='FORTRAN');
             given=  b;
             expected=
                "array([[1, 2, 3],\n" +
                "       [4, 5, 6]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfortran(b);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
            // The transpose of a C-ordered array is a FORTRAN-ordered array.

            // >>> a = np.array([[1, 2, 3], [4, 5, 6]], order='C')
            // >>> a
            // array([[1, 2, 3],
            //        [4, 5, 6]])
            // >>> np.isfortran(a)
            // False
            // >>> b = a.T
            // >>> b
            // array([[1, 4],
            //        [2, 5],
            //        [3, 6]])
            // >>> np.isfortran(b)
            // True
            // 

#if TODO
             given=  a = np.array({{1, 2, 3}, {4, 5, 6}}, order='C');
             given=  a;
             expected=
                "array([[1, 2, 3],\n" +
                "       [4, 5, 6]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfortran(a);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  b = a.T;
             given=  b;
             expected=
                "array([[1, 4],\n" +
                "       [2, 5],\n" +
                "       [3, 6]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isfortran(b);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
            // C-ordered arrays evaluate as False even if they are also FORTRAN-ordered.

            // >>> np.isfortran(np.array([1, 2], order='FORTRAN'))
            // False
            // 

#if TODO
             given=  np.isfortran(np.array({1, 2}, order='FORTRAN'));
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isrealTest()
        {
            // >>> np.isreal([1+1j, 1+0j, 4.5, 3, 2, 2j])
            // array([False,  True,  True,  True,  True, False])
            // 

#if TODO
            var given=  np.isreal({1+1j, 1+0j, 4.5, 3, 2, 2j});
            var expected=
                "array([False,  True,  True,  True,  True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isrealobjTest()
        {
            // >>> np.isrealobj(1)
            // True
            // >>> np.isrealobj(1+0j)
            // False
            // >>> np.isrealobj([3, 1+0j, True])
            // False
            // 

#if TODO
            var given=  np.isrealobj(1);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isrealobj(1+0j);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isrealobj({3, 1+0j, True});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void isscalarTest()
        {
            // >>> np.isscalar(3.1)
            // True
            // >>> np.isscalar(np.array(3.1))
            // False
            // >>> np.isscalar([3.1])
            // False
            // >>> np.isscalar(False)
            // True
            // >>> np.isscalar('numpy')
            // True
            // 

#if TODO
            var given=  np.isscalar(3.1);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isscalar(np.array(3.1));
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isscalar({3.1});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.isscalar(False);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.isscalar('numpy');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
            // NumPy supports PEP 3141 numbers:

            // >>> from fractions import Fraction
            // >>> isscalar(Fraction(5, 17))
            // True
            // >>> from numbers import Number
            // >>> isscalar(Number())
            // True
            // 

#if TODO
             given=  from fractions import Fraction;
             given=  isscalar(Fraction(5, 17));
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  from numbers import Number;
             given=  isscalar(Number());
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void logical_andTest()
        {
            // >>> np.logical_and(True, False)
            // False
            // >>> np.logical_and([True, False], [False, False])
            // array([False, False])
            // 

#if TODO
            var given=  np.logical_and(True, False);
            var expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.logical_and({True, False}, {False, False});
             expected=
                "array([False, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.arange(5)
            // >>> np.logical_and(x>1, x<4)
            // array([False, False,  True,  True, False])
            // 

#if TODO
             given=  x = np.arange(5);
             given=  np.logical_and(x>1, x<4);
             expected=
                "array([False, False,  True,  True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void logical_orTest()
        {
            // >>> np.logical_or(True, False)
            // True
            // >>> np.logical_or([True, False], [False, False])
            // array([ True, False])
            // 

#if TODO
            var given=  np.logical_or(True, False);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.logical_or({True, False}, {False, False});
             expected=
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.arange(5)
            // >>> np.logical_or(x < 1, x > 3)
            // array([ True, False, False, False,  True])
            // 

#if TODO
             given=  x = np.arange(5);
             given=  np.logical_or(x < 1, x > 3);
             expected=
                "array([ True, False, False, False,  True])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void logical_notTest()
        {
            // >>> np.logical_not(3)
            // False
            // >>> np.logical_not([True, False, 0, 1])
            // array([False,  True,  True, False])
            // 

#if TODO
            var given=  np.logical_not(3);
            var expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.logical_not({True, False, 0, 1});
             expected=
                "array([False,  True,  True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.arange(5)
            // >>> np.logical_not(x<3)
            // array([False, False, False,  True,  True])
            // 

#if TODO
             given=  x = np.arange(5);
             given=  np.logical_not(x<3);
             expected=
                "array([False, False, False,  True,  True])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void logical_xorTest()
        {
            // >>> np.logical_xor(True, False)
            // True
            // >>> np.logical_xor([True, True, False, False], [True, False, True, False])
            // array([False,  True,  True, False])
            // 

#if TODO
            var given=  np.logical_xor(True, False);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.logical_xor({True, True, False, False}, {True, False, True, False});
             expected=
                "array([False,  True,  True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> x = np.arange(5)
            // >>> np.logical_xor(x < 1, x > 3)
            // array([ True, False, False, False,  True])
            // 

#if TODO
             given=  x = np.arange(5);
             given=  np.logical_xor(x < 1, x > 3);
             expected=
                "array([ True, False, False, False,  True])";
            Assert.AreEqual(expected, given.repr);
#endif
            // Simple example showing support of broadcasting

            // >>> np.logical_xor(0, np.eye(2))
            // array([[ True, False],
            //        [False,  True]])
            // 

#if TODO
             given=  np.logical_xor(0, np.eye(2));
             expected=
                "array([[ True, False],\n" +
                "       [False,  True]])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void allcloseTest()
        {
            // >>> np.allclose([1e10,1e-7], [1.00001e10,1e-8])
            // False
            // >>> np.allclose([1e10,1e-8], [1.00001e10,1e-9])
            // True
            // >>> np.allclose([1e10,1e-8], [1.0001e10,1e-9])
            // False
            // >>> np.allclose([1.0, np.nan], [1.0, np.nan])
            // False
            // >>> np.allclose([1.0, np.nan], [1.0, np.nan], equal_nan=True)
            // True
            // 

#if TODO
            var given=  np.allclose({1e10,1e-7}, {1.00001e10,1e-8});
            var expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.allclose({1e10,1e-8}, {1.00001e10,1e-9});
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.allclose({1e10,1e-8}, {1.0001e10,1e-9});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.allclose({1.0, np.nan}, {1.0, np.nan});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.allclose({1.0, np.nan}, {1.0, np.nan}, equal_nan=True);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void iscloseTest()
        {
            // >>> np.isclose([1e10,1e-7], [1.00001e10,1e-8])
            // array([True, False])
            // >>> np.isclose([1e10,1e-8], [1.00001e10,1e-9])
            // array([True, True])
            // >>> np.isclose([1e10,1e-8], [1.0001e10,1e-9])
            // array([False, True])
            // >>> np.isclose([1.0, np.nan], [1.0, np.nan])
            // array([True, False])
            // >>> np.isclose([1.0, np.nan], [1.0, np.nan], equal_nan=True)
            // array([True, True])
            // >>> np.isclose([1e-8, 1e-7], [0.0, 0.0])
            // array([ True, False], dtype=bool)
            // >>> np.isclose([1e-100, 1e-7], [0.0, 0.0], atol=0.0)
            // array([False, False], dtype=bool)
            // >>> np.isclose([1e-10, 1e-10], [1e-20, 0.0])
            // array([ True,  True], dtype=bool)
            // >>> np.isclose([1e-10, 1e-10], [1e-20, 0.999999e-10], atol=0.0)
            // array([False,  True], dtype=bool)
            // 

#if TODO
            var given=  np.isclose({1e10,1e-7}, {1.00001e10,1e-8});
            var expected=
                "array([True, False])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1e10,1e-8}, {1.00001e10,1e-9});
             expected=
                "array([True, True])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1e10,1e-8}, {1.0001e10,1e-9});
             expected=
                "array([False, True])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1.0, np.nan}, {1.0, np.nan});
             expected=
                "array([True, False])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1.0, np.nan}, {1.0, np.nan}, equal_nan=True);
             expected=
                "array([True, True])";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1e-8, 1e-7}, {0.0, 0.0});
             expected=
                "array([ True, False], dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1e-100, 1e-7}, {0.0, 0.0}, atol=0.0);
             expected=
                "array([False, False], dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1e-10, 1e-10}, {1e-20, 0.0});
             expected=
                "array([ True,  True], dtype=bool)";
            Assert.AreEqual(expected, given.repr);
             given=  np.isclose({1e-10, 1e-10}, {1e-20, 0.999999e-10}, atol=0.0);
             expected=
                "array([False,  True], dtype=bool)";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void array_equalTest()
        {
            // >>> np.array_equal([1, 2], [1, 2])
            // True
            // >>> np.array_equal(np.array([1, 2]), np.array([1, 2]))
            // True
            // >>> np.array_equal([1, 2], [1, 2, 3])
            // False
            // >>> np.array_equal([1, 2], [1, 4])
            // False
            // 

#if TODO
            var given=  np.array_equal({1, 2}, {1, 2});
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_equal(np.array({1, 2}), np.array({1, 2}));
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_equal({1, 2}, {1, 2, 3});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_equal({1, 2}, {1, 4});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void array_equivTest()
        {
            // >>> np.array_equiv([1, 2], [1, 2])
            // True
            // >>> np.array_equiv([1, 2], [1, 3])
            // False
            // 

#if TODO
            var given=  np.array_equiv({1, 2}, {1, 2});
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_equiv({1, 2}, {1, 3});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
            // Showing the shape equivalence:

            // >>> np.array_equiv([1, 2], [[1, 2], [1, 2]])
            // True
            // >>> np.array_equiv([1, 2], [[1, 2, 1, 2], [1, 2, 1, 2]])
            // False
            // 

#if TODO
             given=  np.array_equiv({1, 2}, {{1, 2}, {1, 2}});
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.array_equiv({1, 2}, {{1, 2, 1, 2}, {1, 2, 1, 2}});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
            // >>> np.array_equiv([1, 2], [[1, 2], [1, 3]])
            // False
            // 

#if TODO
             given=  np.array_equiv({1, 2}, {{1, 2}, {1, 3}});
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void greaterTest()
        {
            // >>> np.greater([4,2],[2,2])
            // array([ True, False])
            // 

#if TODO
            var given=  np.greater({4,2},{2,2});
            var expected=
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // If the inputs are ndarrays, then np.greater is equivalent to ‘>’.

            // >>> a = np.array([4,2])
            // >>> b = np.array([2,2])
            // >>> a > b
            // array([ True, False])
            // 

#if TODO
             given=  a = np.array({4,2});
             given=  b = np.array({2,2});
             given=  a > b;
             expected=
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void greater_equalTest()
        {
            // >>> np.greater_equal([4, 2, 1], [2, 2, 2])
            // array([ True, True, False])
            // 

#if TODO
            var given=  np.greater_equal({4, 2, 1}, {2, 2, 2});
            var expected=
                "array([ True, True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void lessTest()
        {
            // >>> np.less([1, 2], [2, 2])
            // array([ True, False])
            // 

#if TODO
            var given=  np.less({1, 2}, {2, 2});
            var expected=
                "array([ True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void less_equalTest()
        {
            // >>> np.less_equal([4, 2, 1], [2, 2, 2])
            // array([False,  True,  True])
            // 

#if TODO
            var given=  np.less_equal({4, 2, 1}, {2, 2, 2});
            var expected=
                "array([False,  True,  True])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void equalTest()
        {
            // >>> np.equal([0, 1, 3], np.arange(3))
            // array([ True,  True, False])
            // 

#if TODO
            var given=  np.equal({0, 1, 3}, np.arange(3));
            var expected=
                "array([ True,  True, False])";
            Assert.AreEqual(expected, given.repr);
#endif
            // What is compared are values, not types. So an int (1) and an array of
            // length one can evaluate as True:

            // >>> np.equal(1, np.ones(1))
            // array([ True])
            // 

#if TODO
             given=  np.equal(1, np.ones(1));
             expected=
                "array([ True])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void not_equalTest()
        {
            // >>> np.not_equal([1.,2.], [1., 3.])
            // array([False,  True])
            // >>> np.not_equal([1, 2], [[1, 3],[1, 4]])
            // array([[False,  True],
            //        [False,  True]])
            // 

#if TODO
            var given=  np.not_equal({1.,2.}, {1., 3.});
            var expected=
                "array([False,  True])";
            Assert.AreEqual(expected, given.repr);
             given=  np.not_equal({1, 2}, {{1, 3},{1, 4}});
             expected=
                "array([[False,  True],\n" +
                "       [False,  True]])";
            Assert.AreEqual(expected, given.repr);
#endif
        }

    }
}
