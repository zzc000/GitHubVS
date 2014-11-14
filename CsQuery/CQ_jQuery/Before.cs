using System.Collections.Generic;

namespace CsQuery
{
    public partial class CQ
    {

        /// <summary>
        /// Insert content, specified by the parameter, before each element in the set of matched
        /// elements.
        /// </summary>
        ///
        /// <param name="selector">
        /// A CSS selector that determines the elements to insert.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/before/
        /// </url>

        public CQ Before(string selector)
        {
            return Before(Select(selector));
        }

        /// <summary>
        /// Insert the element, specified by the parameter, before each element in the set of matched
        /// elements.
        /// </summary>
        ///
        /// <param name="element">
        /// The element to insert.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/before/
        /// </url>

        public CQ Before(IDomObject element)
        {
            return Before(Objects.Enumerate(element));
        }

        /// <summary>
        /// Insert each element, specified by the parameter, before each element in the set of matched
        /// elements.
        /// </summary>
        ///
        /// <param name="elements">
        /// The elements to insert.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/before/
        /// </url>

        public CQ Before(IEnumerable<IDomObject> elements)
        {
            return EnsureCsQuery(elements).InsertAtOffset(this, 0);
        }

    }
}
