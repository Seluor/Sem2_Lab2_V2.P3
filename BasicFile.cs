namespace BasicFile
{
    public class BasicDocument
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; }
        public string PathToFile { get; set; }

        public virtual void PrintValues()
        {
            string str = "";

            for (int index = 0; index < KeyWords.Length; ++index)
            {
                if (KeyWords[index] != "")
                {
                    str += KeyWords[index];
                }
            }

            Console.WriteLine($"Name: {Name}\nAuthors: {Authors}\nKeyWords: {str}\nTheme: {Theme}\nPathToFile: {PathToFile}");
            Console.ReadKey();
        }
    }
}