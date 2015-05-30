using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebAuto.Data;
using WebAuto.Models;

namespace WebAuto.Controllers
{
    public class MessagesController : ApiController
    {
        private static IMessagesRepository _messagesRepository =
            new TestMessagesRepository();

        // GET api/messages/getall
        public IHttpActionResult GetAll()
        {
            Thread.Sleep(2000);
            var messages = _messagesRepository.GetAll();
            return Ok(messages);
        }

        // POST api/messages
        public IHttpActionResult Post(MessageModel message)
        {
            _messagesRepository.Create(message);
            return Ok();
        }
    }
}