using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Model
{
    public enum PurchaceOrderHeaderStatusEnum : byte
    {
        Unknown = 0,
        Pending = 1,
        Approved = 2,
        Rejected = 3,
        Completed = 4
    }
}