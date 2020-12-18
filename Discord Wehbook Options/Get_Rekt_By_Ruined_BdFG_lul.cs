using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

// Token: 0x0200001D RID: 29
public partial class Get_Rekt_By_Ruined_BdFG_lul : Form
{
	// Token: 0x060000BA RID: 186 RVA: 0x000076C0 File Offset: 0x000058C0
	public void Get_Rekt_By_Ruined_CHDh_lul(object sender, MouseEventArgs e)
	{
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_Bbhh_lul = Control.MousePosition.X - base.Location.X;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_hAGe_lul = Control.MousePosition.Y - base.Location.Y;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00007710 File Offset: 0x00005910
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

	// Token: 0x060000BC RID: 188 RVA: 0x0000C360 File Offset: 0x0000A560
	public Get_Rekt_By_Ruined_BdFG_lul()
	{
		this.Get_Rekt_By_Ruined_CacA_lul();
		this.Get_Rekt_By_Ruined_DggF_lul.Hide();
		this.Get_Rekt_By_Ruined_CDea_lul.MouseDown += this.Get_Rekt_By_Ruined_CHDh_lul;
		this.Get_Rekt_By_Ruined_CDea_lul.MouseMove += this.Get_Rekt_By_Ruined_DBFf_lul;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
	private void Get_Rekt_By_Ruined_DHHb_lul(object sender, EventArgs e)
	{
		if (this.Get_Rekt_By_Ruined_hAgC_lul.Text == "Start Spamming")
		{
			this.Get_Rekt_By_Ruined_hEHb_lul.Start();
			this.Get_Rekt_By_Ruined_hAgC_lul.Text = "Stop Spamming";
		}
		else
		{
			this.Get_Rekt_By_Ruined_hEHb_lul.Stop();
			this.Get_Rekt_By_Ruined_hAgC_lul.Text = "Start Spamming";
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000C420 File Offset: 0x0000A620
	private void Get_Rekt_By_Ruined_AegF_lul(object sender, EventArgs e)
	{
		try
		{
			WebRequest webRequest = (HttpWebRequest)WebRequest.Create(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
			webRequest.ContentType = "application/json";
			webRequest.Method = "POST";
			using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
			{
				string value = JsonConvert.SerializeObject(new Get_Rekt_By_Ruined_gCcc_lul<string, string, string>(this.Get_Rekt_By_Ruined_EFEB_lul.Text, this.Get_Rekt_By_Ruined_AeHH_lul.Text, this.Get_Rekt_By_Ruined_HGda_lul.Text));
				streamWriter.Write(value);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
		}
		catch (Exception ex)
		{
			this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: " + ex.Message;
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00004323 File Offset: 0x00002523
	private void Get_Rekt_By_Ruined_cbAD_lul(object sender, EventArgs e)
	{
		if (this.Get_Rekt_By_Ruined_DGFe_lul.Checked)
		{
			this.Get_Rekt_By_Ruined_DggF_lul.Show();
		}
		else
		{
			this.Get_Rekt_By_Ruined_DggF_lul.Hide();
		}
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
	private void Get_Rekt_By_Ruined_cECD_lul(object sender, EventArgs e)
	{
		if (!(this.Get_Rekt_By_Ruined_ECbE_lul.Text == "Start Spamming"))
		{
			this.Get_Rekt_By_Ruined_DCfD_lul.Stop();
			this.Get_Rekt_By_Ruined_ECbE_lul.Text = "Start Spamming";
		}
		else
		{
			this.Get_Rekt_By_Ruined_DCfD_lul.Start();
			this.Get_Rekt_By_Ruined_ECbE_lul.Text = "Stop Spamming";
		}
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0000C544 File Offset: 0x0000A744
	private void Get_Rekt_By_Ruined_GahG_lul()
	{
		try
		{
			if (this.Get_Rekt_By_Ruined_bhFA_lul.Checked)
			{
				WebRequest webRequest = (HttpWebRequest)WebRequest.Create(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
				webRequest.ContentType = "application/json";
				webRequest.Method = "POST";
				using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
				{
					string value = JsonConvert.SerializeObject(new Get_Rekt_By_Ruined_cdbG_lul<string, string, string, Get_Rekt_By_Ruined_bEBc_lul<string, string, string, Get_Rekt_By_Ruined_hCde_lul<string, string>, Get_Rekt_By_Ruined_dgdF_lul<string, string, bool>[], Get_Rekt_By_Ruined_afhe_lul<string>, Get_Rekt_By_Ruined_hcDb_lul<string>>[]>(this.Get_Rekt_By_Ruined_EFEB_lul.Text, this.Get_Rekt_By_Ruined_AeHH_lul.Text, this.Get_Rekt_By_Ruined_aEHe_lul.Text, new Get_Rekt_By_Ruined_bEBc_lul<string, string, string, Get_Rekt_By_Ruined_hCde_lul<string, string>, Get_Rekt_By_Ruined_dgdF_lul<string, string, bool>[], Get_Rekt_By_Ruined_afhe_lul<string>, Get_Rekt_By_Ruined_hcDb_lul<string>>[]
					{
						new Get_Rekt_By_Ruined_bEBc_lul<string, string, string, Get_Rekt_By_Ruined_hCde_lul<string, string>, Get_Rekt_By_Ruined_dgdF_lul<string, string, bool>[], Get_Rekt_By_Ruined_afhe_lul<string>, Get_Rekt_By_Ruined_hcDb_lul<string>>(this.Get_Rekt_By_Ruined_bfhG_lul.Text, this.Get_Rekt_By_Ruined_HDHH_lul.Text, this.Get_Rekt_By_Ruined_dEcb_lul.Text, new Get_Rekt_By_Ruined_hCde_lul<string, string>(this.Get_Rekt_By_Ruined_cAbe_lul.Text, this.Get_Rekt_By_Ruined_GDaC_lul.Text), new Get_Rekt_By_Ruined_dgdF_lul<string, string, bool>[]
						{
							new Get_Rekt_By_Ruined_dgdF_lul<string, string, bool>(this.Get_Rekt_By_Ruined_hHcH_lul.Text, this.Get_Rekt_By_Ruined_eCDF_lul.Text, true)
						}, new Get_Rekt_By_Ruined_afhe_lul<string>(this.Get_Rekt_By_Ruined_aEHe_lul.Text), new Get_Rekt_By_Ruined_hcDb_lul<string>(this.Get_Rekt_By_Ruined_BfAa_lul.Text))
					}));
					streamWriter.Write(value);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			}
			else
			{
				WebRequest webRequest2 = (HttpWebRequest)WebRequest.Create(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
				webRequest2.ContentType = "application/json";
				webRequest2.Method = "POST";
				using (StreamWriter streamWriter2 = new StreamWriter(webRequest2.GetRequestStream()))
				{
					string value2 = JsonConvert.SerializeObject(new Get_Rekt_By_Ruined_cdbG_lul<string, string, string, Get_Rekt_By_Ruined_EGCd_lul<string, string, Get_Rekt_By_Ruined_hCde_lul<string, string>, Get_Rekt_By_Ruined_afhe_lul<string>, Get_Rekt_By_Ruined_hcDb_lul<string>>[]>(this.Get_Rekt_By_Ruined_EFEB_lul.Text, this.Get_Rekt_By_Ruined_AeHH_lul.Text, this.Get_Rekt_By_Ruined_aEHe_lul.Text, new Get_Rekt_By_Ruined_EGCd_lul<string, string, Get_Rekt_By_Ruined_hCde_lul<string, string>, Get_Rekt_By_Ruined_afhe_lul<string>, Get_Rekt_By_Ruined_hcDb_lul<string>>[]
					{
						new Get_Rekt_By_Ruined_EGCd_lul<string, string, Get_Rekt_By_Ruined_hCde_lul<string, string>, Get_Rekt_By_Ruined_afhe_lul<string>, Get_Rekt_By_Ruined_hcDb_lul<string>>(this.Get_Rekt_By_Ruined_bfhG_lul.Text, this.Get_Rekt_By_Ruined_HDHH_lul.Text, new Get_Rekt_By_Ruined_hCde_lul<string, string>(this.Get_Rekt_By_Ruined_cAbe_lul.Text, this.Get_Rekt_By_Ruined_GDaC_lul.Text), new Get_Rekt_By_Ruined_afhe_lul<string>(this.Get_Rekt_By_Ruined_aEHe_lul.Text), new Get_Rekt_By_Ruined_hcDb_lul<string>(this.Get_Rekt_By_Ruined_BfAa_lul.Text))
					}));
					streamWriter2.Write(value2);
				}
				HttpWebResponse httpWebResponse2 = (HttpWebResponse)webRequest2.GetResponse();
			}
		}
		catch (Exception ex)
		{
			this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: " + ex.Message;
		}
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0000434A File Offset: 0x0000254A
	private void Get_Rekt_By_Ruined_cdeb_lul(object sender, EventArgs e)
	{
		this.Get_Rekt_By_Ruined_GahG_lul();
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
	public void Get_Rekt_By_Ruined_CBFb_lul(Get_Rekt_By_Ruined_fBeA_lul get_Rekt_By_Ruined_fBeA_lul_0)
	{
		this.Get_Rekt_By_Ruined_CDfh_lul.Encoding = get_Rekt_By_Ruined_fBeA_lul_0.Get_Rekt_By_Ruined_hAEc_lul;
		this.Get_Rekt_By_Ruined_CDfh_lul.Headers.Add("Content-Type", get_Rekt_By_Ruined_fBeA_lul_0.Get_Rekt_By_Ruined_CCea_lul);
		byte[] bytes = this.Get_Rekt_By_Ruined_CDfh_lul.Encoding.GetBytes(get_Rekt_By_Ruined_fBeA_lul_0.Get_Rekt_By_Ruined_gdhG_lul());
		this.Get_Rekt_By_Ruined_CDfh_lul.UploadData(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul, "POST", bytes);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0000C82C File Offset: 0x0000AA2C
	private void Get_Rekt_By_Ruined_dCHf_lul(object sender, EventArgs e)
	{
		try
		{
			Get_Rekt_By_Ruined_BGha_lul get_Rekt_By_Ruined_BGha_lul = new Get_Rekt_By_Ruined_BGha_lul(this.Get_Rekt_By_Ruined_AeHH_lul.Text, this.Get_Rekt_By_Ruined_EFEB_lul.Text);
			string[] string_ = new string[]
			{
				"C:/...",
				"C:/...",
				"C:/..."
			};
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string_ = openFileDialog.FileNames;
			}
			get_Rekt_By_Ruined_BGha_lul.Get_Rekt_By_Ruined_hfcB_lul(string_);
			this.Get_Rekt_By_Ruined_CBFb_lul(get_Rekt_By_Ruined_BGha_lul);
		}
		catch (Exception ex)
		{
			this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: " + ex.Message;
		}
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0000434A File Offset: 0x0000254A
	private void Get_Rekt_By_Ruined_Hadg_lul(object sender, EventArgs e)
	{
		this.Get_Rekt_By_Ruined_GahG_lul();
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000C420 File Offset: 0x0000A620
	private void Get_Rekt_By_Ruined_GefA_lul(object sender, EventArgs e)
	{
		try
		{
			WebRequest webRequest = (HttpWebRequest)WebRequest.Create(Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FEGf_lul);
			webRequest.ContentType = "application/json";
			webRequest.Method = "POST";
			using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream()))
			{
				string value = JsonConvert.SerializeObject(new Get_Rekt_By_Ruined_gCcc_lul<string, string, string>(this.Get_Rekt_By_Ruined_EFEB_lul.Text, this.Get_Rekt_By_Ruined_AeHH_lul.Text, this.Get_Rekt_By_Ruined_HGda_lul.Text));
				streamWriter.Write(value);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
		}
		catch (Exception ex)
		{
			this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: " + ex.Message;
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000042E7 File Offset: 0x000024E7
	private void Get_Rekt_By_Ruined_AdbE_lul(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000425B File Offset: 0x0000245B
	private void Get_Rekt_By_Ruined_DBCc_lul(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00004352 File Offset: 0x00002552
	private void Get_Rekt_By_Ruined_HfDG_lul(object sender, EventArgs e)
	{
		new Get_Rekt_By_Ruined_BdFG_lul().Show();
		base.Close();
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00004364 File Offset: 0x00002564
	protected virtual void Get_Rekt_By_Ruined_bCHc_lul(bool disposing)
	{
		if (disposing && this.Get_Rekt_By_Ruined_DgfB_lul != null)
		{
			this.Get_Rekt_By_Ruined_DgfB_lul.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
	private void Get_Rekt_By_Ruined_CacA_lul()
	{
		this.Get_Rekt_By_Ruined_DgfB_lul = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Get_Rekt_By_Ruined_BdFG_lul));
		this.Get_Rekt_By_Ruined_CgCD_lul = new Panel();
		this.Get_Rekt_By_Ruined_aCDa_lul = new Button();
		this.Get_Rekt_By_Ruined_BFcG_lul = new Button();
		this.Get_Rekt_By_Ruined_CEac_lul = new Button();
		this.Get_Rekt_By_Ruined_CDea_lul = new Label();
		this.Get_Rekt_By_Ruined_aFhf_lul = new Panel();
		this.Get_Rekt_By_Ruined_hdFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_eFDb_lul = new Panel();
		this.Get_Rekt_By_Ruined_EFFg_lul = new Panel();
		this.Get_Rekt_By_Ruined_cfdF_lul = new Panel();
		this.Get_Rekt_By_Ruined_CdFC_lul = new Button();
		this.Get_Rekt_By_Ruined_GDFA_lul = new Panel();
		this.Get_Rekt_By_Ruined_aeca_lul = new Panel();
		this.Get_Rekt_By_Ruined_HGda_lul = new TextBox();
		this.Get_Rekt_By_Ruined_AgAF_lul = new Panel();
		this.Get_Rekt_By_Ruined_dEFd_lul = new Panel();
		this.Get_Rekt_By_Ruined_AGDH_lul = new Panel();
		this.Get_Rekt_By_Ruined_FbHg_lul = new Panel();
		this.Get_Rekt_By_Ruined_EeeE_lul = new Label();
		this.Get_Rekt_By_Ruined_hAgC_lul = new Button();
		this.Get_Rekt_By_Ruined_Bbcc_lul = new Label();
		this.Get_Rekt_By_Ruined_hEfC_lul = new Panel();
		this.Get_Rekt_By_Ruined_hbbC_lul = new Panel();
		this.Get_Rekt_By_Ruined_eFbb_lul = new Panel();
		this.Get_Rekt_By_Ruined_Cgad_lul = new Panel();
		this.Get_Rekt_By_Ruined_cddf_lul = new Label();
		this.Get_Rekt_By_Ruined_fCdH_lul = new Panel();
		this.Get_Rekt_By_Ruined_EFEB_lul = new TextBox();
		this.Get_Rekt_By_Ruined_BHba_lul = new Panel();
		this.Get_Rekt_By_Ruined_bCEH_lul = new Panel();
		this.Get_Rekt_By_Ruined_HDGB_lul = new Panel();
		this.Get_Rekt_By_Ruined_hbGd_lul = new Panel();
		this.Get_Rekt_By_Ruined_Bdfh_lul = new Label();
		this.Get_Rekt_By_Ruined_ecFe_lul = new Panel();
		this.Get_Rekt_By_Ruined_AeHH_lul = new TextBox();
		this.Get_Rekt_By_Ruined_dgGd_lul = new Panel();
		this.Get_Rekt_By_Ruined_gfaf_lul = new Panel();
		this.Get_Rekt_By_Ruined_deFa_lul = new Panel();
		this.Get_Rekt_By_Ruined_HhFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_GhgE_lul = new Panel();
		this.Get_Rekt_By_Ruined_fHcB_lul = new Panel();
		this.Get_Rekt_By_Ruined_FBDB_lul = new Panel();
		this.Get_Rekt_By_Ruined_HFEH_lul = new Label();
		this.Get_Rekt_By_Ruined_CfHA_lul = new Panel();
		this.Get_Rekt_By_Ruined_deDe_lul = new Panel();
		this.Get_Rekt_By_Ruined_BBdD_lul = new Panel();
		this.Get_Rekt_By_Ruined_ABDb_lul = new Panel();
		this.Get_Rekt_By_Ruined_hEHb_lul = new Timer(this.Get_Rekt_By_Ruined_DgfB_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul = new Panel();
		this.Get_Rekt_By_Ruined_GCAb_lul = new Panel();
		this.Get_Rekt_By_Ruined_cGCa_lul = new Button();
		this.Get_Rekt_By_Ruined_GGcC_lul = new Button();
		this.Get_Rekt_By_Ruined_gaBG_lul = new Panel();
		this.Get_Rekt_By_Ruined_EFhB_lul = new Panel();
		this.Get_Rekt_By_Ruined_bhFA_lul = new CheckBox();
		this.Get_Rekt_By_Ruined_GgEC_lul = new Panel();
		this.Get_Rekt_By_Ruined_agHF_lul = new Panel();
		this.Get_Rekt_By_Ruined_eCDF_lul = new TextBox();
		this.Get_Rekt_By_Ruined_HffF_lul = new Panel();
		this.Get_Rekt_By_Ruined_BgHa_lul = new Panel();
		this.Get_Rekt_By_Ruined_DAHB_lul = new Panel();
		this.Get_Rekt_By_Ruined_haBa_lul = new Panel();
		this.Get_Rekt_By_Ruined_CCdf_lul = new Label();
		this.Get_Rekt_By_Ruined_AbBe_lul = new Panel();
		this.Get_Rekt_By_Ruined_HCBH_lul = new Panel();
		this.Get_Rekt_By_Ruined_hHcH_lul = new TextBox();
		this.Get_Rekt_By_Ruined_CCdd_lul = new Panel();
		this.Get_Rekt_By_Ruined_BDDA_lul = new Panel();
		this.Get_Rekt_By_Ruined_Chbg_lul = new Panel();
		this.Get_Rekt_By_Ruined_chGE_lul = new Panel();
		this.Get_Rekt_By_Ruined_aGeG_lul = new Label();
		this.Get_Rekt_By_Ruined_AgBb_lul = new Panel();
		this.Get_Rekt_By_Ruined_bGHa_lul = new Panel();
		this.Get_Rekt_By_Ruined_hCCB_lul = new Panel();
		this.Get_Rekt_By_Ruined_DGBH_lul = new Panel();
		this.Get_Rekt_By_Ruined_ecGA_lul = new Panel();
		this.Get_Rekt_By_Ruined_BfAa_lul = new TextBox();
		this.Get_Rekt_By_Ruined_Hahg_lul = new Panel();
		this.Get_Rekt_By_Ruined_hhgG_lul = new Panel();
		this.Get_Rekt_By_Ruined_aaca_lul = new Panel();
		this.Get_Rekt_By_Ruined_HccA_lul = new Panel();
		this.Get_Rekt_By_Ruined_bgeB_lul = new Label();
		this.Get_Rekt_By_Ruined_cFeb_lul = new Panel();
		this.Get_Rekt_By_Ruined_hhaB_lul = new Panel();
		this.Get_Rekt_By_Ruined_GDaC_lul = new TextBox();
		this.Get_Rekt_By_Ruined_dDHE_lul = new Panel();
		this.Get_Rekt_By_Ruined_GeCB_lul = new Panel();
		this.Get_Rekt_By_Ruined_bCbD_lul = new Panel();
		this.Get_Rekt_By_Ruined_bhGG_lul = new Panel();
		this.Get_Rekt_By_Ruined_eagH_lul = new Label();
		this.Get_Rekt_By_Ruined_hfDE_lul = new Panel();
		this.Get_Rekt_By_Ruined_HeCg_lul = new Panel();
		this.Get_Rekt_By_Ruined_cAbe_lul = new TextBox();
		this.Get_Rekt_By_Ruined_EEdH_lul = new Panel();
		this.Get_Rekt_By_Ruined_cBdF_lul = new Panel();
		this.Get_Rekt_By_Ruined_bFdd_lul = new Panel();
		this.Get_Rekt_By_Ruined_ECEg_lul = new Panel();
		this.Get_Rekt_By_Ruined_HbEc_lul = new Label();
		this.Get_Rekt_By_Ruined_ddFd_lul = new Panel();
		this.Get_Rekt_By_Ruined_fDde_lul = new Panel();
		this.Get_Rekt_By_Ruined_bfhG_lul = new TextBox();
		this.Get_Rekt_By_Ruined_DCHF_lul = new Panel();
		this.Get_Rekt_By_Ruined_gGca_lul = new Panel();
		this.Get_Rekt_By_Ruined_agad_lul = new Panel();
		this.Get_Rekt_By_Ruined_defF_lul = new Panel();
		this.Get_Rekt_By_Ruined_BgGE_lul = new Label();
		this.Get_Rekt_By_Ruined_DggF_lul = new Panel();
		this.Get_Rekt_By_Ruined_bHCE_lul = new Panel();
		this.Get_Rekt_By_Ruined_dEcb_lul = new TextBox();
		this.Get_Rekt_By_Ruined_ehdF_lul = new Panel();
		this.Get_Rekt_By_Ruined_fhgb_lul = new Panel();
		this.Get_Rekt_By_Ruined_gbHd_lul = new Panel();
		this.Get_Rekt_By_Ruined_GECE_lul = new Panel();
		this.Get_Rekt_By_Ruined_DAcf_lul = new Label();
		this.Get_Rekt_By_Ruined_EfhA_lul = new Panel();
		this.Get_Rekt_By_Ruined_DGFe_lul = new CheckBox();
		this.Get_Rekt_By_Ruined_cfFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_HDHH_lul = new TextBox();
		this.Get_Rekt_By_Ruined_FfcA_lul = new Panel();
		this.Get_Rekt_By_Ruined_gBae_lul = new Panel();
		this.Get_Rekt_By_Ruined_bEdH_lul = new Panel();
		this.Get_Rekt_By_Ruined_eedd_lul = new Panel();
		this.Get_Rekt_By_Ruined_Bbbe_lul = new Label();
		this.Get_Rekt_By_Ruined_Aegf_lul = new Panel();
		this.Get_Rekt_By_Ruined_hCHd_lul = new Panel();
		this.Get_Rekt_By_Ruined_aEHe_lul = new TextBox();
		this.Get_Rekt_By_Ruined_HCbB_lul = new Panel();
		this.Get_Rekt_By_Ruined_dbEE_lul = new Panel();
		this.Get_Rekt_By_Ruined_FGGc_lul = new Panel();
		this.Get_Rekt_By_Ruined_bEeg_lul = new Panel();
		this.Get_Rekt_By_Ruined_fhhc_lul = new Label();
		this.Get_Rekt_By_Ruined_ghAD_lul = new Panel();
		this.Get_Rekt_By_Ruined_GbEB_lul = new Panel();
		this.Get_Rekt_By_Ruined_hhGA_lul = new Panel();
		this.Get_Rekt_By_Ruined_ECbE_lul = new Button();
		this.Get_Rekt_By_Ruined_ehAb_lul = new Label();
		this.Get_Rekt_By_Ruined_CfCC_lul = new Panel();
		this.Get_Rekt_By_Ruined_FbGF_lul = new Panel();
		this.Get_Rekt_By_Ruined_AefB_lul = new Panel();
		this.Get_Rekt_By_Ruined_gCaa_lul = new Panel();
		this.Get_Rekt_By_Ruined_DCfD_lul = new Timer(this.Get_Rekt_By_Ruined_DgfB_lul);
		this.Get_Rekt_By_Ruined_aHDe_lul = new Label();
		this.Get_Rekt_By_Ruined_CgCD_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_EFFg_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_cfdF_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_aeca_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_fCdH_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_ecFe_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_GhgE_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_fHcB_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_BEEd_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_GCAb_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_gaBG_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_EFhB_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_GgEC_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_agHF_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_AbBe_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_HCBH_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_hCCB_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_DGBH_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_ecGA_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_cFeb_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_hhaB_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_hfDE_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_HeCg_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_ddFd_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_fDde_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_DggF_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_bHCE_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_EfhA_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_cfFc_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_Aegf_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_hCHd_lul.SuspendLayout();
		base.SuspendLayout();
		this.Get_Rekt_By_Ruined_CgCD_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CgCD_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_aCDa_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_BFcG_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_CEac_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Controls.Add(this.Get_Rekt_By_Ruined_CDea_lul);
		this.Get_Rekt_By_Ruined_CgCD_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_CgCD_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_CgCD_lul.Name = "panel1";
		this.Get_Rekt_By_Ruined_CgCD_lul.Size = new Size(726, 25);
		this.Get_Rekt_By_Ruined_CgCD_lul.TabIndex = 1;
		this.Get_Rekt_By_Ruined_aCDa_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_aCDa_lul.FlatAppearance.BorderSize = 0;
		this.Get_Rekt_By_Ruined_aCDa_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_aCDa_lul.Font = new Font("Webdings", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 2);
		this.Get_Rekt_By_Ruined_aCDa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aCDa_lul.Location = new Point(618, 0);
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
		this.Get_Rekt_By_Ruined_BFcG_lul.Location = new Point(654, 0);
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
		this.Get_Rekt_By_Ruined_CEac_lul.Location = new Point(690, 0);
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
		this.Get_Rekt_By_Ruined_CDea_lul.Size = new Size(726, 25);
		this.Get_Rekt_By_Ruined_CDea_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_CDea_lul.Text = "Webhook Spammer";
		this.Get_Rekt_By_Ruined_CDea_lul.TextAlign = ContentAlignment.MiddleLeft;
		this.Get_Rekt_By_Ruined_aFhf_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_aFhf_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_aFhf_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_aFhf_lul.Location = new Point(3, 647);
		this.Get_Rekt_By_Ruined_aFhf_lul.Name = "panel4";
		this.Get_Rekt_By_Ruined_aFhf_lul.Size = new Size(720, 3);
		this.Get_Rekt_By_Ruined_aFhf_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_hdFc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hdFc_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_hdFc_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_hdFc_lul.Location = new Point(723, 25);
		this.Get_Rekt_By_Ruined_hdFc_lul.Name = "panel3";
		this.Get_Rekt_By_Ruined_hdFc_lul.Size = new Size(3, 625);
		this.Get_Rekt_By_Ruined_hdFc_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_eFDb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eFDb_lul.BackgroundImageLayout = ImageLayout.Stretch;
		this.Get_Rekt_By_Ruined_eFDb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_eFDb_lul.Location = new Point(0, 25);
		this.Get_Rekt_By_Ruined_eFDb_lul.Name = "panel2";
		this.Get_Rekt_By_Ruined_eFDb_lul.Size = new Size(3, 625);
		this.Get_Rekt_By_Ruined_eFDb_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_cfdF_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_Bbcc_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_hEfC_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_hbbC_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_eFbb_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Controls.Add(this.Get_Rekt_By_Ruined_Cgad_lul);
		this.Get_Rekt_By_Ruined_EFFg_lul.Location = new Point(258, 32);
		this.Get_Rekt_By_Ruined_EFFg_lul.Name = "panel24";
		this.Get_Rekt_By_Ruined_EFFg_lul.Size = new Size(442, 143);
		this.Get_Rekt_By_Ruined_EFFg_lul.TabIndex = 9;
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_CdFC_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_GDFA_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_aeca_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_EeeE_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_hAgC_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_cfdF_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_cfdF_lul.Name = "panel25";
		this.Get_Rekt_By_Ruined_cfdF_lul.Size = new Size(440, 127);
		this.Get_Rekt_By_Ruined_cfdF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_CdFC_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CdFC_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_CdFC_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_CdFC_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_CdFC_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_CdFC_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_CdFC_lul.Location = new Point(223, 86);
		this.Get_Rekt_By_Ruined_CdFC_lul.Name = "btnSingleMessage";
		this.Get_Rekt_By_Ruined_CdFC_lul.Size = new Size(204, 29);
		this.Get_Rekt_By_Ruined_CdFC_lul.TabIndex = 13;
		this.Get_Rekt_By_Ruined_CdFC_lul.Text = "Send Single Message";
		this.Get_Rekt_By_Ruined_CdFC_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_CdFC_lul.Click += this.Get_Rekt_By_Ruined_GefA_lul;
		this.Get_Rekt_By_Ruined_GDFA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GDFA_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_GDFA_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_GDFA_lul.Name = "panel26";
		this.Get_Rekt_By_Ruined_GDFA_lul.Size = new Size(440, 1);
		this.Get_Rekt_By_Ruined_GDFA_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_HGda_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_AgAF_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_dEFd_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_AGDH_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Controls.Add(this.Get_Rekt_By_Ruined_FbHg_lul);
		this.Get_Rekt_By_Ruined_aeca_lul.Location = new Point(14, 29);
		this.Get_Rekt_By_Ruined_aeca_lul.Name = "panel32";
		this.Get_Rekt_By_Ruined_aeca_lul.Size = new Size(413, 51);
		this.Get_Rekt_By_Ruined_aeca_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_HGda_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_HGda_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_HGda_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_HGda_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_HGda_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_HGda_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_HGda_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_HGda_lul.Name = "txtMessage";
		this.Get_Rekt_By_Ruined_HGda_lul.Size = new Size(411, 49);
		this.Get_Rekt_By_Ruined_HGda_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_HGda_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_AgAF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_AgAF_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_AgAF_lul.Location = new Point(412, 1);
		this.Get_Rekt_By_Ruined_AgAF_lul.Name = "panel33";
		this.Get_Rekt_By_Ruined_AgAF_lul.Size = new Size(1, 49);
		this.Get_Rekt_By_Ruined_AgAF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_dEFd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_dEFd_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_dEFd_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_dEFd_lul.Name = "panel34";
		this.Get_Rekt_By_Ruined_dEFd_lul.Size = new Size(1, 49);
		this.Get_Rekt_By_Ruined_dEFd_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_AGDH_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_AGDH_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_AGDH_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_AGDH_lul.Name = "panel35";
		this.Get_Rekt_By_Ruined_AGDH_lul.Size = new Size(413, 1);
		this.Get_Rekt_By_Ruined_AGDH_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_FbHg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FbHg_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_FbHg_lul.Location = new Point(0, 50);
		this.Get_Rekt_By_Ruined_FbHg_lul.Name = "panel36";
		this.Get_Rekt_By_Ruined_FbHg_lul.Size = new Size(413, 1);
		this.Get_Rekt_By_Ruined_FbHg_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_EeeE_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_EeeE_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_EeeE_lul.Location = new Point(11, 12);
		this.Get_Rekt_By_Ruined_EeeE_lul.Name = "label7";
		this.Get_Rekt_By_Ruined_EeeE_lul.Size = new Size(56, 14);
		this.Get_Rekt_By_Ruined_EeeE_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_EeeE_lul.Text = "Message";
		this.Get_Rekt_By_Ruined_hAgC_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hAgC_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_hAgC_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_hAgC_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_hAgC_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_hAgC_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_hAgC_lul.Location = new Point(14, 86);
		this.Get_Rekt_By_Ruined_hAgC_lul.Name = "btnStartSpammer";
		this.Get_Rekt_By_Ruined_hAgC_lul.Size = new Size(202, 29);
		this.Get_Rekt_By_Ruined_hAgC_lul.TabIndex = 12;
		this.Get_Rekt_By_Ruined_hAgC_lul.Text = "Start Spamming";
		this.Get_Rekt_By_Ruined_hAgC_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_hAgC_lul.Click += this.Get_Rekt_By_Ruined_DHHb_lul;
		this.Get_Rekt_By_Ruined_Bbcc_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_Bbcc_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_Bbcc_lul.Name = "label6";
		this.Get_Rekt_By_Ruined_Bbcc_lul.Size = new Size(112, 14);
		this.Get_Rekt_By_Ruined_Bbcc_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Text = "Regular Spammer";
		this.Get_Rekt_By_Ruined_hEfC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hEfC_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_hEfC_lul.Location = new Point(1, 142);
		this.Get_Rekt_By_Ruined_hEfC_lul.Name = "panel27";
		this.Get_Rekt_By_Ruined_hEfC_lul.Size = new Size(440, 1);
		this.Get_Rekt_By_Ruined_hEfC_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_hbbC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hbbC_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_hbbC_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_hbbC_lul.Name = "panel28";
		this.Get_Rekt_By_Ruined_hbbC_lul.Size = new Size(440, 1);
		this.Get_Rekt_By_Ruined_hbbC_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_eFbb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eFbb_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_eFbb_lul.Location = new Point(441, 0);
		this.Get_Rekt_By_Ruined_eFbb_lul.Name = "panel29";
		this.Get_Rekt_By_Ruined_eFbb_lul.Size = new Size(1, 143);
		this.Get_Rekt_By_Ruined_eFbb_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_Cgad_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_Cgad_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_Cgad_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_Cgad_lul.Name = "panel30";
		this.Get_Rekt_By_Ruined_Cgad_lul.Size = new Size(1, 143);
		this.Get_Rekt_By_Ruined_Cgad_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_cddf_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_cddf_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_cddf_lul.Location = new Point(12, 23);
		this.Get_Rekt_By_Ruined_cddf_lul.Name = "label1";
		this.Get_Rekt_By_Ruined_cddf_lul.Size = new Size(70, 14);
		this.Get_Rekt_By_Ruined_cddf_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_cddf_lul.Text = "Username:";
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_EFEB_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_BHba_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_bCEH_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_HDGB_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_hbGd_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Location = new Point(15, 40);
		this.Get_Rekt_By_Ruined_fCdH_lul.Name = "panel5";
		this.Get_Rekt_By_Ruined_fCdH_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_fCdH_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_EFEB_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_EFEB_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_EFEB_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_EFEB_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_EFEB_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_EFEB_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_EFEB_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_EFEB_lul.Name = "txtUsername";
		this.Get_Rekt_By_Ruined_EFEB_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_EFEB_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_EFEB_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_BHba_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BHba_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_BHba_lul.Location = new Point(210, 1);
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
		this.Get_Rekt_By_Ruined_HDGB_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_HDGB_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_hbGd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hbGd_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_hbGd_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_hbGd_lul.Name = "panel6";
		this.Get_Rekt_By_Ruined_hbGd_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_hbGd_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_Bdfh_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_Bdfh_lul.Location = new Point(12, 66);
		this.Get_Rekt_By_Ruined_Bdfh_lul.Name = "label3";
		this.Get_Rekt_By_Ruined_Bdfh_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_Bdfh_lul.TabIndex = 10;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Text = "Avatar URL:";
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_AeHH_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_dgGd_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_gfaf_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_deFa_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_HhFc_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Location = new Point(15, 83);
		this.Get_Rekt_By_Ruined_ecFe_lul.Name = "panel10";
		this.Get_Rekt_By_Ruined_ecFe_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_ecFe_lul.TabIndex = 9;
		this.Get_Rekt_By_Ruined_AeHH_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_AeHH_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_AeHH_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_AeHH_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_AeHH_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_AeHH_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_AeHH_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_AeHH_lul.Name = "txtAvatarURL";
		this.Get_Rekt_By_Ruined_AeHH_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_AeHH_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_AeHH_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_dgGd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_dgGd_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_dgGd_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_dgGd_lul.Name = "panel11";
		this.Get_Rekt_By_Ruined_dgGd_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_dgGd_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_gfaf_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_gfaf_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_gfaf_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_gfaf_lul.Name = "panel12";
		this.Get_Rekt_By_Ruined_gfaf_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_gfaf_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_deFa_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_deFa_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_deFa_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_deFa_lul.Name = "panel13";
		this.Get_Rekt_By_Ruined_deFa_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_deFa_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_HhFc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HhFc_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_HhFc_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_HhFc_lul.Name = "panel14";
		this.Get_Rekt_By_Ruined_HhFc_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_HhFc_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_fHcB_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_HFEH_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_CfHA_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_deDe_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_BBdD_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_ABDb_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Location = new Point(12, 32);
		this.Get_Rekt_By_Ruined_GhgE_lul.Name = "panel15";
		this.Get_Rekt_By_Ruined_GhgE_lul.Size = new Size(240, 143);
		this.Get_Rekt_By_Ruined_GhgE_lul.TabIndex = 10;
		this.Get_Rekt_By_Ruined_fHcB_lul.Controls.Add(this.Get_Rekt_By_Ruined_Bdfh_lul);
		this.Get_Rekt_By_Ruined_fHcB_lul.Controls.Add(this.Get_Rekt_By_Ruined_FBDB_lul);
		this.Get_Rekt_By_Ruined_fHcB_lul.Controls.Add(this.Get_Rekt_By_Ruined_fCdH_lul);
		this.Get_Rekt_By_Ruined_fHcB_lul.Controls.Add(this.Get_Rekt_By_Ruined_ecFe_lul);
		this.Get_Rekt_By_Ruined_fHcB_lul.Controls.Add(this.Get_Rekt_By_Ruined_cddf_lul);
		this.Get_Rekt_By_Ruined_fHcB_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_fHcB_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_fHcB_lul.Name = "panel16";
		this.Get_Rekt_By_Ruined_fHcB_lul.Size = new Size(238, 127);
		this.Get_Rekt_By_Ruined_fHcB_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_FBDB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FBDB_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_FBDB_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_FBDB_lul.Name = "panel17";
		this.Get_Rekt_By_Ruined_FBDB_lul.Size = new Size(238, 1);
		this.Get_Rekt_By_Ruined_FBDB_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_HFEH_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_HFEH_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_HFEH_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_HFEH_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_HFEH_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_HFEH_lul.Name = "label4";
		this.Get_Rekt_By_Ruined_HFEH_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_HFEH_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_HFEH_lul.Text = "Bot options";
		this.Get_Rekt_By_Ruined_CfHA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CfHA_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_CfHA_lul.Location = new Point(1, 142);
		this.Get_Rekt_By_Ruined_CfHA_lul.Name = "panel18";
		this.Get_Rekt_By_Ruined_CfHA_lul.Size = new Size(238, 1);
		this.Get_Rekt_By_Ruined_CfHA_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_deDe_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_deDe_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_deDe_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_deDe_lul.Name = "panel19";
		this.Get_Rekt_By_Ruined_deDe_lul.Size = new Size(238, 1);
		this.Get_Rekt_By_Ruined_deDe_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_BBdD_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BBdD_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_BBdD_lul.Location = new Point(239, 0);
		this.Get_Rekt_By_Ruined_BBdD_lul.Name = "panel20";
		this.Get_Rekt_By_Ruined_BBdD_lul.Size = new Size(1, 143);
		this.Get_Rekt_By_Ruined_BBdD_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_ABDb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ABDb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_ABDb_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_ABDb_lul.Name = "panel21";
		this.Get_Rekt_By_Ruined_ABDb_lul.Size = new Size(1, 143);
		this.Get_Rekt_By_Ruined_ABDb_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_hEHb_lul.Interval = 500;
		this.Get_Rekt_By_Ruined_hEHb_lul.Tick += this.Get_Rekt_By_Ruined_AegF_lul;
		this.Get_Rekt_By_Ruined_BEEd_lul.Controls.Add(this.Get_Rekt_By_Ruined_GCAb_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul.Controls.Add(this.Get_Rekt_By_Ruined_ehAb_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul.Controls.Add(this.Get_Rekt_By_Ruined_CfCC_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul.Controls.Add(this.Get_Rekt_By_Ruined_FbGF_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul.Controls.Add(this.Get_Rekt_By_Ruined_AefB_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul.Controls.Add(this.Get_Rekt_By_Ruined_gCaa_lul);
		this.Get_Rekt_By_Ruined_BEEd_lul.Location = new Point(13, 180);
		this.Get_Rekt_By_Ruined_BEEd_lul.Name = "panel22";
		this.Get_Rekt_By_Ruined_BEEd_lul.Size = new Size(687, 444);
		this.Get_Rekt_By_Ruined_BEEd_lul.TabIndex = 11;
		this.Get_Rekt_By_Ruined_GCAb_lul.Controls.Add(this.Get_Rekt_By_Ruined_cGCa_lul);
		this.Get_Rekt_By_Ruined_GCAb_lul.Controls.Add(this.Get_Rekt_By_Ruined_GGcC_lul);
		this.Get_Rekt_By_Ruined_GCAb_lul.Controls.Add(this.Get_Rekt_By_Ruined_gaBG_lul);
		this.Get_Rekt_By_Ruined_GCAb_lul.Controls.Add(this.Get_Rekt_By_Ruined_hCCB_lul);
		this.Get_Rekt_By_Ruined_GCAb_lul.Controls.Add(this.Get_Rekt_By_Ruined_hhGA_lul);
		this.Get_Rekt_By_Ruined_GCAb_lul.Controls.Add(this.Get_Rekt_By_Ruined_ECbE_lul);
		this.Get_Rekt_By_Ruined_GCAb_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_GCAb_lul.Location = new Point(1, 15);
		this.Get_Rekt_By_Ruined_GCAb_lul.Name = "panel23";
		this.Get_Rekt_By_Ruined_GCAb_lul.Size = new Size(685, 428);
		this.Get_Rekt_By_Ruined_GCAb_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_cGCa_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_cGCa_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_cGCa_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_cGCa_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_cGCa_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_cGCa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_cGCa_lul.Location = new Point(349, 383);
		this.Get_Rekt_By_Ruined_cGCa_lul.Name = "btnSingleEmbed";
		this.Get_Rekt_By_Ruined_cGCa_lul.Size = new Size(322, 29);
		this.Get_Rekt_By_Ruined_cGCa_lul.TabIndex = 27;
		this.Get_Rekt_By_Ruined_cGCa_lul.Text = "Send Single Embed";
		this.Get_Rekt_By_Ruined_cGCa_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_cGCa_lul.Click += this.Get_Rekt_By_Ruined_Hadg_lul;
		this.Get_Rekt_By_Ruined_GGcC_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GGcC_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_GGcC_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_GGcC_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_GGcC_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_GGcC_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_GGcC_lul.Location = new Point(349, 348);
		this.Get_Rekt_By_Ruined_GGcC_lul.Name = "btnSendFile";
		this.Get_Rekt_By_Ruined_GGcC_lul.Size = new Size(322, 29);
		this.Get_Rekt_By_Ruined_GGcC_lul.TabIndex = 26;
		this.Get_Rekt_By_Ruined_GGcC_lul.Text = "Send a File";
		this.Get_Rekt_By_Ruined_GGcC_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_GGcC_lul.Click += this.Get_Rekt_By_Ruined_dCHf_lul;
		this.Get_Rekt_By_Ruined_gaBG_lul.Controls.Add(this.Get_Rekt_By_Ruined_EFhB_lul);
		this.Get_Rekt_By_Ruined_gaBG_lul.Controls.Add(this.Get_Rekt_By_Ruined_GgEC_lul);
		this.Get_Rekt_By_Ruined_gaBG_lul.Controls.Add(this.Get_Rekt_By_Ruined_AbBe_lul);
		this.Get_Rekt_By_Ruined_gaBG_lul.Controls.Add(this.Get_Rekt_By_Ruined_AgBb_lul);
		this.Get_Rekt_By_Ruined_gaBG_lul.Controls.Add(this.Get_Rekt_By_Ruined_bGHa_lul);
		this.Get_Rekt_By_Ruined_gaBG_lul.Location = new Point(349, 9);
		this.Get_Rekt_By_Ruined_gaBG_lul.Margin = new Padding(2, 2, 2, 2);
		this.Get_Rekt_By_Ruined_gaBG_lul.Name = "panel60";
		this.Get_Rekt_By_Ruined_gaBG_lul.Size = new Size(323, 112);
		this.Get_Rekt_By_Ruined_gaBG_lul.TabIndex = 25;
		this.Get_Rekt_By_Ruined_EFhB_lul.Controls.Add(this.Get_Rekt_By_Ruined_bhFA_lul);
		this.Get_Rekt_By_Ruined_EFhB_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_EFhB_lul.Location = new Point(1, 90);
		this.Get_Rekt_By_Ruined_EFhB_lul.Margin = new Padding(2, 2, 2, 2);
		this.Get_Rekt_By_Ruined_EFhB_lul.Name = "panel92";
		this.Get_Rekt_By_Ruined_EFhB_lul.Size = new Size(321, 22);
		this.Get_Rekt_By_Ruined_EFhB_lul.TabIndex = 12;
		this.Get_Rekt_By_Ruined_bhFA_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_bhFA_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bhFA_lul.FlatAppearance.BorderSize = 100;
		this.Get_Rekt_By_Ruined_bhFA_lul.FlatAppearance.CheckedBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bhFA_lul.FlatAppearance.MouseDownBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bhFA_lul.FlatAppearance.MouseOverBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bhFA_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_bhFA_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_bhFA_lul.Location = new Point(121, 2);
		this.Get_Rekt_By_Ruined_bhFA_lul.Name = "cbUseField";
		this.Get_Rekt_By_Ruined_bhFA_lul.Size = new Size(93, 18);
		this.Get_Rekt_By_Ruined_bhFA_lul.TabIndex = 19;
		this.Get_Rekt_By_Ruined_bhFA_lul.Text = "Use field?";
		this.Get_Rekt_By_Ruined_bhFA_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_GgEC_lul.Controls.Add(this.Get_Rekt_By_Ruined_agHF_lul);
		this.Get_Rekt_By_Ruined_GgEC_lul.Controls.Add(this.Get_Rekt_By_Ruined_CCdf_lul);
		this.Get_Rekt_By_Ruined_GgEC_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_GgEC_lul.Location = new Point(1, 45);
		this.Get_Rekt_By_Ruined_GgEC_lul.Name = "panel86";
		this.Get_Rekt_By_Ruined_GgEC_lul.Size = new Size(321, 45);
		this.Get_Rekt_By_Ruined_GgEC_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_agHF_lul.Controls.Add(this.Get_Rekt_By_Ruined_eCDF_lul);
		this.Get_Rekt_By_Ruined_agHF_lul.Controls.Add(this.Get_Rekt_By_Ruined_HffF_lul);
		this.Get_Rekt_By_Ruined_agHF_lul.Controls.Add(this.Get_Rekt_By_Ruined_BgHa_lul);
		this.Get_Rekt_By_Ruined_agHF_lul.Controls.Add(this.Get_Rekt_By_Ruined_DAHB_lul);
		this.Get_Rekt_By_Ruined_agHF_lul.Controls.Add(this.Get_Rekt_By_Ruined_haBa_lul);
		this.Get_Rekt_By_Ruined_agHF_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_agHF_lul.Name = "panel87";
		this.Get_Rekt_By_Ruined_agHF_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_agHF_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_eCDF_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_eCDF_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_eCDF_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_eCDF_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_eCDF_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_eCDF_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_eCDF_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_eCDF_lul.Name = "txtFIeld1Text";
		this.Get_Rekt_By_Ruined_eCDF_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_eCDF_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_eCDF_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_HffF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HffF_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_HffF_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_HffF_lul.Name = "panel88";
		this.Get_Rekt_By_Ruined_HffF_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_HffF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_BgHa_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BgHa_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_BgHa_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_BgHa_lul.Name = "panel89";
		this.Get_Rekt_By_Ruined_BgHa_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_BgHa_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_DAHB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DAHB_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_DAHB_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_DAHB_lul.Name = "panel90";
		this.Get_Rekt_By_Ruined_DAHB_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_DAHB_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_haBa_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_haBa_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_haBa_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_haBa_lul.Name = "panel91";
		this.Get_Rekt_By_Ruined_haBa_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_haBa_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_CCdf_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_CCdf_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_CCdf_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_CCdf_lul.Name = "label17";
		this.Get_Rekt_By_Ruined_CCdf_lul.Size = new Size(147, 14);
		this.Get_Rekt_By_Ruined_CCdf_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_CCdf_lul.Text = "Field (Value / Text)";
		this.Get_Rekt_By_Ruined_AbBe_lul.Controls.Add(this.Get_Rekt_By_Ruined_HCBH_lul);
		this.Get_Rekt_By_Ruined_AbBe_lul.Controls.Add(this.Get_Rekt_By_Ruined_aGeG_lul);
		this.Get_Rekt_By_Ruined_AbBe_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_AbBe_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_AbBe_lul.Name = "panel61";
		this.Get_Rekt_By_Ruined_AbBe_lul.Size = new Size(321, 45);
		this.Get_Rekt_By_Ruined_AbBe_lul.TabIndex = 1;
		this.Get_Rekt_By_Ruined_HCBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_hHcH_lul);
		this.Get_Rekt_By_Ruined_HCBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_CCdd_lul);
		this.Get_Rekt_By_Ruined_HCBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_BDDA_lul);
		this.Get_Rekt_By_Ruined_HCBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_Chbg_lul);
		this.Get_Rekt_By_Ruined_HCBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_chGE_lul);
		this.Get_Rekt_By_Ruined_HCBH_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_HCBH_lul.Name = "panel62";
		this.Get_Rekt_By_Ruined_HCBH_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_HCBH_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_hHcH_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_hHcH_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_hHcH_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_hHcH_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_hHcH_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_hHcH_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_hHcH_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_hHcH_lul.Name = "txtFIeld1Name";
		this.Get_Rekt_By_Ruined_hHcH_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_hHcH_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_hHcH_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_CCdd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CCdd_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_CCdd_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_CCdd_lul.Name = "panel82";
		this.Get_Rekt_By_Ruined_CCdd_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_CCdd_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_BDDA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BDDA_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_BDDA_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_BDDA_lul.Name = "panel83";
		this.Get_Rekt_By_Ruined_BDDA_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_BDDA_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_Chbg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_Chbg_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_Chbg_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_Chbg_lul.Name = "panel84";
		this.Get_Rekt_By_Ruined_Chbg_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_Chbg_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_chGE_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_chGE_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_chGE_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_chGE_lul.Name = "panel85";
		this.Get_Rekt_By_Ruined_chGE_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_chGE_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_aGeG_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_aGeG_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_aGeG_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_aGeG_lul.Name = "label13";
		this.Get_Rekt_By_Ruined_aGeG_lul.Size = new Size(91, 14);
		this.Get_Rekt_By_Ruined_aGeG_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_aGeG_lul.Text = "Field (Name)";
		this.Get_Rekt_By_Ruined_AgBb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_AgBb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_AgBb_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_AgBb_lul.Name = "panel119";
		this.Get_Rekt_By_Ruined_AgBb_lul.Size = new Size(1, 112);
		this.Get_Rekt_By_Ruined_AgBb_lul.TabIndex = 10;
		this.Get_Rekt_By_Ruined_bGHa_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bGHa_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_bGHa_lul.Location = new Point(322, 0);
		this.Get_Rekt_By_Ruined_bGHa_lul.Name = "panel120";
		this.Get_Rekt_By_Ruined_bGHa_lul.Size = new Size(1, 112);
		this.Get_Rekt_By_Ruined_bGHa_lul.TabIndex = 11;
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_DGBH_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_cFeb_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_hfDE_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_ddFd_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_DggF_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_EfhA_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_Aegf_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_ghAD_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Controls.Add(this.Get_Rekt_By_Ruined_GbEB_lul);
		this.Get_Rekt_By_Ruined_hCCB_lul.Location = new Point(15, 9);
		this.Get_Rekt_By_Ruined_hCCB_lul.Name = "panel63";
		this.Get_Rekt_By_Ruined_hCCB_lul.Size = new Size(328, 356);
		this.Get_Rekt_By_Ruined_hCCB_lul.TabIndex = 24;
		this.Get_Rekt_By_Ruined_DGBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_ecGA_lul);
		this.Get_Rekt_By_Ruined_DGBH_lul.Controls.Add(this.Get_Rekt_By_Ruined_bgeB_lul);
		this.Get_Rekt_By_Ruined_DGBH_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_DGBH_lul.Location = new Point(1, 307);
		this.Get_Rekt_By_Ruined_DGBH_lul.Name = "panel121";
		this.Get_Rekt_By_Ruined_DGBH_lul.Size = new Size(326, 45);
		this.Get_Rekt_By_Ruined_DGBH_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_ecGA_lul.Controls.Add(this.Get_Rekt_By_Ruined_BfAa_lul);
		this.Get_Rekt_By_Ruined_ecGA_lul.Controls.Add(this.Get_Rekt_By_Ruined_Hahg_lul);
		this.Get_Rekt_By_Ruined_ecGA_lul.Controls.Add(this.Get_Rekt_By_Ruined_hhgG_lul);
		this.Get_Rekt_By_Ruined_ecGA_lul.Controls.Add(this.Get_Rekt_By_Ruined_aaca_lul);
		this.Get_Rekt_By_Ruined_ecGA_lul.Controls.Add(this.Get_Rekt_By_Ruined_HccA_lul);
		this.Get_Rekt_By_Ruined_ecGA_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_ecGA_lul.Name = "panel122";
		this.Get_Rekt_By_Ruined_ecGA_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_ecGA_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_BfAa_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_BfAa_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_BfAa_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_BfAa_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_BfAa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_BfAa_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_BfAa_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_BfAa_lul.Name = "txtThumbnail";
		this.Get_Rekt_By_Ruined_BfAa_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_BfAa_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_BfAa_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_Hahg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_Hahg_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_Hahg_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_Hahg_lul.Name = "panel123";
		this.Get_Rekt_By_Ruined_Hahg_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_Hahg_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_hhgG_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hhgG_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_hhgG_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_hhgG_lul.Name = "panel124";
		this.Get_Rekt_By_Ruined_hhgG_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_hhgG_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_aaca_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_aaca_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_aaca_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_aaca_lul.Name = "panel125";
		this.Get_Rekt_By_Ruined_aaca_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_aaca_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_HccA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HccA_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_HccA_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_HccA_lul.Name = "panel126";
		this.Get_Rekt_By_Ruined_HccA_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_HccA_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_bgeB_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_bgeB_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_bgeB_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_bgeB_lul.Name = "label5";
		this.Get_Rekt_By_Ruined_bgeB_lul.Size = new Size(98, 14);
		this.Get_Rekt_By_Ruined_bgeB_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_bgeB_lul.Text = "Thumbnail URL";
		this.Get_Rekt_By_Ruined_cFeb_lul.Controls.Add(this.Get_Rekt_By_Ruined_hhaB_lul);
		this.Get_Rekt_By_Ruined_cFeb_lul.Controls.Add(this.Get_Rekt_By_Ruined_eagH_lul);
		this.Get_Rekt_By_Ruined_cFeb_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_cFeb_lul.Location = new Point(1, 262);
		this.Get_Rekt_By_Ruined_cFeb_lul.Name = "panel54";
		this.Get_Rekt_By_Ruined_cFeb_lul.Size = new Size(326, 45);
		this.Get_Rekt_By_Ruined_cFeb_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_hhaB_lul.Controls.Add(this.Get_Rekt_By_Ruined_GDaC_lul);
		this.Get_Rekt_By_Ruined_hhaB_lul.Controls.Add(this.Get_Rekt_By_Ruined_dDHE_lul);
		this.Get_Rekt_By_Ruined_hhaB_lul.Controls.Add(this.Get_Rekt_By_Ruined_GeCB_lul);
		this.Get_Rekt_By_Ruined_hhaB_lul.Controls.Add(this.Get_Rekt_By_Ruined_bCbD_lul);
		this.Get_Rekt_By_Ruined_hhaB_lul.Controls.Add(this.Get_Rekt_By_Ruined_bhGG_lul);
		this.Get_Rekt_By_Ruined_hhaB_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_hhaB_lul.Name = "panel55";
		this.Get_Rekt_By_Ruined_hhaB_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_hhaB_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_GDaC_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_GDaC_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_GDaC_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_GDaC_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_GDaC_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_GDaC_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_GDaC_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_GDaC_lul.Name = "txtFooterIcon";
		this.Get_Rekt_By_Ruined_GDaC_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_GDaC_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_GDaC_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_dDHE_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_dDHE_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_dDHE_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_dDHE_lul.Name = "panel56";
		this.Get_Rekt_By_Ruined_dDHE_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_dDHE_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_GeCB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GeCB_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_GeCB_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_GeCB_lul.Name = "panel57";
		this.Get_Rekt_By_Ruined_GeCB_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_GeCB_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_bCbD_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bCbD_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_bCbD_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_bCbD_lul.Name = "panel58";
		this.Get_Rekt_By_Ruined_bCbD_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_bCbD_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_bhGG_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bhGG_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_bhGG_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_bhGG_lul.Name = "panel59";
		this.Get_Rekt_By_Ruined_bhGG_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_bhGG_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_eagH_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_eagH_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_eagH_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_eagH_lul.Name = "label12";
		this.Get_Rekt_By_Ruined_eagH_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_eagH_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_eagH_lul.Text = "Footer Icon";
		this.Get_Rekt_By_Ruined_hfDE_lul.Controls.Add(this.Get_Rekt_By_Ruined_HeCg_lul);
		this.Get_Rekt_By_Ruined_hfDE_lul.Controls.Add(this.Get_Rekt_By_Ruined_HbEc_lul);
		this.Get_Rekt_By_Ruined_hfDE_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_hfDE_lul.Location = new Point(1, 217);
		this.Get_Rekt_By_Ruined_hfDE_lul.Name = "panel48";
		this.Get_Rekt_By_Ruined_hfDE_lul.Size = new Size(326, 45);
		this.Get_Rekt_By_Ruined_hfDE_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_HeCg_lul.Controls.Add(this.Get_Rekt_By_Ruined_cAbe_lul);
		this.Get_Rekt_By_Ruined_HeCg_lul.Controls.Add(this.Get_Rekt_By_Ruined_EEdH_lul);
		this.Get_Rekt_By_Ruined_HeCg_lul.Controls.Add(this.Get_Rekt_By_Ruined_cBdF_lul);
		this.Get_Rekt_By_Ruined_HeCg_lul.Controls.Add(this.Get_Rekt_By_Ruined_bFdd_lul);
		this.Get_Rekt_By_Ruined_HeCg_lul.Controls.Add(this.Get_Rekt_By_Ruined_ECEg_lul);
		this.Get_Rekt_By_Ruined_HeCg_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_HeCg_lul.Name = "panel49";
		this.Get_Rekt_By_Ruined_HeCg_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_HeCg_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_cAbe_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_cAbe_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_cAbe_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_cAbe_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_cAbe_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_cAbe_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_cAbe_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_cAbe_lul.Name = "txtFooter";
		this.Get_Rekt_By_Ruined_cAbe_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_cAbe_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_cAbe_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_EEdH_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_EEdH_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_EEdH_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_EEdH_lul.Name = "panel50";
		this.Get_Rekt_By_Ruined_EEdH_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_EEdH_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_cBdF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_cBdF_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_cBdF_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_cBdF_lul.Name = "panel51";
		this.Get_Rekt_By_Ruined_cBdF_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_cBdF_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_bFdd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bFdd_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_bFdd_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_bFdd_lul.Name = "panel52";
		this.Get_Rekt_By_Ruined_bFdd_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_bFdd_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_ECEg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ECEg_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_ECEg_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_ECEg_lul.Name = "panel53";
		this.Get_Rekt_By_Ruined_ECEg_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_ECEg_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_HbEc_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_HbEc_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_HbEc_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_HbEc_lul.Name = "label11";
		this.Get_Rekt_By_Ruined_HbEc_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_HbEc_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_HbEc_lul.Text = "Footer Text";
		this.Get_Rekt_By_Ruined_ddFd_lul.Controls.Add(this.Get_Rekt_By_Ruined_fDde_lul);
		this.Get_Rekt_By_Ruined_ddFd_lul.Controls.Add(this.Get_Rekt_By_Ruined_BgGE_lul);
		this.Get_Rekt_By_Ruined_ddFd_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_ddFd_lul.Location = new Point(1, 135);
		this.Get_Rekt_By_Ruined_ddFd_lul.Name = "panel71";
		this.Get_Rekt_By_Ruined_ddFd_lul.Size = new Size(326, 82);
		this.Get_Rekt_By_Ruined_ddFd_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_fDde_lul.Controls.Add(this.Get_Rekt_By_Ruined_bfhG_lul);
		this.Get_Rekt_By_Ruined_fDde_lul.Controls.Add(this.Get_Rekt_By_Ruined_DCHF_lul);
		this.Get_Rekt_By_Ruined_fDde_lul.Controls.Add(this.Get_Rekt_By_Ruined_gGca_lul);
		this.Get_Rekt_By_Ruined_fDde_lul.Controls.Add(this.Get_Rekt_By_Ruined_agad_lul);
		this.Get_Rekt_By_Ruined_fDde_lul.Controls.Add(this.Get_Rekt_By_Ruined_defF_lul);
		this.Get_Rekt_By_Ruined_fDde_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_fDde_lul.Name = "panel77";
		this.Get_Rekt_By_Ruined_fDde_lul.Size = new Size(211, 55);
		this.Get_Rekt_By_Ruined_fDde_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_bfhG_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_bfhG_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_bfhG_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_bfhG_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_bfhG_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_bfhG_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_bfhG_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_bfhG_lul.Name = "txtDescription";
		this.Get_Rekt_By_Ruined_bfhG_lul.Size = new Size(209, 53);
		this.Get_Rekt_By_Ruined_bfhG_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_bfhG_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_DCHF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DCHF_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_DCHF_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_DCHF_lul.Name = "panel78";
		this.Get_Rekt_By_Ruined_DCHF_lul.Size = new Size(1, 53);
		this.Get_Rekt_By_Ruined_DCHF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_gGca_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_gGca_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_gGca_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_gGca_lul.Name = "panel79";
		this.Get_Rekt_By_Ruined_gGca_lul.Size = new Size(1, 53);
		this.Get_Rekt_By_Ruined_gGca_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_agad_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_agad_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_agad_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_agad_lul.Name = "panel80";
		this.Get_Rekt_By_Ruined_agad_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_agad_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_defF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_defF_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_defF_lul.Location = new Point(0, 54);
		this.Get_Rekt_By_Ruined_defF_lul.Name = "panel81";
		this.Get_Rekt_By_Ruined_defF_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_defF_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_BgGE_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_BgGE_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_BgGE_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_BgGE_lul.Name = "label16";
		this.Get_Rekt_By_Ruined_BgGE_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_BgGE_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_BgGE_lul.Text = "Description";
		this.Get_Rekt_By_Ruined_DggF_lul.Controls.Add(this.Get_Rekt_By_Ruined_bHCE_lul);
		this.Get_Rekt_By_Ruined_DggF_lul.Controls.Add(this.Get_Rekt_By_Ruined_DAcf_lul);
		this.Get_Rekt_By_Ruined_DggF_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_DggF_lul.Location = new Point(1, 90);
		this.Get_Rekt_By_Ruined_DggF_lul.Name = "pnlTitleURL";
		this.Get_Rekt_By_Ruined_DggF_lul.Size = new Size(326, 45);
		this.Get_Rekt_By_Ruined_DggF_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_bHCE_lul.Controls.Add(this.Get_Rekt_By_Ruined_dEcb_lul);
		this.Get_Rekt_By_Ruined_bHCE_lul.Controls.Add(this.Get_Rekt_By_Ruined_ehdF_lul);
		this.Get_Rekt_By_Ruined_bHCE_lul.Controls.Add(this.Get_Rekt_By_Ruined_fhgb_lul);
		this.Get_Rekt_By_Ruined_bHCE_lul.Controls.Add(this.Get_Rekt_By_Ruined_gbHd_lul);
		this.Get_Rekt_By_Ruined_bHCE_lul.Controls.Add(this.Get_Rekt_By_Ruined_GECE_lul);
		this.Get_Rekt_By_Ruined_bHCE_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_bHCE_lul.Name = "panel72";
		this.Get_Rekt_By_Ruined_bHCE_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_bHCE_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_dEcb_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_dEcb_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_dEcb_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_dEcb_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_dEcb_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_dEcb_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_dEcb_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_dEcb_lul.Name = "txtTitleURL";
		this.Get_Rekt_By_Ruined_dEcb_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_dEcb_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_dEcb_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_ehdF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ehdF_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_ehdF_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_ehdF_lul.Name = "panel73";
		this.Get_Rekt_By_Ruined_ehdF_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_ehdF_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_fhgb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_fhgb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_fhgb_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_fhgb_lul.Name = "panel74";
		this.Get_Rekt_By_Ruined_fhgb_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_fhgb_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_gbHd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_gbHd_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_gbHd_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_gbHd_lul.Name = "panel75";
		this.Get_Rekt_By_Ruined_gbHd_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_gbHd_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_GECE_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GECE_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_GECE_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_GECE_lul.Name = "panel76";
		this.Get_Rekt_By_Ruined_GECE_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_GECE_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_DAcf_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_DAcf_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_DAcf_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_DAcf_lul.Name = "label15";
		this.Get_Rekt_By_Ruined_DAcf_lul.Size = new Size(70, 14);
		this.Get_Rekt_By_Ruined_DAcf_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_DAcf_lul.Text = "Title URL";
		this.Get_Rekt_By_Ruined_EfhA_lul.Controls.Add(this.Get_Rekt_By_Ruined_DGFe_lul);
		this.Get_Rekt_By_Ruined_EfhA_lul.Controls.Add(this.Get_Rekt_By_Ruined_cfFc_lul);
		this.Get_Rekt_By_Ruined_EfhA_lul.Controls.Add(this.Get_Rekt_By_Ruined_Bbbe_lul);
		this.Get_Rekt_By_Ruined_EfhA_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_EfhA_lul.Location = new Point(1, 45);
		this.Get_Rekt_By_Ruined_EfhA_lul.Name = "panel65";
		this.Get_Rekt_By_Ruined_EfhA_lul.Size = new Size(326, 45);
		this.Get_Rekt_By_Ruined_EfhA_lul.TabIndex = 1;
		this.Get_Rekt_By_Ruined_DGFe_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_DGFe_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DGFe_lul.FlatAppearance.BorderSize = 100;
		this.Get_Rekt_By_Ruined_DGFe_lul.FlatAppearance.CheckedBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DGFe_lul.FlatAppearance.MouseDownBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DGFe_lul.FlatAppearance.MouseOverBackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_DGFe_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_DGFe_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_DGFe_lul.Location = new Point(228, 22);
		this.Get_Rekt_By_Ruined_DGFe_lul.Name = "cbURL";
		this.Get_Rekt_By_Ruined_DGFe_lul.Size = new Size(51, 18);
		this.Get_Rekt_By_Ruined_DGFe_lul.TabIndex = 18;
		this.Get_Rekt_By_Ruined_DGFe_lul.Text = "URL?";
		this.Get_Rekt_By_Ruined_DGFe_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_DGFe_lul.CheckedChanged += this.Get_Rekt_By_Ruined_cbAD_lul;
		this.Get_Rekt_By_Ruined_cfFc_lul.Controls.Add(this.Get_Rekt_By_Ruined_HDHH_lul);
		this.Get_Rekt_By_Ruined_cfFc_lul.Controls.Add(this.Get_Rekt_By_Ruined_FfcA_lul);
		this.Get_Rekt_By_Ruined_cfFc_lul.Controls.Add(this.Get_Rekt_By_Ruined_gBae_lul);
		this.Get_Rekt_By_Ruined_cfFc_lul.Controls.Add(this.Get_Rekt_By_Ruined_bEdH_lul);
		this.Get_Rekt_By_Ruined_cfFc_lul.Controls.Add(this.Get_Rekt_By_Ruined_eedd_lul);
		this.Get_Rekt_By_Ruined_cfFc_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_cfFc_lul.Name = "panel66";
		this.Get_Rekt_By_Ruined_cfFc_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_cfFc_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_HDHH_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_HDHH_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_HDHH_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_HDHH_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_HDHH_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_HDHH_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_HDHH_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_HDHH_lul.Name = "txtTItle";
		this.Get_Rekt_By_Ruined_HDHH_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_HDHH_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_HDHH_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_FfcA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FfcA_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_FfcA_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_FfcA_lul.Name = "panel67";
		this.Get_Rekt_By_Ruined_FfcA_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_FfcA_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_gBae_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_gBae_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_gBae_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_gBae_lul.Name = "panel68";
		this.Get_Rekt_By_Ruined_gBae_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_gBae_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_bEdH_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bEdH_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_bEdH_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_bEdH_lul.Name = "panel69";
		this.Get_Rekt_By_Ruined_bEdH_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_bEdH_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_eedd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eedd_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_eedd_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_eedd_lul.Name = "panel70";
		this.Get_Rekt_By_Ruined_eedd_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_eedd_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_Bbbe_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bbbe_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_Bbbe_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_Bbbe_lul.Name = "label14";
		this.Get_Rekt_By_Ruined_Bbbe_lul.Size = new Size(42, 14);
		this.Get_Rekt_By_Ruined_Bbbe_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_Bbbe_lul.Text = "Title";
		this.Get_Rekt_By_Ruined_Aegf_lul.Controls.Add(this.Get_Rekt_By_Ruined_hCHd_lul);
		this.Get_Rekt_By_Ruined_Aegf_lul.Controls.Add(this.Get_Rekt_By_Ruined_fhhc_lul);
		this.Get_Rekt_By_Ruined_Aegf_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_Aegf_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_Aegf_lul.Name = "panel64";
		this.Get_Rekt_By_Ruined_Aegf_lul.Size = new Size(326, 45);
		this.Get_Rekt_By_Ruined_Aegf_lul.TabIndex = 0;
		this.Get_Rekt_By_Ruined_hCHd_lul.Controls.Add(this.Get_Rekt_By_Ruined_aEHe_lul);
		this.Get_Rekt_By_Ruined_hCHd_lul.Controls.Add(this.Get_Rekt_By_Ruined_HCbB_lul);
		this.Get_Rekt_By_Ruined_hCHd_lul.Controls.Add(this.Get_Rekt_By_Ruined_dbEE_lul);
		this.Get_Rekt_By_Ruined_hCHd_lul.Controls.Add(this.Get_Rekt_By_Ruined_FGGc_lul);
		this.Get_Rekt_By_Ruined_hCHd_lul.Controls.Add(this.Get_Rekt_By_Ruined_bEeg_lul);
		this.Get_Rekt_By_Ruined_hCHd_lul.Location = new Point(12, 19);
		this.Get_Rekt_By_Ruined_hCHd_lul.Name = "panel39";
		this.Get_Rekt_By_Ruined_hCHd_lul.Size = new Size(211, 21);
		this.Get_Rekt_By_Ruined_hCHd_lul.TabIndex = 16;
		this.Get_Rekt_By_Ruined_aEHe_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_aEHe_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_aEHe_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_aEHe_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_aEHe_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aEHe_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_aEHe_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_aEHe_lul.Name = "txtAuthor";
		this.Get_Rekt_By_Ruined_aEHe_lul.Size = new Size(209, 19);
		this.Get_Rekt_By_Ruined_aEHe_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_aEHe_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_HCbB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HCbB_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_HCbB_lul.Location = new Point(210, 1);
		this.Get_Rekt_By_Ruined_HCbB_lul.Name = "panel40";
		this.Get_Rekt_By_Ruined_HCbB_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_HCbB_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_dbEE_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_dbEE_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_dbEE_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_dbEE_lul.Name = "panel41";
		this.Get_Rekt_By_Ruined_dbEE_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_dbEE_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_FGGc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FGGc_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_FGGc_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_FGGc_lul.Name = "panel42";
		this.Get_Rekt_By_Ruined_FGGc_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_FGGc_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_bEeg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_bEeg_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_bEeg_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_bEeg_lul.Name = "panel43";
		this.Get_Rekt_By_Ruined_bEeg_lul.Size = new Size(211, 1);
		this.Get_Rekt_By_Ruined_bEeg_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_fhhc_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_fhhc_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_fhhc_lul.Location = new Point(9, 2);
		this.Get_Rekt_By_Ruined_fhhc_lul.Name = "label9";
		this.Get_Rekt_By_Ruined_fhhc_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_fhhc_lul.TabIndex = 17;
		this.Get_Rekt_By_Ruined_fhhc_lul.Text = "Author Name";
		this.Get_Rekt_By_Ruined_ghAD_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ghAD_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_ghAD_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_ghAD_lul.Name = "panel31";
		this.Get_Rekt_By_Ruined_ghAD_lul.Size = new Size(1, 356);
		this.Get_Rekt_By_Ruined_ghAD_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_GbEB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GbEB_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_GbEB_lul.Location = new Point(327, 0);
		this.Get_Rekt_By_Ruined_GbEB_lul.Name = "panel37";
		this.Get_Rekt_By_Ruined_GbEB_lul.Size = new Size(1, 356);
		this.Get_Rekt_By_Ruined_GbEB_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_hhGA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hhGA_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_hhGA_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_hhGA_lul.Name = "panel38";
		this.Get_Rekt_By_Ruined_hhGA_lul.Size = new Size(685, 1);
		this.Get_Rekt_By_Ruined_hhGA_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_ECbE_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ECbE_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_ECbE_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_ECbE_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_ECbE_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_ECbE_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_ECbE_lul.Location = new Point(14, 383);
		this.Get_Rekt_By_Ruined_ECbE_lul.Name = "btnStartSpammingEmbed";
		this.Get_Rekt_By_Ruined_ECbE_lul.Size = new Size(328, 29);
		this.Get_Rekt_By_Ruined_ECbE_lul.TabIndex = 12;
		this.Get_Rekt_By_Ruined_ECbE_lul.Text = "Start Spamming";
		this.Get_Rekt_By_Ruined_ECbE_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_ECbE_lul.Click += this.Get_Rekt_By_Ruined_cECD_lul;
		this.Get_Rekt_By_Ruined_ehAb_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_ehAb_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_ehAb_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_ehAb_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_ehAb_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_ehAb_lul.Name = "label10";
		this.Get_Rekt_By_Ruined_ehAb_lul.Size = new Size(98, 14);
		this.Get_Rekt_By_Ruined_ehAb_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_ehAb_lul.Text = "Embed Spammer";
		this.Get_Rekt_By_Ruined_CfCC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CfCC_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_CfCC_lul.Location = new Point(1, 443);
		this.Get_Rekt_By_Ruined_CfCC_lul.Name = "panel44";
		this.Get_Rekt_By_Ruined_CfCC_lul.Size = new Size(685, 1);
		this.Get_Rekt_By_Ruined_CfCC_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_FbGF_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FbGF_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_FbGF_lul.Location = new Point(1, 0);
		this.Get_Rekt_By_Ruined_FbGF_lul.Name = "panel45";
		this.Get_Rekt_By_Ruined_FbGF_lul.Size = new Size(685, 1);
		this.Get_Rekt_By_Ruined_FbGF_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_AefB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_AefB_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_AefB_lul.Location = new Point(686, 0);
		this.Get_Rekt_By_Ruined_AefB_lul.Name = "panel46";
		this.Get_Rekt_By_Ruined_AefB_lul.Size = new Size(1, 444);
		this.Get_Rekt_By_Ruined_AefB_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_gCaa_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_gCaa_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_gCaa_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_gCaa_lul.Name = "panel47";
		this.Get_Rekt_By_Ruined_gCaa_lul.Size = new Size(1, 444);
		this.Get_Rekt_By_Ruined_gCaa_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_DCfD_lul.Interval = 500;
		this.Get_Rekt_By_Ruined_DCfD_lul.Tick += this.Get_Rekt_By_Ruined_cdeb_lul;
		this.Get_Rekt_By_Ruined_aHDe_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_aHDe_lul.Font = new Font("Consolas", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.Get_Rekt_By_Ruined_aHDe_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aHDe_lul.Location = new Point(3, 633);
		this.Get_Rekt_By_Ruined_aHDe_lul.Name = "lblDelStatus";
		this.Get_Rekt_By_Ruined_aHDe_lul.Size = new Size(720, 14);
		this.Get_Rekt_By_Ruined_aHDe_lul.TabIndex = 12;
		this.Get_Rekt_By_Ruined_aHDe_lul.Text = "Status: Idle";
		this.Get_Rekt_By_Ruined_aHDe_lul.TextAlign = ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(51, 51, 51);
		base.ClientSize = new Size(726, 650);
		base.Controls.Add(this.Get_Rekt_By_Ruined_aHDe_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_BEEd_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_EFFg_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_GhgE_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_aFhf_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_hdFc_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_eFDb_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_CgCD_lul);
		this.ForeColor = Color.Silver;
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "formWebhookSpammer";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Webhook Spammer";
		this.Get_Rekt_By_Ruined_CgCD_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EFFg_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EFFg_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_cfdF_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_cfdF_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_aeca_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_aeca_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_fCdH_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fCdH_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_ecFe_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_ecFe_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_GhgE_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_GhgE_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_fHcB_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fHcB_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_BEEd_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_BEEd_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_GCAb_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_gaBG_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EFhB_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EFhB_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_GgEC_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_GgEC_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_agHF_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_agHF_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_AbBe_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_AbBe_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_HCBH_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_HCBH_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_hCCB_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_DGBH_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_DGBH_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_ecGA_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_ecGA_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_cFeb_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_cFeb_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_hhaB_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_hhaB_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_hfDE_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_hfDE_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_HeCg_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_HeCg_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_ddFd_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_ddFd_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_fDde_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fDde_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_DggF_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_DggF_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_bHCE_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_bHCE_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_EfhA_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_EfhA_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_cfFc_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_cfFc_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_Aegf_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_Aegf_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_hCHd_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_hCHd_lul.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x040000DD RID: 221
	private WebClient Get_Rekt_By_Ruined_CDfh_lul = new WebClient();

	// Token: 0x040000DE RID: 222
	private IContainer Get_Rekt_By_Ruined_DgfB_lul = null;

	// Token: 0x040000DF RID: 223
	private Panel Get_Rekt_By_Ruined_CgCD_lul;

	// Token: 0x040000E0 RID: 224
	private Button Get_Rekt_By_Ruined_aCDa_lul;

	// Token: 0x040000E1 RID: 225
	private Button Get_Rekt_By_Ruined_BFcG_lul;

	// Token: 0x040000E2 RID: 226
	private Button Get_Rekt_By_Ruined_CEac_lul;

	// Token: 0x040000E3 RID: 227
	private Label Get_Rekt_By_Ruined_CDea_lul;

	// Token: 0x040000E4 RID: 228
	private Panel Get_Rekt_By_Ruined_aFhf_lul;

	// Token: 0x040000E5 RID: 229
	private Panel Get_Rekt_By_Ruined_hdFc_lul;

	// Token: 0x040000E6 RID: 230
	private Panel Get_Rekt_By_Ruined_eFDb_lul;

	// Token: 0x040000E7 RID: 231
	private Panel Get_Rekt_By_Ruined_EFFg_lul;

	// Token: 0x040000E8 RID: 232
	private Panel Get_Rekt_By_Ruined_cfdF_lul;

	// Token: 0x040000E9 RID: 233
	private Panel Get_Rekt_By_Ruined_GDFA_lul;

	// Token: 0x040000EA RID: 234
	private Label Get_Rekt_By_Ruined_Bbcc_lul;

	// Token: 0x040000EB RID: 235
	private Panel Get_Rekt_By_Ruined_hEfC_lul;

	// Token: 0x040000EC RID: 236
	private Panel Get_Rekt_By_Ruined_hbbC_lul;

	// Token: 0x040000ED RID: 237
	private Panel Get_Rekt_By_Ruined_eFbb_lul;

	// Token: 0x040000EE RID: 238
	private Panel Get_Rekt_By_Ruined_Cgad_lul;

	// Token: 0x040000EF RID: 239
	private Label Get_Rekt_By_Ruined_Bdfh_lul;

	// Token: 0x040000F0 RID: 240
	private Panel Get_Rekt_By_Ruined_ecFe_lul;

	// Token: 0x040000F1 RID: 241
	private TextBox Get_Rekt_By_Ruined_AeHH_lul;

	// Token: 0x040000F2 RID: 242
	private Panel Get_Rekt_By_Ruined_dgGd_lul;

	// Token: 0x040000F3 RID: 243
	private Panel Get_Rekt_By_Ruined_gfaf_lul;

	// Token: 0x040000F4 RID: 244
	private Panel Get_Rekt_By_Ruined_deFa_lul;

	// Token: 0x040000F5 RID: 245
	private Panel Get_Rekt_By_Ruined_HhFc_lul;

	// Token: 0x040000F6 RID: 246
	private Label Get_Rekt_By_Ruined_cddf_lul;

	// Token: 0x040000F7 RID: 247
	private Panel Get_Rekt_By_Ruined_fCdH_lul;

	// Token: 0x040000F8 RID: 248
	private TextBox Get_Rekt_By_Ruined_EFEB_lul;

	// Token: 0x040000F9 RID: 249
	private Panel Get_Rekt_By_Ruined_BHba_lul;

	// Token: 0x040000FA RID: 250
	private Panel Get_Rekt_By_Ruined_bCEH_lul;

	// Token: 0x040000FB RID: 251
	private Panel Get_Rekt_By_Ruined_HDGB_lul;

	// Token: 0x040000FC RID: 252
	private Panel Get_Rekt_By_Ruined_hbGd_lul;

	// Token: 0x040000FD RID: 253
	private Panel Get_Rekt_By_Ruined_aeca_lul;

	// Token: 0x040000FE RID: 254
	private TextBox Get_Rekt_By_Ruined_HGda_lul;

	// Token: 0x040000FF RID: 255
	private Panel Get_Rekt_By_Ruined_AgAF_lul;

	// Token: 0x04000100 RID: 256
	private Panel Get_Rekt_By_Ruined_dEFd_lul;

	// Token: 0x04000101 RID: 257
	private Panel Get_Rekt_By_Ruined_AGDH_lul;

	// Token: 0x04000102 RID: 258
	private Panel Get_Rekt_By_Ruined_FbHg_lul;

	// Token: 0x04000103 RID: 259
	private Label Get_Rekt_By_Ruined_EeeE_lul;

	// Token: 0x04000104 RID: 260
	private Panel Get_Rekt_By_Ruined_GhgE_lul;

	// Token: 0x04000105 RID: 261
	private Panel Get_Rekt_By_Ruined_fHcB_lul;

	// Token: 0x04000106 RID: 262
	private Panel Get_Rekt_By_Ruined_FBDB_lul;

	// Token: 0x04000107 RID: 263
	private Label Get_Rekt_By_Ruined_HFEH_lul;

	// Token: 0x04000108 RID: 264
	private Panel Get_Rekt_By_Ruined_CfHA_lul;

	// Token: 0x04000109 RID: 265
	private Panel Get_Rekt_By_Ruined_deDe_lul;

	// Token: 0x0400010A RID: 266
	private Panel Get_Rekt_By_Ruined_BBdD_lul;

	// Token: 0x0400010B RID: 267
	private Panel Get_Rekt_By_Ruined_ABDb_lul;

	// Token: 0x0400010C RID: 268
	private Button Get_Rekt_By_Ruined_hAgC_lul;

	// Token: 0x0400010D RID: 269
	private Timer Get_Rekt_By_Ruined_hEHb_lul;

	// Token: 0x0400010E RID: 270
	private Panel Get_Rekt_By_Ruined_BEEd_lul;

	// Token: 0x0400010F RID: 271
	private Panel Get_Rekt_By_Ruined_GCAb_lul;

	// Token: 0x04000110 RID: 272
	private Panel Get_Rekt_By_Ruined_hhGA_lul;

	// Token: 0x04000111 RID: 273
	private Button Get_Rekt_By_Ruined_ECbE_lul;

	// Token: 0x04000112 RID: 274
	private Label Get_Rekt_By_Ruined_ehAb_lul;

	// Token: 0x04000113 RID: 275
	private Panel Get_Rekt_By_Ruined_CfCC_lul;

	// Token: 0x04000114 RID: 276
	private Panel Get_Rekt_By_Ruined_FbGF_lul;

	// Token: 0x04000115 RID: 277
	private Panel Get_Rekt_By_Ruined_AefB_lul;

	// Token: 0x04000116 RID: 278
	private Panel Get_Rekt_By_Ruined_gCaa_lul;

	// Token: 0x04000117 RID: 279
	private Panel Get_Rekt_By_Ruined_hCCB_lul;

	// Token: 0x04000118 RID: 280
	private Panel Get_Rekt_By_Ruined_DggF_lul;

	// Token: 0x04000119 RID: 281
	private Panel Get_Rekt_By_Ruined_bHCE_lul;

	// Token: 0x0400011A RID: 282
	private TextBox Get_Rekt_By_Ruined_dEcb_lul;

	// Token: 0x0400011B RID: 283
	private Panel Get_Rekt_By_Ruined_ehdF_lul;

	// Token: 0x0400011C RID: 284
	private Panel Get_Rekt_By_Ruined_fhgb_lul;

	// Token: 0x0400011D RID: 285
	private Panel Get_Rekt_By_Ruined_gbHd_lul;

	// Token: 0x0400011E RID: 286
	private Panel Get_Rekt_By_Ruined_GECE_lul;

	// Token: 0x0400011F RID: 287
	private Label Get_Rekt_By_Ruined_DAcf_lul;

	// Token: 0x04000120 RID: 288
	private Panel Get_Rekt_By_Ruined_EfhA_lul;

	// Token: 0x04000121 RID: 289
	private Panel Get_Rekt_By_Ruined_cfFc_lul;

	// Token: 0x04000122 RID: 290
	private TextBox Get_Rekt_By_Ruined_HDHH_lul;

	// Token: 0x04000123 RID: 291
	private Panel Get_Rekt_By_Ruined_FfcA_lul;

	// Token: 0x04000124 RID: 292
	private Panel Get_Rekt_By_Ruined_gBae_lul;

	// Token: 0x04000125 RID: 293
	private Panel Get_Rekt_By_Ruined_bEdH_lul;

	// Token: 0x04000126 RID: 294
	private Panel Get_Rekt_By_Ruined_eedd_lul;

	// Token: 0x04000127 RID: 295
	private Label Get_Rekt_By_Ruined_Bbbe_lul;

	// Token: 0x04000128 RID: 296
	private Panel Get_Rekt_By_Ruined_Aegf_lul;

	// Token: 0x04000129 RID: 297
	private Panel Get_Rekt_By_Ruined_hCHd_lul;

	// Token: 0x0400012A RID: 298
	private TextBox Get_Rekt_By_Ruined_aEHe_lul;

	// Token: 0x0400012B RID: 299
	private Panel Get_Rekt_By_Ruined_HCbB_lul;

	// Token: 0x0400012C RID: 300
	private Panel Get_Rekt_By_Ruined_dbEE_lul;

	// Token: 0x0400012D RID: 301
	private Panel Get_Rekt_By_Ruined_FGGc_lul;

	// Token: 0x0400012E RID: 302
	private Panel Get_Rekt_By_Ruined_bEeg_lul;

	// Token: 0x0400012F RID: 303
	private Label Get_Rekt_By_Ruined_fhhc_lul;

	// Token: 0x04000130 RID: 304
	private Panel Get_Rekt_By_Ruined_ddFd_lul;

	// Token: 0x04000131 RID: 305
	private Panel Get_Rekt_By_Ruined_fDde_lul;

	// Token: 0x04000132 RID: 306
	private TextBox Get_Rekt_By_Ruined_bfhG_lul;

	// Token: 0x04000133 RID: 307
	private Panel Get_Rekt_By_Ruined_DCHF_lul;

	// Token: 0x04000134 RID: 308
	private Panel Get_Rekt_By_Ruined_gGca_lul;

	// Token: 0x04000135 RID: 309
	private Panel Get_Rekt_By_Ruined_agad_lul;

	// Token: 0x04000136 RID: 310
	private Panel Get_Rekt_By_Ruined_defF_lul;

	// Token: 0x04000137 RID: 311
	private Label Get_Rekt_By_Ruined_BgGE_lul;

	// Token: 0x04000138 RID: 312
	private CheckBox Get_Rekt_By_Ruined_DGFe_lul;

	// Token: 0x04000139 RID: 313
	private Panel Get_Rekt_By_Ruined_cFeb_lul;

	// Token: 0x0400013A RID: 314
	private Panel Get_Rekt_By_Ruined_hhaB_lul;

	// Token: 0x0400013B RID: 315
	private TextBox Get_Rekt_By_Ruined_GDaC_lul;

	// Token: 0x0400013C RID: 316
	private Panel Get_Rekt_By_Ruined_dDHE_lul;

	// Token: 0x0400013D RID: 317
	private Panel Get_Rekt_By_Ruined_GeCB_lul;

	// Token: 0x0400013E RID: 318
	private Panel Get_Rekt_By_Ruined_bCbD_lul;

	// Token: 0x0400013F RID: 319
	private Panel Get_Rekt_By_Ruined_bhGG_lul;

	// Token: 0x04000140 RID: 320
	private Label Get_Rekt_By_Ruined_eagH_lul;

	// Token: 0x04000141 RID: 321
	private Panel Get_Rekt_By_Ruined_hfDE_lul;

	// Token: 0x04000142 RID: 322
	private Panel Get_Rekt_By_Ruined_HeCg_lul;

	// Token: 0x04000143 RID: 323
	private TextBox Get_Rekt_By_Ruined_cAbe_lul;

	// Token: 0x04000144 RID: 324
	private Panel Get_Rekt_By_Ruined_EEdH_lul;

	// Token: 0x04000145 RID: 325
	private Panel Get_Rekt_By_Ruined_cBdF_lul;

	// Token: 0x04000146 RID: 326
	private Panel Get_Rekt_By_Ruined_bFdd_lul;

	// Token: 0x04000147 RID: 327
	private Panel Get_Rekt_By_Ruined_ECEg_lul;

	// Token: 0x04000148 RID: 328
	private Label Get_Rekt_By_Ruined_HbEc_lul;

	// Token: 0x04000149 RID: 329
	private Panel Get_Rekt_By_Ruined_gaBG_lul;

	// Token: 0x0400014A RID: 330
	private Panel Get_Rekt_By_Ruined_GgEC_lul;

	// Token: 0x0400014B RID: 331
	private Panel Get_Rekt_By_Ruined_agHF_lul;

	// Token: 0x0400014C RID: 332
	private TextBox Get_Rekt_By_Ruined_eCDF_lul;

	// Token: 0x0400014D RID: 333
	private Panel Get_Rekt_By_Ruined_HffF_lul;

	// Token: 0x0400014E RID: 334
	private Panel Get_Rekt_By_Ruined_BgHa_lul;

	// Token: 0x0400014F RID: 335
	private Panel Get_Rekt_By_Ruined_DAHB_lul;

	// Token: 0x04000150 RID: 336
	private Panel Get_Rekt_By_Ruined_haBa_lul;

	// Token: 0x04000151 RID: 337
	private Label Get_Rekt_By_Ruined_CCdf_lul;

	// Token: 0x04000152 RID: 338
	private Panel Get_Rekt_By_Ruined_AbBe_lul;

	// Token: 0x04000153 RID: 339
	private Panel Get_Rekt_By_Ruined_HCBH_lul;

	// Token: 0x04000154 RID: 340
	private TextBox Get_Rekt_By_Ruined_hHcH_lul;

	// Token: 0x04000155 RID: 341
	private Panel Get_Rekt_By_Ruined_CCdd_lul;

	// Token: 0x04000156 RID: 342
	private Panel Get_Rekt_By_Ruined_BDDA_lul;

	// Token: 0x04000157 RID: 343
	private Panel Get_Rekt_By_Ruined_Chbg_lul;

	// Token: 0x04000158 RID: 344
	private Panel Get_Rekt_By_Ruined_chGE_lul;

	// Token: 0x04000159 RID: 345
	private Label Get_Rekt_By_Ruined_aGeG_lul;

	// Token: 0x0400015A RID: 346
	private Timer Get_Rekt_By_Ruined_DCfD_lul;

	// Token: 0x0400015B RID: 347
	private Panel Get_Rekt_By_Ruined_AgBb_lul;

	// Token: 0x0400015C RID: 348
	private Panel Get_Rekt_By_Ruined_bGHa_lul;

	// Token: 0x0400015D RID: 349
	private Panel Get_Rekt_By_Ruined_ghAD_lul;

	// Token: 0x0400015E RID: 350
	private Panel Get_Rekt_By_Ruined_GbEB_lul;

	// Token: 0x0400015F RID: 351
	private Panel Get_Rekt_By_Ruined_DGBH_lul;

	// Token: 0x04000160 RID: 352
	private Panel Get_Rekt_By_Ruined_ecGA_lul;

	// Token: 0x04000161 RID: 353
	private TextBox Get_Rekt_By_Ruined_BfAa_lul;

	// Token: 0x04000162 RID: 354
	private Panel Get_Rekt_By_Ruined_Hahg_lul;

	// Token: 0x04000163 RID: 355
	private Panel Get_Rekt_By_Ruined_hhgG_lul;

	// Token: 0x04000164 RID: 356
	private Panel Get_Rekt_By_Ruined_aaca_lul;

	// Token: 0x04000165 RID: 357
	private Panel Get_Rekt_By_Ruined_HccA_lul;

	// Token: 0x04000166 RID: 358
	private Label Get_Rekt_By_Ruined_bgeB_lul;

	// Token: 0x04000167 RID: 359
	private Button Get_Rekt_By_Ruined_GGcC_lul;

	// Token: 0x04000168 RID: 360
	private Label Get_Rekt_By_Ruined_aHDe_lul;

	// Token: 0x04000169 RID: 361
	private Button Get_Rekt_By_Ruined_CdFC_lul;

	// Token: 0x0400016A RID: 362
	private Button Get_Rekt_By_Ruined_cGCa_lul;

	// Token: 0x0400016B RID: 363
	private Panel Get_Rekt_By_Ruined_EFhB_lul;

	// Token: 0x0400016C RID: 364
	private CheckBox Get_Rekt_By_Ruined_bhFA_lul;
}
