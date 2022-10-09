using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> Get(Guid id);
    }
}