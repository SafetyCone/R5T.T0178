using System;

using R5T.T0143;


namespace R5T.T0178
{
    /// <summary>
    /// Attribute indicating a type is a draft strong-type implementation.
    /// A draft strong-type implementation is a quickly created type that should be reviewed and relocated, and thus become a regular, non-draft strong-type implementation.
    /// The marker attribute is useful for surveying for draft strong-types and building a catalogue of them as a kind of TODO list.
    /// The marker attribute can only be used on classes (not structs), since strong types implemenations should be classes.
    /// (Strong-types instances should be used as interfaces, so there will be boxing whenever a struct strong-type instance is used, negating the benefits of using a struct!)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftStrongTypeImplementationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zDraftIsStrongTypeImplementation;

        /// <summary>
        /// Allows specifying that a type is *not* a draft strong-type implementation.
        /// This is useful for marking interfaces that end up canonical draft strong-type implementation code file locations, but are not draft strong-type implementations.
        /// </summary>
        public bool IsDraftStrongTypeImplementation
        {
            get
            {
                return this.zDraftIsStrongTypeImplementation;
            }
        }


        public DraftStrongTypeImplementationMarkerAttribute(
            bool isDraftStrongTypeImplementation = true)
        {
            this.zDraftIsStrongTypeImplementation = isDraftStrongTypeImplementation;
        }
    }
}
