class StopWatch {
    private System.DateTime startTime;
    private System.DateTime endTime;
    public System.DateTime StartTime {
        get {
            return this.startTime;
        }
        set {
            this.startTime = value;
        }
    }
    public System.DateTime EndTime {
        get {
            return this.endTime;
        }
        set {
            this.endTime = value;
        }
    }
    public void Start() {
        this.StartTime = System.DateTime.Now;
    }
    public void Stop() {
        this.EndTime = System.DateTime.Now;
    }
    public void GetElapsedTime() {
        System.TimeSpan elapsedTime = this.EndTime - this.StartTime;
        System.Console.WriteLine("Elapsed time: {0}", elapsedTime.Milliseconds);
    }
}