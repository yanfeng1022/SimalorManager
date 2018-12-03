﻿using HeBianGu.Product.SimalorManager.Base.AttributeEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeBianGu.Product.SimalorManager.RegisterKeys.Eclipse
{
     [KeyAttribute(EclKeyType = EclKeyType.Props, SimKeyType = SimKeyType.Eclipse )]
    public class SOWCR: TableKey
    {
        public SOWCR(string name)
            : base(name)
        {

        }
    }
}
