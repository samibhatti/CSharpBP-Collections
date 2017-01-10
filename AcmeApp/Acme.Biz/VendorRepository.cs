﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }

            for (int i = 0; i < vendors.Count; i++)
            {
              //  vendors[i].CompanyName = vendors[i].CompanyName.ToUpper();
                Console.WriteLine(vendors[i]);
            }
            foreach (var vendor in vendors)
            {
                //                vendor = new Vendor();// not allowed
              //  vendor.CompanyName = vendor.CompanyName.ToUpper();
              //  Console.WriteLine(vendor);
            }
           // Console.WriteLine(vendors);
            //Console.WriteLine(vendors[1]);

            return vendors;
        }
        //Retrieves all of the approved vendors
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                {"ABC Corp", new Vendor()
                    {VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" }},
                {"XYZ Inc", new Vendor()
                {VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } }
            };
            Console.WriteLine(vendors["XYZ Inc"]);
            if (vendors.ContainsKey("XYZ"))
            {
                Console.WriteLine(vendors["XYZ"]);
            }
            // Console.WriteLine(vendors);
            return vendors;
        }


       // public int RetrieveValue(string sql, int defaultValue)
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            //int value = defaultValue;
            T value = defaultValue;

            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
