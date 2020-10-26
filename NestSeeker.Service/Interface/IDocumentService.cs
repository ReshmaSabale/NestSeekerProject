using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface IDocumentService
    {
        IEnumerable<Document> GetAllDocuments();

        Document GetById(int id);
        Document AddDocument(Document document);
    }
}
