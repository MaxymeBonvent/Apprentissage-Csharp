// 59. STREAM

namespace Lesson59
{
    class Program59
    {
        // public static void Main()
        // {
        //     /*
        //         C# includes following standard IO (Input/Output) classes to read/write from 
        //         different sources like files, memory, network, isolated storage, etc.

        //         Stream: System.IO.Stream is an abstract class that provides standard methods 
        //         to transfer bytes (read, write, etc.) to the source. 
        //         It is like a wrapper class to transfer bytes. Classes that need to read/write 
        //         bytes from a particular source must implement the Stream class.

        //         The following classes inherit Stream class to provide the functionality to 
        //         Read/Write bytes from a particular source:
        //     */

        //     /*
        //         1. FileStream reads or writes bytes from/to a physical file, whether it is a 
        //         .txt, .exe, .webp, or any other file. FileStream is derived from the Stream 
        //         class.

        //         2. MemoryStream: MemoryStream reads or writes bytes that are stored in memory.

        //         3. BufferedStream: BufferedStream reads or writes bytes from other Streams to 
        //         improve certain I/O operations' performance.

        //         4. NetworkStream: NetworkStream reads or writes bytes from a network socket.

        //         5. PipeStream: PipeStream reads or writes bytes from different processes.

        //         6. CryptoStream: CryptoStream is for linking data streams to cryptographic 
        //         transformations.
        //     */

        //     // The following diagram shows the hierarchy of stream classes:

        //     /*
        //         STREAM READERS AND WRITERS

        //         StreamReader: StreamReader is a helper class for reading characters from a 
        //         Stream by converting bytes into characters using an encoded value. 
        //         It can be used to read strings (characters) from different Streams like 
        //         FileStream, MemoryStream, etc.

        //         StreamWriter: StreamWriter is a helper class for writing a string to a Stream 
        //         by converting characters into bytes. It can be used to write strings to 
        //         different Streams such as FileStream, MemoryStream, etc.

        //         BinaryReader: BinaryReader is a helper class for reading primitive datatype 
        //         from bytes.

        //         BinaryWriter: BinaryWriter writes primitive types in binary.
        //     */

        //     /*
        //         The above image shows that FileStream reads bytes from a physical file, and 
        //         then StreamReader reads strings by converting those bytes to strings. 
        //         In the same way, the StreamWriter takes a string and converts it into bytes 
        //         and writes to the FileStream, and then the FileStream writes the bytes to a 
        //         physical file. So, the FileStream deals with bytes, where as StreamReader and 
        //         StreamWriter deals with strings.
        //     */
        // }
    }
}