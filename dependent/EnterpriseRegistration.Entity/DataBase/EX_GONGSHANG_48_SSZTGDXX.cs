using System;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseRegistration.Entity
{
    /// <summary>
    /// 商事主体股东信息
    /// </summary>
    [Serializable]
    public partial class EX_GONGSHANG_48_SSZTGDXX
    {
        public EX_GONGSHANG_48_SSZTGDXX()
        { }

        #region Model
        private string _s_guid = "sys_guid";
        private DateTime _s_creation_time = Convert.ToDateTime("1900-01-01");
        private DateTime? _s_last_updated = DateTime.Now;
        private string _s_status = "0";
        private string _s_trans_status = "00";
        private string _s_route_status = "00";
        private string _s_src_node;
        private string _s_dest_node;
        private DateTime? _dtupdate;
        private string _id;
        private string _gdgj;
        private string _gdlx;
        private string _zch;
        private string _sflag;
        private string _gdmc;
        private decimal? _rjcze;
        private string _s_sign_data;
        private decimal? _rjbl;
        private string _zjhm;
        private string _s_sign_cert;
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public string S_GUID
        {
            set { _s_guid = value; }
            get { return _s_guid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime S_CREATION_TIME
        {
            set { _s_creation_time = value; }
            get { return _s_creation_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? S_LAST_UPDATED
        {
            set { _s_last_updated = value; }
            get { return _s_last_updated; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_STATUS
        {
            set { _s_status = value; }
            get { return _s_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_TRANS_STATUS
        {
            set { _s_trans_status = value; }
            get { return _s_trans_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_ROUTE_STATUS
        {
            set { _s_route_status = value; }
            get { return _s_route_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_SRC_NODE
        {
            set { _s_src_node = value; }
            get { return _s_src_node; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S_DEST_NODE
        {
            set { _s_dest_node = value; }
            get { return _s_dest_node; }
        }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime? DTUPDATE
        {
            set { _dtupdate = value; }
            get { return _dtupdate; }
        }
        /// <summary>
        /// 主键ID
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 股东国籍
        /// </summary>
        public string GDGJ
        {
            set { _gdgj = value; }
            get { return _gdgj; }
        }
        /// <summary>
        /// 股东类型
        /// </summary>
        public string GDLX
        {
            set { _gdlx = value; }
            get { return _gdlx; }
        }
        /// <summary>
        /// 注册号
        /// </summary>
        public string ZCH
        {
            set { _zch = value; }
            get { return _zch; }
        }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string SFLAG
        {
            set { _sflag = value; }
            get { return _sflag; }
        }
        /// <summary>
        /// 股东名称
        /// </summary>
        public string GDMC
        {
            set { _gdmc = value; }
            get { return _gdmc; }
        }
        /// <summary>
        /// 股东认缴出资额
        /// </summary>
        public decimal? RJCZE
        {
            set { _rjcze = value; }
            get { return _rjcze; }
        }
        /// <summary>
        /// 签名值字段
        /// </summary>
        public string S_SIGN_DATA
        {
            set { _s_sign_data = value; }
            get { return _s_sign_data; }
        }
        /// <summary>
        /// 股东出资所占比例
        /// </summary>
        public decimal? RJBL
        {
            set { _rjbl = value; }
            get { return _rjbl; }
        }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string ZJHM
        {
            set { _zjhm = value; }
            get { return _zjhm; }
        }
        /// <summary>
        /// 证书序列号
        /// </summary>
        public string S_SIGN_CERT
        {
            set { _s_sign_cert = value; }
            get { return _s_sign_cert; }
        }
        #endregion Model
    }
}
