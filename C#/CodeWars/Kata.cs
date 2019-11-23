using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class Kata
    {
        public static string Rot13(string input)
        {
            var output = "";
            for(int i = 0; i < input.Length; i++) {
                char current = input[i];
                
                var diff = current == char.ToLower(current) ? (current - 'a') : (current - 'A');
                if (diff >= 26 || diff < 0) {
                    output += current;
                } else if (diff >= 13) {
                    current = (char)(current - 13);
                    output += current;
                } else {
                    current = (char)(current + 13);
                    output += current;
                }
            }
            return output;
        }
    }
}
