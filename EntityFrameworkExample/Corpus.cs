using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Corpus
    {
        public int Id { get; set; }
        public virtual ISet<Document> Documents { get; set; }

        public Corpus()
        {
            Documents = new HashSet<Document>();
        }
    }
}
