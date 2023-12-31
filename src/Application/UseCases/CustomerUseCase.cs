﻿using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases
{
    public class CustomerUseCase : ICustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerUseCase(ICustomerRepository userRepository)
        {
            _customerRepository = userRepository;
        }

        public async Task CreateCustomer(Cliente cliente)
        {
            await _customerRepository.CreateCustomer(cliente);
        }

        public async Task<Cliente> GetCustomerByDocument(string cpf)
        {
            return await _customerRepository.GetCustomerByDocument(cpf);
        }
    }
}
