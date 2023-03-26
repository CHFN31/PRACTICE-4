Spell alohamora = new Spell(60,"Алохамора" , "Замок открывается");
Spell vingardiumLeviosa = new Spell(60,"Вингардиумлевиосса", "Предмет поднимается в воздух");

Magician garryPotter = new Magician("Гарри Поттер", 100);
garryPotter.CastSpell(alohamora);
garryPotter.CastSpell(vingardiumLeviosa);

Console.ReadKey(true);



class Spell
{
    public int Mana { get; set; }
    public string SpellName { get; set; }
    private string Effect { get; set; }

    public Spell (int mana, string spellName,string effect)
    {
        Mana = mana;
        Effect = effect;
        SpellName = spellName;

    }
    public void Use( string name)
    {
        Console.WriteLine($"{name} колдует {SpellName} \n {Effect} ");
    }
}
class Magician
{
    public string Name { get; set; }
    public int Mana { get; set; }

    public Magician (string name, int mana)
    {
        Name = name;   
        Mana = mana;
    }
    public void CastSpell (Spell spell)
    {
        if (Mana >= spell.Mana)
        {
            spell.Use(Name);
            Mana -= spell.Mana;
            Console.WriteLine($"Маны осталось {Mana}");
        }
        else 
        {
            Console.WriteLine($"Для использования {spell.SpellName} не хватает {spell.Mana - Mana} единиц маны. Хлебните зелья");
        }
    }
}