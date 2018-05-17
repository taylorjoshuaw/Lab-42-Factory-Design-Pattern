using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Resume
{
    /// <summary>
    /// Contains the professional experience on a resume
    /// </summary>
    public class Experience : Page
    {
        public override string Type => "Professional History";
        public override string Content { get; protected set; } = @"
    Code Wizard - Interwebs
    January 2001 - Present
        - Responsible for writing the most elegant code evuh.
        - Removed so many bugs you might want to call me an exterminator (but
          I prefer Code Wizard)

    Backseat Driver - Taylor Family
    July 1988 - Present
        - Volunteered to correct all family members' driving mistakes on the
          road
        - Criticized everyone's music tastes until they turn off their
          stereo in protest";
    }
}
