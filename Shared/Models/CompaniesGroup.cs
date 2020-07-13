using System;
using System.Collections.Generic;
using System.Text;
using ThreeFourteen.Finnhub.Client.Model;

namespace FinService.Shared.Models
{
    public class CompaniesGroup
    {
        public IEnumerable<Symbol> Symbols { get; set; }
        public string FirstLetter { get; set; }

    }
}
