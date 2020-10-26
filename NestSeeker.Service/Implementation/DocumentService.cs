using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class DocumentService : IDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DocumentService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }
        public Document AddDocument(Document document)
        {
            this._unitOfWork.DocumentRepository.Add(document);
            this._unitOfWork.Save();
            return document;
        }

        public IEnumerable<Document> GetAllDocuments()
        {
            return this._unitOfWork.DocumentRepository.GetAll();
        }

        public Document GetById(int id)
        {
            return this._unitOfWork.DocumentRepository.GetById(id);
        }
    }
}
