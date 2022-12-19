using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message, string ipAddress) : base(success, message)
        {
            Data = data;
            IpAddress = ipAddress;
        }

        public DataResult(T data, bool success, string ipAddress): base(success)
        {
            Data = data;
            IpAddress = ipAddress;
        }
        public T Data { get; }
        public string? IpAddress { get; set; }
    }
}
