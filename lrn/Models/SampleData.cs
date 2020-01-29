using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lrn.Models
{
    public class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone X",
                        Company = "Apple",
                        Price = 1000
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 500
                    },
                    new Phone
                    {
                        Name = "Huawei P30",
                        Company = "Huawei",
                        Price = 500
                    },
                    new Phone
                    {
                        Name = "Honor 9X",
                        Company = "Huawei",
                        Price = 450
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
