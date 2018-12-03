﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/1 15:35:04
 * 说明：
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
     
    public class END : BaseKey
    {
        public END(string _name)
            : base(_name)
        {

        }

        public override void WriteKey(System.IO.StreamWriter writer)
        {
            base.WriteKey(writer);

            writer.WriteLine(this.Name);
        }
    }
}
