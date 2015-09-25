using System.Linq;
using Orchard.ContentManagement.Drivers;
using Cascade.Blurb.Models;
using Orchard.Data;

namespace Cascade.Blurb.Drivers
{
    public class BlurbWidgetDriver : ContentPartDriver<BlurbWidgetPart>
    {

        protected override DriverResult Display(BlurbWidgetPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_BlurbWidget", () => shapeHelper.Parts_BlurbWidget());
        }
    }
}