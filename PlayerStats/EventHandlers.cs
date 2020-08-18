using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.Commands.Reload;
using Exiled.Events.EventArgs;
using Hints;
using MEC;
using Mirror;
using Newtonsoft.Json;
using Respawning;
using Respawning.NamingRules;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayerStats
{
	public class EventHandlers
	{
		public string url = "http://127.0.0.1:4578/";

		private bool h;

		private bool choise;

		private Exiled.API.Features.Player scp;

		private bool die;

		private bool start;

		private int int222;

		public List<string> scp_999 = new List<string>();

		public int s049;

		private int KillerID;

		private int PlayerID;
		List<Vector3> vector3s = new List<Vector3>();
		public bool roundstart = false;

		public int[] GuardType = new int[200];

		public int Guardnum = 0;

		public int count = 0;

		public DateTime updatatimer = DateTime.Now;

		public int deadtimer = 0;

		public bool starttimer = false;

		public bool deadtime = false;

		public int count2 = 0;

		private int waring1;

		private int playernum = 0;

		public bool waring = false;

		public int[] touxiang = new int[101];

		private int round = 0;

		public int chaos = 0;

		public int mtf = 0;

		public int mtfchange = 0;

		public int chaoschange = 0;

		private int coldtime = 0;

		private int coldtime2 = 2;

		private bool coldbc = false;

		private bool coldtb = false;

		private int xp;

		private int lv;

		private bool coldwait233;

		private bool Dio1;

		private bool sjtz1;

		private bool sjtz2;

		private Thread cd;

		private bool ylb1;

		private int tiems;

		private int scp073id;

		private bool scp076yes;

		private bool scp076iteam;

		private int scp076id;

		private int scp2818id;

		private bool scp2818pick;

		private Exiled.API.Features.Player hdjjs;

		private int hdjjsid;

		private int times2;

		private bool scp1143a;

		private int scp1143id;

		private Exiled.API.Features.Player jwhng;

		private int jwhngid;

		private int times;

		private bool bpb;

		private Exiled.API.Features.Player scp181;

		private int scp181id;

		private Exiled.API.Features.Player cxk;

		public bool cxkyes;
		public List<Pickup> Baba = new List<Pickup>();
		public List<Pickup> Baba1 = new List<Pickup>();
		public List<int> 第一次 = new List<int>();
		public List<int> 第二次 = new List<int>();
		private bool cxkflash;

		public int cxkid;

		public bool jntm;

		public int scp817id;

		private Exiled.API.Features.Player scp817;

		public bool scp817yes;

		public int D9341id;

		private bool d9341flash;

		public bool D9341yes;

		public int times1 = 0;

		public bool jntmlq;

		private Exiled.API.Features.Player scp2006;

		private int scp2006id;

		private bool scp035health;

		public int scp035id;

		private bool scp035item2;

		private int times5 = 1;

		private int scpqblid2;

		private Exiled.API.Features.Player scpqbl;

		private string scpqblid;

		private bool qblcq2;

		private int scp914mid;

		private int scp939id;

		private bool jkl;

		private string jklid;

		private Exiled.API.Features.Player xywj;

		private string xywjid;

		private bool bscp79;

		private int jwhhkid;

		private bool jwhngyes;

		private bool jwhngshuachu;

		private bool hrss;

		private bool csm;

		private int csmtime;

		private bool a127;

		private bool a127c;

		private int a127b;

		private Exiled.API.Features.Player xtd;

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

		private bool a127d;

		private bool scp650yes;

		private Exiled.API.Features.Player scp650;

		private int scp650id;

		private bool scp3108pick;

		private int scp3108playerid;

		private bool scp1577pick;

		private bool bhsx;

		private bool yshkq;

		private int peaple;

		private bool sjqx;

		public List<int> sbxd = new List<int>();

		public List<Exiled.API.Features.Player> player_list;
		public List<Pickup> scp330 = new List<Pickup>();
		public List<int> scp330pickup = new List<int>();
		public List<int> scp330hurt = new List<int>();

		public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();

		public List<CoroutineHandle> Coroutines2 = new List<CoroutineHandle>();

		public List<CoroutineHandle> Coroutines3 = new List<CoroutineHandle>();

		public List<int> 小僵尸id = new List<int>();

		private Exiled.API.Features.Player D9341;

		private RoleType D9341js;

		private List<string> scp2006a = new List<string>();

		private Exiled.API.Features.Player scp035;

		private Exiled.API.Features.Player scp914m;

		private Exiled.API.Features.Player scp076;

		private List<Exiled.API.Features.Player> player233 = new List<Exiled.API.Features.Player>();

		private Exiled.API.Features.Player jwhhk;

		private Vector3 hkzb;

		private Exiled.API.Features.Player scp073;

		private Vector3 D9341zb;

		private Exiled.API.Features.Player scp457;

		private List<string> Dio2 = new List<string>();

		private Exiled.API.Features.Player scpqbl3;

		private Exiled.API.Features.Player qblcq;

		private List<string> HDZHG2 = new List<string>();

		private List<int> LLBS233 = new List<int>();

		private List<Door> door2 = new List<Door>();

		private List<string> scp682 = new List<string>();

		private List<string> ylb2 = new List<string>();

		private List<int> bpb2 = new List<int>();

		private Exiled.API.Features.Player scp2818;

		private Exiled.API.Features.Player Dio;

		private List<Vector3> pos1 = new List<Vector3>();

		private Vector3 scp1577pos;

		private Exiled.API.Features.Player scp1143;

		private Exiled.API.Features.Player HDZHG;

		private Exiled.API.Features.Player mrfish;

		private Exiled.API.Features.Player ylb;

		private Vector3 pos3;

		private Exiled.API.Features.Player scp106a;

		private List<Exiled.API.Features.Player> scpd79 = new List<Exiled.API.Features.Player>();

		private Dictionary<int, Vector3> Posstop = new Dictionary<int, Vector3>();

		private int scp1577id = 0;

		private Vector3 scp3108shotatplayerpos;

		private int d = 0;

		private int s;

		private int card;

		private bool scp999yes;

		private int ragdolltime;

		private int itemtime;

		private List<Exiled.API.Features.Player> ljfwj = new List<Exiled.API.Features.Player>();

		private bool scp035goout;

		private bool xitonghedan;

		private bool jwhngwufashanghai;

		private bool bscd;

		private Exiled.API.Features.Player hpsz;

		private int hpszid;

		private Exiled.API.Features.Player scp550;

		private int scp550id;

		private bool scp550yes;

		private bool scp550shuachu;

		private bool scp035yes;

		private bool mzyes;

		private Exiled.API.Features.Player mz;

		private int mzid;

		private Inventory.SyncListItemInfo item;

		private float health;

		private bool meitunshi;

		private int tssj;

		private int scp550lv;

		private int tssl;

		private bool scp79;

		private bool fkyyshuachu;

		private bool fkyyzyes;

		private Exiled.API.Features.Player fkyyz;

		private int fkyyzid;

		private bool ljfuse;

		private int fkyyzcardint;

		private bool bindljf;

		private bool jzsjuse;

		private bool bindjzsj;

		private bool tysuse;

		private bool bindtys;

		private bool zybuse;

		private Exiled.API.Features.Player 误杀玩家;

		private int Gears博士id;

		public Exiled.API.Features.Player Gears博士;

		private bool lxyes;

		private Exiled.API.Features.Player scp49j;

		private int scp49jid;

		private bool scp49jyes;

		private int tuolikadianid;

		private int scp457sh;

		private int timesjw;

		private int timestop;

		private string 事件;

		private string 时间;

		private string 地点;

		private string 人物;

		private string 句子;

		private string 缺少;

		private Exiled.API.Features.Player rhdzzwj;

		private bool rhdyes;

		private int tlid;

		private int g;

		private bool kccd;

		private string sendtxt;

		private object sendtxt6;

		private object sendtxt5;

		private object sendtxt4;

		private object sendtxt3;

		private string sendtxt2;

		private Inventory.SyncListItemInfo D9341Item;

		private bool dq;

		private bool lbvyes;

		private int lbvid;

		private Exiled.API.Features.Player lbv;

		private int timesbxd;

		private bool dfzgc;
		private bool chenghaoyes;
		private bool scp650noxiaren;
		private bool pmdon;
		private Task pmd;
		private Socket socket;
		private int qingjiegongnum;
		private int hdflzid;
		private bool scp106donotliked;
		private bool hdsx;
		private bool shoulei;
		private bool gdyes;

		private IEnumerator<float> ShouLei(Vector3 vector3)
		{
			while(shoulei)
			{
				yield return Timing.WaitForSeconds(0.3f);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GrenadeFrag, 9999f, vector3, Quaternion.identity, 0, 0, 0);
			}
		}
		private IEnumerator<float> testHint(string txtweizhi, Exiled.API.Features.Player player)
		{
			StreamReader sr = new StreamReader("D:\\\\test\\\\" + txtweizhi + ".txt");
			yield return Timing.WaitForSeconds(6f);
			string temp = sr.ReadToEnd();
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			yield return Timing.WaitForSeconds(1f);
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			yield return Timing.WaitForSeconds(1f);
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			yield return Timing.WaitForSeconds(1f);
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			yield return Timing.WaitForSeconds(1f);
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			yield return Timing.WaitForSeconds(1f);
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			yield return Timing.WaitForSeconds(1f);
			player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
			{
				new StringHintParameter("")
			}));
			if (txtweizhi == "scp650")
			{
				scp650.Health = 1f;
			}

		}
		public void OnRestartingRound()
		{
			Socket tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			tcp.Connect("127.0.0.1", 12344);
			tcp.Send(Encoding.UTF8.GetBytes("需要重启服务器了"));
		}
		public void OnRemoteAdminCommand(SendingRemoteAdminCommandEventArgs ev)
		{
			foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
			{
				if (ev.Arguments.Count == 1)
				{
					referenceHub.SendConsoleMessage(ev.Sender.Nickname + "使用" + ev.Name + " " + ev.Arguments[0], "green");
					string temp2 = ev.Sender.Nickname + "使用" + ev.Name + " " + ev.Arguments[0];
					referenceHub.ReferenceHub.hints.Show(new TextHint(temp2, new HintParameter[1]
					{
						new StringHintParameter("")
					}));
				}
				if (ev.Arguments.Count == 2)
				{
					referenceHub.SendConsoleMessage(ev.Sender.Nickname + "使用" + ev.Name + " " + ev.Arguments[0] + " " + ev.Arguments[1], "green");
					string temp = ev.Sender.Nickname + "使用" + ev.Name + " " + ev.Arguments[0] + " " + ev.Arguments[1];
					referenceHub.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
					{
						new StringHintParameter("")
					}));
				}
			}
			if(ev.Name == "csgo")
			{
				End();

				Exiled.Events.Handlers.Server.WaitingForPlayers -= OnWaitingForPlayers;
				Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStart;
				Exiled.Events.Handlers.Server.RoundEnded -= OnRoundEnd;
				Exiled.Events.Handlers.Player.Joined -= OnPlayerJoin;
				Exiled.Events.Handlers.Player.Died -= OnPlayerDeath;
				Exiled.Events.Handlers.Player.MedicalItemUsed -= OnMedicalItem;
				Exiled.Events.Handlers.Server.RespawningTeam -= OnTeamRespawn;
				Exiled.Events.Handlers.Server.SendingConsoleCommand -= OnConsoleCommand;
				Exiled.Events.Handlers.Player.FailingEscapePocketDimension -= OnPocketDimDeath;
				Exiled.Events.Handlers.Player.Escaping -= OnCheckEscape;
				Exiled.Events.Handlers.Player.InteractingDoor -= OnDoorInteract;
				Exiled.Events.Handlers.Scp106.Containing -= OnScp106Contain;
				Exiled.Events.Handlers.Server.EndingRound -= OnCheckRoundEnd;
				Exiled.Events.Handlers.Player.DroppingItem -= OnDropItem;
				Exiled.Events.Handlers.Player.Shooting -= OnShoot;
				Exiled.Events.Handlers.Player.PickingUpItem -= OnPickupItem;
				Exiled.Events.Handlers.Player.Hurting -= OnPlayerHurt;
				Exiled.Events.Handlers.Player.EscapingPocketDimension -= OnPocketDimEscaped;
				Exiled.Events.Handlers.Player.ChangingRole -= OnSetClass;
				Exiled.Events.Handlers.Player.Spawning -= OnPlayerSpawn;
				Exiled.Events.Handlers.Scp079.GainingLevel -= OnScp079LvlGain;
				Exiled.Events.Handlers.Player.UnlockingGenerator -= OnGeneratorUnlock;
				Exiled.Events.Handlers.Player.Left -= OnPlayerLeave;
				Exiled.Events.Handlers.Warhead.Stopping -= ONWarheadCancelled;
				Exiled.Events.Handlers.Scp914.ChangingKnobSetting -= On914KnobChange;
				Exiled.Events.Handlers.Scp096.Enraging -= OnScp096Enrage;
				Exiled.Events.Handlers.Warhead.Detonated -= OnWarheadDetonation;
				Exiled.Events.Handlers.Server.SendingRemoteAdminCommand -= OnRemoteAdminCommand;
				Exiled.Events.Handlers.Map.Decontaminating -= OnDecontaminate;
				Exiled.Events.Handlers.Player.Dying -= OnDying;
				Exiled.Events.Handlers.Server.RestartingRound += OnRestartingRound;
				Exiled.Events.Handlers.Warhead.Starting -= ONWarheadStarter;
				Exiled.Events.Handlers.Player.TriggeringTesla -= OnTriggeringTesla;
			}
			if(ev.Name == "hd")
			{
				shoulei = true;
				Timing.RunCoroutine(ShouLei(ev.Sender.Position));
			}
			if(ev.Name == "hd2")
			{
				if (shoulei)
				{
					shoulei = false;
				}
				else
				{
					shoulei = true;
				}
			}
			if (ev.Name == "test")
			{
				Timing.RunCoroutine(Badapple("cxktxt"));
			}
			if (ev.Name == "test4")
			{
				D9341Item = ev.Sender.Inventory.items;
			}
			if (ev.Name == "test5")
			{
				foreach (Inventory.SyncItemInfo syncItemInfo in D9341Item)
				{
					ev.Sender.AddItem(syncItemInfo);
				}
			}
			if (ev.Name == "test6")
			{
				Coroutines.Add(Timing.RunCoroutine(testHint("测试", ev.Sender)));
			}
			if (ev.Name == "clean")
			{
				Ragdoll[] array = UnityEngine.Object.FindObjectsOfType<Ragdoll>();
				foreach (Ragdoll ragdoll in array)
				{
					NetworkServer.Destroy(ragdoll.gameObject);
					ragdolltime++;
				}
				Pickup[] array2 = UnityEngine.Object.FindObjectsOfType<Pickup>();
				foreach (Pickup item in array2)
				{
					if (item.ItemId == ItemType.Ammo556 || item.ItemId == ItemType.Ammo762 || item.ItemId == ItemType.Flashlight || item.ItemId == ItemType.Ammo9mm || item.ItemId == ItemType.GunE11SR || item.ItemId == ItemType.MicroHID || item.ItemId == ItemType.WeaponManagerTablet || item.ItemId == ItemType.Medkit || item.ItemId == ItemType.KeycardGuard || item.ItemId == ItemType.KeycardSeniorGuard || item.ItemId == ItemType.GrenadeFlash || item.ItemId == ItemType.GrenadeFrag || item.ItemId == ItemType.Disarmer || item.ItemId == ItemType.GunLogicer || item.ItemId == ItemType.GunProject90 || item.ItemId == ItemType.Radio)
					{
						item.Delete();
						itemtime++;
					}
				}
			}
			if (ev.Name == "cleanall")
			{
				Ragdoll[] array = UnityEngine.Object.FindObjectsOfType<Ragdoll>();
				foreach (Ragdoll ragdoll in array)
				{
					NetworkServer.Destroy(ragdoll.gameObject);
				}
				Pickup[] array2 = UnityEngine.Object.FindObjectsOfType<Pickup>();
				foreach (Pickup item in array2)
				{
					item.Delete();
				}
			}

		}

		public void SetPlayerScale(GameObject target, float x, float y, float z)
		{
			try
			{
				NetworkIdentity identity = target.GetComponent<NetworkIdentity>();
				target.transform.localScale = new Vector3(1f * x, 1f * y, 1f * z);
				ObjectDestroyMessage destroyMessage = default(ObjectDestroyMessage);
				destroyMessage.netId = identity.netId;
				foreach (GameObject player in PlayerManager.players)
				{
					if (!(player == target))
					{
						NetworkConnection playerCon = player.GetComponent<NetworkIdentity>().connectionToClient;
						playerCon.Send(destroyMessage);
						object[] parameters = new object[2]
						{
							identity,
							playerCon
						};
						typeof(NetworkServer).InvokeStaticMethod("SendSpawnMessage", parameters);
					}
				}
			}
			catch (Exception e)
			{
				Log.Info($"大小设置失败: {e}");
			}
		}
		public void ONWarheadStarter(StartingEventArgs ev)
		{
			if (hdsx == true)
			{
				ev.IsAllowed = false;
				ev.Player.Broadcast(10, "核弹生锈了暂时无法打开");
			}
		}
		public void ONWarheadCancelled(StoppingEventArgs ev)
		{
			if (xitonghedan)
			{
				ev.Player.Broadcast(2, "<color=red>[警告]</color>\n<color=lime>系统核弹无法关闭</color>");
				ev.IsAllowed = false;
			}
			if (ev.IsAllowed)
			{
				timestop++;
				Exiled.API.Features.Map.Broadcast(5, "<color=red>[警告]</color>\n<color=lime>核弹当前被关闭" + timestop + "超过20次将无法关闭</color>");
			}
			if (timestop > 20)
			{
				ev.Player.Broadcast(2, "<color=red>[警告]</color>\n<color=lime>核弹生气了 无法关闭</color>");
				ev.IsAllowed = false;
			}
		}

		public void OnWarheadDetonation()
		{
			Exiled.API.Features.Map.Broadcast(10, "<color=red>[警告]</color>\n<color=lime>地表核弹即将开启 开启后将会消灭全部 SCP和人类</color>");
			Coroutines.Add(Timing.RunCoroutine(Dbhd()));
			Coroutines.Add(Timing.RunCoroutine(Whereareyou()));
			Exiled.Events.Handlers.Warhead.Detonated -= OnWarheadDetonation;
			Exiled.Events.Handlers.Warhead.Stopping -= ONWarheadCancelled;

		}
		public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
		{
			if (h)
			{
				if (ev.Player.Team != Team.SCP)
				{
					ev.IsTriggerable = false;
				}
			}
			if (scp79)
			{
				if (ev.Player.Team == Team.SCP)
				{
					ev.IsTriggerable = false;
				}
			}
		}
		private IEnumerator<float> Whereareyou()
		{
			while (true)
			{
				yield return Timing.WaitForSeconds(40f);
				foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
				{
					if (!(player.Position.y >= 950f) || !(player.Position.y <= 1030f))
					{
						player.Broadcast(5, "你为什么在这里回去玩游戏=w=");
						player.Kill(DamageTypes.Nuke);
						player.SetRole(RoleType.Spectator);
					}
				}
			}
		}

		private IEnumerator<float> Whereareyou2()
		{
			while (true)
			{
				yield return Timing.WaitForSeconds(40f);
				foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
				{
					if (player.Position.y >= -9f && player.Position.y <= 20f)
					{
						player.Broadcast(5, "你为什么在这里回去玩游戏=w=");
						player.Kill(DamageTypes.Nuke);
						player.SetRole(RoleType.Spectator);
					}
				}
			}
		}

		private IEnumerator<float> Dbhd()
		{
			yield return Timing.WaitForSeconds(480f);
			foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
			{
				referenceHub.SetRole(RoleType.Spectator);
			}
		}
		private IEnumerator<float> Sethpnew(Exiled.API.Features.Player player, float shuliang)
		{
			yield return Timing.WaitForSeconds(10f);
			player.Health = shuliang;

		}
		private IEnumerator<float> Tp(Exiled.API.Features.Player player, Vector3 vector3)
		{
			yield return Timing.WaitForSeconds(0.5f);
			player.ReferenceHub.playerMovementSync.OverridePosition(vector3, 0, false);
		}

		public void OnWaitingForPlayers()
		{
			pmdon = true;
			Coroutines.Add(Timing.RunCoroutine(PMD()));
			foreach (Room room in Map.Rooms)
			{
				Log.Info(room.Name);
			}
			if (Player.Get(100) == null)
			{
				Log.Info("是的是这样的");
			}

			Coroutines.Add(Timing.RunCoroutine(SecondCounter()));
			Coroutines.Add(Timing.RunCoroutine(SecondCounter2()));
		}
		public IEnumerator<float> PMD()
		{

			Log.Info("PMD线程初始化");
			int pmdjsq = 0;
			int pmdawa = 0;
			int xunhuan14 = 0;
			int xunhuan16 = 0;
			int guangboshi = 0;
			int guangboshitxt = 0;
			int chenghao = 0;
			int lajiqingli = 0;
			int xunhuan5 = 0;
			int xunhuanawa = 0;
			while (pmdon)
			{
				xunhuan5++;
				xunhuan14++;
				xunhuan16++;
				chenghao++;
				lajiqingli++;
				xunhuanawa++;
				try
				{
					if (!roundstart)
					{
						pmdjsq++;
						if (pmdjsq == 5)
						{
							switch (pmdawa)
							{
								case 0:
									for (int i = 0; i < player233.Count; i++)
									{
										if (!roundstart && player233[i].UserId != "76561198284755079@steam" && player233[i].UserId != "76561198389200613@steam")
										{
											Setrank_new("称号预留位置", "red", player233[i]);
										}
									}
									break;
								case 1:
									for (int j = 0; j < player233.Count; j++)
									{
										if (!roundstart && player233[j].UserId != "76561198284755079@steam" && player233[j].UserId != "76561198389200613@steam")
										{
											Setrank_new("欢迎加入这个破服务器:1021889243 | 请看标题", "red", player233[j]);
										}
									}
									break;
								case 2:
									for (int k = 0; k < player233.Count; k++)
									{
										if (!roundstart && player233[k].UserId != "76561198284755079@steam" && player233[k].UserId != "76561198389200613@steam")
										{
											Setrank_new("欢迎加入这个破服务器:1021889243 | 请看标题", "yellow", player233[k]);
										}
									}
									break;
								case 3:
									for (int l = 0; l < player233.Count; l++)
									{
										if (!roundstart && player233[l].UserId != "76561198284755079@steam" && player233[l].UserId != "76561198389200613@steam")
										{
											Setrank_new("欢迎加入这个破服务器:1021889243 | 请看标题", "green", player233[l]);
										}
									}
									break;
								case 4:
									for (int m = 0; m < player233.Count; m++)
									{
										if (!roundstart && player233[m].UserId != "76561198284755079@steam" && player233[m].UserId != "76561198389200613@steam")
										{
											Setrank_new("欢迎加入这个破服务器:1021889243 | 请看标题", "pink", player233[m]);
										}
									}
									break;
								default:
									pmdawa = 0;
									break;
							}
							pmdawa++;
							pmdjsq = 0;
						}
					}
				}
				catch (Exception ex)
				{
					Log.Info(ex.Message);
					Log.Info(ex.GetBaseException());
					Log.Info("错误，称号");
				}

				if (xunhuanawa >= 20)
				{
					try
					{
						bscd = false;
						if (Player.Get(scp2818id) != null)
						{
							Player.Get(scp2818id).Broadcast(2, "您现在持有SCP2818");
						}
						
						foreach (Exiled.API.Features.Player referenceHub1 in Exiled.API.Features.Player.List)
						{
							if (referenceHub1.Health < 0f)
							{
								referenceHub1.SetRole(RoleType.Spectator);
							}
						}
						if (scp035yes)
						{
							if(Player.Get(scp035id) != null)
							{
								Player.Get(scp035id).Health -= 20f;
								if (scp035.Health < 0f)
								{
									Player.Get(scp035id).SetRole(RoleType.Spectator);
									scp035id = 0;
									scp035goout = false;
									scp035yes = false;
									scp035 = null;
								}
							}
						}
						if (scp457a)
						{
							if(Player.Get(scp457id) != null)
							{
								scp457sh = 0;
								foreach (Inventory.SyncItemInfo syncItemInfo in scp457.Inventory.items)
								{
									if (syncItemInfo.id.IsSCP())
									{
										scp457sh++;
									}
								}
								if (Player.Get(scp457id) != null)
								{
									Player.Get(scp457id).Broadcast(5, "<color=red>[SCP457]</color>\n<color=lime>灼烧等级:</color>" + scp457sh);
								}
							}
						}
					}
					catch (Exception ex)
					{
						Log.Info(ex.Message);
						Log.Info(ex.GetBaseException());
						Log.Info("错误，循环awa");
					}
				}
				if (xunhuan14 >= 10)
				{
					try
					{
						xunhuan14 = 0;
						if (ylb1)
						{
							foreach (Exiled.API.Features.Player player6 in Exiled.API.Features.Player.List)
							{
								if (player6.Team == Team.MTF && Vector3.Distance(ylb.Position, player6.Position) <= 6)
								{
									player6.Health += 1f;
									player6.Broadcast(5, "<color=yellow>[九尾狐医疗兵]</color>\n<color=#00FFFF>我正在治疗你的伤势</color>");
								}
							}
						}
						switch (lv)
						{
							case 1:
								foreach (Exiled.API.Features.Player player3 in Player.Get(RoleType.Scp049))
								{
									player3.Health += 5f;
								}
								break;
							case 2:
								foreach (Exiled.API.Features.Player player4 in Player.Get(RoleType.Scp049))
								{
									player4.Health += 10f;
								}
								break;
							case 3:
								foreach (Exiled.API.Features.Player player5 in Player.Get(RoleType.Scp049))
								{
									player5.Health += 15f;
								}
								break;
						}
						if (scp49jyes)
						{
							foreach (Exiled.API.Features.Player referenceHub in Player.Get(RoleType.FacilityGuard))
							{
								if (!scp_999.Contains(referenceHub.UserId))
								{
									scp49j = referenceHub;
									scp49jid = referenceHub.Id;
									break;
								}
							}
						}
					}
					catch (Exception ex)
					{
						Log.Info(ex.Message);
						Log.Info(ex.GetBaseException());
						Log.Info("错误，循环14");
					}
				}
				if (xunhuan16 >= 100)
				{
					try
					{
						xunhuan16 = 0;
						foreach (Exiled.API.Features.Player hub in Exiled.API.Features.Player.List)
						{
							if (hub.Role != 0)
							{
								hub.IsGodModeEnabled = false;
							}
						}
					}
					catch (Exception ex)
					{
						Log.Info(ex.Message);
						Log.Info(ex.GetBaseException());
						Log.Info("错误，循环16");
					}
				}
				if (guangboshi >= 10)
				{
					try
					{
						switch (guangboshitxt)
						{
							case 0:
								Intercom.host.CustomContent = "你好呀 欢迎来到广播室(*^▽^*)";
								break;
							case 1:
								Intercom.host.CustomContent = "现在时间是" + DateTime.Now.ToString();
								break;
							case 2:
								Intercom.host.CustomContent = "插件版本是" + DateTime.Today.ToString() + "'ω'";
								break;
							case 3:
								Intercom.host.CustomContent = "(*^▽^*)请河蟹游戏 友善对待他人";
								break;
							case 4:
								Intercom.host.CustomContent = "服主QQ:1312255201(\uffe3▽\uffe3)~*交个朋友";
								break;
							case 5:
								Intercom.host.CustomContent = "\uffe3へ\uffe3进来还不加群打屎你";
								break;
							case 6:
								Intercom.host.CustomContent = "<*))>>=< 最好可以给我money没错就是这条鱼";
								break;
							case 7:
								Intercom.host.CustomContent = "⊂(ο･㉨･ο)⊃ 阿巴阿巴";
								break;
							case 8:
								Intercom.host.CustomContent = "(≧▽≦)/下面是重复的了";
								break;
							default:
								guangboshitxt = 0;
								break;
						}
						guangboshitxt++;
					}
					catch (Exception ex)
					{
						Log.Info(ex.Message);
						Log.Info(ex.GetBaseException());
						Log.Info("错误，广播室");
					}
				}
				if (chenghao >= 300)
				{
					try
					{
						chenghao = 0;
						foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
						{
							try
							{
								Dictionary<string, string> param = new Dictionary<string, string>();
								param.Add("userid", referenceHub.UserId);
								string a = Get(url + "GetBadge", param);
								List<badge> model = new List<badge>();
								model = JsonConvert.DeserializeObject<List<badge>>(a);
								if (model.Count >= 1)
								{
									State.RunCoroutine(nodify_badeg(referenceHub, model[0]));
								}
							}
							catch
							{
							}
						}
					}
					catch (Exception ex)
					{
						Log.Info(ex.Message);
						Log.Info(ex.GetBaseException());
						Log.Info("错误，称号2");
					}
				}
				if (starttimer)
				{
					try
					{
						switch (lajiqingli)
						{
							case 1:
								Exiled.API.Features.Map.Broadcast(10, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>400s</color>后清理服务器");
								break;
							case 200:
								Exiled.API.Features.Map.Broadcast(10, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>200s</color>后清理服务器");
								break;
							case 350:
								Exiled.API.Features.Map.Broadcast(10, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>50s</color>后清理服务器");
								break;
							case 390:
								Exiled.API.Features.Map.Broadcast(5, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>10s</color>后清理服务器");
								Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>5s</color>后清理服务器");
								Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>4s</color>后清理服务器");
								Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>3s</color>后清理服务器");
								Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>2s</color>后清理服务器");
								Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>1s</color>后清理服务器");
								Exiled.API.Features.Map.Broadcast(4, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>开始清理</color>");
								break;
							default:
								break;
						}
						if (lajiqingli >= 400)
						{
							lajiqingli = 0;
							Ragdoll[] array = UnityEngine.Object.FindObjectsOfType<Ragdoll>();
							foreach (Ragdoll ragdoll in array)
							{
								NetworkServer.Destroy(ragdoll.gameObject);
								ragdolltime++;
							}
							Pickup[] array2 = UnityEngine.Object.FindObjectsOfType<Pickup>();
							foreach (Pickup item in array2)
							{
								if (item.ItemId == ItemType.Ammo556 || item.ItemId == ItemType.Ammo762 || item.ItemId == ItemType.Ammo9mm || item.ItemId == ItemType.GunE11SR || item.ItemId == ItemType.MicroHID || item.ItemId == ItemType.WeaponManagerTablet || item.ItemId == ItemType.Medkit || item.ItemId == ItemType.KeycardGuard || item.ItemId == ItemType.KeycardSeniorGuard || item.ItemId == ItemType.GrenadeFlash || item.ItemId == ItemType.GrenadeFrag || item.ItemId == ItemType.Disarmer || item.ItemId == ItemType.GunLogicer || item.ItemId == ItemType.GunProject90 || item.ItemId == ItemType.Radio)
								{
									item.Delete();
									itemtime++;
								}
							}
							Exiled.API.Features.Map.Broadcast(4, "<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>好饱呀</color>\n本次清理了" + itemtime + "个物品" + ragdolltime + "个尸体");
							itemtime = 0;
							ragdolltime = 0;
						}
					}
					catch (Exception ex)
					{
						Log.Info(ex.Message);
						Log.Info(ex.GetBaseException());
						Log.Info("错误，称号2");
					}
				}
				if (xunhuan5 >= 200)
				{

				}
				yield return Timing.WaitForSeconds(1f);

			}
			Log.Info("PMD线程结束运行");
		}
		private IEnumerator<float> HdjjsCD()
		{
			yield return Timing.WaitForSeconds(0.1f);
			hdjjs.RemoveItem(hdjjs.CurrentItem);
			hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n5");
			yield return Timing.WaitForSeconds(1f);
			hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n4");
			yield return Timing.WaitForSeconds(1f);
			hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n3");
			yield return Timing.WaitForSeconds(1f);
			hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n2");
			yield return Timing.WaitForSeconds(1f);
			hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n1");
			yield return Timing.WaitForSeconds(1f);
			hdjjs.AddItem(ItemType.GunE11SR);
		}

		private IEnumerator<float> Xywjsx()
		{
			yield return Timing.WaitForSeconds(90f);
			xywj = null;
			xywjid = null;
			

		}
		private IEnumerator<float> Gd()
		{
			gdyes = true;
			yield return Timing.WaitForSeconds(100f);
			gdyes = false;

		}
		private IEnumerator<float> Gd2()
		{
			while(gdyes)
			{
				yield return Timing.WaitForSeconds(8f);
				Map.TurnOffAllLights(8, false);
			}
		}
		private IEnumerator<float> Slowly()
		{
			foreach(Player player in Player.List)
			{
				player.ReferenceHub.playerEffectsController.EnableEffect<CustomPlayerEffects.SinkHole>(20, false);
			}
			yield return Timing.WaitForSeconds(20f);
			foreach (Player player in Player.List)
			{
				player.ReferenceHub.playerEffectsController.DisableEffect<CustomPlayerEffects.SinkHole>();
			}

		}
		
		private IEnumerator<float> Hdsx()
		{
			yield return Timing.WaitForSeconds(180f);
			hdsx = false;
		}
		private IEnumerator<float> GuanZhanYouXi()
		{
			while (true)
			{
				yield return Timing.WaitForSeconds(15f);
				foreach (Exiled.API.Features.Player referenceHub in Player.Get(RoleType.Spectator))
				{
					句子 = 时间 + 地点 + 人物 + 事件;
					if ((时间 + "").Length == 0)
					{
						缺少 = "时间 输入.jl 内容补充内容";
					}
					else if ((地点 + "").Length == 0)
					{
						缺少 = "地点 输入.jl 内容补充内容";
					}
					else if ((人物 + "").Length == 0)
					{
						缺少 = "人物 输入.jl 内容补充内容";
					}
					else if ((事件 + "").Length == 0)
					{
						缺少 = "事件 输入.jl 内容补充内容";
					}
					else
					{
						缺少 = "输入.jlck开启下一回合";
					}
					referenceHub.Broadcast(5, "当前句子" + 句子 + "\n当前缺少" + 缺少);
				}
			}
		}

		private IEnumerator<float> Remove492(int playerid)
		{
			yield return Timing.WaitForSeconds(10f);
			小僵尸id.Remove(playerid);
		}

		private IEnumerator<float> Badapple(string weizhi)
		{
			int time333 = 1;
			do
			{
				StreamReader sr = new StreamReader("D:\\\\badapple\\\\" + weizhi + "\\" + time333 + ".txt");
				yield return Timing.WaitForSeconds(0.03f);
				Intercom.host.CustomContent = sr.ReadToEnd();
				time333++;
			}
			while (time333 < 6571);
		}

		private IEnumerator<float> SetNineFox()
		{
			yield return Timing.WaitForSeconds(1f);
			timesjw++;
			SyncUnit a = Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Last();
			switch (timesjw)
			{
				case 2:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>蔡徐坤</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>");
					a.UnitName = "蔡徐坤";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break;
				case 3:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>九尾大军</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>");
					a.UnitName = "九尾大军";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break; 
				case 4:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>最差的一届九尾</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>");
					a.UnitName = "最差的一届九尾";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break;
				case 5:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>炮灰</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>");
					a.UnitName = "炮灰";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break;
				case 6:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>顺丰快递</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>");
					a.UnitName = "顺丰快递";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break;
				case 7:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>圆通快递</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>");
					a.UnitName = "圆通快递";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break;
				case 8:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>宅急送</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>");
					a.UnitName = "宅急送";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a;
					break;
				case 9:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>SCP106迫害小分队</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>");
					a.UnitName = "SCP106迫害小分队";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a; break;
				case 10:
					Exiled.API.Features.Map.Broadcast(7, "<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>德国boy</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>");
					a.UnitName = "德国boy";
					Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames[Respawning.RespawnManager.Singleton.NamingManager.AllUnitNames.Count - 1] = a; break;
			}
		}

		private IEnumerator<float> Hdjjs()
		{
			yield return Timing.WaitForSeconds(1f);
			hdjjs.ClearInventory();
			yield return Timing.WaitForSeconds(2f);
			hdjjs.AddItem(ItemType.Adrenaline);
			hdjjs.AddItem(ItemType.Adrenaline);
			hdjjs.AddItem(ItemType.Medkit);
			hdjjs.AddItem(ItemType.GunE11SR);
			hdjjs.AddItem(ItemType.Flashlight);
			hdjjs.AddItem(ItemType.GunUSP);
			hdjjs.Broadcast(5, "你是<color=yellow>混沌狙击手</color>\n你有高额伤害但是 有五秒攻击延时");
			Coroutines.Add(Timing.RunCoroutine(testHint("hdjjs", hdjjs)));
		}

		private IEnumerator<float> RenWuFenPei()
		{
			yield return Timing.WaitForSeconds(5f);
			foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
			{
				if (referenceHub.Role == RoleType.Scientist)
				{
					switch (s)
					{
						case 0:
							scpqbl = referenceHub;
							scpqblid = scpqbl.UserId;
							break;
						case 1:
							{
								int yes = new System.Random().Next(1, 100);
								if (yes >= 60)
								{
									scp914m = referenceHub;
									Setrank_new("SCP914-M", "pink", scp914m);
									scp914mid = scp914m.Id;
									scp914m.Broadcast(10, "你是[<color=red>SCP914-M</color>]\n你就是914的化身");
									Coroutines.Add(Timing.RunCoroutine(testHint("scp914m", scp914m)));
								}
								break;
							}
						case 2:
							scp076 = referenceHub;
							scp076iteam = true;
							scp076id = scp076.Id;
							Setrank_new("SCP-076", "red", scp076);
							scp076yes = true;
							scp076.Broadcast(10, "[<color=red>SCP-076</color>]\n<color=lime>你有强大的SCP抗性以及子弹抗性，你没有卡请等待其他人为你开门</color>");
							Coroutines.Add(Timing.RunCoroutine(testHint("scp076", scp076)));
							Coroutines.Add(Timing.RunCoroutine(SecondCounter10()));
							scp076.ClearInventory();
							break;
						case 3:
							scp650yes = true;
							scp650 = referenceHub;
							scp650.SetRole(RoleType.Scp173);
							scp650id = scp650.Id;
							scp650.IsGodModeEnabled = true;
							Setrank_new("SCP-650", "red", scp650);
							scp076.Broadcast(10, "[<color=red>SCP-650</color>]\n<color=lime>你是无敌的但是你没有伤害 你的责任就是吓人qwq</color>");
							Coroutines.Add(Timing.RunCoroutine(testHint("scp650", scp650)));
							break;
						case 4:
							hpsz = referenceHub;
							hpszid = hpsz.Id;
							break;
						case 5:
							Gears博士 = referenceHub;
							Gears博士.Broadcast(10, "<color=yellow>欢迎您Gears博士\n特殊技能：无法被173秒杀</color>");
							Gears博士id = Gears博士.Id;
							Setrank_new("Gears博士", "yellow", Gears博士);
							break;
					}
					s++;
				}
				if (referenceHub.Role == RoleType.FacilityGuard)
				{
					if (g == 0 && scp999yes)
					{
						scp = referenceHub;
						die = false;
						ScpSpawn();
						scp999yes = false;
					}
					if (g == 1)
					{
					}
					g++;
				}
				if (referenceHub.Id != D9341id && referenceHub.Id != cxkid && referenceHub.Id != scp181id && referenceHub.Id != scp817id && referenceHub.Id != D9341id && referenceHub.Id != scp2006id && referenceHub.Role == RoleType.ClassD)
				{
					switch (d)
					{
						case 0:
							scp181 = referenceHub;
							scp181id = referenceHub.Id;
							card = new System.Random().Next(1, 11);
							Log.Info("测试5");
							Log.Info(card.ToString());
							Setrank_new("scp181", "pink", scp181);
							scp181.Broadcast(10, "你是[<color=red>SCP-181</color>]\n正在为你分配一张初始卡片你有20%几率捡起卡升级 次数无限 你可以人肉开门2次加油哦");
							scp181.Broadcast(10, "[<color=red>SCP-181</color>]\n你还可以合成枪 你也可以合成闪光弹");
							Coroutines.Add(Timing.RunCoroutine(testHint("scp181", scp181)));
							break;
						case 1:
							cxk = referenceHub;
							cxkid = cxk.Id;
							cxkyes = true;
							cxkflash = true;
							Setrank_new("蔡徐坤", "red", cxk);
							cxk.Broadcast(10, "你是[<color=red>SCP-蔡徐坤</color>]\n<color=lime>丢下手电筒使用技能鸡你太美</color>");
							Coroutines.Add(Timing.RunCoroutine(testHint("cxk", cxk)));
							Coroutines.Add(Timing.RunCoroutine(SecondCounter12()));
							break;
						case 2:
							scp817 = referenceHub;
							scp817yes = true;
							scp817id = scp817.Id;
							Setrank_new("SCP817", "red", scp817);
							scp817.Broadcast(10, "你是[<color=red>SCP-817</color>]\n<color=lime>150秒变换一次身份</color>");
							Coroutines.Add(Timing.RunCoroutine(testHint("scp817", scp817)));
							Coroutines.Add(Timing.RunCoroutine(SecondCounter13()));
							break;
						case 3:
							D9341 = referenceHub;
							D9341js = RoleType.ClassD;
							D9341id = D9341.Id;
							D9341zb = D9341.Position;
							d9341flash = true;
							Setrank_new("D-9341", "red", D9341);
							D9341.Broadcast(6, "你是[<color=red>D-9341</color>]<color=lime>你有存档能力 丢掉闪光弹</color><color=red>(打开背包右键不是左键扔出去)</color><color=lime>存档</color>\n<color=lime>死亡或丢手电会回档一共5次机会</color>");
							Coroutines.Add(Timing.RunCoroutine(testHint("d9341", D9341)));
							break;
						case 4:
							scp2006 = referenceHub;
							scp2006id = scp2006.Id;
							scp2006.Broadcast(10, "你是[<color=red>SCP-2006</color>]\n<color=lime>丢下一个硬币就会被随机传送到一个地方</color>");
							Coroutines.Add(Timing.RunCoroutine(Scp2006coin()));
							scp2006a.Add(scp2006.UserId);
							Coroutines.Add(Timing.RunCoroutine(testHint("scp2006", scp2006)));
							break;
						case 5:
							scp035 = referenceHub;
							scp035.Broadcast(10, "你是[<color=red>SCP035</color>]\n<color=lime>HP:300</color><color=red>杀掉一个人后 靠近尸体附身他的人物</color><color=red>每5秒扣除5HP 附身后HP恢复为500</color>");
							scp035health = true;
							scp035id = scp035.Id;
							scp035item2 = true;
							scp035.AddItem(ItemType.GunUSP);
							Coroutines.Add(Timing.RunCoroutine(testHint("scp035", scp035)));
							break;
						case 6:
							xtd = referenceHub;
							xtdid = xtd.Id;
							xtd.Broadcast(10, "你是[<color=red>小偷</color>]\n<color=lime>输入.steal偷取物品300s一次</color>");
							Setrank_new("小偷", "lime", xtd);
							Coroutines.Add(Timing.RunCoroutine(testHint("xt", xtd)));
							break;
					}
					d++;
				}
				if (referenceHub.Role == RoleType.Scp096)
				{
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(referenceHub, 1500)));
				}
				if (referenceHub.Role == RoleType.Scp173 && referenceHub.Id != scp650id)
				{
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(referenceHub, 4200)));
				}
				if (referenceHub.Role == RoleType.Scp049)
				{
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(referenceHub, 3200)));
				}
			}
			foreach (Door door in UnityEngine.Object.FindObjectsOfType<Door>())
			{
				if (door.DoorName.Contains("096"))
				{
					for (int c = 0; c <= 30; c++)
					{
						Pickup test = PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Coin, 0f, new Vector3(door.transform.position.x, door.transform.position.y + 5f, door.transform.position.z), Quaternion.identity, 0, 0, 0);
						Baba.Add(test);
						if (c == 7)
							Baba1.Add(test);
						if (c == 18)
							Baba1.Add(test);
					}
				}
			}
			for (int c2 = 0; c2 <= 30; c2++)
			{
				Pickup test2 = PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Coin, 0f, new Vector3(-54f, 990f, -49f), Quaternion.identity, 0, 0, 0);
				Baba.Add(test2);
				if (c2 == 7)
					Baba1.Add(test2);
				if (c2 == 18)
					Baba1.Add(test2);
			}
			for (int c3 = 0; c3 <= 30; c3++)
			{
				Pickup test3 = PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Coin, 0f, new Vector3(Map.GetRandomSpawnPoint(RoleType.Scp173).x, Map.GetRandomSpawnPoint(RoleType.Scp173).y + 5f, Map.GetRandomSpawnPoint(RoleType.Scp173).z), Quaternion.identity, 0, 0, 0);
				Baba.Add(test3);
				if (c3 == 7)
				{
					Baba1.Add(test3);
				}
			}
			yield return Timing.WaitForSeconds(600f);
			foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
			{
				if (player.Role != RoleType.Spectator)
				{
					continue;
				}
				if (!lbvyes)
				{
					lbvyes = true;
					lbvid = player.Id;
					lbv = player;
					lbv.Role = RoleType.NtfCommander;
					yield return Timing.WaitForSeconds(0.5f);
					lbv.ClearInventory();
					yield return Timing.WaitForSeconds(1f);
					lbv.AddItem(ItemType.GunCOM15);
					lbv.AddItem(ItemType.GunE11SR);
					lbv.AddItem(ItemType.Medkit);
					lbv.AddItem(ItemType.GrenadeFlash);
					lbv.AddItem(ItemType.GrenadeFrag);
					lbv.AddItem(ItemType.KeycardO5);
					lbv.AddItem(ItemType.Coin);
					Map.Broadcast(5, "伞兵一号lbv准备就绪");
					Setrank_new("卢本伟", "red", lbv);
					continue;
				}
				if (timesbxd < 3)
				{
					timesbxd++;
					sbxd.Add(player.Id);
					yield return Timing.WaitForSeconds(0.5f);
					lbv.ClearInventory();
					yield return Timing.WaitForSeconds(2f);
					player.Role = RoleType.NtfLieutenant;
					player.AddItem(ItemType.GunCOM15);
					player.AddItem(ItemType.GunE11SR);
					player.AddItem(ItemType.Medkit);
					player.AddItem(ItemType.GrenadeFlash);
					player.AddItem(ItemType.GrenadeFrag);
					player.AddItem(ItemType.KeycardNTFLieutenant);
					continue;
				}
				break;
			}
		}

		private IEnumerator<float> RunRestoreMaxHp(Exiled.API.Features.Player player, int maxHp)
		{
			yield return Timing.WaitForSeconds(0.1f);
			player.MaxHealth = maxHp;
			player.Health = maxHp;
		}

		private IEnumerator<float> SecondCounter25()
		{
			yield return Timing.WaitForSeconds(2f);
			jwhng.Health = health;
			bscd = true;
		}

		private IEnumerator<float> SecondCounter24()
		{
			yield return Timing.WaitForSeconds(2f);
			Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 500)));
			yield return Timing.WaitForSeconds(2f);
		}

		private IEnumerator<float> Wshf()
		{
			yield return Timing.WaitForSeconds(10f);
			误杀玩家.ReferenceHub.playerMovementSync.OverridePosition(RoleType.NtfCadet.GetRandomSpawnPoint(), 0, false);
		}
		private IEnumerator<float> Jwhngwufashanghai()
		{
			yield return Timing.WaitForSeconds(120f);
			jwhngwufashanghai = false;
			jwhng.ClearBroadcasts();
			jwhng.Broadcast(10, "<color=red>你现在可以变成混沌攻击九尾狐了 右键闪光弹 或者输入.wz</color>");
		}

		private IEnumerator<float> SecondCounter22()
		{
			while (scp457a)
			{
				if (scp457.Role == RoleType.Tutorial)
				{
					foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
					{
						if (player.Team != 0 && player.Id != scp457id && Vector3.Distance(scp457.Position, player.Position) <= 6)
						{
							int sh = 4 + 2 * scp457sh;
							player.Health -= sh;
							player.Broadcast(1, "<color=red>[你感到自己火了]</color>");
						}
					}
				}
				yield return Timing.WaitForSeconds(1f);
			}
		}

		private IEnumerator<float> SecondCounter21()
		{
			yield return Timing.WaitForSeconds(1800f);
			Exiled.API.Features.Warhead.Start();
			xitonghedan = true;
			Exiled.API.Features.Map.Broadcast(5, "<color=red>[警告]</color>\n<color=lime>系统核弹已开启无法关闭</color>");
		}

		public void Setrank_new(string text, string color, Exiled.API.Features.Player player)
		{
			if(player.GlobalBadge == null)
			{
				player.RankName = text;
				player.RankColor = color;
			}
		}

		private IEnumerator<float> Scp2006coin()
		{
			yield return Timing.WaitForSeconds(10f);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
			scp2006.AddItem(ItemType.Coin);
		}

		private IEnumerator<float> SecondCounter20()
		{
			yield return Timing.WaitForSeconds(10f);
			switch (card)
			{
				case 1:
					scp181.AddItem(ItemType.KeycardChaosInsurgency);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 2:
					scp181.AddItem(ItemType.KeycardContainmentEngineer);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 3:
					scp181.AddItem(ItemType.KeycardJanitor);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 4:
					scp181.AddItem(ItemType.KeycardScientistMajor);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 5:
					scp181.AddItem(ItemType.KeycardNTFCommander);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 6:
					scp181.AddItem(ItemType.KeycardNTFLieutenant);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 7:
					scp181.AddItem(ItemType.KeycardO5);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 8:
					scp181.AddItem(ItemType.KeycardScientist);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				case 9:
					scp181.AddItem(ItemType.KeycardZoneManager);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
				default:
					scp181.AddItem(ItemType.KeycardZoneManager);
					card = 0;
					scp181.AddItem(ItemType.Coin);
					break;
			}
			if (scp035item2)
			{
				Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 300)));
				scp035.AddItem(ItemType.GunUSP);
				scp035.AddItem(ItemType.Ammo9mm);
				scp035.AddItem(ItemType.Ammo9mm);
				scp035.AddItem(ItemType.Ammo9mm);
				scp035.AddItem(ItemType.KeycardScientist);
				scp035item2 = false;
				foreach (Door door in Exiled.API.Features.Map.Doors)
				{
					if (door.DoorName == "173_ARMORY")
					{
						door.DestroyDoor(true);
						scp035.ReferenceHub.playerMovementSync.OverridePosition(new Vector3(door.transform.position.x, door.transform.position.y + 1.5f, door.transform.position.z), 0, false);
					}
				}
			}
			if (d9341flash)
			{
				D9341.AddItem(ItemType.Flashlight);
				D9341.AddItem(ItemType.GrenadeFlash);
				d9341flash = false;
			}
			if (cxkflash)
			{
				cxk.AddItem(ItemType.Flashlight);
				cxkflash = false;
			}
			if (scp035health)
			{
				Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 500)));
				scp035health = false;
			}
			foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
			{
				switch (referenceHub.Role)
				{
					case RoleType.Scp93953:
						referenceHub.Health = 6000f;
						break;
					case RoleType.Scp93989:
						referenceHub.Health = 6000f;
						break;
					case RoleType.Scp049:
						referenceHub.Health = 3500f;
						break;
					case RoleType.Scp173:
						referenceHub.Health = 4200f;
						break;
					case RoleType.Scp096:
						referenceHub.Health = 1500f;
						break;
					case RoleType.ClassD:
						referenceHub.Health = 100f;
						break;
					case RoleType.FacilityGuard:
						referenceHub.Health = 100f;
						break;
					case RoleType.Scientist:
						referenceHub.Health = 120f;
						break;
				}
			}
		}

		private IEnumerator<float> Wdzs()
		{
			yield return Timing.WaitForSeconds(10f);
			foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
			{
				if (player3.Role == RoleType.Scp173 && player3.Id != scp650id)
				{
					player3.Health = 4200f;
					player3.IsGodModeEnabled = false;
				}
				if (player3.Health >= 10000f)
				{
					player3.Health = 10000f;
				}
			}
		}

		private IEnumerator<float> SecondCounter19()
		{
			while (true)
			{
				if (scp035goout)
				{
					Setrank_new("SCP-035", "red", scp035);
					Exiled.API.Features.Map.Broadcast(10, "<color=red>因为SCP-035逃出设施 每150s会随机死亡一个玩家</color>");
					yield return Timing.WaitForSeconds(150f);
					using (IEnumerator<Exiled.API.Features.Player> enumerator = Exiled.API.Features.Player.List.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							Exiled.API.Features.Player referenceHub = enumerator.Current;
							referenceHub.Kill();
							referenceHub.SetRole(RoleType.Spectator);
						}
					}
				}
				else
				{
					break;
				}
				yield return Timing.WaitForSeconds(1f);
			}
		}

		private IEnumerator<float> SecondCounter18()
		{
			yield return Timing.WaitForSeconds(100f);
			if (choise == false)
			{
				choise = true;
				scp79 = true;
				foreach (Exiled.API.Features.Player p in Exiled.API.Features.Player.List)
				{
					if (p.Role == RoleType.Scp079)
					{
						p.RankName = "SCP079 - 帮助SCP";
						p.RankColor = "aqua";
					}
				}
				Exiled.API.Features.Map.Broadcast(10, "<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>人类感受恐惧吧 本局SCP079选择帮助SCP</color>\n<color=aqua>SCP不会受到电网的伤害</color>");
			}
		}

		private IEnumerator<float> SecondCounter17()
		{
			chenghaoyes = true;
			while (true)
			{
				switch (times5)
				{
					case 1:
						foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
						{
							switch (player.UserId)
							{
								case "76561198197721054@steam":
									Setrank_new("求别乱杀DD", "lime", player);
									break;
								case "76561198441344563@steam":
									Setrank_new("服内最帅大佬", "lime", player);
									break;
								case "76561198816705835@steam":
									Setrank_new("孤独一生", "yellow", player);
									break;
								case "76561198369468432@steam":
									Setrank_new("白嫖大法好", "lime", player);
									break;
								case "76561198997348090@steam":
									Setrank_new("因为是魔王所以很棒呀", "lime", player);
									break;
								case "76561198893112896@steam":
									Setrank_new("迪奥·布兰度", "yellow", player);
									break;
								case "76561198377975833@steam":
									Setrank_new("02は世界で一番いいです", "yellow", player);
									break;
								case "76561198385564103@steam":
									Setrank_new("半仙", "yellow", player);
									break;
								case "76561199027737454@steam":
									Setrank_new("良民", "yellow", player);
									break;
								case "76561198407952020@steam":
									Setrank_new("福利部长", "yellow", player);
									break;
							}
						}
						times5 = 2;
						break;
					case 2:
						foreach (Exiled.API.Features.Player player2 in Exiled.API.Features.Player.List)
						{
							switch (player2.UserId)
							{
								case "76561198197721054@steam":
									Setrank_new("求别乱杀DD", "crimson", player2);
									break;
								case "76561198441344563@steam":
									Setrank_new("服内最帅大佬", "crimson", player2);
									break;
								case "76561198816705835@steam":
									Setrank_new("孤独一生", "light_green", player2);
									break;
								case "76561198369468432@steam":
									Setrank_new("白嫖大法好", "crimson", player2);
									break;
								case "76561198997348090@steam":
									Setrank_new("因为是魔王所以很棒呀", "crimson", player2);
									break;
								case "76561198893112896@steam":
									Setrank_new("迪奥·布兰度", "orange", player2);
									break;
								case "76561198377975833@steam":
									Setrank_new("02は世界で一番いいです", "orange", player2);
									break;
								case "76561198385564103@steam":
									Setrank_new("半仙", "orange", player2);
									break;
								case "76561199027737454@steam":
									Setrank_new("良民", "orange", player2);
									break;
								case "76561198407952020@steam":
									Setrank_new("福利部长", "orange", player2);
									break;
							}
						}
						times5 = 3;
						break;
					case 3:
						foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
						{
							switch (player3.UserId)
							{
								case "76561198197721054@steam":
									Setrank_new("求别乱杀DD", "cyan", player3);
									break;
								case "76561198441344563@steam":
									Setrank_new("服内最帅大佬", "cyan", player3);
									break;
								case "76561198816705835@steam":
									Setrank_new("孤独一生", "red", player3);
									break;
								case "76561198369468432@steam":
									Setrank_new("白嫖大法好", "cyan", player3);
									break;
								case "76561198997348090@steam":
									Setrank_new("因为是魔王所以很棒呀", "cyan", player3);
									break;
								case "76561198893112896@steam":
									Setrank_new("迪奥·布兰度", "pink", player3);
									break;
								case "76561198377975833@steam":
									Setrank_new("02は世界で一番いいです", "pink", player3);
									break;
								case "76561198385564103@steam":
									Setrank_new("半仙", "pink", player3);
									break;
								case "76561199027737454@steam":
									Setrank_new("良民", "pink", player3);
									break;
								case "76561198407952020@steam":
									Setrank_new("福利部长", "pink", player3);
									break;
							}
						}
						times5 = 4;
						break;
					case 4:
						foreach (Exiled.API.Features.Player player4 in Exiled.API.Features.Player.List)
						{
							switch (player4.UserId)
							{
								case "76561198197721054@steam":
									Setrank_new("求别乱杀DD", "red", player4);
									break;
								case "76561198441344563@steam":
									Setrank_new("服内最帅大佬", "red", player4);
									break;
								case "76561198816705835@steam":
									Setrank_new("孤独一生", "cyan", player4);
									break;
								case "76561198369468432@steam":
									Setrank_new("白嫖大法好", "red", player4);
									break;
								case "76561198997348090@steam":
									Setrank_new("因为是魔王所以很棒呀", "red", player4);
									break;
								case "76561198893112896@steam":
									Setrank_new("迪奥·布兰度", "red", player4);
									break;
								case "76561198377975833@steam":
									Setrank_new("02は世界で一番いいです", "red", player4);
									break;
								case "76561198385564103@steam":
									Setrank_new("半仙", "red", player4);
									break;
								case "76561199027737454@steam":
									Setrank_new("良民", "red", player4);
									break;
								case "76561198407952020@steam":
									Setrank_new("福利部长", "red", player4);
									break;
							}
						}
						times5 = 5;
						break;
					case 5:
						foreach (Exiled.API.Features.Player player5 in Exiled.API.Features.Player.List)
						{
							switch (player5.UserId)
							{
								case "76561198197721054@steam":
									Setrank_new("求别乱杀DD", "light_green", player5);
									break;
								case "76561198441344563@steam":
									Setrank_new("服内最帅大佬", "light_green", player5);
									break;
								case "76561198816705835@steam":
									Setrank_new("孤独一生", "crimson", player5);
									break;
								case "76561198369468432@steam":
									Setrank_new("白嫖大法好", "light_green", player5);
									break;
								case "76561198997348090@steam":
									Setrank_new("因为是魔王所以很棒呀", "light_green", player5);
									break;
								case "76561198893112896@steam":
									Setrank_new("迪奥·布兰度", "light_green", player5);
									break;
								case "76561198377975833@steam":
									Setrank_new("02は世界で一番いいです", "light_green", player5);
									break;
								case "76561198385564103@steam":
									Setrank_new("半仙", "light_green", player5);
									break;
								case "76561199027737454@steam":
									Setrank_new("良民", "light_green", player5);
									break;
								case "76561198407952020@steam":
									Setrank_new("福利部长", "light_green", player5);
									break;
							}
						}
						times5 = 6;
						break;
					case 6:
						chenghaoyes = false;
						foreach (Exiled.API.Features.Player player6 in Exiled.API.Features.Player.List)
						{
							switch (player6.UserId)
							{
								case "76561198197721054@steam":
									Setrank_new("求别乱杀DD", "yellow", player6);
									chenghaoyes = true;
									break;
								case "76561198441344563@steam":
									chenghaoyes = true;
									Setrank_new("服内最帅大佬", "yellow", player6);
									break;
								case "76561198816705835@steam":
									chenghaoyes = true;
									Setrank_new("孤独一生", "lime", player6);
									break;
								case "76561198369468432@steam":
									chenghaoyes = true;
									Setrank_new("白嫖大法好", "yellow", player6);
									break;
								case "76561198997348090@steam":
									chenghaoyes = true;
									Setrank_new("因为是魔王所以很棒呀", "yellow", player6);
									break;
								case "76561198893112896@steam":
									chenghaoyes = true;
									Setrank_new("迪奥·布兰度", "cyan", player6);
									break;
								case "76561198377975833@steam":
									chenghaoyes = true;
									Setrank_new("02は世界で一番いいです", "cyan", player6);
									break;
								case "76561198385564103@steam":
									chenghaoyes = true;
									Setrank_new("半仙", "cyan", player6);
									break;
								case "76561199027737454@steam":
									chenghaoyes = true;
									Setrank_new("良民", "cyan", player6);
									break;
								case "76561198407952020@steam":
									Setrank_new("福利部长", "cyan", player6);
									chenghaoyes = true;
									break;
							}
						}
						times5 = 1;
						break;
				}
				if (chenghaoyes == false)
				{
					break;
				}
				yield return Timing.WaitForSeconds(6f);
			}
		}

		private IEnumerator<float> SecondCounter3()
		{
			while (true)
			{
				if (sjtz1)
				{
					foreach (Player player in Player.List)
					{
						if (Dio2.Contains(player.UserId) == false)
						{
							player.Position = player.Position;
						}
					}
				}
				if (qblcq2)
				{
					qblcq.ReferenceHub.playerMovementSync.OverridePosition(scpqbl3.Position, 0, false);
				}
				if (ljfuse)
				{
					foreach (Exiled.API.Features.Player referenceHub2 in ljfwj)
					{
						if (referenceHub2.Id != fkyyzid)
						{
							referenceHub2.Position = referenceHub2.Position;
						}
					}
				}
				if (jzsjuse)
				{
					foreach (Player player in Player.List)
					{
						if (player.Id != fkyyzid)
						{
							player.Position = player.Position;
						}
					}
				}
				if (!ljfuse && !jzsjuse && !qblcq2 && !sjtz1)
				{
					Timing.KillCoroutines(Coroutines3);
					Coroutines3.Clear();
				}
				yield return Timing.WaitForSeconds(0.1f);
			}
		}

		private IEnumerator<float> SecondCounter12()
		{
			while (true)
			{
				yield return Timing.WaitForSeconds(1f);
				if (cxkyes)
				{
					yield return Timing.WaitForSeconds(100f);
					cxk.AddItem(ItemType.Flashlight);
					cxk.Broadcast(4, "<color=#00FF00>你感受到 一段音乐在你脑中想起\n你突然感觉鸡很美丽</color>");
					continue;
				}
				break;
			}
		}

		private IEnumerator<float> SecondCounter13()
		{
			while (scp817yes)
			{
				yield return Timing.WaitForSeconds(150f);
				pos3 = scp817.Position;
				switch (new System.Random().Next(1, 14))
				{
					case 1:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scientist, true);
						break;
					case 2:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.ChaosInsurgency, true);
						break;
					case 3:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.FacilityGuard, true);
						break;
					case 4:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfCadet, true);
						break;
					case 5:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfCommander, true);
						break;
					case 6:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfLieutenant, true);
						break;
					case 7:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfScientist, true);
						break;
					case 8:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp079, true);
						break;
					case 9:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp106, true);
						break;
					case 10:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp173, true);
						break;
					case 11:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp93953, true);
						break;
					case 12:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp93989, true);
						break;
					case 13:
						scp817.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Tutorial, true);
						break;
				}
				scp817.Broadcast(5, "<color=red>[个人通知]</color>\n<color=#FFFF00>恭喜你性转成功 你已经是女孩子了</color>");
				yield return Timing.WaitForSeconds(10f);
			}
		}

		public void OnDecontaminate(DecontaminatingEventArgs ev)
		{
			Exiled.API.Features.Map.Broadcast(10, "<color=red>[警告]</color>\n地下毒气已开启");
			Coroutines.Add(Timing.RunCoroutine(Whereareyou2()));
			dq = true;
		}

		public IEnumerator<float> ChopperThread()
		{
			while (roundstart)
			{
				Log.Info("九尾狐物资刷新延时10min.");
				yield return Timing.WaitForSeconds(600f);
				Log.Info("刷新物资!");
				foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
				{
					if (referenceHub.Health > 8000f)
					{
						referenceHub.Health = 8000f;
					}
				}
				foreach (Exiled.API.Features.Player h in Exiled.API.Features.Player.List)
				{
					h.Broadcast(5, "<color=66FF00>[九尾狐电台]</color>\n<color=#00FFFF>一份九尾狐补给正在通过飞机送达</color>");
				}
				RespawnEffectsController.ExecuteAllEffects(RespawnEffectsController.EffectType.Selection, SpawnableTeamType.NineTailedFox);
				yield return Timing.WaitForSeconds(15f);
				Vector3 spawn = RoleType.NtfCadet.GetRandomSpawnPoint();
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo556, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo556, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo556, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo556, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo762, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo762, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo762, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo762, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo9mm, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo9mm, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo9mm, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Ammo9mm, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.SCP500, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Medkit, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Adrenaline, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GunLogicer, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GrenadeFlash, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GrenadeFlash, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GrenadeFrag, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GrenadeFrag, 1000f, spawn, Quaternion.identity, 0, 0, 0);
				yield return Timing.WaitForSeconds(15f);
			}
		}

		private IEnumerator<float> SecondCounter11()
		{
			while (jntm)
			{
				yield return Timing.WaitForSeconds(10f);
				jntm = false;
				yield return Timing.WaitForSeconds(1f);
			}
		}

		private IEnumerator<float> SecondCounter10()
		{
			while (scp076yes)
			{
				yield return Timing.WaitForSeconds(0.5f);
				if (scp076iteam)
				{
					scp076.Role = RoleType.NtfCommander;
					yield return Timing.WaitForSeconds(0.5f);
					scp076.ClearInventory();
					yield return Timing.WaitForSeconds(2f);
					scp076.AddItem(ItemType.GunE11SR);
					scp076.AddItem(ItemType.Radio);
					scp076.AddItem(ItemType.Adrenaline);
					scp076.AddItem(ItemType.GrenadeFrag);
					scp076.AddItem(ItemType.GrenadeFrag);
					scp076.AddItem(ItemType.MicroHID);
					scp076iteam = false;
				}
				if (scp076yes)
				{
					scp076.AddItem(ItemType.MicroHID);
				}
				yield return Timing.WaitForSeconds(240f);
			}
		}

		private IEnumerator<float> Diotp()
		{
			yield return Timing.WaitForSeconds(1f);
			Dio.Position = RoleType.ChaosInsurgency.GetRandomSpawnPoint();
			yield return Timing.WaitForSeconds(0.5f);
			Dio.Position = RoleType.ChaosInsurgency.GetRandomSpawnPoint();
		}

		private IEnumerator<float> Scp457tp()
		{
			yield return Timing.WaitForSeconds(1f);
			scp457.Position = RoleType.Scp096.GetRandomSpawnPoint();
			yield return Timing.WaitForSeconds(0.5f);
			scp457.Position = RoleType.Scp096.GetRandomSpawnPoint();
		}

		private IEnumerator<float> Scp073zb()
		{
			yield return Timing.WaitForSeconds(2f);
			scp073.SetRole(RoleType.NtfLieutenant);
		}

		private IEnumerator<float> Scp550item()
		{
			yield return Timing.WaitForSeconds(2f);
			Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp550, 4000)));
			Setrank_new("SCP-550", "red", scp550);
			meitunshi = true;
			scp550.Broadcast(10, "<color=lime>[SCP550]</color>\n<color=yello>你是食尸鬼:HP:5000 如果30s内没吞噬尸体每秒损失8HP</color>\n<color=yellow>站在尸体边上即可吞噬尸体 吞噬完成后你会获得能力的提升</color>");
			Coroutines.Add(Timing.RunCoroutine(SecondCounter26()));
			scp550.AddItem(ItemType.GunProject90);
			scp550.ReferenceHub.playerMovementSync.OverridePosition(RoleType.Scp049.GetRandomSpawnPoint(), 0, false);
			Coroutines.Add(Timing.RunCoroutine(testHint("scp550", scp550)));
		}

		private IEnumerator<float> Hhzhgzb()
		{
			yield return Timing.WaitForSeconds(2f);
			HDZHG.ClearBroadcasts();
			HDZHG.Broadcast(5, "<color=yellow>[个人通知]</color>\n<color=lime>你是</color><color=#00FFFF>[混沌指挥官]</color><color=lime>请带领着混沌走向胜利\n输入.help查看技能</color>");
			Setrank_new("混沌指挥官", "yello", HDZHG);
			Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(HDZHG, 150)));
			HDZHG.AddItem(ItemType.KeycardO5);
			Coroutines.Add(Timing.RunCoroutine(testHint("hdzhg", HDZHG)));
			HDZHG2.Add(HDZHG.UserId);
		}

		private IEnumerator<float> Mzzb()
		{
			yield return Timing.WaitForSeconds(2f);
			Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(mz, 500)));
			mz.AddItem(ItemType.SCP500);
			mz.AddItem(ItemType.Adrenaline);
			Setrank_new("毛子", "white", mz);
			Exiled.API.Features.Map.Broadcast(5, "Сука блядь 乌拉  бутылка водки");
			Log.Info("测试2");
			Coroutines.Add(Timing.RunCoroutine(testHint("mz", mz)));
		}

		private IEnumerator<float> Mrfishzb()
		{
			yield return Timing.WaitForSeconds(1f);
			mrfish.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scientist, true);
			yield return Timing.WaitForSeconds(1f);
			mrfish.ClearInventory();
			yield return Timing.WaitForSeconds(2f);
			mrfish.Health = 120f;
			mrfish.AddItem(ItemType.KeycardO5);
			mrfish.AddItem(ItemType.MicroHID);
			mrfish.AddItem(ItemType.GunLogicer);
			mrfish.AddItem(ItemType.GrenadeFrag);
			mrfish.AddItem(ItemType.Radio);
			mrfish.AddItem(ItemType.SCP500);
			mrfish.AddItem(ItemType.SCP207);
			mrfish.Ammo[(int)AmmoType.Nato9] = 400;
			mrfish.Ammo[(int)AmmoType.Nato556] = 400;
			mrfish.Ammo[(int)AmmoType.Nato762] = 400;
			Coroutines.Add(Timing.RunCoroutine(testHint("mrfish", mrfish)));
			Log.Info("测试5");
		}

		private IEnumerator<float> Scp1577bj()
		{
			yield return Timing.WaitForSeconds(2f);
			Vector3 vector3 = new Vector3(scp1577pos.x, scp1577pos.y + 1f, scp1577pos.z);
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.SCP500, 1000f, vector3, Quaternion.identity, 0, 0, 0);
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.SCP500, 1000f, vector3, Quaternion.identity, 0, 0, 0);
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Medkit, 1000f, vector3, Quaternion.identity, 0, 0, 0);
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.KeycardO5, 1000f, vector3, Quaternion.identity, 0, 0, 0);
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Medkit, 1000f, vector3, Quaternion.identity, 0, 0, 0);
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.MicroHID, 1000f, vector3, Quaternion.identity, 0, 0, 0);
			Log.Info("测试7");
		}

		private IEnumerator<float> Giveboom()
		{
			while (true)
			{
				yield return Timing.WaitForSeconds(40f);
				if (scp1143a)
				{
					scp1143.AddItem(ItemType.GrenadeFrag);
					continue;
				}
				break;
			}
		}

		private IEnumerator<float> Jwhngitem()
		{
			yield return Timing.WaitForSeconds(2f);
			jwhng.ClearInventory();
			yield return Timing.WaitForSeconds(2f);
			jwhng.ClearBroadcasts();
			jwhng.Broadcast(5, "<color=lime>[九尾狐内鬼]</color>\n<color=yello>你是九尾狐中的内鬼HP:350你有120s的准备时间</color>\n<color=yellow>丢下闪光弹切换隐藏模式</color>");
			jwhng.Broadcast(5, "<color=lime>[九尾狐内鬼]</color>\n<color=yello>补充说明 你在隐藏模式被九尾扫到会掉血但是不会暴露</color>\n<color=yellow>120s之前九尾不会对你造成伤害你也无法变身</color>");
			jwhng.AddItem(ItemType.KeycardChaosInsurgency);
			jwhng.AddItem(ItemType.GunE11SR);
			jwhng.AddItem(ItemType.Radio);
			jwhng.AddItem(ItemType.GrenadeFlash);
			jwhng.AddItem(ItemType.Adrenaline);
			Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(jwhng, 350)));
			Coroutines.Add(Timing.RunCoroutine(testHint("jwhng", jwhng)));
		}

		private IEnumerator<float> SecondCounter27()
		{
			while (scp550yes)
			{
				Ragdoll[] array = UnityEngine.Object.FindObjectsOfType<Ragdoll>();
				foreach (Ragdoll ragdoll in array)
				{
					if (Vector3.Distance(ragdoll.transform.transform.position, scp550.Position) <= 5)
					{
						tssj++;
						scp550.Broadcast(1, "<color=lime>[提示]吞噬尸体中进度</color>" + tssj);
						if (scp550lv == 0 && tssj >= 14)
						{
							tssj = 0;
							tssl++;
							meitunshi = true;
							scp550.Health += 100f;
							Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
							NetworkServer.Destroy(ragdoll.gameObject);
						}
						if (scp550lv == 1 && tssj >= 12)
						{
							tssj = 0;
							meitunshi = true;
							tssl++;
							scp550.Health += 100f;
							Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
							NetworkServer.Destroy(ragdoll.gameObject);
						}
						if (scp550lv >= 2 && tssj >= 10)
						{
							meitunshi = true;
							tssj = 0;
							tssl++;
							scp550.Health += 100f;
							Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
							NetworkServer.Destroy(ragdoll.gameObject);
						}
						break;
					}
				}
				if (tssl == 10)
				{
					meitunshi = true;
					scp550lv = 1;
					Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
				}
				if (tssl == 25)
				{
					meitunshi = true;
					scp550lv = 2;
					Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
				}
				if (tssl == 45)
				{
					meitunshi = true;
					scp550lv = 3;
					Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
				}
				if (tssl == 70)
				{
					meitunshi = true;
					scp550lv = 4;
					Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
				}
				if (scp550lv == 1)
				{
					scp550.Health += 3f;
				}
				if (scp550lv == 2)
				{
					scp550.Health += 5f;
				}
				if (scp550lv == 3)
				{
					scp550.Health += 7f;
				}
				if (scp550lv == 4)
				{
					scp550.Health += 9f;
				}
				yield return Timing.WaitForSeconds(1f);
			}
		}

		private IEnumerator<float> SecondCounter26()
		{
			while (scp550yes)
			{
				if (meitunshi)
				{
					yield return Timing.WaitForSeconds(30f);
					meitunshi = false;
				}
				if (!meitunshi && scp550.Health >= 300f)
				{
					scp550.Health -= 8f;
				}
				yield return Timing.WaitForSeconds(1f);
			}
		}

		private IEnumerator<float> Fkyyztp()
		{
			yield return Timing.WaitForSeconds(2f);
			fkyyz.ReferenceHub.playerMovementSync.OverridePosition(RoleType.Scp93989.GetRandomSpawnPoint(), 0, false);
		}


		private IEnumerator<float> SecondCounter2()
		{
			while (true)
			{
				foreach (Exiled.API.Features.Player p in Exiled.API.Features.Player.List)
				{
					if (p.Health <= 1f && p.Id != scp650id)
					{
						Exiled.API.Features.Map.Broadcast(1, p.Nickname + "：你不要过来呀");
						p.AddItem(ItemType.SCP207);
					}
					if (!(p.Position.y <= -1000f) || !(p.Position.y >= -1006f))
					{
						continue;
					}
					int222++;
					switch (new System.Random().Next(1, 14))
					{
						case 1:
							p.Broadcast(5, "<color=red>发生啥事？我练功发自真心</color>" + int222);
							break;
						case 2:
							p.Broadcast(5, "<color=red>有节操~有节操~</color>" + int222);
							break;
						case 3:
							p.Broadcast(5, "<color=red>一切都是屁！</color>" + int222);
							break;
						case 4:
							p.Broadcast(5, "<color=red>DOTA！俺爸瞎啦！ 后妈！</color>" + int222);
							break;
						case 5:
							p.Broadcast(5, "<color=red>妈妈回来！</color>" + int222);
							break;
						case 6:
							p.Broadcast(5, "<color=red>你是三岁小孩吗？</color>" + int222);
							break;
						case 7:
							p.Broadcast(5, "<color=red>哇啊啊啊啊↑</color>" + int222);
							break;
						case 8:
							p.Broadcast(5, "<color=red>B裂 都被插 死B裂</color>" + int222);
							break;
						case 9:
							p.Broadcast(5, "<color=red>俺感觉好好啊！</color>" + int222);
							break;
						case 10:
							p.Broadcast(5, "<color=red>GAY佬！把你活吞！</color>" + int222);
							break;
						case 11:
							p.Broadcast(5, "<color=red>AAAAAAAA圣诞快乐AAAAAA好快乐啊！</color>" + int222);
							break;
						case 12:
							p.Broadcast(5, "<color=red>Wuaaaa~Wuaaaa~Wuaaaa~</color>" + int222);
							break;
						case 13:
							p.Broadcast(5, "<color=red>啊~飞杀祖宗</color>" + int222);
							break;
					}
					if (int222 == 10 || int222 == 20 || int222 == 30 || int222 == 50 || int222 == 60 || (int222 == 70 && int222 == 80 && int222 == 90))
					{
						p.AddItem(ItemType.MicroHID);
						p.Broadcast(5, "<color=lime>[个人通知]/n</color><color=yellow>你已获得电磁炮*1</color>");
					}
					else
					{
						if (int222 < 100)
						{
							continue;
						}
						foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
						{
							if (player.Role == RoleType.Scp079)
							{
								player.SetRole(RoleType.Spectator);
							}
						}
						int222 = 0;
						Exiled.API.Features.Map.Broadcast(10, "<color=lime>SCP-079:你的电脑遇到问题 需要重新启动（蓝屏的钙,好喝的钙）</color>");
					}
				}
				yield return Timing.WaitForSeconds(30f);
			}
		}

		private IEnumerator<float> Hkjs()
		{
			yield return Timing.WaitForSeconds(30f);
			jwhhk.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfScientist, true);
			yield return Timing.WaitForSeconds(1f);
			jwhhk.Health = 120;
			jwhhk.ReferenceHub.playerMovementSync.OverridePosition(hkzb, 0, false);
			hrss = false;
		}

		private IEnumerator<float> SecondCounter()
		{
			while (true)
			{
				try
				{
					Dio.IsGodModeEnabled = false;
					scp457.IsGodModeEnabled = false;
				}
				catch
				{
				}
				if (csm)
				{
					csmtime++;
					if (csmtime == 1)
					{
						csm = false;
						csmtime = 0;
					}
				}
				if (starttimer)
				{
					deadtimer = deadtimer++;
					waring1 = waring1++;
					if (coldbc)
					{
						coldtime++;
						if (coldtime == 8)
						{
							coldbc = false;
							coldtime = 0;
						}
					}
					if (coldtb)
					{
						coldtime2++;
						if (coldtime2 == 30)
						{
							coldtb = false;
							coldtime = 0;
						}
					}
				}
				yield return Timing.WaitForSeconds(10f);
			}
		}

		public void ScpSpawn()
		{
			if (!die)
			{
				scp.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Tutorial, true);
				scp.AddItem(ItemType.Disarmer);
				scp.AddItem(ItemType.Flashlight);
				scp.AddItem(ItemType.KeycardGuard);
				scp.AddItem(ItemType.Radio);
				scp.AddItem(ItemType.GunMP7);
				Setrank_new("SCP-999", "pink", scp);
				Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp, 4000)));
				scp.ClearBroadcasts();
				scp.Broadcast(10, "[<color=red>SCP-999</color>]\n<color=yellow>去给人们带去欢乐吧</color>");
				scp.Ammo[(int)AmmoType.Nato556] = 400;
				scp.Ammo[(int)AmmoType.Nato762] = 400;
				scp.Ammo[(int)AmmoType.Nato9] = 400;
				scp.SendConsoleMessage("\nSCP999插件说明:\nSCP999拥有[" + 4000 + "]血量,攻击到的对象将恢复[" + 5 + "]的血量,SCP999每[" + 150 + "]秒会回复80HP,SCP999不影响游戏结束条件", "green");
				start = true;
				scp_999.Add(scp.UserId);
				Coroutines.Add(Timing.RunCoroutine(testHint("scp999", scp)));
				Log.Info("SCP999已刷新，玩家为:" + scp.Nickname + start);
			}
		}

		public void On914KnobChange(ChangingKnobSettingEventArgs ev)
		{
			foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
			{
				if (Vector3.Distance(ev.Player.Position, player3.Position) <= 10)
				{
					ev.Player.Broadcast(5, "914当前设置：" + ev.KnobSetting.ToString() + "更改人员：" + ev.Player.Nickname);
				}
			}
		}

		public void OnScp096Enrage(EnragingEventArgs ev)
		{
			Exiled.API.Features.Map.Broadcast(5, "<color=red>[警告]</color>\n" + ev.Player.Nickname + "<color=lime>的脸被欣赏了</color>");
		}

		private IEnumerator<float> kick_player(Exiled.API.Features.Player player, string rea)
		{
			yield return Timing.WaitForSeconds(3f);
			player.Kick("你被管理员封了，具体解封时间:" + rea);
		}
		private IEnumerator<float> SecondCounter5()
		{
			yield return Timing.WaitForSeconds(200f);
			if (bhsx)
			{
				bhsx = false;
			}
			if (scp650yes)
			{
				foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
				{
					if (scp650 != null)
					{
						if (player.Id == scp650id && player.Role != 0)
						{
							scp650.IsGodModeEnabled = false;
						}
						int Rolenum = new System.Random().Next(1, 10);
						if (Rolenum >= 6 && (player.Role != RoleType.Spectator) && player.Team != Team.SCP)
						{
							scp650.ReferenceHub.playerMovementSync.OverridePosition(player.Position, 0, false);
						}
					}
				}
			}
			stealcd = false;
			Exiled.API.Features.Map.Broadcast(10, "<color=#00FFFF>如果你有什么好点子或者游玩中有什么问题欢迎您加群哦\n1021889243</color>");
			if (scp2006id != 0)
			{
				if (scp2006 != null)
				{
					scp2006.AddItem(ItemType.Coin);
				}
			}
			foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
			{
				if (referenceHub.Team == Team.SCP)
				{
					referenceHub.Health += 50f;
				}
			}

			int sjsj2 = new System.Random().Next(1, 49);
			if (!fkyyshuachu)
			{
				try
				{
					fkyyshuachu = true;
					fkyyzyes = true;
					fkyyzcardint = 2;
					foreach (Exiled.API.Features.Player player4 in Exiled.API.Features.Player.List)
					{
						if (player4.Role == RoleType.Spectator)
						{
							fkyyz = player4;
							if (fkyyz != null)
							{
								Setrank_new("奇迹的幻想之人", "red", fkyyz);
								fkyyz.Role = RoleType.Tutorial;
								fkyyzid = fkyyz.Id;
								Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(fkyyz, 500)));
								Coroutines.Add(Timing.RunCoroutine(Fkyyztp()));
								fkyyz.Broadcast(10, "<color=yellow>该人物正在测试 如果碰到</color><color=red>无敌 无限技能\n 或其他情况</color><color=yellow>请自觉退出服务器 理解万岁</color> \n<color=yellow>按~输入.help看使用方法</color>");
								break;
							}
						}
					}
				}
				catch
				{
					Log.Info("符卡错误");
				}

			}
			if (fkyyzyes)
			{
				fkyyzcardint++;
			}
			if (!die && start)
			{
				try
				{
					if (scp != null)
					{
						scp.AddItem(ItemType.Medkit);
						scp.Health += 80f;
					}
				}
				catch
				{
					Log.Info("SCP999血包");
				}

			}
			kccd = false;
			if (!scp457die && !scp457a)
			{
				foreach (Exiled.API.Features.Player player5 in Exiled.API.Features.Player.List)
				{
					if (player5.Role == RoleType.Spectator)
					{
						try
						{
							scp457 = player5;
							if (scp457 != null)
							{
								scp457a = true;
								Coroutines.Add(Timing.RunCoroutine(SecondCounter22()));
								scp457id = scp457.Id;
								Setrank_new("SCP-457", "red", scp457);
								scp457.SetRole(RoleType.Tutorial);
								Coroutines.Add(Timing.RunCoroutine(Scp457tp()));
								Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp457, 4000)));
								Exiled.API.Features.Map.Broadcast(10, "<color=red>[SCP457]</color>\n<color=lime>突破收容 请尽快将其重新收容</color>");
								scp457.Broadcast(10, "<color=#FFC0CB>---[SCP457]---</color>\n<color=#00FFFF>HP:4000  </color>你拥有一种特殊能力\n<color=#FFD700>在你周围的人都会扣血 持有SCP物品越多伤害越高</color>");
								break;
							}
						}
						catch
						{
							Log.Info("scp457异常");
						}


					}
				}
			}
			sjtz2 = false;
			coldwait233 = false;
			switch (sjsj2)
			{
				case 1:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>毒气泄漏！-事件：所有生存人类玩家将在30秒内扣除掉1-12hp</color>");
					foreach (Exiled.API.Features.Player player6 in Exiled.API.Features.Player.List)
					{
						int kx = new System.Random().Next(1, 12);
						if (player6.Team != Team.SCP)
						{
							player6.Health -= kx;
						}
					}
					break;
				case 2:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>DD造反！！-事件：所有存活的Class-D获得“造反物品”</color>");
					foreach (Exiled.API.Features.Player player7 in Exiled.API.Features.Player.List)
					{
						if (player7.Role == RoleType.ClassD)
						{
							player7.AddItem(ItemType.GunCOM15);
							player7.AddItem(ItemType.Ammo762);
							player7.AddItem(ItemType.GunCOM15);
						}
					}
					break;
				case 3:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>博士的私货！！-事件：所有存活博士获得电磁炮x2和500hp</color>");
					foreach (Exiled.API.Features.Player player8 in Exiled.API.Features.Player.List)
					{
						if (player8.Role == RoleType.Scientist)
						{
							player8.AddItem(ItemType.MicroHID);
							player8.AddItem(ItemType.MicroHID);
							player8.Health += 500f;
						}
					}
					break;
				case 4:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>我要下班-事件：随机一名保安获得一张黑卡</color>");
					Log.Info("随机事件测试");
					foreach (Exiled.API.Features.Player player9 in Exiled.API.Features.Player.List)
					{
						if (player9.Role == RoleType.FacilityGuard)
						{
							player9.AddItem(ItemType.KeycardO5);
							break;
						}
					}
					break;
				case 5:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>猪是的念来过倒-事件：在场的所有玩家get到了一个笑点</color>");
					break;
				case 6:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>恭喜发财！-事件：所有存活玩家获得一大堆硬币</color>");
					foreach (Exiled.API.Features.Player player10 in Exiled.API.Features.Player.List)
					{
						player10.AddItem(ItemType.Coin);
						player10.AddItem(ItemType.Coin);
						player10.AddItem(ItemType.Coin);
						player10.AddItem(ItemType.Coin);
						player10.AddItem(ItemType.Coin);
					}
					break;
				case 7:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>巧克力真好吃！-事件：花生吃掉自己手手</color>");
					foreach (Exiled.API.Features.Player player11 in Exiled.API.Features.Player.List)
					{
						if (player11.Role == RoleType.Scp173)
						{
							player11.Health -= 50f;
						}
					}
					break;
				case 8:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>无敌战神！-事件：花生-1HP并且无敌 恢复后满血复活qwq</color>");
					foreach (Exiled.API.Features.Player player12 in Exiled.API.Features.Player.List)
					{
						if (player12.Role == RoleType.Scp173)
						{
							player12.Health = 1f;
							player12.IsGodModeEnabled = true;
						}
					}
					Coroutines.Add(Timing.RunCoroutine(Wdzs()));
					break;
				case 9:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>抱抱老爹！-事件：SCP-106随机传送到一名D级人员身边</color>");
					foreach (Exiled.API.Features.Player player14 in Exiled.API.Features.Player.List)
					{
						if (player14.Role == RoleType.Scp106)
						{
							scp106a = player14;
							break;
						}
					}
					foreach (Exiled.API.Features.Player player13 in Exiled.API.Features.Player.List)
					{
						if (player13.Role == RoleType.ClassD)
						{
							if (scp106a != null)
							{
								scp106a.ReferenceHub.playerMovementSync.OverridePosition(player13.Position, 0, false);
							}
							break;
						}
					}
					break;
				case 10:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>毕业学徒！-事件：SCP-49-2变为SCP049</color>");
					foreach (Exiled.API.Features.Player player15 in Exiled.API.Features.Player.List)
					{
						if (player15.Role == RoleType.Scp0492)
						{
							player15.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp049, true);
							break;
						}
					}
					break;
				case 11:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>豆腐渣工程！-事件：5秒内门一碰就坏</color>");
					dfzgc = true;
					yield return Timing.WaitForSeconds(5f);
					dfzgc = false;
					break;
				case 12:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>敬老院！-事件：多出来一个老头</color>");
					foreach (Exiled.API.Features.Player player16 in Exiled.API.Features.Player.List)
					{
						if (player16.Role == RoleType.Spectator)
						{
							player16.SetRole(RoleType.Scp106);
							break;
						}
					}
					break;
				case 13:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>343的馈赠！-事件：一名玩家获得 电磁炮 手雷 黑卡</color>");
					foreach (Exiled.API.Features.Player player17 in Exiled.API.Features.Player.List)
					{
						if ((int)player17.Team > 0 && player17.Role != RoleType.Spectator)
						{
							player17.AddItem(ItemType.KeycardO5);
							player17.AddItem(ItemType.MicroHID);
							player17.AddItem(ItemType.GrenadeFrag);
							break;
						}
					}
					break;
				case 14:
					if (dq)
					{
						break;
					}
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>DD们的复仇！-事件：全部D复活 并携带手枪</color>");
					foreach (Exiled.API.Features.Player player18 in Exiled.API.Features.Player.List)
					{
						if (player18.Role == RoleType.Spectator)
						{
							player18.SetRole(RoleType.ClassD);
							player18.AddItem(ItemType.GunCOM15);
							player18.AddItem(ItemType.KeycardJanitor);
						}
					}
					break;
				case 15:
					if (dq)
					{
						break;
					}
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>洗澡真舒服！-事件：老头洗白变成96</color>");
					foreach (Exiled.API.Features.Player player19 in Exiled.API.Features.Player.List)
					{
						if (player19.Role == RoleType.Scp106)
						{
							player19.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp096, true);
						}
					}
					break;
				case 16:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>泥巴真好玩！-事件：96变黑了</color>");
					foreach (Exiled.API.Features.Player player20 in Exiled.API.Features.Player.List)
					{
						if (player20.Role == RoleType.Scp096)
						{
							player20.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp106, true);
						}
					}
					break;
				case 17:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>我练功发自真心！-事件：一名D级变成SCP079</color>");
					foreach (Exiled.API.Features.Player player21 in Exiled.API.Features.Player.List)
					{
						if (player21.Role == RoleType.ClassD)
						{
							player21.Role = RoleType.Scp079;
							scpd79.Add(player21);
							break;
						}
					}
					break;
				case 18:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>恩断义绝门！-事件：10s后全部门关闭</color>");
					yield return Timing.WaitForSeconds(10f);
					foreach (Door door2 in Exiled.API.Features.Map.Doors)
					{
						door2.isOpen = false;
					}
					break;
				case 19:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>杨永信网戒所！-事件：一名事件刷成079变回D级</color>");
					foreach (Exiled.API.Features.Player player22 in scpd79)
					{
						if (player22.Role == RoleType.Scp079)
						{
							player22.SetRole(RoleType.ClassD);
						}
					}
					break;
				case 20:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>079帮助SCP！-事件：本回合SCP有5%几率开门</color>");
					bscp79 = true;
					break;
				case 21:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>调皮的传送门！-事件：10秒内100%触发随机门</color>");
					csm = true;
					break;
				case 22:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>乔碧萝的逆袭！-事件：乔碧萝恢复伤害</color>");
					qblcq = null;
					qblcq2 = false;
					scpqbl = null;
					scpqbl3 = null;
					scpqblid = null;
					scpqblid2 = 0;
					break;
				case 23:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>空投弹药！-事件：所有人子弹加200发</color>");
					foreach (Exiled.API.Features.Player player23 in Exiled.API.Features.Player.List)
					{
						player23.Ammo[(int)AmmoType.Nato556] = player23.Ammo[(int)AmmoType.Nato556]+ 200;
						player23.Ammo[(int)AmmoType.Nato762] = player23.Ammo[(int)AmmoType.Nato762] + 200;
						player23.Ammo[(int)AmmoType.Nato9] = player23.Ammo[(int)AmmoType.Nato9] + 200;
					}
					break;
				case 24:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>肥宅快乐D！-事件：所有存活D级获得可乐</color>");
					foreach (Exiled.API.Features.Player player24 in Exiled.API.Features.Player.List)
					{
						if (player24.Role == RoleType.ClassD)
						{
							player24.AddItem(ItemType.SCP207);
						}
					}
					break;
				case 25:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>花生油！-事件：复活3个小花生但HP：只有30HP</color>");
					foreach (Exiled.API.Features.Player player25 in Exiled.API.Features.Player.List)
					{
						if (player25.Role == RoleType.Spectator)
						{
							time3++;
							player25.SetRole(RoleType.Scp173);
							if (time3 >= 3)
							{
								break;
							}
							Timing.RunCoroutine(Sethpnew(player25, 30));
						}
					}
					break;
				case 26:
					Log.Info("随机事件测试");
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>九尾狐你们的快递到了！-事件：九尾狐出生点刷两个电磁炮</color>");
					PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.MicroHID, 520f, RoleType.NtfCommander.GetRandomSpawnPoint(), Quaternion.identity, 0, 0, 0);
					PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.MicroHID, 520f, RoleType.NtfCommander.GetRandomSpawnPoint(), Quaternion.identity, 0, 0, 0);
					break;
				case 27:
					Log.Info("随机事件测试");
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>随机惊喜！-事件：随意地点刷一个黑卡</color>");
					PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.KeycardO5, 520f, RoleType.ClassD.GetRandomSpawnPoint(), Quaternion.identity, 0, 0, 0);
					break;
				case 28:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>年久失修！-事件：设施门有几率无法开启</color>");
					bhsx = true;
					break;
				case 29:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>DD们多年的存款！-事件：Class-D获得 物资一份</color>");
					foreach (Exiled.API.Features.Player player26 in Exiled.API.Features.Player.List)
					{
						if (player26.Role == RoleType.ClassD)
						{
							player26.AddItem(ItemType.GunE11SR);
							player26.Health += 50f;
							player26.AddItem(ItemType.KeycardNTFCommander);
						}
					}
					break;
				case 30:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>哇！光头！-事件：多出来一个96</color>");
					foreach (Exiled.API.Features.Player player27 in Exiled.API.Features.Player.List)
					{
						if (player27.Role == RoleType.Spectator)
						{
							player27.SetRole(RoleType.Scp096);
							break;
						}
					}
					break;
				case 31:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>360安全管家！-事件：开始杀毒</color>");
					foreach (Exiled.API.Features.Player player28 in Exiled.API.Features.Player.List)
					{
						int 安全管家 = new System.Random().Next(1, 100);
						if (安全管家 > 98)
						{
							误杀玩家 = player28;
							Exiled.API.Features.Map.Broadcast(10, "[<color=#66FF00>360安全管家</color>]\n" + 误杀玩家.Nickname + "木马病毒 已放入隔离区");
							误杀玩家.Position = RoleType.Tutorial.GetRandomSpawnPoint();
							Coroutines.Add(Timing.RunCoroutine(Wshf()));
						}
					}
					break;
				case 33:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>哔哩哔哩 (\u309c-\u309c)つロ 干杯~！-事件：每人获取一瓶可乐</color>");
					foreach (Exiled.API.Features.Player player29 in Exiled.API.Features.Player.List)
					{
						player29.AddItem(ItemType.SCP207);
					}
					break;
				case 34:
					foreach (Exiled.API.Features.Player player30 in Exiled.API.Features.Player.List)
					{
						player30.AddItem(ItemType.GrenadeFrag);
					}
					break;
				case 35:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>我秃了！-事件：随机一位玩家 加100HP 获得抗性</color>");
					foreach (Exiled.API.Features.Player player31 in Exiled.API.Features.Player.List)
					{
						if (player31.Team != 0)
						{
							tlid = player31.Id;
							player31.Health += 100f;
							break;
						}
					}
					break;
				case 36:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>人群当中，突然钻出来个光头！-事件：96随机传送到一个幸运儿旁边</color>");
					foreach (Exiled.API.Features.Player player32 in Exiled.API.Features.Player.List)
					{
						if (player32.Team == Team.SCP || player32.Role == RoleType.Tutorial)
						{
							continue;
						}
						foreach (Exiled.API.Features.Player referenceHub2 in Exiled.API.Features.Player.List)
						{
							if (referenceHub2.Role == RoleType.Scp096)
							{
								referenceHub2.Position = player32.Position;
								break;
							}
						}
						break;
					}
					break;
				case 37:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>杀手dd！-事件：复活一个dd杀手</color>");
					foreach (Exiled.API.Features.Player player33 in Exiled.API.Features.Player.List)
					{
						if (player33.Role == RoleType.Spectator)
						{
							player33.SetRole(RoleType.ClassD);
							yield return Timing.WaitForSeconds(0.2f);
							player33.AddItem(ItemType.GunCOM15);
							player33.AddItem(ItemType.SCP207);
							player33.AddItem(ItemType.SCP268);
							player33.AddItem(ItemType.Adrenaline);
							player33.AddItem(ItemType.KeycardGuard);
							break;
						}
					}
					break;
				case 38:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>畅通无阻！-事件：服务器全部门开启</color>");
					foreach (Door door3 in Exiled.API.Features.Map.Doors)
					{
						door3.isOpen = true;
					}
					break;
				case 39:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>寸步难行！-事件：服务器全部门关闭并锁住10s</color>");
					Log.Info("随机事件测试");
					foreach (Door door in Exiled.API.Features.Map.Doors)
					{
						door.isOpen = false;
						door.locked = true;
					}
					yield return Timing.WaitForSeconds(10f);

					foreach (Door door4 in Exiled.API.Features.Map.Doors)
					{
						door4.locked = false;
					}
					break;
				case 40:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>爷不吓人了！-事件：650恢复伤害 但是只有5点</color>");
					scp650noxiaren = true;
					break;
				case 41:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>乌拉！-事件：九尾狐和混沌每人获得10HP和一瓶伏特加</color>");
					foreach(Player player in Player.List)
					{
						player.AddItem(ItemType.SCP207);
						player.Health += 10;
					}
					break;
				case 42:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>SCP的噩梦！-事件：所有人获得1颗雷1颗闪光弹</color>");
					foreach (Player player in Player.List)
					{
						player.AddItem(ItemType.GrenadeFlash);
						player.AddItem(ItemType.GrenadeFrag);
					}
					break;
				case 43:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>基金会的剥削！-事件：九尾狐血量上限变为50</color>");
					foreach (Player player in Player.List)
					{
						if(player.Team == Team.MTF)
						{
							player.MaxHealth = 50;
						}
					}
					break;
				case 44:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>对DD毫无兴趣的老头！-事件：无法以献祭的手段收容SCP-106</color>");
					scp106donotliked = true;
					break;
				case 45:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>核弹生锈了！-事件：核弹在180秒内无法启动</color>");
					hdsx = true;
					Coroutines.Add(Timing.RunCoroutine(Hdsx()));
					break;
				case 46:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>常回家看看！-事件：SCP集体回出生点</color>");
					foreach(Player player in Player.List)
					{
						if(player.Team == Team.SCP&& player.Role != RoleType.Scp0492)
						{
							player.Position = Map.GetRandomSpawnPoint(player.Role);
						}
					}
					break;
				case 47:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>基金会欠电费了！-事件：黑天喽</color>");
					Coroutines.Add(Timing.RunCoroutine(Gd()));
					Coroutines.Add(Timing.RunCoroutine(Gd2()));
					break;
				case 48:
					Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>大家慢慢走！-事件：slowly</color>");
					Coroutines.Add(Timing.RunCoroutine(Slowly()));
					break;
				default:
					break;
			}
			if (!Dio1)
			{
				try
				{
					foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
					{
						if (player3.Role == RoleType.Spectator)
						{
							Dio = player3;
							Dio1 = true;
							string diotaici = "你还记得你吃过多少块面包吗？";
							switch (new System.Random().Next(1, 5))
							{
								case 1:
									diotaici = "我真是High到不行啊！";
									break;
								case 2:
									diotaici = "吃我压路机啊！";
									break;
								case 3:
									diotaici = "你还记得你吃过多少块面包吗？";
									break;
								case 4:
									diotaici = "JOJO，我不想再做人了！";
									break;
								default:
									break;
							}
							Exiled.API.Features.Map.Broadcast(10, "<color=#BB1444>Dio:</color>\n<color=lime>" + diotaici + "</color>");
							if (Dio != null)
							{
								Dio.SetRole(RoleType.Tutorial);
								Dio.Position = RoleType.ChaosInsurgency.GetRandomSpawnPoint();
								Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(Dio, 500)));
								Dio.AddItem(ItemType.Flashlight);
								Dio.AddItem(ItemType.GunE11SR);
								Dio.AddItem(ItemType.MicroHID);
								Dio.AddItem(ItemType.MicroHID);
								Dio.Ammo[(int)AmmoType.Nato556] = 400;
								Dio.Ammo[(int)AmmoType.Nato762] = 400;
								Dio.Ammo[(int)AmmoType.Nato9] = 400;
								Dio.AddItem(ItemType.KeycardNTFCommander);
								Dio.ClearBroadcasts();
								Dio.Broadcast(6, "<color=red>ko no dio da</color>\n<color=yellow>丢下手电筒使用时间停止</color>");
								Setrank_new("Dio", "red", Dio);
								Dio2.Add(Dio.UserId);
								Coroutines.Add(Timing.RunCoroutine(Diotp()));
							}
							break;
						}
					}
				}
				catch
				{
					Log.Info("Dio错误");
				}

			}

		}
		public void OnRoundStart()
		{
			Exiled.Events.Handlers.Warhead.Detonated += OnWarheadDetonation;
			Exiled.Events.Handlers.Warhead.Stopping += ONWarheadCancelled;
			Exiled.Events.Handlers.Player.Hurting += OnPlayerHurt;
			Exiled.Events.Handlers.Player.Left += OnPlayerLeave;
			Exiled.Events.Handlers.Player.Dying += OnDying;

			player_list = new List<Exiled.API.Features.Player>();
			foreach (Exiled.API.Features.Player p in Exiled.API.Features.Player.List)
			{
				if (!p.IsHost)
				{
					player_list.Add(p);
				}
			}
			Coroutines.Add(Timing.RunCoroutine(SecondCounter5()));
			Coroutines.Add(Timing.RunCoroutine(SecondCounter18()));
			Coroutines.Add(Timing.RunCoroutine(SecondCounter21()));
			Coroutines.Add(Timing.RunCoroutine(GuanZhanYouXi()));
			Coroutines.Add(Timing.RunCoroutine(SecondCounter20()));
			Coroutines.Add(Timing.RunCoroutine(SetNineFox()));
			Coroutines.Add(Timing.RunCoroutine(RenWuFenPei()));
			if (int222 >= 50)
			{
				int222 = 50;
			}
			for(int xunhuan = 0; xunhuan <15;xunhuan++)
			{
				Pickup pickup = PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Painkillers, 9999f, RoleType.Scp096.GetRandomSpawnPoint(), Quaternion.identity, 0, 0, 0);
				scp330.Add(pickup);
			}
			PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.GunCOM15, 9999f, RoleType.Scp173.GetRandomSpawnPoint(), Quaternion.identity, 0, 0, 0);
			starttimer = true;
			Exiled.API.Features.Map.Broadcast(5, "<color=lime>插件版本" + DateTime.Today.ToString() + "bate4</color> <color=yellow>理解万岁</color>");
			GameObject[] array = GameObject.FindGameObjectsWithTag("Door");
			foreach (GameObject door in array)
			{
				if (new System.Random().Next(1, 12) == 5)
				{
					Vector3 pos = new Vector3(door.transform.position.x, door.transform.position.y + 2f, door.transform.position.z);
					PlayerManager.localPlayer.GetComponent<Inventory>().SetPickup(ItemType.Coin, 0f, pos, Quaternion.identity, 0, 0, 0);
					time2++;
				}
			}
			Exiled.API.Features.Map.Broadcast(10, "<color=lime>本局已生成</color>" + time2 + "<color=lime>个幸运硬币</color>\n 你能找到吗awa？");
			Exiled.API.Features.Map.Broadcast(1, "<color=red>让我看看 哪个小可爱这么幸运 获得幸运玩家呢？</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>让我看看 哪个小可爱这么幸运 获得幸运玩家呢？</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=lime>让我看看 哪个小可爱这么幸运 获得幸运玩家呢？</color>");
			foreach (Exiled.API.Features.Player item2 in Exiled.API.Features.Player.List)
			{
				xywj = item2;
				xywjid = xywj.UserId;
			}
			

			Exiled.API.Features.Map.Broadcast(2, "<color=lime>↓↓↓↓本回合幸运玩家↓↓↓↓</color>\n<color=lime>" + xywj.Nickname + "</color>\n<color=red>你可以按~自选人物了</color>");
			Exiled.API.Features.Map.Broadcast(2, "<color=lime>↓↓↓↓本回合幸运玩家↓↓↓↓</color>\n<color=red>" + xywj.Nickname + "</color>\n<color=red>你可以按~自选人物了</color>");
			Exiled.API.Features.Map.Broadcast(2, "<color=lime>↓↓↓↓本回合幸运玩家↓↓↓↓</color>\n<color=green>" + xywj.Nickname + "</color>\n<color=red>你可以按~自选人物了</color>");
			Coroutines.Add(Timing.RunCoroutine(Xywjsx()));
			xywj.SendConsoleMessage(".s173 变为173\n.s106 变为106\n.sD 变为D级\n.sS 变为科学家\n.sG 变为保安\n.s96选择当96\n注意这会清除你的特殊人物", "green");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66FFFF>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66FFCC>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF99>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF66>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF33>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF00>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66CCFF>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#66CCCC>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFFFF>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFFCC>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF99>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF66>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF33>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			Exiled.API.Features.Map.Broadcast(1, "<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF00>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>");
			int num = 0;
			num = Player.List.Count();
			if (num < 3)
			{
				die = true;
				Log.Info("玩家不足三人,SCP999无法刷新");
			}
			else
			{
				scp999yes = true;
				scp49jyes = true;
			}
			times = 0;
			coldwait233 = false;
			starttimer = true;
			roundstart = true;
			deadtime = true;
			Exiled.API.Features.Map.Broadcast(5, "<color=yellow>回合结束后如果您出现 服务器重启中0% 请点击esc 点击快速重连</color>");
			Exiled.API.Features.Map.Broadcast(10, "<color=#FF0000>警告:</color>站点发生收容失效,Alpha弹头协议将会摧毁此站点\n请在30分钟内遏制重新收容所有SCP项目");
			Exiled.API.Features.Map.Broadcast(2, "<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#9400D3>.tx</color>即可进入<color=#9400D3>投降模式</color>");
			Exiled.API.Features.Map.Broadcast(2, "<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#FFFF33>.tx</color>即可进入<color=#9400D3>投降模式</color>");
			Exiled.API.Features.Map.Broadcast(2, "<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#66FF33>.tx</color>即可进入<color=#9400D3>投降模式</color>");
			Exiled.API.Features.Map.Broadcast(2, "<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#00CCFF>.tx</color>即可进入<color=#9400D3>投降模式</color>");
			Exiled.API.Features.Map.Broadcast(2, "<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#FF9900>.tx</color>即可进入<color=#9400D3>投降模式</color>");
			Coroutines.Add(Timing.RunCoroutine(ChopperThread()));
		}

		public void End()
		{
			gdyes = false;
			第一次.Clear();
			第二次.Clear();
			Baba.Clear();
			Baba1.Clear();
			scp106donotliked = false;
			scp330hurt.Clear();
			scp330pickup.Clear();
			scp330.Clear();
			qingjiegongnum = 0;
			pmdon = false;
			Exiled.Events.Handlers.Player.Shooting -= OnShoot;
			Exiled.Events.Handlers.Player.Hurting -= OnPlayerHurt;
			Exiled.Events.Handlers.Player.Left -= OnPlayerLeave;
			Exiled.Events.Handlers.Player.Dying -= OnDying;
			scp650noxiaren = false;
			scp3108playerid = 0;
			sjtz1 = false;
			sjtz2 = false;
			sbxd.Clear();
			dfzgc = false;
			timesbxd = 0;
			lbvyes = false;
			lbv = null;
			lbvid = 0;
			dq = false;
			g = 0;
			hdjjs = null;
			hdjjsid = 0;
			时间 = "";
			地点 = "";
			人物 = "";
			事件 = "";
			句子 = "";
			缺少 = "";
			timestop = 0;
			timesjw = 0;
			scp49j = null;
			scp49jid = 0;
			Gears博士id = 0;
			Gears博士 = null;
			zybuse = false;
			fkyyshuachu = false;
			fkyyz = null;
			fkyyzid = 0;
			fkyyzyes = false;
			bindljf = false;
			bindtys = false;
			bindjzsj = false;
			scp79 = false;
			scp550lv = 0;
			tssl = 0;
			mz = null;
			mzid = 0;
			mzyes = false;
			scp035yes = false;
			xitonghedan = false;
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
			Timing.KillCoroutines(Coroutines2);
			Coroutines2.Clear();
			Timing.KillCoroutines(Coroutines3);
			Coroutines3.Clear();
			scp999yes = false;
			scp = null;
			die = true;
			start = false;
			scp_999.Clear();
			card = 0;
			s = 0;
			d = 0;
			KillerID = 0;
			PlayerID = 0;
			Guardnum = 0;
			deadtimer = 0;
			waring1 = 0;
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
			Exiled.API.Features.Map.Broadcast(5, "<color=yellow>GG 游戏结束 \n 现在可以打队友了</color>");
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
			Guardnum = 0;
			deadtimer = 0;
			waring1 = 0;
			Dio = null;
			Dio1 = false;
			Dio2.Clear();
			xywj = null;
			xywjid = null;
			bpb = false;
			bpb2.Clear();
			scp2818id = 0;
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
			sjqx = false;
			yshkq = false;
			bhsx = false;
			scp1577pick = false;
			scp1577id = 0;
			scp1577pos = new Vector3();
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
			D9341zb = default(Vector3);
			jntm = false;
			starttimer = false;
			scp2006 = null;
			scp2006a.Clear();
			scp2006id = 0;
			deadtimer = 0;
			scpqblid2 = 0;
			scpqbl = null;
			scpqblid = null;
		}

		public void OnRoundEnd(RoundEndedEventArgs ev)
		{
			foreach (Exiled.API.Features.Player p in Exiled.API.Features.Player.List)
			{
				if (!p.IsHost && player_list.Contains(p))
				{
					string a = addPoint(p, "完成回合奖励", 30);
					if (a == "true")
					{
						p.Broadcast(4, Red("个人通知：") + "完成回合奖励30积分");
					}
				}
			}
			End();
		}

		private IEnumerator<float> nodify_badeg(Exiled.API.Features.Player player, badge p)
		{
			yield return Timing.WaitForSeconds(5f);
			player.RankName = p.Text;
			player.RankColor = p.Color;
		}

		private IEnumerator<float> nodify_badeg2(Exiled.API.Features.Player player, badge p)
		{
			yield return Timing.WaitForSeconds(5f);
			if (p.Role == 1)
			{
				UserGroup userGroup2 = player.Group = ServerStatic.GetPermissionsHandler().GetUserGroup("owner@steam");
				Exiled.API.Features.Map.ClearBroadcasts();
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFFCC>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF99>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF66>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF33>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFCCFF>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFCCCC>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFCC99>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF99FF>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF99CC>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF9999>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF9966>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
			}
			else if (p.Role == 2)
			{
				UserGroup userGroup = player.Group = ServerStatic.GetPermissionsHandler().GetUserGroup("admin@steam");
				Exiled.API.Features.Map.ClearBroadcasts();
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFFCC>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF99>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF66>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF33>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF00>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFCCFF>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFCCCC>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FFCC99>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF99FF>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF99CC>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF9999>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
				Exiled.API.Features.Map.Broadcast(1, "<color=#FF9966>" + player.Nickname + "激活管理权限 请各位进行监督</color>");
			}
			player.RankName = p.Text;
			player.RankColor = p.Color;
		}

		public void OnPlayerJoin(JoinedEventArgs ev)
		{
			string a = playerJoin(ev.Player);
			if (a != "true")
			{
				Coroutines.Add(Timing.RunCoroutine(kick_player(ev.Player, a)));
			}
			if (ev.Player.UserId == "76561198407952020@steam" || ev.Player.UserId == "76561198197721054@steam" || ev.Player.UserId == "76561198385564103@steam" || ev.Player.UserId == "76561198816705835@steam" || ev.Player.UserId == "76561198369468432@steam" || ev.Player.UserId == "76561198997348090@steam" || ev.Player.UserId == "76561198893112896@steam" || ev.Player.UserId == "76561198441344563@steam" || ev.Player.UserId == "76561199027737454@steam" || ev.Player.UserId == "76561198377975833@steam")
			{
				Timing.KillCoroutines(Coroutines2);
				Coroutines2.Clear();
				Coroutines2.Add(Timing.RunCoroutine(SecondCounter17()));
			}
			ev.Player.Broadcast(10, Red("个人通知：") + "本服开启积分插件，按 ~ 打开控制台输入  .shop 查看");
			try
			{
				Dictionary<string, string> param = new Dictionary<string, string>();
				param.Add("userid", ev.Player.UserId);
				string b = Get(url + "GetBadge", param);
				List<badge> model = new List<badge>();
				model = JsonConvert.DeserializeObject<List<badge>>(b);
				if (model.Count >= 1)
				{
					Coroutines.Add(Timing.RunCoroutine(nodify_badeg(ev.Player, model[0])));
				}
			}
			catch
			{
			}
			switch (ev.Player.UserId)
			{
				case "76561199027737454@steam":
					Exiled.API.Features.Map.Broadcast(1, "<color=#33FFFF>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33FFCC>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33FF99>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33FF33>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33FF00>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33CCFF>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33CCCC>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33CC99>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33CC66>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#33CC33>啊，这个名为" + ev.Player.Nickname + "的男人来到了这个服务器! </color>");
					break;
				case "76561198377975833@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=green>" + ev.Player.Nickname + "日常献祭十年寿命换scp! </color>");
					break;
				case "76561198369468432@steam":
					Exiled.API.Features.Map.Broadcast(2, "<color=#6699FF>发出高价回收的声音:50包邮!</color>");
					Exiled.API.Features.Map.Broadcast(2, "<color=#FF0033>发出高价回收的声音:50包邮!</color>");
					Exiled.API.Features.Map.Broadcast(2, "<color=#FFFF00>发出高价回收的声音:50包邮!</color>");
					break;
				case "76561198893112896@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=yellow>砸哇路多，DIO用『世界』暂停了时间并且加入了服务器</color>");
					break;
				case "76561198385564103@steam":
					Exiled.API.Features.Map.Broadcast(1, "<color=#33FFFF>" + ev.Player.Nickname + ":我来装逼了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF6633>" + ev.Player.Nickname + ":我来装逼了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#00FF33>" + ev.Player.Nickname + ":我来装逼了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#666699>" + ev.Player.Nickname + ":我来装逼了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#00FFCC>" + ev.Player.Nickname + ":我来装逼了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#CC99FF>" + ev.Player.Nickname + ":我来装逼了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FFFFFF>" + ev.Player.Nickname + ":我来装逼了</color>");
					break;
				case "76561198997348090@steam":
					Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF66>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#CCFF00>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF6633>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF3300>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#66FF00>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#6666FF>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF0033>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#66CCFF>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>");
					break;
				case "76561198145812844@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=#66FF00>[注意！老阴比]</color>" + ev.Player.Nickname + "<color=#FFFF00>进入游戏，各位注意自己的菊花</color>");
					break;
				case "76561198401019684@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=#66FF00>[注意！49痴汉]</color>" + ev.Player.Nickname + "<color=#FFFF00>进入游戏</color>");
					break;
				case "76561198441344563@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=#66FF00>[全服最帅的人到达战场]</color>" + ev.Player.Nickname + "<color=#FFFF00>进入游戏</color>");
					break;
				case "76561198816705835@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=#66FF00>[全服最菜的大佬]</color>" + ev.Player.Nickname + "<color=#FFFF00>进入游戏</color>");
					break;
				case "76561198149835838@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=red>[SCP079保护协会会长]</color>" + ev.Player.Nickname + "<color=#red>进入游戏</color>");
					break;
				case "76561198425823494@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=#66FF00>[全服最帅的人到达战场]</color>" + ev.Player.Nickname + "<color=#FFFF00>进入游戏</color>");
					break;
				case "76561198389200613@steam":
					Exiled.API.Features.Map.Broadcast(8, "<color=#66FF00>[假服主]</color>" + ev.Player.Nickname + "<color=#FFFF00>进入服务器</color>");
					break;
				case "76561198407952020@stem":
					Exiled.API.Features.Map.Broadcast(1, "<color=#FFFF66>"+ev.Player.Nickname+"爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#CCFF00>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF6633>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF3300>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#66FF00>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#6666FF>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#FF0033>" + ev.Player.Nickname + "爷回来了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#66CCFF>" + ev.Player.Nickname + "爷回来了</color>");
					break;

			}
			string name = ev.Player.Nickname;
			if (!player233.Contains(ev.Player))
			{
				player233.Add(ev.Player);
			}
			playernum = Exiled.API.Features.Player.List.Count();
			object[] objArray1 = new object[5]
			{
				"<color=#FFD700>[",
				name,
				"]</color>，欢迎你加入本服务器\n当前人数:<color=#00FF00>[",
				playernum,
				"/35]</color>\n+本服插件:<color=#00FFFF>很多打不下</color>+"
			};
			ev.Player.Broadcast(5, string.Concat(objArray1));
			ev.Player.Broadcast(5, "<color=yellow>[提示]</color>\n<color=lime>如果你想获得玩家编号\n按~开启控制台，在控制台输入.list获取玩家编号</color>");
			ev.Player.Broadcast(10, "<color=#BB1444>如果你看到这条消息证明随机事件插件已经在运行</color>\n<color=#FFFF00>如有破坏游戏体验等问题请在群内支出qwq</color>");
			switch (new System.Random().Next(1, 11))
			{
				case 1:
					ev.Player.Broadcast(5, "<color=#FF3300>[SCP038]</color>\n<color=#FFFF00>万象树在012房间可以复制物品qwq</color>");
					break;
				case 2:
					ev.Player.Broadcast(5, "<color=#FF3300>[通知]</color>\n<color=#FFFF00>插件介绍还在咕咕咕</color>");
					break;
				case 3:
					ev.Player.Broadcast(5, "<color=#FF3300>[SCP817]</color>\n<color=#FFFF00>随意人\n150秒变换一次角色</color>");
					break;
				case 4:
					ev.Player.Broadcast(5, "<color=#FF3300>[九尾狐内鬼]</color><color=#FFFF00>\n前120秒无法被九尾伤害 120s后会被九尾狐伤害\n伪装模式无法对九尾狐造成伤害</color>");
					break;
				case 5:
					ev.Player.Broadcast(5, "<color=#FF3300>[SCP999]</color><color=#FFFF00>\n打人为回血对SCP回血量为5对人类回血量为2 玩法提示：\n开局找保安交易板子 去914和成USP可以造成伤害哦(仅限于自卫 不可随意杀人)</color>");
					break;
				case 6:
					ev.Player.Broadcast(5, "<color=#FF3300>[蔡徐坤]</color><color=#FFFF00>\n丢下手电筒可以使用鸡你太美\n玩法提示：开局手电筒留到AB电梯直接踹门逃生</color>");
					break;
				case 7:
					ev.Player.Broadcast(5, "<color=#FF3300>[蔡徐坤]</color><color=#FFFF00>\n丢下手电筒可以使用鸡你太美\n玩法提示：开局手电筒留到AB电梯直接踹门逃生</color>");
					break;
				case 8:
					ev.Player.Broadcast(5, "<color=#FF3300>[提示]</color><color=#FFFF00>\n九尾狐指挥官和混沌指挥官 有特殊功能哦\n玩法提示：可以输入.help查看你的指令</color>");
					break;
				case 9:
					ev.Player.Broadcast(5, "<color=#FF3300>[SCP079]</color><color=#FFFF00>\n开局你可以选择帮助SCP还是人类\n玩法提示：如果不选择则为默认帮助SCP</color>");
					break;
				case 10:
					ev.Player.Broadcast(5, "<color=#FF3300>[SCP181]</color><color=#FFFF00>\n你在老头空间做错路不会死哦\n玩法提示：在老头空间不要走得太深会掉下去</color>");
					break;
				case 11:
					ev.Player.Broadcast(5, "<color=#FF3300>[SCP181]</color><color=#FFFF00>\n你在老头空间做错路不会死哦\n玩法提示：在老头空间不要走得太深会掉下去</color>");
					break;
				default:
					break;
			}
			int num = new System.Random().Next(1, 101);
			if (num <= 20)
			{
				switch (new System.Random().Next(1, 7))
				{
					case 1:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>恩断义绝警告</color>");
						break;
					case 2:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你妈的，为什么</color>");
						break;
					case 3:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你打游戏像蔡徐坤</color>");
						break;
					case 4:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你长得像乔碧萝</color>");
						break;
					case 5:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>哈哈哈弱爆了</color>");
						break;
					default:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>噗太菜了</color>");
						break;
				}
			}
			else if (num >= 21 && num <= 40)
			{
				switch (new System.Random().Next(1, 7))
				{
					case 1:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>两行泪两行泪</color>");
						break;
					case 2:
						{
							object[] objArray2 = new object[5]
							{
						"=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>",
						num,
						"</color>%]\n<color=#FF00FF>喵哈哈哈哈哈哈哈才",
						num,
						"%</color>"
							};
							ev.Player.Broadcast(7, string.Concat(objArray2));
							break;
						}
					case 3:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>LOL一般般啦别伤心美好的人生</color>");
						break;
					default:
						ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>=w= qwq qaq awa AWSL</color>");
						break;
				}
			}
			else if (num >= 41 && num <= 49)
			{
				switch (new System.Random().Next(1, 6))
				{
					case 1:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>告诉你一个秘密,下班的神秘代码复制到迅雷</color>");
						break;
					case 2:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>神秘代码不可能给你的233</color>");
						break;
					default:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>其实50%以下比50%还好相信我!</color>");
						break;
				}
			}
			else if (num == 50)
			{
				switch (new System.Random().Next(1, 6))
				{
					case 1:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>也不差嘛~不过电磁炮可能合不出来哇咔咔</color>");
						break;
					case 2:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>50%是好还是坏呢</color>");
						break;
					case 3:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>改编不是乱编!戏说不是胡说!</color>");
						break;
					case 4:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>改编不是乱编!戏说不是胡说!</color>");
						break;
					default:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>50%...如果加1%会不会变得更强呢?</color>");
						break;
				}
			}
			else if (num >= 51 && num <= 80)
			{
				switch (new System.Random().Next(1, 6))
				{
					case 1:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>我觉得海星</color>");
						break;
					case 2:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>快乐DD每一天</color>");
						break;
					case 3:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>不行啊，太短了满足不了我</color>");
						break;
					case 4:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>不行啊，太短了满足不了我</color>");
						break;
					default:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你看你队友打游戏像蔡徐坤</color>");
						break;
				}
			}
			else if (num >= 80 && num <= 90)
			{
				switch (new System.Random().Next(1, 6))
				{
					case 1:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>妈妈咪耶，欧皇？我先吸掉你欧气为敬!</color>");
						break;
					case 2:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>wdnm你太强了</color>");
						break;
					case 3:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你的欧气已被后台转移到服主身上</color>");
						break;
					case 4:
						ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你的人品今天已经花在本服了,切勿抽卡233!</color>");
						break;
				}
			}
			else if (num == 100)
			{
				if (new System.Random().Next(1, 6) <= 3)
				{
					ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>....不就是100%[才不是羡慕],你可以把这条信息截图给服主秀一波了</color>");
				}
				else
				{
					ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>100%!恭喜你,但是这条信息截图也无效233333</color>");
				}
			}
		}

		public void OnPlayerDeath(DiedEventArgs ev)
		{
			try
			{
				if(ev.Target.Id == hdflzid)
				{
					ev.Target.RankName = "";
					hdflzid = 0;
				}
				if (scp330hurt.Contains(ev.Target.Id))
				{
					scp330hurt.Remove(ev.Target.Id);
				}
				if (ev.Killer.Role != RoleType.None && ev.Killer.Role != RoleType.Spectator && ev.Target.Id != ev.Killer.Id)
				{
					if (ev.Target.Team == Team.SCP && ev.Target.Role != RoleType.Scp0492)
					{
						string a = addPoint(ev.Killer, "杀死scp奖励", 250);
						if (a == "true")
						{
							ev.Killer.Broadcast(4, Red("个人通知：") + "杀死scp奖励250积分");
						}
					}
					else if ((ev.Target.Team == Team.MTF || ev.Target.Role == RoleType.ChaosInsurgency) && (ev.Killer.Role == RoleType.ClassD || ev.Killer.Role == RoleType.Scientist))
					{
						string a2 = addPoint(ev.Killer, "困难击杀奖励", 50);
						if (a2 == "true")
						{
							ev.Killer.Broadcast(4, Red("个人通知：") + "困难击杀奖励50积分");
						}
					}
					else
					{
						string a3 = addPoint(ev.Killer, "普通击杀奖励", 30);
						if (a3 == "true")
						{
							ev.Killer.Broadcast(4, Red("个人通知：") + "普通击杀奖励30积分");
						}
					}
				}
				if (ev.Killer.Role == RoleType.Scp173)
				{
					ev.Killer.IsGodModeEnabled = false;
				}
				if (ev.Target.Id == hdjjsid)
				{
					hdjjs = null;
					hdjjsid = 0;
					Setrank_new("", "white", ev.Target);
					Exiled.Events.Handlers.Player.Shooting -= OnShoot;

				}
				else if (ev.Target.Id == lbvid)
				{
					lbv = null;
					lbvid = 0;
					lbvyes = false;
					Exiled.API.Features.Map.Broadcast(6, "卢本伟：全体起立");
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == tlid)
				{
					tlid = 0;
				}
				else if (ev.Target.Id == scp49jid)
				{
					scp49j = null;
					scp49jid = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP-49-J</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ev.Target.Id == Gears博士id)
				{
					Gears博士id = 0;
					Gears博士 = null;
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == fkyyzid)
				{
					fkyyz = null;
					fkyyzid = 0;
					fkyyzyes = false;
					bindljf = false;
					bindtys = false;
					bindjzsj = false;
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == scp550id)
				{
					Setrank_new("", "white", ev.Target);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP550</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					scp550id = 0;
					scp550yes = false;
					scp550 = null;
					scp550lv = 0;
					tssl = 0;
				}
				else if (ev.Target.Id == mzid)
				{
					mz = null;
					mzid = 0;
					Setrank_new("", "white", ev.Target);
				}
				if (ev.Target.Id == jwhngid)
				{
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>九尾狐内鬼</color>]----\n<color=#FF0000>[已被消灭]</color>\n消灭者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					jwhng = null;
					jwhngwufashanghai = true;
					jwhngyes = false;
					jwhngshuachu = true;
					jwhngid = 0;
				}
				else if (scp_999.Contains(ev.Target.UserId))
				{
					die = true;
					Setrank_new("", "", ev.Target);
					Log.Info("SCP99已死亡");
					scp_999.Clear();
					Exiled.API.Features.Map.Broadcast(10, "----[<color=#32CD32>SCP999</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				if (ev.Target.Id == jwhhkid)
				{
					jwhhkid = 0;
					jwhhk = null;
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == scp073id)
				{
					scp073 = null;
					scp073id = 0;
					Setrank_new("", "white", ev.Target);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP073</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ev.Target.Id == scp076id)
				{
					scp076 = null;
					scp076id = 0;
					scp076yes = false;
					Setrank_new("", "white", ev.Target);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ev.Target.Id == scp005aid)
				{
					scp005aid = 0;
				}
				if (ev.Target.Id == scp457id)
				{
					scp457 = null;
					scp457a = false;
					scp457die = true;
					Setrank_new("", "white", ev.Target);
					scp457id = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP457</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ev.Target.Id == xtdid)
				{
					xtd = null;
					xtdid = 0;
					Setrank_new("", "white", ev.Target);
				}
				else if (qblcq2 && qblcq.Id == ev.Target.Id)
				{
					qblcq2 = false;
					qblcq = null;
				}
				else if (scp682.Contains(ev.Target.UserId))
				{
					scp682.Remove(ev.Target.UserId);
					Setrank_new(" ", "white", ev.Target);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP682</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (scp939id == ev.Target.Id)
				{
					Setrank_new(" ", "white", ev.Target);
					scp939id = 0;
				}
				else if (ev.Target.Id == lbvid)
				{
					lbvid = 0;
					lbvyes = false;
					lbv = null;
					Setrank_new(" ", "white", ev.Target);
				}
				else if (ev.Target.Id == scp914mid)
				{
					scp914m = null;
					scp914mid = 0;
					Setrank_new("", "white", ev.Target);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP914-M</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ev.Target.Id == scpqblid2)
				{
					scpqblid2 = 0;
					Setrank_new("", "white", ev.Target);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP乔碧萝</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ev.Target.Id == scp181id)
				{
					scp181id = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP181</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					Setrank_new("", "white", ev.Target);
				}
				if (ev.Target.Id == scp035id)
				{
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP035</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					scp035 = null;
					scp035id = 0;
					scp035goout = false;
					scp035yes = false;
					Setrank_new("", "white", ev.Target);
					Exiled.Events.Handlers.Player.Dying -= OnDying;

				}
				else if (scp2006a.Contains(ev.Target.UserId))
				{
					scp2006a.Clear();
					scp2006 = null;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP2006</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == cxkid)
				{
					cxkid = 0;
					cxk = null;
					cxkyes = false;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP蔡徐坤</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == scp817id)
				{
					scp817id = 0;
					scp817 = null;
					scp817yes = false;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP817</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					Setrank_new("", "white", ev.Target);
				}
				else if (ev.Target.Id == D9341id)
				{
					if (times >= 5)
					{
						D9341 = null;
						D9341id = 0;
						D9341Item = null;
						D9341yes = false;
						D9341zb = default(Vector3);
						Setrank_new("", "white", ev.Target);
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>D-9341</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				else if (bpb2.Contains(ev.Target.Id))
				{
					bpb = false;
					bpb2.Clear();
					Setrank_new("", "white", ev.Target);
				}
				else if (LLBS233.Contains(ev.Target.Id))
				{
					Exiled.API.Features.Map.Broadcast(5, "<color=#FFFF33>Mr.fish:</color>\n装逼失败");
					LLBS233.Remove(ev.Target.Id);
					Setrank_new("", "white", ev.Target);
				}
				else if (Dio2.Contains(ev.Target.UserId))
				{
					Exiled.API.Features.Map.Broadcast(5, "<color=#FFFF33>Dio:</color>\n装逼失败");
					Dio2.Remove(ev.Target.UserId);
					Dio = null;
					Setrank_new("", "white", ev.Target);
				}
				else if (scp1143id == ev.Target.Id)
				{
					scp1143 = null;
					scp1143id = 0;
					scp1143a = false;
					Setrank_new("", "white", ev.Target);

					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP1143</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
				}
				else if (ylb2.Contains(ev.Target.UserId))
				{
					Setrank_new("", "white", ev.Target);
					ylb = null;
					ylb1 = false;
					ylb2.Clear();
				}
				else if (HDZHG2.Contains(ev.Target.UserId))
				{
					HDZHG2.Remove(ev.Target.UserId);
					Setrank_new("", "white", ev.Target);
				}
				peaple = 0;
				for (int i = 0; i <= 39; i++)
				{
					if (touxiang[i] == ev.Target.Id)
					{
						Log.Info("死亡投降玩家:" + ev.Target.Nickname + " 死于:" + ev.Killer.Nickname + " 作为:" + ev.Killer.Role);
						touxiang[i] = 0;
					}
				}
				ev.Target.Broadcast(7, "<color=lime>快乐老家 欢迎回家</color>");
				KillerID = ev.Killer.Id;
				PlayerID = ev.Target.Id;
				if (scp650yes && ev.Killer.Id == scp650id)
				{
					scp650 = null;
					scp650id = 0;
					scp650yes = false;
					ev.Killer.IsGodModeEnabled = false;
					ev.Killer.Kill();
					ev.Killer.SetRole(RoleType.Spectator);
				}
				if (ev.Target.Role == RoleType.Scp173)
				{
					if (KillerID == PlayerID)
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>");
					}
					else if (ev.Killer.UserId == "76561198366416373@steam")
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[收容成功]</color>\n花生你好弱啊 <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
					else
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				if (ev.Target.Role == RoleType.Scp049)
				{
					s049 = 2;
					if (KillerID == PlayerID)
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP049</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>");
					}
					else
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP049</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				if (ev.Target.Role == RoleType.Scp079)
				{
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP079</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>核爆了</color>");
					Setrank_new("SCP079 - 核爆了", "red", ev.Target);
				}
				if (ev.Target.Role == RoleType.Scp096)
				{
					if (KillerID == PlayerID)
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP096</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>");
					}
					else
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP096</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				if (ev.Target.Role == RoleType.Scp93953)
				{
					if (KillerID == PlayerID)
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP939_53</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>");
					}
					else
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP939_53</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				if (ev.Target.Role == RoleType.Scp93989)
				{
					if (KillerID == PlayerID)
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP939_89</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>");
					}
					else
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP939_89</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				if (ev.Target.Role == RoleType.Scp106)
				{
					if (KillerID == PlayerID)
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP106</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>");
					}
					else
					{
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP106</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.Nickname + "</color>");
					}
				}
				if (!sjqx)
				{
					foreach (Exiled.API.Features.Player player2 in Exiled.API.Features.Player.List)
					{
						if (player2.Team == Team.MTF)
						{
							peaple++;
						}
					}
					if (peaple == 1)
					{
						Exiled.API.Features.Map.Broadcast(5, "<color=red>全村人的希望</color>\n<color=lime>你被强化了快上</color>");
						foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
						{
							if (player.Team == Team.MTF)
							{
								player.Health += 200f;
								player.AddItem(ItemType.SCP500);
								sjqx = true;
							}
						}
					}
				}

				if (ev.Killer.Role == RoleType.Scp049)
				{
					小僵尸id.Add(ev.Target.Id);
					Coroutines.Add(Timing.RunCoroutine(Remove492(ev.Target.Id)));
				}
			}
			catch
			{
			}
		}

		public void OnMedicalItem(UsedMedicalItemEventArgs ev)
		{
			if (ev.Player.UserId == jklid)
			{
				if (ev.Player.Id != scp073id && ev.Player.Id != scp076id && !LLBS233.Contains(ev.Player.Id))
				{
					ev.Player.Health += 500f;
				}
				else
				{
					ev.Player.Health += 250f;
				}
				jklid = null;
			}
			if(ev.Item == ItemType.Medkit)
			{
				ev.Player.AdrenalineHealth = 10;
			}
			try
			{
				if (ev.Item == ItemType.SCP207)
				{
					int num3 = new System.Random().Next(1, 100);
					if (num3 >= 99)
					{
						Exiled.API.Features.Map.Broadcast(5, ev.Player.Nickname + ":这可乐有毒");
						ev.Player.Health -= 40f;
					}
				}
				if(ev.Item == ItemType.Painkillers)
				{
					int num3 = new System.Random().Next(1, 100);
					if (num3 >= 99)
					{
						Exiled.API.Features.Map.Broadcast(5, ev.Player.Nickname + ":这药过期了");
						ev.Player.Health -= 40f;
					}
				}
			}
			catch
			{
				Log.Info("我们可能遇到了一些问题 但是问题不大");
			}
		}

		public void OnTeamRespawn(RespawningTeamEventArgs ev)
		{
			if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
			{
				times2 = 1;
				Coroutines.Add(Timing.RunCoroutine(SetHd(ev.Players)));
			}
			if (ev.NextKnownTeam == SpawnableTeamType.NineTailedFox)
			{
				tiems = 0;
				Coroutines.Add(Timing.RunCoroutine(SetNineFox2(ev.Players)));
				Coroutines.Add(Timing.RunCoroutine(SetNineFox()));

			}

		}
		private IEnumerator<float> SetHd(List<Player> players)
		{
			yield return Timing.WaitForSeconds(2f);
			for (int i = 0; i < players.Count(); i++)
			{
				switch (times2)
				{
					case 1:
						HDZHG = players[i];
						times2 = 2;
						Coroutines.Add(Timing.RunCoroutine(Hhzhgzb()));
						break;
					case 2:
						Exiled.API.Features.Map.Broadcast(6, "SCP1143突破收容");
						scp1143 = players[i];
						Setrank_new("SCP-1143", "red", scp1143);
						scp1143.Broadcast(6, "你是SCP1143 30秒会刷一个雷或闪光弹");
						Coroutines.Add(Timing.RunCoroutine(testHint("scp1143", scp1143)));
						scp1143a = true;
						scp1143id = scp1143.Id;
						Coroutines.Add(Timing.RunCoroutine(Giveboom()));
						times2 = 3;
						break;
					case 3:
						if (!mzyes)
						{
							mz = players[i];
							mzid = mz.Id;
							mzyes = true;
							Coroutines.Add(Timing.RunCoroutine(Mzzb()));
						}
						times2 = 4;
						break;
					case 4:
						hdjjs = players[i];
						hdjjsid = players[i].Id;
						Setrank_new("混沌狙击手", "green", players[i]);
						times2 = 5;
						Coroutines.Add(Timing.RunCoroutine(Hdjjs()));
						Exiled.Events.Handlers.Player.Shooting += OnShoot;
						break;
					case 5:
						hdflzid = players[i].Id;
						players[i].RankName = "混沌分裂者";
						Timing.RunCoroutine(Hdflz());
						times2 = 6;
						break;
					default:
						break;
				}
			}
		}
		private IEnumerator<float> Hdflz()
		{
			yield return Timing.WaitForSeconds(1f);
			Player hdflz = Player.Get(hdflzid);
			hdflz.ClearInventory();
			hdflz.Health = 100;
			yield return Timing.WaitForSeconds(4f);
			hdflz.AddItem(ItemType.GunProject90);
			hdflz.AddItem(ItemType.GunUSP);
			hdflz.AddItem(ItemType.KeycardNTFCommander);
			hdflz.AddItem(ItemType.Medkit);
			hdflz.AddItem(ItemType.GunLogicer);

		}
		private IEnumerator<float> SetNineFox2(List<Player> players)
		{
			yield return Timing.WaitForSeconds(3f);
			foreach (Player player in players)
			{
				if(player.Role == RoleType.NtfCadet)
				{
					tiems++;

					switch (tiems)
					{
						case 1:
							mrfish = player;
							Setrank_new("Mr.Fish", "yellow", mrfish);
							Exiled.API.Features.Map.Broadcast(10, "<color=#FF0000>Mr.Fish:</color>你们太菜了看我把SCP都收容了");
							LLBS233.Add(mrfish.Id);
							Coroutines.Add(Timing.RunCoroutine(Mrfishzb()));
							break;
						case 2:
							if (!ylb1)
							{
								ylb1 = true;
								Setrank_new("九尾医疗兵", "yellow", player);
								player.Broadcast(5, "<color=#FF0000>你是九尾狐医疗兵</color>:在你周围的人会回血，捡起对讲机和闪光弹可以变成血包");
								ylb = player;
								ylb2.Add(ylb.UserId);
								Coroutines.Add(Timing.RunCoroutine(testHint("jwhylb", player)));
							}
							break;
						case 3:
							if (!scp073a)
							{
								scp073 = player;
								scp073a = true;
								scp073id = scp073.Id;
								Setrank_new("SCP-073", "red", player);
								player.Broadcast(5, "<color=#FF0000>你是九尾狐SCP-073</color>\n<color=lime>如果SCP攻击你 只有10点伤害 且反伤50 枪械攻击伤害为1且反伤5</color>");
								Coroutines.Add(Timing.RunCoroutine(testHint("scp073", scp073)));
								Coroutines.Add(Timing.RunCoroutine(Scp073zb()));
							}
							break;
						case 4:
							if (!bpb)
							{
								bpb = true;
								bpb2.Add(player.Id);
								Setrank_new("九尾狐爆破兵", "red", player);
								player.Broadcast(5, "<color=red>你是九尾狐爆破兵</color>:捡起对讲机和闪光弹可以变成手雷");
								Coroutines.Add(Timing.RunCoroutine(testHint("jwhbpb", player)));
							}
							break;
						case 5:
							if (Player.Get(jwhhkid) == null)
							{
								jwhhk = player;
								jwhhkid = jwhhk.Id;
								Setrank_new("九尾狐黑客", "red", jwhhk);
								jwhhk.Broadcast(5, "<color=lime>你是九尾狐黑客</color>:输入.hk可以黑入实验室");
							}
							break;
						case 6:
							if (!jwhngshuachu)
							{
								jwhng = player;
								jwhngid = jwhng.Id;
								jwhngwufashanghai = true;
								jwhngyes = true;
								Coroutines.Add(Timing.RunCoroutine(Jwhngwufashanghai()));
								Coroutines.Add(Timing.RunCoroutine(Jwhngitem()));
							}
							break;
						case 7:
							if (!scp550shuachu)
							{
								scp550 = player;
								scp550id = scp550.Id;
								Coroutines.Add(Timing.RunCoroutine(Scp550item()));
								scp550yes = true;
								scp550shuachu = true;
								scp550lv = 0;
								scp550.SetRole(RoleType.Tutorial);
								tssl = 0;
								Coroutines.Add(Timing.RunCoroutine(SecondCounter27()));
							}
							break;
						default:
							break;
					}
				}
			}
		}
		private IEnumerator<float> Ljfsx()
		{
			yield return Timing.WaitForSeconds(10f);
			ljfwj.Clear();
			ljfuse = false;
		}

		private IEnumerator<float> Lxsx()
		{
			yield return Timing.WaitForSeconds(10f);
			lxyes = false;
		}

		private IEnumerator<float> Jzsjsx()
		{
			yield return Timing.WaitForSeconds(5f);
			jzsjuse = false;
		}

		private IEnumerator<float> Rhdsx()
		{
			yield return Timing.WaitForSeconds(60f);
			rhdyes = false;
		}

		private IEnumerator<float> Rhd()
		{
			while (true)
			{
				fkyyz.Broadcast(3, "距离" + Vector3.Distance(fkyyz.Position, rhdzzwj.Position));
				if (!rhdyes)
				{
					break;
				}
				yield return Timing.WaitForSeconds(3f);
			}
		}

		private IEnumerator<float> Tyssx()
		{
			yield return Timing.WaitForSeconds(5f);
			tysuse = false;
		}

		private IEnumerator<float> sendtxtitem()
		{
			yield return Timing.WaitForSeconds(1f);
			string temp = "<pos=-100%><size=30><color=#F3F>嘤嘤嘤服务器公屏聊天系统</color>\n" + sendtxt + "\n" + sendtxt2 + "\n" + sendtxt3?.ToString() + "\n" + sendtxt4?.ToString() + "\n" + sendtxt5?.ToString() + "\n" + sendtxt6?.ToString() + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
			foreach (Exiled.API.Features.Player player2 in Exiled.API.Features.Player.List)
			{
				player2.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
				{
					new StringHintParameter("")
				}));
			}
			yield return Timing.WaitForSeconds(1f);
			foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
			{
				player3.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
				{
					new StringHintParameter("")
				}));
			}
			yield return Timing.WaitForSeconds(1f);
			foreach (Exiled.API.Features.Player player4 in Exiled.API.Features.Player.List)
			{
				player4.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
				{
					new StringHintParameter("")
				}));
			}
			yield return Timing.WaitForSeconds(1f);
			foreach (Exiled.API.Features.Player player5 in Exiled.API.Features.Player.List)
			{
				player5.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
				{
					new StringHintParameter("")
				}));
			}
			yield return Timing.WaitForSeconds(1f);
			foreach (Exiled.API.Features.Player player6 in Exiled.API.Features.Player.List)
			{
				player6.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
				{
					new StringHintParameter("")
				}));
			}
			yield return Timing.WaitForSeconds(1f);
			foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
			{
				player.ReferenceHub.hints.Show(new TextHint(temp, new HintParameter[1]
				{
					new StringHintParameter("")
				}));
			}
		}

		public void OnDying(DyingEventArgs ev)
		{
			if (ev.Killer.Id == scp035id)
			{
				if(ev.Target.Team != Team.SCP)
				{
					scp035.ReferenceHub.characterClassManager.SetClassIDAdv(ev.Target.Role, true);
					Coroutines.Add(Timing.RunCoroutine(SecondCounter24()));
				}
			}
		}

		public void OnConsoleCommand(SendingConsoleCommandEventArgs ev)
		{
			int num = 0;
			int num2 = 0;
			if (ev.Name == "send")
			{
				sendtxt6 = sendtxt5;
				sendtxt5 = sendtxt4;
				sendtxt4 = sendtxt3;
				sendtxt3 = sendtxt2;
				sendtxt2 = sendtxt;
				sendtxt = "[" + ev.Player.Role.ToString() + "]" + ev.Player.Nickname + ":" + ev.Arguments[0];
				Coroutines.Add(Timing.RunCoroutine(sendtxtitem()));
			}
			if (ev.Name == "admin")
			{
				try
				{
					Dictionary<string, string> param = new Dictionary<string, string>();
					param.Add("userid", ev.Player.UserId);
					string b = Get(url + "GetBadge", param);
					List<badge> model = new List<badge>();
					model = JsonConvert.DeserializeObject<List<badge>>(b);
					if (model.Count >= 1)
					{
						Coroutines.Add(Timing.RunCoroutine(nodify_badeg2(ev.Player, model[0])));
					}
				}
				catch
				{
				}
			}
			try
			{
				if (ev.Name == "shop")
				{
					ev.ReturnMessage = "\n1.输入.show查看商品\n2.输入.me查看当前积分\n3.输入.de查看积分积分详情（最近10条）";
				}
				else if (ev.Name == "show")
				{
					List<shop> items = showItems();
					string temp = "\n输入 .buy 编号 购买\n";
					foreach (shop p in items)
					{
						temp = ((!(p.Name == "9999")) ? (temp + p.Name + ". " + p.Nickname + "----" + p.Point + "积分\n") : (temp + p.Name + ". " + p.Nickname + "----" + p.Point + "积分(输入.pr 查看奖池和概率)\n"));
					}
					ev.ReturnMessage = temp;
				}
				else if (ev.Name == "me")
				{
					ev.ReturnMessage = "当前积分：" + myPoint(ev.Player);
				}
				else if (ev.Name == "pr")
				{
					List<jackpot> prizes = showPrize();
					string temp2 = "\n输入 .buy 9999 抽奖\n";
					foreach (jackpot p2 in prizes)
					{
						temp2 = temp2 + p2.Nickname + " 概率：" + p2.Probability * 100f + "%\n";
					}
					ev.ReturnMessage = temp2;
				}
				else if (ev.Name == "de")
				{
					List<detail> data = showDetail(ev.Player);
					string temp3 = "\n";
					foreach (detail p3 in data)
					{
						temp3 = temp3 + p3.Remarks + "  " + p3.Point + " " + p3.Time + "\n";
					}
					ev.ReturnMessage = temp3;
				}
				else if (ev.Name == "buy" && ev.Name == "buy")
				{
					if (ev.Player.Inventory.items.Count == 8)
					{
						ev.ReturnMessage = "背包无多余位置，购买失败";
					}
					else
					{
						string nowPoint = myPoint(ev.Player);
						List<shop> items2 = showItems();
						foreach (shop p4 in items2)
						{
							if (ev.Arguments[0] == p4.Name && p4.Name != "9999")
							{
								if (int.Parse(nowPoint) >= p4.Point)
								{
									string res = usePoint(ev.Player, "购买" + p4.Nickname, p4.Point);
									if (res == "true")
									{
										ev.Player.AddItem((ItemType)int.Parse(p4.Name));
										ev.ReturnMessage = "购买成功：" + p4.Nickname;
									}
								}
								else
								{
									ev.ReturnMessage = "积分不足，购买失败";
								}
								break;
							}
							if (!(ev.Arguments[0] == p4.Name) || !(p4.Name == "9999"))
							{
								continue;
							}
							List<jackpot> prizes2 = showPrize();
							if (int.Parse(nowPoint) >= p4.Point)
							{
								string res2 = usePoint(ev.Player, "购买" + p4.Nickname, p4.Point);
								if (!(res2 == "true"))
								{
									break;
								}
								System.Random rd = new System.Random();
								double random_num = rd.NextDouble();
								double temp4 = 0.0;
								foreach (jackpot pr in prizes2)
								{
									if (random_num >= temp4 && random_num < temp4 + (double)pr.Probability)
									{
										if (pr.Name == "8888" || pr.Name == "9999")
										{
											usePoint(ev.Player, "抽到了" + pr.Nickname, 0);
											ev.ReturnMessage = "恭喜你，抽到" + pr.Nickname + "链接：https://pan.baidu.com/s/1_m1_cdHsONaxSwnFuXMyaQ 提取码：xncp";
										}
										else
										{
											ev.Player.AddItem((ItemType)int.Parse(pr.Name));
											ev.ReturnMessage = "恭喜你，抽到" + pr.Nickname;
										}
										break;
									}
									temp4 += (double)pr.Probability;
								}
							}
							else
							{
								ev.ReturnMessage = "积分不足，购买失败";
							}
							break;
						}
					}
				}
			}
			catch (Exception)
			{
				Log.Info("null");
			}
			if (ev.Name.Contains("badappledonotuse"))
			{
				Coroutines.Add(Timing.RunCoroutine(Badapple("txt")));
			}
			if (ev.Name.Contains("xiangjiaojundonotuse"))
			{
				Coroutines.Add(Timing.RunCoroutine(Badapple("xiangjiaojuntxt")));
			}
			if (ev.Name.Contains("cxkdonotuse"))
			{
				Coroutines.Add(Timing.RunCoroutine(Badapple("cxktxt")));
			}
			if (ev.Name.Contains("jlck"))
			{
				时间 = "";
				地点 = "";
				人物 = "";
				事件 = "";
				句子 = "";
				缺少 = "";
			}
			if (ev.Name.Contains("jl"))
			{
				if ((时间 + "").Length == 0)
				{
					try
					{
						时间 = ev.Arguments[0];
					}
					catch
					{
						Log.Info("nope");
					}
				}
				else if ((地点 + "").Length == 0)
				{
					try
					{
						地点 = ev.Arguments[0];
					}
					catch
					{
						Log.Info("nope");
					}
				}
				else if ((人物 + "").Length == 0)
				{
					try
					{
						人物 = ev.Arguments[0];
					}
					catch
					{
						Log.Info("nope");
					}
				}
				else if ((事件 + "").Length == 0)
				{
					try
					{
						事件 = ev.Arguments[0];
					}
					catch
					{
						Log.Info("nope");
					}
				}
				foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
				{
					if (referenceHub.Role == RoleType.Spectator)
					{
						句子 = 时间 + 地点 + 人物 + 事件;
						if ((时间 + "").Length == 0)
						{
							缺少 = "时间 输入.jl 内容补充内容";
						}
						else if ((地点 + "").Length == 0)
						{
							缺少 = "地点 输入.jl 内容补充内容";
						}
						else if ((人物 + "").Length == 0)
						{
							缺少 = "人物 输入.jl 内容补充内容";
						}
						else if ((事件 + "").Length == 0)
						{
							缺少 = "事件 输入.jl 内容补充内容";
						}
						else
						{
							缺少 = "输入.jlck开启下一回合";
						}
						referenceHub.Broadcast(5, "当前句子" + 句子 + "\n当前缺少" + 缺少);
					}
				}
			}
			if (!jwhngwufashanghai && !bscd && ev.Player.Id == jwhngid && ev.Name.Contains("wz"))
			{
				item = ev.Player.Inventory.items;
				health = ev.Player.Health;
				if (ev.Player.Role == RoleType.ChaosInsurgency)
				{
					ev.Player.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfCadet, true);
				}
				else if (ev.Player.Role == RoleType.NtfCadet)
				{
					ev.Player.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.ChaosInsurgency, true);
				}
				Coroutines.Add(Timing.RunCoroutine(SecondCounter25()));
			}
			if (ev.Player.Id == fkyyzid && ev.Player.Role == RoleType.Tutorial)
			{
				if (ev.Name.Contains("help"))
				{
					ev.Player.SendConsoleMessage("你当前有" + fkyyzcardint + "张符卡", "green");
					ev.Player.SendConsoleMessage("此人物为测试阶段可能含有很多bug", "green");
					ev.Player.SendConsoleMessage("「灵击符」输入.ljf使用效果周围30m人无法移动和攻击10s中 你也无法攻击但是可以移动\n输入.bindljf则可以在背包生成\n输入.debindljf即可取消绑定", "green");
					ev.Player.SendConsoleMessage("「静止时计」输入.jzsj时间停止5s 你也无法攻击但是可以移动\n输入.bindjzsj则可以在背包生成\n输入.debindjzsj即可取消绑定", "green");
					ev.Player.SendConsoleMessage("「替身娃娃」输入.tsww 可以获得护盾 别问我为什么没有绑定功能233", "green");
					ev.Player.SendConsoleMessage("「特别定制的太阳伞」输入.tys 可以获得5s钟抗性和反伤\n输入.bindtys在背包生成一个大黄卡\n输入.debindtys即可取消绑定", "green");
					ev.Player.SendConsoleMessage("「人魂灯」输入.rhd [玩家编号]\n玩家编号可以通过.list获取\n效果：被选择的人的位置会对你显示", "green");
					ev.Player.SendConsoleMessage("「左扇」输入.zs 降低自身攻击力获取高防御30s(未做完请勿使用）", "green");
					ev.Player.SendConsoleMessage("「伊吹瓢」输入.ycp 获取两张符卡(未做完请勿使用)", "green");
					ev.Player.SendConsoleMessage("「天狗团扇」输入.tgts 获取移速提升", "green");
					ev.Player.SendConsoleMessage("「龙玉之羽衣」输入.yy 在使用后10s如果你被攻击 攻击者被定身 且你获得无敌(未做完请勿使用)", "green");
					ev.Player.SendConsoleMessage("「病气平御护符」输入.bqpyhf 在使用后 恢复随机100-150血量", "green");
					ev.Player.SendConsoleMessage("「龙星」输入.lx 在使用后 短时间增加自身攻击力", "green");
					ev.Player.SendConsoleMessage("「制御棒」输入.zyb 在使用后 永久增加自身攻击力 降低防御力", "green");
				}
				if (ev.Name.Contains("bindljf"))
				{
					if (ev.Player.Inventory.items.Count == 8)
					{
						ev.ReturnMessage = "背包无多余位置，绑定失败";
					}
					else
					{
						ev.Player.AddItem(ItemType.KeycardJanitor);
						ev.Player.SendConsoleMessage("「灵击符」绑定完成 丢下清洁工卡即可使用", "green");
						bindljf = true;
					}
				}
				if (ev.Name.Contains("debindljf"))
				{
					bindljf = false;
					ev.Player.SendConsoleMessage("「灵击符」解除绑定成功", "green");
				}
				if (ev.Name.Contains("bindjzsj"))
				{
					if (ev.Player.Inventory.items.Count == 8)
					{
						ev.ReturnMessage = "背包无多余位置，绑定失败";
					}
					else
					{
						ev.Player.AddItem(ItemType.KeycardScientist);
						ev.Player.SendConsoleMessage("「静止时计」绑定完成 丢下科学家卡即可使用", "green");
						bindjzsj = true;
					}
				}
				if (ev.Name.Contains("debindljf"))
				{
					bindjzsj = false;
					ev.Player.SendConsoleMessage("「静止时计」解除绑定成功", "green");
				}
				if (ev.Name.Contains("bindtys"))
				{
					if (ev.Player.Inventory.items.Count == 8)
					{
						ev.ReturnMessage = "背包无多余位置，绑定失败";
					}
					else
					{
						ev.Player.AddItem(ItemType.KeycardScientistMajor);
						ev.Player.SendConsoleMessage("「特别定制的太阳伞」绑定完成 丢下大科学家卡即可使用", "green");
						bindtys = true;
					}
				}
				if (ev.Name.Contains("debindtys"))
				{
					bindtys = false;
					ev.Player.SendConsoleMessage("「特别定制的太阳伞」解除绑定成功", "green");
				}
				if (fkyyzcardint > 0)
				{
					if (ev.Name.Contains("ljf"))
					{
						fkyyzcardint--;
						foreach (Exiled.API.Features.Player player10 in Exiled.API.Features.Player.List)
						{
							if (Vector3.Distance(player10.Position, ev.Player.Position) <= 30)
							{
								ljfwj.Add(player10);
								ljfuse = true;
								player10.Broadcast(5, "「灵击符」十秒内无法行动");
								Coroutines.Add(Timing.RunCoroutine(Ljfsx()));
								Coroutines3.Clear();
							}
						}
						ljfwj.Remove(ev.Player);
						Timing.KillCoroutines(Coroutines3);
						Coroutines3.Clear();
						Coroutines3.Add(Timing.RunCoroutine(SecondCounter3()));

					}
					if (ev.Name.Contains("jzsj"))
					{
						Coroutines.Add(Timing.RunCoroutine(Jzsjsx()));
						jzsjuse = true;
						Exiled.API.Features.Map.Broadcast(5, "「静止时计」效果时间停止5s");
						fkyyzcardint--;
						Timing.KillCoroutines(Coroutines3);
						Coroutines3.Clear();
						Coroutines3.Add(Timing.RunCoroutine(SecondCounter3()));
					}
					if (ev.Name.Contains("tsww"))
					{
						ev.Player.AdrenalineHealth = 200f;
						fkyyzcardint--;
					}
					if (ev.Name.Contains("tys"))
					{
						Coroutines.Add(Timing.RunCoroutine(Tyssx()));
						ev.Player.Broadcast(5, "你已获得5s钟反伤");
						tysuse = true;
						fkyyzcardint--;
					}
					if (ev.Name.Contains("bqpyhf"))
					{
						int num7 = new System.Random().Next(100, 150);
						ev.Player.Health += num7;
						ev.Player.SendConsoleMessage("「病气平御护符」使用成功回血" + num7, "green");
						fkyyzcardint--;
					}
					if (ev.Name.Contains("rhd"))
					{
						foreach (Exiled.API.Features.Player referenceHub2 in Exiled.API.Features.Player.List)
						{
							try
							{
								if (referenceHub2.Id == int.Parse(ev.Arguments[0]))
								{
									ev.Player.SendConsoleMessage("「人魂灯」使用成功追踪玩家" + referenceHub2.Nickname, "green");
									rhdzzwj = referenceHub2;
									rhdyes = true;
									fkyyzcardint--;
									Coroutines.Add(Timing.RunCoroutine(Rhd()));
									Coroutines.Add(Timing.RunCoroutine(Rhdsx()));
								}
							}
							catch
							{
								ev.Player.SendConsoleMessage("「人魂灯」使用失败 来自插件抛出异常 可能是没有填写玩家id", "green");
							}
						}
					}
					if (ev.Name.Contains("zyb"))
					{
						ev.Player.SendConsoleMessage("「制御棒」使用成功", "green");
						fkyyzcardint--;
						zybuse = true;
					}
					if (ev.Name.Contains("tgts"))
					{
						ev.Player.ReferenceHub.playerEffectsController.EnableEffect<CustomPlayerEffects.Scp207>(400,true);
						ev.Player.SendConsoleMessage("「天狗团扇」使用成功", "green");
						fkyyzcardint--;
					}
					if (ev.Name.Contains("lx"))
					{
						Coroutines.Add(Timing.RunCoroutine(Lxsx()));
						lxyes = true;
						ev.Player.SendConsoleMessage("「龙星」使用成功", "green");
						fkyyzcardint--;
					}
				}
			}
			if (ev.Player.Id == tuolikadianid && ev.Name.Contains("tlkd"))
			{
				ev.Player.Position = ev.Player.Role.GetRandomSpawnPoint();
				tuolikadianid = 0;
			}
			foreach (Exiled.API.Features.Player player6 in Exiled.API.Features.Player.List)
			{
				if (player6.Role == RoleType.ChaosInsurgency)
				{
					num++;
				}
				if (player6.Team == Team.MTF)
				{
					num2++;
				}
			}
			if (ev.Player.Role == RoleType.Scp079 && !choise)
			{
				if (ev.Name.Contains("scp"))
				{
					choise = true;
					foreach (Exiled.API.Features.Player player7 in Exiled.API.Features.Player.List)
					{
						if (player7.Role == RoleType.Scp079)
						{
							Setrank_new("SCP079 - 帮助SCP", "aqua", player7);
						}
					}
					scp79 = true;
					Exiled.API.Features.Map.Broadcast(10, "<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>人类感受恐惧吧 本局SCP079选择帮助SCP</color>\n<color=aqua>SCP不会受到电网伤害(人形scp除外)</color>");
				}
				if (ev.Name.Contains("h"))
				{
					foreach (Exiled.API.Features.Player player5 in Exiled.API.Features.Player.List)
					{
						if (player5.Role == RoleType.Scp079)
						{
							Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   帮助人类", "aqua", player5);
						}
					}
					h = true;
					Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   帮助人类", "aqua", ev.Player);
					choise = true;
					Exiled.API.Features.Map.Broadcast(10, "<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>SCP没想到吧我是25仔 本局SCP079选择帮助人类</color>\n<color=aqua>人类不会受到电网伤害</color>");
					foreach (Exiled.API.Features.Player p5 in Exiled.API.Features.Player.List)
					{
						if (p5.Team == Team.SCP)
						{
							if (p5.Role != RoleType.Scp106 && p5.Role != RoleType.Scp096)
							{
								p5.Health += 1000f;
							}
							if (p5.Role == RoleType.Scp096)
							{
								p5.Health += 500f;
							}
						}
					}
				}
			}
			if (ev.Name.Contains("steal") && ev.Player.Id == xtd.Id && !stealcd)
			{
				stealcd = true;
				switch (new System.Random().Next(1, 10))
				{
					case 1:
						ev.Player.AddItem(ItemType.Coin);
						break;
					case 2:
						ev.Player.AddItem(ItemType.KeycardNTFCommander);
						break;
					case 3:
						ev.Player.AddItem(ItemType.GunE11SR);
						break;
					case 4:
						ev.Player.AddItem(ItemType.GunUSP);
						break;
					case 5:
						ev.Player.AddItem(ItemType.SCP500);
						break;
					case 6:
						ev.Player.AddItem(ItemType.KeycardO5);
						break;
					default:
						ev.Player.SendConsoleMessage("什么都没偷到", "green");
						break;
				}
			}
			if (ev.Player.UserId == xywjid)
			{
				if (ev.Name.Contains("s173"))
				{
					xywj.Role = RoleType.Scp173;
					xywj = null;
					xywjid = null;
				}
				if (ev.Name.Contains("s106"))
				{
					xywj.SetRole(RoleType.Scp106);
					xywj = null;
					xywjid = null;
				}
				if (ev.Name.Contains("sD"))
				{
					xywj.SetRole(RoleType.ClassD);
					xywj = null;
					xywjid = null;
				}
				if (ev.Name.Contains("sS"))
				{
					xywj.SetRole(RoleType.Scientist);
					xywj = null;
					xywjid = null;
				}
				if (ev.Name.Contains("sG"))
				{
					xywj = null;
					xywjid = null;
					xywj.Kill();
					xywj.SetRole(RoleType.FacilityGuard);
				}
				if (ev.Name.Contains("s96"))
				{
					xywj = null;
					xywjid = null;
					xywj.Kill();
					xywj.SetRole(RoleType.Scp096);
				}
				if (scp650yes && ev.Player.Id == scp650id)
				{
					scp650 = null;
					scp650id = 0;
					scp650yes = false;
					Setrank_new("", "white", ev.Player);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>[SCP650]</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>自选人物了</color>");
				}
				if (ev.Player.Id == scp076id)
				{
					scp076 = null;
					scp076id = 0;
					scp076yes = false;
					Setrank_new("", "white", ev.Player);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>自选人物了</color>");
				}
			}
			if (ev.Name.Contains("dk") && hrss)
			{
				jwhhk.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfScientist,true);
				jwhhk.ReferenceHub.playerMovementSync.OverridePosition(hkzb, 0, false);
				hrss = false;
			}
			if (ev.Name.Contains("hk") && jwhhkid == ev.Player.Id && !hrss)
			{
				hrss = true;
				hkzb = ev.Player.Position;
				ev.Player.SetRole(RoleType.Scp079);
				ev.Player.Broadcast(10, "<color=lime>输入.dk退出黑客模式</color>");
				Coroutines.Add(Timing.RunCoroutine(Hkjs()));

			}
			if (ev.Name.Contains("tx") && ev.Player.Id != scp035id && ((ev.Player.Role == RoleType.ClassD && !Dio2.Contains(ev.Player.UserId)) || ev.Player.Role == RoleType.Scientist))
			{
				int playerId = ev.Player.Id;
				if (ev.Player.Role == RoleType.ClassD && num == 0)
				{
					touxiang[round] = playerId;
					ev.Player.Broadcast(10, "<color=#FF00FF>你已经进入投降模式</color>无法取消\n当你逃出的时候<color=#00FF7F>自动变为相反阵营</color>");
					Setrank_new("(" + ev.Player.Id + ") 投降人员", "default", ev.Player);
					round++;
				}
				else if (ev.Player.Role == RoleType.ClassD && num > 0)
				{
					ev.Player.Broadcast(10, "<color=#FF00FF>你无法进入投降模式</color>\n因为场上有<color=#00FF7F>混沌</color>");
				}
				if (ev.Player.Role == RoleType.Scientist && num2 == 0)
				{
					touxiang[round] = playerId;
					ev.Player.Broadcast(10, "<color=#FF00FF>你已经进入投降模式</color>无法取消\n当你逃出的时候<color=#00FF7F>自动变为相反阵营</color>");
					Setrank_new("投降人员", "default", ev.Player);
					round++;
				}
				else if (ev.Player.Role == RoleType.Scientist && num2 > 0)
				{
					ev.Player.Broadcast(10, "<color=#FF00FF>你无法进入投降模式</color>\n因为场上有<color=#00FF7F>MTF</color>");
				}
			}
			if (ev.Name.Contains("pos"))
			{
				Vector3 position = ev.Player.Position;
				object[] objArray1 = new object[5]
				{
					position.x,
					"|",
					position.y,
					"|",
					position.z
				};
				ev.ReturnMessage = string.Concat(objArray1);
			}
			if (ev.Name == "c")
			{
				if (ev.Arguments.Count == 0)
				{
					ev.Player.SendConsoleMessage("请输入内容", "yellow");
				}
				if (ev.Arguments.Count == 1)
				{
					ev.Player.SendConsoleMessage("发送成功", "yellow");
					if (ev.Player.Role == RoleType.Spectator)
					{
						foreach (Exiled.API.Features.Player player4 in Exiled.API.Features.Player.List)
						{
							if (player4.Role == RoleType.Spectator)
							{
								player4.Broadcast(5, "[玩家]" + ev.Player.Nickname + ev.Arguments[0]);
							}
						}
					}
					if (ev.Player.Team == Team.SCP)
					{
						foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
						{
							if (player3.Team == Team.SCP)
							{
								player3.Broadcast(5, "[玩家]" + ev.Player.Nickname + ev.Arguments[0]);
							}
							else if (scp_999.Contains(player3.UserId))
							{
								player3.Broadcast(5, "[玩家]" + ev.Player.Nickname + ev.Arguments[0]);
							}
						}
					}
					if (ev.Player.Team == Team.MTF)
					{
						foreach (Exiled.API.Features.Player player2 in Exiled.API.Features.Player.List)
						{
							if (player2.Team == Team.MTF)
							{
								player2.Broadcast(5, "[玩家]" + ev.Player.Nickname + ev.Arguments[0]);
							}
						}
					}
				}
			}
			if (ev.Name == "xfuckyou")
			{
				Vector3 vector3 = new Vector3(ev.Player.Position.x + 3f, ev.Player.Position.y, ev.Player.Position.z);
				ev.Player.Position = vector3;
			}
			if (ev.Name == "yfuckyou")
			{
				Vector3 vector2 = new Vector3(ev.Player.Position.x, ev.Player.Position.y + 3f, ev.Player.Position.z);
				ev.Player.Position = vector2;
			}
			if (ev.Name == "zfuckyou")
			{
				Vector3 vector = new Vector3(ev.Player.Position.x, ev.Player.Position.y, ev.Player.Position.z + 3f);
				ev.Player.Position = vector;
			}
			if (ev.Player.Role == RoleType.NtfCommander && ev.Name == "bc")
			{
				if (ev.Arguments.Count == 0)
				{
					ev.Player.SendConsoleMessage("\n指挥鱼命令使用教程:\n\n.bc [内容]\n\n内容会全图发送给予所有九尾鱼阵营玩家", "yellow");
				}
				else if (ev.Arguments.Count == 1 && !coldbc)
				{
					coldbc = true;
					foreach (Exiled.API.Features.Player player13 in Exiled.API.Features.Player.List)
					{
						if (player13.Team == Team.MTF)
						{
							player13.ClearBroadcasts();
							player13.Broadcast(6, "<color=#4682B4>[来自指挥鱼的信息]</color>\n" + ev.Arguments[0]);
						}
					}
				}
			}
			if (ev.Name == "f")
			{
				if (qblcq2)
				{
					qblcq2 = false;
				}
				else if (Vector3.Distance(scpqbl3.Position,ev.Player.Position) <= 4)
				{
					Exiled.API.Features.Map.Broadcast(5, ev.Player.Nickname + "已经登上坦克");
					qblcq = ev.Player;
					qblcq2 = true;
					Timing.KillCoroutines(Coroutines3);
					Coroutines3.Clear();
					Coroutines3.Add(Timing.RunCoroutine(SecondCounter3()));
				}
			}
			if (ev.Player.Role == RoleType.NtfCommander && ev.Name == "tb")
			{
				if (ev.Arguments.Count == 0)
				{
					ev.Player.SendConsoleMessage("\n提拔使用教程:\n\n.tb [编号]\n\n可以将九尾狐新兵提拔为 九尾狐士官 300秒1个人", "yellow");
				}
				else if (ev.Arguments.Count == 1 && !coldtb)
				{
					coldtb = true;
					int num5 = int.Parse(ev.Arguments[0]);
					foreach (Exiled.API.Features.Player player9 in Exiled.API.Features.Player.List)
					{
						if (player9.Id == num5 && player9.Role == RoleType.NtfCadet)
						{
							ev.Player.SendConsoleMessage("提拔成功", "yellow");
							player9.SetRole(RoleType.NtfLieutenant);
							player9.Broadcast(5, "你表现得超级nice被指挥官提拔了");
						}
					}
				}
			}
			if (HDZHG2.Contains(ev.Player.UserId) && ev.Name == "bc")
			{
				if (ev.Arguments.Count == 0)
				{
					ev.Player.SendConsoleMessage("\n混沌指挥鱼命令使用教程:\n\n.bc [内容]\n\n内容会全图发送给予所有九尾鱼阵营玩家", "yellow");
				}
				else if (ev.Arguments.Count == 1)
				{
					foreach (Exiled.API.Features.Player player12 in Exiled.API.Features.Player.List)
					{
						if (player12.Team == Team.CHI)
						{
							player12.ClearBroadcasts();
							player12.Broadcast(6, "<color=#4682B4>[来自混沌指挥鱼的信息]</color>\n" + ev.Arguments[0]);
						}
					}
				}
			}
			if (ev.Name == "list" && ev.Arguments.Count == 0)
			{
				ev.Player.SendConsoleMessage("全部id", "yellow");
				foreach (Exiled.API.Features.Player player11 in Exiled.API.Features.Player.List)
				{
					ev.Player.SendConsoleMessage("玩家名字:" + player11.Nickname + "     玩家编号:" + player11.Id, "yellow");
				}
				ev.Player.SendConsoleMessage("获取完毕", "yellow");
			}
			if (HDZHG2.Contains(ev.Player.UserId) && ev.Name == "cz")
			{
				if (ev.Arguments.Count == 0)
				{
					ev.Player.SendConsoleMessage("重新做人指令帮助 可以让指定的混沌变成DD重新来过", "yellow");
				}
				if (ev.Arguments.Count == 1)
				{
					int num4 = int.Parse(ev.Arguments[0]);
					foreach (Exiled.API.Features.Player player8 in Exiled.API.Features.Player.List)
					{
						if (!kccd && player8.Id == num4 && player8.Team == Team.CHI && !HDZHG2.Contains(player8.UserId))
						{
							ev.Player.SendConsoleMessage("执行完成", "yellow");
							player8.SetRole(RoleType.ClassD);
							player8.Broadcast(5, "你因为惹怒了混沌指挥官被开除成DD");
							kccd = true;
						}
					}
				}
			}
			if (ev.Name == "help" && ev.Arguments.Count == 0)
			{
				if (HDZHG2.Contains(ev.Player.UserId))
				{
					ev.Player.SendConsoleMessage("混沌指挥官使用教程\n.bc + [内容]把内容广播给全体混沌\n.cz +[玩家编号]把玩家开除成D级", "green");
				}
				if (ev.Player.Role == RoleType.NtfCommander)
				{
					ev.Player.SendConsoleMessage("九尾狐指挥官使用教程\n.bc + [内容]把内容广播给全体九尾狐\n.tb +[玩家编号]把玩家升级", "green");
				}
			}
		}

		public void OnPocketDimDeath(FailingEscapePocketDimensionEventArgs ev)
		{
			try
			{
				if (scp_999.Contains(ev.Player.UserId))
				{
					ev.IsAllowed = false;
				}
			}
			catch
			{
			}
			if (ev.Player.Id == scp457id)
			{
				ev.IsAllowed = false;
			}
			if (ev.Player.Id == scp181id)
			{
				ev.IsAllowed = false;
			}
		}

		public void OnCheckEscape(EscapingEventArgs ev)
		{
			if (!LLBS233.Contains(ev.Player.Id) && ev.Player.Id != scp035id)
			{
				string a = addPoint(ev.Player, "逃离设施奖励", 300);
				if (a == "true")
				{
					ev.Player.Broadcast(4, Red("个人通知：") + "逃离设施奖励300积分");
				}
			}
			if (scp035id == ev.Player.Id)
			{
				ev.IsAllowed = false;
				Exiled.API.Features.Map.Broadcast(10, "<color=#red>警告！！！[SCP-035]已经逃出设施 请尽快消灭</color>");
				scp035goout = true;
				Coroutines.Add(Timing.RunCoroutine(SecondCounter19()));
			}
			if (LLBS233.Contains(ev.Player.Id))
			{
				ev.IsAllowed = false;
			}
			foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
			{
				if (player.Role == RoleType.ChaosInsurgency)
				{
					chaos++;
				}
				if (player.Team == Team.MTF)
				{
					mtf++;
				}
			}
			Log.Info("混沌人数:" + chaos);
			Log.Info("MTF人数:" + mtf);
			if (touxiang.Contains(ev.Player.Id))
			{
				Log.Info("投降玩家是:" + ev.Player.Nickname);
				if (ev.Player.Role == RoleType.ClassD && chaos == 0)
				{
					ev.IsAllowed = false;
					Log.Info("玩家即将变为NTF学员");
					Log.Info("玩家名:" + ev.Player.Nickname);
					ev.Player.Role = RoleType.NtfCadet;
				}
				if (ev.Player.Role == RoleType.Scientist && mtf == 0)
				{
					ev.IsAllowed = false;
					Log.Info("玩家即将变为混沌");
					Log.Info("玩家名:" + ev.Player.Nickname);
					ev.Player.Role = RoleType.ChaosInsurgency;
				}
				for (int i = 0; i <= 100; i++)
				{
					if (touxiang[i] == ev.Player.Id)
					{
						touxiang[i] = 0;
					}
				}
			}
			chaos = 0;
			mtf = 0;
			return;
		}

		public void OnDoorInteract(InteractingDoorEventArgs ev)
		{
			if(scp330hurt.Contains(ev.Player.Id))
			{
				ev.IsAllowed = false;
			}
			if (dfzgc)
			{
				ev.Door.DestroyDoor(true);
			}
			System.Random num111 = new System.Random();
			if (!dq && num111.Next(1, 500) >= 499)
			{
				System.Random random = new System.Random();
				Door door = Exiled.API.Features.Map.Doors[random.Next(Exiled.API.Features.Map.Doors.Count)];
				ev.Player.Position = new Vector3(door.transform.position.x, door.transform.position.y + 1.5f, door.transform.position.z);
				ev.Player.ClearBroadcasts();
				ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>你碰到了随机门以被传送\n如果你被卡住 使用指令.tlkd </color>");
				tuolikadianid = ev.Player.Id;
			}
			if (bhsx && new System.Random().Next(0, 100) >= 97)
			{
				ev.IsAllowed = false;
			}
			if (ev.Player.Role == RoleType.Scp096 && new System.Random().Next(1, 100) <= 3)
			{
				ev.IsAllowed = true;
			}
			if ((ev.Door.DoorName == "NUKE_SURFACE" && ev.Player.CurrentItem.id == ItemType.KeycardNTFCommander) || ev.Player.CurrentItem.id == ItemType.KeycardChaosInsurgency)
			{
				ev.IsAllowed = true;
			}
			if (bscp79 && ev.Player.Team == Team.SCP && new System.Random().Next(0, 100) >= 95)
			{
				ev.IsAllowed = true;
			}
			if (scp005 && ev.Player.Id == scp005aid)
			{
				ev.IsAllowed = true;
			}
			if (scp682.Contains(ev.Player.UserId) && ev.Player.Role == RoleType.Scp93989 && new System.Random().Next(0, 100) >= 98)
			{
				ev.Door.DestroyDoor(b: true);
				ev.IsAllowed = true;
			}
			if (ev.Player.Id == scp181id)
			{
				System.Random random2 = new System.Random();
				if (random2.Next(1, 10) == 9)
				{
					ev.IsAllowed = true;
				}
			}
			if (ev.Player.Id == cxkid)
			{
				System.Random random3 = new System.Random();
				if (random3.Next(1, 5) == 2)
				{
					ev.IsAllowed = false;
					ev.Player.Broadcast(3, "你太菜了导致门没打开");
				}
				if (jntm)
				{
					ev.IsAllowed = true;
					ev.Door.DestroyDoor(b: true);
					ev.Player.ClearBroadcasts();
					ev.Player.Broadcast(4, "你发动鸡你太美门都看不下去了");
				}
			}
			if (ev.Player.Role == RoleType.FacilityGuard && ev.Door.DoorName == "INTERCOM")
			{
				ev.Door.DestroyDoor(b: true);
				Exiled.API.Features.Map.Broadcast(5, "暴躁老哥" + ev.Player.Nickname + "一jio踹开了广播室");
			}
			if (ev.Player.Team == Team.MTF && ev.Door.DoorName == "INTERCOM")
			{
				ev.Door.DestroyDoor(b: true);
				Exiled.API.Features.Map.Broadcast(5, "暴躁老哥" + ev.Player.Nickname + "一jio踹开了广播室");
			}
			if (Dio2.Contains(ev.Player.UserId) && sjtz1)
			{
				ev.Door.DestroyDoor(true);
				ev.IsAllowed = true;
			}
			if (!Dio2.Contains(ev.Player.UserId) && sjtz1)
			{
				ev.IsAllowed = false;
			}

		}

		public void OnScp106Contain(ContainingEventArgs ev)
		{
			Exiled.API.Features.Map.ClearBroadcasts();
			if(scp106donotliked)
			{
				ev.IsAllowed = false;
				ev.Player.Broadcast(5, "我不馋你身子");
			}
			if (ev.IsAllowed)
			{
				Exiled.API.Features.Map.Broadcast(50, "<color=red>广播</color>:(因大腿骨粉碎机而痛苦大叫)\n为什么? 为什么!\n呜呜呜呜呜呜呜");
			}
		}

		public void OnGeneratorUnlock(UnlockingGeneratorEventArgs ev)
		{
			if (h)
			{
				ev.IsAllowed = false;
				ev.Player.Broadcast(5, "当前79属于人类阵营");
			}
		}

		public void OnCheckRoundEnd(EndingRoundEventArgs ev)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
			{
				if (player.Team == Team.SCP && player.Id != scp650id)
				{
					num++;
				}
				if (player.Team == Team.CHI)
				{
					num2++;
				}
				if (player.Role == RoleType.Scientist)
				{
					num3++;
				}
				if (player.Role == RoleType.ClassD && player.Id != scp035id)
				{
					num4++;
				}
				if (player.Team == Team.MTF)
				{
					num5++;
				}
				if (h && player.Role == RoleType.Scp079)
				{
					num--;
				}
			}
			if (num4 == 0 && num >= 1 && num5 == 0 && num3 == 0)
			{
				ev.IsRoundEnded = true;
			}
			if (num == 0 && num4 == 0 && num5 >= 1)
			{
				ev.IsRoundEnded = true;
			}
		}

		public void OnDropItem(DroppingItemEventArgs ev)
		{
			try
			{
				if(ev.Item.id == ItemType.Coin)
				{
					if(ev.Player.Id == lbvid)
					{
						int lbvint = new System.Random().Next(1, 100);
						if(lbvint < 50)
						{
							ev.Player.Health = 5;
						}
						if(lbvint>=50 && lbvint <=75)
						{
							ev.Player.AddItem(ItemType.MicroHID);
						}
						if (lbvint > 75 && lbvint <= 80)
						{
							ev.Player.AddItem(ItemType.MicroHID);
							ev.Player.AddItem(ItemType.MicroHID);
						}
						if (lbvint > 80 && lbvint <= 90)
						{
							ev.Player.Health += 120;
						}
						if (lbvint > 90 && lbvint <= 100)
						{
							ev.Player.AddItem(ItemType.SCP500);
						}
					}
				}
				Vector3 room = ev.Player.Position;
				if (ev.Item.id == ItemType.Ammo556 || ev.Item.id == ItemType.Ammo762 || ev.Item.id == ItemType.Ammo9mm || ev.Item.id == ItemType.Radio)
				{
					return;
				}
				Vector3 randomSpawnPoint = RoleType.Scp173.GetRandomSpawnPoint();
				float num = randomSpawnPoint.x + 20f;
				float num2 = randomSpawnPoint.y + 10f;
				float num3 = randomSpawnPoint.z + 20f;
				float num4 = randomSpawnPoint.x - 20f;
				float num5 = randomSpawnPoint.y - 10f;
				float num6 = randomSpawnPoint.z - 20f;
				if (ev.Player.Id != D9341id && ev.Player.Position.x <= num && ev.Player.Position.x >= num4 && ev.Player.Position.y <= num2 && ev.Player.Position.y >= num5 && ev.Player.Position.z <= num3 && ev.Player.Position.z >= num6)
				{
					ev.Player.ClearBroadcasts();
					ev.Player.Broadcast(5, "你尝试将物品放入 <color=yellow>SCP-1162</color> 获得另外一个物品");
					switch (new System.Random().Next(1, 26))
					{
						case 1:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.SCP500);
							break;
						case 2:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Disarmer);
							break;
						case 3:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.GrenadeFlash);
							break;
						case 4:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Flashlight);
							break;
						case 5:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Medkit);
							break;
						case 6:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Radio);
							break;
						case 7:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardJanitor);
							break;
						case 8:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardScientist);
							break;
						case 9:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardSeniorGuard);
							break;
						case 10:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardZoneManager);
							break;
						case 11:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardScientistMajor);
							break;
						case 12:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardGuard);
							break;
						case 13:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.GunCOM15);
							break;
						case 14:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.GunUSP);
							break;
						case 15:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardNTFLieutenant);
							break;
						case 16:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.GrenadeFlash);
							break;
						case 17:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.MicroHID);
							break;
						case 18:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardFacilityManager);
							break;
						case 19:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Ammo556);
							break;
						case 20:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Ammo762);
							break;
						case 21:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.Ammo9mm);
							break;
						case 22:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
							break;
						case 23:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.WeaponManagerTablet);
							break;
						default:
							ev.IsAllowed = false;
							ev.Player.RemoveItem(ev.Item);
							ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
							break;
					}
				}

				if (ev.Player.Id == fkyyzid)
				{
					if (bindljf && ev.Item.id == ItemType.KeycardJanitor)
					{
						ev.IsAllowed = false;
						if (fkyyzcardint > 0)
						{
							fkyyzcardint--;
							foreach (Exiled.API.Features.Player player3 in Exiled.API.Features.Player.List)
							{
								if (Vector3.Distance(player3.Position, ev.Player.Position) <= 30)
								{
									ljfwj.Add(player3);
									ljfuse = true;
									player3.Broadcast(5, "「灵击符」十秒内无法行动");
									Coroutines.Add(Timing.RunCoroutine(Ljfsx()));
									Coroutines3.Clear();
								}
							}
							ljfwj.Remove(ev.Player);
							Timing.KillCoroutines(Coroutines3);
							Coroutines3.Clear();
							Coroutines3.Add(Timing.RunCoroutine(SecondCounter3()));
						}
					}
					if (bindjzsj && ev.Item.id == ItemType.KeycardScientist && fkyyzcardint > 0)
					{
						ev.IsAllowed = false;
						fkyyzcardint--;
						Coroutines.Add(Timing.RunCoroutine(Jzsjsx()));
						jzsjuse = true;
						Exiled.API.Features.Map.Broadcast(5, "「静止时计」效果时间停止5s");
						Timing.KillCoroutines(Coroutines3);
						Coroutines3.Clear();
						Coroutines3.Add(Timing.RunCoroutine(SecondCounter3()));
					}
					if (bindtys && ev.Item.id == ItemType.KeycardScientistMajor && fkyyzcardint > 0)
					{
						ev.IsAllowed = false;
						fkyyzcardint--;
						Coroutines.Add(Timing.RunCoroutine(Tyssx()));
						ev.Player.Broadcast(5, "你已获得5s钟反伤");
						tysuse = true;
					}
				}
				if (!jwhngwufashanghai && !bscd && ev.Player.Id == jwhngid && ev.Item.id == ItemType.GrenadeFlash)
				{
					ev.IsAllowed = false;
					item = ev.Player.Inventory.items;
					health = ev.Player.Health;
					if (ev.Player.Role == RoleType.ChaosInsurgency)
					{
						ev.Player.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfCadet, true);
						ev.Player.ClearInventory();
					}
					else if (ev.Player.Role == RoleType.NtfCadet)
					{
						ev.Player.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.ChaosInsurgency, true);
						ev.Player.ClearInventory();
					}
					Coroutines.Add(Timing.RunCoroutine(SecondCounter25()));
				}
				if (ev.Player.Id == D9341id)
				{
					if (ev.Item.id == ItemType.GrenadeFlash)
					{
						D9341.Broadcast(6, "存档成功");
						ev.IsAllowed = false;
						ev.Player.RemoveItem(ev.Item);
						D9341.AddItem(ItemType.GrenadeFlash);
						D9341Item = D9341.Inventory.items;
						D9341zb = D9341.Position;
						D9341js = D9341.Role;
					}
					if (ev.Item.id == ItemType.Flashlight && times <= 5)
					{
						D9341.ReferenceHub.characterClassManager.SetClassIDAdv(D9341js, true);
						times++;
						D9341.Health = D9341.MaxHealth;
						Timing.RunCoroutine(Tp(D9341, D9341zb));
						D9341.ClearInventory();
						foreach (Inventory.SyncItemInfo syncItemInfo in D9341Item)
						{
							D9341.AddItem(syncItemInfo.id);
						}
					}
				}
				if (scp2006id == ev.Player.Id && ev.Item.id == ItemType.Coin)
				{
					System.Random random = new System.Random();
					Door door = Exiled.API.Features.Map.Doors[random.Next(Exiled.API.Features.Map.Doors.Count)];
					ev.Player.Position = new Vector3(door.transform.position.x, door.transform.position.y + 1.5f, door.transform.position.z);
					ev.Player.ClearBroadcasts();
					ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>你碰到了随机门以被传送\n如果你被卡住 使用指令.tlkd </color>");
					tuolikadianid = ev.Player.Id;
				}
				if (ev.Player.Id == cxkid && ev.Item.id == ItemType.Flashlight)
				{
					jntm = true;
					ev.Player.ClearBroadcasts();
					ev.IsAllowed = false;
					ev.Player.RemoveItem(ev.Item);
					ev.Player.AddItem(ItemType.Coin);
					ev.Player.Broadcast(10, "成功发动鸡你太美时长10秒");
					Coroutines.Add(Timing.RunCoroutine(SecondCounter11()));
				}
				if (room.y <= -1f && room.y >= -7f)
				{
					if (!coldwait233)
					{
						ev.Player.AddItem(ev.Item.id);
						ev.Player.AddItem(ev.Item.id);
						ev.Player.Broadcast(5, "复制成功");
						coldwait233 = true;
					}
					if (coldwait233)
					{
						ev.Player.Broadcast(5, "038:累死我了一会再来呗QAQ");
					}
				}
				if (scp2818pick && ev.Item.id == ItemType.GunCOM15 && scp2818.Id == ev.Player.Id)
				{
					ev.Player.Broadcast(5, "SCP2818已经被扔下");
					scp2818pick = false;
					scp2818id = 0;
					scp2818 = null;
				}
				if (Dio2.Contains(ev.Player.UserId) && ev.Item.id == ItemType.Flashlight && !sjtz2)
				{
					ev.IsAllowed = false;
					ev.Player.RemoveItem(ev.Item);
					ev.Player.AddItem(ItemType.Coin);
					Exiled.API.Features.Map.ClearBroadcasts();
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>「世界」时间停止了流动</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>1s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>2s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>3s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>4s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>5s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>6s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>7s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>8s过去了</color>");
					Exiled.API.Features.Map.Broadcast(1, "<color=#99FF00>9s过去了</color>");
					sjtz1 = true;
					sjtz2 = true;
					Timing.KillCoroutines(Coroutines3);
					Coroutines3.Clear();
					Coroutines3.Add(Timing.RunCoroutine(SecondCounter3()));
					cd = new Thread(CD);
					cd.Start();
				}
			}
			catch
			{
				Log.Info("丢弃物品发生异常");
			}
		}

		public void CD()
		{
			Dio.Health += 120f;
			Thread.Sleep(9000);
			pos1.Clear();
			sjtz1 = false;
			cd.Abort();
		}

		public void OnShoot(ShootingEventArgs ev)
		{
			try
			{
				if (ev.Shooter.Id == scp3108playerid && ev.Shooter.CurrentItem.id == ItemType.GunCOM15)
				{
					ev.Shooter.RemoveItem(ev.Shooter.CurrentItem);
					Exiled.Events.Handlers.Player.Shooting -= OnShoot;
				}
				if (ev.Shooter.Id == hdjjsid && ev.Shooter.CurrentItem.id == ItemType.GunE11SR)
				{
					Coroutines.Add(Timing.RunCoroutine(HdjjsCD()));

				}
				if (ev.Shooter.Id == scp1577id && ev.Shooter.CurrentItem.id == ItemType.GunCOM15)
				{
					scp1577pos = ev.Shooter.Position;
					Coroutines.Add(Timing.RunCoroutine(Scp1577bj()));
					scp1577id = 0;
					Exiled.API.Features.Map.Broadcast(5, "<color=lime>有人召唤了补给坐标" + scp1577pos.x + "|" + scp1577pos.y + "|" + scp1577pos.z + "按~输入.pos可获取你的坐标</color>");
					ev.Shooter.Broadcast(5, "<color=lime>去尽情白给吧qwq</color>");
					Exiled.Events.Handlers.Player.Shooting -= OnShoot;
				}
			}
			catch
			{
				ev.Shooter.Broadcast(5, "发生异常 联系服主");
			}
		}

		public void OnPickupItem(PickingUpItemEventArgs ev)
		{
			if (Baba.Contains(ev.Pickup))
			{
				Baba.Remove(ev.Pickup);
				ev.IsAllowed = false;
				ev.Pickup.Delete();
				int time = new System.Random().Next(1, 100);
				if (time >= 1 && time <= 5)
				{
					ev.Player.Broadcast(5, "一日三餐没烦恼，就吃老八秘制小汉堡，既实惠还管饱");
					ev.Player.Health = ev.Player.MaxHealth;
				}
				if (time >= 6 && time <= 10)
				{
					ev.Player.Broadcast(5, "美食界里我老八，今天吃个哈密瓜，往里倒点臭卤虾，万人称我美食家");
					ev.Player.AddItem(ItemType.GunLogicer);
					ev.Player.AddItem(ItemType.MicroHID);
				}
				if (time >= 11 && time <= 23)
				{
					ev.Player.Broadcast(5, "都说面条吃不饱，就怪配料没放好，臭豆腐腐乳黄瓜丝，迟到嘴里美汁er汁er");
					ev.Player.AddItem(ItemType.SCP207);
					ev.Player.AddItem(ItemType.Adrenaline);
					ev.Player.AdrenalineHealth = 30;
				}
				if (time >= 24 && time <= 38)
				{
					ev.Player.Broadcast(5, "腐乳豆腐拌香蕉，简简单单的夜宵，不管是香还是臭，到我嘴里都是肉");
					ev.Player.AdrenalineHealth = 20;
				}
				if (time >= 39 && time <= 47)
				{
					ev.Player.Broadcast(5, "美食界里我老八，今天吃个大扒鸭，要问扒鸭哪里好，扒鸭屁股是块宝");
					foreach (Player player in Player.List)
					{
						if (player.Role == RoleType.Scp173)
						{
							ev.Player.Position = player.Position;
						}
					}
				}
				if (time >= 48 && time <= 55)
				{
					ev.Player.Broadcast(5, "老铁们啊，尝不到苦辣，永远不知道酸甜，今天老八挑战一把酸甜苦辣咸，奥利给，干了兄弟们！");
					foreach (Player player in Player.List)
					{
						if (player.Team == Team.SCP)
						{
							ev.Player.Position = player.Position;
							break;
						}
					}
				}
				if (time >= 56 && time <= 74)
				{
					ev.Player.Broadcast(5, "不管是香还是臭，到我嘴里都是肉！");
					ev.Player.Health += 30;
					int awa = new System.Random().Next(1, 6);
					switch (awa)
					{
						case 1:
							ev.Player.AddItem(ItemType.Adrenaline);
							break;
						case 2:
							ev.Player.AddItem(ItemType.GunCOM15);
							break;
						case 3:
							ev.Player.AddItem(ItemType.GunE11SR);
							break;
						case 4:
							ev.Player.AddItem(ItemType.GunLogicer);
							break;
						case 5:
							ev.Player.AddItem(ItemType.KeycardFacilityManager);
							break;
					}
				}
				if (time >= 75 && time <= 85)
				{
					ev.Player.Broadcast(5, "俘虏！");
					if (ev.Player.Team == Team.MTF)
					{
						ev.Player.Role = RoleType.ChaosInsurgency;
					}
					if (ev.Player.Team == Team.CHI)
					{
						ev.Player.Role = RoleType.NtfLieutenant;
					}
					if (ev.Player.Role == RoleType.ClassD)
					{
						ev.Player.Role = RoleType.NtfLieutenant;
					}
					if (ev.Player.Role == RoleType.Scientist)
					{
						ev.Player.Role = RoleType.ChaosInsurgency;
					}
				}
				if (time >= 86 && time <= 100)
				{
					ev.Player.Broadcast(5, "美汁er汁er！");
					ev.Player.Health = ev.Player.MaxHealth;
					ev.Player.AddItem(ItemType.SCP207);
					ev.Player.AddItem(ItemType.SCP018);
					ev.Player.AddItem(ItemType.GunLogicer);
					ev.Player.AddItem(ItemType.Adrenaline);
					ev.Player.AddItem(ItemType.KeycardO5);
				}
			}
			if (Baba1.Contains(ev.Pickup))
			{
				if (!第一次.Contains(ev.Player.Id))
				{
					第一次.Add(ev.Player.Id);
					ev.Player.Broadcast(10, "老铁们啊，只有你们想不到的，没有老八做不到的。还是那句话，今天我老八挑战一把吃粑粑。兄弟们，奥利给！干了！");
					ev.Player.Health -= 80;
				}
				else if (第一次.Contains(ev.Player.Id) && !第二次.Contains(ev.Player.Id))
				{
					第二次.Add(ev.Player.Id);
					ev.Player.Broadcast(10, "老铁们啊，虽然不是同一时间，但是同一个厕所。老八我再次挑战一把吃粑粑，奥利给！干了！兄弟们！");
					ev.Player.Health -= 99;
				}
				else if (第二次.Contains(ev.Player.Id))
				{
					ev.Player.Broadcast(10, "老铁们啊，还是那句话，只有你们想不到的，没有老八做不到的。你们不要笑我狼狈不堪，我也可以笑你离开你的父母比我吃屎都难。奥利给！干了！兄弟们！");
					ev.Player.Health -= 999999;
				}
				if (ev.Player.Health <= 0)
				{
					ev.Player.Kill();
					ev.Player.Role = RoleType.Spectator;
				}
			}
			try
			{
				if(scp330.Contains(ev.Pickup))
				{
					if(scp330pickup.Contains(ev.Player.Id))
					{
						ev.Player.Health -= 75;
						ev.Player.Broadcast(5, "<color=red>你感觉手腕传来疼痛</color>");
						scp330hurt.Add(ev.Player.Id);
					}
					else
					{
						scp330pickup.Add(ev.Player.Id);
						ev.Player.Broadcast(5, "你捡了一个SCP330 再捡起一个你会扣血并且无法开门");
					}
				}
				if (ev.Player.Id == hdjjsid && ev.Pickup.ItemId == ItemType.GunE11SR)
				{
					ev.IsAllowed = false;
				}
				if (ylb2.Contains(ev.Player.UserId))
				{
					switch (ev.Pickup.ItemId)
					{
						case ItemType.GrenadeFlash:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.Medkit);
							break;
						case ItemType.Radio:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.Medkit);
							break;
						case ItemType.WeaponManagerTablet:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.Medkit);
							break;
						default:
							break;
					}
				}
				if (bpb2.Contains(ev.Player.Id))
				{
					switch (ev.Pickup.ItemId)
					{
						case ItemType.GrenadeFlash:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.GrenadeFrag);
							break;
						case ItemType.Radio:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.GrenadeFrag);
							break;
						case ItemType.WeaponManagerTablet:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.GrenadeFrag);
							break;
						default:
							break;
					}
				}
				if (a127d && ev.Pickup.ItemId == ItemType.GunUSP && !scp3108pick)
				{
					scp3108playerid = ev.Player.Id;
					scp3108pick = true;
					Exiled.Events.Handlers.Player.Shooting += OnShoot;
					Exiled.API.Features.Map.Broadcast(5, "<color=red>SCP-3108已被捡起被打中的人会强行转换身份</color>");
					ev.Player.Broadcast(5, "<color=lime>你捡起了</color>\n[<color=red>SCP-3108</color>]\n<color=lime>使用本手枪射中人会让他角色变化 你只能开一枪</color>");
				}
				if (ev.Player.Id == scp914mid)
				{
					switch (new System.Random().Next(1, 4))
					{
						case 2:
							switch (ev.Pickup.ItemId)
							{
								case ItemType.KeycardScientist:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardScientistMajor);
									break;
								case ItemType.KeycardJanitor:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardScientist);
									break;
								case ItemType.KeycardNTFLieutenant:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardNTFCommander);
									break;
								case ItemType.KeycardScientistMajor:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
									break;
								case ItemType.KeycardChaosInsurgency:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardO5);
									break;
								case ItemType.KeycardNTFCommander:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardO5);
									break;
								case ItemType.KeycardZoneManager:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
									break;
								case ItemType.KeycardContainmentEngineer:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardFacilityManager);
									break;
								case ItemType.KeycardFacilityManager:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardO5);
									break;
								case ItemType.GunCOM15:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunProject90);
									break;
								case ItemType.GunProject90:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunE11SR);
									break;
								case ItemType.GunE11SR:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunLogicer);
									break;
								case ItemType.GunLogicer:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.MicroHID);
									break;
								case ItemType.Flashlight:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GrenadeFlash);
									break;
								case ItemType.GrenadeFlash:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GrenadeFrag);
									break;
							}
							break;
						case 3:
							switch (ev.Pickup.ItemId)
							{
								case ItemType.KeycardScientistMajor:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardScientist);
									break;
								case ItemType.KeycardScientist:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardJanitor);
									break;
								case ItemType.KeycardNTFCommander:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardNTFLieutenant);
									break;
								case ItemType.KeycardChaosInsurgency:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
									break;
								case ItemType.KeycardContainmentEngineer:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.KeycardZoneManager);
									break;
								case ItemType.GunProject90:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunCOM15);
									break;
								case ItemType.GunE11SR:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunProject90);
									break;
								case ItemType.GunLogicer:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunE11SR);
									break;
								case ItemType.MicroHID:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GunLogicer);
									break;
								case ItemType.GrenadeFlash:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.Flashlight);
									break;
								case ItemType.GrenadeFrag:
									ev.IsAllowed = false;
									ev.Pickup.Delete();
									ev.Player.AddItem(ItemType.GrenadeFlash);
									break;
							}
							break;
					}
				}
				if (ev.Player.Id == scp181id)
				{
					int cardup = new System.Random().Next(1, 100);
					switch (ev.Pickup.ItemId)
					{
						case ItemType.KeycardScientist:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardScientistMajor);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的科学家变成了大科学家卡</color>]");
							}
							break;
						case ItemType.KeycardJanitor:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardScientist);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的清洁工变成了科学家卡</color>]");
							}
							break;
						case ItemType.KeycardNTFLieutenant:
							if (cardup >= 80)
							{
								ev.Player.AddItem(ItemType.KeycardNTFCommander);
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.Broadcast(5, "[<color=red>当当当当你的士官卡变成了指挥官卡</color>]");
							}
							break;
						case ItemType.KeycardScientistMajor:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardFacilityManager);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的大科学家变成了收容工程师卡</color>]");
							}
							break;
						case ItemType.KeycardFacilityManager:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardNTFCommander);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的收容工程师卡变成了指挥官卡</color>]");
							}
							break;
						case ItemType.KeycardNTFCommander:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardO5);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的指挥官卡变成了黑卡</color>]");
							}
							break;
						case ItemType.KeycardContainmentEngineer:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardFacilityManager);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的区域总监卡变成了设施总监卡</color>]");
							}
							break;
						case ItemType.KeycardSeniorGuard:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardNTFLieutenant);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的九尾狐新兵卡变成了九尾狐士官卡</color>]");
							}
							break;
						case ItemType.KeycardGuard:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardSeniorGuard);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的保安卡变成了设施九尾狐新兵卡</color>]");
							}
							break;
						case ItemType.KeycardChaosInsurgency:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.KeycardO5);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的混沌卡变成了设施黑卡</color>]");
							}
							break;
						case ItemType.GunCOM15:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.GunProject90);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的小手枪变成了P90</color>]");
							}
							break;
						case ItemType.GunProject90:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.GunE11SR);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的P90变成了九尾步枪</color>]");
							}
							break;
						case ItemType.GunE11SR:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.GunLogicer);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的九尾步枪变成了大菠萝</color>]");
							}
							break;
						case ItemType.GunLogicer:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.MicroHID);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的大菠萝变成了电磁炮</color>]");
							}
							break;
						case ItemType.GrenadeFlash:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.GrenadeFrag);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的闪光弹变成了手榴弹</color>]");
							}
							break;
						case ItemType.Flashlight:
							if (cardup >= 80)
							{
								ev.IsAllowed = false;
								ev.Pickup.Delete();
								ev.Player.AddItem(ItemType.GrenadeFlash);
								ev.Player.Broadcast(5, "[<color=red>当当当当你的手电筒变成了闪光弹</color>]");
							}
							break;
					}
				}
				if (!scp1577pick && ev.Pickup.ItemId == ItemType.GunCOM15)
				{
					Vector3 scp1577pos2 = RoleType.Scp173.GetRandomSpawnPoint();
					float num2 = scp1577pos2.x + 10f;
					float num3 = scp1577pos2.y + 10f;
					float num4 = scp1577pos2.z + 10f;
					float num5 = scp1577pos2.x - 10f;
					float num6 = scp1577pos2.y - 10f;
					float num7 = scp1577pos2.z - 10f;
					if (ev.Player.Position.x <= num2 && ev.Player.Position.x >= num5 && ev.Player.Position.y <= num3 && ev.Player.Position.y >= num6 && ev.Player.Position.z <= num4 && ev.Player.Position.z >= num7)
					{
						scp1577pick = true;
						scp1577id = ev.Player.Id;
						Exiled.Events.Handlers.Player.Shooting += OnShoot;
						ev.Player.Broadcast(5, "<color=lime>你捡起了 信号枪</color>\n[<color=red>SCP-1577</color>]\n<color=lime>使用本手枪射击可以呼叫空投</color>");
					}
				}
				else if (ev.Pickup.ItemId == ItemType.GunCOM15 && !scp2818pick)
				{
					Exiled.API.Features.Map.Broadcast(5, "SCP-2818已经被" + ev.Player.Nickname + "捡起");
					ev.Player.Broadcast(5, "你捡起了2818 开枪后瞬间死亡伤害1000点");
					scp2818 = ev.Player;
					scp2818id = ev.Player.Id;
					scp2818pick = true;
				}
				if (ev.Pickup.ItemId == ItemType.KeycardJanitor && !scp005)
				{
					scp005aid = ev.Player.Id;
					ev.Player.Broadcast(5, "<color=lime>你捡起了</color>[<color=red>SCP-005</color>]");
					scp005 = true;
				}
				if (ev.Pickup.ItemId == ItemType.GunUSP)
				{
					a127 = false;
				}
				if (ev.Pickup.ItemId == ItemType.Coin)
				{
					switch (new System.Random().Next(1, 13))
					{
						case 1:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.Coin);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[硬币]");
							break;
						case 2:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.MicroHID);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[电磁炮·有电]");
							break;
						case 3:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.GunE11SR);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[九尾步枪]");
							break;
						case 4:
							ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[收容工程师卡]");
							break;
						case 5:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.GrenadeFrag);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[手雷]");
							break;
						case 6:
							ev.Player.AddItem(ItemType.Ammo556);
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[5.56子弹]");
							break;
						case 7:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.GunLogicer);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[大菠萝]");
							break;
						case 8:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.KeycardGuard);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[保安卡]");
							break;
						case 9:
							ev.Player.AddItem(ItemType.Radio);
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[对讲机有电]");
							break;
						case 10:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.KeycardScientist);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[科学家卡]");
							break;
						case 11:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.SCP500);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[科学家卡]");
							break;
						case 12:
							ev.IsAllowed = false;
							ev.Pickup.Delete();
							ev.Player.AddItem(ItemType.Flashlight);
							ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[手电筒]");
							break;
					}
				}
				if (ev.Player.Id == scp457id)
				{
					ev.Pickup.Delete();
				}
				if (!a127c && ev.Pickup.ItemId == ItemType.GunUSP)
				{
					a127c = true;
					a127 = true;
					ev.Player.Broadcast(5, "<color=lime>你捡起了</color>[<color=red>SCP-127</color>]\n<color=lime>当你扔掉或者死亡都SCP-127都会消失</color>");
					Exiled.API.Features.Map.Broadcast(10, "SCP127力量已经出现");
				}
				Vector3 pos2 = ev.Player.Position;
				if (pos2.y > -735f && pos2.y < -730f && !jkl)
				{
					jkl = true;
					jklid = ev.Player.UserId;
					ev.Player.Broadcast(5, "你捡起了SCP-金坷垃使用后恢复500点血");
					Exiled.API.Features.Map.Broadcast(5, "SCP-金坷垃被捡起了");
				}
				if (Dio2.Contains(ev.Player.UserId))
				{
					ev.Pickup.Delete();
				}
			}
			catch
			{
				Log.Info("捡起物品出现异常");
			}
		}

		public void OnPlayerHurt(HurtingEventArgs ev)
		{
			if(ev.Attacker.Id == scp550id||ev.Target.Id == scp550id)
			{
				if(ev.Attacker.Team == Team.SCP || ev.Target.Team == Team.SCP)
				{
					ev.Amount = 0;
				}
			}
			if(ev.Target.Id == scp550id)
			{
				ev.Amount += 15;
			}
			if(ev.Attacker.Id == scp550id)
			{
				ev.Amount -= 5;
			}
			if (ev.Target.Id == D9341id && LLBS233.Contains(ev.Target.Id) && ev.Target.Id == scp035id && ev.DamageType == DamageTypes.Decont)
			{
				ev.Amount = 0f;
			}
			if (ev.Attacker.Id == hdjjsid && ev.DamageType == DamageTypes.E11StandardRifle)
			{
				ev.Amount = 60f;
			}
			if (ev.Target.Id == hdjjsid)
			{
				ev.Amount += ev.Amount;
			}
			if (ev.Target.Id == tlid)
			{
				if (ev.Attacker.Team == Team.SCP && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
				{
					ev.Amount = 20f;
				}
				else if (ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
				{
					ev.Amount = 10f;
				}
			}
			if (ev.Target.Id == scp49jid && xp < 600 && ev.Attacker.Role == RoleType.Scp049)
			{
				ev.Amount = 0f;
			}
			if (lxyes && ev.Attacker.Id == fkyyzid)
			{
				ev.Amount += 10f;
			}
			if (ev.Target.Id == Gears博士id && ev.Attacker != ev.Target)
			{
				if (ev.DamageType == DamageTypes.Falldown)
				{
					ev.Amount = 0f;
				}
				if (ev.DamageType == DamageTypes.Scp173)
				{
					ev.Amount = 50f;
				}
			}
			if (Dio2.Contains(ev.Attacker.UserId)&&(ev.Target.Id != scp650id) && (ev.Attacker.Id != ev.Target.Id) && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
			{
				Dio.Health += 1f;
			}
			if (ev.DamageType == DamageTypes.Tesla && ev.Attacker.Id == ev.Target.Id)
			{
				if (ev.Target.Team == Team.SCP)
				{
					if (scp79)
					{
						ev.Amount = 0f;
					}
				}
				else if (h)
				{
					ev.Amount = 0f;
				}
			}
			if (fkyyzyes)
			{
				if (zybuse)
				{
					if (ev.Target.Id == fkyyzid && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
					{
						ev.Amount += 10f;
					}
					if (ev.Attacker.Id == fkyyzid && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
					{
						ev.Amount += 20f;
					}
				}
				if (tysuse && ev.Target.Id == fkyyzid)
				{
					ev.Amount = 10f;
					ev.Attacker.Health -= 20f;
				}
				if (ljfuse)
				{
					if (ljfwj.Contains(ev.Attacker) && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
					{
						ev.Amount = 0f;
					}
					if (ev.Attacker.Id == fkyyzid && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
					{
						ev.Amount = 0f;
					}
				}
				if (jzsjuse && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
				{
					ev.Amount = 0f;
				}
			}
			if (scp_999.Contains(ev.Target.UserId) && ev.Attacker.Team == Team.SCP)
			{
				ev.Amount = 50f;
			}
			int num = 0;
			int num2 = 0;
			if (ev.Attacker.Id == scp3108playerid && ev.DamageType == DamageTypes.Usp && ev.Target.Id != scp650id && ev.Target.Id != scp457id)
			{
				scp3108playerid = 0;
				scp3108shotatplayerpos = ev.Target.Position;
				switch (new System.Random().Next(1, 17))
				{
					case 1:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scientist, true);
						break;
					case 2:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.ChaosInsurgency, true);
						break;
					case 3:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.FacilityGuard, true);
						break;
					case 4:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfCadet, true);
						break;
					case 5:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfCommander, true);
						break;
					case 6:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfLieutenant, true);
						break;
					case 7:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.NtfScientist, true);
						break;
					case 8:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp0492, true);
						break;
					case 9:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp079, true);
						break;
					case 10:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp106, true);
						break;
					case 11:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp173, true);
						break;
					case 12:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp93953, true);
						break;
					case 13:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp93989, true);
						break;
					case 14:
						ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Tutorial, true);
						break;
				}
				ev.Target.Broadcast(5, "<color=red>你被SCP-3108射击已经转变身份</color>");
			}
			if (ev.Attacker.Id == scp650id && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
			{
				if (!scp650noxiaren)
				{
					ev.Amount = 0f;
				}
				else
				{
					ev.Amount = 5f;
					ev.Attacker.IsGodModeEnabled = false;
				}
			}
			if (ev.Attacker.Role == RoleType.Scp173 && Dio2.Contains(ev.Target.UserId) && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
			{
				ev.Amount = 100f;
			}
			if (ev.Attacker.Team == Team.SCP && ev.Target.Id == scp457id)
			{
				ev.Amount = 0f;
			}
			if (ev.Attacker.Id == scp457id && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker.Role == RoleType.Tutorial && ev.Target.Id != scp457id)
			{
				ev.Amount = 0f;
			}
			if (ev.Attacker.Id == scp939id && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker.Role == RoleType.Scp93953 && ev.Target.Id != scp035id && !LLBS233.Contains(ev.Target.Id))
			{
				ev.Amount = 100f;
			}
			if (ev.Target.Id == cxkid && jntm)
			{
				int num3 = new System.Random().Next(1, 100);
				if (num3 >= 50)
				{
					ev.Amount = 0f;
				}
			}
			if (ev.Target.Id == scp073id && ev.Target.Id != scp650id && ev.Attacker.Team == Team.SCP && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
			{
				ev.Amount = 10f;
				ev.Attacker.Health -= 30f;
			}
			if (ev.Target.Id == scp073id && ev.Attacker.Team != Team.MTF && ev.Attacker.Role != RoleType.Scientist && ev.Attacker.Team != 0 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
			{
				ev.Amount = 3f;
				ev.Attacker.Health -= 5f;
			}
			if (scp682.Contains(ev.Attacker.UserId) && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker.Role == RoleType.Scp93989 && ev.Target.Id != scp035id && !LLBS233.Contains(ev.Target.Id))
			{
				ev.Amount = 300f;
				if(ev.Attacker.Health <= 10000)
				{
					ev.Attacker.Health += 50f;
				}
			}
			if (ev.Target.UserId == scpqblid && ev.Amount >= scpqbl.Health)
			{
				ev.Amount = 0f;
				scpqblid2 = scpqbl.Id;

				scpqbl.SetRole(RoleType.Scp93989);
				scpqbl3 = ev.Target;
				scpqbl = null;
				scpqblid = null;
				Setrank_new("SCP-乔碧萝", "yellow", ev.Target);
				Exiled.API.Features.Map.Broadcast(10, "我是颜值主播qwq");
			}
			if (ev.Target.Id == scp181id && ev.Attacker.Team == Team.SCP)
			{
				System.Random random = new System.Random();
				if (random.Next(1, 5) == 2)
				{
					ev.Attacker.Health -= 10f;
					ev.Amount = 0f;
				}
			}
			if (scp2006a.Contains(ev.Target.UserId) && ev.Attacker.Id != scp650id && (int)ev.Attacker.Team > 0)
			{
				ev.Amount = 10f;
			}
			if (ev.Target.Id == D9341id && ev.Amount >= ev.Target.Health && times <= 5)
			{
				ev.Amount = 0f;
				D9341.ReferenceHub.characterClassManager.SetClassIDAdv(D9341js, true);
				D9341.Health = D9341.MaxHealth;
				times++;
				D9341.ClearInventory();
				foreach(Inventory.SyncItemInfo syncItemInfo in D9341Item)
				{
					D9341.AddItem(syncItemInfo.id);
				}
				Timing.RunCoroutine(Tp(D9341, D9341zb));
			}
			if (scp2818pick && scp2818id == ev.Attacker.Id && ev.DamageType == DamageTypes.Com15)
			{
				if (ev.Target.Role == RoleType.Scp106)
				{
					ev.Amount = 300f;
					scp2818.Kill();
					scp2818.SetRole(RoleType.Spectator);
					scp2818pick = false;
					scp2818id = 0;
					scp2818 = null;
				}
				else
				{
					ev.Amount = 1000f;
					scp2818.Kill();
					scp2818.SetRole(RoleType.Spectator);
					scp2818pick = false;
					scp2818 = null;
					scp2818id = 0;
				}
			}
			if (ev.Attacker.Role == RoleType.Scp049 && lv == 3 && ev.Target.Id != scp076id && ev.Attacker.Id != scp49jid && !LLBS233.Contains(ev.Target.Id) && ev.Target.Id != scp457id && !scp_999.Contains(ev.Target.UserId) && !Dio2.Contains(ev.Target.UserId))
			{
				int num4 = new System.Random().Next(1, 3);
				if (num4 == 2)
				{
					ev.Amount = 0f;
					ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp0492, true);
				}
			}
			if (ev.Target.Id != scp650id && ev.Target.Id == scp076id)
			{
				if (ev.Attacker.Role == RoleType.Scp173 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
				{
					ev.Amount = 20f;
				}
				if (ev.Attacker.Role == RoleType.Scp049 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
				{
					ev.Amount = 20f;
				}
				if (ev.Attacker.Role == RoleType.Scp0492 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
				{
					ev.Amount = 10f;
				}
				if (ev.Attacker.Role == RoleType.Scp096 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
				{
					ev.Amount = 20f;
				}
				if (ev.Attacker.Role == RoleType.Scp93953 || ev.Attacker.Role == RoleType.Scp93989)
				{
					ev.Amount = 15f;
				}
				if (ev.Attacker.Team != 0 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
				{
					ev.Amount = 7f;
				}
			}
			if (!yshkq && roundstart)
			{
				if (ev.Attacker.Role == RoleType.Scientist && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
				{
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.MTF)
					{
						ev.Amount = 0f;
					}
				}
				else if (ev.DamageType == DamageTypes.Tesla && ev.Attacker.Id != ev.Target.Id)
				{
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.MTF)
					{
						ev.Amount = 0f;
					}
				}
				if (ev.Attacker.Team == Team.CHI && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null && ev.Target.Id != scp035id)
				{
					if (ev.Target.Role == RoleType.ClassD)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.CHI)
					{
						ev.Amount = 0f;
					}
				}
				else if (ev.DamageType == DamageTypes.Tesla && ev.Attacker.Id != ev.Target.Id)
				{
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.MTF)
					{
						ev.Amount = 0f;
					}
				}
				if (ev.Attacker.Role == RoleType.ClassD && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null && ev.Target.Id != scp035id)
				{
					if (ev.Target.Role == RoleType.ClassD)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.CHI)
					{
						ev.Amount = 0f;
					}
				}
				else if (ev.DamageType == DamageTypes.Tesla && ev.Attacker.Id != ev.Target.Id)
				{
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
				}
				if (ev.Attacker.Team == Team.MTF && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
				{
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.MTF)
					{
						ev.Amount = 0f;
					}
				}
				else if (ev.DamageType == DamageTypes.Tesla && ev.Attacker.Id != ev.Target.Id)
				{
					if (ev.Target.Role == RoleType.Scientist)
					{
						ev.Amount = 0f;
					}
					if (ev.Target.Team == Team.MTF)
					{
						ev.Amount = 0f;
					}
				}
			}
			if (ev.Target.Id == scp49jid && ev.Amount >= ev.Target.Health && ev.Target.Role != RoleType.Scp0492)
			{
				Vector3 vector3 = ev.Target.Position;
				ev.Amount = 0f;
				ev.Target.ReferenceHub.characterClassManager.SetClassIDAdv(RoleType.Scp0492, true);
				Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp49j, 1000)));
				Setrank_new("SCP-49-J", "yellow", ev.Target);
				ev.Target.Broadcast(10, "<color=#FFC0CB>[SCP-49-J 瘟疫二逼]</color>\n<color=#00FFFF>你无法攻击人 但是你可以拉起小僵尸</color>\n<color=#FFC0CB>当经验超过600后你可以攻击人类</color>");
				scp49jid = 0;
			}
			if (jwhngyes && !jwhngwufashanghai)
			{
				if (ev.Attacker.Team == Team.MTF && ev.Target.Id == jwhngid)
				{
					ev.Amount = 20f;
				}
				if (ev.Attacker.Id == jwhngid && ev.Attacker.Team == Team.MTF && ev.Target.Team == Team.MTF)
				{
					ev.Target.Broadcast(1, "无法攻击你现在是伪装模式");
					ev.Amount = 0f;
				}
				if (ev.Attacker.Role == RoleType.ChaosInsurgency && ev.Target.Id == jwhngid)
				{
					ev.Amount = 0f;
					ev.Target.ClearBroadcasts();
					ev.Target.Broadcast(1, "停火是友军");
				}
			}
			if (Dio2.Contains(ev.Target.UserId) && sjtz1 && ev.DamageType != DamageTypes.Nuke)
			{
				ev.Amount = 0f;
			}
			if (ev.Attacker.Id == scp076id && ev.Target.Team == Team.SCP)
			{
				ev.Amount += 10f;
			}
			foreach (Exiled.API.Features.Player Player in Exiled.API.Features.Player.List)
			{
				if (Player.Role == RoleType.ChaosInsurgency)
				{
					num++;
				}
				if (Player.Team == Team.MTF)
				{
					num2++;
				}
			}
			if (ev.Attacker.Id == scp035id && (int)ev.Target.Team > 0 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
			{
				ev.Amount = 10f;
			}
			if (ev.Target.Id == scp035id && ev.Attacker.Team == Team.SCP && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
			{
				ev.Amount = 50f;
			}
			if (ev.Target.Id == scp035id && (int)ev.Attacker.Team > 0 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
			{
				ev.Amount = 20f;
			}

			if (ev.Target.Role == RoleType.Scp173)
			{
				if (ev.DamageType == DamageTypes.Logicer || ev.DamageType == DamageTypes.E11StandardRifle || ev.DamageType == DamageTypes.P90 || ev.DamageType == DamageTypes.Mp7)
				{
					ev.Amount = 3f;
				}
				if (ev.DamageType == DamageTypes.Usp)
				{
					ev.Amount += 50f;
				}
			}
			if (ev.Target.Role == RoleType.Scp106 && (ev.DamageType == DamageTypes.Usp || ev.DamageType == DamageTypes.Logicer || ev.DamageType == DamageTypes.E11StandardRifle || ev.DamageType == DamageTypes.P90 || ev.DamageType == DamageTypes.Mp7 || (ev.DamageType == DamageTypes.Com15 && scp2818.Id != ev.Attacker.Id)))
			{
				ev.Amount = 1f;
			}
			if (LLBS233.Contains(ev.Target.Id) && ev.Attacker.Team == Team.SCP && ev.Target.Id != scp650id)
			{
				ev.Amount = 20f;
			}
			if (a127 && ev.DamageType == DamageTypes.Usp && !touxiang.Contains(ev.Attacker.Id))
			{
				ev.Amount = 100f;
				a127b++;
				if (a127b == 10)
				{
					a127 = false;
					a127c = true;
					a127d = true;
					Exiled.API.Features.Map.Broadcast(10, "SCP127力量已经消失");
				}
			}
			if (ev.Attacker.Id == scp650id && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
			{
				ev.Amount = 0f;
			}
			if (scp_999.Contains(ev.Attacker.UserId) && ev.DamageType != DamageTypes.Scp207 && ev.DamageType != DamageTypes.Usp && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null)
			{
				ev.Amount = 0f;
				if (ev.Target.Team == Team.SCP)
				{
					if (ev.Target.Role == RoleType.Scp096 && ev.Target.Health <= 1200)
					{
						ev.Target.Health += 3;
					}
					if (ev.Target.Role == RoleType.Scp173 && ev.Target.Health <= 6000)
					{
						ev.Target.Health += 3;
					}
					if (ev.Target.Role == RoleType.Scp049 && ev.Target.Health <= 6000)
					{
						ev.Target.Health += 3;
					}
					if (ev.Target.Role == RoleType.Scp106 && ev.Target.Health <= 1200)
					{
						ev.Target.Health += 3;
					}
				}
				if (ev.Target.Team != Team.SCP)
				{
					if(ev.Target.Id != scp073id && ev.Target.Id != scp076id)
					{
						if (ev.Target.Health <= 400)
						{
							ev.Target.Health += 3;
						}
					}
					else
					{
						if (ev.Target.Health <= 200)
						{
							ev.Target.Health += 1;
						}
					}
				}
			}
			else if (ev.DamageType == DamageTypes.Tesla)
			{
				if (scp_999.Contains(ev.Attacker.UserId) && ev.Attacker.Id != ev.Target.Id)
				{
					ev.Amount = 0f;
					ev.Target.Health += 10f;
				}
			}
			else if (ev.DamageType == DamageTypes.Usp)
			{
				ev.Amount = 10f;
			}
			if (ev.DamageType == DamageTypes.Scp207)
			{
				ev.Amount = 0f;
			}
			if (ev.Target.Id == fkyyzid && ev.DamageType == DamageTypes.Scp207)
			{
				ev.Amount = 0f;
			}
			if (ev.Attacker.Id == scpqblid2 && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure)
			{
				ev.Amount = 0f;
			}
			if (ev.Target.Role == RoleType.ClassD || ev.Target.Role == RoleType.Scientist || ev.Attacker.Role == RoleType.ClassD || ev.Attacker.Role == RoleType.Scientist)
			{
				if (touxiang.Contains(ev.Target.Id) && (ev.Attacker.Team == Team.MTF || ev.Attacker.Role == RoleType.Scientist) && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null && ev.Target.Id != ev.Attacker.Id && num == 0)
				{
					ev.Attacker.Broadcast(2, "该玩家处于投降状态，你只能对他造成1伤害\n<color=#00FF7F>你自身也受到了3伤害</color>");
					ev.Attacker.Health -= 3f;
					ev.Amount = 1f;
					Log.Info("玩家: " + ev.Attacker.Nickname + " 正在攻击: " + ev.Target.Nickname + " 当前场上混沌: " + num2);
				}
				if (touxiang.Contains(ev.Target.Id) && (ev.Attacker.Team == Team.MTF || ev.Attacker.Role == RoleType.Scientist) && num > 0)
				{
					Log.Info("混沌人数:" + num);
					Log.Info("MTF人数:" + num2);
					ev.Target.Broadcast(2, "由于场上存在混沌\n<color=#00FF7F>你的保护已失效</color>");
					Log.Info("玩家: " + ev.Target.Nickname + "受到攻击,但无保护 | 当前场上混沌个数:" + num);
				}
				if (touxiang.Contains(ev.Target.Id) && ev.Attacker.Role == RoleType.ChaosInsurgency && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Attacker != null && ev.Target.Id != ev.Attacker.Id && num2 == 0 && ev.Target.Role == RoleType.Scientist)
				{
					Log.Info("混沌人数:" + num);
					Log.Info("MTF人数:" + num2);
					ev.Attacker.Broadcast(2, "该玩家处于投降状态，你只能对他造成1伤害\n<color=#00FF7F>你自身也受到了3伤害</color>");
					ev.Amount = 1f;
					ev.Attacker.Health -= 3f;
					Log.Info("玩家: " + ev.Attacker.Nickname + " 正在攻击: " + ev.Target.Nickname + " 当前场上MTF: " + num2);
				}
				if (touxiang.Contains(ev.Target.Id) && ev.Attacker.Role == RoleType.ChaosInsurgency && num2 > 0)
				{
					Log.Info("混沌人数:" + num);
					Log.Info("MTF人数:" + num2);
					ev.Target.Broadcast(2, "由于场上存在MTF阵营\n<color=#00FF7F>你的保护已失效</color>");
					Log.Info("玩家: " + ev.Target.Nickname + "受到攻击,但无保护 | 当前场上九尾个数:" + num2);
				}
				if (touxiang.Contains(ev.Attacker.Id) && (ev.Target.Team == Team.MTF || ev.Target.Role == RoleType.Scientist) && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Target != null && ev.Target.Id != ev.Attacker.Id && num == 0)
				{
					ev.Attacker.Broadcast(2, "你处于投降状态，你无法伤害MTF阵营");
					ev.Amount = 0f;
				}
				if (touxiang.Contains(ev.Attacker.Id) && ev.Target.Team == Team.CHI && ev.DamageType != DamageTypes.Decont && ev.DamageType != DamageTypes.Falldown && ev.DamageType != DamageTypes.Flying && ev.DamageType != DamageTypes.Nuke && ev.DamageType != DamageTypes.Pocket && ev.DamageType != DamageTypes.Tesla && ev.DamageType != DamageTypes.Wall && ev.DamageType != DamageTypes.Lure && ev.Target != null && ev.Target.Id != ev.Attacker.Id && num2 == 0)
				{
					ev.Attacker.Broadcast(2, "你处于投降状态，你无法伤害混沌阵营");
					ev.Amount = 0f;
				}
			}
			if ((ev.Target.Role == RoleType.ClassD || ev.Target.Role == RoleType.Scientist) && ev.DamageType == DamageTypes.Scp049)
			{
				for (int i = 0; i <= 100; i++)
				{
					if (touxiang[i] == ev.Target.Id)
					{
						touxiang[i] = 0;
					}
				}
			}
		}

		public void OnPocketDimEscaped(EscapingPocketDimensionEventArgs ev)
		{
			switch (new System.Random().Next(1, 6))
			{
				case 1:
					ev.Player.AddItem(ItemType.Radio);
					ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n对讲机");
					break;
				case 2:
					ev.Player.AddItem(ItemType.Medkit);
					ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n医疗包");
					break;
				case 3:
					ev.Player.AddItem(ItemType.Flashlight);
					ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n闪光弹");
					break;
				case 4:
					ev.Player.AddItem(ItemType.Adrenaline);
					ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n肾上腺素");
					break;
				case 5:
					ev.Player.AddItem(ItemType.Coin);
					ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n硬币");
					break;
			}
		}

		public void OnScp079LvlGain(GainingLevelEventArgs ev)
		{
			if (h)
			{
				ev.Player.ReferenceHub.scp079PlayerScript.maxMana = 130f;
				ev.Player.Broadcast(10, "<color=#FFC0CB>[消息]</color>\n你升级了,但是你的\n你的电量被限制到了130点QAQ");
			}
			string a = addPoint(ev.Player, "079升级奖励", 30);
			if (a == "true")
			{
				ev.Player.Broadcast(4, Red("个人通知：") + "079升级奖励40积分");
			}
		}

		public void OnSetClass(ChangingRoleEventArgs ev)
		{
			try
			{
				switch (ev.Player.Role)
				{
					case RoleType.Spectator:
						break;
					case RoleType.NtfScientist:
						break;
					case RoleType.Tutorial:
						break;
					case RoleType.FacilityGuard:
						break;
					case RoleType.ClassD:
						break;
					case RoleType.Scientist:
						break;
					case RoleType.NtfCadet:
						break;
					case RoleType.NtfCommander:
						break;
					case RoleType.NtfLieutenant:
						break;
					case RoleType.ChaosInsurgency:
						break;
					case RoleType.Scp079:
						if (!choise)
						{
							ev.Player.SendConsoleMessage("==========SCP079============", "green");
							ev.Player.SendConsoleMessage(".scp         选择本局帮助SCP", "green");
							ev.Player.SendConsoleMessage(".h           选择本局帮助人类", "green");
							Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   未选择帮助倾向", "aqua", ev.Player);
							ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:无限  </color><color=aqua>你可以耗费电量开门和锁门 \n 清点键盘数字键1左边的~键选择本局所属阵营，如果看不到提示则向上翻</color>");
						}
						if (choise)
						{
							if (scp79)
							{
								Setrank_new("SCP079 -  帮助SCP", "aqua", ev.Player);
								ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:无限  </color><color=aqua>你可以耗费电量开门和锁门 \n 本局079选择帮助SCP</color>");
							}
							if (h)
							{
								Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   帮助人类", "aqua", ev.Player);
								ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:无限  </color><color=aqua>你可以耗费电量开门和锁门 \n 本局079选择帮助人类</color>");
							}
						}
						break;
					case RoleType.Scp173:
						ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP173]---</color>\n<color=#00FFFF>HP:4200  </color>你拥有一种特殊能力\n受到除手炮以外的<color=#FFD700>枪械伤害只有3点</color>");
						break;
					case RoleType.Scp049:
						Setrank_new("当前等级:" + lv + "经验值:" + xp, "pink", ev.Player);
						ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP049]---</color>\n<color=#FFC0CB>你一共3级多复活小僵尸吧qwq</color>");
						break;
					case RoleType.Scp096:
						ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP096]---</color>\n<color=#00FFFF>HP:5000  </color>你拥有一种特殊能力\n<color=#FFD700>按E 3%概率 打开所有门</color>");
						break;
					case RoleType.Scp93989:
						ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP939_89]---</color>\n<color=#00FFFF>HP:6000  </color>你拥有一种特殊能力\n受到<color=#FFD700>攻击时</color>你会加速,你可以奔跑");
						break;
					case RoleType.Scp93953:
						ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP939_53]---</color>\n<color=#00FFFF>HP:6000  </color>你拥有一种特殊能力\n受到<color=#FFD700>攻击时</color>你会加速,你可以奔跑");
						break;
					case RoleType.Scp106:
						ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP106]---</color>\n<color=#00FFFF>HP:650  </color>你拥有一种特殊能力\n受到<color=#FFD700>枪械伤害只有1点</color>");
						break;
					default:
						break;
				}
			}
			catch
			{
				ev.Player.Broadcast(5, "设置角色出现问题 联系服主");
			}
		}

		public void OnPlayerSpawn(SpawningEventArgs ev)
		{
			starttimer = true;
			roundstart = true;
			if (ev.Player.Role == RoleType.Scp93989 && ev.Player.Id != scpqblid2 && new System.Random().Next(0, 100) <= 80)
			{
				Setrank_new("SCP-682", "red", ev.Player);
				scp682.Add(ev.Player.UserId);
				Log.Info(ev.Player.Nickname + "成为SCP682");
				Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));
			}
			switch (ev.Player.Role)
			{
				case RoleType.Scp096:
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 1500)));
					break;
				case RoleType.Scp173:
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 4200)));
					break;
				case RoleType.ClassD:
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 100)));
					if(qingjiegongnum<2)
					{
						qingjiegongnum++;
						ev.Player.AddItem(ItemType.KeycardJanitor);
					}
					break;
				case RoleType.Scp0492:
					ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP049_2]---</color>\n<color=#00FFFF>HP:1400</color>");
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 1400)));
					xp += 50;
					if (xp == 100)
					{
						lv = 1;
					}
					if (xp == 300)
					{
						lv = 2;
					}
					if (xp == 700)
					{
						lv = 3;
					}
					foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
					{
						if (player.Role == RoleType.Scp049)
						{
							player.Health += 150f;
							Setrank_new("当前等级:" + lv + " 经验值:" + xp, "pink", player);
						}
					}
					break;
				case RoleType.Tutorial:
					break;
				case RoleType.Scp93989:
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));
					break;
				case RoleType.Scp93953:
					Setrank_new("SCP-939-3", "red", ev.Player);
					ev.Player.Broadcast(10, "<color=#FF0000>你是SCP-939-3你攻击伤害为100点哦qwq</color>");
					Log.Info(ev.Player.Nickname + "939-3");
					scp939id = ev.Player.Id;
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));
					break;
				case RoleType.ChaosInsurgency:
					ev.Player.Broadcast(10, "<color=#FFC0CB>[混沌分裂者]</color>\n<color=#00FFFF>你的任务是救出D级杀光九尾或与SCP合作</color>\n你对SCP造成的伤害<color=#FFD700>+5</color>");
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 120)));
					break;
				case RoleType.NtfCadet:
					ev.Player.Ammo[(int)AmmoType.Nato556] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato762] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato9] = 400;
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 100)));
					break;
				case RoleType.NtfCommander:
					ev.Player.Ammo[(int)AmmoType.Nato556] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato762] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato9] = 400;
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 150)));
					ev.Player.Broadcast(10, "<color=#FFC0CB>[九尾狐指挥官]</color>\n<color=#00FFFF>你可以给所有九尾狐阵营发送信息,冷却80秒</color>\n详细<color=#FFD700>按~键激活控制台输入.help查看帮助</color>");
					break;
				case RoleType.FacilityGuard:
					ev.Player.Ammo[(int)AmmoType.Nato556] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato762] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato9] = 400;
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 100)));
					ev.Player.Broadcast(10, "<color=#FFC0CB>[设施保安]</color>\n<color=#00FFFF>你的任务是捆绑救出D级科学家杀光SCP与混沌</color>\n你可以前往<color=#FFD700>逃脱点</color>获得物资");
					break;
				case RoleType.NtfLieutenant:
					ev.Player.Ammo[(int)AmmoType.Nato556] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato762] = 400;
					ev.Player.Ammo[(int)AmmoType.Nato9] = 400;
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 120)));
					break;
				case RoleType.Scp106:
					Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 650)));
					break;
				default:
					break;
			}
		}

		public void OnPlayerLeave(LeftEventArgs ev)
		{
			try
			{
				if (小僵尸id.Contains(ev.Player.Id))
				{
					xp += 50;
					if (xp == 100)
					{
						lv = 1;
					}
					if (xp == 350)
					{
						lv = 2;
					}
					if (xp == 800)
					{
						lv = 3;
					}
					foreach (Exiled.API.Features.Player referenceHub in Exiled.API.Features.Player.List)
					{
						if (referenceHub.Role == RoleType.Scp049)
						{
							referenceHub.Health += 300f;
							Setrank_new("当前等级:" + lv + " 经验值:" + xp, "pink", referenceHub);
						}
					}
				}
				if (ev.Player.Id == hdjjsid)
				{
					hdjjs = null;
					hdjjsid = 0;
				}
				if (ev.Player.Id == Gears博士id)
				{
					Gears博士id = 0;
					Gears博士 = null;
					
				}
				if (ev.Player.Id == jwhhkid)
				{
					jwhng = null;
					jwhngyes = false;
					jwhngid = 0;
					jwhngwufashanghai = false;
				}
				if (ev.Player.Id == scp035id)
				{
					scp035 = null;
					scp035id = 0;
					scp035goout = false;
					scp035yes = false;
				}
				if (ev.Player.Id == scp550id)
				{
					scp550id = 0;
					scp550yes = false;
					scp550 = null;
					scp550lv = 0;
					tssl = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>[SCP550]</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == hpszid)
				{
					hpsz = null;
					hpszid = 0;
				}
				if (scp650yes && ev.Player.Id == scp650id)
				{
					scp650 = null;
					scp650id = 0;
					scp650yes = false;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>[SCP650]</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == jwhhkid)
				{
					jwhhkid = 0;
					jwhhk = null;
				}
				if (ev.Player.Id == scp073id)
				{
					scp073 = null;
					scp073id = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP073</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == scp076id)
				{
					scp076 = null;
					scp076id = 0;
					scp076yes = false;
					Exiled.API.Features.Map.Broadcast(10, "----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == scp457id)
				{
					scp457 = null;
					scp457a = false;
					scp457die = true;
					Setrank_new("white", "", ev.Player);
					scp457id = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP457</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == xtdid)
				{
					xtd = null;
					xtdid = 0;
				}
				if (qblcq2 && qblcq.Id == ev.Player.Id)
				{
					qblcq2 = false;
					qblcq = null;
				}
				if (scp939id == ev.Player.Id)
				{
					scp939id = 0;
				}
				if (ev.Player.Id == scp914mid)
				{
					scp914m = null;
					scp914mid = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP914-M</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == scpqblid2)
				{
					scpqblid2 = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP乔碧萝</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == scp181id)
				{
					scp181id = 0;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP181</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
					Setrank_new("white", "", ev.Player);
				}
				if (ev.Player.Id == scp035id)
				{
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP035</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
					scp035 = null;
					scp035id = 0;
					scp035goout = false;
					scp035yes = false;
				}
				if (scp2006a.Contains(ev.Player.UserId))
				{
					scp2006a.Clear();
					scp2006 = null;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP2006</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
					Setrank_new("white", "", ev.Player);
				}
				if (ev.Player.Id == cxkid)
				{
					cxkid = 0;
					cxk = null;
					cxkyes = false;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP蔡徐坤</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
					Setrank_new("white", "", ev.Player);
				}
				if (ev.Player.Id == scp817id)
				{
					scp817id = 0;
					scp817 = null;
					scp817yes = false;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP817</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
					Setrank_new("white", "", ev.Player);
				}
				if (ev.Player.Id == D9341id)
				{
					if (times >= 5)
					{
						D9341 = null;
						D9341id = 0;
						D9341Item = null;
						D9341yes = false;
						D9341zb = default(Vector3);
						Setrank_new("white", "", ev.Player);
						Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>D-9341</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
					}
				}
				if (LLBS233.Contains(ev.Player.Id))
				{
					Exiled.API.Features.Map.Broadcast(5, "<color=#FFFF33>Mr.fish:</color>\n装逼失败");
					LLBS233.Remove(ev.Player.Id);
					Setrank_new("white", "", ev.Player);
				}
				if (Dio2.Contains(ev.Player.UserId))
				{
					Exiled.API.Features.Map.Broadcast(5, "<color=#FFFF33>Dio:</color>\n装逼失败");
					Dio2.Remove(ev.Player.UserId);
					Dio = null;
				}
				if (scp1143id == ev.Player.Id)
				{
					scp1143 = null;
					scp1143id = 0;
					scp1143a = false;
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP1143</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (HDZHG2.Contains(ev.Player.UserId))
				{
					HDZHG2.Remove(ev.Player.UserId);
				}
				if (ev.Player.Id == fkyyzid)
				{
					fkyyz = null;
					fkyyzid = 0;
					fkyyzyes = false;
					bindljf = false;
					bindtys = false;
					bindjzsj = false;
				}
				if (bpb2.Contains(ev.Player.Id))
				{
					bpb = false;
					bpb2.Clear();
				}
				if (ylb2.Contains(ev.Player.UserId))
				{
					ylb = null;
					ylb1 = false;
					ylb2.Clear();
				}
				if (scp682.Contains(ev.Player.UserId))
				{
					scp682.Remove(ev.Player.UserId);
					Exiled.API.Features.Map.Broadcast(6, "----[<color=#32CD32>SCP682</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>掉线了</color>");
				}
				if (ev.Player.Id == scp005aid)
				{
					scp005aid = 0;
				}
			}
			catch
			{
				Log.Info("玩家退出发生异常");
			}
		}

		public List<shop> showItems()
		{
			string a = Get2(url + "showItems");
			List<shop> model = new List<shop>();
			return JsonConvert.DeserializeObject<List<shop>>(a);
		}

		public List<jackpot> showPrize()
		{
			string a = Get2(url + "showPrize");
			List<jackpot> model = new List<jackpot>();
			return JsonConvert.DeserializeObject<List<jackpot>>(a);
		}

		public List<detail> showDetail(Exiled.API.Features.Player p)
		{
			Dictionary<string, string> param = new Dictionary<string, string>();
			param.Add("userid", p.UserId);
			string a = Get2(url + "showDetail", param);
			List<detail> model = new List<detail>();
			return JsonConvert.DeserializeObject<List<detail>>(a);
		}

		public string playerJoin(Exiled.API.Features.Player p)
		{
			Dictionary<string, string> param = new Dictionary<string, string>();
			param.Add("userid", p.UserId);
			param.Add("nickname", p.Nickname);
			param.Add("ip", p.IPAddress);
			return Get2(url + "playerJoin", param);
		}

		public string myPoint(Exiled.API.Features.Player p)
		{
			Dictionary<string, string> param = new Dictionary<string, string>();
			param.Add("userid", p.UserId);
			return Get2(url + "myPoint", param);
		}

		public string addPoint(Exiled.API.Features.Player p, string remarks, int point)
		{
			Dictionary<string, string> param = new Dictionary<string, string>();
			param.Add("userid", p.UserId);
			param.Add("nickname", p.Nickname);
			param.Add("Remarks", remarks);
			param.Add("point", point.ToString());
			return Get2(url + "addPoint", param);
		}

		public string usePoint(Exiled.API.Features.Player p, string remarks, int point)
		{
			Dictionary<string, string> param = new Dictionary<string, string>();
			param.Add("userid", p.UserId);
			param.Add("nickname", p.Nickname);
			param.Add("Remarks", remarks);
			param.Add("point", point.ToString());
			return Get2(url + "usePoint", param);
		}

		public string Get2(string url, Dictionary<string, string> dic = null)
		{
			string result = "";
			if (dic == null)
			{
				dic = new Dictionary<string, string>();
			}
			dic.Add("num", playernum.ToString());
			StringBuilder builder = new StringBuilder();
			builder.Append(url);
			if (dic != null)
			{
				builder.Append("?");
				int i = 0;
				foreach (KeyValuePair<string, string> item in dic)
				{
					if (i > 0)
					{
						builder.Append("&");
					}
					builder.AppendFormat("{0}={1}", item.Key, item.Value);
					i++;
				}
			}
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
			req.KeepAlive = false;
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			Stream stream = resp.GetResponseStream();
			try
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					result = reader.ReadToEnd();
				}
			}
			finally
			{
				stream.Close();
			}
			return result;
		}

		public string Get(string url, Dictionary<string, string> dic = null)
		{
			string result = "";
			if (dic == null)
			{
				dic = new Dictionary<string, string>();
			}
			int numplayer = 0;
			foreach (Exiled.API.Features.Player player in Exiled.API.Features.Player.List)
			{
				numplayer++;
			}
			dic.Add("num", numplayer.ToString());
			StringBuilder builder = new StringBuilder();
			builder.Append(url);
			if (dic != null)
			{
				builder.Append("?");
				int i = 0;
				foreach (KeyValuePair<string, string> item in dic)
				{
					if (i > 0)
					{
						builder.Append("&");
					}
					builder.AppendFormat("{0}={1}", item.Key, item.Value);
					i++;
				}
			}
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
			req.KeepAlive = false;
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			Stream stream = resp.GetResponseStream();
			try
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					result = reader.ReadToEnd();
				}
			}
			finally
			{
				stream.Close();
			}
			return result;
		}

		public string Red(string a)
		{
			return "<color=red>" + a + "</color>";
		}

		public string Blue(string a)
		{
			return "<color=blue>" + a + "</color>";
		}

		public string Yellow(string a)
		{
			return "<color=yellow>" + a + "</color>";
		}
	}
}
