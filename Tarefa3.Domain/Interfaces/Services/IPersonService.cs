﻿using Tarefa3.Domain.Models;

namespace Tarefa3.Domain.Interfaces.Service
{
    public interface IPersonService
    {
        Task<List<Person>> GetAll();
    }
}