using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsach_pochta
{
    public class Package
    {
        public int Id { get; set; }
        public DateTime AcceptDate { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public string Type { get; set; }
        public decimal Weight { get; set; }
        public decimal DeclaredValue { get; set; }
        public decimal DeliveryCost { get; set; }
        public string TrackNumber { get; set; }
    }
}
