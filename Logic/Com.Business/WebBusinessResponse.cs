using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Business
{
    /// <summary>
	/// 业务响应
	/// </summary>
	public class WebBusinessResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public Boolean Success { get; set; }

        /// <summary>
        /// 业务消息
        /// </summary>
        public String Message { get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        public String Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public WebBusinessResponse()
        {
            Success = true;

            Message = "Success";

            Error = "Success";
        }

        /// <summary>
        /// 错误
        /// </summary>
        /// <param name="error">错误信息</param>
        public WebBusinessResponse(String error)
        {
            Success = false;
            this.Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success">是否成功</param>
        /// <param name="message">成功的提示</param>
        public WebBusinessResponse(Boolean success, String message)
        {
            this.Success = success;

            this.Message = message;

            Error = "Success";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="error"></param>
        public WebBusinessResponse(Boolean success, String message, String error)
            : this(success, message)
        {
            this.Error = error;
        }
    }
}