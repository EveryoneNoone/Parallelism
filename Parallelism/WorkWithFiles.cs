using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelism
{
    internal class WorkWithFiles
    {
        public List<Task<int>> GetDirectoryFiles(string path)
        {
            var files = Directory.GetFiles(path, "*.txt");
            var tasks = files.Select(FileCountWhiteSpace);
            return tasks.ToList();
        }

        public async Task<int> FileCountWhiteSpace(string path)
        {
            string fileContent = await File.ReadAllTextAsync(path);
            var whitespaceCount = fileContent.Count(char.IsWhiteSpace);
            return whitespaceCount;
        }
    }
}
