using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class InvoiceModel
    {
        public string Number { get; set; }
        public CompanyModel Seller { get; set; }
        public CompanyModel Buyer { get; set; }
        public IEnumerable<ItemModel> Items { get; set; }

        public static InvoiceModel Example()
        {
            return new InvoiceModel()
            {
                Number = "123",
                Seller = new CompanyModel()
                {
                    Name = "Next Step Webs, Inc.",
                    Road = "12345 Sunny Road",
                    Country = "Sunnyville, TX 12345"
                },
                Buyer = new CompanyModel()
                {
                    Name = "Acme Corp.",
                    Road = "16 Johnson Road",
                    Country = "Paris, France 8060"
                },
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        Name = "Website design",
                        Price = 300
                    },
                    new ItemModel()
                    {
                        Name = "Implementing specific components",
                        Price = 600
                    },
                    new ItemModel()
                    {
                        Name = "Maintenance and support",
                        Price = 150
                    }
                }
            };
        }
    }

    public class CompanyModel
    {
        public string Name { get; set; }
        public string Road { get; set; }
        public string Country { get; set; }
    }

    public class ItemModel
    {
        public string Name { get; set; }
        public long Price { get; set; }
    }
}
