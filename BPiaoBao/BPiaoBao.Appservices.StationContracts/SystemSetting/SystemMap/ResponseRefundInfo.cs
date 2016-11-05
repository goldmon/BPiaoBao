﻿using BPiaoBao.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.AppServices.StationContracts.SystemSetting.SystemMap
{
    public class ResponseRefund
    {
        public int ID { get; set; }
        /// <summary>
        /// 理由类型
        /// </summary>
        public EnumRefuse RefuseType { get; set; }
        /// <summary>
        /// 理由内容
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 退款类型【true:退票退款，false：退款不退票】
        /// </summary>
        public bool RefundType { get; set; }
        /// <summary>
        /// 对应517GUID号
        /// </summary>
        public Guid? Guid { get; set; }
        /// <summary>
        /// 验证项
        /// </summary>
        public string CheckItem { get; set; }
    }

    public class RequestRefund
    {
        public int ID { get; set; }
        /// <summary>
        /// 理由类型
        /// </summary>
        public EnumRefuse RefuseType { get; set; }
        /// <summary>
        /// 理由内容
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 退款类型【true:退票退款，false：退款不退票】
        /// </summary>
        public bool RefundType { get; set; }
        /// <summary>
        /// 对应517GUID号
        /// </summary>
        public Guid? Guid { get; set; }
        /// <summary>
        /// 验证项
        /// </summary>
        public string CheckItem { get; set; }
    }
}
