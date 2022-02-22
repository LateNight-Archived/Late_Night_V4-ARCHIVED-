using System;
using System.Runtime.InteropServices;

namespace Late_Night_V3_MediaControl
{
	// Token: 0x0200001C RID: 28
	internal class MediaControl
	{
		// Token: 0x060000F8 RID: 248
		[DllImport("user32.dll", SetLastError = true)]
		private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

		// Token: 0x060000F9 RID: 249 RVA: 0x00007BA0 File Offset: 0x00005DA0
		internal static void PlayPause()
		{
			MediaControl.keybd_event(MediaControl.mediaPlayPause, MediaControl.mediaPlayPause, 0, 0);
			MediaControl.keybd_event(MediaControl.mediaPlayPause, MediaControl.mediaPlayPause, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007BCB File Offset: 0x00005DCB
		internal static void PrevTrack()
		{
			MediaControl.keybd_event(MediaControl.mediaPreviousTrack, MediaControl.mediaPreviousTrack, 0, 0);
			MediaControl.keybd_event(MediaControl.mediaPreviousTrack, MediaControl.mediaPreviousTrack, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007BF6 File Offset: 0x00005DF6
		internal static void NextTrack()
		{
			MediaControl.keybd_event(MediaControl.mediaNextTrack, MediaControl.mediaNextTrack, 0, 0);
			MediaControl.keybd_event(MediaControl.mediaNextTrack, MediaControl.mediaNextTrack, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007C21 File Offset: 0x00005E21
		internal static void Stop()
		{
			MediaControl.keybd_event(MediaControl.mediaStop, MediaControl.mediaStop, 0, 0);
			MediaControl.keybd_event(MediaControl.mediaStop, MediaControl.mediaStop, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007C4C File Offset: 0x00005E4C
		internal static void VolumeUp()
		{
			MediaControl.keybd_event(MediaControl.volUp, MediaControl.volUp, 0, 0);
			MediaControl.keybd_event(MediaControl.volUp, MediaControl.volUp, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007C77 File Offset: 0x00005E77
		internal static void VolumeDown()
		{
			MediaControl.keybd_event(MediaControl.volDown, MediaControl.volDown, 0, 0);
			MediaControl.keybd_event(MediaControl.volDown, MediaControl.volDown, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007CA2 File Offset: 0x00005EA2
		internal static void VolumeMute()
		{
			MediaControl.keybd_event(MediaControl.volMute, MediaControl.volMute, 0, 0);
			MediaControl.keybd_event(MediaControl.volMute, MediaControl.volMute, MediaControl.KEYEVENTF_KEYUP, 0);
		}

		// Token: 0x0400006F RID: 111
		private static int KEYEVENTF_KEYUP = 2;

		// Token: 0x04000070 RID: 112
		private static byte mediaPlayPause = 179;

		// Token: 0x04000071 RID: 113
		private static byte mediaNextTrack = 176;

		// Token: 0x04000072 RID: 114
		private static byte mediaPreviousTrack = 177;

		// Token: 0x04000073 RID: 115
		private static byte mediaStop = 178;

		// Token: 0x04000074 RID: 116
		private static byte volUp = 175;

		// Token: 0x04000075 RID: 117
		private static byte volDown = 174;

		// Token: 0x04000076 RID: 118
		private static byte volMute = 173;
	}
}
