var beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");
var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
report.Save(data, "cervezas.txt");


public class BeerData
{
    private List<string> _beers;

    public BeerData()
    {
        _beers = new List<string>();
    }

    public void Add(string beer) => _beers.Add(beer);

    public List<string> GetAll() => _beers;
}

public class ReportGeneratorBeer
{
    private BeerData _beerData;

    public ReportGeneratorBeer(BeerData beerData)
    {
        _beerData = beerData;
    }

    public List<string> Generate()
    {
        var data = new List<string>();
        int i = 1;
        foreach (var beer in _beerData.GetAll())
        {
            data.Add(i + " Cerveza: " + beer);
            i++;
        }
        return data;
    }
}

public class Report
{
    public void Save(List<string> data, string filePath)
    {
        using(var writer = new StreamWriter(filePath))
        {
            foreach(var beer in data)
            {
                writer.WriteLine(beer);
            }
        }
    }
}   