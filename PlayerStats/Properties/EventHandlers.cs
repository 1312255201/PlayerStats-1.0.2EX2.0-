using System;
using System.Collections.Generic;
using System.Threading;
using EXILED;
using EXILED.ApiObjects;
using EXILED.Extensions;
using Grenades;
using MEC;
using Mirror;
using Telepathy;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Assertions.Must;
namespace PlayerStats
{
    public class EventHandlers
    {
        public static string url = "http://127.0.0.1:4578/";

        private int scp079id = -1;
        private bool h;
        private bool choise;

        private ReferenceHub scp;
        private bool die;
        private bool start;
        private int int222;
        private DateTime maxtime;
        public static List<String> scp_999 = new List<String>();



        private string SCP173;
        private string SCP049;
        private string SCP079;
        private string SCP096;
        private string SCP939_89;
        private string SCP939_53;
        private string SCP106;
        private int s173;
        public int s049;
        private int s096;
        private int s939_53;
        private int s939_89;
        private int s106;
        private int KillerID;
        private int PlayerID;
        private int RoleSet = 0;
        public bool roundstart = false;
        public int[] GuardType = new int[200];
        public int Guardnum = 0;
        public int count = 0;
        public DateTime updatatimer = DateTime.Now;
        public int deadtimer = 0;
        public bool starttimer = false;



        private bool firstscp;
        public bool deadtime = false;
        public int count2 = 0;
        private int waring1;
        private int playernum = 0;
        public bool waring = false;
        public int[] touxiang = new int[0x65];
        private int round = 0;
        public int chaos = 0;
        public int mtf = 0;
        public int mtfchange = 0;
        public int chaoschange = 0;
        private int Count = 0;
        private int issuperTrue = 0;
        private int issuperFalse = 0;
        private int coldtime = 0;
        private int coldtime2 = 2;
        private bool coldbc = false;
        private bool coldtb = false;
        private int ini10;
        private int xp;
        private int lv;
        private bool coldwait233;
        private bool Dio1;
        private bool sjtz1;
        private bool sjtz2;
        private Thread cd;
        private bool ylb1;
        private DateTime updatatimer2 = DateTime.Now;
        private DateTime updatatimer5 = DateTime.Now;
        private DateTime updatatimer6 = DateTime.Now;


        private DateTime updatatimer7 = DateTime.Now;
        private int tiems;
        private int scp073id;
        private bool mrfishzb = true;
        private bool scp076yes;
        private bool scp076iteam;
        private int scp076id;
        private bool xhsnb;
        private int xhsnb2;
        private int scp2818id;
        private bool scp2818pick;
        private bool hhzhgzb = true;
        private int times2;
        private bool scp1143a;
        private int scp1143id;
        private ReferenceHub jwhng;
        private int jwhngid;
        private int times;
        private DateTime updatatimer3 = DateTime.Now;
        private bool bpb;
        private bool jljy1;
        private bool jljyzb;
        private ReferenceHub scp181;
        private int scp181id;
        private ReferenceHub cxk;


        //181�ı�������
        public int cxkid;
        public bool jntm;
        public bool cxkyes;
        private bool cxkflash;
        public int scp817id;
        private ReferenceHub scp817;
        public bool scp817yes;
        public int D9341id;
        private bool d9341flash;
        public bool D9341yes;
        public int times1 = 0;
        public bool jntmlq;
        public int times3 = 0;
        private ReferenceHub scp2006;
        private int scp2006id;
        private bool scp035health;
        public int scp035id;
        private bool scp035item2;
        private int times5 = 1;
        private int scpqblid2;
        private ReferenceHub scpqbl;
        private string scpqblid;
        private int scp914mid;
        private DateTime updatatimer181 = DateTime.Now;
        private DateTime updatatimer182 = DateTime.Now;
        private DateTime updatatimer183 = DateTime.Now;
        private DateTime updatatimer184 = DateTime.Now;
        private DateTime updatatimer185 = DateTime.Now;
        private DateTime updatatimer186 = DateTime.Now;
        private int scp939id;
        private bool jkl;
        private string jklid;
        private bool qblcq2;
        private ReferenceHub xywj;
        private string xywjid;
        private bool bscp79;
        private int jwhhkid;
        private bool jwhngyes;
        private bool jwhngitem;
        private bool jwhngshuachu;
        private bool hrss;
        private int hktime;
        private bool csm;
        private int csmtime;
        private bool a127;
        private bool a127c;
        private int a127b;
        private ReferenceHub xtd;
        private int xtdid;
        private bool stealcd;
        private bool scp457a;
        private bool scp457die;
        private int scp457id;
        private int time2;
        private int time3;
        private bool scp005;
        private int scp005aid;
        private bool scp073a;
        private bool scp073zb = true;
        private bool a127d;
        private bool scp650yes;
        private ReferenceHub scp650;
        private int scp650id;
        private bool scp3108pick;
        private int scp3108playerid;
        private bool scp3108shotyes;
        private bool scp1577bj;
        private DateTime updatatimerscp1577;
        private bool scp1577pick;
        private int gjtr;
        private bool bhsx;
        private int njsxtimes;
        private bool yshkq;
        private int peaple;
        private bool sjqx;
        private DateTime upwait = DateTime.Now;
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public Dictionary<string, Stats> Stats = new Dictionary<string, Stats>();
        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();
        private Thread pmd;
        private ReferenceHub D9341;
        private RoleType D9341js;
        private List<string> scp2006a = new List<string>();
        private ReferenceHub scp035;
        private ReferenceHub scp914m;
        private ReferenceHub scp076;
        private List<ReferenceHub> player233 = new List<ReferenceHub>();
        private List<ReferenceHub> player22 = new List<ReferenceHub>();
        private List<string> hd = new List<string>();
        private List<int> jw = new List<int>();
        private ReferenceHub jwhhk;
        private Vector3 hkzb;
        private ReferenceHub scp073;
        private List<Inventory.SyncItemInfo> D9341Item;
        private Vector3 D9341zb;
        private ReferenceHub scp457;
        private List<string> Dio2 = new List<string>();
        private ReferenceHub scpqbl3;
        private ReferenceHub qblcq;
        private List<string> HDZHG2 = new List<string>();
        private List<int> LLBS233 = new List<int>();
        private List<Door> door2 = new List<Door>();
        private List<string> jljy2 = new List<string>();
        private Door door3;
        private List<string> scp682 = new List<string>();
        private List<string> ylb2 = new List<string>();
        private List<int> bpb2 = new List<int>();
        private List<int> scp1577id = new List<int>();
        private List<Door> doord = new List<Door>();
        private ReferenceHub scp2818;
        private ReferenceHub Dio;
        private List<ReferenceHub> player5 = new List<ReferenceHub>();
        private List<Vector3> pos1 = new List<Vector3>();
        private Vector3 scp1577pos;
        private List<ReferenceHub> playerqwq = new List<ReferenceHub>();
        private ReferenceHub scp1143;
        private ReferenceHub HDZHG;
        private ReferenceHub mrfish;
        private Vector3 pos4;
        private ReferenceHub jljy;
        private Vector3 scp457b;
        private ReferenceHub ylb;
        private Vector3 pos3;
        private ReferenceHub scp106a;
        private List<ReferenceHub> scpd79 = new List<ReferenceHub>();
        private Vector3 LCZ;
        private Vector3 scp3108shotatplayerpos;
        private Vector3 pos2;
        private int d = 0;
        private int s;
        private int card;
        private bool scp2006coin;
        private bool scp999yes;
        private bool scp457tp;
        private bool diotp;
        private int ragdolltime;
        private int itemtime; 
        private bool scp999tp;
        private List<ReferenceHub> playerdio = new List<ReferenceHub>();
        private bool scp035goout;
        private bool diyicizhixingzheli;
        private bool xitonghedan;
        private Vector3 pos5;
        private bool jwhngwufashanghai;
        private bool bscd;
        private ReferenceHub hpsz;
        private int hpszid;
        private ReferenceHub scp550;
        private int scp550id;
        private bool scp550item;
        private bool scp550yes;
        private bool scp550shuachu;
        private List<Inventory.SyncItemInfo> scp035item;
        private bool scp035yes;
        private bool mzyes;
        private ReferenceHub mz;
        private int mzid;
        private bool mzzb;
        private List<Inventory.SyncItemInfo> item;
        private float health;
        private bool meitunshi;
        private int tssj;
        private int scp550lv;
        private int tssl;
        private bool scp79;
        private float scp457health;

        public void SetPlayerScale(GameObject target, float x, float y, float z)
        {
            try
            {
                NetworkIdentity identity = target.GetComponent<NetworkIdentity>();
                

                target.transform.localScale = new Vector3(1 * x, 1 * y, 1 * z);

                ObjectDestroyMessage destroyMessage = new ObjectDestroyMessage();
                destroyMessage.netId = identity.netId;


                foreach (GameObject player in PlayerManager.players)
                {
                    if (player == target)
                        continue;

                    NetworkConnection playerCon = player.GetComponent<NetworkIdentity>().connectionToClient;

                    playerCon.Send(destroyMessage, 0);

                    object[] parameters = new object[] { identity, playerCon };
                    typeof(NetworkServer).InvokeStaticMethod("SendSpawnMessage", parameters);
                }
            }
            catch (Exception e)
            {
                Log.Info($"��С����ʧ��: {e}");
            }
        }
        public void ONWarheadCancelled(WarheadCancelEvent ev)
        {
            if (xitonghedan == true)
            {
                ev.Player.Broadcast(2, "<color=red>[����]</color>\n<color=lime>ϵͳ�˵��޷��ر�</color>", false);
                ev.Allow = false;

            }
        }
        public void OnWaitingForPlayers()
        {
            pmd = new Thread(PMD);
            pmd.Start();

            Coroutines.Add(Timing.RunCoroutine(SecondCounter()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter2()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter3()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter4()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter5()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter6()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter7()));

            Coroutines.Add(Timing.RunCoroutine(SecondCounter8()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter9()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter10()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter11()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter12()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter13()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter14()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter15()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter16()));

            Coroutines.Add(Timing.RunCoroutine(SecondCounter18()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter19()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter17()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter20()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter21()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter22()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter23()));

        }
        private IEnumerator<float> SecondCounter28()
        {
            yield return Timing.WaitForSeconds(2f);
            foreach(Inventory.SyncItemInfo item2 in D9341.GetAllItems())
            {
                D9341.RemoveItem(item2);
            }
            foreach (Inventory.SyncItemInfo item2 in D9341Item)
            {
                D9341.AddItem(item2);
            }
            D9341.SetPosition(D9341zb);
        }
        private IEnumerator<float> RunRestoreMaxHp(ReferenceHub player, int maxHp)
        {
            yield return Timing.WaitForSeconds(0.1f);
            
            player.playerStats.maxHP = maxHp;
            player.SetHealth(maxHp);
        }
        private IEnumerator<float> SecondCounter25()
        {
            yield return Timing.WaitForSeconds(2f);

            foreach (Inventory.SyncItemInfo syncItemInfo in jwhng.GetAllItems())
            {
                jwhng.RemoveItem(syncItemInfo);
            }

            foreach (Inventory.SyncItemInfo syncItemInfo in item)
            {
                jwhng.AddItem(syncItemInfo);
            }

            jwhng.SetHealth(health);
            bscd = true;
        }
        private IEnumerator<float> SecondCounter24()
        {
            yield return Timing.WaitForSeconds(2f);
            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 500)));

            foreach (Inventory.SyncItemInfo item in scp035.GetAllItems())
            {
                scp035.RemoveItem(item);
            }
            foreach (Inventory.SyncItemInfo item in scp035item)
            {
                scp035.AddItem(item);
            }
        }

        private IEnumerator<float> SecondCounter23()
        {
            for (; ; )
            {
                if (jwhngwufashanghai == true)
                {
                    yield return Timing.WaitForSeconds(120f);
                    jwhngwufashanghai = false;
                    jwhng.ClearBroadcasts();
                    jwhng.Broadcast(10, "<color=red>�����ڿ��Ա�ɻ��繥����β����</color>",false);
                }
                foreach (ReferenceHub referenceHub1 in Player.GetHubs())
                {
                    if (referenceHub1.GetHealth() <= 0)
                    {
                        referenceHub1.SetRole(RoleType.Spectator);
                    }
                }
                if(scp035yes == true)
                {
                    scp035.AddHealth(-10);
                    if(scp035.GetHealth() <= 0)
                    {
                        scp035.SetRole(RoleType.Spectator);
                        scp035id = 0;
                        scp035goout = false;
                        scp035yes = false;
                        scp035 = null;
                    }
                }
                yield return Timing.WaitForSeconds(10f);
            }

        }


        private IEnumerator<float> SecondCounter22()
        {
            for (; ; )
            {
                if (scp457a == true)
                {
                    scp457b = scp457.GetPosition();
                    float num2 = scp457b.x + 4;
                    float num3 = scp457b.y + 4;
                    float num4 = scp457b.z + 4;
                    float num5 = scp457b.x - 4;
                    float num6 = scp457b.y - 4;
                    float num7 = scp457b.z - 4;

                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if ((player.GetTeam() != Team.SCP) && (player.GetPlayerId() != scp457id) && (player.GetPosition().x <= num2) && (player.GetPosition().x >= num5) && (player.GetPosition().y <= num3) && (player.GetPosition().y >= num6) && (player.GetPosition().z <= num4) && (player.GetPosition().z >= num7))
                        {
                            player.AddHealth(-3);
                            player.Broadcast(1, "SCP-457���㸽�������ڳ�����Ѫ", false);
                        }
                    }
                }

                yield return Timing.WaitForSeconds(1f);
            }

        }


        private IEnumerator<float> SecondCounter21()
        {
            for (; ; )
            {
                if(starttimer ==true)
                {
                    yield return Timing.WaitForSeconds(1800f);
                    Map.StartNuke();
                    xitonghedan = true;
                    Map.Broadcast("<color=red>[����]</color>\n<color=lime>ϵͳ�˵��ѿ����޷��ر�</color>", 4,  false);

                }
                yield return Timing.WaitForSeconds(5f);

            }

        }

        private IEnumerator<float> SecondCounter20()
        {
            for (; ; )
            {
                if((starttimer == true) &&(diyicizhixingzheli ==true))
                {
                    yield return Timing.WaitForSeconds(10f);
                    string[] textArray1 = new string[] { "[<color=#FFA500>", SCP173, "</color> <color=#008000>", SCP049, "</color> <color=#FF8C00>", SCP079, "</color> <color=#808080>", SCP096, "</color> <color=#800000>", SCP939_89, "</color> <color=#CD5C5C>", SCP939_53, "</color> <color=#D2691E>", SCP106, "</color>", "]\n<color=#FF0000>��⵽����SCP��ͻ������</color>" };
                    Map.Broadcast(string.Concat(textArray1), 12, false);
                    if (card == 1)
                    {
                        scp181.AddItem(ItemType.KeycardChaosInsurgency);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                    }
                    if (card == 2)
                    {
                        scp181.AddItem(ItemType.KeycardContainmentEngineer);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                        
                    }
                    if (card == 4)
                    {
                        scp181.AddItem(ItemType.KeycardJanitor);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 5)
                    {
                        scp181.AddItem(ItemType.KeycardScientistMajor);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 6)
                    {
                        scp181.AddItem(ItemType.KeycardNTFCommander);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 7)
                    {
                        scp181.AddItem(ItemType.KeycardNTFLieutenant);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 8)
                    {
                        scp181.AddItem(ItemType.KeycardO5);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 9)
                    {
                        scp181.AddItem(ItemType.KeycardScientist);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                    }
                    if (card == 10)
                    {
                        scp181.AddItem(ItemType.KeycardZoneManager);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if(scp035item2 == true)
                    {
                        Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 300)));

                        scp035.AddItem(ItemType.GunUSP);
                        scp035.AddItem(ItemType.Ammo9mm);
                        scp035.AddItem(ItemType.Ammo9mm);
                        scp035.AddItem(ItemType.Ammo9mm);
                        scp035.AddItem(ItemType.KeycardScientist);
                        scp035item2 = false;
                        foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
                        {
                            if(door.name == "173_ARMORY")
                            {
                                scp035.SetPosition(door.transform.position.x, door.transform.position.y+(float)1.5, door.transform.position.z);
                            }
                        }
                            
                    }
                    if (scp2006coin == true)
                    {
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006.AddItem(ItemType.Coin);
                        scp2006coin = false;
                    }
                    if (d9341flash == true)
                    {
                        D9341.AddItem(ItemType.Flashlight);
                        D9341.AddItem(ItemType.GrenadeFlash);
                        d9341flash = false;
                    }
                    if (cxkflash == true)
                    {
                        cxk.AddItem(ItemType.Flashlight);
                        cxkflash = false;
                    }
                    if (scp035health == true)
                    {
                        Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 500)));

                        scp035health = false;
                    }
                    if (scp076iteam == true)
                    {
                        scp076.AddItem(ItemType.GunE11SR);
                        scp076.AddItem(ItemType.Radio);
                        scp076.AddItem(ItemType.Adrenaline);
                        scp076.AddItem(ItemType.GrenadeFrag);
                        scp076.AddItem(ItemType.GrenadeFrag);
                        scp076.AddItem(ItemType.MicroHID);
                        scp076iteam = false;
                    }
                    diyicizhixingzheli = false;
                }

                yield return Timing.WaitForSeconds(10f);

            }

        }
        private IEnumerator<float> wdzs()
        {
            yield return Timing.WaitForSeconds(10f);

            foreach (ReferenceHub player3 in Player.GetHubs())
            {
                if (player3.GetRole() == RoleType.Scp173)
                {
                    if(player3.GetPlayerId()!= scp650id)
                    {
                        player3.SetHealth(4200);
                        player3.SetGodMode(false);
                    }

                }
            }
            xhsnb = false;
        }
        private IEnumerator<float> SecondCounter19()
        {
            for (; ; )
            {
                if(scp035goout == true)
                {

                    scp035.SetRank("SCP-035", "red", true);
                    Map.Broadcast("<color=red>��ΪSCP-035�ӳ���ʩ ÿ150s���������һ����β����Ӫ���</color>", 10, false);
                    yield return Timing.WaitForSeconds(150f);
                    foreach(ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(referenceHub.GetTeam() == Team.MTF)
                        {
                            referenceHub.Kill();
                            referenceHub.SetRole(RoleType.Spectator);
                            break;
                        }
                    }
                }
                yield return Timing.WaitForSeconds(1f);

            }

        }      
        private IEnumerator<float> SecondCounter18()
        {
            for (; ; )
            {
                if (roundstart == true)
                {
                    yield return Timing.WaitForSeconds(100f);
                    if(choise == false)
                    {
                        choise = true;
                        foreach (ReferenceHub p in Player.GetHubs())
                        {
                            if (p.GetRole() == RoleType.Scp079)
                            {
                                p.SetRank("SCP079 - ����SCP", "aqua", true);
                            }
                        }
                        Map.Broadcast("<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>������ܿ־�� ����SCP079ѡ�����SCP</color>\n<color=aqua>SCP�����ܵ��������˺�</color>", 10, false);
                    }

                }
                yield return Timing.WaitForSeconds(1f);

            }
        }
        private IEnumerator<float> SecondCounter17()
        {
            for (; ; )
            {
                if (times5 == 6)
                {
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            player.SetRank("�����ɱDD", "yellow",  true);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            player.SetRank("������˧����", "yellow",  true);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            player.SetRank("�¶�һ��", "lime", true);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            player.SetRank("���δ󷨺�", "yellow",  true);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            player.SetRank("��Ϊ��ħ�����Ժܰ�ѽ", "yellow", true);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            player.SetRank("�ϰ¡�������", "cyan", true);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            player.SetRank("��̱��̱", "cyan", true);
                        }
                    }
                    times5 = 1;
                }
                if (times5 == 5)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            player.SetRank("�����ɱDD", "green",  true);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            player.SetRank("������˧����", "green",  true);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            player.SetRank("�¶�һ��", "crimson", true);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            player.SetRank("���δ󷨺�", "green",  true);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            player.SetRank("��Ϊ��ħ�����Ժܰ�ѽ", "green", true);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            player.SetRank("�ϰ¡�������", "green",  true);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            player.SetRank("��̱��̱", "green", true);
                        }
                    }
                    times5 = 6;
                }
                if (times5 == 4)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            player.SetRank("�����ɱDD", "red",  true);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            player.SetRank("������˧����", "red",  true);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            player.SetRank("�¶�һ��", "cyan",  true);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            player.SetRank("���δ󷨺�", "red",  true);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            player.SetRank("��Ϊ��ħ�����Ժܰ�ѽ", "red", true);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            player.SetRank("�ϰ¡�������", "red",  true);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            player.SetRank("��̱��̱", "red", true);
                        }
                    }
                    times5 = 5;
                }
                if (times5 == 3)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            player.SetRank("�����ɱDD", "cyan",  true);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            player.SetRank("������˧����", "cyan",  true);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            player.SetRank("�¶�һ��", "red",  true);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            player.SetRank("���δ󷨺�", "cyan",  true);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            player.SetRank("��Ϊ��ħ�����Ժܰ�ѽ", "cyan",  true);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            player.SetRank("�ϰ¡�������", "pink",  true);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            player.SetRank("��̱��̱", "pink", true);
                        }
                    }
                    times5 = 4;
                }
                if (times5 == 2)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            player.SetRank("�����ɱDD", "crimson", true);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            player.SetRank("������˧����", "crimson",  true);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            player.SetRank("�¶�һ��", "green", true);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            player.SetRank("���δ󷨺�", "crimson",  true);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            player.SetRank("��Ϊ��ħ�����Ժܰ�ѽ", "crimson", true);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            player.SetRank("�ϰ¡�������", "orange",  true);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            player.SetRank("��̱��̱", "orange", true);
                        }
                    }
                    times5 = 3;
                }
                if (times5 == 1)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            player.SetRank("�����ɱDD", "lime", true);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            player.SetRank("������˧����", "lime",  true);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            player.SetRank("�¶�һ��", "yellow",  true);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            player.SetRank("���δ󷨺�", "lime",  true);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            player.SetRank("��Ϊ��ħ�����Ժܰ�ѽ", "lime",  true);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            player.SetRank("�ϰ¡�������", "yellow",  true);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            player.SetRank("��̱��̱", "yellow", true);
                        }
                    }
                    times5 = 2;
                }
                yield return Timing.WaitForSeconds(6f);
            }
        }
        private IEnumerator<float> SecondCounter16()
        {
            for (; ; )
            {
                foreach(ReferenceHub hub in Player.GetHubs())
                {
                    if(hub.GetRole() != RoleType.Scp173)
                    {
                        hub.SetGodMode(false);
                    }

                }
                bscd = false;
                yield return Timing.WaitForSeconds(10f);
            }
        }
        private IEnumerator<float> SecondCounter14()
        {
            for (; ; )
            {
                if (ylb1 == true)
                {
                    Vector3 pos2 = ylb.GetPosition();
                    float num2 = pos2.x + 3;
                    float num3 = pos2.y + 3;
                    float num4 = pos2.z + 3;
                    float num5 = pos2.x - 3;
                    float num6 = pos2.y - 3;
                    float num7 = pos2.z - 3;

                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if ((player3.GetTeam() == Team.MTF) && (player3.GetPosition().x <= num2) && (player3.GetPosition().x >= num5) && (player3.GetPosition().y <= num3) && (player3.GetPosition().y >= num6) && ((player3.GetPosition().z <= num4) && (player3.GetPosition().z >= num7)))
                        {
                            player3.AddHealth(1);
                            player3.Broadcast(5, "����˿���������", false);
                        }
                    }

                }
                if (lv == 1)
                {
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            player3.AddHealth(5);
                        }
                    }
                }
                if (lv == 2)
                {
                    ;
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            player3.AddHealth(10);
                        }
                    }
                }
                if (lv == 3)
                {
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            player3.AddHealth(15);
                        }
                    }
                }
                if (scp999yes == true)
                {
                    foreach (ReferenceHub player2 in Player.GetHubs())
                    {
                        if (player2.GetRole() == RoleType.FacilityGuard)
                        {
                            scp = player2;
                            die = false;
                            ScpSpawn();
                            scp999yes = false;
                            break;
                        }
                    }
                }
                yield return Timing.WaitForSeconds(5f);

            }
        }
        private IEnumerator<float> SecondCounter3()
        {
            for (; ; )
            {
                if (sjtz1 == true)
                {
                    foreach (ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(Dio2.Contains(referenceHub.GetUserId())==false)
                        {
                            referenceHub.SetPosition(referenceHub.GetPosition());
                        }
                    }
                    //for (int i = 0; i < playerdio.Count; i++)
                    //{
                      //  if (Dio2.Contains(playerdio[i].GetUserId()) == false)
                        //{
                          //  playerdio[i].SetPosition(pos1[i]);
                        //}
                   // }
                }
                if (qblcq2 == true)
                {
                    qblcq.SetPosition(scpqbl3.GetPosition());
                }
                yield return Timing.WaitForSeconds((float)0.2);
            }
        }

        private IEnumerator<float> SecondCounter12()
        {
            for (; ; )
            {
                if (cxkyes == true)
                {
                    yield return Timing.WaitForSeconds(100f);
                    cxk.AddItem(ItemType.Flashlight);
                    cxk.Broadcast(4, "����̫���������", false);
                }
                

                yield return Timing.WaitForSeconds(1f);
            }
        }
        private IEnumerator<float> SecondCounter13()
        {
            for (; ; )
            {
                if(scp817yes == true)
                {
                    yield return Timing.WaitForSeconds(150f);
                    pos3 = scp817.GetPosition();

                    int Rolenum = new System.Random().Next(1, 14);
                    if (Rolenum == 1)
                    {
                        scp817.SetRole(RoleType.Scientist, true);
                    }
                    if (Rolenum == 2)
                    {
                        scp817.SetRole(RoleType.ChaosInsurgency, true);
                    }
                    if (Rolenum == 3)
                    {
                        scp817.SetRole(RoleType.FacilityGuard, true);
                    }
                    if (Rolenum == 4)
                    {
                        scp817.SetRole(RoleType.NtfCadet, true);
                    }
                    if (Rolenum == 5)
                    {
                        scp817.SetRole(RoleType.NtfCommander, true);
                    }
                    if (Rolenum == 6)
                    {
                        scp817.SetRole(RoleType.NtfLieutenant, true);
                    }
                    if (Rolenum == 7)
                    {
                        scp817.SetRole(RoleType.NtfScientist, true);
                    }
                    if (Rolenum == 8)
                    {
                        scp817.SetRole(RoleType.Scp079, true);
                    }
                    if (Rolenum == 9)
                    {
                        scp817.SetRole(RoleType.Scp106, true);
                    }
                    if (Rolenum == 10)
                    {
                        scp817.SetRole(RoleType.Scp173, true);
                    }
                    if (Rolenum == 11)
                    {
                        scp817.SetRole(RoleType.Scp93953, true);
                    }
                    if (Rolenum == 12)
                    {
                        scp817.SetRole(RoleType.Scp93989, true);
                    }
                    if (Rolenum == 13)
                    {
                        scp817.SetRole(RoleType.Tutorial,true);
                    }

                    scp817.Broadcast(5, "�������qwq", false);
                    times3 = 1;
                    scp817.SetPosition(pos3);
                }
                yield return Timing.WaitForSeconds(10f);
            }
        }
        private IEnumerator<float> SecondCounter11()
        {
            for (; ; )
            {
                if(jntm == true)
                {
                    yield return Timing.WaitForSeconds(10f);
                    jntm = false;
                }
                yield return Timing.WaitForSeconds(1f);
            }
        }
        private IEnumerator<float> SecondCounter10()
        {
            for (; ; )
            {
                scp076.AddItem(ItemType.MicroHID);
                yield return Timing.WaitForSeconds(240f);
            }
        }
        private IEnumerator<float> SecondCounter9()
        {
            for (; ; )
            {
                if (scp3108shotyes == true)
                {
                    scp3108playerid = 0;
                }
                scp2006.AddItem(ItemType.Coin);
                foreach (ReferenceHub player in Player.GetHubs())
                {
                    if (player.GetTeam() == Team.SCP)
                    {
                        player.AddHealth(25);
                    }
                }
                if (bpb == true)
                {
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (bpb2.Contains(player.GetPlayerId()))
                        {
                            player.AddItem(ItemType.GrenadeFrag);
                        }
                    }
                }
                if (ylb1 == true)
                {
                    ylb.AddItem(ItemType.Medkit);
                }
                yield return Timing.WaitForSeconds(100f);
            }
        }
        private IEnumerator<float> SecondCounter8()
        {
            for (; ; )
            {

                foreach (GameObject d in GameObject.FindGameObjectsWithTag("Door"))
                {
                
                }
                foreach (ReferenceHub player in Player.GetHubs())
                {
                    if (player.GetUserId() == "76561198133773112@steam")
                    {
                        player.SetRank("BILIBILI_������", "lime", true);
                    }
                    if (player.GetUserId() == "76561198335932913@steam")
                    {
                        player.SetRank("�в���~", "lime", true);
                    }
                    if (player.GetUserId() == "76561198376557635@steam")
                    {
                        player.SetRank("VIP1", "lime", true);
                    }
                    if (player.GetUserId() == "76561198425823494@steam")
                    {
                        player.SetRank("˹����", "red", true);
                    }
                    if (player.GetUserId() == "76561198979881230@steam")
                    {
                        player.SetRank("��Ⱥ��פUP��", "aqua", true);
                    }
                    if (player.GetUserId() == "76561198401019684@steam")
                    {
                        player.SetRank("����Сѧ����������С���", "lime", true);
                    }
                    if (player.GetUserId() == "76561198416583969@steam")
                    {
                        player.SetRank("ɳ���ս���", "blue", true);
                    }
                    if (player.GetUserId() == "76561198961941280@steam")
                    {
                        player.SetRank("BILIBILI_Ԫ���������", "aqua", true);
                    }
                    if (player.GetUserId() == "76561198359791579@steam")
                    {
                        player.SetRank("D-17396", "yellow", true);
                    }
                    if (player.GetUserId() == "76561198977855934@steam")
                    {
                        player.SetRank("49����", "pink", true);
                    }
                    if (player.GetUserId() == "76561198845175801@steam")
                    {
                        player.SetRank("����ϲ49", "lime", true);
                    }
                    if (player.GetUserId() == "76561198414605683@steam")
                    {
                        player.SetRank("BILILBILI_��С��", "lime", true);
                    }
                    if (player.GetUserId() == "76561198360004164@steam")
                    {
                        player.SetRank("bilibili���cQWQ", "lime", true);
                    }
                    if (player.GetUserId() == "76561198865192444@steam")
                    {
                        player.SetRank("��ͷ������ʿ", "red", true);
                    }




                }
                yield return Timing.WaitForSeconds(60f);
            }
        }
        private IEnumerator<float> SecondCounter7()
        {
            for (; ; )
            {
                if(starttimer == true)
                {
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>400s</color>�����������", 10, false);
                    yield return Timing.WaitForSeconds(200f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>200s</color>�����������", 10, false);
                    yield return Timing.WaitForSeconds(150f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>50s</color>�����������", 10, false);
                    yield return Timing.WaitForSeconds(40f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>10s</color>�����������", 5, false);
                    yield return Timing.WaitForSeconds(5f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>5s</color>�����������", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>4s</color>�����������", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>3s</color>�����������", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>2s</color>�����������", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�����ǰ׸��˺ö������ɶ���ѽ</color>\n�һ���<color=red>1s</color>�����������", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>��ʼ����</color>", 4, false);
                    foreach (Ragdoll ragdoll in UnityEngine.Object.FindObjectsOfType<Ragdoll>())
                    {
                        NetworkServer.Destroy(ragdoll.gameObject);
                        ragdolltime++;
                        
                    }
                    foreach (Pickup item in UnityEngine.Object.FindObjectsOfType<Pickup>())
                    {
                        if (item.ItemId == ItemType.Ammo556 || item.ItemId == ItemType.Ammo762 || item.ItemId == ItemType.Ammo9mm || item.ItemId == ItemType.GunE11SR || item.ItemId == ItemType.WeaponManagerTablet || item.ItemId == ItemType.GrenadeFlash || item.ItemId == ItemType.GrenadeFrag || item.ItemId == ItemType.Disarmer || item.ItemId == ItemType.GunLogicer || item.ItemId == ItemType.GunProject90 || item.ItemId == ItemType.Radio)
                        {
                            item.Delete();
                            itemtime++;
                        }

                    }
                    Map.Broadcast("<color=#FFFF00>[С������������ʦ]</color>\n<color=#66FFFF>�ñ�ѽ</color>\n����������" + itemtime.ToString() + "����Ʒ" + ragdolltime.ToString() + "��ʬ��", 4, false);
                    itemtime = 0;
                    ragdolltime = 0;
                    yield return Timing.WaitForSeconds(100f);

                }
                yield return Timing.WaitForSeconds(1f);

            }
        }
        private IEnumerator<float> SecondCounter6()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(10f);
                int i = 0;
                foreach (ReferenceHub referenceHub in Player.GetHubs())
                {
                    i++;
                    playerqwq.Add(referenceHub);
                }
                if (scp650yes == true)
                {
                    int cardup = new System.Random().Next(1, i);

                    if ((playerqwq[cardup].GetTeam() != Team.SCP) && (playerqwq[cardup].GetRole() != RoleType.Spectator))
                    {
                        scp650.SetPosition(playerqwq[cardup].GetPosition());
                    }
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (player.GetPlayerId() == scp650id)
                        {
                            if (player.GetRole() != RoleType.Scp173)
                            {
                                scp650.SetGodMode(false);
                            }
                        }
                    }
                }

                if (scp1143a == true)
                {
                    yield return Timing.WaitForSeconds(2f);

                    scp1143.AddItem(ItemType.GrenadeFrag);
                }
                //1143������
                if(mzzb == false)
                {
                    yield return Timing.WaitForSeconds(2f);

                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(mz, 500)));

                    mz.AddItem(ItemType.SCP500);
                    mz.AddItem(ItemType.Adrenaline);
                    mzzb = true;
                    Map.Broadcast("����ܧ� �ҧݧ�է� ����   �ҧ���ݧܧ� �ӧ�էܧ�  ", 5, false);
                    
                }
                if (hhzhgzb == false)
                {
                    yield return Timing.WaitForSeconds(2f);

                    HDZHG.ClearBroadcasts();
                    HDZHG.Broadcast(5, "���ǻ���ָ�ӹٰ�~�򿪿���̨����.help���ָ�����", false);
                    HDZHG.SetRank("����ָ�ӹ�", "yello", true);
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(HDZHG, 150)));

                    HDZHG.AddItem(ItemType.KeycardO5);
                    HDZHG2.Add(HDZHG.GetUserId());
                    hhzhgzb = true;
                }
                //����ָ�ӹٷ���
                if (scp073zb == false)
                {
                    yield return Timing.WaitForSeconds(2f);

                    scp073.SetRole(RoleType.NtfLieutenant);
                    scp073zb = true;
                }
                if (mrfishzb == false)
                {
                    yield return Timing.WaitForSeconds(3f);

                    mrfish.SetRole(RoleType.Scientist,true);
                    mrfish.SetHealth(120);
                    mrfish.AddItem(ItemType.KeycardO5);
                    mrfish.AddItem(ItemType.MicroHID);
                    mrfish.AddItem(ItemType.MicroHID);
                    mrfish.AddItem(ItemType.GunLogicer);
                    mrfish.AddItem(ItemType.GrenadeFrag);
                    mrfish.AddItem(ItemType.Radio);
                    mrfish.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                    mrfish.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                    mrfish.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);

                    mrfishzb = true;
                }
                if (jljyzb == true)
                {
                    yield return Timing.WaitForSeconds(2f);

                    jljy.SetRole(RoleType.Tutorial);
                    jljy.SetPosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard));
                    jljy.AddItem(ItemType.GunE11SR);
                    jljy.AddItem(ItemType.MicroHID);
                    jljy.AddItem(ItemType.MicroHID);
                    jljy.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                    jljy.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                    jljy.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
                    jljy.AddItem(ItemType.KeycardNTFCommander);
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(jljy, 250)));

                    jljy2.Add(jljy.GetUserId());
                    jljy.SetRank("������Ӱ", "red", true);
                    jljyzb = false;
                }
                if(scp1577bj == true)
                {
                    yield return Timing.WaitForSeconds(2f);
                    Vector3 vector3 = new Vector3(scp1577pos.x, scp1577pos.y + 2, scp1577pos.z);
                    Map.SpawnItem(ItemType.SCP500, 500, vector3);
                    Map.SpawnItem(ItemType.SCP500, 500, vector3);
                    Map.SpawnItem(ItemType.Medkit, 500, vector3);
                    Map.SpawnItem(ItemType.MicroHID, 500, vector3);
                    Map.SpawnItem(ItemType.KeycardO5, 500, vector3);
                    scp1577bj = false;
                }
                if(jwhngitem ==false)
                {
                    yield return Timing.WaitForSeconds(2f);

                    jwhngitem = true;
                    foreach (Inventory.SyncItemInfo item in jwhng.GetAllItems())
                    {
                        jwhng.RemoveItem(item);
                    }
                    jwhng.ClearBroadcasts();
                    jwhng.Broadcast(5, "<color=lime>[��β���ڹ�]</color>\n<color=yello>���Ǿ�β���е��ڹ�HP:350����120s��׼��ʱ��</color>\n<color=yellow>�������ⵯ�л�����ģʽ</color>");
                    jwhng.Broadcast(5, "<color=lime>[��β���ڹ�]</color>\n<color=yello>����˵�� ��������ģʽ����βɨ�����Ѫ���ǲ��ᱩ¶</color>\n<color=yellow>120s֮ǰ��β�����������˺���Ҳ�޷�����</color>");
                    jwhng.AddItem(ItemType.KeycardChaosInsurgency);
                    jwhng.AddItem(ItemType.GunE11SR);
                    jwhng.AddItem(ItemType.Radio);
                    jwhng.AddItem(ItemType.GrenadeFlash);
                    jwhng.AddItem(ItemType.Adrenaline);
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(jwhng, 500)));

                }
                if (scp550item == true)
                {
                    yield return Timing.WaitForSeconds(2f);

                    scp550item = false;
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp550, 5000)));

                    scp550.SetRank("SCP-550", "red", true);
                    meitunshi = true;
                    scp550.Broadcast(10, "<color=lime>[SCP550]</color>\n<color=yello>����ʳʬ��:HP:5000 ���30s��û����ʬ��ÿ����ʧ8HP</color>\n<color=yellow>վ��ʬ����ϼ�������ʬ�� ������ɺ����������������</color>");
                    Coroutines.Add(Timing.RunCoroutine(SecondCounter26()));
                    scp550.AddItem(ItemType.GunProject90);
                }

            }
        }
        private IEnumerator<float> SecondCounter27()
        {
            for (; ; )
            {
                if(scp550yes == true)
                {
                    Vector3 pos2 = scp550.GetPosition();
                    float num2 = pos2.x + 3;
                    float num3 = pos2.y + 3;
                    float num4 = pos2.z + 3;
                    float num5 = pos2.x - 3;
                    float num6 = pos2.y - 3;
                    float num7 = pos2.z - 3;



                    foreach (Ragdoll ragdoll in UnityEngine.Object.FindObjectsOfType<Ragdoll>())
                    {
                        if ((ragdoll.transform.position.x <= num2) && (ragdoll.transform.position.x >= num5) && (ragdoll.transform.position.y <= num3) && (ragdoll.transform.position.y >= num6) && ((ragdoll.transform.position.z <= num4) && (ragdoll.transform.position.z >= num7)))
                        {
                            tssj++;
                            scp550.Broadcast(1, "<color=lime>[��ʾ]����ʬ���н���</color>" + tssj);
                            if (scp550lv == 0)
                            {
                                if(tssj >= 14)
                                {
                                    tssj = 0;
                                    tssl++;
                                    meitunshi = true;
                                    scp550.AddHealth(100);
                                    scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv,"red",true);
                                    NetworkServer.Destroy(ragdoll.gameObject);
                                }
                            }
                            if(scp550lv == 1)
                            {
                                if (tssj >= 12)
                                {
                                    tssj = 0;
                                    meitunshi = true;
                                    tssl++;
                                    scp550.AddHealth(100);
                                    scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv, "red", true);
                                    NetworkServer.Destroy(ragdoll.gameObject);
                                }
                            }
                            if (scp550lv >= 2)
                            {
                                if (tssj >= 10)
                                {
                                    meitunshi = true;
                                    tssj = 0;
                                    tssl++;
                                    scp550.AddHealth(100);
                                    scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv, "red", true);
                                    NetworkServer.Destroy(ragdoll.gameObject);
                                }
                            }

                            break;
                        }
                        else
                        {
                            tssj = 0;
                        }
                    }
                }
                if (scp550yes == true)
                {
                    if (tssl == 5)
                    {
                        meitunshi = true;
                        scp550lv = 1;
                        scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv, "red", true);
                    }
                    if (tssl == 10)
                    {
                        meitunshi = true;
                        scp550lv = 2;
                        scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv, "red", true);
                    }
                    if (tssl == 15)
                    {
                        meitunshi = true;
                        scp550lv = 3;
                        scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv, "red", true);
                    }
                    if (tssl == 30)
                    {
                        meitunshi = true;
                        scp550lv = 4;
                        scp550.SetRank("SCP550|����ʬ������:" + tssl + "|�ȼ�:" + scp550lv, "red", true);
                    }
                    if (scp550lv == 1)
                    {
                        scp550.AddHealth(2);
                    }
                    if (scp550lv == 2)
                    {
                        scp550.AddHealth(4);
                    }
                    if (scp550lv == 3)
                    {
                        scp550.AddHealth(6);
                    }
                    if (scp550lv == 4)
                    {
                        scp550.AddHealth(8);
                    }
                }
                yield return Timing.WaitForSeconds(1f);

            }
        }

        private IEnumerator<float> SecondCounter26()
        {
            for (; ; )
            {
                if(meitunshi == true)
                {
                    yield return Timing.WaitForSeconds(30f);
                    meitunshi = false;
                }
                if(meitunshi == false)
                {
                    if(scp550.GetHealth() >= 300)
                    {
                        scp550.AddHealth(-8);
                    }
                }
                yield return Timing.WaitForSeconds(1f);

            }
        }
        private IEnumerator<float> SecondCounter5()
        {
            for (; ; )
            {
 
                int sjsj2 = new System.Random().Next(1, 31);
                Log.Info(sjsj2.ToString());

                if ((scp457die == false) && (scp457a == false))
                {
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Spectator)
                        {
                            scp457 = player3;
                            scp457a = true;
                            Log.Info("����¼�����");

                            scp457id = scp457.GetPlayerId();
                            scp457.SetRank("SCP-457", "red", true);
                            scp457.SetRole(RoleType.Tutorial);
                            scp457tp = true;

                            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp457, 4000)));

                            Map.Broadcast("<color=red>SCP457�Ѿ������뾡������</color>", 10, false);
                            scp457.Broadcast(10, "<color=#FFC0CB>---[SCP457]---</color>\n<color=#00FFFF>HP:4000  </color>��ӵ��һ����������\n<color=#FFD700>������Χ���˶����Ѫ</color>", false);
                            break;
                        }
                    }
                }
                if (sjsj2 == 1)
                {
                    Map.Broadcast("<color=#BB1444>����й©��-�¼�����������������ҽ���30���ڿ۳���1-12hp</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        int kx = new System.Random().Next(1, 12);
                        if (player3.GetTeam() > Team.SCP)
                        {
                            player3.AddHealth(-kx);
                        }
                    }
                }
                if (sjsj2 == 2)
                {
                    Map.Broadcast("<color=#BB1444>DD�췴����-�¼������д���Class-D��á��췴��Ʒ��</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        if (player3.GetRole() == RoleType.ClassD)
                        {
                            player3.AddItem(ItemType.GunCOM15);
                            player3.AddItem(ItemType.Ammo762);
                            player3.AddItem(ItemType.GunCOM15);
                        }
                    }
                }
                if (sjsj2 == 3)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>��ʿ��˽������-�¼������д�ʿ��õ����x2��500hp</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        if (player3.GetRole() == RoleType.Scientist)
                        {
                            player3.AddItem(ItemType.MicroHID);
                            player3.AddItem(ItemType.MicroHID);
                            player3.SetHealth(player3.GetHealth() + 500);
                        }
                    }

                }
                if (sjsj2 == 4)
                {
                    Map.Broadcast("<color=#BB1444>��Ҫ�°�-�¼������һ���������һ�źڿ�</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.FacilityGuard)
                        {
                            player3.AddItem(ItemType.KeycardO5);
                            break;
                        }
                    }
                }
                if (sjsj2 == 5)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>���ǵ���������-�¼����ڳ����������get����һ��Ц��</color>", 10, false);
                }
                if (sjsj2 == 6)
                {
                    Map.Broadcast("<color=#BB1444>��ϲ���ƣ�-�¼������д����һ��һ���Ӳ��</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        player3.AddItem(ItemType.Coin);
                        player3.AddItem(ItemType.Coin);
                        player3.AddItem(ItemType.Coin);
                        player3.AddItem(ItemType.Coin);
                        player3.AddItem(ItemType.Coin);
                    }

                }
                if (sjsj2 == 7)
                {
                    Map.Broadcast("<color=#BB1444>�ɿ�����óԣ�-�¼��������Ե��Լ�����</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp173)
                        {
                            
                            player3.AddHealth(-50);
                        }
                    }

                }
                if (sjsj2 == 8)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>�޵�ս��-�¼�������-1HP�����޵� �ָ�����Ѫ����qwq</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp173)
                        {
                            player3.SetHealth(1);
                            player3.SetGodMode(true);
                        }

                    }
                    xhsnb = true;
                }
                if (sjsj2 == 9)
                {
                    Map.Broadcast("<color=#BB1444>�����ϵ���-�¼���SCP-106������͵�һ��D����Ա���</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp106)
                        {
                            scp106a = player3;
                            break;
                        }
                    }
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.ClassD)
                        {
                            scp106a.SetPosition(player3.GetPosition());
                            break;
                        }

                    }
                }
                if (sjsj2 == 10)
                {
                    Map.Broadcast("<color=#BB1444>��ҵѧͽ��-�¼���SCP-49-2��ΪSCP049</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp0492)
                        {
                            player3.SetRole(RoleType.Scp049,true);
                            break;
                        }
                    }
                }
                if (sjsj2 == 11)
                {
                    Map.Broadcast("<color=#BB1444>����ִ�գ�-�¼���SCP-49��ΪSCP-049-2</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            pos5 = player3.GetPosition();
                            player3.SetRole(RoleType.Scp0492,true);

                            player3.SetHealth(5000);
                            break;
                        }
                    }
                }
                if (sjsj2 == 12)
                {
                    Map.Broadcast("<color=#BB1444>����Ժ��-�¼��������һ����ͷ</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Spectator)
                        {
                            player3.SetRole(RoleType.Scp106);
                            break;
                        }
                    }
                }
                if (sjsj2 == 13)
                {
                    Map.Broadcast("<color=#BB1444>343��������-�¼���һ����һ�� ����� ���� �ڿ�</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if ((player3.GetTeam() > Team.SCP) && (player3.GetRole() != RoleType.Spectator))
                        {
                            player3.AddItem(ItemType.KeycardO5);
                            player3.AddItem(ItemType.MicroHID);
                            player3.AddItem(ItemType.GrenadeFrag);
                            break;
                        }
                    }
                }
                if (sjsj2 == 14)
                {
                    Map.Broadcast("<color=#BB1444>DD�ǵĸ���-�¼���ȫ��D���� ��Я����ǹ</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Spectator)
                        {
                            player3.SetRole(RoleType.ClassD);
                            player3.AddItem(ItemType.GunCOM15);
                        }
                    }
                    csm = true;
                }
                if (sjsj2 == 15)
                {
                    Map.Broadcast("<color=#BB1444>ϴ���������-�¼�����ͷϴ�ױ��96</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp106)
                        {
                            player3.SetRole(RoleType.Scp096,true);
                        }
                    }
                }
                if (sjsj2 == 16)
                {
                    Map.Broadcast("<color=#BB1444>�������棡-�¼���96�����</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp096)
                        {
                            player3.SetRole(RoleType.Scp106, true);
                        }
                    }
                }
                if (sjsj2 == 17)
                {
                    Map.Broadcast("<color=#BB1444>�������������ģ�-�¼���һ��D�����SCP079</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.ClassD)
                        {
                            player3.SetRole(RoleType.Scp079);
                            scpd79.Add(player3);
                            break;
                        }
                    }
                }
                if (sjsj2 == 18)
                {
                    Map.Broadcast("<color=#BB1444>С��ģʽ��-�¼���������ҳߴ���С</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        SetPlayerScale(player3.gameObject, (float)0.7, (float)0.7, (float)0.7);
                    }
                }
                if (sjsj2 == 19)
                {
                    Map.Broadcast("<color=#BB1444>��������������-�¼���һ���¼�ˢ��079���D��</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp079)
                        {
                            player3.SetRole(RoleType.ClassD);
                        }
                    }
                }
                if (sjsj2 == 20)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>079����SCP��-�¼������غ�SCP��5%���ʿ���</color>", 10, false);
                    bscp79 = true;
                }
                if (sjsj2 == 21)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>��Ƥ�Ĵ����ţ�-�¼���10����100%���������</color>", 10, false);
                    csm = true;
                }
                if (sjsj2 == 22)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>�Ǳ��ܵ���Ϯ��-�¼����Ǳ��ָܻ��˺�</color>", 10, false);
                    qblcq = null;
                    qblcq2 = false;
                    scpqbl = null;
                    scpqbl3 = null;
                    scpqblid = null;
                    scpqblid2 = 0;

                }
                if (sjsj2 == 23)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>��Ͷ��ҩ��-�¼����������ӵ���200��</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        player3.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, player3.GetAmmo(EXILED.ApiObjects.AmmoType.Dropped5) + 200);
                        player3.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, player3.GetAmmo(EXILED.ApiObjects.AmmoType.Dropped7) + 200);
                        player3.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, player3.GetAmmo(EXILED.ApiObjects.AmmoType.Dropped9) + 200);
                    }
                }
                if (sjsj2 == 24)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>��լ����D��-�¼������д��D����ÿ���</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.ClassD)
                        {
                            player3.AddItem(ItemType.SCP207);
                        }
                    }
                }
                if (sjsj2 == 25)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>�����ͣ�-�¼�������3��С������HP��ֻ��30HP</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Spectator)
                        {
                            time3++;
                            player3.SetRole(RoleType.Scp173);
                            player3.SetHealth(30);
                            if (time3 >= 3)
                            {
                                break;
                            }

                        }
                    }

                }
                if (sjsj2 == 26)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>��β�����ǵĿ�ݵ��ˣ�-�¼�����β��������ˢ���������</color>", 10, false);
                    Map.SpawnItem(ItemType.MicroHID, 500, Map.GetRandomSpawnPoint(RoleType.NtfCommander));
                    Map.SpawnItem(ItemType.MicroHID, 500, Map.GetRandomSpawnPoint(RoleType.NtfCommander));
                }
                if (sjsj2 == 27)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>�����ϲ��-�¼�������ص�ˢһ���ڿ�</color>", 10, false);
                    Map.SpawnItem(ItemType.KeycardO5, 500, Map.GetRandomSpawnPoint(RoleType.ClassD));

                }
                if (sjsj2 == 28)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>���ʧ�ޣ�-�¼�����ʩ���м����޷�����</color>", 10, false);
                    bhsx = true;

                }
                if (sjsj2 == 29)
                {
                    Log.Info("����¼�����");
                    Map.Broadcast("<color=#BB1444>DD�Ƕ���Ĵ�-�¼���Class-D��� ����һ��</color>", 10, false);
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.ClassD)
                        {
                            player3.AddItem(ItemType.GunE11SR);
                            player3.AddHealth(50);
                            player3.AddItem(ItemType.KeycardNTFCommander);
                        }
                    }
                }
                if (sjsj2 == 30)
                {
                    Map.Broadcast("<color=#BB1444>�ۣ���ͷ��-�¼��������һ��96</color>", 10, false);
                    Log.Info("����¼�����");
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Spectator)
                        {
                            player3.SetRole(RoleType.Scp096);
                            break;
                        }
                    }
                }

                if (Dio1 == false)
                {
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Spectator)
                        {
                            Dio = player3;
                            Dio1 = true;
                            Map.Broadcast("<color=#BB1444>Dio:</color>\n<color=#BB1444>�ֵ�������װ����</color>", 10, false);
                            Dio.SetRole(RoleType.Tutorial);
                            Dio.SetPosition(Map.GetRandomSpawnPoint(RoleType.ChaosInsurgency));
                            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(Dio, 500)));
                            Dio.AddItem(ItemType.Flashlight);
                            Dio.AddItem(ItemType.GunE11SR);
                            Dio.AddItem(ItemType.MicroHID);
                            Dio.AddItem(ItemType.MicroHID);
                            Dio.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                            Dio.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                            Dio.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
                            Dio.AddItem(ItemType.KeycardNTFCommander);
                            Dio.ClearBroadcasts();
                            Dio.Broadcast(6, "����Dio�����ֵ�ʹ��ʱ��ֹͣ", false);
                            Dio.SetRank("Dio", "red", true);
                            Dio2.Add(Dio.GetUserId());
                            diotp = true;

                            break;
                            

                        }
                    }

                }
                yield return Timing.WaitForSeconds(200f);
            }
        }
        private IEnumerator<float> SecondCounter4()
        {
            for (; ; )
            {

                if (bhsx == true)
                {
                    if (njsxtimes == 1)
                    {
                        njsxtimes = 0;
                        bhsx = false;
                    }
                }
                updatatimerscp1577 = DateTime.Now.AddSeconds(300.0);
                njsxtimes++;
                stealcd = false;
                Map.Broadcast("<color=#00FFFF>�������ʲô�õ��ӻ�����������ʲô���⻶ӭ����ȺŶ\n979685108</color>", 7, false);
                Map.Broadcast("<color=#00FFFF>���������ʮ�ֿ��٣�˵������������������ϵ�������б�\n������979685108��Ⱥ��</color>", 7, false);
                yield return Timing.WaitForSeconds(300f);
            }
        }
        private IEnumerator<float> SecondCounter15()
        {
            for (; ; )
            {
                if (!die && start)
                {
                    scp.AddItem(ItemType.Medkit);
                    scp.AddHealth(80);
                }
                coldwait233 = false;//038cd 120s
                yield return Timing.WaitForSeconds(120f);
            }
        }
        private IEnumerator<float> SecondCounter2()
        {
            for (; ; )
            {
                foreach (ReferenceHub p in Player.GetHubs())
                {
                    if ((p.GetPosition().y <= -1000) && (p.GetPosition().y >= -1006))
                    {
                        int222++;
                        p.Broadcast(5, "�����ڲ�����Ե�ǰ����(��ĵ�������ڳ���)" + int222, false);
                        if ((int222 == 10) || (int222 == 20) || (int222 == 30) || (int222 == 50) || (int222 == 60) || (int222 == 70) && (int222 == 80) && (int222 == 90))
                        {
                            p.AddItem(ItemType.MicroHID);
                            p.Broadcast(5, "����ڳ������", false);
                        }
                        if (int222 >= 100)
                        {
                            foreach (ReferenceHub player in Player.GetHubs())
                            {
                                if (player.GetRole() == RoleType.Scp079)
                                {
                                    player.Kill(DamageTypes.Tesla);
                                }
                            }
                            int222 = 0;
                            Map.Broadcast("�����Ѿ��������", 10, false);
                        }
                    }
                }
                if (diotp == true)
                {
                    diotp = false;
                    Dio.SetPosition(Map.GetRandomSpawnPoint(RoleType.ChaosInsurgency));
                    yield return Timing.WaitForSeconds(2f);

                    Dio.SetPosition(Map.GetRandomSpawnPoint(RoleType.ChaosInsurgency));

                }
                if (scp457tp == true)
                {
                    scp457tp = false;
                    scp457.SetPosition(Map.GetRandomSpawnPoint(RoleType.Scp096));
                    yield return Timing.WaitForSeconds(2f);
                    scp457.SetPosition(Map.GetRandomSpawnPoint(RoleType.Scp096));

                }
                if (scp999tp == true)
                {
                    scp999tp = false;
                    scp.SetPosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard));
                    yield return Timing.WaitForSeconds(2f);
                    scp.SetPosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard));
                    scp.SetGodMode(false);
                }
                yield return Timing.WaitForSeconds(20f);
            }
        }
        private IEnumerator<float> SecondCounter()
        {
            for (; ; )
            {

                Dio.SetGodMode(false);
                scp457.SetGodMode(false);

                if (csm)
                {

                    csmtime++;
                    if (csmtime == 10)
                    {
                        csm = false;
                        csmtime = 0;
                    }
                }
                if (hrss)
                {
                    hktime++;
                    float num2 = hkzb.x + 2;
                    float num3 = hkzb.y + 2;
                    float num4 = hkzb.z + 2;
                    float num5 = hkzb.x - 2;
                    float num6 = hkzb.y - 2;
                    float num7 = hkzb.z - 2;
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if ((player.GetTeam() != Team.MTF) && (player.GetRole() != RoleType.Scientist) && (player.GetPosition().x <= num2) && (player.GetPosition().x >= num5) && (player.GetPosition().y <= num3) && (player.GetPosition().y >= num6) && ((player.GetPosition().z <= num4) && (player.GetPosition().z >= num7)))
                        {
                            jwhhk.SetRole(RoleType.NtfScientist , true);
                            jwhhk.SetPosition(hkzb);
                            hktime = 0;
                            hrss = false;
                        }
                    }
                    if (hktime == 60)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetPlayerId() == jwhhkid)
                            {
                                jwhhk.SetRole(RoleType.NtfScientist,true);
                                jwhhk.SetPosition(hkzb);
                                hktime = 0;
                                hrss = false;

                            }
                        }
                    }
                }

                if(starttimer)
                {
                    deadtimer = deadtimer++;
                    waring1 = waring1++;
                    if (deadtimer >= 100)
                    {
                        xywj = null;
                        xywjid = null;
                    }
                    if (coldbc)
                    {
                        coldtime++;
                        if (coldtime == 80)
                        {
                            coldbc = false;
                            coldtime = 0;
                        }
                    }
                    if (coldtb)
                    {
                        coldtime2++;
                        if (coldtime2 == 300)
                        {
                            coldtb = false;
                            coldtime = 0;
                        }
                    }
                    if (deadtimer <= 30)
                    {

                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Spectator)
                            {
                                int num = new System.Random().Next(1, 100);
                                if ((num >= 0) && (num <= 0x19))
                                {
                                    if ((s173 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.SetRole(RoleType.Scp173);
                                        s173 = 1;
                                        num = 0;
                                    }
                                    else if ((s096 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp096);
                                        player.Broadcast(10, "<color=#FFC0CB>[��Ϣ]</color>\n��������������\n��Ϊ���Զ�������Ӫ���ܰ���", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>�������Ķ���</color>", false);
                                        s096 = 1;
                                        num = 0;
                                        Log.Info("һ������ӳټ����Ϊ��: SCP096");
                                    }
                                    else if ((s106 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp106);
                                        player.Broadcast(10, "<color=#FFC0CB>[��Ϣ]</color>\n��������������\n��Ϊ���Զ�������Ӫ���ܰ���", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>�������Ķ���</color>", false);
                                        s106 = 1;
                                        num = 0;
                                        Log.Info("һ������ӳټ����Ϊ��: SCP106");
                                    }
                                    else if ((s939_53 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp93953);
                                        player.Broadcast(10, "<color=#FFC0CB>[��Ϣ]</color>\n��������������\n��Ϊ���Զ�������Ӫ���ܰ���", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>�������Ķ���</color>", false);
                                        s939_53 = 1;
                                        num = 0;
                                        Log.Info("һ������ӳټ����Ϊ��: SCP939_53");
                                    }
                                    else if ((s939_89 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp93989);
                                        player.Broadcast(10, "<color=#FFC0CB>[��Ϣ]</color>\n��������������\n��Ϊ���Զ�������Ӫ���ܰ���", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>�������Ķ���</color>", false);
                                        s939_89 = 1;
                                        num = 0;
                                        Log.Info("һ������ӳټ����Ϊ��: SCP939_89");
                                    }
                                    else if ((s049 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.SetRole(RoleType.Scp049);
                                        s049 = 1;
                                        num = 0;

                                    }
                                    else
                                    {
                                        player.SetRole(RoleType.ClassD);
                                        num = 0;
                                    }
                                }
                                else if ((num >= 0x33) && (num <= 100))
                                {
                                    player.SetRole(RoleType.ClassD);
                                    num = 0;

                                }
                                else if ((num >= 0x1a) && (num <= 50))
                                {
                                    player.SetRole(RoleType.FacilityGuard);
                                    num = 0;
                                }
                                else
                                {
                                    player.SetRole(RoleType.ClassD);
                                    num = 0;
                                }
                                break;
                            }
                        }
                    }
                }


                yield return Timing.WaitForSeconds(1f);
            }
        }
        public void ScpSpawn()
        {
            if (!die)
            {
                scp.SetRole(RoleType.Tutorial,true);
                scp.AddItem(ItemType.Disarmer);
                scp.AddItem(ItemType.Flashlight);
                scp.AddItem(ItemType.KeycardGuard);
                scp.AddItem(ItemType.Radio);
                scp.AddItem(ItemType.GunMP7);
                scp.SetRank("SCP-999", "pink", true);
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp, 5000)));

                scp.ClearBroadcasts();
                scp.Broadcast(10, "����[<color=red>SCP-999</color>],��~��`�鿴�̳�", false);
                scp.SetAmmo(AmmoType.Dropped5, 500);
                scp.SetAmmo(AmmoType.Dropped7, 500);
                scp.SetAmmo(AmmoType.Dropped9, 500);
                scp.SendConsoleMessage(string.Concat(new object[] { "\nSCP999���˵��:\nSCP999ӵ��[", 5000, "]Ѫ��,�������Ķ��󽫻ָ�[", 5, "]��Ѫ��,SCP999ÿ[", 150, "]���ظ�80HP,SCP999��Ӱ����Ϸ��������" }), "green");
                maxtime = DateTime.Now.AddSeconds(120);
                start = true;
                scp_999.Add(scp.GetUserId());
                scp999tp = true;
                Log.Info("SCP999��ˢ�£����Ϊ:" + scp.GetNickname() + start.ToString());
            }
        }
        public void On914KnobChange(ref Scp914KnobChangeEvent ev)
        {
            if (ev.Player.GetTeam() == Team.CDP)
            {
                ev.Player.Broadcast(5,"914��ǰ���ã�"+ev.KnobSetting+ "������Ա��"+ev.Player.GetNickname(), false);
            }

            if (ev.Player.GetTeam() == Team.MTF)
            {
                ev.Player.Broadcast(5, "914��ǰ���ã�" + ev.KnobSetting + "������Ա��" + ev.Player.GetNickname(), false);

            }

            if (ev.Player.GetTeam() == Team.CHI)
            {
                ev.Player.Broadcast(5, "914��ǰ���ã�" + ev.KnobSetting + "������Ա��" + ev.Player.GetNickname(), false);

            }

            if (ev.Player.GetTeam() == Team.RSC)
            {
                ev.Player.Broadcast(5, "914��ǰ���ã�" + ev.KnobSetting + "������Ա��" + ev.Player.GetNickname(), false);

            }

            if (ev.Player.GetTeam() == Team.TUT)
            {
                ev.Player.Broadcast(5, "914��ǰ���ã�" + ev.KnobSetting + "������Ա��" + ev.Player.GetNickname(), false);
            }

        }
        public void OnScp096Enrage(ref Scp096EnrageEvent ev)
        {

            Map.Broadcast("<color=red>[����]</color>\n"+ev.Player.GetNickname()+"������SCP096����", 5,false);

        }
        public void OnRoundStart()
        {
            diyicizhixingzheli = true;
            Map.SpawnItem(ItemType.GunCOM15, 500, Map.GetRandomSpawnPoint(RoleType.Scp173));
            List<ReferenceHub> list = new List<ReferenceHub>();
            List<ReferenceHub> list2 = new List<ReferenceHub>();
            starttimer = true;
            firstscp = true;
            Map.Broadcast("���θ�������2020.6.14�����������Ǵ߸���", 5, false);
            foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
            {
                if (new System.Random().Next(1, 12) == 5)
                {
                    Vector3 pos = new Vector3(door.transform.position.x, door.transform.position.y + (float)2.0, door.transform.position.z);
                    Map.SpawnItem(ItemType.Coin, 500, pos);
                    time2++;
                }
            }
            Map.Broadcast("<color=lime>����������</color>" + time2 + "<color=lime>������Ӳ��</color>", 10, false);
            Map.Broadcast("<color=red>��ʼ��ȡ�������</color>", 3, false);
            foreach (ReferenceHub player in Player.GetHubs())
            {
                xywj = player;
                xywjid = xywj.GetUserId();
            }
            Map.Broadcast("<color=lime>�����������غ�������ҡ�������</color>\n" + "<color=lime>" + xywj.GetNickname() + "</color>\n<color=red>����԰�~��ѡ������</color>", 2, false);
            Map.Broadcast("<color=lime>�����������غ�������ҡ�������</color>\n" + "<color=red>" + xywj.GetNickname() + "</color>\n<color=red>����԰�~��ѡ������</color>", 2, false);
            Map.Broadcast("<color=lime>�����������غ�������ҡ�������</color>\n" + "<color=green>" + xywj.GetNickname() + "</color>\n<color=red>����԰�~��ѡ������</color>", 2, false);
            xywj.SendConsoleMessage(".s173 ��Ϊ173\n.s106 ��Ϊ106\n.sD ��ΪD��\n.sS ��Ϊ��ѧ��\n.sG ��Ϊ����\nע�������������������", "green");
            Map.Broadcast("�������DDOS���ط����������޷�һֱ���б� ����ؼ�Ⱥ��979685108", 15, false);
            int num = 0;
            foreach (ReferenceHub player in Player.GetHubs())
            {
                num++;
            }
            if (num < 3)
            {
                die = true;
                Log.Info("��Ҳ�������,SCP999�޷�ˢ��");
            }
            else
            {
                scp999yes = true;
            }


            times = 0;


            coldwait233 = false;
            starttimer = true;
            roundstart = true;
            deadtime = true;
            Map.Broadcast("���ڷ������������ÿ������һ�غϿ��ܾͻ�ը��\nֱ�ӵ��ֱ�����Ӳ�������Ip��������", 7, false);
            Map.Broadcast("<color=#FF0000>����:</color>վ�㷢������ʧЧ,Alpha��ͷЭ�齫��ݻٴ�վ��\n����30�����ڶ���������������SCP��Ŀ", 10, false);
            Map.Broadcast("<color=#FFFF00>[����Ͷ��ģʽ]</color>\n---|<color=#FF0000>��������ϵ� ~ ��[����1���]</color>|---\n����<color=#9400D3>.tx</color>���ɽ���<color=#9400D3>Ͷ��ģʽ</color>", 10, false);

        }
        public void OnRoundEnd()
        {
            scp79 = false;
            scp550lv = 0;
            tssl = 0;
            mz = null;
            mzid = 0;
            mzyes = false;
            scp035yes = false;
            xitonghedan = false;
            jwhngitem = true;
            this.scp079id = -1;
            h = false;
            roundstart = false;
            choise = false;
            scp035goout = false;
            jwhng = null;
            jwhngwufashanghai = false;
            jwhhkid = 0;
            jwhngyes = false;
            jwhngshuachu = false;
            scp550shuachu = false;
            Timing.KillCoroutines(Coroutines);
            Coroutines.Clear();
            scp999yes = false;
            scp = null;
            die = true;
            start = false;
            scp_999.Clear();
            card = 0;
            s = 0;
            d = 0;
            SCP049 = "";
            SCP079 = "";
            SCP096 = "";
            SCP939_53 = "";
            SCP939_89 = "";
            SCP106 = "";
            KillerID = 0;
            PlayerID = 0;
            RoleSet = 0;
            s173 = 0;
            s049 = 0;
            s096 = 0;
            s939_53 = 0;
            s939_89 = 0;
            s106 = 0;
            Guardnum = 0;
            deadtimer = 0;
            waring1 = 0;
            ini10 = 0;
            coldwait233 = false;
            Dio = null;
            Dio1 = false;
            Dio2.Clear();
            tiems = 0;
            sjtz1 = false;
            scp076 = null;
            scp035yes = false;
            scp076yes = false;
            scp2818 = null;
            scp2818pick = false;
            scp1143a = false;
            scp1143 = null;
            times = 0;
            Map.Broadcast("�غϽ������˱����ر�", 5, false);
            jljy = null;
            jljy1 = false;
            jljy2.Clear();
            jljyzb = false;
            sjtz2 = false;
            ylb1 = false;
            HDZHG2.Clear();
            coldwait233 = false;
            coldbc = false;
            coldtb = false;
            coldtime = 0;
            mtf = 0;
            chaos = 0;
            mtfchange = 0;
            chaoschange = 0;
            round = 0;
            Array.Clear(touxiang, 0, touxiang.Length);
            playernum = 0;
            roundstart = false;
            player233.Clear();
            starttimer = false;
            deadtime = false;
            KillerID = 0;
            PlayerID = 0;
            RoleSet = 0;
            Guardnum = 0;
            deadtimer = 0;
            waring1 = 0;
            ini10 = 0;
            Dio = null;
            Dio1 = false;
            Dio2.Clear();
            xywj = null;
            xywjid = null;
            //181endβ��
            bpb = false;
            bpb2.Clear();
            xhsnb2 = 0;
            scp2818id = 0;
            xhsnb = false;
            mrfishzb = true;
            scp1143id = 0;
            xp = 0;
            lv = 0;
            coldbc = false;
            coldtb = false;
            HDZHG2.Clear();
            coldtime = 0;
            mtf = 0;
            chaos = 0;
            mtfchange = 0;
            chaoschange = 0;
            round = 0;
            Array.Clear(touxiang, 0, touxiang.Length);
            playernum = 0;
            roundstart = false;
            player233.Clear();
            starttimer = false;
            deadtime = false;
            SCP173 = "";
            sjqx = false;
            yshkq = false;
            bhsx = false;
            gjtr = 0;
            scp1577pick = false;
            scp1577bj = false;
            scp1577id = new List<int>();
            scp1577pos = new Vector3();
            scp3108shotyes = false;
            scp3108shotatplayerpos = new Vector3();
            scp3108playerid = 0;
            scp3108pick = false;
            a127d = false;
            HDZHG = null;
            scp650yes = false;
            scp650 = null;
            scp650id = 0;
            scp073 = null;
            scp073a = false;
            scp073zb = true;
            scp076id = 0;
            scp005 = false;
            scp005aid = 0;
            time2 = 0;
            scp457die = false;
            scp457 = null;
            scp457a = false;
            scp457id = 0;
            xtd = null;
            xtdid = 0;
            a127 = false;
            a127b = 0;
            a127c = false;
            scp914mid = 0;
            scp914m = null;
            scp1143 = null;
            scp1143id = 0;
            scp1143a = false;
            csm = false;
            jwhhk = null;
            jwhhkid = 0;
            qblcq2 = false;
            qblcq = null;
            scpqbl3 = null;
            scp682.Clear();
            scp939id = 0;
            jkl = false;
            jklid = null;
            //181endͷ
            times5 = 1;
            scp035 = null;
            scp035id = 0;
            scp181id = 0;
            cxkid = 0;
            scp817id = 0;
            scp817 = null;
            cxk = null;
            cxkyes = false;
            scp817yes = false;
            D9341 = null;
            D9341id = 0;
            D9341Item = null;
            D9341yes = false;
            D9341zb = new Vector3();
            jntm = false;
            starttimer = false;
            scp2006 = null;
            scp2006a.Clear();
            scp2006id = 0;
            times3 = 0;
            deadtimer = 0;
            scpqblid2 = 0;
            scpqbl = null;
            scpqblid = null;
        }
        public void OnPlayerJoin(PlayerJoinEvent ev)
        {
            if (ev.Player.GetUserId() == "76561198377975833@steam")
            {
                Map.Broadcast("<color=green>"+ev.Player.GetNickname()+ "�ճ��׼�ʮ��������scp! </color>", 8, false);

            }
            if (ev.Player.GetUserId() == "76561198369468432@steam")
            {
                Map.Broadcast("<color=#6699FF>�����߼ۻ��յ�����:50����!</color>", 2, false);
                Map.Broadcast("<color=#FF0033>�����߼ۻ��յ�����:50����!</color>", 2, false);
                Map.Broadcast("<color=#FFFF00>�����߼ۻ��յ�����:50����!</color>", 2, false);

            }
            if (ev.Player.GetUserId() == "76561198893112896@steam")
            {
                Map.Broadcast("<color=yellow>����·�࣬DIO�á����硻��ͣ��ʱ�䲢�Ҽ����˷�����</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198997348090@steam")
            {
                Map.Broadcast("<color=#FFFF66>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#CCFF00>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#99FF00>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#FF6633>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#FF3300>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#66FF00>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#6666FF>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#FF0033>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
                Map.Broadcast("<color=#66CCFF>˳˳��ħ������ƤƤϺ���Ÿ�ҥ������:ƤƤϺ������ȥ��һ��������!</color>", 1, false);
            }
            if (ev.Player.GetUserId() == "76561198145812844@steam")
            {
                Map.Broadcast("<color=#66FF00>[ע�⣡������]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>������Ϸ����λע���Լ��ľջ�</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198401019684@steam")
            {
                Map.Broadcast("<color=#66FF00>[ע�⣡49�պ�]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>������Ϸ</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198441344563@steam")
            {
                Map.Broadcast("<color=#66FF00>[ȫ����˧���˵���ս��]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>������Ϸ</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198816705835@steam")
            {
                Map.Broadcast("<color=#66FF00>[ȫ����˵Ĵ���]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>������Ϸ</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198149835838@steam")
            {
                Map.Broadcast("<color=red>[SCP079����Э��᳤]</color>" + ev.Player.GetNickname() + "<color=#red>������Ϸ</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198425823494@steam")
            {
                Map.Broadcast("<color=#66FF00>[ȫ����˧���˵���ս��]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>������Ϸ</color>", 8, false);
            }
            string name = ev.Player.GetNickname();
            if (!player233.Contains(ev.Player))
            {
                player233.Add(ev.Player);
            }
            playernum++;
            object[] objArray1 = new object[] { "<color=#FFD700>[", name, "]</color>����ӭ����뱾������\n��ǰ����:<color=#00FF00>[", playernum, "/35]</color>\n+�������:<color=#00FFFF>�ܶ����</color>+" };
            ev.Player.Broadcast(5, string.Concat(objArray1), false);

            ev.Player.Broadcast(8, "��~��������̨���ڿ���̨����.list��ȡ��ұ��", false);
            ev.Player.Broadcast(10, "<color=#BB1444>����㿴��������Ϣ֤������¼�����Ѿ�������</color>\n<color=#FFFF00>�����ƻ���Ϸ�������������Ⱥ��֧��qwq</color>", false);
            int num3 = new System.Random().Next(1, 11);
            if (num3 == 1)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP038]</color>\n<color=#FFFF00>��������012������Ը�����Ʒqwq</color>", false);
            }
            if (num3 == 2)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[֪ͨ]</color>\n<color=#FFFF00>������ܻ��ڹ�����</color>", false);
            }
            if (num3 == 3)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP817]</color>\n<color=#FFFF00>������\n150��任һ�ν�ɫ</color>", false);
            }
            if(num3 == 4)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[��β���ڹ�]</color><color=#FFFF00>\nǰ120���޷�����β�˺� 120s��ᱻ��β���˺�\nαװģʽ�޷��Ծ�β������˺�</color>", false);
            }
            if (num3 == 5)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP999]</color><color=#FFFF00>\n����Ϊ��Ѫ��SCP��Ѫ��Ϊ5�������Ѫ��Ϊ2 �淨��ʾ��\n�����ұ������װ��� ȥ914�ͳ�USP��������˺�Ŷ(���������� ��������ɱ��)</color>", false);
            }
            if (num3 == 6)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[������]</color><color=#FFFF00>\n�����ֵ�Ͳ����ʹ�ü���̫��\n�淨��ʾ�������ֵ�Ͳ����AB����ֱ����������</color>", false);
            }
            if (num3 == 7)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[������]</color><color=#FFFF00>\n�����ֵ�Ͳ����ʹ�ü���̫��\n�淨��ʾ�������ֵ�Ͳ����AB����ֱ����������</color>", false);
            }
            if (num3 == 8)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[��ʾ]</color><color=#FFFF00>\n��β��ָ�ӹٺͻ���ָ�ӹ� �����⹦��Ŷ\n�淨��ʾ����������.help�鿴���ָ��</color>", false);
            }
            if (num3 == 9)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP079]</color><color=#FFFF00>\n���������ѡ�����SCP��������\n�淨��ʾ�������ѡ����ΪĬ�ϰ���SCP</color>", false);
            }
            if (num3 == 10)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP181]</color><color=#FFFF00>\n������ͷ�ռ�����·������Ŷ\n�淨��ʾ������ͷ�ռ䲻Ҫ�ߵ�̫������ȥ</color>", false);
            }
            if (num3 == 11)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP181]</color><color=#FFFF00>\n������ͷ�ռ�����·������Ŷ\n�淨��ʾ������ͷ�ռ䲻Ҫ�ߵ�̫������ȥ</color>", false);
            }
            int num = new System.Random().Next(1, 101);
            if (num <= 20)
            {
                int num2 = new System.Random().Next(1, 7);
                if (num2 == 1)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�����������</color>", false);
                }
                else if (num2 == 2)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>����ģ�Ϊʲô</color>", false);
                }
                else if (num2 == 3)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�����Ϸ�������</color>", false);
                }
                else if (num2 == 4)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�㳤�����Ǳ���</color>", false);
                }
                else if (num2 == 5)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>������������</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>��̫����</color>", false);
                }
            }
            if ((num >= 0x15) && (num <= 40))
            {
                int num2 = new System.Random().Next(1, 7);
                if (num2 == 1)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>������������</color>", false);
                }
                else if (num2 == 2)
                {
                    object[] objArray2 = new object[] { "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>", num, "</color>%]\n<color=#FF00FF>������������������", num, "%</color>" };
                    ev.Player.Broadcast(7, string.Concat(objArray2), false);
                }
                else if (num2 == 3)
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>LOLһ��������������õ�����</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(7, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>=w= qwq qaq awa AWSL</color>", false);
                }
            }
            if ((num >= 0x29) && (num <= 0x31))
            {
                if (new System.Random().Next(1, 6) == 1)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>������һ������,�°�����ش��븴�Ƶ�Ѹ��</color>", false);
                }
                else if (new System.Random().Next(1, 6) == 2)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>���ش��벻���ܸ����233</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>��ʵ50%���±�50%����������!</color>", false);
                }
            }
            if (num == 50)
            {
                int num5 = new System.Random().Next(1, 6);
                switch (num5)
                {
                    case 1:
                        ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>Ҳ������~��������ڿ��ܺϲ�����������</color>", false);
                        goto Label_037D;

                    case 2:
                        ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>50%�Ǻû��ǻ���</color>", false);
                        goto Label_037D;

                    case 3:
                        ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�ı಻���ұ�!Ϸ˵���Ǻ�˵!</color>", false);
                        break;
                }
                if (num5 == 3)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�ı಻���ұ�!Ϸ˵���Ǻ�˵!</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>50%...�����1%�᲻���ø�ǿ��?</color>", false);
                }
            }
        Label_037D:
            if ((num >= 51) && (num <= 80))
            {
                int num6 = new System.Random().Next(1, 6);
                switch (num6)
                {
                    case 1:
                        ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�Ҿ��ú���</color>", false);
                        goto Label_0468;

                    case 2:
                        ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>����DDÿһ��</color>", false);
                        goto Label_0468;

                    case 3:
                        ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>���а���̫�������㲻����</color>", false);
                        break;
                }
                if (num6 == 3)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>���а���̫�������㲻����</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�㿴����Ѵ���Ϸ�������</color>", false);
                }
            }
        Label_0468:
            if ((num >= 80) && (num <= 90))
            {
                int num2 = new System.Random().Next(1, 6);

                if (num2 == 1)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>������Ү��ŷ�ʣ�����������ŷ��Ϊ��!</color>", false);
                }
                if (num2 == 2)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>wdnm��̫ǿ��</color>", false);
                }
                if (num2 == 3)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>���ŷ���ѱ���̨ת�Ƶ���������</color>", false);
                }
                if (num2 == 4)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>�����Ʒ�����Ѿ����ڱ�����,����鿨233!</color>", false);
                }

            }

            if (num == 100)
            {
                if (new System.Random().Next(1, 6) <= 3)
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>....������100%[�Ų�����Ľ],����԰�������Ϣ��ͼ��������һ����</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= ��������ļ��,�㱾�غ���Ʒָ��Ϊ\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>100%!��ϲ��,����������Ϣ��ͼҲ��Ч233333</color>", false);
                }
            }
        }
        public void OnPlayerDeath(ref PlayerDeathEvent ev)
        {
            if(ev.Player.GetPlayerId() == scp550id)
            {
                scp550.SetRank("", "", true);
                Map.Broadcast("----[<color=#32CD32>SCP550</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                scp550id = 0;
                scp550yes = false;
                scp550 = null;
                scp550lv = 0;
                tssl = 0;

            }
            if(ev.Killer.GetPlayerId() == scp035id)
            {
                scp035item = ev.Killer.GetAllItems();
                scp035.SetRole(ev.Player.GetRole(), true);
                Coroutines.Add(Timing.RunCoroutine(SecondCounter24()));

            }
            if(ev.Player.GetPlayerId() == mzid)
            {
                mz = null;
                mzid = 0;
            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {

                Map.Broadcast("----[<color=#32CD32>��β���ڹ�</color>]----\n<color=#FF0000>[�ѱ�����]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                jwhng = null;
                jwhngwufashanghai = true;
                jwhngyes = false;
                jwhngshuachu = true;
                jwhngid = 0;
            }
            peaple = 0;
            if (scp_999.Contains(ev.Player.GetUserId()))
            {
                die = true;
                scp.SetRank("", "", true);
                Log.Info("SCP99������");
                string Killer999 = ev.Killer.GetNickname();
                scp_999.Clear();
                Map.Broadcast("----[<color=#32CD32>SCP999</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + Killer999 + "</color>", 6, false);
            }
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetTeam() == Team.MTF)
                {
                    peaple = peaple + 1;
                }
            }
            if (sjqx == false)
            {
                if (peaple == 2)
                {
                    Map.Broadcast("<color=red>ȫ���˵�ϣ��</color>\n<color=lime>�㱻ǿ���˿���</color>", 5, false);
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (player.GetTeam() == Team.MTF)
                        {
                            player.AddHealth(200);
                            player.AddItem(ItemType.SCP500);
                            sjqx = true;
                        }
                    }
                }

            }
            for (int i = 0; i <= 0x27; i++)
            {
                if (touxiang[i] == ev.Player.GetPlayerId())
                {
                    Log.Info(string.Concat(new object[] { "����Ͷ�����:", ev.Player.GetNickname(), " ����:", ev.Killer.GetNickname(), " ��Ϊ:", ev.Killer.GetRole() }));
                    touxiang[i] = 0;
                }
            }

            ev.Player.Broadcast(7, "��ӭ�ؼ�qwq", false);
            KillerID = ev.Killer.GetPlayerId();
            PlayerID = ev.Player.GetPlayerId();

            if ((scp650yes == true) && (ev.Player.GetPlayerId() == scp650id))
            {

                scp650 = null;
                scp650id = 0;
                scp650yes = false;
                ev.Killer.SetGodMode(false);
                ev.Killer.Kill();

            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {
                jwhhkid = 0;
                jwhhk = null;
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                scp073 = null;
                scp073id = 0;
                ev.Player.SetRank("white", "", true);
                Map.Broadcast("----[<color=#32CD32>SCP073</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp076id)
            {
                scp076 = null;
                scp076id = 0;
                scp076yes = false;
                ev.Player.SetRank("white", "", true);
                Map.Broadcast("----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp005aid)
            {
                scp005aid = 0;

            }
            if (ev.Player.GetPlayerId() == scp457id)
            {
                scp457 = null;
                scp457a = false;
                scp457die = true;
                scp457b = new Vector3();
                ev.Player.SetRank("white", "", true);
                scp457id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP457</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == xtdid)
            {
                xtd = null;
                xtdid = 0;
                xtd.SetRank("white", "", true);

            }
            if ((qblcq2 == true) && (qblcq.GetPlayerId() == ev.Player.GetPlayerId()))
            {
                qblcq2 = false;
                qblcq = null;

            }
            if (scp682.Contains(ev.Player.GetUserId()))
            {
                scp682.Remove(ev.Player.GetUserId());
                ev.Player.SetRank("white", " ", true);
                Map.Broadcast("----[<color=#32CD32>SCP682</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (scp939id == ev.Player.GetPlayerId())
            {
                ev.Player.SetRank("white", " ", true);
                scp939id = 0;

            }
            if (ev.Player.GetPlayerId() == scp914mid)
            {
                scp914m = null;
                scp914mid = 0;
                Map.Broadcast("----[<color=#32CD32>SCP914-M</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);


            }
            if (ev.Player.GetPlayerId() == scpqblid2)
            {
                scpqblid2 = 0;
                Map.Broadcast("----[<color=#32CD32>SCP�Ǳ���</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                scp181id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP181</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == scp035id)
            {
                Map.Broadcast("----[<color=#32CD32>SCP035</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                scp035 = null;
                scp035id = 0;
                scp035goout = false;
                scp035yes = false;
            }
            if (scp2006a.Contains(ev.Player.GetUserId()))
            {
                scp2006a.Clear();
                scp2006 = null;
                Map.Broadcast("----[<color=#32CD32>SCP2006</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                cxkid = 0;
                cxk = null;
                cxkyes = false;
                string Killercxk = ev.Killer.GetNickname();
                Map.Broadcast("----[<color=#32CD32>SCP������</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + Killercxk + "</color>", 6, false);
                Killercxk = null;
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == scp817id)
            {
                scp817id = 0;
                scp817 = null;
                scp817yes = false;
                string Killer817 = ev.Killer.GetNickname();
                Map.Broadcast("----[<color=#32CD32>SCP817</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + Killer817 + "</color>", 6, false);
                Killer817 = null;
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == D9341id)
            {
                if (times >= 5)
                {
                    D9341 = null;
                    D9341id = 0;
                    D9341Item = null;
                    D9341yes = false;
                    D9341zb = new Vector3();
                    ev.Player.SetRank("white", "", true);
                    Map.Broadcast("----[<color=#32CD32>D-9341</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

                }
            }
            if (bpb2.Contains(ev.Player.GetPlayerId()))
            {
                bpb = false;
                bpb2.Clear();
                ev.Player.SetRank("white", "", true);

            }
            if (LLBS233.Contains(ev.Player.GetPlayerId()))
            {
                Map.Broadcast("<color=#FFFF33>Mr.fish:</color>\nװ��ʧ��", 5, false);
                LLBS233.Remove(ev.Player.GetPlayerId());
                ev.Player.SetRank("white", "", true);

            }
            if (Dio2.Contains(ev.Player.GetUserId()))
            {
                Map.Broadcast("<color=#FFFF33>Dio:</color>\nװ��ʧ��", 5, false);
                Dio2.Remove(ev.Player.GetUserId());
                Dio = null;
                ev.Player.SetRank("white", "", true);

            }
            if (scp1143id == ev.Player.GetPlayerId())
            {
                scp1143 = null;
                scp1143id = 0;
                scp1143a = false;
                Map.Broadcast("----[<color=#32CD32>SCP1143</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ylb2.Contains(ev.Player.GetUserId()))
            {
                ev.Player.SetRank("white", "", true);
                ylb = null;
                ylb1 = false;
                ylb2.Clear();

            }
            if (HDZHG2.Contains(ev.Player.GetUserId()))
            {
                HDZHG2.Remove(ev.Player.GetUserId());

            }
            if (ev.Player.GetRole() == RoleType.Scp173)
            {

                s173 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>��ɱ���߱�����������</color>", 6, false);
                }
                else
                {
                    if (ev.Killer.GetUserId() == "76561198366416373@steam")
                    {
                        Map.Broadcast("----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n����������� <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                    }
                    else
                    {
                        Map.Broadcast("----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                    }

                }

            }
            if (ev.Player.GetRole() == RoleType.Scp049)
            {
                s049 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP049</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>��ɱ���߱�����������</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP049</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                Map.Broadcast("----[<color=#32CD32>SCP079</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>�˱���</color>", 6, false);
                ev.Player.SetRank("red", "SCP079 - �˱���", true);

            }
            if (ev.Player.GetRole() == RoleType.Scp096)
            {
                s096 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP096</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>��ɱ���߱�����������</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP096</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp93953)
            {
                s939_53 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_53</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>��ɱ���߱�����������</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_53</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp93989)
            {
                s939_89 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_89</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>��ɱ���߱�����������</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_89</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp106)
            {
                s106 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP106</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\nԭ��: <color=#40E0D0>��ɱ���߱�����������</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP106</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }
            }
        }
        public void OnThrowGrenade(ref GrenadeThrownEvent ev)
        {

        }
        public void OnMedicalItem(MedicalItemEvent ev)
        {
            if (ev.Player.GetUserId() == jklid)
            {
                ev.Allow = false;
                ev.Player.AddHealth(1000);
                jklid = null;
            }
            if(ev.Player.GetPlayerId() == scp457id)
            {
                scp457health = ev.Player.GetHealth();
                Coroutines.Add(Timing.RunCoroutine(scp457helth()));
            }
            
        }
        private IEnumerator<float> scp457helth()
        {
            yield return Timing.WaitForSeconds(10f);
            scp457.SetHealth(scp457health);
        }

        public void OnTeamRespawn(ref TeamRespawnEvent ev)
        {
            if (ev.IsChaos == true)
            {
                player22 = ev.ToRespawn;
                times2 = 1;
                foreach (ReferenceHub p in player22)
                {
                    hd.Add(p.GetUserId());
                }
            }
            if (ev.IsChaos == false)
            {
                player22 = ev.ToRespawn;
                tiems = 1;
                foreach (ReferenceHub p in player22)
                {
                    jw.Add(p.GetPlayerId());
                }
            }
        }
        public void OnConsoleCommand(ConsoleCommandEvent ev)
        {
            string name = ev.Player.GetNickname();
            int num = 0;
            int num2 = 0;
            char[] separator = new char[] { ' ' };
            string[] strArray = ev.Command.ToLower().Split(separator);
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetRole() == RoleType.ChaosInsurgency)
                {
                    num++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    num2++;
                }
            }
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                if (choise == false)
                {
                    if (ev.Command.Contains("scp"))
                    {
                        choise = true;
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Scp079)
                            {
                                player.SetRank("SCP079 - ����SCP", "aqua", true);
                            }
                        }
                        scp79 = true;
                        Map.Broadcast("<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>������ܿ־�� ����SCP079ѡ�����SCP</color>\n<color=aqua>SCP�����ܵ������˺�(����scp����)</color>", 10,  false);
                    }
                    if (ev.Command.Contains("h"))
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Scp079)
                            {
                                player.SetRank("SCP079 - ������:130 | �����ָ�:3AP/s   ��������", "aqua", true);
                            }
                        }
                        h = true;
                        ev.Player.SetRank("SCP079 - ������:130 | �����ָ�:3AP/s   ��������", "aqua", true);
                        choise = true;
                        Map.Broadcast("<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>SCPû�뵽������25�� ����SCP079ѡ���������</color>\n<color=aqua>���಻���ܵ������˺�</color>", 10,  false);
                        foreach (ReferenceHub p in Player.GetHubs())
                        {
                            if (p.GetTeam() == Team.SCP)
                            {
                                if (p.GetRole() != RoleType.Scp106)
                                {
                                    p.AddHealth(3000);
                                }
                            }
                        }
                    }
                }
            }
            if (ev.Command.Contains("steal") && (ev.Player.GetPlayerId() == xtd.GetPlayerId()) && (stealcd == false))
            {
                stealcd = true;
                foreach (ReferenceHub p in Player.GetHubs())
                {
                    int num4 = new System.Random().Next(1, 10);
                    if (num4 == 1)
                    {
                        ev.Player.AddItem(ItemType.Coin);
                    }
                    if (num4 == 2)
                    {
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);

                    }
                    if (num4 == 3)
                    {
                        ev.Player.AddItem(ItemType.GunE11SR); ;
                    }
                    if (num4 == 4)
                    {
                        ev.Player.AddItem(ItemType.GunUSP);
                    }
                    if (num4 == 5)
                    {
                        ev.Player.AddItem(ItemType.SCP500);
                    }
                    if (num4 == 6)
                    {
                        ev.Player.AddItem(ItemType.KeycardO5);
                    }
                    if (num4 > 6)
                    {
                        ev.Player.SendConsoleMessage("ʲô��û͵��", "green");
                    }
                    break;

                }
                ev.Player.SendConsoleMessage("�������û���ҵ���", "red");
            }
            if (ev.Player.GetUserId() == xywjid)
            {
                if (ev.Command.Contains("s173"))
                {
                    xywj.SetRole(RoleType.Scp173);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("s106"))
                {
                    xywj.SetRole(RoleType.Scp106);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("sD"))
                {
                    xywj.SetRole(RoleType.ClassD);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("sS"))
                {
                    xywj.SetRole(RoleType.Scientist);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("sG"))
                {

                    xywj = null;
                    xywjid = null;
                    xywj.Kill();
                    xywj.SetRole(RoleType.FacilityGuard);
                }
                if (ev.Command.Contains("s96"))
                {
                    xywj = null;
                    xywjid = null;
                    xywj.Kill();
                    xywj.SetRole(RoleType.Scp096);
                }
                if ((scp650yes == true) && (ev.Player.GetPlayerId() == scp650id))
                {
                    scp650 = null;
                    scp650id = 0;
                    scp650yes = false;
                    Map.Broadcast("----[<color=#32CD32>[SCP650]</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "��ѡ������" + "</color>", 6, false);

                }
                if (ev.Player.GetPlayerId() == scp076id)
                {
                    scp076 = null;
                    scp076id = 0;
                    scp076yes = false;
                    Map.Broadcast("----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "��ѡ������" + "</color>", 6, false);

                }
                
            }

            if (ev.Command.Contains("dk"))
            {
                if (hrss == true)
                {
                    jwhhk.SetRole(RoleType.NtfScientist);
                    jwhhk.SetPosition(hkzb);
                    hktime = 0;
                    hrss = false;
                }
            }

            if (ev.Command.Contains("hk"))
            {
                if ((jwhhkid == ev.Player.GetPlayerId()) && (hrss == false))
                {
                    hrss = true;
                    hkzb = ev.Player.GetPosition();
                    ev.Player.SetRole(RoleType.Scp079);

                }
            }

            if (ev.Command.Contains("tx")&&(ev.Player.GetPlayerId()!= scp035id) && ((ev.Player.GetRole() == RoleType.ClassD) && (Dio2.Contains(ev.Player.GetUserId()) == false) || (ev.Player.GetRole() == RoleType.Scientist)))
            {
                int playerId = ev.Player.GetPlayerId();
                if ((ev.Player.GetRole() == RoleType.ClassD) && (num == 0))
                {
                    touxiang[round] = playerId;
                    ev.Player.Broadcast(10, "<color=#FF00FF>���Ѿ�����Ͷ��ģʽ</color>�޷�ȡ��\n�����ӳ���ʱ��<color=#00FF7F>�Զ���Ϊ�෴��Ӫ</color>", false);
                    ev.Player.SetRank("(" + ev.Player.GetPlayerId() + ") Ͷ����Ա", "default", true);
                    round++;
                }
                else if ((ev.Player.GetRole() == RoleType.ClassD) && (num > 0))
                {
                    ev.Player.Broadcast(10, "<color=#FF00FF>���޷�����Ͷ��ģʽ</color>\n��Ϊ������<color=#00FF7F>����</color>", false);
                }
                if ((ev.Player.GetRole() == RoleType.Scientist) && (num2 == 0))
                {
                    touxiang[round] = playerId;
                    ev.Player.Broadcast(10, "<color=#FF00FF>���Ѿ�����Ͷ��ģʽ</color>�޷�ȡ��\n�����ӳ���ʱ��<color=#00FF7F>�Զ���Ϊ�෴��Ӫ</color>", false);
                    ev.Player.SetRank("Ͷ����Ա", "default", true);
                    round++;
                }
                else if ((ev.Player.GetRole() == RoleType.Scientist) && (num2 > 0))
                {
                    ev.Player.Broadcast(10, "<color=#FF00FF>���޷�����Ͷ��ģʽ</color>\n��Ϊ������<color=#00FF7F>MTF</color>", false);
                }
            }
            if (ev.Command.Contains("pos"))
            {
                Vector3 position = ev.Player.GetPosition();
                object[] objArray1 = new object[] { position.x, "|", position.y, "|", position.z };
                ev.ReturnMessage = string.Concat(objArray1) ?? "";
            }
            if (strArray[0] == "c")
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("����������", "yellow");
                }
                if (strArray.Length == 2)
                {
                    ev.Player.SendConsoleMessage("���ͳɹ�", "yellow");
                    if (ev.Player.GetRole() == RoleType.Spectator)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Spectator)
                            {
                                player.Broadcast(5, "[���]" + ev.Player.GetNickname() + strArray[1], false);
                            }
                        }
                    }
                    if (ev.Player.GetTeam() == Team.SCP)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetTeam() == Team.SCP)
                            {
                                player.Broadcast(5, "[���]" + ev.Player.GetNickname() + strArray[1], false);
                            }
                        }
                    }
                    if (ev.Player.GetTeam() == Team.MTF)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetTeam() == Team.MTF)
                            {
                                player.Broadcast(5, "[���]" + ev.Player.GetNickname() + strArray[1], false);
                            }
                        }
                    }
                }
            }
            if (strArray[0] == "xfuckyou")
            {
                Vector3 vector = new Vector3(ev.Player.GetPosition().x + 3, ev.Player.GetPosition().y, ev.Player.GetPosition().z);

                ev.Player.SetPosition(vector);
            }
            if (strArray[0] == "yfuckyou")
            {
                Vector3 vector = new Vector3(ev.Player.GetPosition().x, ev.Player.GetPosition().y + 3, ev.Player.GetPosition().z);

                ev.Player.SetPosition(vector);
            }
            if (strArray[0] == "zfuckyou")
            {
                Vector3 vector = new Vector3(ev.Player.GetPosition().x, ev.Player.GetPosition().y, ev.Player.GetPosition().z + 3);

                ev.Player.SetPosition(vector);
            }
            if ((ev.Player.GetRole() == RoleType.NtfCommander) && (strArray[0] == "bc"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("\nָ��������ʹ�ý̳�:\n\n.bc [����]\n\n���ݻ�ȫͼ���͸������о�β����Ӫ���", "yellow");
                }
                else if ((strArray.Length == 2) && !coldbc)
                {
                    coldbc = true;
                    foreach (ReferenceHub player5 in Player.GetHubs())
                    {
                        if (player5.GetTeam() == Team.MTF)
                        {
                            player5.ClearBroadcasts();
                            player5.Broadcast(6, "<color=#4682B4>[����ָ�������Ϣ]</color>\n" + strArray[1], false);
                        }
                    }

                }
            }
            if (strArray[0] == "f")
            {
                Vector3 pos = scpqbl3.GetPosition();
                float pos2 = pos.x + 3;
                float pos3 = pos.y + 3;
                float pos4 = pos.z + 3;
                float pos5 = pos.x - 3;
                float pos6 = pos.y - 3;
                float pos7 = pos.z - 3;
                ReferenceHub player = ev.Player;
                if (qblcq2 == true)
                {
                    qblcq2 = false;
                }
                else if ((player.GetPosition().x <= pos2) && (player.GetPosition().x >= pos5) && (player.GetPosition().y <= pos3) && (player.GetPosition().y >= pos6) && ((player.GetPosition().z <= pos4) && (player.GetPosition().z >= pos7)))
                {
                    Map.Broadcast(ev.Player.GetNickname() + "�Ѿ�����̹��", 5, false);
                    qblcq = ev.Player;
                    qblcq2 = true;
                }



            }
            if ((ev.Player.GetRole() == RoleType.NtfCommander) && (strArray[0] == "tb"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("\n���ʹ�ý̳�:\n\n.tb [���]\n\n���Խ���β���±����Ϊ ��β��ʿ�� 300��1����", "yellow");
                }
                else if ((strArray.Length == 2) && !coldtb)
                {
                    coldtb = true;

                    int num4 = int.Parse(strArray[1]);
                    foreach (ReferenceHub player2 in Player.GetHubs())
                    {
                        if ((player2.GetPlayerId() == num4) && (player2.GetRole() == RoleType.NtfCadet))
                        {
                            ev.Player.SendConsoleMessage("��γɹ�", "yellow");
                            player2.SetRole(RoleType.NtfLieutenant);
                            player2.Broadcast(5, "����ֵó���nice��ָ�ӹ������", false);
                        }
                    }

                }
            }
            if ((HDZHG2.Contains(ev.Player.GetUserId())) && (strArray[0] == "bc"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("\n����ָ��������ʹ�ý̳�:\n\n.bc [����]\n\n���ݻ�ȫͼ���͸������о�β����Ӫ���", "yellow");
                }
                else if ((strArray.Length == 2))
                {
                    foreach (ReferenceHub player5 in Player.GetHubs())
                    {
                        if (player5.GetTeam() == Team.CHI)
                        {
                            player5.ClearBroadcasts();
                            player5.Broadcast(6, "<color=#4682B4>[���Ի���ָ�������Ϣ]</color>\n" + strArray[1], false);
                        }
                    }

                }
            }
            if ((strArray[0] == "list"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("ȫ��id", "yellow");
                    foreach (ReferenceHub player5 in Player.GetHubs())
                    {
                        ev.Player.SendConsoleMessage("�������:" + player5.GetNickname() + "     ��ұ��:" + player5.GetPlayerId(), "yellow");
                    }
                    ev.Player.SendConsoleMessage("��ȡ���", "yellow");
                }
            }
            if ((strArray[0] == "cz"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("��������ָ����� ������ָ���Ļ�����DD��������", "yellow");

                }
                if (strArray.Length == 2)
                {
                    int num4 = int.Parse(strArray[1]);
                    foreach (ReferenceHub player2 in Player.GetHubs())
                    {
                        if ((player2.GetPlayerId() == num4) && (player2.GetTeam() == Team.CHI) && (!HDZHG2.Contains(player2.GetUserId())))
                        {
                            ev.Player.SendConsoleMessage("ִ�����", "yellow");
                            player2.SetRole(RoleType.ClassD);
                            player2.Broadcast(5, "����Ϊ��ŭ�˻���ָ�ӹٱ�������DD", false);
                        }
                    }
                }
            }
            if ((strArray[0] == "help"))
            {
                if (strArray.Length == 1)
                {
                    if (HDZHG2.Contains(ev.Player.GetUserId()))
                    {
                        ev.Player.SendConsoleMessage("����ָ�ӹ�ʹ�ý̳�\n.bc + [����]�����ݹ㲥��ȫ�����\n.cz +[��ұ��]����ҿ�����D��", "green");
                    }
                    if (ev.Player.GetRole() == RoleType.NtfCommander)
                    {
                        ev.Player.SendConsoleMessage("��β��ָ�ӹ�ʹ�ý̳�\n.bc + [����]�����ݹ㲥��ȫ���β��\n.tb +[��ұ��]���������", "green");
                    }

                }
            }
            num = 0;
            num2 = 0;
        }
        public void PMD()
        {
        qwq1:

            if (roundstart == false)
            {

                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam"&& player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("�ƺ�Ԥ��λ��", "red", true);
                            if (player233[i].GetUserId() == "76561198425823494@steam")
                            {
                                player233[i].SetRank("˹����", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198388299994@steam")
                            {
                                player233[i].SetRank("BILIBILI_z_zɧ��", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561197961446054@steam")
                            {
                                player233[i].SetRank("BILIBILI_һ������ƹ�", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198190686028@steam")
                            {
                                player233[i].SetRank("BILIBILI_�ֲ�����", "cyan", true);
                            }
                            if (player233[i].GetUserId() == "76561198825310613@steam")
                            {
                                player233[i].SetRank("����TV_����.����", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198384476113@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198381947239@steam")
                            {
                                player233[i].SetRank("BILIBILI_��������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198816705835@steam")
                            {
                                player233[i].SetRank("�¶�һ��", "silvery", true);
                            }

                            if (player233[i].GetUserId() == "76561198133773112@steam")
                            {
                                player233[i].SetRank("BILIBILI_������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198335932913@steam")
                            {
                                player233[i].SetRank("�в���~", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198371077590@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198979881230@steam")
                            {
                                player233[i].SetRank("��Ⱥ��פUP��", "aqua", true);
                            }
                            if (player233[i].GetUserId() == "76561198401019684@steam")
                            {
                                player233[i].SetRank("����Сѧ����������С���", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198145812844@steam")
                            {
                                player233[i].SetRank("������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198359791579@steam")
                            {
                                player233[i].SetRank("D-17396", "yellow", true);
                            }
                        }

                    }
                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {

                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("��ӭ��������Ʒ�����:979685108 | �뿴����", "red", true);
                            if (player233[i].GetUserId() == "76561198366416373@steam")
                            {
                                player233[i].SetRank("BILIBILI_�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198977855934")
                            {
                                player233[i].SetRank("49����", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198361793702@steam")
                            {
                                player233[i].SetRank("����һ�����������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198841949627@steam")
                            {
                                player233[i].SetRank("�ճ�����ˮ�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198840690652@steam")
                            {
                                player233[i].SetRank("����NPC", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198831124013@steam")
                            {
                                player233[i].SetRank("Ԯ����Ů", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198388299994@steam")
                            {
                                player233[i].SetRank("BILIBILI_z_zɧ��", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561197961446054@steam")
                            {
                                player233[i].SetRank("BILIBILI_һ������ƹ�", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198190686028@steam")
                            {
                                player233[i].SetRank("BILIBILI_�ֲ�����", "cyan", true);
                            }
                            if (player233[i].GetUserId() == "76561198825310613@steam")
                            {
                                player233[i].SetRank("����TV_����.����", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198384476113@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198381947239@steam")
                            {
                                player233[i].SetRank("BILIBILI_��������", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198816705835@steam")
                            {
                                player233[i].SetRank("�¶�һ��", "silvery", true);
                            }
                            if (player233[i].GetUserId() == "76561198841744752@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }

                            if (player233[i].GetUserId() == "76561198133773112@steam")
                            {
                                player233[i].SetRank("BILIBILI_������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198335932913@steam")
                            {
                                player233[i].SetRank("�в���~", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198425823494@steam")
                            {
                                player233[i].SetRank("˹����", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198371077590@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198812450849@steam")
                            {
                                player233[i].SetRank("BILIBILI_gou_mr", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198979881230@steam")
                            {
                                player233[i].SetRank("��Ⱥ��פUP��", "aqua", true);
                            }
                            if (player233[i].GetUserId() == "76561198191585303@steam")
                            {
                                player233[i].SetRank("����Ů", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198401019684@steam")
                            {
                                player233[i].SetRank("����Сѧ����������С���", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198145812844@steam")
                            {
                                player233[i].SetRank("������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198359791579@steam")
                            {
                                player233[i].SetRank("D-17396", "yellow", true);
                            }
                        }
                    }

                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            if (player233[i].GetUserId() == "76561198366416373@steam")
                            {
                                player233[i].SetRank("BILIBILI_�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198361793702@steam")
                            {
                                player233[i].SetRank("����һ�����������", "green", true);
                            }
                            player233[i].SetRank("��ӭ��������Ʒ�����:979685108 | �뿴����", "yellow", true);
                            if (player233[i].GetUserId() == "76561198977855934@steam")
                            {
                                player233[i].SetRank("49����", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198840690652@steam")
                            {
                                player233[i].SetRank("����NPC", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198841949627@steam")
                            {
                                player233[i].SetRank("�ճ�����ˮ�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198831124013@steam")
                            {
                                player233[i].SetRank("Ԯ����Ů", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198388299994@steam")
                            {
                                player233[i].SetRank("BILIBILI_z_zɧ��", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561197961446054@steam")
                            {
                                player233[i].SetRank("BILIBILI_һ������ƹ�", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198190686028@steam")
                            {
                                player233[i].SetRank("BILIBILI_�ֲ�����", "cyan", true);
                            }
                            if (player233[i].GetUserId() == "76561198825310613@steam")
                            {
                                player233[i].SetRank("����TV_����.����", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198384476113@steam")
                            {
                                player233[i].SetRank("lime", "VIP1", true);
                            }
                            if (player233[i].GetUserId() == "76561198381947239@steam")
                            {
                                player233[i].SetRank("BILIBILI_��������", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198816705835@steam")
                            {
                                player233[i].SetRank("�¶�һ��", "silvery", true);
                            }
                            if (player233[i].GetUserId() == "76561198841744752@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }

                            if (player233[i].GetUserId() == "76561198133773112@steam")
                            {
                                player233[i].SetRank("BILIBILI_������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198335932913@steam")
                            {
                                player233[i].SetRank("�в���~", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198425823494@steam")
                            {
                                player233[i].SetRank("˹����", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198371077590@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198812450849@steam")
                            {
                                player233[i].SetRank("BILIBILI_gou_mr", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198979881230@steam")
                            {
                                player233[i].SetRank("��Ⱥ��פUP��", "aqua", true);
                            }
                            if (player233[i].GetUserId() == "76561198191585303@steam")
                            {
                                player233[i].SetRank("����Ů", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198401019684@steam")
                            {
                                player233[i].SetRank("����Сѧ����������С���", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198145812844@steam")
                            {
                                player233[i].SetRank("������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198359791579@steam")
                            {
                                player233[i].SetRank("D-17396", "yellow", true);
                            }
                        }
                    }

                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("��ӭ��������Ʒ�����:979685108 | �뿴����", "green", true);
                            if (player233[i].GetUserId() == "76561198366416373@steam")
                            {
                                player233[i].SetRank("BILIBILI_�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198361793702@steam")
                            {
                                player233[i].SetRank("����һ�����������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198977855934@steam")
                            {
                                player233[i].SetRank("49����", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198840690652@steam")
                            {
                                player233[i].SetRank("����NPC", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198831124013@steam")
                            {
                                player233[i].SetRank("pink", "Ԯ����Ů", true);
                            }
                            if (player233[i].GetUserId() == "76561198841949627@steam")
                            {
                                player233[i].SetRank("�ճ�����ˮ�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198388299994@steam")
                            {
                                player233[i].SetRank("BILIBILI_z_zɧ��", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561197961446054")
                            {
                                player233[i].SetRank("BILIBILI_һ������ƹ�", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198190686028@steam")
                            {
                                player233[i].SetRank("BILIBILI_�ֲ�����", "cyan", true);
                            }
                            if (player233[i].GetUserId() == "76561198825310613@steam")
                            {
                                player233[i].SetRank("����TV_����.����", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198384476113@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198381947239@steam")
                            {
                                player233[i].SetRank("BILIBILI_��������", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198816705835@steam")
                            {
                                player233[i].SetRank("�¶�һ��", "silvery", true);
                            }
                            if (player233[i].GetUserId() == "76561198841744752@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198133773112@steam")
                            {
                                player233[i].SetRank("BILIBILI_������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198335932913@steam")
                            {
                                player233[i].SetRank("�в���~", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198425823494@steam")
                            {
                                player233[i].SetRank("˹����", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198371077590@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198812450849@steam")
                            {
                                player233[i].SetRank("BILIBILI_gou_mr", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198979881230@steam")
                            {
                                player233[i].SetRank("��Ⱥ��פUP��", "aqua", true);
                            }
                            if (player233[i].GetUserId() == "76561198191585303@steam")
                            {
                                player233[i].SetRank("����Ů", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198401019684@steam")
                            {
                                player233[i].SetRank("����Сѧ����������С���", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198145812844@steam")
                            {
                                player233[i].SetRank("������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198359791579@steam")
                            {
                                player233[i].SetRank("D-17396", "yellow", true);
                            }
                        }
                    }
                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("��ӭ��������Ʒ�����:979685108 | �뿴����", "pink", true);
                            if (player233[i].GetUserId() == "76561198366416373@steam")
                            {
                                player233[i].SetRank("BILIBILI_�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198361793702@steam")
                            {
                                player233[i].SetRank("����һ������������������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198977855934@steam")
                            {
                                player233[i].SetRank("49����", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198840690652@steam")
                            {
                                player233[i].SetRank("����NPC", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198841949627@steam")
                            {
                                player233[i].SetRank("�ճ�����ˮ�������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198831124013@steam")
                            {
                                player233[i].SetRank("Ԯ����Ů", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198388299994@steam")
                            {
                                player233[i].SetRank("crimson", "BILIBILI_z_zɧ��", true);
                            }
                            if (player233[i].GetUserId() == "76561197961446054@steam")
                            {
                                player233[i].SetRank("BILIBILI_һ������ƹ�", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198190686028@steam")
                            {
                                player233[i].SetRank("BILIBILI_�ֲ�����", "cyan", true);
                            }
                            if (player233[i].GetUserId() == "76561198825310613@steam")
                            {
                                player233[i].SetRank("����TV_����.����", "crimson", true);
                            }
                            if (player233[i].GetUserId() == "76561198384476113@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198381947239@steam")
                            {
                                player233[i].SetRank("BILIBILI_��������", "pink", true);
                            }
                            if (player233[i].GetUserId() == "76561198816705835@steam")
                            {
                                player233[i].SetRank("�¶�һ��", "silvery", true);
                            }
                            if (player233[i].GetUserId() == "76561198841744752@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198133773112@steam")
                            {
                                player233[i].SetRank("BILIBILI_������", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198335932913@steam")
                            {
                                player233[i].SetRank("�в���~", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198425823494@steam")
                            {
                                player233[i].SetRank("˹����", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198371077590@steam")
                            {
                                player233[i].SetRank("VIP1", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198812450849@steam")
                            {
                                player233[i].SetRank("BILIBILI_gou_mr", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198979881230@steam")
                            {
                                player233[i].SetRank("��Ⱥ��פUP��", "aqua", true);
                            }
                            if (player233[i].GetUserId() == "76561198191585303@steam")
                            {
                                player233[i].SetRank("����Ů", "red", true);
                            }
                            if (player233[i].GetUserId() == "76561198401019684@steam")
                            {
                                player233[i].SetRank("����Сѧ����������С���", "lime", true);
                            }
                            if (player233[i].GetUserId() == "76561198145812844@steam")
                            {
                                player233[i].SetRank("������", "green", true);
                            }
                            if (player233[i].GetUserId() == "76561198359791579@steam")
                            {
                                player233[i].SetRank("D-17396", "yellow", true);
                            }

                        }
                    }

                }
                Thread.Sleep(5000);
            }
            else
            {
                pmd.Abort();
            }
            goto qwq1;
        }
        public void OnPocketDimDeath(PocketDimDeathEvent ev)
        {
            if (scp_999.Contains(ev.Player.GetUserId()))
            {
                ev.Allow = false;
            }
            if (ev.Player.GetPlayerId() == scp457id)
            {
                ev.Allow = false;
            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                ev.Allow = false;
            }
        }
        public void OnCheckEscape(ref CheckEscapeEvent ev)
        {
            if(scp035id == ev.Player.GetPlayerId())
            {
                ev.Allow = false;
                Map.Broadcast("<color=#red>���棡����[SCP-035]�Ѿ��ӳ���ʩ �뾡������</color>", 10, false);
                scp035goout = true;
            }

            if (LLBS233.Contains(ev.Player.GetPlayerId()))
            {
                ev.Allow = false;
            }
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetRole() == RoleType.ChaosInsurgency)
                {
                    chaos++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    mtf++;
                }
            }
            Log.Info("��������:" + chaos);
            Log.Info("MTF����:" + mtf);
            foreach (int num2 in touxiang)
            {
                if (num2 == ev.Player.GetPlayerId())
                {
                    Log.Info("Ͷ�������:" + ev.Player.GetNickname());
                }
                if (((num2 == ev.Player.GetPlayerId()) && (ev.Player.GetRole() == RoleType.ClassD)) && (chaos == 0))
                {
                    Log.Info("��Ҽ�����ΪNTFѧԱ");
                    Log.Info("�����:" + ev.Player.GetNickname());
                    ev.Player.SetRole(RoleType.NtfCadet);
                    for (int i = 0; i <= 100; i++)
                    {
                        if (touxiang[i] == ev.Player.GetPlayerId())
                        {
                            touxiang[i] = 0;
                        }
                    }
                    chaos = 0;
                    mtf = 0;
                    return;
                }
                if (((num2 == ev.Player.GetPlayerId()) && (ev.Player.GetRole() == RoleType.Scientist)) && (mtf == 0))
                {
                    Log.Info("��Ҽ�����Ϊ����");
                    Log.Info("�����:" + ev.Player.GetNickname());
                    ev.Player.SetRole(RoleType.ChaosInsurgency);
                    for (int i = 0; i <= 100; i++)
                    {
                        if (touxiang[i] == ev.Player.GetPlayerId())
                        {
                            touxiang[i] = 0;
                        }
                    }
                    chaos = 0;
                    mtf = 0;
                    return;
                }
            }
            chaos = 0;
            mtf = 0;
        }
        public void OnDoorInteract(ref DoorInteractionEvent ev)
        {
            if (door2.Contains(ev.Door) && (jljy2.Contains(ev.Player.GetUserId()) == false))
            {
                ev.Player.AddHealth(-50);
                ev.Player.Broadcast(5, "������ӰΪ�����", false);
                door2.Remove(ev.Door);

            }


           // foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
            //{
              //  System.Random num111 = new System.Random();
                //if ((num111.Next(1, 301) >= 299) && (deadtimer <= 1800))
                //{
                //
                  //  ev.Player.SetPosition(new Vector3(door.transform.position.x, door.transform.position.y + (float)1.5, door.transform.position.z));
                    //ev.Player.ClearBroadcasts();
                    //ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>��������������Ա�����</color>", false);

                //}
            //}
                   

           
            if (bhsx == true)
            {
                if (new System.Random().Next(0, 100) >= 97)
                {
                    ev.Allow = false;
                }
            }
            if ((ev.Player.GetRole() == RoleType.Scp096) && (new System.Random().Next(1, 100) <= 3))
            {
                ev.Allow = true;
            }
            if ((ev.Door.DoorName == "NUKE_SURFACE") && (ev.Player.inventory.GetItemInHand().id == ItemType.KeycardNTFCommander) || (ev.Player.inventory.GetItemInHand().id == ItemType.KeycardChaosInsurgency))
            {
                ev.Allow = true;
            }
            //            if (csm == true)
            //{
            // Doors = Map.Doors;
            //System.Random random = new System.Random();
            //door3 = Doors[random.Next(Doors.Count)];
            //ev.Player.SetPosition(new Vector3(door3.localPos.x, door3.localPos.y + (float)1.5, door3.localPos.z));
            // ev.Player.ClearBroadcasts();
            //         ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>��������������Ա�����</color>", false);

            //     }
            if (bscp79 == true)
            {
                if (ev.Player.GetTeam() == Team.SCP)
                {
                    if (new System.Random().Next(0, 100) >= 95)
                    {
                        ev.Allow = true;
                    }
                }
            }

            if ((scp005 == true) && (ev.Player.GetPlayerId() == scp005aid))
            {
                ev.Allow = true;

            }

            if (scp682.Contains(ev.Player.GetUserId()) && (ev.Player.GetRole() == RoleType.Scp93989))
            {
                if (new System.Random().Next(0, 100) >= 90)
                {
                    ev.Door.DestroyDoor(true);
                    ev.Allow = true;
                }

            }

            if (ev.Player.GetPlayerId() == scp181id)
            {
                System.Random random = new System.Random();
                if (random.Next(1, 0x1f) == 0x18)
                {
                    ev.Allow = true;
                }

            }

            if (ev.Player.GetPlayerId() == cxkid)
            {
                System.Random random = new System.Random();
                if (random.Next(1, 5) == 2)
                {
                    ev.Allow = false;
                    ev.Player.Broadcast(3, "��̫���˵�����û��", false);
                }
                if (jntm == true)
                {
                    ev.Allow = true;
                    ev.Door.DestroyDoor(true);
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(4, "�㷢������̫���Ŷ�������ȥ��", false);

                }

            }

            if ((ev.Player.GetRole() == RoleType.FacilityGuard) && (ev.Door.DoorName == "INTERCOM"))
            {
                ev.Door.DestroyDoor(true);
                Map.Broadcast("�����ϸ�" + ev.Player.GetNickname() + "һjio�߿��˹㲥��", 5, false);

            }
            if ((ev.Player.GetTeam() == Team.MTF) && (ev.Door.DoorName == "INTERCOM"))
            {
                ev.Door.DestroyDoor(true);

                Map.Broadcast("�����ϸ�" + ev.Player.GetNickname() + "һjio�߿��˹㲥��", 5, false);

            }
            if ((Dio2.Contains(ev.Player.GetUserId())) && (sjtz1 == true))
            {
                ev.Door.DestroyDoor(true);

                ev.Allow = true;

            }
            if ((Dio2.Contains(ev.Player.GetUserId()) == false) && (sjtz1 == true))
            {
                ev.Allow = false;

            }
            if (jljy2.Contains(ev.Player.GetUserId()))
            {
                int num3 = new System.Random().Next(1, 100);
                if (num3 >= 99)
                {
                    door2.Add(ev.Door);
                    ev.Player.Broadcast(5, "�Ѿ�����ը��", false);
                }
            }
        }
        public void OnScp106Contain(Scp106ContainEvent ev)
        {
            Map.ClearBroadcasts();
            Map.Broadcast("<color=red>�㲥</color>:(����ȹǷ������ʹ����)\nΪʲô? Ϊʲô!\n��������������", 20, false);
        }
        public void OnGeneratorUnlock(ref GeneratorUnlockEvent ev)
        {
            if(h == true)
            {
                ev.Allow = false;
                ev.Player.Broadcast(5, "��ǰ79����������Ӫ", false);
            }
        }
        public void OnCheckRoundEnd(ref CheckRoundEndEvent ev)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if ((player.GetTeam() == Team.SCP) && (player.GetPlayerId() != scp650id))
                {
                    num++;
                }
                if (player.GetTeam() == Team.CHI)
                {
                    num2++;
                }
                if (player.GetRole() == RoleType.Scientist)
                {
                    num3++;
                }
                if ((player.GetRole() == RoleType.ClassD) && (player.GetPlayerId() != scp035id))
                {
                    num4++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    num5++;
                }
                if(h == true)
                {
                    if(player.GetRole()==RoleType.Scp079)
                    {
                        num--;
                    }
                }

            }

            
            if ((num4 == 0) && (num >= 1) && (num5 == 0) && (num3 == 0))
            {
                ev.LeadingTeam = RoundSummary.LeadingTeam.Anomalies;
                ev.ForceEnd = true;

            }
            if ((num == 0) && (num4 == 0) && (num5 >= 1))
            {
                ev.LeadingTeam = RoundSummary.LeadingTeam.FacilityForces;
                ev.ForceEnd = true;
            }

        }
        public void OnDropItem(ref DropItemEvent ev)
        {
            Vector3 room = ev.Player.GetPosition();
            if(jwhngwufashanghai == false)
            {
                if(bscd == false)
                {
                    if (ev.Player.GetPlayerId() == jwhngid)
                    {
                        if (ev.Item.id == ItemType.GrenadeFlash)
                        {
                            ev.Allow = false;
                            item = ev.Player.GetAllItems();
                            health = ev.Player.GetHealth();
                            if (ev.Player.GetRole() == RoleType.ChaosInsurgency)
                            {
                                ev.Player.SetRole(RoleType.NtfCadet, true);
                                foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.GetAllItems())
                                {
                                    ev.Player.RemoveItem(syncItemInfo);
                                }

                            }
                            if (ev.Player.GetRole() == RoleType.NtfCadet)
                            {
                                ev.Player.SetRole(RoleType.ChaosInsurgency, true);
                                foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.GetAllItems())
                                {
                                    ev.Player.RemoveItem(syncItemInfo);
                                }
                            }

                            Coroutines.Add(Timing.RunCoroutine(SecondCounter25()));


                        }
                    }
                }


            }
            if (ev.Player.GetPlayerId() == D9341id)
            {
                if (ev.Item.id == ItemType.GrenadeFlash)
                {
                    D9341.Broadcast(6, "�浵�ɹ�", false);
                    ev.Allow = false;
                    ev.Player.RemoveItem(ev.Item);
                    D9341.AddItem(ItemType.GrenadeFlash);
                    D9341Item = D9341.GetAllItems();
                    D9341zb = D9341.GetPosition();

                    D9341js = D9341.GetRole();
                }
                if (ev.Item.id == ItemType.Flashlight)
                {
                    if (times <= 5)
                    {
                        D9341.SetRole(D9341js);
                        Coroutines.Add(Timing.RunCoroutine(SecondCounter23()));

                        times++;
                    }

                }
            }
            if (scp2006id == ev.Player.GetPlayerId())
            {
                if (ev.Item.id == ItemType.Coin)
                {

                    foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
                    {
                        int door2 = new System.Random().Next(1, 100);
                        if (door2 >= 80)
                        {
                            ev.Player.SetPosition(new Vector3(door.transform.position.x, door.transform.position.y + (float)1.5, door.transform.position.z));
                            break;
                        }
                    }
                }
            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                if (ev.Item.id == ItemType.Flashlight)
                {
                    jntm = true;
                    ev.Player.ClearBroadcasts();
                    ev.Allow = false;
                    ev.Player.RemoveItem(ev.Item);
                    ev.Player.AddItem(ItemType.Coin);
                    ev.Player.Broadcast(10, "�ɹ���������̫��ʱ��10��", false);

                }
            }
            if ((room.y <= -1f) && (room.y >= -7f))
            {
                if (coldwait233 == false)
                {
                    ev.Player.AddItem(ev.Item.id);
                    ev.Player.AddItem(ev.Item.id);
                    ev.Player.Broadcast(5, "���Ƴɹ�", false);
                    coldwait233 = true;
                }
                if (coldwait233 == true)
                {
                    ev.Player.Broadcast(5, "038:��������һ��������QAQ", false);
                }
            }
            if (scp2818pick == true)
            {
                if ((ev.Item.id == ItemType.GunCOM15) && (scp2818.GetPlayerId() == ev.Player.GetPlayerId()))
                {
                    ev.Player.Broadcast(5, "SCP2818�Ѿ�������", false);
                    scp2818pick = false;
                    scp2818id = 0;
                    scp2818 = null;
                }
            }

            if ((Dio2.Contains(ev.Player.GetUserId())) && (ev.Item.id == ItemType.Flashlight) && (sjtz2 == false))
            {
                ev.Player.AddItem(ItemType.Coin);
                Map.ClearBroadcasts();
                Map.Broadcast("<color=#99FF00>Dio������ʱ��ֹͣ</color>", 12, false);
                cd = new Thread(CD);
                cd.Start();
                sjtz1 = true;
                sjtz2 = true;
            }

        Label_01E9:
            if ((((((s173 == 0) || (s173 == 2)) && ((s096 == 0) || (s096 == 2))) && (((s939_53 == 0) || (s939_53 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s106 == 1) && (RoleSet != 1)))
            {
                Log.Info("��ǰ����ֻʣ��һ��SCP��");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "��ǰ����ֻʣ��һ��SCP��\n<color=#FF1493>����԰����ָ�ӹٿ�������</color>\n��Ϊ���ݹ���ʦ��", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s096 == 0) || (s096 == 2))) && (((s939_53 == 0) || (s939_53 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s173 == 1) && (RoleSet != 1)))
            {
                Log.Info("��ǰ����ֻʣ��һ��SCP��");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "��ǰ����ֻʣ��һ��SCP��\n<color=#FF1493>����԰����ָ�ӹٿ�������</color>\n��Ϊ���ݹ���ʦ��", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s939_53 == 0) || (s939_53 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s096 == 1) && (RoleSet != 1)))
            {
                Log.Info("��ǰ����ֻʣ��һ��SCP��");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "��ǰ����ֻʣ��һ��SCP��\n<color=#FF1493>����԰����ָ�ӹٿ�������</color>\n��Ϊ���ݹ���ʦ��", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s096 == 0) || (s096 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s939_53 == 1) && (RoleSet != 1)))
            {
                Log.Info("��ǰ����ֻʣ��һ��SCP��");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "��ǰ����ֻʣ��һ��SCP��\n<color=#FF1493>����԰����ָ�ӹٿ�������</color>\n��Ϊ���ݹ���ʦ��", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s096 == 0) || (s096 == 2)) && ((s939_53 == 0) || (s939_53 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s939_89 == 1) && (RoleSet != 1)))
            {
                Log.Info("��ǰ����ֻʣ��һ��SCP��");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "��ǰ����ֻʣ��һ��SCP��\n<color=#FF1493>����԰����ָ�ӹٿ�������</color>\n��Ϊ���ݹ���ʦ��", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s096 == 0) || (s096 == 2)) && ((s939_53 == 0) || (s939_53 == 2)))) && ((s939_89 == 0) || (s939_89 == 2))) && ((s049 == 1) && (RoleSet != 1)))
            {
                Log.Info("��ǰ����ֻʣ��һ��SCP��");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "��ǰ����ֻʣ��һ��SCP��\n<color=#FF1493>����԰����ָ�ӹٿ�������</color>\n��Ϊ���ݹ���ʦ��", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        RoleSet = 1;
                    }
                }
            }
        }
        public void CD()
        {
            Dio.AddHealth(120);
            Thread.Sleep(12000);
            pos1.Clear();
            sjtz1 = false;
            cd.Abort();
        }
        public void OnShoot(ref ShootEvent ev)
        {
            if (ev.Shooter.GetPlayerId() == scp3108playerid)
            {
                
                if (ev.Shooter.inventory.GetItemInHand().id == ItemType.GunCOM15)
                {
                    ev.Shooter.RemoveItem(ev.Shooter.inventory.GetItemInHand());
                    scp3108shotyes = true;
                }
            }
            if (scp1577id.Contains(ev.Shooter.GetPlayerId()))
            {
                if (ev.Shooter.GetTeam() == Team.MTF)
                {
                    if (ev.Shooter.inventory.GetItemInHand().id == ItemType.GunCOM15)
                    {
                        scp1577pos = ev.Shooter.GetPosition();
                        scp1577bj = true;
                        scp1577id = new List<int>();
                        Map.Broadcast("<color=lime>�����ٻ��˲�������" + scp1577pos.x + "|" + scp1577pos.y + "|" + scp1577pos.z + "��~����.pos�ɻ�ȡ�������</color>", 5, false);
                        ev.Shooter.Broadcast(5, "<color=lime>ȥ����׸���qwq</color>", false);
                    }
                }
                else
                {
                    if (ev.Shooter.inventory.GetItemInHand().id == ItemType.GunCOM15)
                    {
                        scp1577pos = ev.Shooter.GetPosition();
                        scp1577bj = true;
                        scp1577id = new List<int>();
                        Map.Broadcast("<color=lime>�����ٻ��˲�������" + scp1577pos.x + "|" + scp1577pos.y + "|" + scp1577pos.z + "��~����.pos�ɻ�ȡ�������</color>", 5, false);
                        ev.Shooter.Broadcast(5, "<color=lime>���Ѿ������˲���</color>", false);
                    }
                }

            }
        }
        public void OnPickupItem(ref PickupItemEvent ev)
        {
            if (ylb2.Contains(ev.Player.GetUserId()))
            {
                if (ev.Item.ItemId == ItemType.Flashlight)
                {
                    ev.Allow = false;
                    ev.Item.Delete();

                    ev.Player.AddItem(ItemType.Medkit);

                }
                if (ev.Item.ItemId == ItemType.Radio)
                {

                    ev.Allow = false;

                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Medkit);
                }

            }
            if (bpb2.Contains(ev.Player.GetPlayerId()))
            {
                if (ev.Item.ItemId == ItemType.Flashlight)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);

                }
                if (ev.Item.ItemId == ItemType.Radio)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);
                }
            }
            if ((a127d == true) && (ev.Item.ItemId == ItemType.GunUSP))
            {
                if (scp3108pick == false)
                {
                    scp3108playerid = ev.Player.GetPlayerId();
                    scp3108pick = true;
                    Map.Broadcast("<color=red>SCP-3108�ѱ����𱻴��е��˻�ǿ��ת�����</color>", 5, false);
                    ev.Player.Broadcast(5, "<color=lime>�������</color>\n[<color=red>SCP-3108</color>]\n<color=lime>ʹ�ñ���ǹ�����˻�������ɫ�仯 ��ֻ�ܿ�һǹ</color>", false);
                }
            }
            if (ev.Player.GetPlayerId() == scp914mid)
            {
                int cardup = new System.Random().Next(1, 4);
                if (cardup == 2)
                {
                    if (ev.Item.ItemId == ItemType.KeycardScientist)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardJanitor)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientist);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardNTFLieutenant)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardScientistMajor)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardNTFCommander)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardZoneManager)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                    }

                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                    }
                    if (ev.Item.ItemId == ItemType.GunCOM15)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.GunCOM15)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunE11SR);
                    }
                    if (ev.Item.ItemId == ItemType.GunE11SR)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunLogicer);
                    }
                    if (ev.Item.ItemId == ItemType.GunLogicer)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.MicroHID);
                    }
                    if (ev.Item.ItemId == ItemType.GunCOM15)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.Flashlight)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GrenadeFrag);
                    }

                }
                if (cardup == 3)
                {
                    if (ev.Item.ItemId == ItemType.KeycardScientistMajor)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientist);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardScientist)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardJanitor);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardNTFCommander)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardContainmentEngineer)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardZoneManager);

                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunCOM15);

                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunCOM15);
                    }
                    if (ev.Item.ItemId == ItemType.GunE11SR)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.GunLogicer)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunE11SR);
                    }
                    if (ev.Item.ItemId == ItemType.MicroHID)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunLogicer);
                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunCOM15);
                    }
                    if (ev.Item.ItemId == ItemType.GrenadeFrag)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.Flashlight);
                    }
                }
            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                if (ev.Item.ItemId == ItemType.KeycardScientist)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                        ev.Player.Broadcast(5, "[<color=red>����������Ŀ�ѧ�ұ���˴��ѧ�ҿ�</color>]", false);
                    }

                }
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    Log.Info("����" + cardup);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientist);
                        ev.Player.Broadcast(5, "[<color=red>�������������๤����˿�ѧ�ҿ�</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardNTFLieutenant)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.Broadcast(5, "[<color=red>�����������ʿ�ٿ������ָ�ӹٿ�</color>]", false);
                    }
                }

                if (ev.Item.ItemId == ItemType.KeycardScientistMajor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        ev.Player.Broadcast(5, "[<color=red>����������Ĵ��ѧ�ұ�������ݹ���ʦ��</color>]", false);
                    }

                }
                if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                        ev.Player.Broadcast(5, "[<color=red>��������������ݹ���ʦ�������ָ�ӹٿ�</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardNTFCommander)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                        ev.Player.Broadcast(5, "[<color=red>�����������ָ�ӹٿ�����˺ڿ�</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardZoneManager)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        ev.Player.Broadcast(5, "[<color=red>����������������ܼ࿨�������ʩ�ܼ࿨</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFLieutenant);
                        ev.Player.Broadcast(5, "[<color=red>����������ľ�β���±�������˾�β��ʿ�ٿ�</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardJanitor);
                        ev.Player.Broadcast(5, "[<color=red>����������ı������������ʩ��β���±���</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardContainmentEngineer)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                        ev.Player.Broadcast(5, "[<color=red>����������Ļ��翨�������ʩ�ڿ�</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunCOM15)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                        ev.Player.Broadcast(5, "[<color=red>�����������С��ǹ�����P90</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunCOM15)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                        ev.Player.Broadcast(5, "[<color=red>�����������С��ǹ�����P90</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunProject90)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunE11SR);
                        ev.Player.Broadcast(5, "[<color=red>�����������P90����˾�β��ǹ</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunE11SR)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunLogicer);
                        ev.Player.Broadcast(5, "[<color=red>����������ľ�β��ǹ����˴���</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunLogicer)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.MicroHID);
                        ev.Player.Broadcast(5, "[<color=red>����������Ĵ��ܱ���˵����</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunCOM15)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                        ev.Player.Broadcast(5, "[<color=red>����������ı���ǹ�����P90</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.Flashlight)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GrenadeFrag);
                        ev.Player.Broadcast(5, "[<color=red>��������������ⵯǹ���������</color>]", false);
                    }
                }
            }
            if ((scp1577pick == false) && (ev.Item.ItemId == ItemType.GunCOM15))
            {
                Vector3 scp1577pos2 = Map.GetRandomSpawnPoint(RoleType.Scp173);
                float num2 = scp1577pos2.x + 10;
                float num3 = scp1577pos2.y + 10;
                float num4 = scp1577pos2.z + 10;
                float num5 = scp1577pos2.x - 10;
                float num6 = scp1577pos2.y - 10;
                float num7 = scp1577pos2.z - 10;
                if ((ev.Player.GetPosition().x <= num2) && (ev.Player.GetPosition().x >= num5) && (ev.Player.GetPosition().y <= num3) && (ev.Player.GetPosition().y >= num6) && ((ev.Player.GetPosition().z <= num4) && (ev.Player.GetPosition().z >= num7)))
                {
                    scp1577pick = true;
                    scp1577id.Add(ev.Player.GetPlayerId());
                    ev.Player.Broadcast(5, "<color=lime>������� �ź�ǹ</color>\n[<color=red>SCP-1577</color>]\n<color=lime>ʹ�ñ���ǹ������Ժ��п�Ͷ</color>", false);
                }
            }
            else
            {
                if ((ev.Item.ItemId == ItemType.GunCOM15) && (scp2818pick == false))
                {
                    Map.Broadcast("SCP-2818�Ѿ���" + ev.Player.GetNickname() + "����", 5, false);
                    ev.Player.Broadcast(5, "�������2818 ��ǹ��˲�������˺�1000��", false);
                    scp2818 = ev.Player;
                    scp2818id = ev.Player.GetPlayerId();
                    scp2818pick = true;
                }
            }
            if (ev.Player.GetPlayerId() == scp005aid)
            {
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    scp005aid = 0;

                }
            }
            if (ev.Item.ItemId == ItemType.KeycardJanitor)
            {
                if (scp005 == false)
                {
                    scp005aid = ev.Player.GetPlayerId();
                    ev.Player.Broadcast(5, "<color=lime>�������</color>[<color=red>SCP-005</color>]", false);
                }
            }

            if (ev.Item.ItemId == ItemType.GunUSP)
            {
                a127 = false;

            }
            if (ev.Item.ItemId == ItemType.Coin)
            {
                int num = new System.Random().Next(1, 13);

                if (num == 1)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Coin);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[Ӳ��]", false);
                    Log.Info("Ӳ�ұ�Ϊ��Ӳ��| ���:" + ev.Player.GetNickname());
                }
                if (num == 2)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.MicroHID);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[����ڡ��е�]", false);
                    Log.Info("Ӳ�ұ�Ϊ�˵����| ���:" + ev.Player.GetNickname());
                }
                if (num == 3)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GunE11SR);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[��β��ǹ]", false);
                    Log.Info("Ӳ�ұ�Ϊ�˾�β��ǹ| ���:" + ev.Player.GetNickname());
                }
                if (num == 4)
                {
                    ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[���ݹ���ʦ��]", false);
                    Log.Info("Ӳ�ұ�Ϊ�����ݹ���ʦ��| ���:" + ev.Player.GetNickname());
                }
                if (num == 5)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[����]", false);
                    Log.Info("Ӳ�ұ�Ϊ������| ���:" + ev.Player.GetNickname());
                }
                if (num == 6)
                {
                    ev.Player.AddItem(ItemType.Ammo556);
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[5.56�ӵ�]", false);
                }
                if (num == 7)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GunLogicer);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[����]", false);
                }
                if (num == 8)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.KeycardGuard);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[������]", false);
                }
                if (num == 9)
                {
                    ev.Player.AddItem(ItemType.Radio);
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[�Խ����е�]", false);
                }
                if (num == 10)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.KeycardScientist);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[��ѧ�ҿ�]", false);
                }
                if (num == 11)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.SCP500);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[��ѧ�ҿ�]", false);
                }
                if (num == 12)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Flashlight);
                    ev.Player.Broadcast(5, "<color=#FF1493>���Ӳ�ұ����</color>\n[�ֵ�Ͳ]", false);
                    Log.Info("Ӳ�ұ�Ϊ���ֵ�Ͳ| ���:" + ev.Player.GetNickname());
                }
            }

            if (ev.Player.GetPlayerId() == scp457id)
            {
                ev.Item.Delete();
            }
            if ((a127c == false) && (ev.Item.ItemId == ItemType.GunUSP))
            {
                a127c = true;

                a127 = true;
                ev.Player.Broadcast(5, "<color=lime>�������</color>[<color=red>SCP-127</color>]\n<color=lime>�����ӵ�����������SCP-127������ʧ</color>", false);
                Map.Broadcast("SCP127�����Ѿ�����", 10, false);
            }
            Vector3 pos2 = ev.Player.GetPosition();
            if ((pos2.y > -735) && (pos2.y < -730))
            {

                if (jkl == false)
                {
                    jkl = true;
                    jklid = ev.Player.GetUserId();
                    ev.Player.Broadcast(5, "�������SCP-�����ʹ�ú�ָ�1000��Ѫ", false);
                    Map.Broadcast("SCP-�������������", 5, false);

                }
            }


            if (Dio2.Contains(ev.Player.GetUserId()))
            {
                ev.Item.Delete();
            }

        }
        public void OnPlayerHurt(ref PlayerHurtEvent ev)
        {
            if (ev.DamageType == DamageTypes.Tesla)
            {
                if (ev.Attacker.GetPlayerId() == ev.Player.GetPlayerId())
                {
                    if (ev.Player.GetTeam() == Team.SCP)
                    {
                        if (scp79==true)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else
                    {
                        if (h == true)
                        {
                            ev.Amount = 0;
                        }
                    }
                }

            }
            
            if (scp_999.Contains(ev.Attacker.GetUserId()) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 0;
                if(ev.Player.GetHealth()<=8000)
                {
                    ev.Player.AddHealth(2);
                    if ((ev.Player.GetTeam() == Team.SCP) && (ev.Player.GetRole() != RoleType.Scp096))
                    {
                        ev.Player.AddHealth(3);

                    }

                }

            }
            else if (ev.DamageType == DamageTypes.Tesla)
            {
                if ((scp_999.Contains(ev.Attacker.GetUserId())) && (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId()))
                {
                    ev.Amount = 0;
                    ev.Player.AddHealth(10);
                }
            }
            if (scp_999.Contains(ev.Player.GetUserId()) && (ev.Attacker.GetTeam() == Team.SCP))
            {
                ev.Amount = 50;
            }
            LCZ = ev.Player.GetPosition();
            int num = 0;
            int num2 = 0;
            if (ev.Attacker.GetPlayerId() == scp650id)
            {
                gjtr++;
                ev.Attacker.Broadcast(4, "<color=red>ֹͣ��ι���ˢѪ���������ᱻ���������</color>", false);
                if (gjtr == 50)
                {
                    ev.Attacker.BanPlayer(0, "�㴥��650ˢѪ����");

                }
            }
            if (ev.Attacker.GetPlayerId() == scp3108playerid)
            {
                if ((ev.DamageType == DamageTypes.Usp) && (ev.Player.GetPlayerId() != scp650id) && (ev.Player.GetPlayerId() != scp457id))
                {
                    scp3108playerid = 0;
                    scp3108shotatplayerpos = ev.Player.GetPosition();
                    int Rolenum = new System.Random().Next(1, 17);
                    if (Rolenum == 1)
                    {
                        ev.Player.SetRole(RoleType.Scientist);
                    }
                    if (Rolenum == 2)
                    {
                        ev.Player.SetRole(RoleType.ChaosInsurgency);
                    }
                    if (Rolenum == 3)
                    {
                        ev.Player.SetRole(RoleType.FacilityGuard);
                    }
                    if (Rolenum == 4)
                    {
                        ev.Player.SetRole(RoleType.NtfCadet);
                    }
                    if (Rolenum == 5)
                    {
                        ev.Player.SetRole(RoleType.NtfCommander);
                    }
                    if (Rolenum == 6)
                    {
                        ev.Player.SetRole(RoleType.NtfLieutenant);
                    }
                    if (Rolenum == 7)
                    {
                        ev.Player.SetRole(RoleType.NtfScientist);
                    }
                    if (Rolenum == 8)
                    {
                        ev.Player.SetRole(RoleType.Scp0492);
                    }
                    if (Rolenum == 9)
                    {
                        ev.Player.SetRole(RoleType.Scp079);
                    }
                    if (Rolenum == 10)
                    {
                        ev.Player.SetRole(RoleType.Scp106);
                    }
                    if (Rolenum == 11)
                    {
                        ev.Player.SetRole(RoleType.Scp173);
                    }
                    if (Rolenum == 12)
                    {
                        ev.Player.SetRole(RoleType.Scp93953);
                    }
                    if (Rolenum == 13)
                    {
                        ev.Player.SetRole(RoleType.Scp93989);
                    }
                    if (Rolenum == 14)
                    {
                        ev.Player.SetRole(RoleType.Tutorial);
                    }
                    ev.Player.Broadcast(5, "<color=red>�㱻SCP-3108����Ѿ�ת�����</color>", false);

                    ev.Player.SetPosition(scp3108shotatplayerpos);
                }
            }
            if ((ev.Attacker.GetPlayerId() == scp650id) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 0;

            }
            if ((ev.Attacker.GetRole() == RoleType.Scp173) && (Dio2.Contains(ev.Player.GetUserId())) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 100;
            }
            if ((ev.Attacker.GetTeam() == Team.SCP) && (ev.Player.GetPlayerId() == scp457id))
            {
                ev.Amount = 0;
            }
            if ((ev.Attacker.GetPlayerId() == scp457id) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker.GetRole() == RoleType.Tutorial) && (ev.Player.GetPlayerId() != scp457id))
            {
                ev.Amount = 0;
            }
            if ((ev.Attacker.GetPlayerId() == scp939id) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker.GetRole() == RoleType.Scp93953) && (ev.Player.GetPlayerId() != scp035id) && (LLBS233.Contains(ev.Player.GetPlayerId()) == false))
            {
                ev.Amount = 100f;
            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                if (jntm == true)
                {
                    int num3 = new System.Random().Next(1, 100);
                    if (num3 >= 50)
                    {
                        ev.Amount = 0;
                    }
                }
            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                if ((ev.Player.GetPlayerId() != scp650id) && (ev.Attacker.GetTeam() == Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 10;
                    ev.Attacker.AddHealth(-30);
                }
            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                if ((ev.Attacker.GetTeam() != Team.MTF) && (ev.Attacker.GetRole() != RoleType.Scientist) && (ev.Attacker.GetTeam() != Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {

                    ev.Amount = 3;
                    ev.Attacker.AddHealth(-5);

                }
            }
            if ((scp682.Contains(ev.Attacker.GetUserId())) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker.GetRole() == RoleType.Scp93989) && (ev.Player.GetPlayerId() != scp035id) && (LLBS233.Contains(ev.Player.GetPlayerId()) == false))
            {
                ev.Amount = 300f;
                ev.Attacker.AddHealth(100);
            }
            if ((ev.Attacker.GetPlayerId() == scpqblid2) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 0;
            }
            if ((ev.Player.GetUserId() == scpqblid) && (ev.Amount >= scpqbl.GetHealth()))
            {
                ev.Amount = 0;
                scpqbl.SetRole(RoleType.Scp93989);
                scpqblid2 = scpqbl.GetPlayerId();
                scpqbl3 = ev.Player;
                scpqbl = null;
                scpqblid = null;
                ev.Player.SetRank("SCP-�Ǳ���", "yellow",  true);
                Map.Broadcast("������ֵ����qwq", 7, false);
            }
            if ((ev.Player.GetPlayerId() == scp181id) && (ev.Attacker.GetTeam() == Team.SCP))
            {
                System.Random random = new System.Random();
                if (random.Next(1, 3) == 2)
                {
                    ev.Attacker.AddHealth(ev.Amount);
                    ev.Amount = 0;
                }
            }
            if (scp2006a.Contains(ev.Player.GetUserId()) && (ev.Attacker.GetPlayerId() != scp650id))
            {
                if (ev.Attacker.GetTeam() > Team.SCP)
                {
                    ev.Amount = 10;
                }
            }
            if ((ev.Player.GetPlayerId() == D9341id))
            {
                if ((ev.Amount >= ev.Player.GetHealth()) && (times <= 5))
                {
                    ev.Amount = 0;
                    D9341.SetRole(D9341js);
                    Coroutines.Add(Timing.RunCoroutine(SecondCounter23()));
                    times++;
                }

            }
            if ((ev.Attacker.GetPlayerId() == scp035id) && (ev.Player.GetTeam() > Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 20;
            }
            if ((ev.Player.GetPlayerId() == scp035id) && (ev.Attacker.GetTeam() == Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 50;
            }
            if ((ev.Player.GetPlayerId() == scp035id) && (ev.Attacker.GetTeam() > Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 50;
            }
            if ((scp2818pick == true))
            {
                if ((scp2818id == ev.Attacker.GetPlayerId()) && (ev.DamageType == DamageTypes.Com15))
                {
                    if (ev.Player.GetRole() == RoleType.Scp106)
                    {
                        ev.Amount = 300;
                        scp2818.Kill();
                        scp2818.SetRole(RoleType.Spectator);
                        scp2818pick = false;
                        scp2818id = 0;
                        scp2818 = null;
                    }
                    else
                    {
                        ev.Amount = 1000;
                        scp2818.Kill();
                        scp2818.SetRole(RoleType.Spectator);
                        scp2818pick = false;
                        scp2818 = null;
                        scp2818id = 0;
                    }
                }
            }
            if (ev.Attacker.GetRole() == RoleType.Scp049)
            {
                if ((lv == 3) && (ev.Player.GetPlayerId() != scp076id) && (LLBS233.Contains(ev.Player.GetPlayerId()) == false) && (ev.Player.GetPlayerId() != scp457id))
                {
                    ev.Amount = 0;
                    ev.Player.SetRole(RoleType.Scp0492 ,true);
                }
            }
            if ((ev.Player.GetPlayerId() != scp650id) && (ev.Player.GetPlayerId() == scp076id))
            {
                if ((ev.Attacker.GetRole() == RoleType.Scp173) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 20;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp049) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 20;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp0492) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 10;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp096) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 20;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp93953) || (ev.Attacker.GetRole() == RoleType.Scp93989))
                {
                    ev.Amount = 15;
                }
                if ((ev.Attacker.GetTeam() != Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 6;
                }
            }
            if (yshkq == false)
            {
                if (roundstart == true)
                {
                    if ((ev.Attacker.GetRole() == RoleType.Scientist) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        if (ev.Player.GetRole() == RoleType.Scientist)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.MTF)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }
                    if ((ev.Attacker.GetTeam() == Team.CHI) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != scp035id))
                    {
                        if (ev.Player.GetRole() == RoleType.ClassD)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.CHI)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }
                    if ((ev.Attacker.GetRole() == RoleType.ClassD) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != scp035id))
                    {
                        if (ev.Player.GetRole() == RoleType.ClassD)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.CHI)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }
                    if ((ev.Attacker.GetTeam() == Team.MTF) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        if (ev.Player.GetRole() == RoleType.Scientist)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.MTF)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }

                }
            }
            if(jwhngyes == true)
            {
                if (jwhngwufashanghai == false)
                {
                    if (ev.Attacker.GetTeam() == Team.MTF)
                    {
                        if (ev.Player.GetPlayerId() == jwhhkid)
                        {
                            ev.Amount = 20;
                        }
                    }
                    if (ev.Attacker.GetPlayerId() == jwhngid)
                    {
                        if (ev.Attacker.GetTeam() == Team.MTF)
                        {
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Player.Broadcast(1, "�޷�������������αװģʽ", false);
                                ev.Amount = 0;
                            }
                        }
                    }
                    if (ev.Attacker.GetRole() == RoleType.ChaosInsurgency)
                    {
                        if (ev.Player.GetPlayerId() == jwhngid)
                        {
                            ev.Amount = 0;
                            ev.Player.ClearBroadcasts();
                            ev.Player.Broadcast(1, "ͣ�����Ѿ�", false);
                        }
                    }
                }
            }
            if ((Dio2.Contains(ev.Player.GetUserId())) && (sjtz1 == true) && (ev.DamageType != DamageTypes.Nuke))
            {
                ev.Amount = 0;
            }
            if (ev.Attacker.GetPlayerId() == scp076id)
            {
                if (ev.Player.GetTeam() == Team.SCP)
                {
                    ev.Amount = ev.Amount + 10;
                }
            }
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetRole() == RoleType.ChaosInsurgency)
                {
                    num++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    num2++;
                }
            }
            foreach (int num4 in touxiang)
            {
                if ((num4 == ev.Player.GetPlayerId()) && ((ev.Attacker.GetTeam() == Team.MTF) || (ev.Attacker.GetRole() == RoleType.Scientist)) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num == 0))
                {
                    ev.Attacker.Broadcast(2, "����Ҵ���Ͷ��״̬����ֻ�ܶ������1�˺�\n<color=#00FF7F>������Ҳ�ܵ���3�˺�</color>", false);
                    ev.Amount = 1f;
                    Log.Info(string.Concat(new object[] { "���: ", ev.Attacker.GetNickname(), " ���ڹ���: ", ev.Player.GetNickname(), " ��ǰ���ϻ���: ", num2 }));
                }
                if ((num4 == ev.Player.GetPlayerId()) && ((ev.Attacker.GetTeam() == Team.MTF) || (ev.Attacker.GetRole() == RoleType.Scientist)) && (num > 0))
                {
                    Log.Info("��������:" + num);
                    Log.Info("MTF����:" + num2);
                    ev.Player.Broadcast(2, "���ڳ��ϴ��ڻ���\n<color=#00FF7F>��ı�����ʧЧ</color>", false);
                    Log.Info(string.Concat(new object[] { "���: ", ev.Player.GetNickname(), "�ܵ�����,���ޱ��� | ��ǰ���ϻ������:", num }));
                }
                if ((num4 == ev.Player.GetPlayerId()) && (ev.Attacker.GetRole() == RoleType.ChaosInsurgency) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall)&& (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num2 == 0) && (ev.Player.GetRole() == RoleType.Scientist))
                {
                    Log.Info("��������:" + num);
                    Log.Info("MTF����:" + num2);
                    ev.Attacker.Broadcast(2, "����Ҵ���Ͷ��״̬����ֻ�ܶ������1�˺�\n<color=#00FF7F>������Ҳ�ܵ���3�˺�</color>", false);

                    Log.Info(string.Concat(new object[] { "���: ", ev.Attacker.GetNickname(), " ���ڹ���: ", ev.Player.GetNickname(), " ��ǰ����MTF: ", num2 }));
                }
                if ((num4 == ev.Player.GetPlayerId()) && (ev.Attacker.GetRole() == RoleType.ChaosInsurgency) && (num2 > 0))
                {
                    Log.Info("��������:" + num);
                    Log.Info("MTF����:" + num2);
                    ev.Player.Broadcast(2, "���ڳ��ϴ���MTF��Ӫ\n<color=#00FF7F>��ı�����ʧЧ</color>", false);
                    Log.Info(string.Concat(new object[] { "���: ", ev.Player.GetNickname(), "�ܵ�����,���ޱ��� | ��ǰ���Ͼ�β����:", num2 }));
                }
                if ((num4 == ev.Attacker.GetPlayerId()) && ((ev.Player.GetTeam() == Team.MTF) || (ev.Player.GetRole() == RoleType.Scientist)) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Player != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num == 0))
                {
                    ev.Attacker.Broadcast(2, "�㴦��Ͷ��״̬�����޷��˺�MTF��Ӫ", false);
                    ev.Amount = 0f;
                }
                if ((num4 == ev.Attacker.GetPlayerId()) && (ev.Player.GetTeam() == Team.CHI) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Player != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num2 == 0))
                {
                    ev.Attacker.Broadcast(2, "�㴦��Ͷ��״̬�����޷��˺�������Ӫ", false);
                    ev.Amount = 0f;
                }
            }
            if (((ev.Player.GetRole() == RoleType.ClassD) || (ev.Player.GetRole() == RoleType.Scientist)) && (ev.DamageType == DamageTypes.Scp049))
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (touxiang[i] == ev.Player.GetPlayerId())
                    {
                        touxiang[i] = 0;
                    }
                }
            }
            if (ev.Player.GetRole() == RoleType.Scp173)
            {
                if ((((ev.DamageType == DamageTypes.Logicer) || (ev.DamageType == DamageTypes.E11StandardRifle)) || ((ev.DamageType == DamageTypes.P90) || (ev.DamageType == DamageTypes.Mp7))) || (ev.DamageType == DamageTypes.Com15))
                {
                    ev.Amount = 3f;
                }
                if (ev.DamageType == DamageTypes.Usp)
                {
                    ev.Amount += 50f;
                }
            }
            if ((ev.Player.GetRole() == RoleType.Scp106) && (((((ev.DamageType == DamageTypes.Usp) || (ev.DamageType == DamageTypes.Logicer)) || ((ev.DamageType == DamageTypes.E11StandardRifle) || (ev.DamageType == DamageTypes.P90))) || (ev.DamageType == DamageTypes.Mp7)) || (ev.DamageType == DamageTypes.Com15) && (scp2818.GetPlayerId() != ev.Attacker.GetPlayerId())))
            {
                ev.Amount = 1f;
            }

            if ((LLBS233.Contains(ev.Player.GetPlayerId())) && (ev.Attacker.GetTeam() == Team.SCP) && (ev.Player.GetPlayerId() != scp650id))
            {
                ev.Amount = 20f;
            }
            if ((a127 == true) && (ev.DamageType == DamageTypes.Usp))
            {
                ev.Amount = 100;
                a127b++;
                if (a127b == 10)
                {
                    a127 = false;
                    a127c = true;
                    a127d = true;
                    Map.Broadcast("SCP127�����Ѿ���ʧ", 10, false);
                }

            }
            if ((ev.Attacker.GetPlayerId() == scp650id) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 0;
            }

            num = 0;
            num2 = 0;
        }
        public void OnPocketDimEscaped(PocketDimEscapedEvent ev)
        {
            int num = new System.Random().Next(1, 4);
            if (num == 1)
            {
                ev.Player.AddItem(ItemType.Radio);
                ev.Player.Broadcast(10, "<color=#FF1493>���ڿڴ����ѹε���</color>\n�Խ���", false);
            }
            else if (num == 2)
            {
                ev.Player.AddItem(ItemType.Medkit);
                ev.Player.Broadcast(10, "<color=#FF1493>���ڿڴ����ѹε���</color>\nҽ�ư�", false);
            }
            else if (num == 3)
            {
                ev.Player.AddItem(ItemType.Flashlight);
                ev.Player.Broadcast(10, "<color=#FF1493>���ڿڴ����ѹε���</color>\n���ⵯ", false);
            }
        }
        public void OnScp079LvlGain(Scp079LvlGainEvent ev)
        {
            if (h == true)
            {
                ev.Player.scp079PlayerScript.NetworkmaxMana = 130;
                ev.Player.Broadcast(10, "<color=#FFC0CB>[��Ϣ]</color>\n��������,�������\n" + "��ĵ��������Ƶ���130��QAQ", false);
            }
        }
        public void OnSetClass(SetClassEvent ev)
        {
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                this.scp079id = ev.Player.GetPlayerId();
                if (choise == false)
                {
                    ev.Player.SendMessage("==========SCP079============");
                    ev.Player.SendMessage(".scp         ѡ�񱾾ְ���SCP");
                    ev.Player.SendMessage(".h           ѡ�񱾾ְ�������");
                    ev.Player.SetRank("SCP079 - ������:130 | �����ָ�:3AP/s   δѡ���������", "aqua", true);
                    ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:����  </color><color=aqua>����Ժķѵ������ź����� \n ���������ּ�1��ߵ�~��ѡ�񱾾�������Ӫ�������������ʾ�����Ϸ�</color>", false);
                }
                if (choise == true)
                {
                    if (scp79 == true)
                    {
                        ev.Player.SetRank("SCP079 -  ����SCP", "aqua", true);
                        ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:����  </color><color=aqua>����Ժķѵ������ź����� \n ����079ѡ�����SCP</color>", false);
                    }
                    if (h == true)
                    {
                        ev.Player.SetRank("SCP079 - ������:130 | �����ָ�:3AP/s   ��������", "aqua",  true);
                        ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:����  </color><color=aqua>����Ժķѵ������ź����� \n ����079ѡ���������</color>", false);
                    }

                }
            }
            if (ev.Player.GetRole() == RoleType.Scp173)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP173]---</color>\n<color=#00FFFF>HP:4200  </color>��ӵ��һ����������\n�ܵ������������<color=#FFD700>ǹе�˺�ֻ��3��</color>", false);
                SCP173 = "SCP173";
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 4200)));
                s173 = 1;
            }
            if (ev.Player.GetRole() == RoleType.Scp049)
            {
                ev.Player.SetRank("��ǰ�ȼ�:" + lv + "����ֵ:" + xp, "pink", true);
                SCP049 = "SCP049";
                s173 = 1;
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player,3000)));

                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP049]---</color>\n<color=#FFC0CB>��һ��3���ิ��С��ʬ��qwq</color>", false);
            }
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                SCP079 = "SCP079";
            }
            if (ev.Player.GetRole() == RoleType.Scp096)
            {
                ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP096]---</color>\n<color=#00FFFF>HP:5000  </color>��ӵ��һ����������\n<color=#FFD700>��E 3%���� ��������</color>", false);
                SCP096 = "SCP096";
                s096 = 1;
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 1500)));
            }
            if (ev.Player.GetRole() == RoleType.Scp93989)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP939_89]---</color>\n<color=#00FFFF>HP:6000  </color>��ӵ��һ����������\n�ܵ�<color=#FFD700>����ʱ</color>������,����Ա���", false);
                SCP939_89 = "SCP939_89";
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));

                s939_89 = 1;
            }
            if (ev.Player.GetRole() == RoleType.Scp93953)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP939_53]---</color>\n<color=#00FFFF>HP:6000  </color>��ӵ��һ����������\n�ܵ�<color=#FFD700>����ʱ</color>������,����Ա���", false);
                SCP939_53 = "SCP939_53";
                s939_53 = 1;
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));

            }
            if (ev.Player.GetRole() == RoleType.Scp106)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP106]---</color>\n<color=#00FFFF>HP:650  </color>��ӵ��һ����������\n�ܵ�<color=#FFD700>ǹе�˺�ֻ��1��</color>", false);
                SCP106 = "SCP106";
                s106 = 1;
            }
            if (ev.Player.GetRole() == RoleType.Scp0492)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP049_2]---</color>\n<color=#00FFFF>HP:1400</color>", false);
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 1400)));

                xp = xp + 50;
                if (xp == 100)
                {
                    lv = 1;
                }
                if (xp == 400)
                {
                    lv = 2;
                }
                if (xp == 800)
                {
                    lv = 3;
                }
                foreach (ReferenceHub player in Player.GetHubs())
                {
                    if (player.GetRole() == RoleType.Scp049)
                    {
                        player.AddHealth(100);
                        player.SetRank("��ǰ�ȼ�:" + lv + " ����ֵ:" + xp, "pink", true);
                    }
                }
            }
            if (ev.Role == RoleType.NtfCommander)
            {
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
            }
            if (ev.Role == RoleType.NtfLieutenant)
            {
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 450);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
            }
            if (ev.Role == RoleType.Scientist)
            {
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 450);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 450);
            }
            if (ev.Role == RoleType.NtfCadet)
            {
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 40);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 0xa5);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 450);
            }
            if (ev.Role == RoleType.FacilityGuard)
            {
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 450);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
            }
            if (ev.Role == RoleType.ChaosInsurgency)
            {
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 0);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 0);
            }
        }
        public void OnPlayerSpawn(PlayerSpawnEvent ev)
        {

            starttimer = true;
            roundstart = true;

            if(ev.Player.GetPlayerId() != D9341id)
            {
                if (ev.Player.GetRole() == RoleType.ClassD)
                {
                    if (d == 0)
                    {
                        scp181 = ev.Player;
                        scp181id = ev.Player.GetPlayerId();
                        card = new System.Random().Next(1, 11);
                        Log.Info("����5");
                        Log.Info(card.ToString());
                        scp181.SetRank("scp181", "pink", true);
                        scp181.Broadcast(10, "����[<color=red>SCP-181</color>]\n����Ϊ�����һ�ų�ʼ��Ƭ����20%���ʼ������� �������� ��������⿪��2�μ���Ŷ", false);
                        scp181.Broadcast(10, "[<color=red>SCP-181</color>]\n�㻹���Ժϳ�ǹ ��Ҳ���Ժϳ����ⵯ", false);

                    }
                    if (d == 1)
                    {
                        cxk = ev.Player;
                        cxkid = cxk.GetPlayerId();
                        cxkyes = true;
                        cxkflash = true;
                        cxk.SetRank("������", "red", true);
                        cxk.Broadcast(10, "����[<color=red>SCP-������</color>]\n<color=lime>�����ֵ�Ͳʹ�ü��ܼ���̫��</color>", false);
                    }
                    if (d == 2)
                    {
                        scp817 = ev.Player;
                        scp817yes = true;
                        scp817id = scp817.GetPlayerId();
                        scp817.SetRank("SCP817", "red", true);
                        scp817.Broadcast(10, "����[<color=red>SCP-817</color>]\n<color=lime>150��任һ�����</color>", false);
                    }
                    if (d == 3)
                    {
                        D9341 = ev.Player;
                        D9341js = RoleType.Spectator;
                        D9341id = D9341.GetPlayerId();
                        d9341flash = true;

                        D9341.SetRank("D-9341", "red", true);
                        D9341.Broadcast(6, "����[<color=red>D-9341</color>]<color=lime>���д浵���� �������ⵯ</color><color=red>(�򿪱����Ҽ���������ӳ�ȥ)</color><color=lime>�浵</color>\n<color=lime>�������ֵ��ص�һ��5�λ���</color>", false);
                    }
                    if (d == 4)
                    {
                        scp2006 = ev.Player;
                        scp2006id = scp2006.GetPlayerId();
                        scp2006.Broadcast(10, "����[<color=red>SCP-2006</color>]\n<color=lime>����һ��Ӳ�Ҿͻᱻ������͵�һ���ط�</color>", false);
                        scp2006coin = true;

                        scp2006a.Add(scp2006.GetUserId());
                    }
                    if (d == 5)
                    {
                        scp035 = ev.Player;
                        scp035.Broadcast(10, "����[<color=red>SCP035</color>]\n<color=lime>HP:300</color><color=red>ɱ��һ���˺� ����ʬ�帽����������</color><color=red>ÿ5��۳�5HP �����HP�ָ�Ϊ500</color>", false);
                        scp035health = true;
                        scp035id = scp035.GetPlayerId();
                        scp035item2 = true;
                        scp035.AddItem(ItemType.GunUSP);
                    }
                    if (d == 6)
                    {
                        xtd = ev.Player;
                        xtdid = xtd.GetPlayerId();
                        xtd.Broadcast(10, "����[<color=red>С͵</color>]\n<color=lime>����.steal͵ȡ��Ʒ300sһ��</color>", false);
                        xtd.SetRank("С͵", "lime", true);
                    }
                    d++;
                }
            }
            if (ev.Player.GetRole() == RoleType.Scientist)
            {
                if (s == 0)
                {
                    scpqbl = ev.Player;
                    scpqblid = scpqbl.GetUserId();
                }
                if (s == 1)
                {
                    int yes = new System.Random().Next(1, 100);
                    if (yes >= 60)
                    {
                        scp914m = ev.Player;
                        scp914m.SetRank("SCP914-M", "pink", true);
                        scp914mid = scp914m.GetPlayerId();
                        scp914m.Broadcast(10, "����[<color=red>SCP914-M</color>]\n�����914�Ļ���", false);
                    }
                }
                if (s == 2)
                {
                    scp076 = ev.Player;
                    scp076.SetRole(RoleType.NtfCommander);
                    scp076iteam = true;
                    scp076id = scp076.GetPlayerId();
                    scp076.SetRank("SCP-076", "red", true);
                    scp076yes = true;
                    scp076.Broadcast(10, "[<color=red>SCP-076</color>]\n<color=lime>����ǿ���SCP�����Լ��ӵ����ԣ���û�п���ȴ�������Ϊ�㿪��</color>", false);
                    foreach (Inventory.SyncItemInfo item in scp076.GetAllItems())
                    {
                        scp076.RemoveItem(item);
                    }
                }
                if (s == 3)
                {
                    scp650yes = true;
                    scp650 = ev.Player;
                    scp650.SetRole(RoleType.Scp173);
                    scp650.SetHealth(1);
                    scp650id = scp650.GetPlayerId();
                    scp650.SetGodMode(true);
                    scp650.SetRank("SCP-650", "red", true);
                    scp076.Broadcast(10, "[<color=red>SCP-650</color>]\n<color=lime>�����޵еĵ�����û���˺� ������ξ�������qwq</color>", false);
                }
                if(s == 4)
                {
                    hpsz = ev.Player;
                    hpszid = hpsz.GetPlayerId();
                }
                s++;
            }

            int playerId = ev.Player.GetPlayerId();
            if ((ev.Player.GetRole() == RoleType.Scp93989) && (new System.Random().Next(0, 100) <= 20))
            {
                ev.Player.SetRank("SCP-682", "red", true);
                ev.Player.Broadcast(10, "<color=#FF0000>����SCP682��ү��ס������Ŷqwq</color>", false);
                scp682.Add(ev.Player.GetUserId());
                Log.Info(ev.Player.GetNickname() + "��ΪSCP682");
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));


            }
            if (ev.Player.GetRole() == RoleType.Scp93953)
            {
                ev.Player.SetRank("SCP-939-3", "red", true);
                ev.Player.Broadcast(10, "<color=#FF0000>����SCP-939-3�㹥���˺�Ϊ100��Ŷqwq</color>", false);
                Log.Info(ev.Player.GetNickname() + "939-3");
                scp939id = ev.Player.GetPlayerId();
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));

            }
            if (ev.Player.GetRole() == RoleType.ChaosInsurgency)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>[���������]</color>\n<color=#00FFFF>��������Ǿȳ�D��ɱ���β����SCP����</color>\n���SCP��ɵ��˺�<color=#FFD700>+5</color>", false);
                if(times2 == 3)
                {
                    if(mzyes == false)
                    {
                        mz = ev.Player;
                        mzid = mz.GetPlayerId();
                        mzzb = false;
                        mzyes = true;
                    }
                    times2 = 4;
                }
                if (times2 == 2)
                {
                    Map.Broadcast("SCP1143ͻ������", 6, false);
                    scp1143 = ev.Player;
                    scp1143.SetRank("SCP-1143", "red",  true);
                    scp1143.Broadcast(6, "����SCP1143 30���ˢһ���׻����ⵯ", false);
                    scp1143a = true;
                    scp1143id = scp1143.GetPlayerId();
                    times2 = 3;
                }
                if ((times2 == 1))
                {
                    HDZHG = ev.Player;
                    hhzhgzb = false;
                    times2 = 2;
                }

            }
            if ((ev.Player.GetRole() == RoleType.NtfCadet) && (jw.Contains(ev.Player.GetPlayerId())))
            {
                if ((times == 8) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    if (scp550shuachu == false)
                    {
                        scp550 = ev.Player;
                        scp550id = scp550.GetPlayerId();
                        scp550item = true;
                        scp550yes = true;
                        scp550shuachu = true;
                        scp550lv = 0;
                        scp550.SetRole(RoleType.Tutorial);
                        tssl = 0;
                    }
                    times = 9;

                }
                if ((times == 7) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    if(jwhngshuachu == false)
                    {
                        jwhng = ev.Player;
                        jwhngid = jwhng.GetPlayerId();
                        jwhngwufashanghai = true;
                        jwhngyes = true;
                        jwhngitem = false;
                    }
                    times = 8;

                }
                if ((times == 6) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    jwhhk = ev.Player;
                    jwhhkid = jwhhk.GetPlayerId();

                    jw.Remove(ev.Player.GetPlayerId());
                    jwhhk.SetRank("��β���ڿ�", "red", true);
                    jwhhk.Broadcast(5, "<color=lime>���Ǿ�β���ڿ�</color>:����.hk���Ժ���ʵ����", false);
                    times = 7;
                }
                if ((tiems == 5) && (jljy1 == false) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    times = 6;
                    jljy1 = true;
                    jljy = ev.Player;
                    jw.Remove(ev.Player.GetPlayerId());
                    jljy.Broadcast(5, "���Ǽ�����Ӱ���Ե�����װ�������ɷ�", false);
                    jljy.SetRole(RoleType.FacilityGuard);
                    jljyzb = true;
                }
                if ((tiems == 4) && (bpb == false) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    times = 5;
                    bpb = true;
                    jw.Remove(ev.Player.GetPlayerId());
                    bpb2.Add(ev.Player.GetPlayerId());
                    ev.Player.SetRank("��β�����Ʊ�", "red", true);
                    ev.Player.Broadcast(5, "<color=red>���Ǿ�β�����Ʊ�</color>:����Խ��������ⵯ���Ա������", false);
                }
                if ((tiems == 3) && (scp073a == false) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    tiems = 4;
                    scp073 = ev.Player;
                    scp073a = true;
                    scp073id = scp073.GetPlayerId();
                    jw.Remove(ev.Player.GetPlayerId());
                    ev.Player.SetRank("SCP-073", "red", true);
                    ev.Player.Broadcast(5, "<color=#FF0000>���Ǿ�β��SCP-073</color>\n<color=lime>���SCP������ ֻ��10���˺� �ҷ���50 ǹе�����˺�Ϊ1�ҷ���5</color>", false);
                    scp073zb = false;
                }
                if ((tiems == 2) && (ylb1 == false) && (ev.Player.GetRole() == RoleType.NtfCadet) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    ylb1 = true;
                    ev.Player.SetRank("��βҽ�Ʊ�", "yellow",  true);
                    ev.Player.Broadcast(5, "<color=#FF0000>���Ǿ�β��ҽ�Ʊ�</color>:������Χ���˻��Ѫ������Խ��������ⵯ���Ա��Ѫ��", false);
                    ylb = ev.Player;
                    ylb2.Add(ylb.GetUserId());
                    tiems = 3;
                    jw.Remove(ev.Player.GetPlayerId());
                }
                if ((ev.Player.GetRole() == RoleType.NtfCadet) && (tiems == 1) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    jw.Remove(ev.Player.GetPlayerId());
                    mrfish = ev.Player;
                    mrfish.SetRank("Mr.Fish", "yellow", true);
                    Map.Broadcast("<color=#FF0000>Mr.Fish:</color>����̫���˿��Ұ�SCP��������", 10, false);
                    LLBS233.Add(mrfish.GetPlayerId());
                    tiems = 2;
                    mrfishzb = false;
                }
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
            }
            if (ev.Player.GetRole() == RoleType.NtfCommander)
            {
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
                ev.Player.Broadcast(10, "<color=#FFC0CB>[��β��ָ�ӹ�]</color>\n<color=#00FFFF>����Ը����о�β����Ӫ������Ϣ,��ȴ80��</color>\n��ϸ<color=#FFD700>��~���������̨����.help�鿴����</color>", false);
            }
            if (ev.Player.GetRole() == RoleType.FacilityGuard)
            {
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
                ev.Player.Broadcast(10, "<color=#FFC0CB>[��ʩ����]</color>\n<color=#00FFFF>�������������ȳ�D����ѧ��ɱ��SCP�����</color>\n�����ǰ��<color=#FFD700>���ѵ�</color>�������", false);
            }
            if (ev.Player.GetRole() == RoleType.NtfLieutenant)
            {
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
            }

        }
        public void OnPlayerLeave(PlayerLeaveEvent ev)
        {

            if(ev.Player.GetPlayerId()==jwhhkid)
            {
                jwhng = null;
                jwhngyes = false;
                jwhngid = 0;
                jwhngwufashanghai = false;
                jwhngitem = true;
            }
            if(ev.Player.GetPlayerId() == scp035id)
            {
                scp035 = null;
                scp035id = 0;
                scp035goout = false;
                scp035yes = false;
            }
            if(ev.Player.GetPlayerId() == scp550id)
            {
                scp550id = 0;
                scp550yes = false;
                scp550 = null;
                scp550lv = 0;
                tssl = 0;
                Map.Broadcast("----[<color=#32CD32>[SCP550]</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == hpszid)
            {
                hpsz = null;
                hpszid = 0;
            }
            if ((scp650yes == true) && (ev.Player.GetPlayerId() == scp650id))
            {
                scp650 = null;
                scp650id = 0;
                scp650yes = false;
                Map.Broadcast("----[<color=#32CD32>[SCP650]</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {
                jwhhkid = 0;
                jwhhk = null;
            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                scp073 = null;
                scp073id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP073</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp076id)
            {
                scp076 = null;
                scp076id = 0;
                scp076yes = false;
                Map.Broadcast("----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp005aid)
            {
                scp005aid = 0;
            }
            if (ev.Player.GetPlayerId() == scp457id)
            {
                scp457 = null;
                scp457a = false;
                scp457die = true;
                scp457b = new Vector3();
                ev.Player.SetRank("white", "", true);
                scp457id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP457</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == xtdid)
            {
                xtd = null;
                xtdid = 0;
            }
            if ((qblcq2 == true) && (qblcq.GetPlayerId() == ev.Player.GetPlayerId()))
            {
                qblcq2 = false;
                qblcq = null;

            }
            if (scp682.Contains(ev.Player.GetUserId()))
            {
                scp682.Remove(ev.Player.GetUserId());
                Map.Broadcast("----[<color=#32CD32>SCP682</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (scp939id == ev.Player.GetPlayerId())
            {
                scp939id = 0;
            }
            if (ev.Player.GetPlayerId() == scp914mid)
            {
                scp914m = null;
                scp914mid = 0;
                Map.Broadcast("----[<color=#32CD32>SCP914-M</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);
            }
            if (ev.Player.GetPlayerId() == scpqblid2)
            {
                scpqblid2 = 0;
                Map.Broadcast("----[<color=#32CD32>SCP�Ǳ���</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                scp181id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP181</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == scp035id)
            {
                Map.Broadcast("----[<color=#32CD32>SCP035</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);
                scp035 = null;
                scp035id = 0;
                scp035goout = false;
                scp035yes = false;
            }
            if (scp2006a.Contains(ev.Player.GetUserId()))
            {
                scp2006a.Clear();
                scp2006 = null;
                Map.Broadcast("----[<color=#32CD32>SCP2006</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                cxkid = 0;
                cxk = null;
                cxkyes = false;
                Map.Broadcast("----[<color=#32CD32>SCP������</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == scp817id)
            {
                scp817id = 0;
                scp817 = null;
                scp817yes = false;
                Map.Broadcast("----[<color=#32CD32>SCP817</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);
                ev.Player.SetRank("white", "", true);

            }
            if (ev.Player.GetPlayerId() == D9341id)
            {
                if (times >= 5)
                {
                    D9341 = null;
                    D9341id = 0;
                    D9341Item = null;
                    D9341yes = false;
                    D9341zb = new Vector3();
                    ev.Player.SetRank("white", "", true);
                    Map.Broadcast("----[<color=#32CD32>D-9341</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

                }
            }
            if (bpb2.Contains(ev.Player.GetPlayerId()))
            {
                bpb = false;
                bpb2.Clear();
            }
            if (LLBS233.Contains(ev.Player.GetPlayerId()))
            {
                Map.Broadcast("<color=#FFFF33>Mr.fish:</color>\nװ��ʧ��", 5, false);
                LLBS233.Remove(ev.Player.GetPlayerId());
                ev.Player.SetRank("white", "", true);

            }
            if (Dio2.Contains(ev.Player.GetUserId()))
            {
                Map.Broadcast("<color=#FFFF33>Dio:</color>\nװ��ʧ��", 5, false);
                Dio2.Remove(ev.Player.GetUserId());
                Dio = null;

            }
            if (scp1143id == ev.Player.GetPlayerId())
            {
                scp1143 = null;
                scp1143id = 0;
                scp1143a = false;
                Map.Broadcast("----[<color=#32CD32>SCP1143</color>]----\n<color=#FF0000>[���ݳɹ�]</color>\n������: <color=#40E0D0>" + "������" + "</color>", 6, false);

            }
            if (ylb2.Contains(ev.Player.GetUserId()))
            {
                ylb = null;
                ylb1 = false;
                ylb2.Clear();

            }
            if (HDZHG2.Contains(ev.Player.GetUserId()))
            {
                HDZHG2.Remove(ev.Player.GetUserId());
            }
        }
    }
}