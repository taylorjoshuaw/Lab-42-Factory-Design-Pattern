using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages
{
    /// <summary>
    /// Represents a single page of a document
    /// </summary>
    public abstract class Page
    {
        /// <summary>
        /// Human friendly representation of the page's type ("Cover Letter", "References", etc.)
        /// </summary>
        public abstract string Type { get; }
        /// <summary>
        /// The body of the page
        /// </summary>
        public abstract string Content { get; protected set; }

        /// <summary>
        /// Converts the page to a string by its Type and Content properties
        /// </summary>
        /// <returns>String representation of the page using its type and content
        /// properties</returns>
        public override string ToString() => $"Page Name:\n    {Type}\nContent:\t{Content}";
    }
}
