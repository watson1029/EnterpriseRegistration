using EnterpriseRegistration.Entity.Interface.GzApi;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseRegistration.DataAccess.DataBase
{
    public class GzApiReader
    {
        public static readonly IConfigurationSection serviceAddress = Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetSection("ApiSetting");

        public static async Task<LoginResponse> Login(LoginRequest req)
        {
            try
            {
                var client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(req));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var res = await client.PostAsync(serviceAddress["LoginAddress"], content);
                var result = await res.Content.ReadAsStringAsync();
                //var result = @"{ ""ack_code"":""SUCCESS"",""errors"":[],""sign"":null,""sign_method"":null,""timestamp"":null,""correlation_id"":""074fa498-7bfd-4876-a39c-89afecfc13a1"",""response_id"":""247eee0f-d785-4d38-bee5-518914a20e60"",""data"":null,""access_token"":""b61df831-0f1f-4ccf-b30b-4b930be9593c""}";
                return JsonConvert.DeserializeObject<LoginResponse>(result);
            }
            catch (Exception ex)
            {
                var res = new LoginResponse();
                res.ack_code = "FAILURE";
                res.errors.Add(new ErrorMsg("Login未知错误", ex.ToString()));
                return res;
            }
        }

        public static async Task<GetLegalResponse> GetLegal(GetLegalRequest req)
        {
            try
            {
                var client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(req));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var res = await client.PostAsync(serviceAddress["GetOrgAddress"], content);
                var result = await res.Content.ReadAsStringAsync();
                //var result = @"{""ack_code"":""SUCCESS"",""errors"":[],""sign"":null,""sign_method"":null,""timestamp"":null,""correlation_id"":""552e6cd7 - 82ef - 4cdc - bc52 - 6dbf22be93d8"",""response_id"":""b48c8ad0 - 3c1a - 45ef - bcd7 - f34e14e4f641"",""data"":{ ""id"":null,""createdBy"":null,""createdDate"":null,""lastModifiedBy"":null,""lastModifiedDate"":""2017 - 05 - 14 01:00:25"",""name"":""广州德拉蒙德食品科技有限公司"",""organizationNumber"":""084852576"",""registeredNumber"":""440101000250791"",""primaryRegisteredNumber"":null,""registeredNumberList"":null,""registeredType"":""企业"",""registeredAgency"":""广州市工商行政管理局"",""registeredDate"":""2013 - 11 - 29 00:00:00"",""cancellationDate"":null,""organizationType"":""企业法人"",""organizationTypeCode"":""1"",""economyType"":""有限责任公司"",""economyTypeCode"":""62"",""industry"":""工程和技术研究和试验发展"",""industryCode"":""M7320"",""businessScope"":""食品科学技术研究服务; 商品批发贸易(许可审批类商品除外); 百货零售(食品零售除外); 货物进出口(专营专控商品除外); 技术进出口; 化妆品及卫生用品批发; 婴儿用品批发; 商品零售贸易(许可审批类商品除外); 化妆品及卫生用品零售; 婴儿用品零售; "",""subordinateRelations"":""其他"",""subordinateRelationsCode"":""90"",""registeredDivision"":""天河区"",""registeredDivisionCode"":""440101"",""registeredAddress"":""广州市天河区珠江东路16号2801房之自编06单元(仅限办公用途)"",""registeredPostal"":""510055"",""registeredGridding"":null,""officeLandDivision"":null,""officeLandDivisionCode"":null,""officeLandAddress"":""广州市天河区珠江东路16号2801房之自编06单元(仅限办公用途)"",""officeLandPostal"":""510000"",""officeLandGridding"":null,""contactPerson"":null,""contactPhone"":""82313161"",""fax"":null,""website"":null,""email"":""294172317@qq.com"",""nationalTaxNumber"":""440104084852576"",""nationalTaxStatus"":""开业"",""localTaxNumber"":""440104084852576"",""localTaxStatus"":""正常"",""registeredCapitalCurrency"":""人民币"",""registeredCapitalCurrencyCode"":""002"",""registeredCapital"":1000.0,""representativeName"":""张礼春"",""representativeIdType"":""居民身份证"",""representativeIdTypeCode"":""1"",""representativeIdNumber"":""340122197003216012"",""representativeDuty"":null,""representativePhone"":null,""businessRegistrationType"":""有限责任公司(自然人投资或控股)"",""businessRegistrationStatus"":""已开业"",""businessStyle"":null,""licensingBusinessProgram"":""乳制品批发; 乳制品零售; 预包装食品零售; 预包装食品批发; "",""socialSecurityNumber"":""44010493053391"",""form"":null,""socialCreditCode"":null,""clerkNumber"":0,""insurantNumber"":0,""duty"":null,""personnelComposition"":null,""approvalNumber"":null,""fundingSources"":null,""purpose"":null,""businessUnit"":null,""businessUnitPhone"":null,""memberNumber"":0,""directorNumber"":0,""customCategory"":null,""dataInfos"":null,""gisAddress"":null,""gisAddressId"":null,""gisX"":null,""gisY"":null,""gisMatchValue"":null,""gisValid"":false,""gpsX"":null,""gpsY"":null,""new"":false},""total_count"":1}";
                //var result = @"{""ack_code"":""FAILURE"",""errors"":[{""name"":""无效安全令牌错误: 安全令牌为空"",""code"":""InvalidAccessTokenException"",""severity"":""ERROR"",""message"":""无效安全令牌错误: 安全令牌为空"",""innerCode"":""gov.platform.api.exception.InvalidAccessTokenException""}],""sign"":null,""sign_method"":null,""timestamp"":null,""correlation_id"":""cc7990ce - 2b64 - 4b30 - 854f - a57f1ec04386"",""response_id"":""440efe40 - bd8e - 4c41 - bf0f - 623eb7061e31"",""data"":null}";
                return JsonConvert.DeserializeObject<GetLegalResponse>(result);
            }
            catch (Exception ex)
            {
                var res = new GetLegalResponse();
                res.ack_code = "FAILURE";
                res.errors.Add(new ErrorMsg("GetOrg未知错误", ex.ToString()));
                return res;
            }
        }
        
        public static async Task<LogoutResponse> Logout(LogoutRequest req)
        {
            try
            {
                var client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(req));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var res = await client.PostAsync(serviceAddress["LogoutAddress"], content);
                var result = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LogoutResponse>(result);
            }
            catch (Exception ex)
            {
                var res = new LogoutResponse();
                res.ack_code = "FAILURE";
                res.errors.Add(new ErrorMsg("Logout未知错误", ex.ToString()));
                return res;
            }
        }
    }
}
