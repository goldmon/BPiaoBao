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

namespace BPiaoBao.Client.DomesticTicket.View
{
    /// <summary>
    /// TicketTableControl.xaml 的交互逻辑
    /// </summary>
    [Part("100131")]
    public partial class TicketTableControl : UserControl, IPart
    {
        public TicketTableControl()
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


        public string Title
        {
            get { return "机票总表"; }
        }
    }
}
