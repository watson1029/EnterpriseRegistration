using System;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseRegistration.Entity
{
    /// <summary>
    /// 商事主体基础信息
    /// </summary>
    [Serializable]
    public partial class EX_GONGSHANG_41_SSZTJCXX
    {
        public EX_GONGSHANG_41_SSZTJCXX()
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
        private DateTime? _czsj;
        private string _lxdh;
        private string _mc;
        private string _ztzt;
        private DateTime? _dtupdate;
        private string _djjg;
        private string _s_sign_cert;
        private string _jyfw;
        private string _s_sign_data;
        private string _xkjyfw;
        private string _sflag;
        private string _rjzczb;
        private string _sftz;
        private string _zch;
        private string _fddbr;
        private string _clrq;
        private string _zyxmlb;
        private string _hzrq;
        private string _basszb;
        private string _yyqx;
        private string _lxr;
        private string _qylx;
        private string _sfxg;
        private string _uniscid;
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
        /// 操作时间
        /// </summary>
        public DateTime? CZSJ
        {
            set { _czsj = value; }
            get { return _czsj; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string LXDH
        {
            set { _lxdh = value; }
            get { return _lxdh; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string MC
        {
            set { _mc = value; }
            get { return _mc; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public string ZTZT
        {
            set { _ztzt = value; }
            get { return _ztzt; }
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
        /// 登记机关
        /// </summary>
        public string DJJG
        {
            set { _djjg = value; }
            get { return _djjg; }
        }
        /// <summary>
        /// 证书序列号
        /// </summary>
        public string S_SIGN_CERT
        {
            set { _s_sign_cert = value; }
            get { return _s_sign_cert; }
        }
        /// <summary>
        /// 经营范围
        /// </summary>
        public string JYFW
        {
            set { _jyfw = value; }
            get { return _jyfw; }
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
        /// 许可经营范围
        /// </summary>
        public string XKJYFW
        {
            set { _xkjyfw = value; }
            get { return _xkjyfw; }
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
        /// 认缴注册资本,币种
        /// </summary>
        public string RJZCZB
        {
            set { _rjzczb = value; }
            get { return _rjzczb; }
        }
        /// <summary>
        /// 是否通知
        /// </summary>
        public string SFTZ
        {
            set { _sftz = value; }
            get { return _sftz; }
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
        /// 法定代表人/负责人/执行事务合伙人
        /// </summary>
        public string FDDBR
        {
            set { _fddbr = value; }
            get { return _fddbr; }
        }
        /// <summary>
        /// 成立日期
        /// </summary>
        public string CLRQ
        {
            set { _clrq = value; }
            get { return _clrq; }
        }
        /// <summary>
        /// 主营项目类别
        /// </summary>
        public string ZYXMLB
        {
            set { _zyxmlb = value; }
            get { return _zyxmlb; }
        }
        /// <summary>
        /// 核准日期
        /// </summary>
        public string HZRQ
        {
            set { _hzrq = value; }
            get { return _hzrq; }
        }
        /// <summary>
        /// 备案实收资本
        /// </summary>
        public string BASSZB
        {
            set { _basszb = value; }
            get { return _basszb; }
        }
        /// <summary>
        /// 营业期限
        /// </summary>
        public string YYQX
        {
            set { _yyqx = value; }
            get { return _yyqx; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string LXR
        {
            set { _lxr = value; }
            get { return _lxr; }
        }
        /// <summary>
        /// 商事主体类型
        /// </summary>
        public string QYLX
        {
            set { _qylx = value; }
            get { return _qylx; }
        }
        /// <summary>
        /// 是否修改
        /// </summary>
        public string SFXG
        {
            set { _sfxg = value; }
            get { return _sfxg; }
        }
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public string UNISCID
        {
            set { _uniscid = value; }
            get { return _uniscid; }
        }
        #endregion Model
    }
}
