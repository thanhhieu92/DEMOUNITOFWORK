﻿using DEMOUNITOFWORK.Models;

namespace DEMOUNITOFWORK.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order OrderGetOrder(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
