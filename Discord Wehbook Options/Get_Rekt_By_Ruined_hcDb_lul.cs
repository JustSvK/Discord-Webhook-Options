using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200000F RID: 15
[CompilerGenerated]
[DebuggerDisplay("\\{ url = {url} }", Type = "<Anonymous Type>")]
internal sealed class Get_Rekt_By_Ruined_hcDb_lul<T>
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00003FBA File Offset: 0x000021BA
	public T url
	{
		get
		{
			return this.Get_Rekt_By_Ruined_egab_lul;
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00003FC2 File Offset: 0x000021C2
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_hcDb_lul(T gparam_0)
	{
		this.Get_Rekt_By_Ruined_egab_lul = gparam_0;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000676C File Offset: 0x0000496C
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_hcDb_lul<T> get_Rekt_By_Ruined_hcDb_lul = obj as Get_Rekt_By_Ruined_hcDb_lul<T>;
		return get_Rekt_By_Ruined_hcDb_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_egab_lul, get_Rekt_By_Ruined_hcDb_lul.Get_Rekt_By_Ruined_egab_lul);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003FD1 File Offset: 0x000021D1
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return 288439005 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_egab_lul);
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0000679C File Offset: 0x0000499C
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ url = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T get_Rekt_By_Ruined_egab_lul = this.Get_Rekt_By_Ruined_egab_lul;
		array[num] = ((get_Rekt_By_Ruined_egab_lul != null) ? get_Rekt_By_Ruined_egab_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000034 RID: 52
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_egab_lul;
}
