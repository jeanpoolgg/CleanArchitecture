
namespace ObjectOrientedProgramming.Business
{
    public class ExpiringBear : Beer
    {
        public DateTime ExpirationDate { get; set; }

        public ExpiringBear(string name, decimal price, decimal alcohol, DateTime expirationDate) : base(name, price, alcohol)
        {
            ExpirationDate = expirationDate;
        }
    }
}
