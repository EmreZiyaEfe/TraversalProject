using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DTO.DTOs.MailDTOs
{
    public class MailRequestDtos
    {
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string RecieverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public IFormFile File { get; set; }
    }
}
