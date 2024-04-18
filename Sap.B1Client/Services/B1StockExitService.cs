﻿using Microsoft.Extensions.Options;
using RestSharp;
using Sap.B1Client.System.Abstracts;
using Sap.B1Client.System.Constants;
using Sap.B1Client.System.Models;

namespace Sap.B1Client.B1StockExit
{
    public class B1StockExitService(IOptions<ConfigOptionModel> options) : B1ClientBase(options)
    {
        public RestResponse AddNewStockExit(object entity)
        {
            // _request = new RestRequest(Constant.B1S_Path_Stock_Exit, Method.Post);
            _request.Resource = Constant.B1S_Path_Stock_Exit;
            _request.Method = Method.Post;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
            _request.AddJsonBody(entity);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse RetrieveAllStockExit(string requiredTemplate)
        {
            // _request = new RestRequest(Constant.B1S_Path_Stock_Exit + requiredTemplate, Method.Get);
            _request.Resource = Constant.B1S_Path_Stock_Exit + requiredTemplate;
            _request.Method = Method.Get;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse RetrieveStockExit(string identity)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID, identity), Method.Get);
            _request.Resource = string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID, identity);
            _request.Method = Method.Get;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse AlterStockExit(string identity, object contentObjt)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID, identity), Method.Patch);
            _request.Resource = string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID, identity);
            _request.Method = Method.Patch;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);
            _request.AddHeader(Constant.B1S_Label_ReplaceOnPatch, true.ToString());
            _request.AddJsonBody(contentObjt);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse CancelDocument(string identity)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID + Constant.B1S_AcDoc_CANCEL, identity), Method.Post);
            _request.Resource = string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID + Constant.B1S_AcDoc_CANCEL, identity);
            _request.Method = Method.Post;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }

        public RestResponse CloseDocument(string identity)
        {
            // _request = new RestRequest(string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID + Constant.B1S_AcDoc_CLOSE, identity), Method.Post);
            _request.Resource = string.Format(Constant.B1S_Path_Stock_Exit + Constant.B1S_IID + Constant.B1S_AcDoc_CLOSE, identity);
            _request.Method = Method.Post;
            _request.AddHeader(Constant.B1S_Label_Cookie, _hCookieString);

            _response = _client.Execute(_request);
            return _response;
        }
    }
}