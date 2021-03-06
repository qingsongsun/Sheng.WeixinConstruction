﻿using Linkup.DataRelationalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    [Table("MemberTag")]
    public class MemberTagEntity
    {
        private Guid _id = Guid.NewGuid();
        [Key]
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Guid Domain
        {
            get;
            set;
        }

        public string AppId
        {
            get;
            set;
        }

        /// <summary>
        /// 微信端Id
        /// </summary>
        [OrderBy(OrderBy = OrderBy.ASC)]
        public int TagId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
