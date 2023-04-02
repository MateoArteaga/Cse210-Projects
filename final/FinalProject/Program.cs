using System;
using System.Collections.Generic;
using System.Threading;

class SnakeGame
{
    static void Main(string[] args)
    {
        int difficulty;
        Console.WriteLine("Easy(1) Normal(2) or Hard(3)?: ");
        difficulty = int.Parse(Console.ReadLine());
        if (difficulty == 1)
        {
            difficulty = 100;
        }
        if (difficulty == 2)
        {
            difficulty = 50;
        }
        if (difficulty == 3)
        {
            difficulty = 20;
        }
        else 
        {
            difficulty = 100;
        }
        Console.Title = "Snake Game";
        Console.CursorVisible = false;

        Console.SetWindowSize(50, 20);
        Console.SetBufferSize(50, 20);

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        Snake snake = new Snake();
        Food food = new Food();
        food.Spawn(snake);

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                snake.ChangeDirection(key);
            }

            Console.Clear();
            snake.Move();
            if (snake.HasCollided())
            {
                break;
            }
            if (snake.Head.Position == food.Position)
            {
                snake.Eat(food);
                food.Spawn(snake);
                Console.WriteLine("now!");
            }
            snake.Draw();
            food.Draw();
            Thread.Sleep(difficulty);
        }

        Console.SetCursorPosition(15, 9);
        Console.WriteLine("Game Over!");
        Console.ReadKey(true);
    }
}


enum Direction
{
    Left,
    Right,
    Up,
    Down
}

