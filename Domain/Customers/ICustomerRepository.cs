// ICustomerRepository.cs04:0704:07

namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
    Task Add(Customer customer);
}