using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Base;

namespace GitHubUIAssignment.Context
{
    public class Page
    {
        public BasePage CurrentPage { get; set; }
        public string UserName { get; set; }
    }
}
