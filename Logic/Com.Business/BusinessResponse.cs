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
	public class BusinessResponse : IBusinessResponse
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
        public BusinessResponse()
        {
            Success = true;

            Message = "Success";

            Error = "Success";
        }

        /// <summary>
        /// 错误
        /// </summary>
        /// <param name="error">错误信息</param>
        public BusinessResponse(String error)
        {
            Success = false;
            this.Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success">是否成功</param>
        /// <param name="message">成功的提示</param>
        public BusinessResponse(Boolean success, String message)
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
        public BusinessResponse(Boolean success, String message, String error)
            : this(success, message)
        {
            this.Error = error;
        }
    }

    /// <summary>
    /// 业务响应
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BusinessResponse<T> : WebBusinessResponse, IBusinessResponse<T>
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BusinessResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessResponse{T}"/> class.
        /// </summary>
        /// <param name="error">错误信息</param>
        public BusinessResponse(String error)
            : base(error)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessResponse{T}"/> class.
        /// </summary>
        /// <param name="data">返回的数据</param>
        public BusinessResponse(T data)
        {
            this.Data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        public BusinessResponse(Boolean success, String message)
            : base(success, message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="error"></param>
        public BusinessResponse(Boolean success, String message, String error)
            : base(success, message, error)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public BusinessResponse(Boolean success, String message, T data)
            : base(success, message)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessResponse{T}"/> class.
        /// </summary>
        /// <param name="sucess">if set to <c>true</c> [sucess].</param>
        /// <param name="message">The message.</param>
        /// <param name="error">The error.</param>
        /// <param name="data">The data.</param>
        public BusinessResponse(Boolean sucess, String message, String error, T data)
            : base(sucess, message, error)
        {
            this.Data = data;
        }
    }
}