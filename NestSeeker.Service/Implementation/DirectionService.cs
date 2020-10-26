using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class DirectionService : IDirectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DirectionService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }

        public Direction AddDirection(Direction direction)
        {
            this._unitOfWork.DirectionRepository.Add(direction);
            this._unitOfWork.Save();
            return direction;

        }

        public IEnumerable<Direction> GetAllDirection()
        {
            return this._unitOfWork.DirectionRepository.GetAll();
        }

        public Direction GetById(int id)
        {
            //throw new NotImplementedException();
            return this._unitOfWork.DirectionRepository.GetById(id);
        }
    }
}
