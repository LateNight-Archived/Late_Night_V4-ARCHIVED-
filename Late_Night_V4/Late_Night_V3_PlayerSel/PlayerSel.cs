using System;
using Il2CppSystem.Collections.Generic;
using Late_Night_config;
using Late_Night_V2_Playerlist;
using Late_Night_V2_wrappers;
using Late_Night_V3;
using UnityEngine;
using VRC;

namespace Late_Night_V3_PlayerSel
{
	// Token: 0x02000018 RID: 24
	public class PlayerSel : MonoBehaviour
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000723A File Offset: 0x0000543A
		public PlayerSel(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007248 File Offset: 0x00005448
		public float timeinig()
		{
			return (PlayerWrapper.GetSelectedPlayer(true) != null) ? 1f : 2f;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007274 File Offset: 0x00005474
		public void Update()
		{
			PlayerSel.time += Time.deltaTime;
			bool flag = PlayerSel.time <= 2.5f;
			if (!flag)
			{
				bool uidone = Late_Night.UIdone;
				if (uidone)
				{
					bool flag2 = RoomManager.Method_Public_Static_get_Boolean_3();
					if (flag2)
					{
						bool flag3 = PlayerWrapper.GetSelectedPlayer(true) != null;
						if (flag3)
						{
							string text = "";
							bool flag4 = PlayerWrapper.GetSelectedPlayer(true) == null;
							if (flag4)
							{
								return;
							}
							Player selectedPlayer = PlayerWrapper.GetSelectedPlayer(true);
							bool flag5 = selectedPlayer != null;
							if (flag5)
							{
								text = string.Concat(new string[]
								{
									text,
									"\n",
									Playerlist.PlayerName(selectedPlayer),
									"\n",
									Playerlist.PlayerPING(selectedPlayer),
									Playerlist.PlayerFPS(selectedPlayer),
									Playerlist.PlayerisFristring(selectedPlayer),
									Playerlist.Playerisvr(selectedPlayer),
									Playerlist.Playerisquet(selectedPlayer),
									Playerlist.Playerismaster(selectedPlayer),
									Playerlist.TrustRank(selectedPlayer),
									"\n",
									Playerlist.PlayerAviname(selectedPlayer),
									"\n",
									Playerlist.PlayerAviWhen(selectedPlayer),
									"\n",
									Playerlist.PlayerAviAuth(selectedPlayer),
									"\n",
									Playerlist.PlayerAvipuborpri(selectedPlayer),
									"\n",
									Playerlist.PlayerAviPatform(selectedPlayer),
									"\n",
									Playerlist.PlayerAviID(selectedPlayer)
								});
								Late_Night.ListText.SetText("<color=#ffdd00>Player:</color> \n <color=#ff00e1>[P]= Ping</color> <color=#ffdd00>[F]= Friend</color> <color=#55ff00>[FPS]= FPS</color> \n <color=#42f20c>[Q]=is Quest</color> <color=" + Config.Instance.Master + ">[M]= World master</color> " + text);
							}
						}
						else
						{
							string text2 = "";
							List<Player>.Enumerator enumerator = PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.GetEnumerator();
							while (enumerator.MoveNext())
							{
								text2 = string.Concat(new string[]
								{
									text2,
									"\n",
									Playerlist.PlayerName(enumerator.current),
									Playerlist.PlayerPING(enumerator.current),
									Playerlist.PlayerFPS(enumerator.current),
									Playerlist.PlayerisFristring(enumerator.current),
									Playerlist.Playerisvr(enumerator.current),
									Playerlist.Playerisquet(enumerator.current),
									Playerlist.Playerismaster(enumerator.current),
									Playerlist.TrustRank(enumerator.current)
								});
								Late_Night.ListText.SetText(string.Format("<color=#ffdd00>Players: [{0}]</color>\n <color=#ff00e1>[P]= Ping</color> <color=#ffdd00>[F]= Friend</color> <color=#55ff00>[FPS]= FPS</color>\n <color=#42f20c>[Q]=is Quest</color> <color={1}>[M]= World master</color> {2}", PlayerWrapper.GetAllPlayers().Count, Config.Instance.Master, text2));
							}
						}
						Late_Night.clock.SetText("<color=#ffdd00>" + DateTime.Now.ToString("h:mm:ss tt") + "</color>");
					}
				}
				PlayerSel.time = 0f;
			}
		}

		// Token: 0x04000068 RID: 104
		public static float time;

		// Token: 0x04000069 RID: 105
		public static string info;
	}
}
