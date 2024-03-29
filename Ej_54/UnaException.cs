﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_54
{
    public class UnaException : Exception
    {
        public string message;
        public UnaException(string message)
            : base($"Custom Exp: {message}") { }

        public UnaException(string message, Exception innerException)
            : base($"Custom Exp: {message}", innerException) { }
    }
}
