using System;
using System.Reflection;
using HarmonyLib;
using Late_Night_V3_colnsole;

// Token: 0x02000002 RID: 2
internal class gPatch
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	public string ID { get; set; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
	// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
	public MethodBase TargetMethod { get; set; }

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
	// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000027A
	public HarmonyMethod Prefix { get; set; }

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00000283
	// (set) Token: 0x06000008 RID: 8 RVA: 0x0000208B File Offset: 0x0000028B
	public HarmonyMethod Postfix { get; set; }

	// Token: 0x06000009 RID: 9 RVA: 0x00002094 File Offset: 0x00000294
	public gPatch(string Identifier, MethodBase Target, HarmonyMethod Before, HarmonyMethod After)
	{
		this.ID = Identifier;
		this.TargetMethod = Target;
		this.Prefix = Before;
		this.Postfix = After;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000020C0 File Offset: 0x000002C0
	public void AttemptPatch()
	{
		try
		{
			Harmony harmony = new Harmony(this.ID);
			harmony.Patch(this.TargetMethod, this.Prefix, this.Postfix, null, null, null);
			string[] array = new string[7];
			array[0] = "Patching ";
			array[1] = this.TargetMethod.DeclaringType.FullName;
			array[2] = ".";
			array[3] = this.TargetMethod.Name;
			array[4] = " | with ";
			int num = 5;
			HarmonyMethod prefix = this.Prefix;
			array[num] = ((prefix != null) ? prefix.method.Name : null);
			int num2 = 6;
			HarmonyMethod postfix = this.Postfix;
			array[num2] = ((postfix != null) ? postfix.method.Name : null);
			LNCcolnsole.Patches(string.Concat(array), false, ConsoleColor.DarkMagenta);
		}
		catch (Exception ex)
		{
			LNCcolnsole.ERROR(string.Concat(new string[]
			{
				"Error in AttemptPatch! - ",
				ex.Message,
				" From:AttemptPatch ",
				ex.Source,
				" - Stack:AttemptPatch ",
				ex.StackTrace
			}), false, ConsoleColor.Red);
		}
	}
}
