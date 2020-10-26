using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    class MyFavouriteService : IMyFavouriteService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MyFavouriteService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }

        public MyFavourites AddFavourite(MyFavourites myFavourites)
        {
            this._unitOfWork.MyFavouritesRepository.Add(myFavourites);
            this._unitOfWork.Save();
            return myFavourites;
        }

        public IEnumerable<MyFavourites> GetAllMyFavourites()
        {
            return this._unitOfWork.MyFavouritesRepository.GetAll();
        }

        public MyFavourites GetById(int id)
        {
            return this._unitOfWork.MyFavouritesRepository.GetById(id);
        }
    }
}
