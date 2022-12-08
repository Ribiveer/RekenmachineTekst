
char[] goodChars = { 'O', 'E', 'Z', 'I', 'G', 'S', 'H', 'B', 'L' };

using(FileStream file = new FileStream("woorden.txt", FileMode.Open))
{

    using (StreamReader read = new StreamReader(file))
    {
        string? lineN;
        while((lineN = read.ReadLine()) != null)
        {
            bool usedAp = false;
            string line = (string)lineN;
            line = line.ToUpper();
            bool goodn = true;
            for(int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                bool anyGoodChar = false;
                foreach(char g in goodChars)
                {
                    if (c == g)
                        anyGoodChar = true;
                }
                if(c == '\'')
                {
                    if (!usedAp)
                    {
                        anyGoodChar = true;
                        usedAp = true;
                    }
                }
                if (!anyGoodChar)
                    goodn = false;
            }
            if(goodn)
                Console.WriteLine(line);
        }
    }
}