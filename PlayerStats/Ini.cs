using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.IO;
 using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Exiled.API.Features;

namespace YYYLike
{
     public class IniFile
     {
         #region API函数声明
 
         [DllImport("kernel32")]//返回0表示失败，非0为成功
         private static extern long WritePrivateProfileString(string section, string key,
             string val, string filePath);
 
         [DllImport("kernel32")]//返回取得字符串缓冲区的长度
         private static extern long GetPrivateProfileString(string section, string key,
             string def, StringBuilder retVal, int size, string filePath);


        #endregion
        /// <summary>
        /// 读Ini文件
        /// </summary>
        /// <param name="Section">[]内的段落名</param>
        /// <param name="Key">key</param>
        /// <param name="NoText"></param>
        /// NoText对应API函数的def参数，它的值由用户指定，是当在配置文件中没有找到具体的Value时，就用NoText的值来代替。可以为空
        /// <param name="iniFilePath">ini配置文件的路径加ini文件名</param>
        /// <returns></returns>
        #region 读Ini文件

        public static int ReadExp(string steam64id)
        {
            string path = "C:\\\\经验\\\\" + steam64id;
            if (File.Exists(path))
            {
                string[] conf = File.ReadAllLines(path);
                foreach (string cat in conf)
                {
                    if (cat.Contains("="))
                    {
                        if (cat.Split('=')[0] == steam64id)
                        {
                            string s = cat;
                            Regex r = new Regex(steam64id + "=");
                            try
                            {
                                return int.Parse(r.Replace(s, "", 1));
                            }
                            catch
                            {
                                return 0;
                            }
                        }
                    }
                }
                return 0;
            }
            else
            {
                File.WriteAllText(path,"");
                return 0;
            }
        }
        public static int ReadLevel(int exp)
        {
            int Lv = 0;
            Lv = exp / 500;
            return Lv;
        }

        public static string ReadLevel2(int exp)
        {
            int Lv = 0;
            string Lv2 = "";

            Lv = exp / 1000;
            if(Lv <=10)
            {
                Lv2 = Lv.ToString() + "|Neutralized";
            }
            if(Lv >10 && Lv <=30)
            {
                Lv2 = Lv.ToString() + "|Safe";

            }
            if (Lv > 30 && Lv <= 60 )
            {
                Lv2 = Lv.ToString() + "|Euclid";

            }
            if (Lv > 60 && Lv <= 100)
            {
                Lv2 = Lv.ToString() + "|Keter";
            }
            if (Lv > 100 && Lv <= 150)
            {
                Lv2 = Lv.ToString() + "|Thaumiel";
            }
            if (Lv > 150)
            {
                Lv2 = Lv.ToString() + "|O5";
            }
            return Lv2;
        }
        public static bool AddExp(string steam64id, int Exp)
        {
            string path = "C:\\\\经验\\\\"+steam64id;

            if (File.Exists(path))
            {
                string[] conf = File.ReadAllLines(path);
                foreach (string cat in conf)
                {
                    if (cat.Contains("="))
                    {
                        if (cat.Split('=')[0] == steam64id)
                        {
                            string s = cat;
                            Regex r = new Regex(steam64id + "=");
                            try
                            {
                                string sa = File.ReadAllText(path);
                                Regex ra = new Regex(steam64id + "="+ r.Replace(s, "", 1));
                                File.WriteAllText(path, ra.Replace(sa, steam64id + "=" + (int.Parse(r.Replace(s, "", 1)) + Exp).ToString(), 1));
                                if (Player.Get(steam64id) != null)
                                {
                                    EventHandlers.setnick(Player.Get(steam64id).ReferenceHub);
                                }
                                return true;
                            }
                            catch
                            {
                                return false;
                            }
                        }
                    }
                }
                File.WriteAllText(path, File.ReadAllText(path)+"\n"+steam64id+"="+Exp.ToString());
                return false;
            }
            else
            {
                File.WriteAllText(path, "");
                return false;
            }
        }
        #endregion
    }
 }