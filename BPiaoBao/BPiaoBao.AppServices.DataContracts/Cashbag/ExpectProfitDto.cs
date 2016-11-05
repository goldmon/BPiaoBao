﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.AppServices.DataContracts.Cashbag
{
    /// <summary>
    /// 收益
    /// </summary>
    public class ExpectProfitDto
    {
        /// <summary>
        /// 提前终止转出收益
        /// </summary>
        public decimal Profit { get; set; }
        /// <summary>
        /// 正常转出收益
        /// </summary>
        public decimal NormalProfit { get; set; }
    }
}