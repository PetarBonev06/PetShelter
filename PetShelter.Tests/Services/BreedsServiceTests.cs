using Moq;
using PetShelter.Service;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Enums;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Tests.Services
{
    public class BreedsServiceTests
    {
        private readonly Mock<IBreedRepository> _breedRepositoryMock = new Mock<IBreedRepository>();

        private readonly IBreedsService _service;

        public BreedsServiceTests()
        {
            _service = new BreedsService(_breedRepositoryMock.Object);
        }

        [Test]

        public async Task WhenCreateAsync_WithValidData_ThenSaveAsync()
        {
            // Arrange
            var breedDto = new BreedDto
            {
                Id = 0,
                Name = "Pug",
                Size = BreedSize.Small
            };

            //Act
            await _service.SaveAsync(breedDto);

            //Assert
            _breedRepositoryMock.Verify(x => x.SaveAsync(breedDto), Times.Once);
        }

        [Test]

        public async Task WhenSaveAsync_WithNull_ThenThrowArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async ()  => await _service.SaveAsync(null));
            _breedRepositoryMock.Verify(x => x.SaveAsync(null), Times.Never);
        }
    }
}
