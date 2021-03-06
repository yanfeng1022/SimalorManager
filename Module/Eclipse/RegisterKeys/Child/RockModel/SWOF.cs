﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/2 10:38:01

 * 说明：


/
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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Product.SimalorManager.RegisterKeys.Eclipse
{
    /// <summary> 油水相渗 </summary>
    [KeyAttribute(EclKeyType = EclKeyType.Props )]
    public class SWOF : RegionKey<SWOF.Item>
    {
        public SWOF(string _name)
            : base(_name)
        {

        }

        /// <summary> 分区数量 </summary>
        public int RegionCount=0;


        public class Item: HeBianGu.Product.SimalorManager.ItemNormal
        {
            /// <summary> 含水饱和度 </summary>
            public string hsbhd;
           /// <summary> 水相相对渗透率 </summary>
            public string sxxdstl;
           /// <summary> 油相相对渗透率 </summary>
            public string yxxdstl;
           /// <summary> 毛管压力 </summary>
            public string mgyl;


           string formatStr = "{0}{1}{2}{3}";

            /// <summary> 转换成字符串 </summary>
            public override string ToString()
            {
                return string.Format(formatStr, hsbhd.ToSaveLockDD(), sxxdstl.ToSaveLockDD(), yxxdstl.ToSaveLockDD(), mgyl.ToSaveLockDD());
            }



            /// <summary> 解析字符串 </summary>
            public override void Build(List<string> newStr)
            {

                for (int i = 0; i < newStr.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            this.hsbhd = newStr[0];
                            break;
                        case 1:
                            this.sxxdstl = newStr[1];
                            break;
                        case 2:
                            this.yxxdstl = newStr[2];
                            break;
                        case 3:
                            this.mgyl = newStr[3];
                            break;
                        default:
                            break;
                    }
                }
            }



            public override object Clone()
            {
                Item item = new Item()
                {
                    hsbhd = this.hsbhd,
                    sxxdstl = this.sxxdstl,
                    yxxdstl=this.yxxdstl,
                    mgyl=this.mgyl
                };
                return item;
            }
        }
    }
}
