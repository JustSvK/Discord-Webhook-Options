using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000D RID: 13
[CompilerGenerated]
[DebuggerDisplay("\\{ username = {username}, avatar_url = {avatar_url}, embeds = {embeds} }", Type = "<Anonymous Type>")]
internal sealed class Get_Rekt_By_Ruined_dbCg_lul<T, U, V>
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000042 RID: 66 RVA: 0x00003F50 File Offset: 0x00002150
	public T username
	{
		get
		{
			return this.Get_Rekt_By_Ruined_chgG_lul;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000043 RID: 67 RVA: 0x00003F58 File Offset: 0x00002158
	public U avatar_url
	{
		get
		{
			return this.Get_Rekt_By_Ruined_GCEH_lul;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000044 RID: 68 RVA: 0x00003F60 File Offset: 0x00002160
	public V embeds
	{
		get
		{
			return this.Get_Rekt_By_Ruined_DCAb_lul;
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00003F68 File Offset: 0x00002168
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_dbCg_lul(T gparam_0, U gparam_1, V gparam_2)
	{
		this.Get_Rekt_By_Ruined_chgG_lul = gparam_0;
		this.Get_Rekt_By_Ruined_GCEH_lul = gparam_1;
		this.Get_Rekt_By_Ruined_DCAb_lul = gparam_2;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000064D4 File Offset: 0x000046D4
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_dbCg_lul<T, U, V> get_Rekt_By_Ruined_dbCg_lul = obj as Get_Rekt_By_Ruined_dbCg_lul<T, U, V>;
		return get_Rekt_By_Ruined_dbCg_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_chgG_lul, get_Rekt_By_Ruined_dbCg_lul.Get_Rekt_By_Ruined_chgG_lul) && EqualityComparer<U>.Default.Equals(this.Get_Rekt_By_Ruined_GCEH_lul, get_Rekt_By_Ruined_dbCg_lul.Get_Rekt_By_Ruined_GCEH_lul) && EqualityComparer<V>.Default.Equals(this.Get_Rekt_By_Ruined_DCAb_lul, get_Rekt_By_Ruined_dbCg_lul.Get_Rekt_By_Ruined_DCAb_lul);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00006534 File Offset: 0x00004734
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return ((1507404991 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_chgG_lul)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.Get_Rekt_By_Ruined_GCEH_lul)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.Get_Rekt_By_Ruined_DCAb_lul);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00006588 File Offset: 0x00004788
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ username = {0}, avatar_url = {1}, embeds = {2} }}";
		object[] array = new object[3];
		int num = 0;
		T get_Rekt_By_Ruined_chgG_lul = this.Get_Rekt_By_Ruined_chgG_lul;
		array[num] = ((get_Rekt_By_Ruined_chgG_lul != null) ? get_Rekt_By_Ruined_chgG_lul.ToString() : null);
		int num2 = 1;
		U get_Rekt_By_Ruined_GCEH_lul = this.Get_Rekt_By_Ruined_GCEH_lul;
		array[num2] = ((get_Rekt_By_Ruined_GCEH_lul != null) ? get_Rekt_By_Ruined_GCEH_lul.ToString() : null);
		int num3 = 2;
		V get_Rekt_By_Ruined_DCAb_lul = this.Get_Rekt_By_Ruined_DCAb_lul;
		array[num3] = ((get_Rekt_By_Ruined_DCAb_lul != null) ? get_Rekt_By_Ruined_DCAb_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400002E RID: 46
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_chgG_lul;

	// Token: 0x0400002F RID: 47
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U Get_Rekt_By_Ruined_GCEH_lul;

	// Token: 0x04000030 RID: 48
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V Get_Rekt_By_Ruined_DCAb_lul;
}
