class LearnStream {
    public static void Run() {
        FileStream fs = new FileStream("TextFile/test.txt", FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Hello World");
        fs.Flush(); // Flushes the data from the buffer to the file
        sw.Close(); // Closes the StreamWriter and the underlying FileStream
        fs.Close(); // Closes the FileStream

        /*
        FileStream is a class that provides a Stream for a file, supporting both synchronous and asynchronous read and write operations.
        FileStream is used to read from, write to, and create files.
        */

        /* 
        StreamWriter is a class that provides a TextWriter for writing characters to a stream in a particular encoding.
        StreamWriter is used to write text to a file.
        */

        /*
        FileMode is an enum that specifies how the operating system should open a file.
        Available modes are: Append (opens the file if it exists and seeks to the end of the file, or creates a new file), 
                             Create (creates a new file), 
                             CreateNew (creates a new file, throws an exception if the file already exists), 
                             Open (opens a file), 
                             OpenOrCreate (opens a file if it exists, creates a new file if it does not), 
                             Truncate (opens the file, truncates it to zero bytes, and writes to it)
        */    

        /*
        FileAccess is an enum that specifies the operations that can be performed on the file opened by the FileStream object.
        Available modes are: Read, Write, ReadWrite
        */                    
    }
}