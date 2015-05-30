using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAuto.Models;

namespace WebAuto.Data
{
    /// <summary>
    /// Тестовая реализация IMessageRepository.
    /// Имитирует сохранение сообщений в базу.
    /// </summary>
    public class TestMessagesRepository : IMessagesRepository
    {
        private List<MessageModel> _messages =
            new List<MessageModel>();

        public TestMessagesRepository()
        {
            Create(
                new MessageModel
                {
                    Comment = "test comment",
                    Number = "test number",
                    Icons = new List<string>(),                    
                });                          
        }

        public void Create(MessageModel message)
        {
            message.Dtime = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
            _messages.Add(message);

        }

        public List<MessageModel> GetAll()
        {
            return _messages;
        }
    }
}