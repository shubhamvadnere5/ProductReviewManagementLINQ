﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace ProductReviewManagementLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Review="good",Rating=17,IsLike=true},
                new ProductReview(){ProductId=2,UserId=6,Review="good",Rating=11,IsLike=true},
                new ProductReview(){ProductId=1,UserId=2,Review="bad",Rating=7,IsLike=false},
                new ProductReview(){ProductId=12,UserId=1,Review="good",Rating=19,IsLike=true},
                new ProductReview(){ProductId=1,UserId=2,Review="good",Rating=18,IsLike=true},
                new ProductReview(){ProductId=8,UserId=3,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=5,UserId=5,Review="good",Rating=9,IsLike=false},
                new ProductReview(){ProductId=6,UserId=3,Review="good",Rating=7,IsLike=false},
                new ProductReview(){ProductId=4,UserId=5,Review="bad",Rating=19,IsLike=true},
                new ProductReview(){ProductId=3,UserId=6,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=5,UserId=7,Review="good",Rating=15,IsLike=true},
                new ProductReview(){ProductId=1,UserId=1,Review="good",Rating=18,IsLike=true},
                new ProductReview(){ProductId=2,UserId=9,Review="good",Rating=16,IsLike=true},
                new ProductReview(){ProductId=9,UserId=3,Review="bad",Rating=10,IsLike=false},
                new ProductReview(){ProductId=8,UserId=4,Review="good",Rating=13,IsLike=true},
                new ProductReview(){ProductId=4,UserId=5,Review="bad",Rating=3,IsLike=false},
                new ProductReview(){ProductId=2,UserId=8,Review="good",Rating=17,IsLike=true},
                new ProductReview(){ProductId=5,UserId=4,Review="bad",Rating=9,IsLike=false},
                new ProductReview(){ProductId=6,UserId=3,Review="good",Rating=24,IsLike=true},
                new ProductReview(){ProductId=1,UserId=7,Review="bad",Rating=3,IsLike=false},
                new ProductReview(){ProductId=4,UserId=9,Review="bad",Rating=1,IsLike=false},
                new ProductReview(){ProductId=9,UserId=8,Review="bad",Rating=2,IsLike=false},
                new ProductReview(){ProductId=8,UserId=3,Review="good",Rating=30,IsLike=true},
                new ProductReview(){ProductId=6,UserId=1,Review="bad",Rating=7,IsLike=false},
                new ProductReview(){ProductId=7,UserId=5,Review="good",Rating=34,IsLike=true},
            };
            Console.WriteLine("Choose operation you want: \n 1-Display all product review \n 2-Retrieve top three records \n 3-Retrieve records based on rating and productId \n 4-Count of the product id \n 5-Retrieve only ProductId and review \n 6-Skip Top Five Records \n 8-Create datatable and insert list \n 9-Retrieve the records whose column islike has true \n 10-Average rating value of productID");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ManagementOperation.IterateLoopList(list);
                    break;
                case 2:
                    ManagementOperation.RetriveTop3Records(list);
                    break;
                case 3:
                    ManagementOperation.RetriveBasedonProductIdandRating(list);
                    break;
                case 4:
                    ManagementOperation.CountingID(list);
                    break;
                case 5:
                    ManagementOperation.ProductIdandReview(list);
                    break;
                case 6:
                    ManagementOperation.IterateLoopList(list);
                    ManagementOperation.SkipTopFiveRecords(list);
                    break;
                case 8:
                    DataTable dataTable = ManagementOperation.CreateDataTable(list);
                    ManagementOperation.DisplayTableDetails(dataTable);
                    break;
                case 9:
                    DataTable table = ManagementOperation.CreateDataTable(list);
                    ManagementOperation.ReturnsOnlyIsLikeFieldAsTrue(table);
                    break;
                case 10:
                    DataTable dt = ManagementOperation.CreateDataTable(list);
                    ManagementOperation.AverageOfRating(dt);
                    break;
            }
            Console.ReadLine();
        }
    }
}