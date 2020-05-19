public class Fruit {
    private FruitType type;
    private int duration;
    private int x;
    private int y;
    private int points;

    public FruitType Type { get => type; set => type = value; }
    public int Duration { get => duration; set => duration = value; }
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public int Points { get => points; set => points = value; }

    public Fruit(FruitType type)
    {
        Type = type;   
        Duration = 300;
        X = 0;
        Y = 0;
        Points = 100;
    }
}