using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000010 RID: 16
[CompilerGenerated]
[DebuggerDisplay("\\{ username = {username}, avatar_url = {avatar_url}, content = {content} }", Type = "<Anonymous Type>")]
internal sealed class Get_Rekt_By_Ruined_gCcc_lul<T, U, V>
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000055 RID: 85 RVA: 0x00003FE9 File Offset: 0x000021E9
	public T username
	{
		get
		{
			return this.Get_Rekt_By_Ruined_chgG_lul;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00003FF1 File Offset: 0x000021F1
	public U avatar_url
	{
		get
		{
			return this.Get_Rekt_By_Ruined_GCEH_lul;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00003FF9 File Offset: 0x000021F9
	public V content
	{
		get
		{
			return this.Get_Rekt_By_Ruined_fEaD_lul;
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00004001 File Offset: 0x00002201
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_gCcc_lul(T gparam_0, U gparam_1, V gparam_2)
	{
		this.Get_Rekt_By_Ruined_chgG_lul = gparam_0;
		this.Get_Rekt_By_Ruined_GCEH_lul = gparam_1;
		this.Get_Rekt_By_Ruined_fEaD_lul = gparam_2;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000067E4 File Offset: 0x000049E4
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_gCcc_lul<T, U, V> get_Rekt_By_Ruined_gCcc_lul = obj as Get_Rekt_By_Ruined_gCcc_lul<T, U, V>;
		return get_Rekt_By_Ruined_gCcc_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_chgG_lul, get_Rekt_By_Ruined_gCcc_lul.Get_Rekt_By_Ruined_chgG_lul) && EqualityComparer<U>.Default.Equals(this.Get_Rekt_By_Ruined_GCEH_lul, get_Rekt_By_Ruined_gCcc_lul.Get_Rekt_By_Ruined_GCEH_lul) && EqualityComparer<V>.Default.Equals(this.Get_Rekt_By_Ruined_fEaD_lul, get_Rekt_By_Ruined_gCcc_lul.Get_Rekt_By_Ruined_fEaD_lul);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00006844 File Offset: 0x00004A44
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return ((2107748826 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_chgG_lul)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.Get_Rekt_By_Ruined_GCEH_lul)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.Get_Rekt_By_Ruined_fEaD_lul);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00006898 File Offset: 0x00004A98
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ username = {0}, avatar_url = {1}, content = {2} }}";
		object[] array = new object[3];
		int num = 0;
		T get_Rekt_By_Ruined_chgG_lul = this.Get_Rekt_By_Ruined_chgG_lul;
		array[num] = ((get_Rekt_By_Ruined_chgG_lul != null) ? get_Rekt_By_Ruined_chgG_lul.ToString() : null);
		int num2 = 1;
		U get_Rekt_By_Ruined_GCEH_lul = this.Get_Rekt_By_Ruined_GCEH_lul;
		array[num2] = ((get_Rekt_By_Ruined_GCEH_lul != null) ? get_Rekt_By_Ruined_GCEH_lul.ToString() : null);
		int num3 = 2;
		V get_Rekt_By_Ruined_fEaD_lul = this.Get_Rekt_By_Ruined_fEaD_lul;
		array[num3] = ((get_Rekt_By_Ruined_fEaD_lul != null) ? get_Rekt_By_Ruined_fEaD_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000035 RID: 53
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_chgG_lul;

	// Token: 0x04000036 RID: 54
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U Get_Rekt_By_Ruined_GCEH_lul;

	// Token: 0x04000037 RID: 55
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V Get_Rekt_By_Ruined_fEaD_lul;
}
