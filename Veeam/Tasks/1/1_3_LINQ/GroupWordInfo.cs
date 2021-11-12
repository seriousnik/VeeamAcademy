using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_3_LINQ
{
    public class GroupWordInfo
    {
        public int GroupNumber { get; set; }
        public int WordLength { get; set; }
        public int WordNumber { get => Words?.Count() ?? 0; }
        public IEnumerable<string> Words { get; set; }
        public override string ToString()
        {
            return $"Группа {GroupNumber}. Длина {WordLength}. Количество {WordNumber}.\n" +
                $"{string.Join("\n", Words)}\n";
        }
    }
}
