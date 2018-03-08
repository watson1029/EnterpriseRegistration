using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseRegistration.Entity.Interface.GzApi
{
    public class LoginRequest
    {
        public string app_key { get; set; }
        public string app_secret { get; set; }
        public string account { get; set; }
        public string password { get; set; }
    }

    public class LoginResponse
    {
        public string ack_code { get; set; }
        public List<ErrorMsg> errors { get; set; }
        public string access_token { get; set; }
        public LoginResponse()
        {
            this.errors = new List<ErrorMsg>();
        }
    }

    public class GetLegalRequest
    {
        public string access_token { get; set; }
        public string registered_number { get; set; }
        public string organization_number { get; set; }
        public GetLegalRequest(string access_token, string registered_number)
        {
            this.access_token = access_token;
            this.registered_number = registered_number;
        }
        public GetLegalRequest(LoginResponse res, string registered_number, string organization_number)
        {
            this.access_token = res.access_token;
            this.registered_number = registered_number;
            this.organization_number = organization_number;
        }
    }

    public class GetLegalResponse
    {
        public string ack_code { get; set; }
        public List<ErrorMsg> errors { get; set; }
        public LegalData data { get; set; }
        public GetLegalResponse()
        {
            this.errors = new List<ErrorMsg>();
            this.data = new LegalData();
        }
    }

    public class LogoutRequest
    {
        public string access_token { get; set; }
        public LogoutRequest(string access_token)
        {
            this.access_token = access_token;
        }
        public LogoutRequest(LoginResponse res)
        {
            this.access_token = res.access_token;
        }
    }

    public class LogoutResponse
    {
        public string ack_code { get; set; }
        public List<ErrorMsg> errors { get; set; }
        public LogoutResponse()
        {
            this.errors = new List<ErrorMsg>();
        }
    }

    public class ErrorMsg
    {
        public string name { get; set; }
        public string message { get; set; }
        public ErrorMsg(string name, string message)
        {
            this.name = name;
            this.message = message;
        }
    }

    public class LegalData
    {
        public string organizationNumber { get; set; }
        public string registeredNumber { get; set; }
        public string name { get; set; }
        public string representativeName { get; set; }
        public string representativeIdNumber { get; set; }
    }

    public class ApiResult
    {
        public string result { get; set; }
        public List<ErrorMsg> errors { get; set; }
        public LegalData jsonData { get; set; }

        public ApiResult()
        {
            errors = new List<ErrorMsg>();
        }

        public void AddMsgSingle(bool result, ErrorMsg error, LegalData jsonData)
        {
            if (result)
            {
                this.result = "SUCCESS";
                this.errors = null;
                this.jsonData = jsonData;
            }
            else
            {
                this.result = "FAILURE";
                this.errors.Add(error);
                this.jsonData = null;
            }
        }

        public void AddMsg(bool result, List<ErrorMsg> error, LegalData jsonData)
        {
            if (result)
            {
                this.result = "SUCCESS";
                this.errors = null;
                this.jsonData = jsonData;
            }
            else
            {
                this.result = "FAILURE";
                foreach (var e in error)
                {
                    this.errors.Add(e);
                }
                this.jsonData = null;
            }
        }
    }
}
