namespace BasicFile
{
    internal class Program
    {
        private static void DocumentOutput(BasicDocument basicFile )
        {
            basicFile.PrintValues();
        }
        static void Main(string[] args)
        {
            BasicDocument Information = new BasicDocument
            {
                Name = "Name",
                Authors = "Authors",
                Theme = "Theme",
                PathToFile = "C\\PathToFile\\Name",
                KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
            };
            /**/
            Console.WriteLine("This is a Basic information of documents");
            DocumentOutput(Information);
            /**/
            Console.WriteLine("Enter a number of File: ");
            Console.WriteLine("1. MSWord\n2. PDF\n3. MS MSExcel\n4. TXT\n5. HTML");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BasicDocument InformationWord = new Word
                    {
                        Name = "Name",
                        Authors = "Authors",
                        Theme = "Theme",
                        PathToFile = "C\\PathToFile\\Name.word",
                        KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
                        TestInfo10 = "TestInfo10",
                        TestInfo11 = "TestInfo11",
                        TestInfo12 = "TestInfo12"
                    };
                    DocumentOutput(InformationWord);
                    break;
                case "2":
                    BasicDocument InformationPDF = new PDF
                    {
                        Name = "Name",
                        Authors = "Authors",
                        Theme = "Theme",
                        PathToFile = "C\\PathToFile\\Name.pdf",
                        KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
                        TestInfo6 = "TestInfo6",
                        TestInfo7 = "TestInfo7"
                    };
                    DocumentOutput(InformationPDF);
                    break;
                case "3":
                    BasicDocument InformationExcel = new MSExcelDocument
                    {
                        Name = "Name",
                        Authors = "Authors",
                        Theme = "Theme",
                        PathToFile = "C\\PathToFile\\Name.xlx",
                        KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
                        TestInfo1 = "TestInfo1",
                        TestInfo2 = "TestInfo2",
                        TestInfo3 = "TestInfo3",
                    };
                    DocumentOutput(InformationExcel);
                    break;
                case "4":
                    BasicDocument InformationTXT = new TXT
                    {
                        Name = "Name",
                        Authors = "Authors",
                        Theme = "Theme",
                        PathToFile = "C\\PathToFile\\Name.txt",
                        KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
                        TestInfo8 = "TestInfo8",
                        TestInfo9 = "TestInfo9",
                    };
                    DocumentOutput(InformationTXT);
                    break;
                case "5":
                    BasicDocument InformationHTML = new HTML
                    {
                        Name = "Name",
                        Authors = "Authors",
                        Theme = "Theme",
                        PathToFile = "C\\PathToFile\\Name.thml",
                        KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
                        TestInfo4 = "TestInfo4",
                        TestInfo5 = "TestInfo5",
                    };
                    DocumentOutput(InformationHTML);
                    break;
                default:
                    Console.WriteLine("Document not Found.");
                    break;
            }
        }
    }
}