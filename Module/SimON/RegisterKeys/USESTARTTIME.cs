﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/1 17:43:17

 * 说明：
 * 
 * 读取规则：找到ENDBOX退出读取，读到要修改的关键字放到ObsoverKey观察对象中
 * 

 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HeBianGu.Product.SimalorManager.RegisterKeys.SimON
{
    /// <summary> 范围类 </summary>
    public class USESTARTTIME : SingleKey
    {
        public USESTARTTIME(string _name)
            : base(_name)
        {
           
        }

    }
}
