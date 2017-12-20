using System;

namespace WebApplication2.Models
{
    public class MyViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}