DataContainer dataContainer = new DataContainer("Совы не то ,чем кажутся");
DataManager dataManager = new DataManager();

dataManager.ChangeDate(dataContainer, "Некоторые совы очень большие!");
Console.WriteLine( dataContainer.Data);
Console.ReadKey(true);








struct DataContainer
{
    public DataContainer(string data)
    {
        Data = data;
    }
    public string Data { get; set; }
}
class DataManager
{

    public void PrintData(DataContainer dataContainer)
    {
        Console.WriteLine(dataContainer.Data);
    }
    public void ChangeDate(DataContainer dataContainer, string newData)
    {
        dataContainer.Data = newData;
    }
}
