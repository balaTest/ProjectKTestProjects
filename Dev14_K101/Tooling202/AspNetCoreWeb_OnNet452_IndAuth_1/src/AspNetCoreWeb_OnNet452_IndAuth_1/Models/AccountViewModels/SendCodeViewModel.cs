using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreWeb_OnNet452_IndAuth_1.Models.AccountViewModels
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}
