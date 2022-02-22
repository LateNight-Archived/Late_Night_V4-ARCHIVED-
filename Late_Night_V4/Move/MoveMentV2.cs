using System;
using Late_Night_config;
using Late_Night_V3_colnsole;
using UnityEngine;
using UnityEngine.XR;
using VRC.SDKBase;

namespace Late_Night_V4.Move
{
	// Token: 0x0200002B RID: 43
	internal class MoveMentV2 : MonoBehaviour
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00012684 File Offset: 0x00010884
		public MoveMentV2(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00012690 File Offset: 0x00010890
		public void OnEnable()
		{
			bool flag = base.gameObject != null;
			if (flag)
			{
				this.Self = base.gameObject;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000126BC File Offset: 0x000108BC
		public void Update()
		{
			bool flag = !RoomManager.Method_Public_Static_get_Boolean_3();
			if (!flag)
			{
				this.Mover();
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000126E0 File Offset: 0x000108E0
		public void FlyNoClip(bool Fly, bool Noclip = false)
		{
			this.FlyG = Fly;
			this.NoclipG = Noclip;
			Networking.LocalPlayer.UseLegacyLocomotion();
			Physics.gravity = (this.FlyG ? new Vector3(0f, 0f, 0f) : new Vector3(0f, -9.81f, 0f));
			this.Self.GetComponent<Collider>().enabled = !this.NoclipG;
			LNCcolnsole.Log(string.Format("Fly :{0}", this.FlyG), true, ConsoleColor.White);
			LNCcolnsole.Log(string.Format("NoClip :{0}", this.NoclipG), true, ConsoleColor.White);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00012798 File Offset: 0x00010998
		public void AddFly(float C = 1f)
		{
			Config.Instance.FlySpeed = Config.Instance.FlySpeed + C;
			LNCcolnsole.Log(string.Format("Fly Speed :{0}", Config.Instance.FlySpeed), true, ConsoleColor.White);
			this.FlyNoClip(this.FlyG, this.NoclipG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000127FC File Offset: 0x000109FC
		public void SubFly(float D = 1f)
		{
			Config.Instance.FlySpeed = Config.Instance.FlySpeed - D;
			LNCcolnsole.Log(string.Format("Fly Speed :{0}", Config.Instance.FlySpeed), true, ConsoleColor.White);
			this.FlyNoClip(this.FlyG, this.NoclipG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00012860 File Offset: 0x00010A60
		public void ResetFly()
		{
			Config.Instance.FlySpeed = 6f;
			LNCcolnsole.Log(string.Format("Fly Speed :{0}", Config.Instance.FlySpeed), true, ConsoleColor.White);
			this.FlyNoClip(this.FlyG, this.NoclipG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000128C0 File Offset: 0x00010AC0
		public void Speeds(bool A)
		{
			this.SpeedG = A;
			bool speedG = this.SpeedG;
			if (speedG)
			{
				Networking.LocalPlayer.SetWalkSpeed(Config.Instance.WalkSpeed);
				Networking.LocalPlayer.SetRunSpeed(Config.Instance.RunSpeed);
				Networking.LocalPlayer.SetStrafeSpeed(Config.Instance.WalkSpeed);
				LNCcolnsole.Log(string.Format("Speed :{0}", this.SpeedG), true, ConsoleColor.White);
			}
			else
			{
				Networking.LocalPlayer.SetWalkSpeed(2f);
				Networking.LocalPlayer.SetRunSpeed(4f);
				Networking.LocalPlayer.SetStrafeSpeed(2f);
				LNCcolnsole.Log(string.Format("Speed :{0}", this.SpeedG), true, ConsoleColor.White);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00012990 File Offset: 0x00010B90
		public void AddSpeed(float C = 1f)
		{
			Config.Instance.WalkSpeed = Config.Instance.WalkSpeed + C;
			Config.Instance.RunSpeed = Config.Instance.RunSpeed + C;
			LNCcolnsole.Log(string.Format("Walk Speed :{0}", Config.Instance.WalkSpeed), true, ConsoleColor.White);
			LNCcolnsole.Log(string.Format("Run Speed :{0}", Config.Instance.RunSpeed), true, ConsoleColor.White);
			this.Speeds(this.SpeedG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00012A28 File Offset: 0x00010C28
		public void SubSpeed(float D = 1f)
		{
			Config.Instance.WalkSpeed = Config.Instance.WalkSpeed - D;
			Config.Instance.RunSpeed = Config.Instance.RunSpeed - D;
			LNCcolnsole.Log(string.Format("Walk Speed :{0}", Config.Instance.WalkSpeed), true, ConsoleColor.White);
			LNCcolnsole.Log(string.Format("Run Speed :{0}", Config.Instance.RunSpeed), true, ConsoleColor.White);
			this.Speeds(this.SpeedG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00012AC0 File Offset: 0x00010CC0
		public void ResetSpeed()
		{
			Config.Instance.WalkSpeed = 2f;
			Config.Instance.RunSpeed = 4f;
			LNCcolnsole.Log(string.Format("Walk Speed :{0}", Config.Instance.WalkSpeed), true, ConsoleColor.White);
			LNCcolnsole.Log(string.Format("Run Speed :{0}", Config.Instance.RunSpeed), true, ConsoleColor.White);
			this.Speeds(this.SpeedG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00012B48 File Offset: 0x00010D48
		public void Jumps(bool B)
		{
			this.JumpG = B;
			bool jumpG = this.JumpG;
			if (jumpG)
			{
				Networking.LocalPlayer.SetJumpImpulse(Config.Instance.JumpPower);
				LNCcolnsole.Log(string.Format("Jump :{0}", this.JumpG), true, ConsoleColor.White);
			}
			else
			{
				Networking.LocalPlayer.SetJumpImpulse(3f);
				LNCcolnsole.Log(string.Format("Jump :{0}", this.JumpG), true, ConsoleColor.White);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00012BD0 File Offset: 0x00010DD0
		public void AddJump(float C = 1f)
		{
			Config.Instance.JumpPower = Config.Instance.JumpPower + C;
			LNCcolnsole.Log(string.Format("Jump :{0}", Config.Instance.JumpPower), true, ConsoleColor.White);
			this.Jumps(this.JumpG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00012C30 File Offset: 0x00010E30
		public void SubJump(float D = 1f)
		{
			Config.Instance.JumpPower = Config.Instance.JumpPower - D;
			LNCcolnsole.Log(string.Format("Jump :{0}", Config.Instance.JumpPower), true, ConsoleColor.White);
			this.Jumps(this.JumpG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00012C90 File Offset: 0x00010E90
		public void ResetJump()
		{
			Config.Instance.JumpPower = 3f;
			LNCcolnsole.Log(string.Format("Jump :{0}", Config.Instance.JumpPower), true, ConsoleColor.White);
			this.Jumps(this.JumpG);
			Config.Instance.SaveConfig();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00012CE8 File Offset: 0x00010EE8
		public void Mover()
		{
			bool flag = !this.FlyG;
			if (!flag)
			{
				bool isPresent = XRDevice.isPresent;
				if (isPresent)
				{
					bool flag2 = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") < 0f;
					if (flag2)
					{
						this.Self.transform.position = this.Self.transform.position - new Vector3(0f, Config.Instance.FlySpeed * Time.deltaTime, 0f);
					}
					bool flag3 = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") > 0f;
					if (flag3)
					{
						this.Self.transform.position = this.Self.transform.position + new Vector3(0f, Config.Instance.FlySpeed * Time.deltaTime, 0f);
					}
					bool flag4 = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickHorizontal") < 0f;
					if (flag4)
					{
						this.Self.transform.position += this.Self.transform.right * -1f * Config.Instance.FlySpeed * Time.deltaTime;
					}
					bool flag5 = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickHorizontal") > 0f;
					if (flag5)
					{
						this.Self.transform.position += this.Self.transform.right * Config.Instance.FlySpeed * Time.deltaTime;
					}
					bool flag6 = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical") < 0f;
					if (flag6)
					{
						this.Self.transform.position += this.Self.transform.forward * -1f * Config.Instance.FlySpeed * Time.deltaTime;
					}
					bool flag7 = Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical") > 0f;
					if (flag7)
					{
						this.Self.transform.position += this.Self.transform.forward * Config.Instance.FlySpeed * Time.deltaTime;
					}
				}
				else
				{
					bool key = Input.GetKey(113);
					if (key)
					{
						this.Self.transform.position = this.Self.transform.position - new Vector3(0f, Config.Instance.FlySpeed * Time.deltaTime, 0f);
					}
					bool key2 = Input.GetKey(101);
					if (key2)
					{
						this.Self.transform.position = this.Self.transform.position + new Vector3(0f, Config.Instance.FlySpeed * Time.deltaTime, 0f);
					}
					bool key3 = Input.GetKey(97);
					if (key3)
					{
						this.Self.transform.position += this.Self.transform.right * -1f * Config.Instance.FlySpeed * Time.deltaTime;
					}
					bool key4 = Input.GetKey(100);
					if (key4)
					{
						this.Self.transform.position += this.Self.transform.right * Config.Instance.FlySpeed * Time.deltaTime;
					}
					bool key5 = Input.GetKey(115);
					if (key5)
					{
						this.Self.transform.position += this.Self.transform.forward * -1f * Config.Instance.FlySpeed * Time.deltaTime;
					}
					bool key6 = Input.GetKey(119);
					if (key6)
					{
						this.Self.transform.position += this.Self.transform.forward * Config.Instance.FlySpeed * Time.deltaTime;
					}
				}
			}
		}

		// Token: 0x040000D4 RID: 212
		public GameObject Self;

		// Token: 0x040000D5 RID: 213
		public bool FlyG;

		// Token: 0x040000D6 RID: 214
		public bool NoclipG;

		// Token: 0x040000D7 RID: 215
		public bool SpeedG;

		// Token: 0x040000D8 RID: 216
		public bool JumpG;
	}
}
