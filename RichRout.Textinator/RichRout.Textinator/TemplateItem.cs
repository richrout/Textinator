using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RichRout.Textinator
{
    public class TemplateItem
    {
        public TemplateItem()
        {
            Id = Guid.NewGuid();
        }

        [PrimaryKey]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Contact { get; set; }
        public string Message { get; set; }
    }
}
