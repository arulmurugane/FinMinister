using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FinMinister.Application.Contracts.Persistence;
using FinMinister.Domain.Entities;
using System.Threading;

namespace FinMinister.Applicaiton.UnitTests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IExpenseRepository> GetExpenseRepository()
        {
            var expenses = new List<Expense>
            {
                new Expense{
                    Id = Guid.NewGuid(),
                    Category = "Sports",
                    Description = "Badminton Racquet",
                    Amount = 3500,
                    UserId = 5,
                    CreatedBy = -1,
                    SyncDateTime = DateTime.Now

                },
                new Expense{
                    Id = Guid.NewGuid(),
                    Category = "Grocery",
                    Description = "Rice, oil, soap",
                    Amount = 7000,
                    UserId = 5,
                    CreatedBy = -1,
                    SyncDateTime = DateTime.Now

                },
                new Expense{
                    Id = Guid.NewGuid(),
                    Category = "Fitness",
                    Description = "Gym",
                    Amount = 5000,
                    UserId = 2,
                    CreatedBy = -1,
                    SyncDateTime = DateTime.Now

                }
            };

            var mocExpenseRepository = new Mock<IExpenseRepository>();
            mocExpenseRepository.Setup(repo => repo.GetExpenseListByUserIdAsync(It.IsAny<int>())).ReturnsAsync(
               (int userId) =>
               {
                  return expenses.Where<Expense>(e => e.UserId == userId).ToList();
               });

            mocExpenseRepository.Setup(repo => repo.AddAsync(It.IsAny<Expense>())).ReturnsAsync(
               (Expense expense) =>
               {
                   expenses.Add(expense);
                   return expense;
               });

            return mocExpenseRepository;
        }
        
    }
}
