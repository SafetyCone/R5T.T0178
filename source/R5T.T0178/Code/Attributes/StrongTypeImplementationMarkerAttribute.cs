using System;

using R5T.T0143;


namespace R5T.T0178
{
    /// <summary>
    /// Attribute indicating a class is a strong-type implementation.
    /// A strong-type implementation is a class that implements one (or more) strong-type interfaces.
    /// The marker attribute is useful for surveying code for strong-type implementations then building a catalogue.
    /// The marker attribute can only be used on classes (not structs), since strong types implemenations should be classes.
    /// (Strong-types instances should be used as interfaces, so there will be boxing whenever a struct strong-type instance is used, negating the benefits of using a struct!)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class StrongTypeImplementationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsStrongTypeImplementation;

        /// <summary>
        /// Allows specifying that a type is *not* a strong-type implementation.
        /// This is useful for marking interfaces that end up in canonical strong-type implementation code file locations, but are not strong-type implementations.
        /// </summary>
        public bool IsStrongTypeImplementation
        {
            get
            {
                return this.zIsStrongTypeImplementation;
            }
        }


        public StrongTypeImplementationMarkerAttribute(
            bool isStrongTypeImplementation = true)
        {
            this.zIsStrongTypeImplementation = isStrongTypeImplementation;
        }
    }
}
