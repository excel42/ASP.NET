using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;

namespace Application.Models
{
    public class DocumentActs
    {
        public List<Document> GetDocuments()
        {
            DocumentData documentData = new DocumentData();

            var documents = documentData.Douments;

            return documents;
        }
    }
}