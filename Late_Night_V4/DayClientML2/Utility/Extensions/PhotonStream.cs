using System;
using System.Collections.Generic;
using Photon.Realtime;
using UnityEngine;

namespace DayClientML2.Utility.Extensions
{
	// Token: 0x02000060 RID: 96
	public class PhotonStream
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x0001B5CC File Offset: 0x000197CC
		public PhotonStream(bool write, object[] incomingData)
		{
			this.isWriting = write;
			bool flag = incomingData == null;
			if (flag)
			{
				this.writeData = new Queue<object>(10);
			}
			else
			{
				this.readData = incomingData;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001B60B File Offset: 0x0001980B
		public void SetReadStream(object[] incomingData, byte pos = 0)
		{
			this.readData = incomingData;
			this.currentItem = pos;
			this.isWriting = false;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001B624 File Offset: 0x00019824
		internal void ResetWriteStream()
		{
			this.writeData.Clear();
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0001B633 File Offset: 0x00019833
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0001B63B File Offset: 0x0001983B
		public bool isWriting { get; private set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0001B644 File Offset: 0x00019844
		public bool isReading
		{
			get
			{
				return !this.isWriting;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0001B64F File Offset: 0x0001984F
		public int Count
		{
			get
			{
				return (!this.isWriting) ? this.readData.Length : this.writeData.Count;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001B670 File Offset: 0x00019870
		public object ReceiveNext()
		{
			bool isWriting = this.isWriting;
			object result;
			if (isWriting)
			{
				Debug.LogError("Error: you cannot read this stream that you are writing!");
				result = null;
			}
			else
			{
				bool flag = (int)this.currentItem >= this.Count;
				if (flag)
				{
					Debug.LogError("Error: read beyond stream length!");
					result = null;
				}
				else
				{
					object obj = this.readData[(int)this.currentItem];
					this.currentItem += 1;
					result = obj;
				}
			}
			return result;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001B6EC File Offset: 0x000198EC
		public object PeekNext()
		{
			bool flag = !this.isWriting;
			object result;
			if (flag)
			{
				result = this.readData[(int)this.currentItem];
			}
			else
			{
				Debug.LogError("Error: you cannot read this stream that you are writing!");
				result = null;
			}
			return result;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001B72C File Offset: 0x0001992C
		public void SendNext(object obj)
		{
			bool flag = !this.isWriting;
			if (flag)
			{
				Debug.LogError("Error: you cannot write/send to this stream that you are reading!");
			}
			else
			{
				this.writeData.Enqueue(obj);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0001B768 File Offset: 0x00019968
		public object[] ToArray()
		{
			return (!this.isWriting) ? this.readData : this.writeData.ToArray();
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0001B798 File Offset: 0x00019998
		public void Serialize(ref bool myBool)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(myBool);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					myBool = (bool)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0001B800 File Offset: 0x00019A00
		public void Serialize(ref int myInt)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(myInt);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					myInt = (int)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0001B868 File Offset: 0x00019A68
		public void Serialize(ref string value)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(value);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					value = (string)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0001B8CC File Offset: 0x00019ACC
		public void Serialize(ref char value)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(value);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					value = (char)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001B934 File Offset: 0x00019B34
		public void Serialize(ref short value)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(value);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					value = (short)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0001B99C File Offset: 0x00019B9C
		public void Serialize(ref float obj)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(obj);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					obj = (float)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0001BA04 File Offset: 0x00019C04
		public void Serialize(ref Player obj)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(obj);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					obj = (Player)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001BA68 File Offset: 0x00019C68
		public void Serialize(ref Vector3 obj)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(obj);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					obj = (Vector3)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001BAD8 File Offset: 0x00019CD8
		public void Serialize(ref Vector2 obj)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(obj);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					obj = (Vector2)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0001BB48 File Offset: 0x00019D48
		public void Serialize(ref Quaternion obj)
		{
			bool isWriting = this.isWriting;
			if (isWriting)
			{
				this.writeData.Enqueue(obj);
			}
			else
			{
				bool flag = this.readData.Length > (int)this.currentItem;
				if (flag)
				{
					obj = (Quaternion)this.readData[(int)this.currentItem];
					this.currentItem += 1;
				}
			}
		}

		// Token: 0x040001DA RID: 474
		private Queue<object> writeData;

		// Token: 0x040001DB RID: 475
		private object[] readData;

		// Token: 0x040001DC RID: 476
		internal byte currentItem;
	}
}
