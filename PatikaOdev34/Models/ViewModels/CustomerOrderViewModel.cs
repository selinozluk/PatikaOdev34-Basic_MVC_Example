namespace Basic_MVC_Example.Models.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; } = new Customer();
        public List<Order> Orders { get; set; } = new();

    }
}
