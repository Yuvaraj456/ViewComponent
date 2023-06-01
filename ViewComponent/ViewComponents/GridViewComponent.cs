using Microsoft.AspNetCore.Mvc;
using ViewComponentEx.Models;

namespace ViewComponentEx.ViewComponents
{
    public class GridViewComponent : ViewComponent

    {
       public async Task  <IViewComponentResult> InvokeAsync(PersonGridModel grid)
        {
           
            //ViewData["grid"] = model;
            return View("Sample", grid); //invokes a partial view, Shared/Components/Grid/Default.cshtml
        }
    }
    
}
