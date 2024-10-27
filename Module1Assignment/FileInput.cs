namespace Module1Assignment;

public class FileInput
{
    private StreamReader? _inStream;
    private readonly string _fileName;
    
    public FileInput(string fileName)
    {
        this._fileName = fileName;
        try
        {
            _inStream = new StreamReader(this._fileName);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + ex);
        }
    }
    
    public void FileRead()
    {
        string line;
        try
        {
            while ((line = _inStream.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("File Write Error: " + _fileName + " " + ex);
        }
    }
    
    public string FileReadLine()
    {
        try
        {
            return _inStream.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("File Write Error: " + _fileName + " " + ex);
            return null;
        }
    }
    
    public void FileClose()
    {
        if (_inStream != null)
        {
            try
            {
                _inStream.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}