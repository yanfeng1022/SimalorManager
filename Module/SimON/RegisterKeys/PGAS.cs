﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/1 13:39:53

 * 说明：
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using HeBianGu.Product.SimalorManager.Base.AttributeEx;
using HeBianGu.Product.SimalorManager.Eclipse.FileInfos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HeBianGu.Product.SimalorManager.RegisterKeys.SimON
{
    /// <summary>  </summary
    [KeyAttribute(EclKeyType = EclKeyType.Grid, SimKeyType = SimKeyType.SimON)]
    public class PGAS : TableKey
    {
        public PGAS(string _name)
            : base(_name)
        {

        }
    }
}
