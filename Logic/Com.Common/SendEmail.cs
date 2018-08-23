using Com.Enums;
using Com.ViewModel;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Com.Common
{
    /// <summary>
    /// 发送邮件
    /// </summary>
    public class SendEmail
    {
        string smtpServer = ""; //SMTP服务器
        int port = 0;//端口号

        public string Send(SendEmailViewModel viewmodel)
        {
            if (viewmodel.SenderType == EmailAddressType.QQ)
            {
                smtpServer = "smtp.exmail.qq.com";
                port = 25;
            }
            else if (viewmodel.SenderType == EmailAddressType.NetEase)
            {
                smtpServer = "smtp.qiye.163.com";
                port = 25;
            }
            else
            {
                return "发件人邮箱不存在";
            }

            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.Port = port;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(viewmodel.Sender, viewmodel.SenderPwd);// 发件人邮箱和校验码

            // 发送邮件设置        
            MailMessage mailMessage = new MailMessage(viewmodel.Sender, viewmodel.Reciever); // 发送人和收件人
            mailMessage.Subject = viewmodel.Title;//标题
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Body = viewmodel.Content;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.Priority = MailPriority.Normal;//优先级

            try
            {
                smtpClient.Send(mailMessage);
                return "发送成功";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
