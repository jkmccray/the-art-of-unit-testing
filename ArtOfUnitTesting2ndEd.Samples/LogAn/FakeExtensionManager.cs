﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
    public class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;
        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }

    }
}
