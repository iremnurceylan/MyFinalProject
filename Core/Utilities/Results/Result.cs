using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // 2 parametre gonderen birisi icin bu constructor calısacak aynı zamanda bu classın diger constructorı da calışır
        public Result(bool success ,string messsage):this(success)
        {
            Message = Message;
           
        }
        public Result(bool success)
        {
           
            Success = success;
        }

        public bool Success { get; } 

        public string Message { get; } 
    }
}
