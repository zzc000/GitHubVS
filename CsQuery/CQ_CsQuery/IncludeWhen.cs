
namespace CsQuery
{
    public partial class CQ
    {


        /// <summary>
        /// Conditionally includes a selection. This is the equivalent of calling Remove() only when
        /// "include" is false.
        /// </summary>
        ///
        /// <param name="include">
        /// true to include, false to exclude.
        /// </param>
        ///
        /// <returns>
        /// The current CQ object
        /// </returns>

        public CQ IncludeWhen(bool include)
        {
            if (!include)
            {
                Remove();
            }
            return this;
        }
    }
}
