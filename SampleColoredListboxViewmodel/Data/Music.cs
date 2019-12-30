using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleColoredListboxViewmodel.Data
{
    /// <summary>
    /// Simple data model to be shown in the UI
    /// </summary>
    public class Music
    {
        /// <summary>
        /// Gets the title to be shown
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// If this property is try it will be highlighted in the UI.
        /// </summary>
        public bool IsSpecial { get; set; }
    }
}
