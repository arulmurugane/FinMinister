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
using FinMinister.Application.Features.Expenses.Command;
using AutoMapper;

namespace FinMinister.Applicaiton.UnitTests.Expenses
{
    public class CreateExpenseTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IExpenseRepository> _mockExpenseRepository;

        public CreateExpenseTests()
        {
            _mockExpenseRepository = RepositoryMocks.GetExpenseRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidExpense_AddedToExpensesRepo()
        {
            var handler = new CreateExpenseCommandHandler(_mapper, _mockExpenseRepository.Object);

            await handler.Handle(new CreateExpenseCommand() { Category = "Test", Description="Test", Amount= 300, UserId = 100 }, CancellationToken.None);

            var allExpenses = await _mockExpenseRepository.Object.GetExpenseListByUserIdAsync(100);
            allExpenses.Count.ShouldBe(1);
        }

    }
}
