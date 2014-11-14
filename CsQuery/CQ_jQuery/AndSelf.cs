using CsQuery.ExtensionMethods.Internal;
using CsQuery.Implementation;

namespace CsQuery
{
    public partial class CQ
    {

        /// <summary>
        /// Add the previous set of elements on the stack to the current set.
        /// </summary>
        ///
        /// <returns>
        /// A new CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/andself/
        /// </url>

        public CQ AndSelf()
        {
            var csq = NewInstance(this);
            csq.Order = SelectionSetOrder.Ascending;

            if (CsQueryParent == null)
            {
                return csq;
            }
            else
            {
                csq.SelectionSet.AddRange(CsQueryParent.SelectionSet);
                return csq;
            }
        }
        

    }
}
