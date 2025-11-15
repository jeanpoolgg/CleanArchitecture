namespace BeersRepositoryComponent
{
    public class Beers
    {
        private List<string> _beers;

        public Beers() => _beers = new List<string>();

        public void AddBeer(string beer) => _beers.Add(beer);

        public List<string> GetBeers() => _beers;
    }
}
