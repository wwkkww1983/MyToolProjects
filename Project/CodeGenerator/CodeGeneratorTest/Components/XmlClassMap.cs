/************************************************************************************
 *      Copyright (C) 2019 FigKey,All Rights Reserved
 *      File:
 *				XmlClassMap.cs
 *      Description:
 *				 类映射实体类
 *      Author:
 *				唐小东
 *				1297953037@qq.com
 *				http://www.figkey.com
 *      Finish DateTime:
 *				2019年09月26日
 *      History:
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGeneratorTest.Components
{
    /// <summary>
    /// 类映射实体类
    /// </summary>
    [Serializable]
    public class XmlClassMap
    {
        #region 私有字段

        private string className;
        private string tableName;
        private Dictionary<string, XmlPropertyMap> properties = new Dictionary<string, XmlPropertyMap>();
        private XmlPropertyMap identity = null;
        private Dictionary<string, XmlPropertyMap> ids = new Dictionary<string, XmlPropertyMap>();
        #endregion

        #region 构造方法

        public XmlClassMap() { }

        public XmlClassMap(string className, string tableName)
        {
            this.className = className;
            this.tableName = tableName;
        }

        #endregion

        #region 公有属性

        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        /// <summary>
        /// 对应的表明
        /// </summary>
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        /// <summary>
        /// 对应类的属性集合
        /// </summary>
        public Dictionary<string, XmlPropertyMap> Properties
        {
            get { return properties; }
            set { properties = value; }
        }
        /// <summary>
        /// 自增属性
        /// </summary>
        public XmlPropertyMap Identity
        {
            get { return identity; }
            set { identity = value; }
        }
        /// <summary>
        /// 主键属性
        /// </summary>
        public Dictionary<string, XmlPropertyMap> Ids
        {
            get { return ids; }
            set { ids = value; }
        }
        #endregion
    }
}
