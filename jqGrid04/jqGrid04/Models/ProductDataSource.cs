﻿using System.Collections.Generic;

namespace jqGrid04.Models
{
    /// <summary>
    /// منبع داده فرضی جهت سهولت دموی برنامه
    /// </summary>
    public static class ProductDataSource
    {

        private static readonly IList<Product> _cachedItems;
        static ProductDataSource()
        {
            _cachedItems = createProductsDataSource();
        }

        public static IList<Product> LatestProducts
        {
            get { return _cachedItems; }
        }

        /// <summary>
        /// هدف صرفا تهیه یک منبع داده آزمایشی ساده تشکیل شده در حافظه است
        /// </summary>        
        private static IList<Product> createProductsDataSource()
        {
            var list = new List<Product>();
            for (var i = 0; i < 500; i++)
            {
                list.Add(new Product
                {
                    Id = i + 100,
                    Name = "نام " + (i + 1),
                    Price = i * 1000,
                    Supplier = new Supplier
                    {
                        Id = i + 1,
                        CompanyName = "شرکت " + (i + 1),
                        Address = "آدرس " + (i + 1),
                        PostalCode = "کدپستی " + (i + 1),
                        City = "شهر " + (i + 1),
                        Country = "کشور " + (i + 1),
                        Phone = "شماره تماس " + (i + 1),
                        HomePage = "سایت " + (i + 1)
                    },
                    Category = new Category
                    {
                        Id = i + 1,
                        Name = "گروه " + (i + 1)
                    }
                });
            }
            return list;
        }
    }
}