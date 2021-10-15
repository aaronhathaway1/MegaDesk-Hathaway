using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hathaway
{
    public enum ShippingSpeed
    {
        Rush3Day,
        Rush5Day,
        Rush7Day,
        NoRush
    }

    class DeskQuote
    {
        public Desk Desk { get; set; }

        public DateTime QuoteDate { get; set; }

        public string CustomerName { get; set; }

        public decimal QuoteAmount { get; set; }

        public ShippingSpeed Shipping { get; set; }
    }
}
