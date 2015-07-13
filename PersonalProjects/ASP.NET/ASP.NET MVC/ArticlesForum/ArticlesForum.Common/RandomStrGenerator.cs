namespace ArticlesForum.Common
{
    using System;
    using System.Text;

    public class RandomStrGenerator : IRandomStrGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUWXVYZabcdefghijklmnopqrstuwxvyz";
        
        private Random random;
        
        public RandomStrGenerator()
        {
            this.random = new Random();
        }

        public string RandomString(int minLength, int maxLength)
        {
            var randomStr = new StringBuilder();
            var stringLength = this.random.Next(minLength, maxLength + 1);
            for (int i = 0; i <= stringLength; i++)
            {
                randomStr.Append(Letters[this.random.Next(0, Letters.Length)]);
            }

            return randomStr.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }
    }
}
