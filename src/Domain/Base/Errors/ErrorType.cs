using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base.Errors
{
    public abstract class ErrorType
    {
        public string Name { get; }
        public int Value { get; }

        protected ErrorType(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public static readonly ErrorType Conflict = new ErrorTypeInstance("Conflict", 0);
        public static readonly ErrorType NotFound = new ErrorTypeInstance("NotFound", 1);
        public static readonly ErrorType BadRequest = new ErrorTypeInstance("BadRequest", 2);
        public static readonly ErrorType Validation = new ErrorTypeInstance("Validation", 3);
        public static readonly ErrorType Unexpected = new ErrorTypeInstance("Unexpected", 4);

        public static readonly List<ErrorType> All = new List<ErrorType>
        {
            Conflict,
            NotFound,
            BadRequest,
            Validation,
            Unexpected
        };

        private class ErrorTypeInstance : ErrorType
        {
            public ErrorTypeInstance(string name, int value) : base(name, value) { }
        }

        public override string ToString() => Name;
    }
}
