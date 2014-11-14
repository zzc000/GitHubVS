using System.Collections.Generic;

namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// Get the children of each element in the set of matched elements, including text and comment
        /// nodes.
        /// </summary>
        ///
        /// <returns>
        /// A new CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/contents/
        /// </url>

        public CQ Contents()
        {

            List<IDomObject> list = new List<IDomObject>();
            foreach (IDomObject obj in SelectionSet)
            {
                if (obj is IDomContainer)
                {
                    list.AddRange(obj.ChildNodes);
                }
            }

            return NewInstance(list, this);
        }

        

    }
}
