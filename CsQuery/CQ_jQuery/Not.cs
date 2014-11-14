using CsQuery.Engine;
using System.Collections.Generic;

namespace CsQuery
{
    public partial class CQ
    {

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        ///
        /// <param name="selector">
        /// A CSS selector.
        /// </param>
        ///
        /// <returns>
        /// A new CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/not/
        /// </url>

        public CQ Not(string selector)
        {
            var subSelector = new Selector(selector);
            var notList = subSelector.ToFilterSelector().Select(Document,Selection);

            return Not(notList);
        }

        /// <summary>
        /// Selects all elements except the element passed as a parameter.
        /// </summary>
        ///
        /// <param name="element">
        /// The element to exclude.
        /// </param>
        ///
        /// <returns>
        /// A new CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/not/
        /// </url>

        public CQ Not(IDomObject element)
        {
            return Not(Objects.Enumerate(element));
        }

        /// <summary>
        /// Selects all elements except those passed as a parameter.
        /// </summary>
        ///
        /// <param name="elements">
        /// The elements to be excluded.
        /// </param>
        ///
        /// <returns>
        /// A new CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/not/
        /// </url>

        public CQ Not(IEnumerable<IDomObject> elements)
        {
            CQ csq = NewInstance(SelectionSet);
            csq.SelectionSet.ExceptWith(elements);
            csq.Selector = Selector;
            return csq;
        }

    }
}
