using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Business
{
    /// <summary>
    /// 分页参数类
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paging"/> class.
        /// </summary>
        public Paging()
        {
            PageIndex = 1;
            PageSize = 10;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public Int32 PageCount { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Int32 PageIndex { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public Int32 PageSize { get; set; }

        /// <summary>
        /// 总行数
        /// </summary>
        public Int32 Total { get; set; }
    }
}