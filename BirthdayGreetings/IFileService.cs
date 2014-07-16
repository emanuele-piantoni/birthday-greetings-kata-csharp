using System.Collections.Generic;

namespace BirthdayGreetings
{
    public interface IFileService
    {
        IEnumerable<string> GetLines();
    }
}