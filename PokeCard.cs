public class PokeCard
{
    public string Name { get; set; }
    public Type Type { get; set; }
    public Stage Stage { get; set; }
    public CardId Id { get; set; }
    public int HP { get; set; }
    public int RetreatCost { get; set; }
    public string[] Attacks { get; set; }
    public Type Weakness { get; set; }
    public Type Resistance { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Id})";
    }
}