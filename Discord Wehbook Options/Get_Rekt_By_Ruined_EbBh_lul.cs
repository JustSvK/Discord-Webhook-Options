using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

// Token: 0x0200001A RID: 26
public partial class Get_Rekt_By_Ruined_EbBh_lul : Form
{
	// Token: 0x0600009D RID: 157 RVA: 0x000076C0 File Offset: 0x000058C0
	public void Get_Rekt_By_Ruined_CHDh_lul(object sender, MouseEventArgs e)
	{
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_Bbhh_lul = Control.MousePosition.X - base.Location.X;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_hAGe_lul = Control.MousePosition.Y - base.Location.Y;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00007710 File Offset: 0x00005910
	public void Get_Rekt_By_Ruined_DBFf_lul(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEdg_lul = Control.MousePosition;
			Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEdg_lul.X = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEdg_lul.X - Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_Bbhh_lul;
			Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEdg_lul.Y = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEdg_lul.Y - Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_hAGe_lul;
			base.Location = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEdg_lul;
		}
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00007770 File Offset: 0x00005970
	public Get_Rekt_By_Ruined_EbBh_lul()
	{
		this.Get_Rekt_By_Ruined_CacA_lul();
		base.Size = new Size(921, 172);
		this.Get_Rekt_By_Ruined_fahD_lul.Show();
		this.Get_Rekt_By_Ruined_fahD_lul.Size = new Size(921, 172);
		this.Get_Rekt_By_Ruined_fahD_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_CDea_lul.MouseDown += this.Get_Rekt_By_Ruined_CHDh_lul;
		this.Get_Rekt_By_Ruined_CDea_lul.MouseMove += this.Get_Rekt_By_Ruined_DBFf_lul;
		this.Get_Rekt_By_Ruined_cDdf_lul.Hide();
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00007818 File Offset: 0x00005A18
	private void Get_Rekt_By_Ruined_dfCB_lul(object sender, EventArgs e)
	{
		try
		{
			string text = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_hFhA_lul.DownloadString(this.Get_Rekt_By_Ruined_CaAe_lul.Text);
			object arg = JsonConvert.DeserializeObject(text);
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_gbfG_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_gbfG_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_gbfG_lul.Target;
			CallSite get_Rekt_By_Ruined_gbfG_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_gbfG_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GDBg_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GDBg_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text2 = target(get_Rekt_By_Ruined_gbfG_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GDBg_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GDBg_lul, arg, "type"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dDaG_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dDaG_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target2 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dDaG_lul.Target;
			CallSite get_Rekt_By_Ruined_dDaG_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dDaG_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dAhE_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dAhE_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text3 = target2(get_Rekt_By_Ruined_dDaG_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dAhE_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_dAhE_lul, arg, "id"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FEdh_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FEdh_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target3 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FEdh_lul.Target;
			CallSite get_Rekt_By_Ruined_FEdh_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FEdh_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeDa_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeDa_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text4 = target3(get_Rekt_By_Ruined_FEdh_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeDa_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeDa_lul, arg, "name"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GacG_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GacG_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target4 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GacG_lul.Target;
			CallSite get_Rekt_By_Ruined_GacG_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GacG_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_Edec_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_Edec_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			target4(get_Rekt_By_Ruined_GacG_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_Edec_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_Edec_lul, arg, "avatar"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAhC_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAhC_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target5 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAhC_lul.Target;
			CallSite get_Rekt_By_Ruined_hAhC_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAhC_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_DdGh_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_DdGh_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text5 = target5(get_Rekt_By_Ruined_hAhC_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_DdGh_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_DdGh_lul, arg, "channel_id"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAeh_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAeh_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target6 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAeh_lul.Target;
			CallSite get_Rekt_By_Ruined_hAeh_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_hAeh_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FgCE_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FgCE_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text6 = target6(get_Rekt_By_Ruined_hAeh_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FgCE_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_FgCE_lul, arg, "guild_id"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeHe_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeHe_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target7 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeHe_lul.Target;
			CallSite get_Rekt_By_Ruined_GeHe_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_GeHe_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_eGHg_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_eGHg_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			target7(get_Rekt_By_Ruined_GeHe_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_eGHg_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_eGHg_lul, arg, "application_id"));
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_BBhb_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_BBhb_lul = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Get_Rekt_By_Ruined_EbBh_lul)));
			}
			Func<CallSite, object, string> target8 = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_BBhb_lul.Target;
			CallSite get_Rekt_By_Ruined_BBhb_lul = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_BBhb_lul;
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_afbA_lul == null)
			{
				Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_afbA_lul = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Get_Rekt_By_Ruined_EbBh_lul), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text7 = target8(get_Rekt_By_Ruined_BBhb_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_afbA_lul.Target(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FedH_lul.Get_Rekt_By_Ruined_afbA_lul, arg, "token"));
			string text8 = string.Concat(new string[]
			{
				"Type: ",
				text2,
				"\nID: ",
				text3,
				"\nName: ",
				text4,
				"\nChannel ID: ",
				text5,
				"\nGuild ID: ",
				text6,
				"\nToken: ",
				text7
			});
			this.Get_Rekt_By_Ruined_eDhB_lul.Text = text8;
			this.Get_Rekt_By_Ruined_bABD_lul.Text = "Status: Valid Webhook URL!";
			this.Get_Rekt_By_Ruined_EBEG_lul.Enabled = true;
		}
		catch
		{
			this.Get_Rekt_By_Ruined_bABD_lul.Text = "Status: This may be a invalid Webhook URL";
			this.Get_Rekt_By_Ruined_EBEG_lul.Enabled = false;
		}
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00004254 File Offset: 0x00002454
	private void Get_Rekt_By_Ruined_AdbE_lul(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000425B File Offset: 0x0000245B
	private void Get_Rekt_By_Ruined_DBCc_lul(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00004264 File Offset: 0x00002464
	private void Get_Rekt_By_Ruined_HfDG_lul(object sender, EventArgs e)
	{
		Application.Restart();
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00007DB4 File Offset: 0x00005FB4
	private void Get_Rekt_By_Ruined_bfbg_lul(object sender, EventArgs e)
	{
		this.Get_Rekt_By_Ruined_fahD_lul.Hide();
		this.Get_Rekt_By_Ruined_cDdf_lul.Show();
		this.Get_Rekt_By_Ruined_cDdf_lul.Size = new Size(1140, 544);
		this.Get_Rekt_By_Ruined_cDdf_lul.Location = new Point(0, 0);
		base.Size = new Size(1140, 544);
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul = this.Get_Rekt_By_Ruined_CaAe_lul.Text;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00007E28 File Offset: 0x00006028
	private void Get_Rekt_By_Ruined_GahG_lul()
	{
		WebRequest webRequest = (HttpWebRequest)WebRequest.Create(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
		webRequest.ContentType = "application/json";
		webRequest.Method = "POST";
		using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
		{
			string value = JsonConvert.SerializeObject(new Get_Rekt_By_Ruined_dbCg_lul<string, string, Get_Rekt_By_Ruined_FCCd_lul<string, string, Get_Rekt_By_Ruined_hcDb_lul<string>>[]>(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FcDb_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_gceg_lul, new Get_Rekt_By_Ruined_FCCd_lul<string, string, Get_Rekt_By_Ruined_hcDb_lul<string>>[]
			{
				new Get_Rekt_By_Ruined_FCCd_lul<string, string, Get_Rekt_By_Ruined_hcDb_lul<string>>(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_dhhD_lul, Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_bFea_lul, new Get_Rekt_By_Ruined_hcDb_lul<string>(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_egCf_lul))
			}));
			streamWriter.Write(value);
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00007ED0 File Offset: 0x000060D0
	private void Get_Rekt_By_Ruined_AfgF_lul(object sender, EventArgs e)
	{
		if (this.Get_Rekt_By_Ruined_edaF_lul.Checked)
		{
			if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul.Count<char>() <= 60)
			{
				return;
			}
			try
			{
				using (HttpClient httpClient = new HttpClient())
				{
					this.Get_Rekt_By_Ruined_GahG_lul();
					Task<HttpResponseMessage> task = httpClient.DeleteAsync(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
					if (task.Result.StatusCode != HttpStatusCode.NoContent)
					{
						this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Webhook has not been deleted. This could be the result of an invalid webhook URL.";
					}
					else
					{
						this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Deleted! with Message";
					}
				}
				return;
			}
			catch
			{
				this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Error.";
				return;
			}
		}
		if (Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul.Count<char>() > 60)
		{
			try
			{
				using (HttpClient httpClient2 = new HttpClient())
				{
					Task<HttpResponseMessage> task2 = httpClient2.DeleteAsync(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
					if (task2.Result.StatusCode == HttpStatusCode.NoContent)
					{
						this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Deleted!";
					}
					else
					{
						this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Webhook has not been deleted. This could be the result of an invalid webhook URL.";
					}
				}
			}
			catch
			{
				this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Error.";
			}
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000426B File Offset: 0x0000246B
	private void Get_Rekt_By_Ruined_EfCf_lul(object sender, EventArgs e)
	{
		if (!this.Get_Rekt_By_Ruined_edaF_lul.Checked)
		{
			this.Get_Rekt_By_Ruined_aEhc_lul.Visible = false;
		}
		else
		{
			this.Get_Rekt_By_Ruined_aEhc_lul.Visible = true;
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00004294 File Offset: 0x00002494
	private void Get_Rekt_By_Ruined_cBHH_lul(object sender, EventArgs e)
	{
		new Get_Rekt_By_Ruined_cDGB_lul().Show();
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00008024 File Offset: 0x00006224
	private void Get_Rekt_By_Ruined_CAdC_lul(object sender, EventArgs e)
	{
		base.Size = new Size(921, 172);
		this.Get_Rekt_By_Ruined_fahD_lul.Show();
		this.Get_Rekt_By_Ruined_fahD_lul.Size = new Size(921, 172);
		this.Get_Rekt_By_Ruined_fahD_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_cDdf_lul.Hide();
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000042A0 File Offset: 0x000024A0
	private void Get_Rekt_By_Ruined_cgbB_lul(object sender, EventArgs e)
	{
		new Get_Rekt_By_Ruined_BdFG_lul().Show();
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000042AC File Offset: 0x000024AC
	private void Get_Rekt_By_Ruined_cHbH_lul(object sender, PaintEventArgs e)
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000042AE File Offset: 0x000024AE
	protected virtual void Get_Rekt_By_Ruined_bCHc_lul(bool disposing)
	{
		if (disposing && this.Get_Rekt_By_Ruined_DgfB_lul != null)
		{
			this.Get_Rekt_By_Ruined_DgfB_lul.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00008088 File Offset: 0x00006288
	private void Get_Rekt_By_Ruined_CacA_lul()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Get_Rekt_By_Ruined_EbBh_lul));
		this.Get_Rekt_By_Ruined_eFDb_lul = new Panel();
		this.Get_Rekt_By_Ruined_hdFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_aFhf_lul = new Panel();
		this.Get_Rekt_By_Ruined_fCdH_lul = new Panel();
		this.Get_Rekt_By_Ruined_CaAe_lul = new TextBox();
		this.Get_Rekt_By_Ruined_BHba_lul = new Panel();
		this.Get_Rekt_By_Ruined_bCEH_lul = new Panel();
		this.Get_Rekt_By_Ruined_HDGB_lul = new Panel();
		this.Get_Rekt_By_Ruined_hbGd_lul = new Panel();
		this.Get_Rekt_By_Ruined_cddf_lul = new Label();
		this.Get_Rekt_By_Ruined_EBEG_lul = new Button();
		this.Get_Rekt_By_Ruined_fahD_lul = new Panel();
		this.Get_Rekt_By_Ruined_bABD_lul = new Label();
		this.Get_Rekt_By_Ruined_cDdf_lul = new Panel();
		this.Get_Rekt_By_Ruined_ghAD_lul = new Panel();
		this.Get_Rekt_By_Ruined_aeca_lul = new Panel();
		this.Get_Rekt_By_Ruined_DfcF_lul = new Button();
		this.Get_Rekt_By_Ruined_AgAF_lul = new Panel();
		this.Get_Rekt_By_Ruined_EeeE_lul = new Label();
		this.Get_Rekt_By_Ruined_dEFd_lul = new Panel();
		this.Get_Rekt_By_Ruined_AGDH_lul = new Panel();
		this.Get_Rekt_By_Ruined_FbHg_lul = new Panel();
		this.Get_Rekt_By_Ruined_GbEB_lul = new Panel();
		this.Get_Rekt_By_Ruined_EFFg_lul = new Panel();
		this.Get_Rekt_By_Ruined_cfdF_lul = new Panel();
		this.Get_Rekt_By_Ruined_hBaa_lul = new Button();
		this.Get_Rekt_By_Ruined_GDFA_lul = new Panel();
		this.Get_Rekt_By_Ruined_Bbcc_lul = new Label();
		this.Get_Rekt_By_Ruined_hEfC_lul = new Panel();
		this.Get_Rekt_By_Ruined_hbbC_lul = new Panel();
		this.Get_Rekt_By_Ruined_eFbb_lul = new Panel();
		this.Get_Rekt_By_Ruined_Cgad_lul = new Panel();
		this.Get_Rekt_By_Ruined_FBDB_lul = new Panel();
		this.Get_Rekt_By_Ruined_CfHA_lul = new Panel();
		this.Get_Rekt_By_Ruined_aEhc_lul = new Button();
		this.Get_Rekt_By_Ruined_edaF_lul = new CheckBox();
		this.Get_Rekt_By_Ruined_aHDe_lul = new Label();
		this.Get_Rekt_By_Ruined_EdgH_lul = new Button();
		this.Get_Rekt_By_Ruined_deDe_lul = new Panel();
		this.Get_Rekt_By_Ruined_bgeB_lul = new Label();
		this.Get_Rekt_By_Ruined_BBdD_lul = new Panel();
		this.Get_Rekt_By_Ruined_ABDb_lul = new Panel();
		this.Get_Rekt_By_Ruined_BEEd_lul = new Panel();
		this.Get_Rekt_By_Ruined_GCAb_lul = new Panel();
		this.Get_Rekt_By_Ruined_dgGd_lul = new Panel();
		this.Get_Rekt_By_Ruined_GhgE_lul = new Panel();
		this.Get_Rekt_By_Ruined_eDhB_lul = new Label();
		this.Get_Rekt_By_Ruined_fHcB_lul = new Panel();
		this.Get_Rekt_By_Ruined_Bdfh_lul = new Label();
		this.Get_Rekt_By_Ruined_HhFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_deFa_lul = new Panel();
		this.Get_Rekt_By_Ruined_gfaf_lul = new Panel();
		this.Get_Rekt_By_Ruined_ecFe_lul = new Panel();
		this.Get_Rekt_By_Ruined_CgCD_lul = new Panel();
		this.Get_Rekt_By_Ruined_aCDa_lul = new Button();
		this.Get_Rekt_By_Ruined_BFcG_lul = new Button();
		this.Get_Rekt_By_Ruined_CEac_lul = new Button();
		this.Get_Rekt_By_Ruined_CDea_lul = new Label();
		this.Get_Rekt_By_Ruined_fCdH_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_fahD_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_cDdf_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_ghAD_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_aeca_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_EFFg_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_cfdF_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_FBDB_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_CfHA_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_dgGd_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_GhgE_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_CgCD_lul.SuspendLayout();
		base.SuspendLayout();
		this.Get_Rekt_By_Ruined_eFDb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eFDb_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_eFDb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_eFDb_lul.Location = new Point(0, 25);
		this.Get_Rekt_By_Ruined_eFDb_lul.Name = "panel2";
		this.Get_Rekt_By_Ruined_eFDb_lul.Size = new Size(3, 727);
		this.Get_Rekt_By_Ruined_eFDb_lul.TabIndex = 1;
		this.Get_Rekt_By_Ruined_hdFc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hdFc_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_hdFc_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_hdFc_lul.Location = new Point(1333, 25);
		this.Get_Rekt_By_Ruined_hdFc_lul.Name = "panel3";
		this.Get_Rekt_By_Ruined_hdFc_lul.Size = new Size(3, 727);
		this.Get_Rekt_By_Ruined_hdFc_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_aFhf_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_aFhf_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_aFhf_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_aFhf_lul.Location = new Point(3, 749);
		this.Get_Rekt_By_Ruined_aFhf_lul.Name = "panel4";
		this.Get_Rekt_By_Ruined_aFhf_lul.Size = new Size(1330, 3);
		this.Get_Rekt_By_Ruined_aFhf_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_CaAe_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_BHba_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_bCEH_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_HDGB_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_hbGd_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Location = new Point(20, 63);
		this.Get_Rekt_By_Ruined_fCdH_lul.Name = "panel5";
		this.Get_Rekt_By_Ruined_fCdH_lul.Size = new Size(888, 21);
		this.Get_Rekt_By_Ruined_fCdH_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_CaAe_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_CaAe_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_CaAe_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_CaAe_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_CaAe_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_CaAe_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_CaAe_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_CaAe_lul.Name = "txtWebhookURL";
		this.Get_Rekt_By_Ruined_CaAe_lul.Size = new Size(886, 19);
		this.Get_Rekt_By_Ruined_CaAe_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_CaAe_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_CaAe_lul.TextChanged += this.Get_Rekt_By_Ruined_dfCB_lul;
		this.Get_Rekt_By_Ruined_BHba_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BHba_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_BHba_lul.Location = new Point(887, 1);
		this.Get_Rekt_By_Ruined_BHba_lul.Name = "panel9";
		this.Get_Rekt_By_Ruined_BHba_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_BHba_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_bCEH_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bCEH_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_bCEH_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_bCEH_lul.Name = "panel8";
		this.Get_Rekt_By_Ruined_bCEH_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_bCEH_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_HDGB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HDGB_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_HDGB_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_HDGB_lul.Name = "panel7";
		this.Get_Rekt_By_Ruined_HDGB_lul.Size = new Size(888, 1);
		this.Get_Rekt_By_Ruined_HDGB_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_hbGd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hbGd_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_hbGd_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_hbGd_lul.Name = "panel6";
		this.Get_Rekt_By_Ruined_hbGd_lul.Size = new Size(888, 1);
		this.Get_Rekt_By_Ruined_hbGd_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_cddf_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_cddf_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_cddf_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_cddf_lul.Location = new Point(18, 46);
		this.Get_Rekt_By_Ruined_cddf_lul.Name = "label1";
		this.Get_Rekt_By_Ruined_cddf_lul.Size = new Size(154, 15);
		this.Get_Rekt_By_Ruined_cddf_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_cddf_lul.Text = "Enter Webhook target.";
		this.Get_Rekt_By_Ruined_EBEG_lul.Enabled = false;
		this.Get_Rekt_By_Ruined_EBEG_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_EBEG_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_EBEG_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_EBEG_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_EBEG_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_EBEG_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_EBEG_lul.Location = new Point(21, 90);
		this.Get_Rekt_By_Ruined_EBEG_lul.Name = "btnUse";
		this.Get_Rekt_By_Ruined_EBEG_lul.Size = new Size(886, 32);
		this.Get_Rekt_By_Ruined_EBEG_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_EBEG_lul.Text = "Use this Webhook";
		this.Get_Rekt_By_Ruined_EBEG_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_EBEG_lul.Click += this.Get_Rekt_By_Ruined_bfbg_lul;
		this.Get_Rekt_By_Ruined_fahD_lul.Controls.Add(this.Get_Rekt_By_Ruined_bABD_lul);
		this.Get_Rekt_By_Ruined_fahD_lul.Controls.Add(this.Get_Rekt_By_Ruined_EBEG_lul);
		this.Get_Rekt_By_Ruined_fahD_lul.Controls.Add(this.Get_Rekt_By_Ruined_fCdH_lul);
		this.Get_Rekt_By_Ruined_fahD_lul.Controls.Add(this.Get_Rekt_By_Ruined_cddf_lul);
		this.Get_Rekt_By_Ruined_fahD_lul.Location = new Point(51, 562);
		this.Get_Rekt_By_Ruined_fahD_lul.Name = "pnlStart";
		this.Get_Rekt_By_Ruined_fahD_lul.Size = new Size(924, 169);
		this.Get_Rekt_By_Ruined_fahD_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_bABD_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_bABD_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_bABD_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_bABD_lul.Location = new Point(0, 155);
		this.Get_Rekt_By_Ruined_bABD_lul.Name = "lblValidCh";
		this.Get_Rekt_By_Ruined_bABD_lul.Size = new Size(924, 14);
		this.Get_Rekt_By_Ruined_bABD_lul.TabIndex = 11;
		this.Get_Rekt_By_Ruined_bABD_lul.Text = "Status: Idle";
		this.Get_Rekt_By_Ruined_bABD_lul.TextAlign = ContentAlignment.MiddleCenter;
		this.Get_Rekt_By_Ruined_cDdf_lul.Controls.Add(this.Get_Rekt_By_Ruined_ghAD_lul);
		this.Get_Rekt_By_Ruined_cDdf_lul.Controls.Add(this.Get_Rekt_By_Ruined_EFFg_lul);
		this.Get_Rekt_By_Ruined_cDdf_lul.Controls.Add(this.Get_Rekt_By_Ruined_FBDB_lul);
		this.Get_Rekt_By_Ruined_cDdf_lul.Controls.Add(this.Get_Rekt_By_Ruined_dgGd_lul);
		this.Get_Rekt_By_Ruined_cDdf_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_cDdf_lul.Name = "pnlWebhook";
		this.Get_Rekt_By_Ruined_cDdf_lul.Size = new Size(1140, 544);
		this.Get_Rekt_By_Ruined_cDdf_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_cDdf_lul.Paint += this.Get_Rekt_By_Ruined_cHbH_lul;
		this.Get_Rekt_By_Ruined_ghAD_lul.Controls.Add(this.Get_Rekt_By_Ruined_aeca_lul);
		this.Get_Rekt_By_Ruined_ghAD_lul.Controls.Add(this.Get_Rekt_By_Ruined_EeeE_lul);
		this.Get_Rekt_By_Ruined_ghAD_lul.Controls.Add(this.Get_Rekt_By_Ruined_dEFd_lul);
		this.Get_Rekt_By_Ruined_ghAD_lul.Controls.Add(this.Get_Rekt_By_Ruined_AGDH_lul);
		this.Get_Rekt_By_Ruined_ghAD_lul.Controls.Add(this.Get_Rekt_By_Ruined_FbHg_lul);
		this.Get_Rekt_By_Ruined_ghAD_lul.Controls.Add(this.Get_Rekt_By_Ruined_GbEB_lul);
		this.Get_Rekt_By_Ruined_ghAD_lul.Location = new Point(632, 267);
		this.Get_Rekt_By_Ruined_ghAD_lul.Name = "panel31";
		this.Get_Rekt_By_Ruined_ghAD_lul.Size = new Size(492, 83);
		this.Get_Rekt_By_Ruined_ghAD_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_DfcF_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_AgAF_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_aeca_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_aeca_lul.Name = "panel32";
		this.Get_Rekt_By_Ruined_aeca_lul.Size = new Size(490, 67);
		this.Get_Rekt_By_Ruined_aeca_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_DfcF_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DfcF_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_DfcF_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_DfcF_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_DfcF_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_DfcF_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_DfcF_lul.Location = new Point(20, 19);
		this.Get_Rekt_By_Ruined_DfcF_lul.Name = "button3";
		this.Get_Rekt_By_Ruined_DfcF_lul.Size = new Size(450, 29);
		this.Get_Rekt_By_Ruined_DfcF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_DfcF_lul.Text = "Open Webhook spammer";
		this.Get_Rekt_By_Ruined_DfcF_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_DfcF_lul.Click += this.Get_Rekt_By_Ruined_cgbB_lul;
		this.Get_Rekt_By_Ruined_AgAF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_AgAF_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_AgAF_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_AgAF_lul.Name = "panel33";
		this.Get_Rekt_By_Ruined_AgAF_lul.Size = new Size(490, 1);
		this.Get_Rekt_By_Ruined_AgAF_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_EeeE_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_EeeE_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_EeeE_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_EeeE_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_EeeE_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_EeeE_lul.Name = "label7";
		this.Get_Rekt_By_Ruined_EeeE_lul.Size = new Size(112, 14);
		this.Get_Rekt_By_Ruined_EeeE_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_EeeE_lul.Text = "Webhook Spammer";
		this.Get_Rekt_By_Ruined_dEFd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_dEFd_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_dEFd_lul.Location = new Point(1, 82);
		this.Get_Rekt_By_Ruined_dEFd_lul.Name = "panel34";
		this.Get_Rekt_By_Ruined_dEFd_lul.Size = new Size(490, 1);
		this.Get_Rekt_By_Ruined_dEFd_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_AGDH_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_AGDH_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_AGDH_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_AGDH_lul.Name = "panel35";
		this.Get_Rekt_By_Ruined_AGDH_lul.Size = new Size(490, 1);
		this.Get_Rekt_By_Ruined_AGDH_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_FbHg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FbHg_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_FbHg_lul.Location = new Point(491, 0);
		this.Get_Rekt_By_Ruined_FbHg_lul.Name = "panel36";
		this.Get_Rekt_By_Ruined_FbHg_lul.Size = new Size(1, 83);
		this.Get_Rekt_By_Ruined_FbHg_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_GbEB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GbEB_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_GbEB_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_GbEB_lul.Name = "panel37";
		this.Get_Rekt_By_Ruined_GbEB_lul.Size = new Size(1, 83);
		this.Get_Rekt_By_Ruined_GbEB_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_cfdF_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_Bbcc_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_hEfC_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_hbbC_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_eFbb_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_Cgad_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Location = new Point(272, 166);
		this.Get_Rekt_By_Ruined_EFFg_lul.Name = "panel24";
		this.Get_Rekt_By_Ruined_EFFg_lul.Size = new Size(597, 80);
		this.Get_Rekt_By_Ruined_EFFg_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_hBaa_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_GDFA_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_cfdF_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_cfdF_lul.Name = "panel25";
		this.Get_Rekt_By_Ruined_cfdF_lul.Size = new Size(595, 64);
		this.Get_Rekt_By_Ruined_cfdF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_hBaa_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hBaa_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_hBaa_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_hBaa_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_hBaa_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_hBaa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_hBaa_lul.Location = new Point(55, 18);
		this.Get_Rekt_By_Ruined_hBaa_lul.Name = "button2";
		this.Get_Rekt_By_Ruined_hBaa_lul.Size = new Size(491, 29);
		this.Get_Rekt_By_Ruined_hBaa_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_hBaa_lul.Text = "Change Webhook";
		this.Get_Rekt_By_Ruined_hBaa_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_hBaa_lul.Click += this.Get_Rekt_By_Ruined_CAdC_lul;
		this.Get_Rekt_By_Ruined_GDFA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GDFA_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_GDFA_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_GDFA_lul.Name = "panel26";
		this.Get_Rekt_By_Ruined_GDFA_lul.Size = new Size(595, 1);
		this.Get_Rekt_By_Ruined_GDFA_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_Bbcc_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_Bbcc_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_Bbcc_lul.Name = "label6";
		this.Get_Rekt_By_Ruined_Bbcc_lul.Size = new Size(105, 14);
		this.Get_Rekt_By_Ruined_Bbcc_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Text = "Change Webhook";
		this.Get_Rekt_By_Ruined_hEfC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hEfC_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_hEfC_lul.Location = new Point(1, 79);
		this.Get_Rekt_By_Ruined_hEfC_lul.Name = "panel27";
		this.Get_Rekt_By_Ruined_hEfC_lul.Size = new Size(595, 1);
		this.Get_Rekt_By_Ruined_hEfC_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_hbbC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hbbC_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_hbbC_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_hbbC_lul.Name = "panel28";
		this.Get_Rekt_By_Ruined_hbbC_lul.Size = new Size(595, 1);
		this.Get_Rekt_By_Ruined_hbbC_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_eFbb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eFbb_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_eFbb_lul.Location = new Point(596, 0);
		this.Get_Rekt_By_Ruined_eFbb_lul.Name = "panel29";
		this.Get_Rekt_By_Ruined_eFbb_lul.Size = new Size(1, 80);
		this.Get_Rekt_By_Ruined_eFbb_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_Cgad_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_Cgad_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_Cgad_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_Cgad_lul.Name = "panel30";
		this.Get_Rekt_By_Ruined_Cgad_lul.Size = new Size(1, 80);
		this.Get_Rekt_By_Ruined_Cgad_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_FBDB_lul.Controls.Add(this.Get_Rekt_By_Ruined_CfHA_lul);
		this.Get_Rekt_By_Ruined_FBDB_lul.Controls.Add(this.Get_Rekt_By_Ruined_bgeB_lul);
		this.Get_Rekt_By_Ruined_FBDB_lul.Controls.Add(this.Get_Rekt_By_Ruined_BBdD_lul);
		this.Get_Rekt_By_Ruined_FBDB_lul.Controls.Add(this.Get_Rekt_By_Ruined_ABDb_lul);
		this.Get_Rekt_By_Ruined_FBDB_lul.Controls.Add(this.Get_Rekt_By_Ruined_BEEd_lul);
		this.Get_Rekt_By_Ruined_FBDB_lul.Controls.Add(this.Get_Rekt_By_Ruined_GCAb_lul);
		this.Get_Rekt_By_Ruined_FBDB_lul.Location = new Point(18, 252);
		this.Get_Rekt_By_Ruined_FBDB_lul.Name = "panel17";
		this.Get_Rekt_By_Ruined_FBDB_lul.Size = new Size(597, 125);
		this.Get_Rekt_By_Ruined_FBDB_lul.TabIndex = 1;
		this.Get_Rekt_By_Ruined_CfHA_lul.Controls.Add(this.Get_Rekt_By_Ruined_aEhc_lul);
		this.Get_Rekt_By_Ruined_CfHA_lul.Controls.Add(this.Get_Rekt_By_Ruined_edaF_lul);
		this.Get_Rekt_By_Ruined_CfHA_lul.Controls.Add(this.Get_Rekt_By_Ruined_aHDe_lul);
		this.Get_Rekt_By_Ruined_CfHA_lul.Controls.Add(this.Get_Rekt_By_Ruined_EdgH_lul);
		this.Get_Rekt_By_Ruined_CfHA_lul.Controls.Add(this.Get_Rekt_By_Ruined_deDe_lul);
		this.Get_Rekt_By_Ruined_CfHA_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_CfHA_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_CfHA_lul.Name = "panel18";
		this.Get_Rekt_By_Ruined_CfHA_lul.Size = new Size(595, 109);
		this.Get_Rekt_By_Ruined_CfHA_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_aEhc_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_aEhc_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_aEhc_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_aEhc_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_aEhc_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_aEhc_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aEhc_lul.Location = new Point(436, 58);
		this.Get_Rekt_By_Ruined_aEhc_lul.Name = "btnEditMessage";
		this.Get_Rekt_By_Ruined_aEhc_lul.Size = new Size(107, 29);
		this.Get_Rekt_By_Ruined_aEhc_lul.TabIndex = 12;
		this.Get_Rekt_By_Ruined_aEhc_lul.Text = "Edit Message";
		this.Get_Rekt_By_Ruined_aEhc_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_aEhc_lul.Visible = false;
		this.Get_Rekt_By_Ruined_aEhc_lul.Click += this.Get_Rekt_By_Ruined_cBHH_lul;
		this.Get_Rekt_By_Ruined_edaF_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_edaF_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_edaF_lul.FlatAppearance.CheckedBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_edaF_lul.FlatAppearance.MouseDownBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_edaF_lul.FlatAppearance.MouseOverBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_edaF_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_edaF_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_edaF_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_edaF_lul.Location = new Point(52, 65);
		this.Get_Rekt_By_Ruined_edaF_lul.Name = "cbWithMessage";
		this.Get_Rekt_By_Ruined_edaF_lul.Size = new Size(163, 18);
		this.Get_Rekt_By_Ruined_edaF_lul.TabIndex = 11;
		this.Get_Rekt_By_Ruined_edaF_lul.Text = "Delete with message?";
		this.Get_Rekt_By_Ruined_edaF_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_edaF_lul.CheckedChanged += this.Get_Rekt_By_Ruined_EfCf_lul;
		this.Get_Rekt_By_Ruined_aHDe_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_aHDe_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_aHDe_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aHDe_lul.Location = new Point(0, 95);
		this.Get_Rekt_By_Ruined_aHDe_lul.Name = "lblDelStatus";
		this.Get_Rekt_By_Ruined_aHDe_lul.Size = new Size(595, 14);
		this.Get_Rekt_By_Ruined_aHDe_lul.TabIndex = 10;
		this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Idle";
		this.Get_Rekt_By_Ruined_aHDe_lul.TextAlign = ContentAlignment.MiddleCenter;
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_EdgH_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_EdgH_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_EdgH_lul.Location = new Point(52, 30);
		this.Get_Rekt_By_Ruined_EdgH_lul.Name = "btnDeleteWb";
		this.Get_Rekt_By_Ruined_EdgH_lul.Size = new Size(491, 29);
		this.Get_Rekt_By_Ruined_EdgH_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_EdgH_lul.Text = "Delete Webhook";
		this.Get_Rekt_By_Ruined_EdgH_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_EdgH_lul.Click += this.Get_Rekt_By_Ruined_AfgF_lul;
		this.Get_Rekt_By_Ruined_deDe_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_deDe_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_deDe_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_deDe_lul.Name = "panel19";
		this.Get_Rekt_By_Ruined_deDe_lul.Size = new Size(595, 1);
		this.Get_Rekt_By_Ruined_deDe_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_bgeB_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_bgeB_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_bgeB_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_bgeB_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_bgeB_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_bgeB_lul.Name = "label5";
		this.Get_Rekt_By_Ruined_bgeB_lul.Size = new Size(112, 14);
		this.Get_Rekt_By_Ruined_bgeB_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_bgeB_lul.Text = "Webhook Deleter";
		this.Get_Rekt_By_Ruined_BBdD_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BBdD_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_BBdD_lul.Location = new Point(1, 124);
		this.Get_Rekt_By_Ruined_BBdD_lul.Name = "panel20";
		this.Get_Rekt_By_Ruined_BBdD_lul.Size = new Size(595, 1);
		this.Get_Rekt_By_Ruined_BBdD_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_ABDb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ABDb_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_ABDb_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_ABDb_lul.Name = "panel21";
		this.Get_Rekt_By_Ruined_ABDb_lul.Size = new Size(595, 1);
		this.Get_Rekt_By_Ruined_ABDb_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_BEEd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BEEd_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_BEEd_lul.Location = new Point(596, 0);
		this.Get_Rekt_By_Ruined_BEEd_lul.Name = "panel22";
		this.Get_Rekt_By_Ruined_BEEd_lul.Size = new Size(1, 125);
		this.Get_Rekt_By_Ruined_BEEd_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_GCAb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GCAb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_GCAb_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_GCAb_lul.Name = "panel23";
		this.Get_Rekt_By_Ruined_GCAb_lul.Size = new Size(1, 125);
		this.Get_Rekt_By_Ruined_GCAb_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_dgGd_lul.Controls.Add(this.Get_Rekt_By_Ruined_GhgE_lul);
		this.Get_Rekt_By_Ruined_dgGd_lul.Controls.Add(this.Get_Rekt_By_Ruined_Bdfh_lul);
		this.Get_Rekt_By_Ruined_dgGd_lul.Controls.Add(this.Get_Rekt_By_Ruined_HhFc_lul);
		this.Get_Rekt_By_Ruined_dgGd_lul.Controls.Add(this.Get_Rekt_By_Ruined_deFa_lul);
		this.Get_Rekt_By_Ruined_dgGd_lul.Controls.Add(this.Get_Rekt_By_Ruined_gfaf_lul);
		this.Get_Rekt_By_Ruined_dgGd_lul.Controls.Add(this.Get_Rekt_By_Ruined_ecFe_lul);
		this.Get_Rekt_By_Ruined_dgGd_lul.Location = new Point(17, 35);
		this.Get_Rekt_By_Ruined_dgGd_lul.Name = "panel11";
		this.Get_Rekt_By_Ruined_dgGd_lul.Size = new Size(1108, 125);
		this.Get_Rekt_By_Ruined_dgGd_lul.TabIndex = 0;
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_eDhB_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_fHcB_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_GhgE_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_GhgE_lul.Name = "panel15";
		this.Get_Rekt_By_Ruined_GhgE_lul.Size = new Size(1106, 109);
		this.Get_Rekt_By_Ruined_GhgE_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_eDhB_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_eDhB_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_eDhB_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_eDhB_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_eDhB_lul.Name = "lblTokenInfo";
		this.Get_Rekt_By_Ruined_eDhB_lul.Size = new Size(1106, 108);
		this.Get_Rekt_By_Ruined_eDhB_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_eDhB_lul.Text = "Type:\r\nID:\r\nName:\r\nChannel ID:\r\nGuild ID:\r\nApplication ID:\r\nToken:";
		this.Get_Rekt_By_Ruined_eDhB_lul.TextAlign = ContentAlignment.MiddleCenter;
		this.Get_Rekt_By_Ruined_fHcB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_fHcB_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_fHcB_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_fHcB_lul.Name = "panel16";
		this.Get_Rekt_By_Ruined_fHcB_lul.Size = new Size(1106, 1);
		this.Get_Rekt_By_Ruined_fHcB_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_Bdfh_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_Bdfh_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_Bdfh_lul.Name = "label3";
		this.Get_Rekt_By_Ruined_Bdfh_lul.Size = new Size(91, 14);
		this.Get_Rekt_By_Ruined_Bdfh_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Text = "Webhook Info";
		this.Get_Rekt_By_Ruined_HhFc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HhFc_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_HhFc_lul.Location = new Point(1, 124);
		this.Get_Rekt_By_Ruined_HhFc_lul.Name = "panel14";
		this.Get_Rekt_By_Ruined_HhFc_lul.Size = new Size(1106, 1);
		this.Get_Rekt_By_Ruined_HhFc_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_deFa_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_deFa_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_deFa_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_deFa_lul.Name = "panel13";
		this.Get_Rekt_By_Ruined_deFa_lul.Size = new Size(1106, 1);
		this.Get_Rekt_By_Ruined_deFa_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_gfaf_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_gfaf_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_gfaf_lul.Location = new Point(1107, 0);
		this.Get_Rekt_By_Ruined_gfaf_lul.Name = "panel12";
		this.Get_Rekt_By_Ruined_gfaf_lul.Size = new Size(1, 125);
		this.Get_Rekt_By_Ruined_gfaf_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_ecFe_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ecFe_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_ecFe_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_ecFe_lul.Name = "panel10";
		this.Get_Rekt_By_Ruined_ecFe_lul.Size = new Size(1, 125);
		this.Get_Rekt_By_Ruined_ecFe_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_CgCD_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CgCD_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_aCDa_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_BFcG_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_CEac_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_CDea_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_CgCD_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_CgCD_lul.Name = "panel1";
		this.Get_Rekt_By_Ruined_CgCD_lul.Size = new Size(1336, 25);
		this.Get_Rekt_By_Ruined_CgCD_lul.TabIndex = 0;
		this.Get_Rekt_By_Ruined_aCDa_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_aCDa_lul.FlatAppearance.BorderSize = 0;
		this.Get_Rekt_By_Ruined_aCDa_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_aCDa_lul.Font = new Font("Webdings", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 2);
		this.Get_Rekt_By_Ruined_aCDa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aCDa_lul.Location = new Point(1228, 0);
		this.Get_Rekt_By_Ruined_aCDa_lul.Name = "btnRestart";
		this.Get_Rekt_By_Ruined_aCDa_lul.Size = new Size(36, 25);
		this.Get_Rekt_By_Ruined_aCDa_lul.TabIndex = 9;
		this.Get_Rekt_By_Ruined_aCDa_lul.Text = "q";
		this.Get_Rekt_By_Ruined_aCDa_lul.UseVisualStyleBackColor = false;
		this.Get_Rekt_By_Ruined_aCDa_lul.Click += this.Get_Rekt_By_Ruined_HfDG_lul;
		this.Get_Rekt_By_Ruined_BFcG_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_BFcG_lul.FlatAppearance.BorderSize = 0;
		this.Get_Rekt_By_Ruined_BFcG_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_BFcG_lul.Font = new Font("Webdings", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 2);
		this.Get_Rekt_By_Ruined_BFcG_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_BFcG_lul.Location = new Point(1264, 0);
		this.Get_Rekt_By_Ruined_BFcG_lul.Name = "btnMinimize";
		this.Get_Rekt_By_Ruined_BFcG_lul.Size = new Size(36, 25);
		this.Get_Rekt_By_Ruined_BFcG_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_BFcG_lul.Text = "0";
		this.Get_Rekt_By_Ruined_BFcG_lul.UseVisualStyleBackColor = false;
		this.Get_Rekt_By_Ruined_BFcG_lul.Click += this.Get_Rekt_By_Ruined_DBCc_lul;
		this.Get_Rekt_By_Ruined_CEac_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_CEac_lul.FlatAppearance.BorderSize = 0;
		this.Get_Rekt_By_Ruined_CEac_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_CEac_lul.Font = new Font("Webdings", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 2);
		this.Get_Rekt_By_Ruined_CEac_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_CEac_lul.Location = new Point(1300, 0);
		this.Get_Rekt_By_Ruined_CEac_lul.Name = "btnExit";
		this.Get_Rekt_By_Ruined_CEac_lul.Size = new Size(36, 25);
		this.Get_Rekt_By_Ruined_CEac_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_CEac_lul.Text = "r";
		this.Get_Rekt_By_Ruined_CEac_lul.UseVisualStyleBackColor = false;
		this.Get_Rekt_By_Ruined_CEac_lul.Click += this.Get_Rekt_By_Ruined_AdbE_lul;
		this.Get_Rekt_By_Ruined_CDea_lul.BackColor = Color.Transparent;
		this.Get_Rekt_By_Ruined_CDea_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_CDea_lul.Font = new Font("Consolas", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_CDea_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_CDea_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_CDea_lul.Name = "label2";
		this.Get_Rekt_By_Ruined_CDea_lul.Size = new Size(1336, 25);
		this.Get_Rekt_By_Ruined_CDea_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_CDea_lul.Text = "Discord Webhook Options v1";
		this.Get_Rekt_By_Ruined_CDea_lul.TextAlign = ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(51, 51, 51);
		base.ClientSize = new Size(1336, 752);
		base.Controls.Add(this.Get_Rekt_By_Ruined_aFhf_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_hdFc_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_eFDb_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_CgCD_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_cDdf_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_fahD_lul);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "Form1";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Discord Webhook Options";
		this.Get_Rekt_By_Ruined_fCdH_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fCdH_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_fahD_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fahD_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_cDdf_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_ghAD_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_ghAD_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_aeca_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EFFg_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EFFg_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_cfdF_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_FBDB_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_FBDB_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_CfHA_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_CfHA_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_dgGd_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_dgGd_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_GhgE_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_CgCD_lul.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x0400005A RID: 90
	public static WebClient Get_Rekt_By_Ruined_hFhA_lul = new WebClient();

	// Token: 0x0400005B RID: 91
	public static Point Get_Rekt_By_Ruined_FEdg_lul = default(Point);

	// Token: 0x0400005C RID: 92
	public static int Get_Rekt_By_Ruined_Bbhh_lul;

	// Token: 0x0400005D RID: 93
	public static int Get_Rekt_By_Ruined_hAGe_lul;

	// Token: 0x0400005E RID: 94
	public static string Get_Rekt_By_Ruined_FEGf_lul;

	// Token: 0x0400005F RID: 95
	public static string Get_Rekt_By_Ruined_FcDb_lul;

	// Token: 0x04000060 RID: 96
	public static string Get_Rekt_By_Ruined_gceg_lul;

	// Token: 0x04000061 RID: 97
	public static string Get_Rekt_By_Ruined_dhhD_lul;

	// Token: 0x04000062 RID: 98
	public static string Get_Rekt_By_Ruined_bFea_lul;

	// Token: 0x04000063 RID: 99
	public static string Get_Rekt_By_Ruined_egCf_lul;

	// Token: 0x04000064 RID: 100
	public static Color Get_Rekt_By_Ruined_EEAE_lul;

	// Token: 0x04000065 RID: 101
	private IContainer Get_Rekt_By_Ruined_DgfB_lul = null;

	// Token: 0x04000066 RID: 102
	private Panel Get_Rekt_By_Ruined_CgCD_lul;

	// Token: 0x04000067 RID: 103
	private Label Get_Rekt_By_Ruined_CDea_lul;

	// Token: 0x04000068 RID: 104
	private Panel Get_Rekt_By_Ruined_eFDb_lul;

	// Token: 0x04000069 RID: 105
	private Panel Get_Rekt_By_Ruined_hdFc_lul;

	// Token: 0x0400006A RID: 106
	private Panel Get_Rekt_By_Ruined_aFhf_lul;

	// Token: 0x0400006B RID: 107
	private Panel Get_Rekt_By_Ruined_fCdH_lul;

	// Token: 0x0400006C RID: 108
	private TextBox Get_Rekt_By_Ruined_CaAe_lul;

	// Token: 0x0400006D RID: 109
	private Panel Get_Rekt_By_Ruined_BHba_lul;

	// Token: 0x0400006E RID: 110
	private Panel Get_Rekt_By_Ruined_bCEH_lul;

	// Token: 0x0400006F RID: 111
	private Panel Get_Rekt_By_Ruined_HDGB_lul;

	// Token: 0x04000070 RID: 112
	private Panel Get_Rekt_By_Ruined_hbGd_lul;

	// Token: 0x04000071 RID: 113
	private Label Get_Rekt_By_Ruined_cddf_lul;

	// Token: 0x04000072 RID: 114
	private Button Get_Rekt_By_Ruined_EBEG_lul;

	// Token: 0x04000073 RID: 115
	private Button Get_Rekt_By_Ruined_aCDa_lul;

	// Token: 0x04000074 RID: 116
	private Button Get_Rekt_By_Ruined_BFcG_lul;

	// Token: 0x04000075 RID: 117
	private Button Get_Rekt_By_Ruined_CEac_lul;

	// Token: 0x04000076 RID: 118
	private Panel Get_Rekt_By_Ruined_fahD_lul;

	// Token: 0x04000077 RID: 119
	private Panel Get_Rekt_By_Ruined_cDdf_lul;

	// Token: 0x04000078 RID: 120
	private Panel Get_Rekt_By_Ruined_dgGd_lul;

	// Token: 0x04000079 RID: 121
	private Panel Get_Rekt_By_Ruined_GhgE_lul;

	// Token: 0x0400007A RID: 122
	private Label Get_Rekt_By_Ruined_eDhB_lul;

	// Token: 0x0400007B RID: 123
	private Panel Get_Rekt_By_Ruined_fHcB_lul;

	// Token: 0x0400007C RID: 124
	private Label Get_Rekt_By_Ruined_Bdfh_lul;

	// Token: 0x0400007D RID: 125
	private Panel Get_Rekt_By_Ruined_HhFc_lul;

	// Token: 0x0400007E RID: 126
	private Panel Get_Rekt_By_Ruined_deFa_lul;

	// Token: 0x0400007F RID: 127
	private Panel Get_Rekt_By_Ruined_gfaf_lul;

	// Token: 0x04000080 RID: 128
	private Panel Get_Rekt_By_Ruined_ecFe_lul;

	// Token: 0x04000081 RID: 129
	private Panel Get_Rekt_By_Ruined_FBDB_lul;

	// Token: 0x04000082 RID: 130
	private Panel Get_Rekt_By_Ruined_CfHA_lul;

	// Token: 0x04000083 RID: 131
	private Label Get_Rekt_By_Ruined_aHDe_lul;

	// Token: 0x04000084 RID: 132
	private Button Get_Rekt_By_Ruined_EdgH_lul;

	// Token: 0x04000085 RID: 133
	private Panel Get_Rekt_By_Ruined_deDe_lul;

	// Token: 0x04000086 RID: 134
	private Label Get_Rekt_By_Ruined_bgeB_lul;

	// Token: 0x04000087 RID: 135
	private Panel Get_Rekt_By_Ruined_BBdD_lul;

	// Token: 0x04000088 RID: 136
	private Panel Get_Rekt_By_Ruined_ABDb_lul;

	// Token: 0x04000089 RID: 137
	private Panel Get_Rekt_By_Ruined_BEEd_lul;

	// Token: 0x0400008A RID: 138
	private Panel Get_Rekt_By_Ruined_GCAb_lul;

	// Token: 0x0400008B RID: 139
	private CheckBox Get_Rekt_By_Ruined_edaF_lul;

	// Token: 0x0400008C RID: 140
	private Label Get_Rekt_By_Ruined_bABD_lul;

	// Token: 0x0400008D RID: 141
	private Button Get_Rekt_By_Ruined_aEhc_lul;

	// Token: 0x0400008E RID: 142
	private Panel Get_Rekt_By_Ruined_EFFg_lul;

	// Token: 0x0400008F RID: 143
	private Panel Get_Rekt_By_Ruined_cfdF_lul;

	// Token: 0x04000090 RID: 144
	private Button Get_Rekt_By_Ruined_hBaa_lul;

	// Token: 0x04000091 RID: 145
	private Panel Get_Rekt_By_Ruined_GDFA_lul;

	// Token: 0x04000092 RID: 146
	private Label Get_Rekt_By_Ruined_Bbcc_lul;

	// Token: 0x04000093 RID: 147
	private Panel Get_Rekt_By_Ruined_hEfC_lul;

	// Token: 0x04000094 RID: 148
	private Panel Get_Rekt_By_Ruined_hbbC_lul;

	// Token: 0x04000095 RID: 149
	private Panel Get_Rekt_By_Ruined_eFbb_lul;

	// Token: 0x04000096 RID: 150
	private Panel Get_Rekt_By_Ruined_Cgad_lul;

	// Token: 0x04000097 RID: 151
	private Panel Get_Rekt_By_Ruined_ghAD_lul;

	// Token: 0x04000098 RID: 152
	private Panel Get_Rekt_By_Ruined_aeca_lul;

	// Token: 0x04000099 RID: 153
	private Button Get_Rekt_By_Ruined_DfcF_lul;

	// Token: 0x0400009A RID: 154
	private Panel Get_Rekt_By_Ruined_AgAF_lul;

	// Token: 0x0400009B RID: 155
	private Label Get_Rekt_By_Ruined_EeeE_lul;

	// Token: 0x0400009C RID: 156
	private Panel Get_Rekt_By_Ruined_dEFd_lul;

	// Token: 0x0400009D RID: 157
	private Panel Get_Rekt_By_Ruined_AGDH_lul;

	// Token: 0x0400009E RID: 158
	private Panel Get_Rekt_By_Ruined_FbHg_lul;

	// Token: 0x0400009F RID: 159
	private Panel Get_Rekt_By_Ruined_GbEB_lul;

	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	private static class Get_Rekt_By_Ruined_FedH_lul
	{
		// Token: 0x040000A0 RID: 160
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_GDBg_lul;

		// Token: 0x040000A1 RID: 161
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_gbfG_lul;

		// Token: 0x040000A2 RID: 162
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_dAhE_lul;

		// Token: 0x040000A3 RID: 163
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_dDaG_lul;

		// Token: 0x040000A4 RID: 164
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_GeDa_lul;

		// Token: 0x040000A5 RID: 165
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_FEdh_lul;

		// Token: 0x040000A6 RID: 166
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_Edec_lul;

		// Token: 0x040000A7 RID: 167
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_GacG_lul;

		// Token: 0x040000A8 RID: 168
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_DdGh_lul;

		// Token: 0x040000A9 RID: 169
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_hAhC_lul;

		// Token: 0x040000AA RID: 170
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_FgCE_lul;

		// Token: 0x040000AB RID: 171
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_hAeh_lul;

		// Token: 0x040000AC RID: 172
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_eGHg_lul;

		// Token: 0x040000AD RID: 173
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_GeHe_lul;

		// Token: 0x040000AE RID: 174
		public static CallSite<Func<CallSite, object, string, object>> Get_Rekt_By_Ruined_afbA_lul;

		// Token: 0x040000AF RID: 175
		public static CallSite<Func<CallSite, object, string>> Get_Rekt_By_Ruined_BBhb_lul;
	}
}
