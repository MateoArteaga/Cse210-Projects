class Food
{
    public Position Position { get; set; }

    public void Spawn(Snake snake)
    {
        Random random = new Random();
        int x = random.Next(0, 50);
        int y = random.Next(0, 20);
        Position = new Position(x, y);

        while (snake.HasCollidedWithFood(Position))
        {
            x = random.Next(0, 50);
            y = random.Next(0, 20);
            Position = new Position(x, y);
        }
    }

    public void Draw()
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write("X");
    }
}