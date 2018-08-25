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
            return Regex.IsMatch(mobile, @"^(13[0-9]|15[012356789]|18[0-9]|14[57]|17[35678]|166|19[89])\d{8}");
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

