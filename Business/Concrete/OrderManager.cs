using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCutting.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        [SecuredOperation("order.add,admin")]
        [ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {
            
            //business code

            _orderDal.Add(order);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult("Başarıyla silindi");

        }

        public IDataResult<Order> Get(Guid id)
        
        {
            var data = _orderDal.Get(o=>o.ID == id);

            if(data==null){
                return new ErrorDataResult<Order>(data,"Order bulunamadı!");
            }
            
            return new SuccessDataResult<Order>(data);
        }

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Order>>("Sistem Bakımda!");
            }
           
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(),"Ürünler Listelendi!");
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult("Güncelleme başarılı");
        }
    }
}