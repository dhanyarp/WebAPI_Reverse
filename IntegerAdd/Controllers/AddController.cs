using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using IntegerAdd.Models;

namespace IntegerAdd.Controllers
{
    public class AddController: ApiController
    {

        [Route("add/input1/{input1}/input2/{input2}")]
        [HttpPost]
        public HttpResponseMessage AddInput(int input1, int input2)
        {
            int result = input1 + input2;

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [Route("add/integers")]
        [HttpPost]
        public HttpResponseMessage PostData(DataInput input)
        {
            int result = input.Input1 + input.Input2;

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

    }
}