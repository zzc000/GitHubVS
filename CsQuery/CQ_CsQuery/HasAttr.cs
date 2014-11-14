
namespace CsQuery
{
    public partial class CQ
    {

        /// <summary>
        /// Test for the existence of an attribute.
        /// </summary>
        ///
        /// <param name="name">
        /// The name of the attribute to get.
        /// </param>
        ///
        /// <returns>
        /// A string of the attribute value, or null if the attribute does not exist.
        /// </returns>
        
        public bool HasAttr(string name)
        {
            if (Length > 0 && !string.IsNullOrEmpty(name))
            {
                return this[0].HasAttribute(name);
            }
            return false;
        }
        
    }
}
