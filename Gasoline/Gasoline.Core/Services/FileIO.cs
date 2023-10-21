using Gasoline.Core.Interfaces;
using System.Text;

namespace Gasoline.Core.Services
{
    public class FileIO : IFileIO
    {
        protected string _path;

        public FileIO(string path)
        {
            _path = path;
        }
        public string Read()
        {
            if (File.Exists(_path) == false)
                throw new FileNotFoundException($"{_path} not found");

            using(var sr = new StreamReader(_path))
            {
                return sr.ReadToEnd();
            }
        }

        public async Task<string> ReadAsync()
        {
            if (File.Exists(_path) == false)
                throw new FileNotFoundException($"{_path} not found");
            
            using(var sr = new StreamReader(_path))
                return await sr.ReadToEndAsync();
        }

        public void Write(string json)
        {
            using(var sw = new StreamWriter(_path, false, Encoding.UTF8))
                sw.Write(json);
        }

        public async Task WriteAsync(string json)
        {
            using(var sw = new StreamWriter(_path, false, Encoding.UTF8))
                await sw.WriteAsync(json);
        }
    }
}
