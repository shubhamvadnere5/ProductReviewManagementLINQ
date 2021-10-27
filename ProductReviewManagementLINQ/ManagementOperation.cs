﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    class ManagementOperation
    {
        


            // UC1 Add  values in the list
            public static void IterateLoopList(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine("Product ID:" + product.ProductId + "\t User ID:" + product.UserId + "\t Review:" + product.Review + "\t Rating:" + product.Rating);
            }
        }

            //UC2
            //Retriving Top 3 Records from the List
            public static void RetriveTop3Records(List<ProductReview> list)
        {
            var result = (from product in list orderby product.Rating descending select product).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("After Sorting");
            IterateLoopList(result);
            var top3Records = result.Take(3).ToList();
            Console.WriteLine("=============================================");
            Console.WriteLine("Top 3 Records");
            IterateLoopList(top3Records);
            Console.ReadLine();
        }
            //UC3
            //retrive the record whose Rating is Greater than 3 and Product ID is Either 1 or 4 or 9
            public static void RetriveBasedonProductIdandRating(List<ProductReview> list)
        {
            var data = (list.Where(a => a.Rating > 3 && (a.ProductId == 1 || a.ProductId == 4 || a.ProductId == 9))).ToList();
            Console.WriteLine("The desire Result is :");
            IterateLoopList(data);
            Console.ReadLine();
        }
            //UC4
            //Counting Each ID present in the List
            public static void CountingID(List<ProductReview> list)
        {
            var data = (list.GroupBy(a => a.ProductId).Select(x => new { ProductId = x.Key, count = x.Count() }));
            Console.WriteLine("Count of Each Product Id is: ");
            foreach (var element in data)
            {
                Console.WriteLine("Product ID: " + element.ProductId + "\t Count: " + element.count);
                Console.WriteLine("========================================================");
            }
        }
        //UC5
        //Retrive only ProductID and Review from the Records
        public static void ProductIdandReview(List<ProductReview> list)
        {
            var p = list.Select(product => new { ProductId = product.ProductId, review = product.Review }).ToList();
            foreach (var element in p)
            {
                Console.WriteLine("Product ID: " + element.ProductId + "\t Review: " + element.review);
                Console.WriteLine("=====================================");
            }
        }
        //Uc6
        public static void SkipTopFiveRecords(List<ProductReview> products)
        {
            Console.WriteLine("\n----------Skip Top Five records in list");
            var res = (from product in products orderby product.Rating descending select product).Skip(5).ToList();
            IterateLoopList(res);
        }

        //UC8 create data table insert records into it
        public static void CreateDataTable(List<ProductReview> productList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("productId");
            dt.Columns.Add("userId");
            dt.Columns.Add("rating");
            dt.Columns.Add("review");
            dt.Columns.Add("isLike", typeof(bool));

            foreach (var data in productList)
            {
                dt.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
            }

            //Display table
            foreach (DataRow p in dt.Rows)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
            }
        }
    }
}
  
        
    


    

    

