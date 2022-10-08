using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class PageTypeGroup : List<PageModel>
    {
        public string Title { get; set; }
        public string ShortName { get; set; } //will be used for jump lists
        public string Subtitle { get; set; }
        public PageTypeGroup(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }

        public static IList<PageTypeGroup> All { private set; get; }

        static PageTypeGroup()
        {
            List<PageTypeGroup> Groups = new List<PageTypeGroup> {
            new PageTypeGroup ("Alpha", "A"){
                new PageModel("Amelia", "Cedar"),
                new PageModel("Alfie", "Spruce"),
                new PageModel("Ava", "Pine"),
                new PageModel("Archie", "Maple")
            },
            new PageTypeGroup ("Bravo", "B"){
                new PageModel("Brooke", "Lumia"),
                new PageModel("Bobby", "Xperia"),
                new PageModel("Bella", "Desire"),
                new PageModel("Ben", "Chocolate")
            }
        };
            All = Groups; //set the publicly accessible list
        }
    }
}