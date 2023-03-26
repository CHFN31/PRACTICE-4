Orcs newOrc = new Orcs();

newOrc.OrcsQyantity();
newOrc.OrcsQyantity();
newOrc.OrcsQyantity();
newOrc.OrcsQyantity();
newOrc.OrcsQyantity();
newOrc.OrcsQyantity();
newOrc.OrcsInfo();






class Orcs
{
    public int orcGoldIncome;
    public int orcQuantity;

    public Orcs ()
    {
       
    }

    public int OrcsQyantity()
    {
        orcQuantity++;
        if(orcQuantity < 5)
        {
            return orcGoldIncome += 2;
        }
        else
        {
            return orcGoldIncome -= 2;
        }
    }

    public void OrcsInfo()
    {
        Console.WriteLine($"кол-во орков {orcQuantity} \n Кол-во золота {orcGoldIncome} ");
    }

}