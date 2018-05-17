using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Report
{
    /// <summary>
    /// Represents the references / works cited page of an APA report
    /// </summary>
    public class WorksCited : Page
    {
        public override string Type => "Works Cited";

        public override string Content { get; protected set; } = @"
    COLD FUSION                                                               4

    References

    Taylor, J. (2018, May 16). Cold Fusion: It's pretty cool.
        Retrieved 16 May, 2018 from https://www.youtube.com/watch?v=oHg5SJYRHA0";
    }
}
