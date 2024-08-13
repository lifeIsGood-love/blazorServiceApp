// using Microsoft.EntityFrameworkCore;

// namespace BlazingPizza.Data;

// public class PizzaStoreContext : DbContext
// {
//     public PizzaStoreContext(DbContextOptions options) : base(options)
//     {
//     }

//     public DbSet<PizzaSpecial> Specials { get; set; }
// }

// public class Pizza
// {
//     public int PizzaId { get; set; }
    
//     public string Name { get; set; }
    
//     public string Description { get; set; }
    
//     public decimal Price { get; set; }
    
//     public bool Vegetarian { get; set; }
    
//     public bool Vegan { get; set; }
// }

// public class PizzaService
// {
//     public Task<Pizza[]> GetPizzasAsync()
//     {
//     // Call your data access technology here
//     }
// }

using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}