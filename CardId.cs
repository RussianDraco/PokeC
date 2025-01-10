public class CardId {
    public int CardNum { get; set; }
    public int Set { get; set; }

    public override string ToString()
    {
        return $"{CardNum}/{Set}";
    }
}