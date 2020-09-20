using Dal.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Concrete.EntityFramework.Repository
{
    public class EfSellRepository : EfGenericRepository<SellDetail>, ISellRepository
    {
        public EfSellRepository():base()
        {
            
        }

        public bool deleteOffer(int offerId)
        {
            throw new NotImplementedException();
        }

        public bool deleteSell(int sellDetailId)
        {
            throw new NotImplementedException();
        }

        public int makeOffer(OfferDetail offerDetail)
        {
            throw new NotImplementedException();
        }

        public int sellBook(SellDetail selldetail)
        {
            throw new NotImplementedException();
        }
    }
}
