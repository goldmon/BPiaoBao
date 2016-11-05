﻿using BPiaoBao.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.AppServices.ConsoContracts.SystemSetting.DataObjects
{
    public class ResponseSmsTemplate
    {
        public int ID { get; set; }
        /// <summary>
        /// 商户code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        public string TemplateName { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        public string TemplateContents { get; set; }
        /// <summary>
        /// 模板状态
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 最后操作时间
        /// </summary>
        public DateTime LastOperTime { get; set; }
        /// <summary>
        /// 是否为系统模板
        /// </summary>
        public bool IsSystemTemplate { get; set; }
        /// <summary>
        /// 行程类型
        /// </summary>
        public EnumSkyWayType SkyWayType { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        public EnumSmsTemplateType TemplateType { get; set; }
    }
}
