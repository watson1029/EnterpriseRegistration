using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseRegistration.Entity.Interface.FsApi
{
    public class LoginRequest
    {
        public string account { get; set; }
        public string password { get; set; }
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
        public VerifyLegalRequest(string _tokenId, string TYSHXYDM, string FRZJH)
        {
            this._tokenId = _tokenId;
            this.TYSHXYDM = TYSHXYDM;
            this.FRZJH = FRZJH;
        }
        public VerifyLegalRequest(LoginResponse res, string TYSHXYDM, string FRZJH)
        {
            this._tokenId = res.data.tokenId;
            this.TYSHXYDM = TYSHXYDM;
            this.FRZJH = FRZJH;
        }
    }

    public class VerifyLegalResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
    }

    public class LegalData
    {
        public string TYSHXYDM { get; set; }
        public string MC { get; set; }
        public string JYCS { get; set; }
        public string FDDBR { get; set; }
        public string FRZJH { get; set; }
    }

    public class ApiResult
    {
        public string result { get; set; }
        public string errors { get; set; }
        public LegalData jsonData { get; set; }

        public void AddMsg(bool result, string error, LegalData jsonData)
        {
            if (result)
            {
                this.result = "SUCCESS";
                this.errors = "";
                this.jsonData = jsonData;
            }
            else
            {
                this.result = "FAILURE";
                this.errors += "-" + error;
                this.jsonData = null;
            }
        }
    }
}
