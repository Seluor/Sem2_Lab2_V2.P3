using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DocumentMenu
{
    // Singleton pattern implementation
    public sealed class DocumentManager
    {
        private static readonly DocumentManager instance = new DocumentManager();
        private List<Document> documents = new List<Document>();

        private DocumentManager() { }

        public static DocumentManager Instance
        {
            get { return instance; }
        }

        public void AddDocument(Document doc)
        {
            documents.Add(doc);
        }

        public void RemoveDocument(Document doc)
        {
            documents.Remove(doc);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. Add Document");
            Console.WriteLine("2. Remove Document");
            Console.WriteLine("3. List All Documents");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddDocumentMenu();
                    break;
                case "2":
                    RemoveDocumentMenu();
                    break;
                case "3":
                    ListAllDocumentsMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            DisplayMenu();
        }

        private void AddDocumentMenu()
        {
            Console.WriteLine("Enter the name of the document:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the author of the document:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the keywords of the document (comma-separated):");
            string[] keywords = Console.ReadLine().Split(',');

            Console.WriteLine("Enter the subject of the document:");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter the file path of the document:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Select the type of document:");
            Console.WriteLine("1. MS Word");
            Console.WriteLine("2. PDF");
            Console.WriteLine("3. MS Excel");
            Console.WriteLine("4. TXT");
            Console.WriteLine("5. HTML");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    documents.Add(new MSWordDocument(name, author, keywords, subject, filePath));
                    break;
                case "2":
                    documents.Add(new PDFDocument(name, author, keywords, subject, filePath));
                    break;
                case "3":
                    documents.Add(new MSExcelDocument(name, author, keywords, subject, filePath));
                    break;
                case "4":
                    documents.Add(new TXTDocument(name, author, keywords, subject, filePath));
                    break;
                case "5":
                    documents.Add(new HTMLDocument(name, author, keywords, subject, filePath));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private void RemoveDocumentMenu()
        {
            Console.WriteLine("Enter the name of the document you want to remove:");
            string name = Console.ReadLine();

            Document doc = documents.Find(d => d.Name == name);
            if (doc != null)
            {
                documents.Remove(doc);
                Console.WriteLine("Document removed.");
            }
            else
            {
                Console.WriteLine("Document not found.");
            }
        }

        private void ListAllDocumentsMenu()
        {
            Console.WriteLine("List of documents:");

            foreach (Document doc in documents)
            {
                Console.WriteLine(doc.GetInfo());
            }
        }
    }

    public abstract class Document
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string[] Keywords { get; set; }
        public string Subject { get; set; }
        public string FilePath { get; set; }

        public Document(string name, string author, string[] keywords, string subject, string filePath)
        {
            Name = name;
            Author = author;
            Keywords = keywords;
            Subject = subject;
            FilePath = filePath;
        }
        public abstract string GetInfo();
    }

    public class MSWordDocument : Document
    {
        public MSWordDocument(string name, string author, string[] keywords, string subject, string filePath)
            : base(name, author, keywords, subject, filePath)
        {
        }

        public override string GetInfo()
        {
            return $"MS Word Document: {Name}, by {Author}, Keywords: {string.Join(",", Keywords)}, Subject: {Subject}, File Path: {FilePath}";
        }
    }

    public class PDFDocument : Document
    {
        public PDFDocument(string name, string author, string[] keywords, string subject, string filePath)
            : base(name, author, keywords, subject, filePath)
        {
        }

        public override string GetInfo()
        {
            return $"PDF Document: {Name}, by {Author}, Keywords: {string.Join(",", Keywords)}, Subject: {Subject}, File Path: {FilePath}";
        }
    }

    public class MSExcelDocument : Document
    {
        public MSExcelDocument(string name, string author, string[] keywords, string subject, string filePath)
            : base(name, author, keywords, subject, filePath)
        {
        }

        public override string GetInfo()
        {
            return $"MS Excel Document: {Name}, by {Author}, Keywords: {string.Join(",", Keywords)}, Subject: {Subject}, File Path: {FilePath}";
        }
    }

    public class TXTDocument : Document
    {
        public TXTDocument(string name, string author, string[] keywords, string subject, string filePath)
            : base(name, author, keywords, subject, filePath)
        {
        }

        public override string GetInfo()
        {
            return $"TXT Document: {Name}, by {Author}, Keywords: {string.Join(",", Keywords)}, Subject: {Subject}, File Path: {FilePath}";
        }
    }

    public class HTMLDocument : Document
    {
        public HTMLDocument(string name, string author, string[] keywords, string subject, string filePath)
            : base(name, author, keywords, subject, filePath)
        {
        }

        public override string GetInfo()
        {
            return $"HTML Document: {Name}, by {Author}, Keywords: {string.Join(",", Keywords)}, Subject: {Subject}, File Path: {FilePath}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager docManager = DocumentManager.Instance;
            docManager.DisplayMenu();
        }
    }
}