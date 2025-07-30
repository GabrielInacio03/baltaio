using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url): base(title, url)
        {
            this.Items = new List<CareerIem>();
        }
        public IList<CareerIem> Items { get; set; }
        public int TotalCourses => Items.Count; //expression body
        
        
    }
    
}