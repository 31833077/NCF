﻿using Senparc.Ncf.Core.Models;
using System.ComponentModel;

namespace Senparc.Xncf.CodeBuilder.Models.DatabaseModel.Dto
{
    public class BuilderTableColumnDto : DtoBase
    {
        /// <summary>
        /// 归属表编号
        /// </summary>
        [Description("归属表编号")]
        [Browsable(false)]
        public int TableId { get; set; }
        /// <summary>
        /// 表名称
        /// </summary>
        [Description("表名称")]
        public string TableName { get; set; }
        /// <summary>
        /// 列名称
        /// </summary>
        [Description("列名称")]
        public string ColumnName { get; set; }
        /// <summary>
        /// 列描述
        /// </summary>
        [Description("列描述")]
        public string Comment { get; set; }
        /// <summary>
        /// 列类型
        /// </summary>
        [Description("列类型")]
        public string ColumnType { get; set; }
        /// <summary>
        /// 实体类型
        /// </summary>
        [Description("实体类型")]
        public string EntityType { get; set; }
        /// <summary>
        /// 实体名称
        /// </summary>
        [Description("实体名称")]
        public string EntityName { get; set; }
        /// <summary>
        /// 是否主键
        /// </summary>
        [Description("是否主键")]
        public bool IsKey { get; set; }
        /// <summary>
        /// 是否自增
        /// </summary>
        [Description("是否自增")]
        public bool IsIncrement { get; set; }
        /// <summary>
        /// 是否必填
        /// </summary>
        [Description("是否必填")]
        public bool IsRequired { get; set; }
        /// <summary>
        /// 是否为插入字段
        /// </summary>
        [Description("是否为插入字段")]
        public bool IsInsert { get; set; }
        /// <summary>
        /// 是否编辑字段
        /// </summary>
        [Description("是否编辑字段")]
        public bool IsEdit { get; set; }
        /// <summary>
        /// 是否列表字段
        /// </summary>
        [Description("是否列表字段")]
        public bool IsList { get; set; }
        /// <summary>
        /// 是否查询字段
        /// </summary>
        [Description("是否查询字段")]
        public bool IsQuery { get; set; }
        /// <summary>
        /// 查询方式（等于、不等于、大于、小于、范围）
        /// </summary>
        [Description("查询方式（等于、不等于、大于、小于、范围）")]
        public string QueryType { get; set; }
        /// <summary>
        /// 显示类型（文本框、文本域、下拉框、复选框、单选框、日期控件）
        /// </summary>
        [Description("显示类型（文本框、文本域、下拉框、复选框、单选框、日期控件）")]
        public string HtmlType { get; set; }
        /// <summary>
        /// 编辑类型（文本框、文本域、下拉框、复选框、单选框、日期控件）
        /// </summary>
        [Description("编辑类型（文本框、文本域、下拉框、复选框、单选框、日期控件）")]
        public string EditType { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Description("排序")]
        public int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        [Description("创建人ID")]
        [Browsable(false)]
        public string CreateUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Description("修改时间")]
        public System.DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 修改人ID
        /// </summary>
        [Description("修改人ID")]
        [Browsable(false)]
        public string UpdateUserId { get; set; }
        /// <summary>
        /// 修改时的行位置
        /// </summary>
        [Description("修改时的行位置")]
        public int? EditRow { get; set; }
        /// <summary>
        /// 修改时的列位置
        /// </summary>
        [Description("修改时的列位置")]
        public int? EditCol { get; set; }
        /// <summary>
        /// 修改人姓名
        /// </summary>
        [Description("修改人姓名")]
        public string UpdateUserName { get; set; }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        [Description("创建人姓名")]
        public string CreateUserName { get; set; }
        /// <summary>
        /// 最大长度
        /// </summary>
        [Description("最大长度")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// 数据源（用于下拉框、复选框等取值）
        /// </summary>
        [Description("数据源（用于下拉框、复选框等取值）")]
        public string DataSource { get; set; }
        public BuilderTableColumnDto() { }
    }
}
