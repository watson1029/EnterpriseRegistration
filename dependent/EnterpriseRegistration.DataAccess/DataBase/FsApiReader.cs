using EnterpriseRegistration.Entity.Interface.FsApi;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseRegistration.DataAccess.DataBase
{
    public class FsApiReader
    {
        private static readonly IConfigurationSection serviceAddress = Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetSection("ApiSetting");

        public static async Task<LoginResponse> Login(LoginRequest req)
        {
            try
            {
                var client = new HttpClient();
                var res = await client.GetAsync(serviceAddress["LoginAddress"]);
                var result = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LoginResponse>(result);
            }
            catch (Exception ex)
            {
                var res = new LoginResponse();
                res.success = false;
                res.message = "调用login.do发生未知错误：" + ex.ToString();
                return res;
            }
        }

        public static async Task<GetLegalResponse> GetLegalMsg(GetLegalRequest req)
        {
            try
            {
                var client = new HttpClient();
                var res = await client.GetAsync(serviceAddress["GetLegalAddress"]);
                var result = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<GetLegalResponse>(result);
            }
            catch (Exception ex)
            {
                var res = new GetLegalResponse();
                res.success = false;
                res.message = "调用searchCompany.do发生未知错误：" + ex.ToString();
                return res;
            }
        }

        public static async Task<VerifyLegalResponse> VerifyLegalMsg(VerifyLegalRequest req)
        {
            try
            {
                var client = new HttpClient();
                var res = await client.GetAsync(serviceAddress["VerifyLegalAdderss"]);
                var result = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<VerifyLegalResponse>(result);
            }
            catch (Exception ex)
            {
                var res = new VerifyLegalResponse();
                res.success = false;
                res.message = "调用verifyCerno.do发生未知错误：" + ex.ToString();
                return res;
            }
        }
    }
}
