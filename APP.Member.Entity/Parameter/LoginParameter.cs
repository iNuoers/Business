using System.ComponentModel;

namespace APP.Member.Entity.Parameter
{
    /// <summary>
    /// 登录接口业务参数
    /// </summary>
    public class LoginParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("手机号码")]
        public string Phone { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Description("登录密码")]
        public string Password { get; set; }
    }
}