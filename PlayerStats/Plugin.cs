using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using HarmonyLib;
using System.Threading;
using System.Threading.Tasks;

namespace PlayerStats
{
	public class Plugin : Plugin<YYYlikeconfig>
	{
		private EventHandlers server;

		public override void OnEnabled()
		{
			base.OnEnabled();
			RegisterEvents();
			Log.Info("Exiled2.0插件读取完毕");
		}

		private void RegisterEvents()
		{
			server = new EventHandlers();
			Exiled.Events.Handlers.Player.Died += server.OnPlayerDeath;
			Exiled.Events.Handlers.Server.WaitingForPlayers += server.OnWaitingForPlayers;
			Exiled.Events.Handlers.Server.RoundEnded += server.OnRoundEnd;
			Exiled.Events.Handlers.Player.Died += server.OnPlayerDeath;
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
			Scp096.Enraging += server.OnScp096Enrage;
			Exiled.Events.Handlers.Server.EndingRound += server.OnCheckRoundEnd;
			Exiled.Events.Handlers.Scp914.ChangingKnobSetting += server.On914KnobChange;
			Exiled.Events.Handlers.Server.RoundStarted += server.OnRoundStart;
			Exiled.Events.Handlers.Map.Decontaminating += server.OnDecontaminate;
			Exiled.Events.Handlers.Server.RestartingRound += server.OnRestartingRound;
			Exiled.Events.Handlers.Warhead.Starting += server.ONWarheadStarter;
			Exiled.Events.Handlers.Player.TriggeringTesla += server.OnTriggeringTesla;

			Thread thread = new Thread(Watchconnecting);
			thread.IsBackground = true;
			thread.Start();
		}

		private void Watchconnecting()
		{
			NetServer.Instance.Start();
		}

		public override void OnDisabled()
		{
			base.OnDisabled();
			UnregisterEvents();
		}

		private void UnregisterEvents()
		{
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
			Exiled.Events.Handlers.Player.Left -= server.OnPlayerLeave;
			Exiled.Events.Handlers.Warhead.Stopping -= server.ONWarheadCancelled;
			Exiled.Events.Handlers.Scp914.ChangingKnobSetting -= server.On914KnobChange;
			Scp096.Enraging -= server.OnScp096Enrage;
			Exiled.Events.Handlers.Warhead.Detonated -= server.OnWarheadDetonation;
			Exiled.Events.Handlers.Server.SendingRemoteAdminCommand -= server.OnRemoteAdminCommand;
			Exiled.Events.Handlers.Map.Decontaminating -= server.OnDecontaminate;
			Exiled.Events.Handlers.Player.Dying -= server.OnDying;
			Exiled.Events.Handlers.Server.RestartingRound += server.OnRestartingRound;
			Exiled.Events.Handlers.Warhead.Starting -= server.ONWarheadStarter;
			Exiled.Events.Handlers.Player.TriggeringTesla -= server.OnTriggeringTesla;

			server = null;
		}
	}
}
