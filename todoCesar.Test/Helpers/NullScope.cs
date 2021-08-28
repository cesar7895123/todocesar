using System;

namespace todoCesar.Test.Helpers
{
    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; set; }
        public void Dispose() { }

        private NullScope() { }
    }
}
