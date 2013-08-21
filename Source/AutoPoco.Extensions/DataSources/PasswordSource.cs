using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class PasswordSource : DatasourceBase<string>
    {
        private static readonly char[] _vowels = { 'a', 'e', 'i', 'o', 'u' };
        private static readonly char[] _consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v' };
        private static readonly char[] _doubleConsonants = { 'c', 'd', 'f', 'g', 'l', 'm', 'n', 'p', 'r', 's', 't' };
        private static readonly Random _random = new Random();

        private readonly int _length;

        public PasswordSource()
            : this(8)
        {
        }

        public PasswordSource(int length)
        {
            _length = length;
        }

        public override string Next(IGenerationContext context)
        {
            return Generate(_length);
        }

        public static string Generate(int passwordLength)
        {
            bool wroteConsonant = false;
            int counter;
            var password = new StringBuilder();

            for (counter = 0; counter <= passwordLength; counter++)
            {
                if (password.Length > 0 & (wroteConsonant == false) & (_random.Next(100) < 10))
                {
                    password.Append(_doubleConsonants[_random.Next(_doubleConsonants.Length)], 2);
                    counter += 1;
                    wroteConsonant = true;
                }
                else
                {
                    if ((wroteConsonant == false) & (_random.Next(100) < 90))
                    {
                        password.Append(_consonants[_random.Next(_consonants.Length)]);
                        wroteConsonant = true;
                    }
                    else
                    {
                        password.Append(_vowels[_random.Next(_vowels.Length)]);
                        wroteConsonant = false;
                    }
                }
            }

            password.Length = passwordLength;
            return password.ToString();
        }

    }
}
