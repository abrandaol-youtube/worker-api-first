using System;
using System.Collections.Generic;
using System.Text;
using WebApiBackgroundServices.Domain;

namespace WebApiBackgroundServices.Repository
{
    public interface ICommandRepository
    {
        string GetMessage();
        void SetMessage(Message message);
    }
}
