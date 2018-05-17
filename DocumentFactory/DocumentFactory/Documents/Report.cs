using System;
using System.Collections.Generic;
using System.Text;
using DocumentFactory.Pages;
using DocumentFactory.Pages.Report;

namespace DocumentFactory.Documents
{
    /// <summary>
    /// Builds the pages of an APA report
    /// </summary>
    public class Report : Document
    {
        public override string Type => "APA Report";

        public override Page MakePage(string type)
        {
            switch (type)
            {
                case nameof(CoverSheet):
                    return new CoverSheet();
                case nameof(Abstract):
                    return new Abstract();
                case nameof(Body):
                    return new Body();
                case nameof(WorksCited):
                    return new WorksCited();
                default:
                    return null;
            }
        }
    }
}
