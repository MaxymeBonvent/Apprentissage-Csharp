// 61. FILEINFO

using System.IO; // Necessary for FileInfo.AppendText method
using System.Text; // Necessary for Encoding

namespace Lesson61
{
    class Program61
    {
        // public static void Main()
        // {
        //     /*
        //         Here, you will learn how to use FileInfo class to perform read/write 
        //         operation on physical files.

        //         The FileInfo class provides the same functionality as the static File class 
        //         but you have more control on read/write operations on files by writing code 
        //         manually for reading or writing bytes from a file.
        //     */

        //     /*
        //         IMPORTANT PROPERTIES AND METHODS OF FILEINFO

        //         PROPERTIES 

        //         Property	    Usage
        //         Directory	    Gets an instance of the parent directory.

        //         DirectoryName	Gets a string representing the directory's full path.

        //         Exists	        Gets a value indicating whether a file exists.

        //         Extension	    Gets the string representing the extension part of the file.

        //         FullName	    Gets the full path of the directory or file.

        //         IsReadOnly	    Gets or sets a value that determines if the current file is 
        //                         read only.

        //         LastAccessTime	Gets or sets the time the current file or directory was last 
        //                         accessed.

        //         LastWriteTime	Gets or sets the time when the current file or directory was 
        //                         last written to.

        //         Length	        Gets the size, in bytes, of the current file.

        //         Name	        Gets the name of the file.

        //         METHODS

        //         Method	            Usage
        //         AppendText	        Creates a StreamWriter that appends text to the file 
        //                             represented by this instance of the FileInfo.

        //         CopyTo	            Copies an existing file to a new file, disallowing the 
        //                             overwriting of an existing file.

        //         Create	            Creates a file.

        //         CreateText	        Creates a StreamWriter that writes a new text file.

        //         Decrypt	            Decrypts a file that was encrypted by the current account 
        //                             using the Encrypt method.

        //         Delete	            Deletes the specified file.

        //         Encrypt	            Encrypts a file so that only the account used to encrypt 
        //                             the file can decrypt it.

        //         GetAccessControl	Gets a FileSecurity object that encapsulates the access 
        //                             control list (ACL) entries for a specified file.

        //         MoveTo	            Moves a specified file to a new location, providing the 
        //                             option to specify a new file name.

        //         Open	            Opens a file in the specified FileMode.

        //         OpenRead	        Creates a file with the read-only FileStream.

        //         OpenText	        Creates a StreamReader with UTF-8 encoding that reads from 
        //                             an existing text file.

        //         OpenWrite	        Creates a write-only FileStream.

        //         Replace	            Replaces the contents of a specified file with the file 
        //                             described by the current FileInfo object, deleting the 
        //                             original file, and creating a backup of the replaced file.

        //         ToString	        Returns a path as string.
        //     */

        //     /*
        //         The following example shows how to read all bytes from a file manually and 
        //         then convert them to a string using UTF8 encoding:
        //     */
            
        //     // Create an object of the FileInfo class with a specified file path           
        //     FileInfo txtFile = new (@"C:fileInfoFile.txt");
        //     Console.WriteLine($"txtFile == {txtFile}.\n");

        //     // Add a text in the fileInfo file with a StreamWriter
        //     // using(StreamWriter sw = fileInfo.AppendText())
        //     // {
        //     //     Console.WriteLine($"sw == {sw}.");
                
        //     //     for(int line = 0; line < 10; line++)
        //     //     {
        //     //         sw.WriteLine($"Line {line+1}.");
        //     //     }
        //     // }
            
        //     // Open file for Read-Write
        //     FileStream fileStream = txtFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite); 
        //     Console.WriteLine($"fileStream == {fileStream}.");
        //     Console.WriteLine($"fileStream.Length == {fileStream.Length} bytes.\n");

        //     // Create byte array of same size as FileStream length
        //     byte[] fileBytes = new byte[fileStream.Length];
        //     Console.WriteLine($"fileBytes == {fileBytes}.");

        //     // Define a counter to check how many bytes are there to read. 
        //     // Decrease the counter as each byte is being read
        //     int numBytesToRead = (int) fileBytes.Length;
        //     Console.WriteLine($"numBytesToRead == {numBytesToRead}.\n");

        //     // Counter to indicate number of bytes already read
        //     int numBytesAlreadyRead = 0;

        //     // As long as there are bytes to read from the file
        //     do
        //     {
        //         // Number of bytes already read
        //         int bytes = fileStream.Read(fileBytes, numBytesAlreadyRead, numBytesToRead);
        //         Console.WriteLine($"bytes == {bytes}.");

        //         // Increase the number of bytes already read
        //         numBytesAlreadyRead += bytes;
        //         Console.WriteLine($"numBytesAlreadyRead == {numBytesAlreadyRead}.");

        //         // Decrease the number of bytes left to read
        //         numBytesToRead -= bytes;
        //         Console.WriteLine($"numBytesToRead == {numBytesToRead}.");
        //     } while(numBytesToRead > 0);

        //     // Once all bytes are read, we convert the byte[] to a string using UTF-8 encoding
        //     string? fileString = Encoding.UTF8.GetString(fileBytes);
        //     Console.WriteLine($"fileString == {fileString}");

        //     /*
        //         As you have seen in the above code, you have to write lot of code for 
        //         reading/writing a string from a FileSream. The same read/write operation can 
        //         be done easily using StreamReader and StreamWriter.

        //         The following example shows how StreamReader makes it easy to read strings 
        //         from a file:
        //     */

            
        //     // Create an object of the FileInfo class           
        //     FileInfo txtFile2 = new(@"C:txtFile2.txt");
        //     Console.WriteLine($"txtFile2 == {txtFile2}.");

        //     // Write content  to the newly made file
        //     // using(StreamWriter sw = txtFile2.AppendText())
        //     // {
        //     //     for(int line = 0; line < 3; line++)
        //     //     {
        //     //         sw.WriteLine($"txtFile2 line {line+1}.");
        //     //     }
        //     // }
                    
        //     // Open the file for ReadWrite
        //     FileStream fileStream2 = txtFile2.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read); 
        //     Console.WriteLine($"fileStream2 == {fileStream2}.");

        //     /* 
        //         Create an object of the StreamReader class by passing the FileStream object on 
        //         which it needs to operates on
        //     */
        //     StreamReader streamReader = new(fileStream2);
        //     Console.WriteLine($"streamReader == {streamReader}.");

        //     //Use the ReadToEnd method to read the whole file's content
        //     string? fileContent = streamReader.ReadToEnd();
        //     Console.WriteLine($"fileContent == {fileContent}");

        //     //Close StreamReader object after operation
        //     streamReader.Close();
        //     fileStream2.Close();

        //     /*
        //         Notice that fi.Open() has three parameters: The first parameter is FileMode 
        //         for creating and opening a file if it does not exist; the second parameter, 
        //         FileAccess, is to indicate a Read operation; and the third parameter is to 
        //         share the file for reading with other users while the file is open.

        //         The following example shows how StreamWriter makes it easy to write strings 
        //         to a File:
        //     */

            
        //     // Create an object of the FileInfo class         
        //     FileInfo txtFile3 = new(@"C:txtFile3.txt");
                    
        //     // Open the file for ReadWrite
        //     FileStream fileStream3 = txtFile3.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite); 

        //     // Create a StreamWriter object to write strings to the FileSream object
        //     StreamWriter streamWriter3 = new(fileStream3);
        //     streamWriter3.WriteLine("Line from streamWriter.");

        //     // Creating a stream reader to read the content of the file
        //     StreamReader streamReader3 = new(fileStream3);
        //     string? txtFile3Content = streamReader3.ReadToEnd();

        //     Console.WriteLine($"txtFile3Content == {txtFile3Content}");

        //     /*  Close the stream only after all operations are done
        //         Closing the streamWriter also closes the streamReader and fileStream
        //     */
        //     streamWriter3.Close();

        //     /*
        //         Read and Write operations are not possible on the same FileStream object 
        //         simultaneously. 
        //         If you are already reading from a file, create a separate FileStream object 
        //         to write to the same file, as shown below:
        //     */

            
        //     // Create a text file
        //     FileInfo txtFile4 = new (@"C:txtFile4.txt");

        //     // Open txtFile4.txt for read and write operation
        //     FileStream fileStream4RW = txtFile4.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite); 

        //     // Write text to txtFile4.txt using the newly made StreamWriter object
        //     using(StreamWriter streamWriter4 = txtFile4.AppendText())
        //     {
        //         for(int line = 0; line < 3; line++)
        //         {
        //             streamWriter4.WriteLine($"Line {line+1}.");
        //         }
        //     }

        //     // Create a streamReader object
        //     StreamReader streamReader4 = new (fileStream4RW);

        //     // Read the content of txtFile4.txt using the StreamReader object
        //     string? txtFile4Content = streamReader4.ReadToEnd();
        //     Console.WriteLine($"txtFile4Content == {txtFile4Content}");

        //     // Close all Stream objects
        //     fileStream4RW.Close();
        //     fileStream4RW.Close();

        //     /*
        //         Thus you can use FileInfo, StreamReader and StreamWriter class to read/write 
        //         contents from physical file.
        //     */
        // }
    }
}