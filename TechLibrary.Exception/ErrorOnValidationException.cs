﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TechLibrary.Exception
{
    public class ErrorOnValidationException : TechLibraryException
    {
        private readonly List<string> _errors;

        public ErrorOnValidationException(List<string> errorMessages)
        {
            _errors = errorMessages;
        }

        public override List<string> GetErrorMessages()
        {
            return _errors;
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }
    }
}
