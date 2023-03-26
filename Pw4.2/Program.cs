
Package Laundry = new Package("Стиральная машина", 50);
Package PcClub = new Package("Компьютеры", 125);
Package X5GROUP = new Package("Стелажы", 220);

DeliveryService mail = new DeliveryService(200);
mail.SendAPacckage(Laundry);
mail.SendAPacckage(PcClub);
mail.SendAPacckage(X5GROUP);

Console.ReadKey(true);




class Package
{
    public string PackageDescription { get; set; }
    public double Weight { get; set; }

    public Package(string packageDescription, double weight) 
    {
        PackageDescription = packageDescription;
        Weight = weight;
    }
}
class DeliveryService
{
    private double WeightLimit { get; set; }
    private double packageOverallWeight;

    public DeliveryService( int weightLimit)
    {
        WeightLimit = weightLimit;
    }
    public void SendAPacckage(Package package)
    { 
        if (WeightLimit >= (packageOverallWeight += package.Weight))
        {

            Console.WriteLine($"Общий вес {packageOverallWeight}");
        }
        else
        {
            Console.WriteLine($"У нас не хватает места ");
        }
    }
}