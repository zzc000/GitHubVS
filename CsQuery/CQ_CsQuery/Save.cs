using System.IO;

namespace CsQuery
{
    public partial class CQ
    {
        /// <summary>
        /// Save the current Document to an HTML file.
        /// </summary>
        ///
        /// <returns>
        /// A new CQ object.
        /// </returns>

        public void Save(string fileName, DomRenderingOptions renderingOptions=DomRenderingOptions.Default)
        {
            File.WriteAllText(fileName, Render(renderingOptions));
        }
    }
}
