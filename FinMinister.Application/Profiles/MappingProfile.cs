using AutoMapper;
using FinMinister.Application.Features.Expenses.Queries;
using FinMinister.Application.Features.Expenses.Command;
using FinMinister.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinMinister.Application.Features.Incomes.Queries;

namespace FinMinister.Application.Profiles
{
    internal class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Expense, ExpenseListVM>();
            CreateMap<Income, IncomeListVM>();
            CreateMap<Expense, CreateExpenseCommand>().ReverseMap();
        }
    }
}
