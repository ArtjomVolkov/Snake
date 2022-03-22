using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    public class Media
    {
        private string resourcesFoler;
        public Media()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal); // Получить индекс папки bin
            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                .ToString();
            resourcesFoler = binFolder + "resources\\"; // путь до указанной в инкесе папки
        }
        public string GetResourceFolder()
        {
            return resourcesFoler;
        }
    }
}
