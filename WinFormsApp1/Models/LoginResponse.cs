using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
    }
}
