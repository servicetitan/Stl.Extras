using System;

namespace Stl.Internal
{
    public static class ExperimentalErrors
    {
        public static Exception QueueSizeMustBeGreaterThanZero(string paramName) =>
            new ArgumentOutOfRangeException(paramName, "Queue size must be > 0.");
        public static Exception BufferLengthMustBeGreaterThanOne(string paramName) =>
            new ArgumentOutOfRangeException(paramName, "Buffer length must be > 1.");
        public static Exception BufferLengthMustBeGreaterThanZero(string paramName) =>
            new ArgumentOutOfRangeException(paramName, "Buffer length must be > 0.");
        public static Exception EnqueueCompleted() =>
            new InvalidOperationException("EnqueueCompleted == true.");
    }
}
