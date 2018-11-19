﻿using System;

namespace User.API
{
    public class UserException : Exception
    {
        public UserException(string message) : base(message)
        {

        }

        public UserException(string message,Exception innerException):base(message,innerException)
        {
            
        }
    }
}