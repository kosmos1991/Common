using Com.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.ViewModel
{
    public class SendEmailViewModel
    {
        /// <summary>
        /// 发件人邮箱地址
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 发件人邮箱类型
        /// </summary>
        public EmailAddressType SenderType { get; set; }

        /// <summary>
        /// 发件人邮箱校验码
        /// </summary>
        public string SenderPwd { get; set; }

        /// <summary>
        /// 收件人邮箱地址
        /// </summary>
        public string Reciever { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}