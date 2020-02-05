using System;

namespace LogAn
{
    public class LogAnalyzer
    {

        private IExtensionManager manager;
        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = ExtensionManagerFactory.Create();
        }
        public bool IsValidLogFileName(string fileName)
        {
            //fileName = fileName.ToUpper();
            //if (string.IsNullOrEmpty(fileName))
            //{
            //    throw new ArgumentException("filename has to be provided");
            //}
            //if (!fileName.EndsWith(".SLF"))
            //{
            //    return false;
            //}
            //return true;

            return manager.IsValid(fileName);
        }
    }
}
