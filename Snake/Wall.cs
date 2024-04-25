class Wall
{
    private Point2D position;
    private int direction; // 0: horizontal, 1: vertical
    private int length;

    public Point2D Position
    {
        get { return this.position;}
        set { this.position = value; }
    }
    public int Direction
    {
        get { return this.direction; }
        set { this.direction = value; }
    }
    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public Wall(Point2D position, int direction, int length, int[,] board)
    {
        this.Position = position;
        this.Direction = direction;
        this.Length = length;
        this.AddToBoard(board);
    }

    public void Render()
    {
        if (this.Direction == 0) {
            for (int i=0; i<this.Length; i++) {
                Console.SetCursorPosition(this.Position.y + i, this.Position.x);
                Console.Write("■");
            }
        }
        else {
            for (int i=0; i<this.Length; i++) {
                Console.SetCursorPosition(this.Position.y, this.Position.x + i);
                Console.Write("■"); 
            }
        }
    }
    public void AddToBoard(int[,] board)
    {
        if (this.Direction == 0) {
            for (int i=0; i<this.Length; i++) {
                board[this.Position.x, this.Position.y + i] = 2;
            }
        }
        else {
            for (int i=0; i<this.Length; i++) {
                board[this.Position.x + i, this.Position.y] = 2;
            }
        }
    }
}