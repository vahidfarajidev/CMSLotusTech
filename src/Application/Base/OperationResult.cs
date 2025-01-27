using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Base
{
    public class OperationResult
    {
        public bool IsSuccess { get; private set; }
        public bool IsFailure => !IsSuccess;
        public string Error { get; private set; }

        public OperationResult(bool isSuccess, string error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }
    }

    public class OperationResult<T> : OperationResult
    {
        public T Value { get; private set; }
        
        protected internal OperationResult(T value) : base (true, string.Empty)
        {
            Value = value;
        }

        protected internal OperationResult(string error) : base (false, error)
        {
            Value = default!;
        }

        public static OperationResult<T> Success(T value)
        {
            return new OperationResult<T>(value);
        }

        public static OperationResult<T> Failure(string error)
        {
            return new OperationResult<T>(error);
        }
    }
}
