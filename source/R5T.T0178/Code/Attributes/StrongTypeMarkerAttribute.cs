using System;

using R5T.T0143;


namespace R5T.T0178
{
    /// <summary>
    /// Attribute indicating a interface is a strong-type. (A strongly-typed wrapper around another type, usually a C# language built in type.
    /// For example, it's not a string, it's an AWS S3 Bucket Name.)
    /// The marker attribute is useful for surveying code for strong-types then building a catalogue.
    /// The marker attribute can only be used on interfaces, since strong types should be interfaces. (Implementations of strong types have their own attribute.)
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class StrongTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsStrongType;

        /// <summary>
        /// Allows specifying that a type is *not* a strong type.
        /// This is useful for marking interfaces that end up in canonical strong-type code file locations, but are not strong-types.
        /// </summary>
        public bool IsStrongType
        {
            get
            {
                return this.zIsStrongType;
            }
        }


        public StrongTypeMarkerAttribute(
            bool isStrongType = true)
        {
            this.zIsStrongType = isStrongType;
        }
    }
}
