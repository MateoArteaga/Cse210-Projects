class SnakeSegment
{
    public Position Position { get; set; }

    public SnakeSegment(Position position)
    {
        Position = position;
    }

    public void Draw()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write("O");
    }
}
