using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    abstract class Stock
    {
        private double price;
        private readonly List<ISalesChannel> salesChannels = new List<ISalesChannel>();

        public string title { get; }
        protected Stock(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public void Attach(ISalesChannel salesChannel)
        {
            salesChannels.Add(salesChannel);
        }

        public void Detach(ISalesChannel salesChannel)
        {
            salesChannels.Remove(salesChannel);
        }

        public void Notify()
        {
            salesChannels.ForEach(x => x.Update(this));
            Console.WriteLine(string.Empty);
        }

        public double Price
        {
            get => price;
            set
            {
                if (Math.Abs(price - value) > 0.0)
                {
                    price = value;
                    Notify();
                }
            }
        }
    }
}
