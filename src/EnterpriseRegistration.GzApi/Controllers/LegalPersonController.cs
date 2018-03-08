using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using EnterpriseRegistration.Entity.Interface.GzApi;

namespace EnterpriseRegistration.GzApi.Controllers
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

        [Route("GetByZch/{zch}")]
        public async Task<ApiResult> GetByZch(string zch)
        {
            ApiResult apiresult = new ApiResult();
            LoginResponse loginRes = new LoginResponse();
            try
            {
                loginRes = await DataAccess.DataBase.GzApiReader.Login(_login);
                if (loginRes.ack_code.Equals("SUCCESS"))
                {
                    var legalRes = await DataAccess.DataBase.GzApiReader.GetLegal(new GetLegalRequest(loginRes, zch, null));
                    if (legalRes.ack_code.Equals("SUCCESS"))
                    {
                        apiresult.AddMsgSingle(true, null, legalRes.data);
                    }
                    else
                    {
                        apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson错误", "获取数据错误"), null);
                        apiresult.AddMsg(false, legalRes.errors, null);
                    }
                }
                else
                {
                    apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson错误", "登陆错误"), null);
                    apiresult.AddMsg(false, loginRes.errors, null);
                }
            }
            catch (Exception ex)
            {
                apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson未知错误", ex.ToString()), null);
            }
            return apiresult;
        }

        [Route("GetByOrg/{org}")]
        public async Task<ApiResult> GetByOrg(string org)
        {
            ApiResult apiresult = new ApiResult();
            LoginResponse loginRes = new LoginResponse();
            try
            {
                loginRes = await DataAccess.DataBase.GzApiReader.Login(_login);
                if (loginRes.ack_code.Equals("SUCCESS"))
                {
                    var legalRes = await DataAccess.DataBase.GzApiReader.GetLegal(new GetLegalRequest(loginRes, null, org));
                    if (legalRes.ack_code.Equals("SUCCESS"))
                    {
                        apiresult.AddMsgSingle(true, null, legalRes.data);
                    }
                    else
                    {
                        apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson错误", "获取数据错误"), null);
                        apiresult.AddMsg(false, legalRes.errors, null);
                    }
                }
                else
                {
                    apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson错误", "登陆错误"), null);
                    apiresult.AddMsg(false, loginRes.errors, null);
                }
            }
            catch (Exception ex)
            {
                apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson未知错误", ex.ToString()), null);
            }
            finally
            {
                //try
                //{
                //    if (loginRes.ack_code.Equals("SUCCESS"))
                //    {
                //        var logoutRes = await Logout(new LogoutRequest(loginRes));
                //        if (!logoutRes.ack_code.Equals("SUCCESS"))
                //        {
                //            apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson错误", "登出错误"), null);
                //            apiresult.AddMsg(false, logoutRes.errors, null);
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    apiresult.AddMsgSingle(false, new ErrorMsg("GetLegalPerson未知错误", ex.ToString()), null);
                //}
            }
            return apiresult;
        }
    }
}