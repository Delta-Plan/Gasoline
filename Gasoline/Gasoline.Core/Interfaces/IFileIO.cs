namespace Gasoline.Core.Interfaces
{
    internal interface IFileIO
    {
        public void Write(string json);
        public string Read();

        public Task WriteAsync(string json);
        public Task<string> ReadAsync();
    }
}
