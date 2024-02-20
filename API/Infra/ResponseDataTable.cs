using System;
using System.Collections.Generic;
using System.Text;

namespace Pertamina.PRIME.Models.BaseModel
{
    
    public class ResponseDataTable<T>
    {
        public ResponseDataTable(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        //public ResponseDataTable(T data)
        //{
        //    IsSuccess = true;
        //    Message = string.Empty;
        //    Value = data;
        //}
        //public ResponseDataTable(bool isSuccess, string message, T value)
        //{
        //    IsSuccess = isSuccess;
        //    Message = message;
        //    Value = value;
        //}

        //public ResponseDataTable(T value, PageInfo pageInfo)
        //{
        //    //IsSuccess = true;
        //    Message = string.Empty;
        //    Value = value;
        //    //PageInfo = pageInfo;
        //}
        public ResponseDataTable(string nextLink, T value, int total, int page)
        {
            Next = nextLink;
            Page = page;
            Total = total;
            Value = value;
            IsSuccess = true;
            //PageInfo = pageInfo;
        }
        public string Next { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public bool IsSuccess { get; set; }

        //public PageInfo PageInfo { get; set; }
    }
}
