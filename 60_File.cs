// 60. FILE

namespace Lesson60
{
    class Program60
    {
        // public static void Main()
        // {
        //     /*
        //         C# provides the following classes to work with the File system. 
        //         They can be used to access directories, access files, open files for reading 
        //         or writing, create a new file or move existing files from one location to 
        //         another, etc.
        //     */
            
        //     /*
        //         Class Name	    Usage
        //         File	        File is a static class that provides different 
        //                         functionalities like copy, create, move, delete, open for 
        //                         reading or /writing, encrypt or decrypt, check if a file 
        //                         exists, append lines or text to a file's content, get last
        //                         access time, etc.
        //         .
        //         FileInfo	    The FileInfo class provides the same functionality as a 
        //                         static File class. You have more control on how you do 
        //                         read/write operations on a file by writing code manually for 
        //                         reading or writing bytes from a file.

        //         Directory	    Directory is a static class that provides functionality for 
        //                         creating, moving, deleting and accessing subdirectories.

        //         DirectoryInfo	DirectoryInfo provides instance methods for creating, moving, 
        //                         deleting and accessing subdirectories.

        //         Path	        Path is a static class that provides functionality such as 
        //                         retrieving the extension of a file, changing the extension of 
        //                         a file, retrieving the absolute physical path, and other path 
        //                         related functionalities.
        //     */

        //     /*
        //         FILE

        //         C# includes static File class to perform I/O operation on physical file system. 
        //         The static File class includes various utility method to interact with 
        //         physical file of any type e.g. binary, text etc.

        //         Use this static File class to perform some quick operation on physical file. 
        //         It is not recommended to use File class for multiple operations on multiple 
        //         files at the same time due to performance reasons. Use FileInfo class in that 
        //         scenario.
        //     */

        //     /*
        //         IMPORTANT METHODS OF THE STATIC FILE CLASS

        //         Method	            Usage
        //         AppendAllLines	    Appends lines to a file, and then closes the file. 
        //                             If the specified file does not exist, this method creates 
        //                             a file, writes the specified lines to the file, and then 
        //                             closes the file.

        //         AppendAllText	    Opens a file, appends the specified string to the file, 
        //                             and then closes the file. If the file does not exist, 
        //                             this method creates a file, writes the specified string 
        //                             to the file, then closes the file.

        //         AppendText	        Creates a StreamWriter that appends UTF-8 encoded text to 
        //                             an existing file, or to a new file if the specified file 
        //                             does not exist.

        //         Copy	            Copies an existing file to a new file. Overwriting a file 
        //                             of the same name is not allowed.

        //         Create	            Creates or overwrites a file in the specified path.

        //         CreateText	        Creates or opens a file for writing UTF-8 encoded text.

        //         Decrypt	            Decrypts a file that was encrypted by the current account 
        //                             using the Encrypt method.

        //         Delete	            Deletes the specified file.

        //         Encrypt	            Encrypts a file so that only the account used to encrypt 
        //                             the file can decrypt it.

        //         Exists	            Determines whether the specified file exists.

        //         GetAccessControl    Gets a FileSecurity object that encapsulates the access 
        //                             control list (ACL) entries for a specified file.

        //         Move	            Moves a specified file to a new location, providing the 
        //                             option to specify a new file name.

        //         Open	            Opens a FileStream on the specified path with read/write 
        //                             access.

        //         ReadAllBytes	    Opens a binary file, reads the contents of the file into 
        //                             a byte array, and then closes the file.

        //         ReadAllLines	    Opens a text file, reads all lines of the file, and then 
        //                             closes the file.

        //         ReadAllText	        Opens a text file, reads all lines of the file, and then 
        //                             closes the file.

        //         Replace	            Replaces the contents of a specified file with the 
        //                             contents of another file, deleting the original file, and 
        //                             creating a backup of the replaced file.

        //         WriteAllBytes	    Creates a new file, writes the specified byte array to 
        //                             the file, and then closes the file. If the target file 
        //                             already exists, it is overwritten.

        //         WriteAllLines	    Creates a new file, writes a collection of strings to the 
        //                             file, and then closes the file.

        //         WriteAllText	    Creates a new file, writes the specified string to the 
        //                             file, and then closes the file. If the target file 
        //                             already exists, it is overwritten.
        //     */

        //     /*
        //         APPEND TEXT LINES

        //         Use AppendAllLines() method to append multiple text lines to the specified 
        //         file as shown below.
        //     */

        //     string testLines = "First line.\nSecond line.\nThird line.\n";

        //     /* 
        //         Opens testFile.txt and append lines to it. 
        //         If the file does not exist, one is created and opened.
        //     */
        //     File.AppendAllLines(@"C:testFile.txt", testLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());

        //     /*
        //         APPEND STRING

        //         Use File.AppendAllText() method to append string to a file in single line of 
        //         code as shown below.
        //     */

        //     /* 
        //         Opens testFile2.txt and appends text to it. 
        //         If the file does not exist, one is created and opened.
        //     */
        //     File.AppendAllText(@"C: testFile2.txt", "This is File testing.");

        //     /*
        //         The following example shows how to perform different operations using the 
        //         static File class.
        //     */

        //     // Checks whether the file exists or not at a location
        //     bool doesFileExists = File.Exists(@"C:testFile.txt");
        //     Console.WriteLine($"doesFileExists == {doesFileExists}.");

        //     // Copy testFile.txt as new file testFileCopy.txt
        //     File.Copy(@"C:testFile.txt", @"C:testFileCopy2.txt");

        //     // // Get when the file was last accessed
        //     DateTime lastAccessTime = File.GetLastAccessTime(@"C:testFile.txt");
        //     Console.WriteLine($"lastAccessTime == {lastAccessTime.ToLocalTime()}.");

        //     // // Get when the file was last written
        //     DateTime lastWriteTime = File.GetLastWriteTime(@"C:testFile.txt");
        //     Console.WriteLine($"lastWriteTime == {lastWriteTime}.");

        //     string? startPath = "C:\\Users\\maxym\\Documents\\VisualStudioCode\\C#\\Lessons\\testFile.txt";
        //     string? destPath = "C:\\Users\\maxym\\Documents\\VisualStudioCode\\C#\\Lessons\\FileStorage\\testFile2.txt";

        //     //Delete file
        //     if(File.Exists(destPath))
        //     {
        //         File.Delete(destPath);
        //     }

        //     else
        //     {
        //         Console.WriteLine("Cannot delete non-existing file testFile2.txt.");
        //     }
            
        //     // Move file to a new location
        //     File.Move(startPath, destPath);

        //     // Open a file and returns FileStream for reading bytes from the file
        //     FileStream fileStream = File.Open(startPath, FileMode.OpenOrCreate);
        //     Console.WriteLine($"fileStream == {fileStream}.");

        //     //Open file and return StreamReader for reading string from the file
        //     StreamReader streamReader = File.OpenText(startPath);
        //     Console.WriteLine($"streamReader == {streamReader}.");
                
        //     //Delete file
        //     if(File.Exists(destPath))
        //     {
        //         File.Delete(destPath);
        //     }

        //     else
        //     {
        //         Console.WriteLine("Cannot delete non-existing file testFile2.txt.");
        //     }

        //     /*
        //         Thus, it is easy to work with physical file using static File class. 
        //         However, if you want more flexibility then use FileInfo class. 
        //         Likewise, use static Directory class to work with physical directories.
        //     */
        // }
    }
}