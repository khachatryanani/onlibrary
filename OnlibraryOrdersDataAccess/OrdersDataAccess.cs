using OnlibraryOrdersDataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OnlibraryOrdersDataAccess
{
    public class OrdersDataAccess: IOrdersDataAccess
    {
        private readonly string connectionString;

        public OrdersDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int CreateOrder(OrderBase order) 
        {

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[CreateOrder]";
                    SqlParameter outputParam = command.Parameters.Add("@orderId", SqlDbType.Int);
                    outputParam.Direction = ParameterDirection.Output;

                    command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = order.UserId;
                    command.Parameters.Add("@bookId", SqlDbType.Int).Value = order.BookId;
                    command.Parameters.Add("@bookLanguage", SqlDbType.Int).Value = order.BookLanguageId;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = order.Address;
                    command.Parameters.Add("@country", SqlDbType.Int).Value = order.Country;
                    command.Parameters.Add("@orderDate", SqlDbType.DateTime2).Value = order.OrderDate;

                    command.ExecuteNonQuery();

                    return  Convert.ToInt32(outputParam.Value);
                }
            }
        }

        public IEnumerable<OrderBase> GetOrders(string userId) 
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetOrders]";
                    command.Parameters.Add("@userId", SqlDbType.NVarChar).Value = userId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var orders = new List<OrderBase>();
                        if (reader.HasRows)
                        {
                            int orderId = reader.GetOrdinal("OrderId");
                            int bookId = reader.GetOrdinal("BookId");
                            int bookLanguageId = reader.GetOrdinal("BookLanguage");
                            int address = reader.GetOrdinal("Address");
                            int country = reader.GetOrdinal("Country");
                            int orderDate = reader.GetOrdinal("OrderDate");


                            while (reader.Read())
                            {
                                orders.Add(
                                    new OrderBase
                                    {
                                        UserId = userId,
                                        OrderId = reader.GetInt32(orderId),
                                        BookId = reader.GetInt32(bookId),
                                        BookLanguageId = reader.GetInt32(bookLanguageId),
                                        Address = reader.GetString(address),
                                        Country = reader.GetInt32(country),
                                        OrderDate = reader.GetDateTime(orderDate)
                                    });
                            }
                        }

                        return orders;
                    }
                }
            }


        }
    }
}
