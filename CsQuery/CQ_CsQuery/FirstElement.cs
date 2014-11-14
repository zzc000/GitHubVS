using System.Collections;
using System.Collections.Generic;

namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// The first IDomElement (e.g. not text/special nodes) in the selection set, or null if none
        /// exists.
        /// </summary>
        ///
        /// <returns>
        /// An IDomElement object.
        /// </returns>

        public IDomElement FirstElement()
        {

            using (IEnumerator<IDomElement> sequence = Elements.GetEnumerator())
            {
                if (sequence.MoveNext())
                {
                    return sequence.Current;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
