
namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// Remove all child nodes of the set of matched elements from the DOM.
        /// </summary>
        ///
        /// <returns>
        /// The current CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/empty/
        /// </url>

        public CQ Empty()
        {

            return Each((IDomObject e) =>
            {
                if (e.HasChildren)
                {
                    e.ChildNodes.Clear();
                }
            });
        }

        

    }
}
