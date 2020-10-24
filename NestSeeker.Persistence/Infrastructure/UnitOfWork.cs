using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Persistence.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NestSeekerContext _context;
        public Repository<User> UserRepository { get; }
        public Repository<UserRole> UserRoleRepository { get; private set; }
        public Repository<Role> RoleRepository { get; }
        public Repository<Status> StatusRepository { get; }
        public Repository<TransactionType> TransactionTypeRepository { get; }
        public Repository<Requests> RequestsRepository { get; }
        public Repository<PropertyType> ProprtyTypeRepository { get; }
       
        public Repository<MyFavourites> MyFavouritesRepository { get; }
        public Repository<Direction> DirectionRepository { get; }
        public Repository<BHKType> BHKTypeRepository { get; }
        public Repository<Document> DocumentRepository { get; }

        //Repository<Property> IUnitOfWork.PropertyRepository => throw new NotImplementedException();

        public Repository<Property> PropertyRepository { get; }

        //Repository<User> IUnitOfWork.PropertyRepository => throw new NotImplementedException();

        // Repository<User> IUnitOfWork.UserRepository => throw new NotImplementedException();

        public UnitOfWork(NestSeekerContext context)
        {
            this._context = context;
           
            this.UserRepository = new Repository<User>(this._context);
            this.PropertyRepository = new Repository<Property>(this._context);
            this.ProprtyTypeRepository = new Repository<PropertyType>(this._context);
            this.TransactionTypeRepository = new Repository<TransactionType>(this._context);
            this.UserRoleRepository = new Repository<UserRole>(this._context);
            this.StatusRepository = new Repository<Status>(this._context);
            this.RoleRepository = new Repository<Role>(this._context);
            this.RequestsRepository = new Repository<Requests>(this._context);
            this.MyFavouritesRepository = new Repository<MyFavourites>(this._context);
            this.DirectionRepository = new Repository<Direction>(this._context);
            this.DocumentRepository = new Repository<Document>(this._context);
            this.BHKTypeRepository = new Repository<BHKType>(this._context);
           
        }

        public void Dispose()
        {
            this._context.Dispose();
        }

        public int Save()
        {
            return this._context.SaveChanges();
        }
    }
}

