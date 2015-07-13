﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Framework.Repository;
using Framework.Web.Domain;

namespace Framework.Web.Service
{
    public class BookService : BaseService<Book>
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Dummy code, will be remove
        public void DoSomething()
        {
            using (var unitOfWork = UnitOfWorkFactory.Get())
            {
                var tmp = unitOfWork.Repository<Book>();

                //TODO:
            }
        }

        public void InsertBook(Book newBook)
        {
            if (newBook == null)
            {
                throw new ArgumentNullException("This method requires a not null book instance");
            }
            newBook.ReceivedDate = DateTime.Now;
            Repository.Insert(newBook);
            _unitOfWork.Save();
        }


    }
}