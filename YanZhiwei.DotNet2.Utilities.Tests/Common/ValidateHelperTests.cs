﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YanZhiwei.DotNet2.Utilities.Common;

namespace YanZhiwei.DotNet2.Utilities.DataOperator.Tests
{
    [TestClass()]
    public class ValidateHelperTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InRangeTest()
        {
            ValidateHelper.Begin().InRange(2, 3, 8, "2");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNumberTest()
        {
            ValidateHelper.Begin().IsNumber("yanzhiwei", "不是数字.");
        }
    }
}