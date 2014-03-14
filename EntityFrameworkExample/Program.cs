using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. In App.config define connection string.
            // 2. In DataContext specify this connection string in the constructor as a parameter to the implicit one.
            // 3. Define models == database tables in Document.cs and Corpus.cs.
            // 4. Run.

            var doc1 = new Document { Content = "this is my doc" };
            var doc2 = new Document { Content = "this is my doc 2" };
            var doc3 = new Document { Content = "this is my doc 3" };

            var corpus1 = new Corpus();
            corpus1.Documents.Add(doc1);
            corpus1.Documents.Add(doc2);

            var corpus2 = new Corpus();
            corpus2.Documents.Add(doc3);            

            var context = new DataContext();
            context.Corpora.Add(corpus1);
            context.Corpora.Add(corpus2);
            context.SaveChanges();  // Note that we didn't have to explicitely add the individual documents.

            Console.WriteLine(doc1.Id);
            Console.WriteLine(corpus2.Id);

            Console.ReadLine();
        }
    }
}
