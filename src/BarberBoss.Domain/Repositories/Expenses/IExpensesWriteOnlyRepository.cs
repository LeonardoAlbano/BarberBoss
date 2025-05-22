﻿using BarberBoss.Domain.Entities;

namespace BarberBoss.Domain.Repositories.Expenses
{
    public interface IExpensesWriteOnlyRepository
    {
        Task Add(Expense expense);
        /// <summary>
        /// This function returns TRUE if the deletion was successful otherwise returns FALSE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(long id);

    }
}
