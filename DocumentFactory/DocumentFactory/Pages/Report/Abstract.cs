using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory.Pages.Report
{
    /// <summary>
    /// Represents the abstract page of an APA report
    /// </summary>
    public class Abstract : Page
    {
        public override string Type => "Abstract";

        public override string Content { get; protected set; } = @"
    COLD FUSION                                                               2

                                   Abstract

    Cold fusion is a very simple energy generation method that totally works 
    and can be created using two soda cans, a flux capacitor, and exactly one
    plumbus. This report will explain how these components work in conjunction
    with perpetual motion machines to make the world a better place.

        Keywords: cold fusion, energy, power, plumbus, science";
    }
}
