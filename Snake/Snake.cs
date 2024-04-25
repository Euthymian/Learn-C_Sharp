using System.Reflection;
using System.Xml.Linq;

class Snake {
    private List<Point2D> body;
    private List<Point2D> direction;
    private int length;
    private Point2D? newDir;

    public List<Point2D> Body
    {
        get { return body; }
        set { body = value; }
    }

    public List<Point2D> Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    public int Length { 
        get { return length; } 
        set { length = value; } 
    }

    public Point2D? NewDir
    {
        get { return newDir; }
        set { newDir = value; }
    }

    public Snake()
    {
        this.body = new List<Point2D>();
        this.direction = new List<Point2D>();
        this.length = 2;
    }
    public void Init()
    {
        this.Body.Add(new Point2D(79, 19));
        this.Body.Add(new Point2D(80, 19));
        this.Body.Add(new Point2D(81, 19));
        this.Direction.Add(new Point2D(-1, 0));
        this.Direction.Add(new Point2D(-1, 0));
        this.Direction.Add(new Point2D(-1, 0));
    }
    public void Render()
    {
        foreach (var item in this.Body)
        {
            Console.SetCursorPosition(item.x, item.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public void Move(int[,] board)
    {
        for (int i=0; i<this.Body.Count; i++)
        {
            //this.Body[i].x += this.Direction[i].x;

            var bodyPart = this.Body[i];
            bodyPart.x += this.Direction[i].x;
            bodyPart.y += this.Direction[i].y;
            this.Body[i] = bodyPart;
            board[this.Body[i].x,this.Body[i].y] = 1;
        }
    }
    public void ChangeDir(Point2D? dir)
    {
        for (int i=this.Body.Count-1; i > 0; --i)
        {
            this.Direction[i] = this.Direction[i-1];
        }
        if (dir != null)
        {
            this.Direction[0] = new Point2D(dir.Value.x, dir.Value.y);
        }
    }
    public void Eat(Bait bait)
    {
        if (bait.Position == this.Body[0])
        {
            bait.Eaten = true;
            this.Body.Add(new Point2D(
                this.Body[this.Body.Count-1].x - this.Direction[this.Direction.Count - 1].x, 
                this.Body[this.Body.Count - 1].y - this.Direction[this.Direction.Count - 1].y));
            this.Direction.Add(new Point2D(this.Direction[this.Direction.Count - 1].x, this.Direction[this.Direction.Count - 1].y));
        }
    }
    public void Update(int[,] board, Bait bait)
    {
        this.ChangeDir(this.NewDir);
        this.Eat(bait);
        this.Move(board);
        this.Length = this.Body.Count;
    }
}