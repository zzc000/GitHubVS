using System.Collections.Generic;

namespace CsQuery
{
    public partial class CQ
    {

        /// <summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by
        /// a selector.
        /// </summary>
        ///
        /// <param name="selector">
        /// A string containing a selector expression to match elements against.
        /// </param>
        ///
        /// <returns>
        /// A new CQ object
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/parents/
        /// </url>

        public CQ Parent(string selector = null)
        {
            return FilterIfSelector(selector, MapRangeToNewCQ(Selection, ParentImpl));
        }


        private IEnumerable<IDomObject> ParentImpl(IDomObject input)
        {
            if (input.ParentNode != null &&
                input.ParentNode.NodeType == NodeType.ELEMENT_NODE)
            {
                yield return input.ParentNode;
            }
        }

    }
}
