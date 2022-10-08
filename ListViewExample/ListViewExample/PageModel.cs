using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class PageModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public PageModel(string title, string subtitle)
        {
            Title = title;
            Subtitle = subtitle;
        }
    }
}