﻿#region <版 本 注 释>
/*
 * ========================================================================
 * Copyright(c) ********************, All Rights Reserved.
 * ========================================================================
 *    
 * 作者：[HeBianGu]   时间：2015/12/1 17:43:33

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
     
    public class FAULTS : ItemsKey<FAULTS.Item>
    {
        public FAULTS(string _name)
            : base(_name)
        {

        }

        private string falutName;
        /// <summary> 断层名 </summary>
        public string FalutName
        {
            get { return falutName; }
            set { falutName = value; }
        }

        MULTFLT.Item multflt = null;
        /// <summary> 修正参数 </summary>
        public MULTFLT.Item Multflt
        {
            get { return multflt; }
            set { multflt = value; }
        }

        THPRESFT.Item thpresft = null;

        /// <summary> 启动压力 </summary>
        public THPRESFT.Item Thpresft
        {
            get { return thpresft; }
            set { thpresft = value; }
        }

        /// <summary> 项实体 </summary>
        public class Item : HeBianGu.Product.SimalorManager.Item
        {
            /// <summary> 断层名 </summary>
            public string dcm0;


            private string x11;
            /// <summary> X1 </summary>
            public string X11
            {
                get { return x11; }
                set { x11 = value; }
            }

            private string x22;
            /// <summary> X2 </summary>
            public string X22
            {
                get { return x22; }
                set { x22 = value; }
            }

            private string y13;
            /// <summary> Y1 </summary>
            public string Y13
            {
                get { return y13; }
                set { y13 = value; }
            }

            private string y24;
            /// <summary> Y2 </summary>
            public string Y24
            {
                get { return y24; }
                set { y24 = value; }
            }

            private string z15;
            /// <summary> Z1 </summary>
            public string Z15
            {
                get { return z15; }
                set { z15 = value; }
            }

            private string z26;
            /// <summary> Z2 </summary>
            public string Z26
            {
                get { return z26; }
                set { z26 = value; }
            }

            private string dcm7 = "X";
            /// <summary> 断层面 </summary>
            public string Dcm7
            {
                get { return dcm7; }
                set { dcm7 = value; }
            }


            string formatStr = "{0}{1}{2}{3}{4}{5}{6}{7} /";

            /// <summary> 转换成字符串 </summary>
            public override string ToString()
            {
                return string.Format(formatStr, dcm0.ToEclStr(), x11.ToDD(), x22.ToDD(), y13.ToDD(), y24.ToDD(), z15.ToDD(), z26.ToDD(), dcm7.ToEclStr()); ;
            }

            /// <summary> 解析字符串 </summary>
            public override void Build(List<string> newStr)
            {

                for (int i = 0; i < newStr.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            this.dcm0 = newStr[0];
                            break;
                        case 1:
                            this.x11 = newStr[1];
                            break;
                        case 2:
                            this.x22 = newStr[2];
                            break;
                        case 3:
                            this.y13 = newStr[3];
                            break;
                        case 4:
                            this.y24 = newStr[4];
                            break;
                        case 5:
                            this.z15 = newStr[5];
                            break;
                        case 6:
                            this.z26 = newStr[6];
                            break;
                        case 7:
                            this.dcm7 = this.TransToDcm(newStr[7]);
                            break;
                        default:
                            break;
                    }
                }

            }


            string TransToDcm(string str)
            {
                str = str.Trim();

                switch (str)
                {
                    case "I":
                        return "X";

                    case "J":
                        return "Y";

                    case "K":
                        return "Z";

                    default:
                        return str;
                }
            }

        }

    }
}
