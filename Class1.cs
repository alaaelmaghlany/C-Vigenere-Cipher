using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_Cipher_11
{
    class Class1
    {
        static string alpha = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
        static string output = null;
        static char[] letter = alpha.ToCharArray();

        static char[] input = null;
        static int res = 0;

        public static int getKey(string Key)
        {
            int r = 0;
            input=Key.ToUpper().ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (input[j] == letter[i])
                    {
                        r = 1;
                    }
                }
            }
            return r;
        }
        public static string Encription(string plain_Text, int key)
        {
            input = plain_Text.ToUpper().ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (input[j] == letter[i])
                    {
                        input[j] = letter[(i + key) % letter.Length];
                        break;
                    }
                }
            }
            output = new string(input);
                return output;

        }
        public static string Dencription(string cipher_Text, int key)
        {
            input = cipher_Text.ToUpper().ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (input[j] == letter[i])
                    {
                        res = (i - key + letter.Length);
                        input[j] = letter[res % letter.Length];
                        break;
                    }
                }
            }
            output = new string(input);
            return output;

        }

    }    
        



