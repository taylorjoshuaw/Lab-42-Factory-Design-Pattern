using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Report
{
    /// <summary>
    /// Represents the body of an APA report
    /// </summary>
    public class Body : Page
    {
        public override string Type => "Report Body";

        public override string Content { get; protected set; } = @"
    COLD FUSION                                                               3

    Something something cold fusion. Something something all the energy.
    Something something dark side.

    In conclusion, cold fusion is pretty cool (Taylor, 2018).";
    }
}
