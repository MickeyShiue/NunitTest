using Mickey.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mickey.Service
{
    public class CustomersService
    {
        private readonly IRepository<Customers> _CustomersRepository;

        public CustomersService()
        {
            this._CustomersRepository = new Repository<Customers>();
        }

        //參數建構式留給測試專案用隔離框架使用，避免真的新增資料
        public CustomersService(IRepository<Customers> CustomersRepository)
        {
            this._CustomersRepository = CustomersRepository;
        }

        public void Create(Customers Entity)
        {
            _CustomersRepository.Create(Entity);
            _CustomersRepository.SaveChange();
        }

    }
}
