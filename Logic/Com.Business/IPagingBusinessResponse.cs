﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Business
{
    /// <summary>
	/// 带有分页的业务响应
	/// </summary>
	/// <typeparam name="T">返回对象的类型</typeparam>
	public interface IPagingBusinessResponse<T> : IBusinessResponse<T>
    {
        /// <summary>
        /// 分页信息
        /// </summary>
        Paging Paging { get; set; }
    }
}
