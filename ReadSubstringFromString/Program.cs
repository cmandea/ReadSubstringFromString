namespace ReadSubstringFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = CheckString(1);
            string text2 = CheckString(2);

            Console.WriteLine("Sirul 1 este:" + text1);
            Console.WriteLine("Sirul 2 este:" + text2);

            //am verificat sirurile sa nu fie null > fac verific de cate ori apare sirul1 in sirul 2
            if (text2.Contains(text1,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Sirul 2 '{text2}' contine sirul '{text1}'");
            }
            else
            {
                Console.WriteLine($"Sirul 2 '{text2}' NU contine sirul '{text1}'");
            }

            //splituiesc sirul2 dupa sirul1 si voi obtine dimensiunea array --> nr de splituiri=dimensiunearray-1
            string[] textArray = text2.Split(text1);
            int numberofAppears = textArray.Length - 1;

            Console.WriteLine($"'{text1}' apare de {numberofAppears} ori in sirul '{text2}' :");
                    

        }

        static string CheckString(int nrString) //verific daca stringul este null ----
        {
            Console.Write("Please enter a string" + nrString + ":");
            string strText = Console.ReadLine();
            bool isValidString = string.IsNullOrWhiteSpace(strText);
            while (isValidString)
            {
                if (string.IsNullOrWhiteSpace(strText))
                {
                    Console.WriteLine("Please enter a string" + nrString + " not null:");
                    strText = Console.ReadLine();
                    isValidString = string.IsNullOrWhiteSpace(strText);
                 
                }
                else
                {
                    isValidString = string.IsNullOrWhiteSpace(strText);
                   
                }
            }
            return strText;

        }
    }
}