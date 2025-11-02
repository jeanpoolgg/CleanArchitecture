IRepository<string> beerData = new BeerData();
beerData.Add("Corona");
beerData.Add("Delirium");
beerData.Add("Erdinger");
var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var reportGeneratorHTMLBeer = new ReportGeneratorHTMLBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
// report.Save(reportGeneratorBeer, "cervezas.txt");
report.Save(reportGeneratorHTMLBeer, "cervezas.html");

Show(reportGeneratorBeer);

void Show(IReportShow report)
{
    report.Show();
}

public interface IReportGenerator
{
    public string Generate();
}

public interface IReportShow
{
    public void Show();
}

public interface IRepository<T>
{
    public void Add(T item);
    public List<T> GetAll();
}

public class BeerData: IRepository<string>
{
    private List<string> _beers;

    public BeerData()
    {
        _beers = new List<string>();
    }

    public void Add(string beer) => _beers.Add(beer);

    public List<string> GetAll() => _beers;
}


public class LimitedBeerData
{
    private IRepository<string> _beerData;
    private int _limit;
    private int _count = 0;

    public LimitedBeerData(int limit, IRepository<string> beerData)
    {
        _limit = limit;
        _beerData = beerData;
    }

    public void Add(string beer)
    {
        if (_count >= _limit)
        {
            throw new InvalidOperationException("Límite de cervezas alcanzado");
        }
        _beerData.Add(beer);
        _count++;
    }
}

public class ReportGeneratorBeer : IReportGenerator, IReportShow
{
    private IRepository<string> _beerData;

    public ReportGeneratorBeer(IRepository<string> beerData)
    {
        _beerData = beerData;
    }

    public string Generate()
    {
        string data = "";
        foreach (var beer in _beerData.GetAll())
        {
            data += "Cerveza: " + beer + Environment.NewLine;
        }
        return data;
    } 

    public void Show()
    {
        foreach(var beer in _beerData.GetAll())
        {
            Console.WriteLine("Cerveza: " + beer);
        }
    }   
}

public class ReportGeneratorHTMLBeer : IReportGenerator
{
    private IRepository<string> _beerData;
    public ReportGeneratorHTMLBeer(IRepository<string> beerData)
    {
        _beerData = beerData;
    }

    public string Generate()
    {
        string data = "<html><body><ul>";
        foreach(var beer in _beerData.GetAll())
        {
            data += "<li>" + beer + "</li>";
        }
        data += "</ul></body></html>";
        return data;
    }
}

public class Report
{
    public void Save(IReportGenerator reportGenerator, string filePath)
    {
        using(var writer = new StreamWriter(filePath))
        {
            string data = reportGenerator.Generate();
            writer.WriteLine(data);
        }
    }
}   