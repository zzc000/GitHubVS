
namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// Return the current assembly's version.
        /// </summary>
        ///
        /// <returns>
        /// A string
        /// </returns>

        public static string Version()
        {
            return typeof(CQ).Assembly.GetName().Version.ToString();
        }
    }
}
