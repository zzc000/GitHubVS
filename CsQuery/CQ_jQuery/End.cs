
namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// End the most recent filtering operation in the current chain and return the set of matched
        /// elements to its previous state.
        /// </summary>
        ///
        /// <returns>
        /// The CQ object at the root of the current chain, or a new, empty selection if this CQ object
        /// is the direct result of a Create()
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/end/
        /// </url>

        public CQ End()
        {
            return CsQueryParent ?? NewCqInDomain();
        }
        

    }
}
