using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample1.Models;

namespace Sample1.Controllers
{
    public class ContentController : Controller
    {
        private readonly List<Content> ContentList;
        public ContentController(IOptionsSnapshot<List<Content>> option)
        {
            ContentList = option.Value;
        }
        public IActionResult Index()
        {
            return View(new ContentViewModel() { Contents = ContentList });
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            //new Content().add_time.Humanize();
            //return View(new ContentViewModel { Contents = contents });
        }
        public IActionResult TestLayout()
        {
            return View();
        }

    }
}