class Snake
{
    private List<SnakeSegment> segments = new List<SnakeSegment>();
    private Direction direction = Direction.Right;
    public bool HasCollidedWithFood(Position foodPosition)
    {
    if (Head.Position.X == foodPosition.X && Head.Position.Y == foodPosition.Y)
    {
        segments.Add(new SnakeSegment(new Position(7, 10)));
        return true;
    }

    return false;
    }
    public Snake()
    {
        segments.Add(new SnakeSegment(new Position(10, 10)));
        segments.Add(new SnakeSegment(new Position(9, 10)));
        segments.Add(new SnakeSegment(new Position(8, 10)));
    }

    public void ChangeDirection(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.LeftArrow && direction != Direction.Right)
        {
            direction = Direction.Left;
        }
        else if (key.Key == ConsoleKey.RightArrow && direction != Direction.Left)
        {
            direction = Direction.Right;
        }
        else if (key.Key == ConsoleKey.UpArrow && direction != Direction.Down)
        {
            direction = Direction.Up;
        }
        else if (key.Key == ConsoleKey.DownArrow && direction != Direction.Up)
        {
            direction = Direction.Down;
        }
    }

    public void Move()
    {
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].Position = segments[i - 1].Position;
        }

        if (direction == Direction.Left)
        {
            segments[0].Position = new Position(segments[0].Position.X - 1, segments[0].Position.Y);
        }
        else if (direction == Direction.Right)
        {
            segments[0].Position = new Position(segments[0].Position.X + 1, segments[0].Position.Y);
        }
        else if (direction == Direction.Up)
        {
            segments[0].Position = new Position(segments[0].Position.X, segments[0].Position.Y - 1);
        }
        else if (direction == Direction.Down)
        {
            segments[0].Position = new Position(segments[0].Position.X, segments[0].Position.Y + 1);
        }
    }

    public void Eat(Food food)
    {
        segments.Add(new SnakeSegment(Tail.Position));
    }

    public bool HasCollided()
    {
        Position headPosition = Head.Position;

        if (headPosition.X < 0 || headPosition.X >= 50 || headPosition.Y < 0 || headPosition.Y >= 20)
        {
            return true;
        }

        for (int i = 1; i < segments.Count; i++)
        {
            if (headPosition == segments[i].Position)
            {
                return true;
            }
        }

        return false;
    }

    public void Draw()
    {
        foreach (SnakeSegment segment in segments)
        {
            segment.Draw();
        }
    }

    public SnakeSegment Head
    {
        get
        {
            return segments[0];
        }
    }
    public SnakeSegment Tail
    {
        get
        {
            return segments[segments.Count];
        }
    }
}