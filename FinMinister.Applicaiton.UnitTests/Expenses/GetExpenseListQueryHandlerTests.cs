using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using FinMinister.Application.Contracts.Persistence;
using FinMinister.Domain.Entities;
using FinMinister.Applicaiton.UnitTests.Mocks;
using FinMinister.Application.Profiles;
using FinMinister.Application.Features.Expenses.Queries;
using AutoMapper;


namespace FinMinister.Applicaiton.UnitTests.Expenses
{
    public class GetExpenseListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IExpenseRepository> _mockExpenseRepository;

        public GetExpenseListQueryHandlerTests()
        {
            _mockExpenseRepository = RepositoryMocks.GetExpenseRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetExpenseListTest()
        {
            var handler = new GetExpenseListQueryHandler(_mapper, _mockExpenseRepository.Object);

            var result = await handler.Handle(new GetExpenseListQuery(){ UserId = 5 }, CancellationToken.None);

            result.ShouldBeOfType<List<ExpenseListVM>>();

            result.Count.ShouldBe(3);
        }
    }
}
