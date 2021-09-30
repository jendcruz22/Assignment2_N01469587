using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment2.Controllers
{
    //J2 Problem from 2007: I Speak TXTMSG
    public class J2ProblemController : ApiController
    {
        //GET: api/j2problem/txtmsg/shortform
        [HttpGet]
        [Route("api/j2problem/txtmsg/{shortform}")]

        public string TXTMSG(string ShortForm)
       {
            string outputMessage;

            switch (ShortForm)
            {

                case "CU":
                    outputMessage = "see you";
                    break;

                case ":-)":
                    outputMessage = "I'm happy";
                    break;

                case ":-(":
                    outputMessage = "I'm unhappy";
                    break;

                case ";-)":
                    outputMessage = "wink";
                    break;

                case ":-P":
                    outputMessage = "stick out my tongue";
                    break;

                case "(~.~)":
                    outputMessage = "sleepy";
                    break;

                case "TA":
                    outputMessage = "totally awesome";
                    break;

                case "CCC":
                    outputMessage = "Canadian Computing Competition";
                    break;

                case "CUZ":
                    outputMessage = "because";
                    break;

                case "TY":
                    outputMessage = "thank-you";
                    break;

                case "YW":
                    outputMessage = "you're welcome";
                    break;

                case "TTYL":
                    outputMessage = "talk to you later";
                    break;

                default:
                    outputMessage = "Invalid Input";
                    break;
            }

            return outputMessage;
        }
    }
}
