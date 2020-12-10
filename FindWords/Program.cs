using System;

namespace FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Почтальон! Почтальон\' Печкин \"почта";
            char[] ar = { ',', '.', ':', ';', '?', '!','-','\"', '\'', ' '};
            text = text.ToLower().Trim();
            char[] text_ch = text.ToCharArray();
            for (int i = 0; i <text_ch.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if (text_ch[i] == ar[j])
                        text_ch[i] = '1';
                }
            }
            //text = null;
            //foreach (char i in text_ch)
            //    text += i;
            //Console.WriteLine(text);

        }
    }
}
