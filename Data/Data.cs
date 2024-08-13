namespace BlazingPizza.Data;

public class PizzaState
{
    public int PizzaId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }
}

// public class PizzaService
// {
//     public Task<PizzaState[]> GetPizzasAsync()
//     {
//     // Call your data access technology here
//     }
// }