using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class csgo
    {
        private bool huihekaishi;

        public void OnRoundStart()
        {
            huihekaishi = true;
            Timing.RunCoroutine(HuiheKaiShiFenpei());
        }
        
        private IEnumerator<float> HuiheKaiShiFenpei()
        {
            bool hd = true;
            yield return Timing.WaitForSeconds(1f);
            foreach(Player player in Player.List)
            {
                if(hd)
                {
                    hd = false;
                    player.Role = RoleType.ChaosInsurgency;
                    player.ClearInventory();
                    player.AddItem(ItemType.GrenadeFlash);
                    player.AddItem(ItemType.GrenadeFrag);
                    player.AddItem(ItemType.GunUSP);
                    player.AddItem(ItemType.GunCOM15);
                    player.AddItem(ItemType.GunE11SR);
                    player.AddItem(ItemType.GunLogicer);
                    player.AddItem(ItemType.GunMP7);
                    player.AddItem(ItemType.GunProject90);
                }
                else
                {
                    hd = true;
                    player.Role = RoleType.NtfLieutenant;
                    player.ClearInventory();
                    player.AddItem(ItemType.GrenadeFlash);
                    player.AddItem(ItemType.GrenadeFrag);
                    player.AddItem(ItemType.GunUSP);
                    player.AddItem(ItemType.GunCOM15);
                    player.AddItem(ItemType.GunE11SR);
                    player.AddItem(ItemType.GunLogicer);
                    player.AddItem(ItemType.GunMP7);
                    player.AddItem(ItemType.GunProject90);
                }
            }
            yield return Timing.WaitForSeconds(30f);
            foreach(Player player1 in Player.List)
            {
                if(player1.Role ==RoleType.NtfLieutenant)
                {
                    player1.Position = RoleType.NtfLieutenant.GetRandomSpawnPoint();
                }
                if(player1.Role == RoleType.ChaosInsurgency)
                {
                    player1.Position = RoleType.ClassD.GetRandomSpawnPoint();
                }
            }

        }
        public void OnRoundEnd(RoundEndedEventArgs ev)
        {
            huihekaishi = true;
        }
        public void OnEnding(EndingRoundEventArgs ev)
        {
            List<Team> teams = new List<Team>();
            foreach (Player player in Player.List)
            {
                teams.Add(player.Team);
            }
            if(teams.Contains(Team.MTF) && teams.Contains(Team.CHI))
            {
                ev.IsRoundEnded = false;
            }
        }


    }
}
