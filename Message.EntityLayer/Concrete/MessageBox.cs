using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.EntityLayer.Concrete
{
    public class MessageBox
    {
        public int MessageBoxId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string ImageUrl { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public string MessageImageUrl { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
