using Mickey.DataAccess;
using Mickey.Domain;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mickey.Service.Tests
{
    [TestFixture]
    public class CustomerServiceTests
    {
        [Test]
        public void Create_WhenCalled()
        {
            Customers model = new Customers { CompanyName = "MickeyCompany" };
            IRepository<Customers> mockDAO = Substitute.For<IRepository<Customers>>(); //測試隔離框架

            CustomersService service = new CustomersService(mockDAO);

            service.Create(model);

            mockDAO.Received(1).Create(model);
        }
    }
}
