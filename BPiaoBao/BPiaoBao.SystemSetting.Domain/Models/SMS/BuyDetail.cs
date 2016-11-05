﻿using JoveZhao.Framework.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BPiaoBao.Common.Enums;

namespace BPiaoBao.SystemSetting.Domain.Models.SMS
{
    public class BuyDetail : ValueObjectBase
    {
        public int ID { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public string PayNo { get; set; }
        /// <summary>
        /// 外部流水号
        /// </summary>
        public string OutPayNo { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime BuyTime { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 购买条数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal PayAmount { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public EnumPayMethod PayWay { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public EnumPayStatus BuyState { get; set; }
        /// <summary>
        /// 支付手续费
        /// </summary>
        public decimal PayFee { get; set; }
    }
}
