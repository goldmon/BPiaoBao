﻿using BPiaoBao.Client.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BPiaoBao.Client.Account.View
{
    /// <summary>
    /// AllFinanceControl.xaml 的交互逻辑
    /// </summary>
    [Part(Main.AllFinanceCode)]
    public partial class AllFinanceControl : UserControl, IPart
    {
        public AllFinanceControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取内容
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetContent()
        {
            return this;
        }

        /// <summary>
        /// 获取标题
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public string Title
        {
            get { return "所有理财产品"; }
        }
    }
}
