using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseRegistration.Entity.Interface.FsApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EnterpriseRegistration.FsApi.Controllers
{
    [Produces("application/json")]
    [Route("api/LegalPerson")]
    public class LegalPersonController : Controller
    {
        private readonly LoginRequest _login;
        public LegalPersonController(IOptions<LoginRequest> options)
        {
            _login = options.Value;
        }

        [Route("GetData/{uniscid}")]
        public async Task<ApiResult> GetLegalPerson(string uniscid)
        {
            ApiResult apiresult = new ApiResult();
            LoginResponse loginRes = new LoginResponse();
            try
            {
                loginRes = await DataAccess.DataBase.FsApiReader.Login(_login);
                if (loginRes.success)
                {
                    var legalRes = await DataAccess.DataBase.FsApiReader.GetLegalMsg(new GetLegalRequest(loginRes, uniscid));
                    if (legalRes.success)
                    {
                        apiresult.AddMsg(true, null, legalRes.data[0]);
                    }
                    else
                    {
                        apiresult.AddMsg(false, "GetLegalPerson获取数据错误：" + legalRes.message, null);
                    }
                }
                else
                {
                    apiresult.AddMsg(false, "GetLegalPerson登陆错误：" + loginRes.message, null);
                }
            }
            catch (Exception ex)
            {
                apiresult.AddMsg(false, "GetLegalPerson未知错误：" + ex.ToString(), null);
            }
            return apiresult;
        }

        public async Task<ApiResult> VerifyLegalPerson(string uniscid, string FRZJH)
        {
            ApiResult apiresult = new ApiResult();
            LoginResponse loginRes = new LoginResponse();
            try
            {
                loginRes = await DataAccess.DataBase.FsApiReader.Login(_login);
                if (loginRes.success)
                {
                    var legalRes = await DataAccess.DataBase.FsApiReader.VerifyLegalMsg(new VerifyLegalRequest(loginRes, uniscid, FRZJH));
                    if (legalRes.success)
                    {
                        apiresult.AddMsg(true, null, null);
                    }
                    else
                    {
                        apiresult.AddMsg(false, "VerifyLegalPerson验证数据错误：" + legalRes.message, null);
                    }
                }
                else
                {
                    apiresult.AddMsg(false, "VerifyLegalPerson登陆错误：" + loginRes.message, null);
                }
            }
            catch (Exception ex)
            {
                apiresult.AddMsg(false, "VerifyLegalPerson未知错误：" + ex.ToString(), null);
            }
            return apiresult;
        }
    }
}