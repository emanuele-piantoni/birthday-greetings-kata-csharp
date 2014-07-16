using System.Collections.Generic;

namespace BirthdayGreetings
{
    public class FileService : IFileService
    {
        private readonly string _filename;

        public FileService(string filename)
        {
            _filename = filename;
        }

        public IEnumerable<string> GetLines()
        {
            var result = new List<string>();

            var input = new System.IO.StreamReader(_filename);
            var str = input.ReadLine(); // skip header

            while ((str = input.ReadLine()) != null)
            {
                result.Add(str);
            }

            return result;
        }


    }
}