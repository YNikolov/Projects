using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesForum.Common
{
    public interface IRandomStrGenerator
    {
        string RandomString(int minLength, int maxLength);

        int RandomNumber(int min, int max);
    }
}
