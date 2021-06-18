using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using HarmonyLib;
using MEC;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace YYYLike
{
	public class Plugin : Plugin<YYYlikeconfig>
	{
		private EventHandlers server;
		public int PatchesCounter { get; private set; }
		public Harmony Harmony { get; private set; }

		public override void OnEnabled()
		{
			base.OnEnabled();
			RegisterEvents();
			Log.Info("Exiled2.0插件读取完毕");
		}

		private void RegisterEvents()
		{
			if(Exiled.API.Features.Server.Port != 7779)
            {
				server = new EventHandlers();
				KickPlayer kickPlayer = new KickPlayer();
				CmdBinding.Load();

				CmdBinding.KeyBind(KeyCode.G, ".jineng");
				CmdBinding.KeyBind(KeyCode.F, ".f");
				CmdBinding.Save();
				Exiled.Events.Handlers.Warhead.Detonated += server.OnWarheadDetonation;
				Exiled.Events.Handlers.Player.Left += server.OnPlayerLeave;
				Exiled.Events.Handlers.Player.Dying += server.OnDying;
				Exiled.Events.Handlers.Player.Shooting += server.OnShoot;

				Exiled.Events.Handlers.Player.Died += server.OnPlayerDeath;
				Exiled.Events.Handlers.Server.WaitingForPlayers += server.OnWaitingForPlayers;
				Exiled.Events.Handlers.Server.RoundEnded += server.OnRoundEnd;
				Exiled.Events.Handlers.Player.MedicalItemUsed += server.OnMedicalItem;
				Exiled.Events.Handlers.Server.RespawningTeam += server.OnTeamRespawn;
				Exiled.Events.Handlers.Server.SendingConsoleCommand += server.OnConsoleCommand;
				Exiled.Events.Handlers.Player.FailingEscapePocketDimension += server.OnPocketDimDeath;
				Exiled.Events.Handlers.Player.Escaping += server.OnCheckEscape;
				Exiled.Events.Handlers.Player.InteractingDoor += server.OnDoorInteract;
				Scp106.Containing += server.OnScp106Contain;
				Exiled.Events.Handlers.Player.DroppingItem += server.OnDropItem;
				Exiled.Events.Handlers.Player.PickingUpItem += server.OnPickupItem;
				Exiled.Events.Handlers.Player.Hurting += server.OnPlayerHurt;
				Exiled.Events.Handlers.Player.EscapingPocketDimension += server.OnPocketDimEscaped;
				Exiled.Events.Handlers.Player.ChangingRole += server.OnSetClass;
				Exiled.Events.Handlers.Player.Spawning += server.OnPlayerSpawn;
				Scp079.GainingLevel += server.OnScp079LvlGain;
				Exiled.Events.Handlers.Player.UnlockingGenerator += server.OnGeneratorUnlock;
				Exiled.Events.Handlers.Player.Joined += server.OnPlayerJoin;
				Exiled.Events.Handlers.Warhead.Stopping += server.ONWarheadCancelled;
				Exiled.Events.Handlers.Server.SendingRemoteAdminCommand += server.OnRemoteAdminCommand;
				Exiled.Events.Handlers.Scp096.Enraging += server.OnScp096Enrage;
				Exiled.Events.Handlers.Server.EndingRound += server.OnCheckRoundEnd;
				Exiled.Events.Handlers.Scp914.ChangingKnobSetting += server.On914KnobChange;
				Exiled.Events.Handlers.Server.RoundStarted += server.OnRoundStart;
				Exiled.Events.Handlers.Map.Decontaminating += server.OnDecontaminate;
				Exiled.Events.Handlers.Server.RestartingRound += server.OnRestartingRound;
				Exiled.Events.Handlers.Warhead.Starting += server.ONWarheadStarter;
				Exiled.Events.Handlers.Player.TriggeringTesla += server.OnTriggeringTesla;
				Exiled.Events.Handlers.Player.EnteringPocketDimension += server.OnEnteringPocketDimension;
				Exiled.Events.Handlers.Map.AnnouncingDecontamination += server.OnAnnouncingDecontamination;
				Exiled.Events.Handlers.Player.UsingMedicalItem += server.OnUsingMedicalItem;
				Exiled.Events.Handlers.Player.Verified += server.OnVerified;
				Exiled.Events.Handlers.Player.InteractingElevator += server.OnInteractingElevator;
				Exiled.Events.Handlers.Map.PlacingBlood += server.OnPlaceBlood;
				Exiled.Events.Handlers.Player.ChangingItem += server.OnChangeItem;
				Exiled.Events.Handlers.Map.ExplodingGrenade += server.OnExplodingGrenade;

				Exiled.Events.Handlers.Scp914.Activating += server.OnActivating;
				//注册投票踢人
				Exiled.Events.Handlers.Server.SendingConsoleCommand += kickPlayer.OnCommandSend;
				Exiled.Events.Handlers.Server.RoundEnded += kickPlayer.OnRoundEnd;
				
				Exiled.Events.Handlers.Map.GeneratorActivated += server.电板激活事件;
				
				Exiled.Events.Handlers.Player.PreAuthenticating += server.OnPreAuthenticating;
				
				try
				{
					Harmony = new Harmony($"com.galaxy.cu-{DateTime.UtcNow.Ticks}");
					Harmony.PatchAll(); 
				}
				catch (Exception e)
				{
					Log.Error($"Patching failed!, " + e);
				}

			}

		}


		public override void OnDisabled()
		{
			base.OnDisabled();
			UnregisterEvents();
		}

		private void UnregisterEvents()
		{
			KickPlayer kickPlayer = new KickPlayer();
			Exiled.Events.Handlers.Player.UsingMedicalItem -= server.OnUsingMedicalItem;
			Exiled.Events.Handlers.Server.WaitingForPlayers -= server.OnWaitingForPlayers;
			Exiled.Events.Handlers.Server.RoundStarted -= server.OnRoundStart;
			Exiled.Events.Handlers.Server.RoundEnded -= server.OnRoundEnd;
			Exiled.Events.Handlers.Player.Joined -= server.OnPlayerJoin;
			Exiled.Events.Handlers.Player.Died -= server.OnPlayerDeath;
			Exiled.Events.Handlers.Player.MedicalItemUsed -= server.OnMedicalItem;
			Exiled.Events.Handlers.Server.RespawningTeam -= server.OnTeamRespawn;
			Exiled.Events.Handlers.Server.SendingConsoleCommand -= server.OnConsoleCommand;
			Exiled.Events.Handlers.Player.FailingEscapePocketDimension -= server.OnPocketDimDeath;
			Exiled.Events.Handlers.Player.Escaping -= server.OnCheckEscape;
			Exiled.Events.Handlers.Player.InteractingDoor -= server.OnDoorInteract;
			Scp106.Containing -= server.OnScp106Contain;
			Exiled.Events.Handlers.Server.EndingRound -= server.OnCheckRoundEnd;
			Exiled.Events.Handlers.Player.DroppingItem -= server.OnDropItem;
			Exiled.Events.Handlers.Player.Shooting -= server.OnShoot;
			Exiled.Events.Handlers.Player.PickingUpItem -= server.OnPickupItem;
			Exiled.Events.Handlers.Player.Hurting -= server.OnPlayerHurt;
			Exiled.Events.Handlers.Player.EscapingPocketDimension -= server.OnPocketDimEscaped;
			Exiled.Events.Handlers.Player.ChangingRole -= server.OnSetClass;
			Exiled.Events.Handlers.Player.Spawning -= server.OnPlayerSpawn;
			Scp079.GainingLevel -= server.OnScp079LvlGain;
			Exiled.Events.Handlers.Player.UnlockingGenerator -= server.OnGeneratorUnlock;
			Exiled.Events.Handlers.Scp914.Activating -= server.OnActivating;
			Exiled.Events.Handlers.Player.Left -= server.OnPlayerLeave;
			Exiled.Events.Handlers.Warhead.Stopping -= server.ONWarheadCancelled;
			Exiled.Events.Handlers.Scp914.ChangingKnobSetting -= server.On914KnobChange;
			Exiled.Events.Handlers.Scp096.Enraging -= server.OnScp096Enrage;
			Exiled.Events.Handlers.Warhead.Detonated -= server.OnWarheadDetonation;
			Exiled.Events.Handlers.Server.SendingRemoteAdminCommand -= server.OnRemoteAdminCommand;
			Exiled.Events.Handlers.Map.Decontaminating -= server.OnDecontaminate;
			Exiled.Events.Handlers.Player.Dying -= server.OnDying;
			Exiled.Events.Handlers.Server.RestartingRound += server.OnRestartingRound;
			Exiled.Events.Handlers.Warhead.Starting -= server.ONWarheadStarter;
			Exiled.Events.Handlers.Player.TriggeringTesla -= server.OnTriggeringTesla;
			Exiled.Events.Handlers.Player.EnteringPocketDimension -= server.OnEnteringPocketDimension;
			Exiled.Events.Handlers.Map.AnnouncingDecontamination -= server.OnAnnouncingDecontamination;
			Exiled.Events.Handlers.Player.Verified -= server.OnVerified;
			Exiled.Events.Handlers.Player.InteractingElevator -= server.OnInteractingElevator;
			Exiled.Events.Handlers.Map.PlacingBlood -= server.OnPlaceBlood;
			Exiled.Events.Handlers.Player.ChangingItem -= server.OnChangeItem;
			Exiled.Events.Handlers.Map.ExplodingGrenade -= server.OnExplodingGrenade;
			server = null;
			//关闭投票踢人
			Exiled.Events.Handlers.Server.SendingConsoleCommand -= kickPlayer.OnCommandSend;
			Exiled.Events.Handlers.Server.RoundEnded -= kickPlayer.OnRoundEnd;
			kickPlayer = null;
			Exiled.Events.Handlers.Map.GeneratorActivated -= server.电板激活事件;
			Exiled.Events.Handlers.Player.PreAuthenticating -= server.OnPreAuthenticating;
			Harmony.UnpatchAll();
		}
	}
}
