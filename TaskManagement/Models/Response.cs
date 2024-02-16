using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public bool IsWrongPassword { get; set; }
        public bool IsWrongEmail { get; set; }
        public bool IsAuthorized { get; set; }
        public string Message { get; set; }
        public string Role {  get; set; }
    }
}
