using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichRout.Textinator
{
    public class EditTemplateModel
    {
        public EditTemplateModel()
        {
            Contact = "Bob";
        }

        public string Name { get; set; }
        public string Contact { get; set; }
        public string Message { get; set; }
    }
}
