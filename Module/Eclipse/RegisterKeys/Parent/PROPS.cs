﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/11/28 13:46:37

 * 说明：PROPS(必须)     油层岩石和流体性质（密度、粘度、相对渗透率、毛管压力等）随压力、饱和度、组分变化表；
 * 
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using HeBianGu.Product.SimalorManager.Base.AttributeEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Product.SimalorManager.RegisterKeys.Eclipse
{
    /// <summary> (必须)油层岩石和流体性质（密度、粘度、相对渗透率、毛管压力等）随压力、饱和度、组分变化表 </summary>
    [KeyAttribute(EclKeyType = EclKeyType.Parent)]
    public class PROPS : ParentKey
    {
        public PROPS(string _name)
            : base(_name)
        {

        }
    }
}
