// Customer.cs03:0703:07

using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customers;

public sealed class Customer : AggregateRoot
{
    public Customer(CustomerId id, string name, string lastName, string email, PhoneNumber phoneNumber, Address address, bool active)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        Active = active;
    }
    private Customer(){}
    
    public CustomerId Id { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; set; }
    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public Address Address { get; private set; }
    public bool Active { get; set; }
}