using AutoMapper;
using FinMinister.Application.Features.Expenses;
using FinMinister.Application.Features.Expenses.Command;
using FinMinister.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinMinister.Application.Profiles
{
    internal class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Expense, ExpenseListVM>();
            CreateMap<Expense, CreateExpenseCommand>().ReverseMap();
        }
    }
}
