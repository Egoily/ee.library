﻿using System;

namespace ee.Core.Exceptions
{
    public class EeException : Exception
    {
        public int ErrorCode { get; protected set; }

        public EeException(int errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
