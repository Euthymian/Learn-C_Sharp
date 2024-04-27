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
    private List<Wall> walls;
    private int[,] board;
    private bool run;
    public SnakeGame()
    {
        run = true;
        snake = new Snake();
        snake.Init();
        bait = new Bait(new Point2D(50,19));
        board = new int[Console.WindowHeight, Console.WindowWidth];
        walls =
        [
            new Wall(new Point2D(0, 0), 0, this.board.GetLength(1), this.board),
            new Wall(new Point2D(Console.WindowHeight - 1, 0), 0, this.board.GetLength(1), this.board),
            new Wall(new Point2D(0, 0), 1, this.board.GetLength(0), this.board),
            new Wall(new Point2D(0, Console.WindowWidth - 1), 1, this.board.GetLength(0), this.board),
            new Wall(new Point2D(20,49), 1, 5, board),
            new Wall(new Point2D(20,49), 0, 7, board),
            new Wall(new Point2D(11,80), 1, 6, board),
            new Wall(new Point2D(11,74), 0, 6, board),
            new Wall(new Point2D(35,90), 0, 11, board),
            new Wall(new Point2D(6,6), 1, 7, board)
        ];
    }
    private void Render()
    {
        foreach (Wall wall in walls)
        {
            wall.Render();
        }
        this.bait.Render();
        this.snake.Render();
    }
    private void Update()
    {
        this.bait.Update(this.board);
        this.snake.Update(this.board, this.bait, ref this.run);
    }
    public void Run()
    {
        //new Wall(new Point2D(0, 0), 0, this.board.GetLength(1), this.board);
        //new Wall(new Point2D(Console.WindowHeight - 1,0), 0, this.board.GetLength(1), this.board);
        //new Wall(new Point2D(0, 0), 1, this.board.GetLength(0), this.board);
        //new Wall(new Point2D(0, Console.WindowWidth - 1), 1, this.board.GetLength(0), this.board);
        //for (int i = 0; i < board.GetLength(0); i++)
        //{
        //    for (int j = 0; j < board.GetLength(1); j++)
        //    {
        //        Console.Write(board[i, j]);
        //    }
        //    System.Console.WriteLine();
        //}

        while (run)
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