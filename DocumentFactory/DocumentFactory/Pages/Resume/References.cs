using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Resume
{
    /// <summary>
    /// Represents the professional references on a resume
    /// </summary>
    public class References : Page
    {
        public override string Type => "References";
        public override string Content { get; protected set; } = @"
    Barack Obama - Former President
        Phone: 555-555-5555

    Zeus - Sky and Thunder God
        Note: Ask Hera for Contact Info";
    }
}
