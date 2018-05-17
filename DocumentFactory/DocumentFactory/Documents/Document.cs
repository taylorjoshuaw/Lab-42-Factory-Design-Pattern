using System;
using System.Collections.Generic;
using System.Text;
using DocumentFactory.Pages;

namespace DocumentFactory.Documents
{
    /// <summary>
    /// Represents a document which can build pages relevant to that
    /// document (works cited, abstract, etc. for an APA report or
    /// cover letter, educational accomplishments, etc. for a resume)
    /// </summary>
    public abstract class Document
    {
        /// <summary>
        /// Human readable representation of the type of document
        /// </summary>
        public abstract string Type { get; }

        /// <summary>
        /// Factory method which returns new instances of objects based
        /// on the string being passed in as input
        /// </summary>
        /// <param name="type">The type of object to instantiate as
        /// a string</param>
        /// <returns>New object instance for the requested type as
        /// provided in string format</returns>
        public abstract Page MakePage(string type);
    }
}
