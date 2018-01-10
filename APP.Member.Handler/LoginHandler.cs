using APP.CommonLib.Utils;
using APP.CommonLib.XService;
using APP.Member.Entity.Parameter;
using APP.Member.Entity.Response;

namespace APP.Member.Handler
{
    /// <summary>
    /// 用户登录模块
    /// </summary>
    public class LoginHandler : IServiceHandler
    {
        public ServiceResult Invoke(ServiceRequest req)
        {
            LoginParameter param = JsonHelper.JsonDeserialize<LoginParameter>(req.data);
            


            throw new System.NotImplementedException();
        }
    }
}
