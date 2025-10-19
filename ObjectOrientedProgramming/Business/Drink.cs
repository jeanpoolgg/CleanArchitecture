
namespace ObjectOrientedProgramming.Business
{
    public abstract class Drink
    {
        public int Quantity { get; set; }

        public Drink(int quantity)
        {
            Quantity = quantity;
        }

        public string GetQuantityInfo()
        {
            return Quantity + " ml";
        }

        public abstract string GetCategory();

    }
}
