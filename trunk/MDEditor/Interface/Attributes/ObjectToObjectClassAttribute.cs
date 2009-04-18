using System;
using System.Collections.Generic;
using System.Text;

namespace MDEditor.Interface.Attributes
{
    internal class ObjectToObjectClassAttribute
    {
        public readonly Action ScanMethod;
        public ObjectToObjectClassAttribute()
        {
            ScanMethod = DefaultScan;
        }

        public ObjectToObjectClassAttribute(Action NewScanMethod)
        {
            ScanMethod = NewScanMethod;
        }

        private void DefaultScan()
        {
        }
    }
}
