using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000014 RID: 20
[DebuggerDisplay("\\{ name = {name}, value = {value}, inline = {inline} }", Type = "<Anonymous Type>")]
[CompilerGenerated]
internal sealed class Get_Rekt_By_Ruined_dgdF_lul<T, U, V>
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000075 RID: 117 RVA: 0x0000412D File Offset: 0x0000232D
	public T name
	{
		get
		{
			return this.Get_Rekt_By_Ruined_bfhC_lul;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000076 RID: 118 RVA: 0x00004135 File Offset: 0x00002335
	public U value
	{
		get
		{
			return this.Get_Rekt_By_Ruined_Gfdb_lul;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000077 RID: 119 RVA: 0x0000413D File Offset: 0x0000233D
	public V inline
	{
		get
		{
			return this.Get_Rekt_By_Ruined_BbEF_lul;
		}
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00004145 File Offset: 0x00002345
	[DebuggerHidden]
	public Get_Rekt_By_Ruined_dgdF_lul(T gparam_0, U gparam_1, V gparam_2)
	{
		this.Get_Rekt_By_Ruined_bfhC_lul = gparam_0;
		this.Get_Rekt_By_Ruined_Gfdb_lul = gparam_1;
		this.Get_Rekt_By_Ruined_BbEF_lul = gparam_2;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00006E3C File Offset: 0x0000503C
	[DebuggerHidden]
	public bool Get_Rekt_By_Ruined_BdAC_lul(object obj)
	{
		Get_Rekt_By_Ruined_dgdF_lul<T, U, V> get_Rekt_By_Ruined_dgdF_lul = obj as Get_Rekt_By_Ruined_dgdF_lul<T, U, V>;
		return get_Rekt_By_Ruined_dgdF_lul != null && EqualityComparer<T>.Default.Equals(this.Get_Rekt_By_Ruined_bfhC_lul, get_Rekt_By_Ruined_dgdF_lul.Get_Rekt_By_Ruined_bfhC_lul) && EqualityComparer<U>.Default.Equals(this.Get_Rekt_By_Ruined_Gfdb_lul, get_Rekt_By_Ruined_dgdF_lul.Get_Rekt_By_Ruined_Gfdb_lul) && EqualityComparer<V>.Default.Equals(this.Get_Rekt_By_Ruined_BbEF_lul, get_Rekt_By_Ruined_dgdF_lul.Get_Rekt_By_Ruined_BbEF_lul);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00006E9C File Offset: 0x0000509C
	[DebuggerHidden]
	public int Get_Rekt_By_Ruined_bEBB_lul()
	{
		return ((-289113375 + EqualityComparer<T>.Default.GetHashCode(this.Get_Rekt_By_Ruined_bfhC_lul)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.Get_Rekt_By_Ruined_Gfdb_lul)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.Get_Rekt_By_Ruined_BbEF_lul);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00006EF0 File Offset: 0x000050F0
	[DebuggerHidden]
	public string Get_Rekt_By_Ruined_EdaB_lul()
	{
		IFormatProvider provider = null;
		string format = "{{ name = {0}, value = {1}, inline = {2} }}";
		object[] array = new object[3];
		int num = 0;
		T get_Rekt_By_Ruined_bfhC_lul = this.Get_Rekt_By_Ruined_bfhC_lul;
		array[num] = ((get_Rekt_By_Ruined_bfhC_lul != null) ? get_Rekt_By_Ruined_bfhC_lul.ToString() : null);
		int num2 = 1;
		U get_Rekt_By_Ruined_Gfdb_lul = this.Get_Rekt_By_Ruined_Gfdb_lul;
		array[num2] = ((get_Rekt_By_Ruined_Gfdb_lul != null) ? get_Rekt_By_Ruined_Gfdb_lul.ToString() : null);
		int num3 = 2;
		V get_Rekt_By_Ruined_BbEF_lul = this.Get_Rekt_By_Ruined_BbEF_lul;
		array[num3] = ((get_Rekt_By_Ruined_BbEF_lul != null) ? get_Rekt_By_Ruined_BbEF_lul.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000045 RID: 69
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T Get_Rekt_By_Ruined_bfhC_lul;

	// Token: 0x04000046 RID: 70
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U Get_Rekt_By_Ruined_Gfdb_lul;

	// Token: 0x04000047 RID: 71
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V Get_Rekt_By_Ruined_BbEF_lul;
}
