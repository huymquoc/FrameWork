using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Framework.Repository;
using Framework.Web.Domain;
using Framework.Web.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;


namespace Framework.Web.Service
{
    public class AlertService : BaseService<Book>
    {
        private readonly IUnitOfWork _unitOfWork;


        public AlertService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



    }
}