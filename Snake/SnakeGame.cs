using System.Diagnostics.CodeAnalysis;

struct Point2D
{
    public int x;
    public int y;
    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public static bool operator ==(Point2D a, Point2D b)
    {
        return a.x == b.x && a.y == b.y;
    }
    public static bool operator !=(Point2D a, Point2D b)
    {
        return a.x!=b.y || a.y!=b.x;
    }
}
class SnakeGame
{
    private Snake snake;
    private Bait bait;
    private int[,] board;
    public SnakeGame()
    {
        snake = new Snake();
        snake.Init();
        bait = new Bait(new Point2D(50,19));
        board = new int[Console.WindowWidth, Console.WindowHeight];
    }
    public void Render()
    {
        this.bait.Render();
        this.snake.Render();
    }
    public void Update()
    {
        this.bait.Update(this.board);
        this.snake.Update(this.board, this.bait);
    }
    public void Run()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow && this.snake.Direction[0].y == 0)
                {
                    this.snake.NewDir = new Point2D(0, -1);
                }
                else if (key == ConsoleKey.RightArrow && this.snake.Direction[0].x == 0)
                {
                    this.snake.NewDir = new Point2D(1, 0);
                }
                else if (key == ConsoleKey.DownArrow && this.snake.Direction[0].y == 0)
                {
                    this.snake.NewDir = new Point2D(0, 1);
                }
                else if (key == ConsoleKey.LeftArrow && this.snake.Direction[0].x == 0)
                {
                    this.snake.NewDir = new Point2D(-1, 0);
                }
            }
            Console.Clear();
            this.Update();
            this.Render();
            Thread.Sleep(75 - this.snake.Length * 2);
            this.snake.NewDir = null;
        }
    }
}