class Bait {
    private Point2D position;
    private Random rand;
    private bool eaten;
    public bool Eaten
    {
        get { return eaten; }
        set { eaten = value; }
    }
    public Point2D Position
    {
        get { return position; }
        set { position = value; }
    }
    public Bait(Point2D position) {
        this.eaten = false;
        this.position = position;
        this.rand = new Random();
    }
    public void Spawn(int[,] board) {
        this.position.x = rand.Next(120);
        this.position.y = rand.Next(40);
        while (board[this.position.y, this.position.x] != 0)
        {
            this.position.x = rand.Next(120);
            this.position.y = rand.Next(40);
        }
    }
    public void Render()
    {
        Console.SetCursorPosition(this.position.x, this.position.y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("o");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void Update(int[,] board)
    {
        if (this.Eaten)
        {
            this.Eaten = false;
            this.Spawn(board);
        }
    }
}