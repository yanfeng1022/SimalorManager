﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) 北京奥伯特石油科技有限公司, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[李海军]   时间：2015/12/1 13:39:53
 * 文件名：COORD
 * 说明：
 * 
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using OPT.Product.SimalorManager.Base.AttributeEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Product.SimalorManager.RegisterKeys.Eclipse
{
    [KeyAttribute(EclKeyType = EclKeyType.Include, IsBigDataKey = true)]
    public class ENDSCALE : Key
    {
        public ENDSCALE(string _name)
            : base(_name)
        {

        }

        public override void WriteKey(System.IO.StreamWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine(this.Name);
            writer.WriteLine(KeyConfiger.EndFlag);
        }

    }
}
