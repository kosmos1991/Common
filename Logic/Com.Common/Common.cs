using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace Com.Common
{
    public class Common
    {
        /// <summary>
        /// DataSetToList
        /// </summary>
        /// <typeparam name="T">转换类型</typeparam>
        /// <param name="dataSet">数据源</param>
        /// <param name="tableIndex">需要转换表的索引</param>
        /// <returns></returns>
        public IList<T> DataSetToList<T>(DataSet dataSet, int tableIndex)
        {
            //确认参数有效
            if (dataSet == null || dataSet.Tables.Count <= 0 || tableIndex < 0)
                return null;

            DataTable dt = dataSet.Tables[tableIndex];

            IList<T> list = new List<T>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建泛型对象
                T _t = Activator.CreateInstance<T>();
                //获取对象所有属性
                PropertyInfo[] propertyInfo = _t.GetType().GetProperties();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    foreach (PropertyInfo info in propertyInfo)
                    {
                        //属性名称和列名相同时赋值
                        if (dt.Columns[j].ColumnName.ToUpper().Equals(info.Name.ToUpper()))
                        {
                            if (dt.Rows[i][j] != DBNull.Value)
                            {
                                info.SetValue(_t, dt.Rows[i][j], null);
                            }
                            else
                            {
                                info.SetValue(_t, null, null);
                            }
                            break;
                        }
                    }
                }
                list.Add(_t);
            }
            return list;
        }

        /// <summary>
        /// C# 把一个文件夹下所有文件删除
        /// </summary>
        /// <param name="srcPath"></param>
        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// Md5加密函数
        /// </summary>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        public static string Encrypt(string strPwd)
        {
            var md5Hasher = MD5.Create();

            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(strPwd)); //将字符编码为一个字节序列 

            var sBuilder = new StringBuilder(); //计算data字节数组的哈希值

            foreach (var @byte in data)
            {
                sBuilder.Append(@byte.ToString("x2"));
            }

            return sBuilder.ToString();
        }

        /// <summary>
        /// 根据枚举类和枚举值获取枚举的描述
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDescriptionFromEnumValue(Type enumType, object enumValue)
        {
            try
            {
                object o = Enum.Parse(enumType, enumValue.ToString());

                string name = o.ToString();
                DescriptionAttribute[] customAttributes = (DescriptionAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((customAttributes != null) && (customAttributes.Length == 1))
                {
                    return customAttributes[0].Description;
                }
                return name;
            }
            catch
            {
                return "未知";
            }
        }
    }
}
