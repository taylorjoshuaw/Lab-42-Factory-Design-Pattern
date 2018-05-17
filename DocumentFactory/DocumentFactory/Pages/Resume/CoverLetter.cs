using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Resume
{
    /// <summary>
    /// Represents the cover letter of a resume
    /// </summary>
    public class CoverLetter : Page
    {
        public override string Type => "Cover Letter";
        public override string Content { get; protected set; } = @"
    Dear Employer,

    I am the awesomest person. You should hire me. I will add so much
    value to the value chain. Synergy. Collaboration. <insert SEO terms
    and buzzwords here>

    Sincerely,
    Your future employee";
    }
}
