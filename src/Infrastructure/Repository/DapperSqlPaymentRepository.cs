using System;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Dapper;

namespace Infrastructure.Repository
{
    public class DapperSqlPaymentRepository : DapperSqlRepository<Payment>, IPaymentRepository
    {
        public DapperSqlPaymentRepository()
        {
            TableName = "Payment";
        }
    }
}
