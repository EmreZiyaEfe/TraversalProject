using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract.AbstractUow;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.UnitOfWork;

namespace Traversal.Business.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public void TAdd(Account item)
        {
            _accountDal.Add(item);
            _uowDal.Save();
        }

        public Account TGetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void TMultiUpdate(List<Account> items)
        {
           _accountDal.MultiUpdate(items);
            _uowDal.Save();
        }

        public void TUpdate(Account item)
        {
            _accountDal.Update(item);
            _uowDal.Save();
        }
    }
}
