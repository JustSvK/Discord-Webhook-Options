using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000019 RID: 25
internal class Get_Rekt_By_Ruined_hCBF_lul : ComboBox
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000098 RID: 152 RVA: 0x000073E0 File Offset: 0x000055E0
	// (set) Token: 0x06000099 RID: 153 RVA: 0x000073F8 File Offset: 0x000055F8
	public string[] Get_Rekt_By_Ruined_dCGb_lul
	{
		get
		{
			return this.Get_Rekt_By_Ruined_bEhA_lul;
		}
		set
		{
			int num = value.Length;
			this.Get_Rekt_By_Ruined_bEhA_lul = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.Get_Rekt_By_Ruined_bEhA_lul[i] = value[i];
			}
			base.Items.Clear();
			this.Get_Rekt_By_Ruined_hbaF_lul();
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00007440 File Offset: 0x00005640
	public Get_Rekt_By_Ruined_hCBF_lul()
	{
		base.DrawMode = DrawMode.OwnerDrawFixed;
		base.DropDownStyle = ComboBoxStyle.DropDownList;
		this.Get_Rekt_By_Ruined_Dghf_lul = 2;
		this.Get_Rekt_By_Ruined_fBHG_lul = 3;
		base.BeginUpdate();
		this.Get_Rekt_By_Ruined_hbaF_lul();
		base.EndUpdate();
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000074B8 File Offset: 0x000056B8
	private void Get_Rekt_By_Ruined_hbaF_lul()
	{
		if (this.Get_Rekt_By_Ruined_bEhA_lul != null)
		{
			foreach (string text in this.Get_Rekt_By_Ruined_bEhA_lul)
			{
				try
				{
					if (Color.FromName(text).IsKnownColor)
					{
						base.Items.Add(text);
					}
				}
				catch
				{
					throw new Exception("Invalid Color Name: " + text);
				}
			}
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000752C File Offset: 0x0000572C
	protected virtual void Get_Rekt_By_Ruined_ffEe_lul(DrawItemEventArgs e)
	{
		base.OnDrawItem(e);
		if ((e.State & DrawItemState.ComboBoxEdit) != DrawItemState.ComboBoxEdit)
		{
			e.DrawBackground();
		}
		Graphics graphics = e.Graphics;
		if (e.Index != -1)
		{
			this.Get_Rekt_By_Ruined_aDgC_lul = Color.FromName((string)base.Items[e.Index]);
			graphics.FillRectangle(new SolidBrush(this.Get_Rekt_By_Ruined_aDgC_lul), e.Bounds.X + this.Get_Rekt_By_Ruined_Dghf_lul, e.Bounds.Y + this.Get_Rekt_By_Ruined_Dghf_lul, e.Bounds.Width / this.Get_Rekt_By_Ruined_fBHG_lul - 2 * this.Get_Rekt_By_Ruined_Dghf_lul, e.Bounds.Height - 2 * this.Get_Rekt_By_Ruined_Dghf_lul);
			graphics.DrawRectangle(Pens.Black, e.Bounds.X + this.Get_Rekt_By_Ruined_Dghf_lul, e.Bounds.Y + this.Get_Rekt_By_Ruined_Dghf_lul, e.Bounds.Width / this.Get_Rekt_By_Ruined_fBHG_lul - 2 * this.Get_Rekt_By_Ruined_Dghf_lul, e.Bounds.Height - 2 * this.Get_Rekt_By_Ruined_Dghf_lul);
			graphics.DrawString(this.Get_Rekt_By_Ruined_aDgC_lul.Name, e.Font, new SolidBrush(this.ForeColor), (float)(e.Bounds.Width / this.Get_Rekt_By_Ruined_fBHG_lul + 5 * this.Get_Rekt_By_Ruined_Dghf_lul), (float)e.Bounds.Y);
		}
	}

	// Token: 0x04000056 RID: 86
	private string[] Get_Rekt_By_Ruined_bEhA_lul = new string[]
	{
		"Black",
		"White",
		"Red",
		"Blue",
		"Purple"
	};

	// Token: 0x04000057 RID: 87
	protected int Get_Rekt_By_Ruined_Dghf_lul;

	// Token: 0x04000058 RID: 88
	protected int Get_Rekt_By_Ruined_fBHG_lul;

	// Token: 0x04000059 RID: 89
	private Color Get_Rekt_By_Ruined_aDgC_lul;
}
