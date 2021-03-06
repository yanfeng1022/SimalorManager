﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/1 17:43:17

 * 说明：
 * 
GCONPROD
'G' ORAT 11000 3* CON /
/

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
    /// <summary> 生产井组控制 </summary>
     
    public class GCONPROD : ItemsKey<GCONPROD.Item>
    {
        public GCONPROD(string _name)
            : base(_name)
        {

        }



        /// <summary> 黑油项实体 </summary>
        public class Item : HeBianGu.Product.SimalorManager.Item
        {
            /// <summary> 井组名 </summary>
            public string jzm0="FIELD";
            /// <summary> 控制模式 </summary>
            public string kzms1 = "NONE";
            /// <summary> 日产油量 </summary>
            public string rcyl2;
            /// <summary> 日产水量 </summary>
            public string rcsl3;
            /// <summary> 日产气量 </summary>
            public string rcql4;
            /// <summary> 日产液量 </summary>
            public string rcyl5;
            /// <summary> 修井措施 </summary>
            public string xjcs6 = "NONE";
            /// <summary> 高级井组控制 </summary>
            public string gjjzkz7 = "YES";
            /// <summary> 指导产量 </summary>
            public string zdcl8;
            /// <summary> 流体相态 </summary>
            public string ltxt9;
            /// <summary> 产水违反修井 </summary>
            public string cswfxj10;
            /// <summary> 产气违反修井 </summary>
            public string cqwfxj11;
            /// <summary> 产液违反修井 </summary>
            public string cywfxj12;
            /// <summary> 油藏体积流量 </summary>
            public string yctjll13;
            /// <summary> 油藏条件产量百分比 </summary>
            public string yctjclbfb14;
            /// <summary> 日产湿气量 </summary>
            public string rcsql15;


            string formatStr = "{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}/";

            /// <summary> 转换成字符串 </summary>
            public override string ToString()
            {
                return string.Format(formatStr, jzm0.ToEclStr(), kzms1.ToEclStr(), rcyl2.ToDD(), rcsl3.ToDD(), rcql4.ToDD(),
                    rcyl5.ToDD(), xjcs6.ToEclStr(), gjjzkz7.ToEclStr(), zdcl8.ToDD(), ltxt9.ToDD(), cswfxj10.ToDD(), this.cqwfxj11.ToDD(),
                    this.cywfxj12.ToDD(), this.yctjll13.ToDD(), this.yctjclbfb14.ToDD(), this.rcsql15.ToDD());
            }

            /// <summary> 解析字符串 </summary>
            public override void Build(List<string> newStr)
            {
                for (int i = 0; i < newStr.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            this.jzm0 = newStr[0];
                            break;
                        case 1:
                            this.kzms1 = newStr[1];
                            break;
                        case 2:
                            this.rcyl2 = newStr[2];
                            break;
                        case 3:
                            this.rcsl3 = newStr[3];
                            break;
                        case 4:
                            this.rcql4 = newStr[4];
                            break;
                        case 5:
                            this.rcyl5 = newStr[5];
                            break;
                        case 6:
                            this.xjcs6 = newStr[6];
                            break;
                        case 7:
                            this.gjjzkz7 = newStr[7];
                            break;
                        case 8:
                            this.zdcl8 = newStr[8];
                            break;
                        case 9:
                            this.ltxt9 = newStr[9];
                            break;
                        case 10:
                            this.cswfxj10 = newStr[10];
                            break;
                        case 11:
                            this.cqwfxj11 = newStr[11];
                            break;
                        case 12:
                            this.cywfxj12 = newStr[12];
                            break;
                        case 13:
                            this.yctjll13 = newStr[13];
                            break;
                        case 14:
                            this.yctjclbfb14 = newStr[14];
                            break;
                        case 15:
                            this.rcsql15 = newStr[15];
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
                    return jzm0;
                }
                set
                {
                    jzm0 = value;
                }
            }

        }
    }



}
