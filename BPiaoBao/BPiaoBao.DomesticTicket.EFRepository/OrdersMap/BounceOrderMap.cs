﻿using BPiaoBao.DomesticTicket.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace BPiaoBao.DomesticTicket.EFRepository.OrdersMap
{
    public class BounceOrderMap : EntityTypeConfiguration<BounceOrder>
    {
        public BounceOrderMap()
        {
            this.Property(t => t.AttachmentUrl).HasColumnName("BounceAttachmentUrl");
        }
    }
}
