
namespace ObjectOrientedProgramming.Business
{
    public class ExpiringBear : Beer
    {
        public DateTime ExpirationDate { get; set; }

        public ExpiringBear(string name, decimal price, decimal alcohol, DateTime expirationDate, int quantity) : base(name, price, alcohol, quantity)
        {
            ExpirationDate = expirationDate;
        }

        public override string GetInfo()
        {
            return "Cerveza con caducidad: " + Name + ", " + "Precio: $ " + Price + ", Alcohol: " + Alcohol + ", caducidad: " + ExpirationDate.Date.ToString();
        }
    }
}
