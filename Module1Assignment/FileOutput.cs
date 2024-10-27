namespace Module1Assignment;

using System.IO;

public class FileOutput
{
    private StreamWriter? _outStream;
    private readonly string _fileName;

    public FileOutput(string fileName)
    {
        this._fileName = fileName;
        try
        {
            _outStream = new StreamWriter(this._fileName);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + ex);
        }
    }
    
    public void FileWrite(string line)
    {
        try
        {
            _outStream.WriteLine(line);
        }
        catch (Exception ex)
        {
            Console.WriteLine("File Write Error: " + _fileName + " " + ex);
        }
    }
    
    public void FileClose()
    {
        if (_outStream != null)
        {
            try
            {
                _outStream.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}