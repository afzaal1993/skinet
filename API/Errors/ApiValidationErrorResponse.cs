using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse() : base(400)  //Coz we know it will be a 400
        {

        }

        public IEnumerable<string> Errors { get; set; }
    }
}