using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseRegistration.Entity.Interface.FsApi
{
    public class LoginRequest
    {
        public string account { get; set; }
        public string password { get; set; }
        public LoginRequest()
        {
            this.account = "fsnhkf";
            this.password = "rt0adc3949ba59abbe56e057f20f898f";
        }
    }
    public class LoginResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public LoginData data { get; set; }
        public LoginResponse()
        {
            this.data = new LoginData();
        }
    }

    public class LoginData
    {
        public string userId { get; set; }
        public string tokenId { get; set; }
    }

    public class GetLegalRequest
    {
        public string _tokenId { get; set; }
        public string TYSHXYDM { get; set; }
        public GetLegalRequest(string _tokenId, string TYSHXYDM)
        {
            this._tokenId = _tokenId;
            this.TYSHXYDM = TYSHXYDM;
        }
        public GetLegalRequest(LoginResponse res, string TYSHXYDM)
        {
            this._tokenId = res.data.tokenId;
            this.TYSHXYDM = TYSHXYDM;
        }
    }

    public class GetLegalResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<LegalData> data { get; set; }
        public GetLegalResponse()
        {
            this.data = new List<LegalData>();
        }
    }

    public class VerifyLegalRequest
    {
        public string _tokenId { get; set; }
        public string TYSHXYDM { get; set; }
        public string FRZJH { get; set; }
    }

    public class VerifyLegalResponse
    {
        public string success { get; set; }
        public string message { get; set; }
    }

    public class LegalData
    {
        public string TYSHXYDM { get; set; }
        public string MC { get; set; }
        public string FDDBR { get; set; }
        public string FRZJH { get; set; }
    }

    public class ApiResult
    {
        public string result { get; set; }
        public List<ErrorMsg> errors { get; set; }
        public object jsonData { get; set; }

        public ApiResult()
        {
            errors = new List<ErrorMsg>();
        }

        public void AddMsgSingle(bool result, ErrorMsg error, object jsonData)
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

        public void AddMsg(bool result, List<ErrorMsg> error, object jsonData)
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
}
