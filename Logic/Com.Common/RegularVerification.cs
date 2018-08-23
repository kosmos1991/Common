using System.Text.RegularExpressions;

namespace Com.Common
{
    /// <summary>
    /// 正则表达式验证
    /// </summary>
    public class RegularVerification
    {
        /// <summary>
        /// 验证手机号码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsMobile(string mobile)
        {
            return Regex.IsMatch(mobile, @"^[1]+[3,4,5,7,8,9]+\d{9}");
        }

        /// <summary>
        /// 验证邮箱
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(email, @"^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+");
        }

        /// <summary>
        /// 验证QQ号
        /// </summary>
        /// <param name="qq"></param>
        /// <returns></returns>
        public static bool IsQQ(string qq)
        {
            return Regex.IsMatch(qq, @"^[1-9][0-9]{4,14}");
        }
    }
}

