using System;

using R5T.T0143;


namespace R5T.T0178
{
    /// <summary>
    /// Attribute indicating a type is a draft strong-type.
    /// A draft strong-type is a quickly created type that should be reviewed and relocated, and thus become a regular, non-draft strong-type.
    /// The marker attribute is useful for surveying for draft strong-types and building a catalogue of them as a kind of TODO list.
    /// The marker attribute can only be used on interfaces, since strong types should be interfaces. (Implementations of strong types have their own attribute.)
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftStrongTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zDraftIsStrongType;

        /// <summary>
        /// Allows specifying that a type is *not* a draft strong-type.
        /// This is useful for marking interfaces that end up canonical draft strong-type code file locations, but are not draft strong-types.
        /// </summary>
        public bool IsDraftStrongType
        {
            get
            {
                return this.zDraftIsStrongType;
            }
        }


        public DraftStrongTypeMarkerAttribute(
            bool isDraftStrongType = true)
        {
            this.zDraftIsStrongType = isDraftStrongType;
        }
    }
}
