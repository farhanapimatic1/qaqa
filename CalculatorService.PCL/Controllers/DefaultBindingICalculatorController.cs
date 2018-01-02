/*
 * CalculatorService.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using CalculatorService.PCL;
using CalculatorService.PCL.Utilities;
using CalculatorService.PCL.Http.Request;
using CalculatorService.PCL.Http.Response;
using CalculatorService.PCL.Http.Client;
using CalculatorService.PCL.Exceptions;

namespace CalculatorService.PCL.Controllers
{
    public partial class DefaultBindingICalculatorController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static DefaultBindingICalculatorController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DefaultBindingICalculatorController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new DefaultBindingICalculatorController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.ICalculatorAddOutputMessage response from the API call</return>
        public Models.ICalculatorAddOutputMessage Add(Models.ICalculatorAddInputMessage body)
        {
            Task<Models.ICalculatorAddOutputMessage> t = AddAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.ICalculatorAddOutputMessage response from the API call</return>
        public async Task<Models.ICalculatorAddOutputMessage> AddAsync(Models.ICalculatorAddInputMessage body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Add");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ICalculatorAddOutputMessage>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.ICalculatorSubtractOutputMessage response from the API call</return>
        public Models.ICalculatorSubtractOutputMessage CreateSubtract(Models.ICalculatorSubtractInputMessage body)
        {
            Task<Models.ICalculatorSubtractOutputMessage> t = CreateSubtractAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.ICalculatorSubtractOutputMessage response from the API call</return>
        public async Task<Models.ICalculatorSubtractOutputMessage> CreateSubtractAsync(Models.ICalculatorSubtractInputMessage body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/Subtract");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ICalculatorSubtractOutputMessage>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 