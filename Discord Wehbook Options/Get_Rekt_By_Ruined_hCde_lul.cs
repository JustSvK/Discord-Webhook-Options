using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000013 RID: 19
[DebuggerDisplay("\\{ text = {text}, icon_url = {icon_url} }", Type = "<Anonymous Type>")]
[CompilerGenerated]
internal sealed class Get_Rekt_By_Ruined_hCde_lul<T, U>
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600006F RID: 111 RVA: 0x000040D8 File Offset: 0x000022D8
	public T text
	{
		get
		{
			return this.Get_Rekt_By_Ruined_CaGd_lul;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000070 RID: 112 RVA: 0x000040E0 File Offset: 0x000022E0
	public U icon_url
	{
		get
		{
			return this.Get_Rekt_By_Ruined_AdEH_lul;
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000040E8 File Offset: 0x000022E8
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_hCde_lul(T gparam_0, U gparam_1)
	{
		this.Get_Rekt_By_Ruined_CaGd_lul = gparam_0;
		this.Get_Rekt_By_Ruined_AdEH_lul = gparam_1;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00006D84 File Offset: 0x00004F84
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_hCde_lul<T, U> get_Rekt_By_Ruined_hCde_lul = obj as Get_Rekt_By_Ruined_hCde_lul<T, U>;
		return get_Rekt_By_Ruined_hCde_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_CaGd_lul, get_Rekt_By_Ruined_hCde_lul.Get_Rekt_By_Ruined_CaGd_lul) && EqualityComparer<U>.Default.Equals(this.Get_Rekt_By_Ruined_AdEH_lul, get_Rekt_By_Ruined_hCde_lul.Get_Rekt_By_Ruined_AdEH_lul);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000040FE File Offset: 0x000022FE
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return (-1778319042 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_CaGd_lul)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.Get_Rekt_By_Ruined_AdEH_lul);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00006DCC File Offset: 0x00004FCC
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ text = {0}, icon_url = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T get_Rekt_By_Ruined_CaGd_lul = this.Get_Rekt_By_Ruined_CaGd_lul;
		array[num] = ((get_Rekt_By_Ruined_CaGd_lul != null) ? get_Rekt_By_Ruined_CaGd_lul.ToString() : null);
		int num2 = 1;
		U get_Rekt_By_Ruined_AdEH_lul = this.Get_Rekt_By_Ruined_AdEH_lul;
		array[num2] = ((get_Rekt_By_Ruined_AdEH_lul != null) ? get_Rekt_By_Ruined_AdEH_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000043 RID: 67
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_CaGd_lul;

	// Token: 0x04000044 RID: 68
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U Get_Rekt_By_Ruined_AdEH_lul;
}
