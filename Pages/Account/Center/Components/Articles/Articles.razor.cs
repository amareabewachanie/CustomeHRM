using System.Collections.Generic;
using MyHRM.Models;
using Microsoft.AspNetCore.Components;

namespace MyHRM.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}