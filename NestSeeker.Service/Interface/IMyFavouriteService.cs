using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface IMyFavouriteService
    {
        IEnumerable<MyFavourites> GetAllMyFavourites();

        MyFavourites GetById(int id);
        MyFavourites AddFavourite(MyFavourites myFavourites);
    }
}
