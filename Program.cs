using System;

/* 11
Даны два слова. Для каждой буквы первого слова определить, входит ли она во второе слово. 
Повторяющиеся буквы первого слова не рассматривать. 

Например, если заданные слова процессор и информация, 
то для букв первого из них ответом должно быть: нет да да да нет нет. 
*/


namespace FirstLAB3ex
{
    public class Logic
    {

        private string first;
        private string second;

        public Logic(string ln1, string ln2)
        {
            first = ln1;
            second = ln2;

            first = deleteSimilar(first);
            second = deleteSimilar(second);
        }


        private string deleteSimilar(string line)
        {
            string ans = "";

            for (int i = 0; i < line.Length; i++)
            {
                bool inLine = false;

                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[i] == line[j])
                    {
                        inLine = true;
                        break;
                    }
                }

                if (inLine == false)
                {
                    ans += line[i];
                }
            }

            return ans;
        }

        public string search()
        {
            string ans = "";

            for (int i = 0; i < first.Length; i++)
            {
                bool included = false;

                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        included = true;
                        break;
                    }
                }

                ans += check(included);
            }

            return ans;
        }

        public string check(bool expression)
        {
            if (expression) return "да ";
            else return "нет ";
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите порвое слово: ");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Введите второе слово: ");
            string secondWord = Console.ReadLine();

            Logic ans = new Logic(firstWord, secondWord);
            string answer = ans.search();

            Console.WriteLine(answer);

        }
    }
}
