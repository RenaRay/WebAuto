using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAuto.Models;

namespace WebAuto.Data
{
    public interface IMessagesRepository
    {
        void Create(MessageModel message);
        List<MessageModel> GetAll();
    }
}