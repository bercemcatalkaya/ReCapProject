using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message):this(isSuccess)
        {
            Message = message;
        }

        public Result(bool isSuccess)
        {
            Success = isSuccess;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
