using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class Appearance
    {
        Stock stock = null;
        NationalDebt nationalDebt = null;
        Realty realty = null;

        public Appearance()
        {
            stock = new Stock("股票");
            nationalDebt = new NationalDebt("国债");
            realty = new Realty("房地产");
        }

        public void Buy()
        {
            stock.Buy();
            nationalDebt.Buy();
            realty.Buy();
        }

        public void Sell()
        {
            stock.Sell();
            nationalDebt.Sell();
            realty.Sell();
        }
    }
}
