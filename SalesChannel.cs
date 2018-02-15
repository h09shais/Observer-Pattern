using System;

namespace ObserverPattern
{
    class SalesChannel : ISalesChannel
    {
        private string name;

        public SalesChannel(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0}: {1} has changed to {2:C}", name, stock.title, stock.Price);
        }

        public Stock Stock { get; set; }
    }
}
