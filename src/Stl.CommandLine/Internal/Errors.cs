using System;

namespace Stl.CommandLine.Internal
{
    public static class Errors
    {
        public static Exception MissingCliArgument(string template) =>
            new ArgumentException($"Required argument with template '{template ?? "(unknown)"}' is missing.");
        public static Exception UnsupportedFormatString(string format) =>
            new ArgumentException("Unsupported format string: '{0}'.");
    }
}
