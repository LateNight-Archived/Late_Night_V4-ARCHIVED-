using System;
using Late_Night_config;
using Late_Night_V3.Modules_Funny;
using Late_Night_V3.Modules_QOL;
using Late_Night_V3_colnsole;
using Late_Night_V4.Move;
using VRC.SDKBase;
using XButtonAPI;

namespace Late_Night_V3.Modules_Movement
{
	// Token: 0x02000027 RID: 39
	internal class Movement
	{
		// Token: 0x06000187 RID: 391 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		public static void Movement_menu(QMNestedButton Submenu)
		{
			Movement.TogFly = Submenu.AddToggle("Fly", "Fly", delegate(bool B)
			{
				Movement.GetCurentBehaviour().FlyNoClip(B, false);
			}, false);
			Movement.TogNoClip = Submenu.AddToggle("Noclip", "Noclip", delegate(bool B)
			{
				Movement.GetCurentBehaviour().FlyNoClip(B, B);
			}, false);
			QMNestedButton qmnestedButton = Submenu.AddMenuPage("Fly/NoClip Settings", "Fly/NoClip Settings", "Fly Setting", false, null);
			qmnestedButton.AddButton("Fly Speed+", "Fly Speed", delegate
			{
				Movement.GetCurentBehaviour().AddFly(1f);
			}, null);
			qmnestedButton.AddButton("Fly Speed-", "Fly Speed", delegate
			{
				Movement.GetCurentBehaviour().SubFly(1f);
			}, null);
			qmnestedButton.AddButton("Fly Speed Reset", "Fly Speed Reset", delegate
			{
				Movement.GetCurentBehaviour().ResetFly();
			}, null);
			Movement.TogSpeed = Submenu.AddToggle("Speed", "Speed", delegate(bool B)
			{
				Movement.GetCurentBehaviour().Speeds(B);
			}, false);
			QMNestedButton qmnestedButton2 = Submenu.AddMenuPage("Speed Settings", "Speed Settings", "Speed Setting", false, null);
			qmnestedButton2.AddButton(" Speed+", " Speed", delegate
			{
				Movement.GetCurentBehaviour().AddSpeed(1f);
			}, null);
			qmnestedButton2.AddButton(" Speed-", " Speed", delegate
			{
				Movement.GetCurentBehaviour().SubSpeed(1f);
			}, null);
			qmnestedButton2.AddButton(" Speed Reset", " Speed Reset", delegate
			{
				Movement.GetCurentBehaviour().ResetSpeed();
			}, null);
			Movement.TogJump = Submenu.AddToggle("Jump", "Jump", delegate(bool B)
			{
				Movement.GetCurentBehaviour().Jumps(B);
			}, false);
			QMNestedButton qmnestedButton3 = Submenu.AddMenuPage("Jump Settings", "Jump Settings", "Jump Setting", false, null);
			qmnestedButton3.AddButton(" Jump+", " Jump", delegate
			{
				Movement.GetCurentBehaviour().AddJump(1f);
			}, null);
			qmnestedButton3.AddButton(" Jump-", " Jump", delegate
			{
				Movement.GetCurentBehaviour().SubJump(1f);
			}, null);
			qmnestedButton3.AddButton(" Jump Reset", " Jump Reset", delegate
			{
				Movement.GetCurentBehaviour().ResetJump();
			}, null);
			QMNestedButton qmnestedButton4 = Submenu.AddMenuPage("More...", "More...", "More shit", false, null);
			qmnestedButton4.AddButton("Force jump", "Add jump", delegate
			{
				Networking.LocalPlayer.SetJumpImpulse(3f);
				LNCcolnsole.Log("Jump added", false, ConsoleColor.Green);
			}, null);
			qmnestedButton4.AddToggle("Inf-jump", "Inf-jump", delegate(bool B)
			{
				Config.Instance.Inf_jump = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Inf_jump);
			qmnestedButton4.AddToggle("Rocket-jump", "Rocket-jump", delegate(bool B)
			{
				Config.Instance.Rock_jump = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.Rock_jump);
			qmnestedButton4.AddToggle("QmFreeze", "QmFreeze", delegate(bool B)
			{
				Config.Instance.QmFreeze = B;
				Config.Instance.SaveConfig();
			}, Config.Instance.QmFreeze);
			Submenu.AddToggle("Quick Short Cuts", "Quick Short Cuts", delegate(bool B)
			{
				QOL.meadiatoggle.Toggle(B, true, false);
			}, !Config.Instance.QuickMediaOrMove);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
		public static void Atchcom()
		{
			bool flag = Funny.GetLocalPlayer().GetComponent<MoveMentV2>() == null;
			if (flag)
			{
				Funny.GetLocalPlayer().AddComponent<MoveMentV2>();
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00010004 File Offset: 0x0000E204
		public static MoveMentV2 GetCurentBehaviour()
		{
			Movement.Atchcom();
			return (Funny.GetLocalPlayer().GetComponent<MoveMentV2>() != null) ? Funny.GetLocalPlayer().GetComponent<MoveMentV2>() : null;
		}

		// Token: 0x040000C2 RID: 194
		public static QMToggleButton TogFly;

		// Token: 0x040000C3 RID: 195
		public static QMToggleButton TogNoClip;

		// Token: 0x040000C4 RID: 196
		public static QMToggleButton TogSpeed;

		// Token: 0x040000C5 RID: 197
		public static QMToggleButton TogJump;
	}
}
