using System.Collections.Generic;

namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// Replace the target, which is the result of the selector passed, with the set of matched
        /// elements.
        /// </summary>
        ///
        /// <param name="selector">
        /// A selector expression indicating which element(s) to replace.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/replaceAll/
        /// </url>

        public CQ ReplaceAll(string selector)
        {
            return ReplaceAll(Select(selector));
        }

        /// <summary>
        /// Replace the target element with the set of matched elements.
        /// </summary>
        ///
        /// <param name="target">
        /// An element.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/replaceAll/
        /// </url>

        public CQ ReplaceAll(IDomObject target)
        {
            return ReplaceAll(Objects.Enumerate(target));
        }

        /// <summary>
        /// Replace each target element with the set of matched elements.
        /// </summary>
        ///
        /// <param name="targets">
        /// The targets to be replaced.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object.
        /// </returns>
        ///
        /// <url>
        /// http://api.jquery.com/replaceAll/
        /// </url>

        public CQ ReplaceAll(IEnumerable<IDomObject> targets)
        {
            return EnsureCsQuery(targets).ReplaceWith(SelectionSet);
        }
        

    }
}
