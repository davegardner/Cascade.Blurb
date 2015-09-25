using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Cascade.Blurb.Models;
using Orchard.Tags.Models;
using Orchard;
using Orchard.Mvc;
using Orchard.Themes;
using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Tags.Services;

namespace Cascade.Blurb.Controllers
{
    public class BlurbWidgetController : Controller
    {
        private readonly IContentManager _cm;
        private readonly ITagService _tagService;

        public BlurbWidgetController(IContentManager cm, ITagService tagService)
        {
            _cm = cm;
            _tagService = tagService;
        }

        public ActionResult GetItems(string selector)
        {
            string text = string.Empty;
            var tag = _tagService.GetTagByName(selector);
            if (tag != null)
            {
                var items = _tagService.GetTaggedContentItems(tag.Id);
                if (items != null && items.Count() > 0)
                {
                    var item = items.FirstOrDefault(b=>b.ContentItem.ContentType == "Blurb");
                    if (item != null)
                    {
                        var blurb = item.As<BodyPart>();
                        text = blurb.Text;
                    }
                }
            }
            return Content(text);
        }
    }
}