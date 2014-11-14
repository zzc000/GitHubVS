using CsQuery.ExtensionMethods.Internal;

namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// The current selection set will become the only members of the document in this object. This
        /// is a destructive method that will completely replace the document.
        /// </summary>
        ///
        /// <returns>
        /// The current CQ object
        /// </returns>

        public CQ MakeRoot()
        {
            Document.ChildNodes.Clear();
            Document.ChildNodes.AddRange(Elements);
            return this;
        }

        /// <summary>
        /// The elements identified by the selector will become the only members of the document in this
        /// object. This is a destructive method that will completely replace the document.
        /// </summary>
        ///
        /// <param name="selector">
        /// A selector that determines which elements will become the new document.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object
        /// </returns>

        public CQ MakeRoot(string selector)
        {
            return Select(selector).MakeRoot();
        }
    }
}
