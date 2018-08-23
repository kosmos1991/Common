using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Business
{
    /// <summary>
	/// 业务响应接口
	/// </summary>
	public interface IBusinessResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        Boolean Success { get; set; }

        /// <summary>
        /// 业务消息
        /// </summary>
        String Message { get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        String Error { get; set; }
    }

    /// <summary>
    /// 业务响应接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBusinessResponse<T> : IBusinessResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        T Data { get; set; }
    }
}
