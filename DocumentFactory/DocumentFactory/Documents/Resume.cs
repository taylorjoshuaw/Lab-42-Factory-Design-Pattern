using DocumentFactory.Pages;
using DocumentFactory.Pages.Resume;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Documents
{
    /// <summary>
    /// Builds the pages of a resume
    /// </summary>
    public class Resume : Document
    {
        public override string Type => "Resume";

        public override Page MakePage(string type)
        {
            switch (type)
            {
                case nameof(CoverLetter):
                    return new CoverLetter();
                case nameof(Experience):
                    return new Experience();
                case nameof(Education):
                    return new Education();
                case nameof(References):
                    return new References();
                default:
                    return null;
            }
        }
    }
}
