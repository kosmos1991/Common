using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Business
{
    /// <summary>
    /// 分页请求类
    /// </summary>
    public class PagingBusinessResponse<T> : WebBusinessResponse, IPagingBusinessResponse<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public PagingBusinessResponse()
        {
            Paging = new Paging();
            Data = default(T);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="error"></param>
        public PagingBusinessResponse(Boolean success, String message, String error)
            : base(success, message, error)
        {
        }

        /// <summary>
        /// 分页信息
        /// </summary>
        public Paging Paging { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public T Data { get; set; }

    }
}
