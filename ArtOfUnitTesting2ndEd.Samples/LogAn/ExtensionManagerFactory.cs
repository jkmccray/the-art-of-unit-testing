using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
    public class ExtensionManagerFactory
    {
        private IExtensionManager customManager = null;
        public IExtensionManager Create()
        {
            if (customManager != null)
            {
                return customManager;
            }
            return new FakeExtensionManager();
        }
        public void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }
    }
}
