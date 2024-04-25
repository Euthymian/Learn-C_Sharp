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
        this.startTime = System.DateTime.Now;
    }
    public void Stop() {
        this.endTime = System.DateTime.Now;
    }
    public void GetElapsedTime() {
        System.TimeSpan elapsedTime = this.endTime - this.startTime;
        System.Console.WriteLine("Elapsed time: {0}", elapsedTime.Milliseconds);
    }
}