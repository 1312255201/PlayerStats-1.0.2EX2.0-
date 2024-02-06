using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Hints;
using Interactables.Interobjects.DoorUtils;
using MEC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYYLike
{
    //本文件为投票踢人插件awa
    //注册 OnCommandSend
    public class KickPlayer
    {
        private Player 被踢的人;
        private string 理由;
        private string 被踢玩家名称;
        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();
        private bool kickcd;
        private string 最后投票玩家名称;
        public List<int> 已经参与投票的人ID = new List<int>();
        private int 赞成;
        private int 否决;
        private string 发起者名称;
        private bool 投票发起;
        private string doorname;

        public void OnCommandSend(SendingConsoleCommandEventArgs ev)
        {
            if (ev.Name == "kick")
            {
                
                if (ev.Arguments.Count() != 2)
                {
                    Log.Info(ev.Arguments.Count());

                    ev.ReturnMessage = "错误，使用方法 kick [id] [理由]";
                }
                if (ev.Arguments.Count() == 2)
                {
                    if (kickcd == false)
                    {
                        被踢的人 = Player.Get(int.Parse(ev.Arguments[0]));

                        if (被踢的人 != null)
                        {
                            投票发起 = true;

                            理由 = ev.Arguments[1];
                            被踢玩家名称 = 被踢的人.Nickname;
                            发起者名称 = ev.Player.Nickname;
                            已经参与投票的人ID.Add(ev.Player.Id);
                            已经参与投票的人ID.Add(被踢的人.Id);
                            赞成++;
                            否决++;
                            Coroutines.Add(Timing.RunCoroutine(Whereareyou()));
                            Coroutines.Add(Timing.RunCoroutine(Whereareyou2()));

                        }
                        else
                        {
                            ev.ReturnMessage = "错误 玩家不存在";
                        }
                    }
                }
            }
            if (ev.Name == "kickyes")
            {
                if (!已经参与投票的人ID.Contains(ev.Player.Id))
                {
                    最后投票玩家名称 = ev.Player.Nickname;
                    已经参与投票的人ID.Add(ev.Player.Id);
                    赞成++;
                }

            }
            if (ev.Name == "kickno")
            {
                if (!已经参与投票的人ID.Contains(ev.Player.Id))
                {
                    最后投票玩家名称 = ev.Player.Nickname;
                    已经参与投票的人ID.Add(ev.Player.Id);
                    否决++;
                }


            }
/*            if(ev.Name == "bad")
            {
                Timing.RunCoroutine(Bad());
            }*/
        }
        private IEnumerator<float> Bad()
        {
            while(true)
            {
                foreach(Player player in Player.List)
                {
                    if(player.Role != RoleType.Spectator)
                    {
                        if (player.Team == Team.SCP)
                        {
                            foreach (DoorVariant room in Map.Doors)
                            {
                                try
                                {
                                    doorname = room.GetComponent<DoorNametagExtension>().GetName;
                                }
                                catch
                                {

                                }
                            }

                        }
                        else
                        {
                            foreach (DoorVariant room in Map.Doors)
                            {
                                try
                                {
                                    doorname = room.GetComponent<DoorNametagExtension>().GetName;
                                }
                                catch
                                {

                                }
                            }

                        }
                    }
                    else
                    {
                        if (player.Team == Team.SCP)
                        {
                            foreach (DoorVariant room in Map.Doors)
                            {
                                try
                                {
                                    doorname = room.GetComponent<DoorNametagExtension>().GetName;
                                }
                                catch
                                {

                                }
                            }

                        }
                        else
                        {
                            foreach (DoorVariant room in Map.Doors)
                            {
                                try
                                {
                                    doorname = room.GetComponent<DoorNametagExtension>().GetName;
                                }
                                catch
                                {

                                }
                            }

                        }
                    }
                }
            }
        }
        //投票信息显示
        private IEnumerator<float> Whereareyou()
        {
            while (投票发起)
            {
                yield return Timing.WaitForSeconds(1f);
                string temp = "<align=left>" + "<pos=-27%>正在进行投票踢人" + "\n<pos=-27%>发起者:" + 发起者名称 + "被投票请出的人:" + 被踢玩家名称 + "\n<pos=-27%>原因:" + 理由+"\n<pos=-27%>当前已参与人数" + 已经参与投票的人ID.Count() + "/" + Player.List.Count()+"最后投票玩家"+ 最后投票玩家名称 + "\n<pos=-27%>同意："+赞成+"否决:"+否决 + "\n<pos=-27%>按~打开控制台.kickyes同意.kickno不同意<pos=-27%>\n\n\n\n\n\n";

                foreach(Player player in Player.List)
                {
                    player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1] { new StringHintParameter("") }));

                }
            }
        }
        //投票计时
        private IEnumerator<float> Whereareyou2()
        {
            yield return Timing.WaitForSeconds(60f);
            if(已经参与投票的人ID.Count()>= Player.List.Count()/2)
            {
                if(赞成 - 否决 >= 2)
                {
                    被踢的人.Ban(10, "你已经被投票踢出 投票t出为玩家决定与服务器无关");
                    Reset();
                }
                Reset();

            }
            else
            {
                Map.Broadcast(10, "踢出失败 参与投票人数不足");
                Reset();
            }

        }
        //回合结束
        public void OnRoundEnd(RoundEndedEventArgs ev)
        {
            Reset();
        }
        //投票重置
        public void Reset()
        {
            被踢的人 = null;
            理由 = "";
            foreach(CoroutineHandle coroutineHandle in Coroutines)
            {
                Timing.KillCoroutines(coroutineHandle);

            }
            Coroutines.Clear();
            kickcd = true;
            最后投票玩家名称 = "";
            已经参与投票的人ID.Clear();
            赞成 = 0;
            否决 = 0;
            发起者名称 = "";
            被踢玩家名称 = "";
            投票发起 = false;
        }
    }
}
