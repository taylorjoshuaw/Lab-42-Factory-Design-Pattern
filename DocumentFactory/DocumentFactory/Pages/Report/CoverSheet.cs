using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Report
{
    /// <summary>
    /// Represents the cover sheet of an APA report
    /// </summary>
    public class CoverSheet : Page
    {
        public override string Type => "Cover Sheet";

        public override string Content { get; protected set; } = @"
    Running head: COLD FUSION                                                 1






                                  Cold Fusion
                                Joshua W. Taylor
                                 Code Fellows







";
    }
}
