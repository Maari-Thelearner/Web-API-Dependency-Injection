using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService
{
    public interface ICompanyInfoForScoped
    {
        string CompanyName { get; set; }

        string Place { get; set; }

        string ContactNumber { get; set; }

        int CompanyRefNo { get; set; }

        int GetNumber();

    }
}
