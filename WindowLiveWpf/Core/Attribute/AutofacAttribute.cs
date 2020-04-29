using System;

namespace Live.Client.Core
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AutofacAttribute : Attribute
    {
        public AutofacAttribute(bool allow)
        {
            _allow = allow;
        }

        private bool _allow;

        public bool Allow { get { return _allow; } }
    }
}
