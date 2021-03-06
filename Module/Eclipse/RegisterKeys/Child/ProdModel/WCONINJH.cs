﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/1 17:43:17

 * 说明：
 * 
 * 修改者：           时间：               
 * 修改说明：
 * ========================================================================
*/
#endregion
using HeBianGu.Product.SimalorManager.Base.AttributeEx;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Product.SimalorManager.RegisterKeys.Eclipse
{
    /// <summary> 注入井 </summary>
     
    public class WCONINJH : ItemsKey<WCONINJH.Item>,IProductEvent
    {
        public WCONINJH(string _name)
            : base(_name)
        {

        }


        public void SetWellName(string wellName)
        {
            this.Items.ForEach(l => l.Name = wellName);
        }

        /// <summary> 项实体 </summary>
        public class Item : HeBianGu.Product.SimalorManager.Item,IProductItem
        {
            /// <summary> 井名 </summary>
            public string jm0;
            /// <summary> 注入流体 </summary>
            public string zrltlx1="WATER";
            /// <summary> 状态 </summary>
            public string jzkgz2="OPEN";
            /// <summary> 日注入量 </summary>
            public string rzrl3;
            /// <summary> 井底流压限制 </summary>
            public string jdlyxz4;
            /// <summary> 井口压力 </summary>
            public string jkyl5;
            /// <summary> VFP表号 </summary>
            public string VFP6;
            /// <summary> 挥发油浓度/溶解气浓度 </summary>
            public string hfynd7;
            /// <summary> 油体积分数 </summary>
            public string ytjfs8;
            /// <summary> 水体积分数 </summary>
            public string stjfs9;
            /// <summary> 气体积分数 </summary>
            public string qtjfs10;


            string formatStr = "{0}{1}{2}{3}{4}{5}{6}{7}{8}{9} /";

            /// <summary> 转换成字符串 </summary>
            public override string ToString()
            {
                return string.Format(formatStr, 
                    jm0.ToEclStr(), 
                    zrltlx1.ToEclStr(), 
                    jzkgz2.ToEclStr(),
                    this.rzrl3.ToDD(), 
                    this.jdlyxz4.ToDD(), 
                    this.jkyl5.ToDD(), 
                    this.VFP6.ToDD(), 
                    this.hfynd7.ToDD(), 
                    this.ytjfs8.ToDD(),
                    this.stjfs9.ToDD(),
                    this.qtjfs10.ToDD()
                    ); ;
            }

            /// <summary> 解析字符串 </summary>
            public override void Build(List<string> newStr)
            {
                for (int i = 0; i < newStr.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            this.jm0 = newStr[0];
                            break;
                        case 1:
                            this.zrltlx1 = newStr[1];
                            break;
                        case 2:
                            this.jzkgz2 = newStr[2];
                            break;
                        case 3:
                            this.rzrl3 = newStr[3];
                            break;
                        case 4:
                            this.jdlyxz4 = newStr[4];
                            break;
                        case 5:
                            this.jkyl5 = newStr[5];
                            break;
                        case 6:
                            this.VFP6 = newStr[6];
                            break;
                        case 7:
                            this.hfynd7 = newStr[7];
                            break;
                        case 8:
                            this.ytjfs8 = newStr[8];
                            break;
                        case 9:
                            this.stjfs9 = newStr[9];
                            break;
                        case 10:
                            this.qtjfs10 = newStr[10];
                            break;
                        default:
                            break;
                    }
                }
            }


            public string Name
            {
                get
                {
                   return this.jm0;
                }
                set
                {
                    this.jm0=value;
                }
            }
        }
    }
}
