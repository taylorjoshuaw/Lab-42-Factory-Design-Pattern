using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Resume
{
    /// <summary>
    /// Lists the educational accomplishments on a resume
    /// </summary>
    public class Education : Page
    {
        public override string Type => "Educational History";
        public override string Content { get; protected set; } = @"
    Read Good Certificate (Advanced Level) - 2018
    Derek Zoolander School for Kids Who Can't Read Good

    Ph.D of Juggling - 53 B.C.
    Me Juggle Like Champ Institute";
    }
}
