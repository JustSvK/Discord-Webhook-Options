using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000E RID: 14
[CompilerGenerated]
[DebuggerDisplay("\\{ description = {description}, title = {title}, thumbnail = {thumbnail} }", Type = "<Anonymous Type>")]
internal sealed class Get_Rekt_By_Ruined_FCCd_lul<T, U, V>
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00003F85 File Offset: 0x00002185
	public T description
	{
		get
		{
			return this.Get_Rekt_By_Ruined_eGAg_lul;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00003F8D File Offset: 0x0000218D
	public U title
	{
		get
		{
			return this.Get_Rekt_By_Ruined_hdBE_lul;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00003F95 File Offset: 0x00002195
	public V thumbnail
	{
		get
		{
			return this.Get_Rekt_By_Ruined_aACg_lul;
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003F9D File Offset: 0x0000219D
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_FCCd_lul(T gparam_0, U gparam_1, V gparam_2)
	{
		this.Get_Rekt_By_Ruined_eGAg_lul = gparam_0;
		this.Get_Rekt_By_Ruined_hdBE_lul = gparam_1;
		this.Get_Rekt_By_Ruined_aACg_lul = gparam_2;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00006620 File Offset: 0x00004820
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_FCCd_lul<T, U, V> get_Rekt_By_Ruined_FCCd_lul = obj as Get_Rekt_By_Ruined_FCCd_lul<T, U, V>;
		return get_Rekt_By_Ruined_FCCd_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_eGAg_lul, get_Rekt_By_Ruined_FCCd_lul.Get_Rekt_By_Ruined_eGAg_lul) && EqualityComparer<U>.Default.Equals(this.Get_Rekt_By_Ruined_hdBE_lul, get_Rekt_By_Ruined_FCCd_lul.Get_Rekt_By_Ruined_hdBE_lul) && EqualityComparer<V>.Default.Equals(this.Get_Rekt_By_Ruined_aACg_lul, get_Rekt_By_Ruined_FCCd_lul.Get_Rekt_By_Ruined_aACg_lul);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00006680 File Offset: 0x00004880
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return ((-558198030 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_eGAg_lul)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.Get_Rekt_By_Ruined_hdBE_lul)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.Get_Rekt_By_Ruined_aACg_lul);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000066D4 File Offset: 0x000048D4
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ description = {0}, title = {1}, thumbnail = {2} }}";
		object[] array = new object[3];
		int num = 0;
		T get_Rekt_By_Ruined_eGAg_lul = this.Get_Rekt_By_Ruined_eGAg_lul;
		array[num] = ((get_Rekt_By_Ruined_eGAg_lul != null) ? get_Rekt_By_Ruined_eGAg_lul.ToString() : null);
		int num2 = 1;
		U get_Rekt_By_Ruined_hdBE_lul = this.Get_Rekt_By_Ruined_hdBE_lul;
		array[num2] = ((get_Rekt_By_Ruined_hdBE_lul != null) ? get_Rekt_By_Ruined_hdBE_lul.ToString() : null);
		int num3 = 2;
		V get_Rekt_By_Ruined_aACg_lul = this.Get_Rekt_By_Ruined_aACg_lul;
		array[num3] = ((get_Rekt_By_Ruined_aACg_lul != null) ? get_Rekt_By_Ruined_aACg_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000031 RID: 49
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_eGAg_lul;

	// Token: 0x04000032 RID: 50
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U Get_Rekt_By_Ruined_hdBE_lul;

	// Token: 0x04000033 RID: 51
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V Get_Rekt_By_Ruined_aACg_lul;
}
