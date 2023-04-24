using System;


namespace R5T.T0178
{
    /// <summary>
    /// Marker interface for interfaces that are strong-types.
    /// (A strong-type is a wrapper around another .NET type, usually one of the C# primitive types. For example, it's not a string, it's a file path, or an AWS S3 bucket name.)
    /// (Strong-types are also always interfaces, although they can have implementations.)
    /// Allows extension methods-for (or if defined here, methods-on) all strong-types.
    /// </summary>
    public interface IStrongTypeMarker
    {
    }
}
