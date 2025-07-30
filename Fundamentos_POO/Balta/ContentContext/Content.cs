using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            this.Title = title;
            this.Url = url;
        }
        
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}