using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000015 RID: 21
[CompilerGenerated]
[DebuggerDisplay("\\{ name = {name} }", Type = "<Anonymous Type>")]
internal sealed class Get_Rekt_By_Ruined_afhe_lul<T>
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600007C RID: 124 RVA: 0x00004162 File Offset: 0x00002362
	public T name
	{
		get
		{
			return this.Get_Rekt_By_Ruined_bfhC_lul;
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000416A File Offset: 0x0000236A
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_afhe_lul(T gparam_0)
	{
		this.Get_Rekt_By_Ruined_bfhC_lul = gparam_0;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00006F88 File Offset: 0x00005188
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_afhe_lul<T> get_Rekt_By_Ruined_afhe_lul = obj as Get_Rekt_By_Ruined_afhe_lul<T>;
		return get_Rekt_By_Ruined_afhe_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_bfhC_lul, get_Rekt_By_Ruined_afhe_lul.Get_Rekt_By_Ruined_bfhC_lul);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00004179 File Offset: 0x00002379
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return 1987306689 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_bfhC_lul);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00006FB8 File Offset: 0x000051B8
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ name = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T get_Rekt_By_Ruined_bfhC_lul = this.Get_Rekt_By_Ruined_bfhC_lul;
		array[num] = ((get_Rekt_By_Ruined_bfhC_lul != null) ? get_Rekt_By_Ruined_bfhC_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000048 RID: 72
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_bfhC_lul;
}
