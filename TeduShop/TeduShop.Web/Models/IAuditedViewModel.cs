using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Web.Models
{
    interface IAuditedViewModel
    {
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        bool Status { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}
