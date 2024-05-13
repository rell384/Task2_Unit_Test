using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAPI.Entities;
using CarFactoryAPI.Entities;
using CarFactoryAPI.Repositories_DAL;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CarFactoryAPI.Repositories_DAL;
using CarFactoryAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CarFactoryAPI_test
{
    public class OwnerRepoTests
    {
        private Mock<FactoryContext> factoryContextMock;
        private OwnerRepository ownerRepository;
        public OwnerRepoTests()
        {
            factoryContextMock = new Mock<FactoryContext>();

            ownerRepository = new OwnerRepository(factoryContextMock.Object);
        }

        [Fact]
        [Trait("Author", "Reham")]
        public void GetOwnerById_AskForOwner10_ReturnOwner()
        {

            List<Owner> owners = new List<Owner>() { new Owner() { Id = 10 } };

            factoryContextMock.Setup(fcm => fcm.Owners).ReturnsDbSet(owners);


            Owner owner = ownerRepository.GetOwnerById(10);


            Assert.NotNull(owner);
        }

        [Fact]
        [Trait("Author", "Reham")]
        public void GetAllOwner_ReturnListOfOwner()
        {

            List<Owner> owners = new List<Owner>() { new Owner() { Id = 10 } };

            factoryContextMock.Setup(fcm => fcm.Owners).ReturnsDbSet(owners);


            List<Owner> owner = ownerRepository.GetAllOwners();


            Assert.NotNull(owner);
        }
    }
}
