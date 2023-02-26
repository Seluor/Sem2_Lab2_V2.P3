namespace BasicFile
{
    public class MSExcelDocument : BasicDocument
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; }
        public string PathToFile { get; set; }

        public string TestInfo1 { get; set; }
        public string TestInfo2 { get; set; }
        public string TestInfo3 { get; set; }


        public override void PrintValues()
        {
            Console.WriteLine($"TestInfo1: {TestInfo1}\nTestInfo2: {TestInfo2}\nTestInfo3: {TestInfo3}");
            Console.ReadKey();
        }

    }
    public class HTML : BasicDocument
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; }
        public string PathToFile { get; set; }

        public string TestInfo4 { get; set; }
        public string TestInfo5 { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"TestInfo4: {TestInfo4}\nTestInfo5: {TestInfo5}");
            Console.ReadKey();
        }
    }
    public class PDF : BasicDocument
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; }
        public string PathToFile { get; set; }

        public string TestInfo6 { get; set; }
        public string TestInfo7 { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"TestInfo6: {TestInfo6}\nTestInfo7: {TestInfo7}");
            Console.ReadKey();
        }
    }
    public class TXT : BasicDocument
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; }
        public string PathToFile { get; set; }

        public string TestInfo8 { get; set; }
        public string TestInfo9 { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"TestInfo8: {TestInfo8}\nTestInfo9: {TestInfo9}");
            Console.ReadKey();
        }
    }
    public class Word : BasicDocument
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string[] KeyWords { get; set; }
        public string Theme { get; set; }
        public string PathToFile { get; set; }

        public string TestInfo10 { get; set; }
        public string TestInfo11 { get; set; }
        public string TestInfo12 { get; set; }

        public override void PrintValues()
        {
            Console.WriteLine($"TestInfo10: {TestInfo10}\nTestInfo11: {TestInfo11}\nTestInfo12: {TestInfo12}");
            Console.ReadKey();
        }
    }

}