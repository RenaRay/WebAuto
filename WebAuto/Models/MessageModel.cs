using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAuto.Models
{

    /// <summary>
    /// Модель для сообщения. Данные, которые передаются с клиента на сервер.
    /// </summary>
    public class MessageModel
    {
        public string Comment {get; set;}
        public string Number { get; set;}
        public List<string> Icons { get; set; }
        public string Dtime { get; set; }
    }
}
