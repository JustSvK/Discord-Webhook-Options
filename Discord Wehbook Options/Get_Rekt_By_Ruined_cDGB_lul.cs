using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200001C RID: 28
public partial class Get_Rekt_By_Ruined_cDGB_lul : Form
{
	// Token: 0x060000AF RID: 175 RVA: 0x0000A6D0 File Offset: 0x000088D0
	public Get_Rekt_By_Ruined_cDGB_lul()
	{
		this.Get_Rekt_By_Ruined_CacA_lul();
		this.Get_Rekt_By_Ruined_EFEB_lul.Text = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FcDb_lul;
		this.Get_Rekt_By_Ruined_BEHh_lul.Text = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_gceg_lul;
		this.Get_Rekt_By_Ruined_bfhG_lul.Text = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_dhhD_lul;
		this.Get_Rekt_By_Ruined_aaHe_lul.Text = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_bFea_lul;
		this.Get_Rekt_By_Ruined_BfAa_lul.Text = Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_egCf_lul;
		this.Get_Rekt_By_Ruined_CDea_lul.MouseDown += this.Get_Rekt_By_Ruined_CHDh_lul;
		this.Get_Rekt_By_Ruined_CDea_lul.MouseMove += this.Get_Rekt_By_Ruined_DBFf_lul;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000076C0 File Offset: 0x000058C0
	public void Get_Rekt_By_Ruined_CHDh_lul(object sender, MouseEventArgs e)
	{
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_Bbhh_lul = Control.MousePosition.X - base.Location.X;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_hAGe_lul = Control.MousePosition.Y - base.Location.Y;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00007710 File Offset: 0x00005910
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

	// Token: 0x060000B2 RID: 178 RVA: 0x0000A770 File Offset: 0x00008970
	private void Get_Rekt_By_Ruined_AfgF_lul(object sender, EventArgs e)
	{
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_FcDb_lul = this.Get_Rekt_By_Ruined_EFEB_lul.Text;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_gceg_lul = this.Get_Rekt_By_Ruined_BEHh_lul.Text;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_dhhD_lul = this.Get_Rekt_By_Ruined_bfhG_lul.Text;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_bFea_lul = this.Get_Rekt_By_Ruined_aaHe_lul.Text;
		Get_Rekt_By_Ruined_EbBh_lul.Get_Rekt_By_Ruined_egCf_lul = this.Get_Rekt_By_Ruined_BfAa_lul.Text;
		base.Close();
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000042AC File Offset: 0x000024AC
	private void Get_Rekt_By_Ruined_Ggba_lul(object sender, EventArgs e)
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x000042AC File Offset: 0x000024AC
	private void Get_Rekt_By_Ruined_dFBE_lul(object sender, EventArgs e)
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000042E7 File Offset: 0x000024E7
	private void Get_Rekt_By_Ruined_AdbE_lul(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0000425B File Offset: 0x0000245B
	private void Get_Rekt_By_Ruined_DBCc_lul(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000042EF File Offset: 0x000024EF
	private void Get_Rekt_By_Ruined_HfDG_lul(object sender, EventArgs e)
	{
		new Get_Rekt_By_Ruined_cDGB_lul().Show();
		base.Close();
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00004301 File Offset: 0x00002501
	protected virtual void Get_Rekt_By_Ruined_bCHc_lul(bool disposing)
	{
		if (disposing && this.Get_Rekt_By_Ruined_DgfB_lul != null)
		{
			this.Get_Rekt_By_Ruined_DgfB_lul.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000A7D4 File Offset: 0x000089D4
	private void Get_Rekt_By_Ruined_CacA_lul()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Get_Rekt_By_Ruined_cDGB_lul));
		this.Get_Rekt_By_Ruined_CgCD_lul = new Panel();
		this.Get_Rekt_By_Ruined_aCDa_lul = new Button();
		this.Get_Rekt_By_Ruined_BFcG_lul = new Button();
		this.Get_Rekt_By_Ruined_CEac_lul = new Button();
		this.Get_Rekt_By_Ruined_CDea_lul = new Label();
		this.Get_Rekt_By_Ruined_eFDb_lul = new Panel();
		this.Get_Rekt_By_Ruined_hdFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_aFhf_lul = new Panel();
		this.Get_Rekt_By_Ruined_fCdH_lul = new Panel();
		this.Get_Rekt_By_Ruined_EFEB_lul = new TextBox();
		this.Get_Rekt_By_Ruined_BHba_lul = new Panel();
		this.Get_Rekt_By_Ruined_bCEH_lul = new Panel();
		this.Get_Rekt_By_Ruined_HDGB_lul = new Panel();
		this.Get_Rekt_By_Ruined_hbGd_lul = new Panel();
		this.Get_Rekt_By_Ruined_cddf_lul = new Label();
		this.Get_Rekt_By_Ruined_Bdfh_lul = new Label();
		this.Get_Rekt_By_Ruined_HFEH_lul = new Label();
		this.Get_Rekt_By_Ruined_ecFe_lul = new Panel();
		this.Get_Rekt_By_Ruined_BEHh_lul = new TextBox();
		this.Get_Rekt_By_Ruined_dgGd_lul = new Panel();
		this.Get_Rekt_By_Ruined_gfaf_lul = new Panel();
		this.Get_Rekt_By_Ruined_deFa_lul = new Panel();
		this.Get_Rekt_By_Ruined_HhFc_lul = new Panel();
		this.Get_Rekt_By_Ruined_GhgE_lul = new Panel();
		this.Get_Rekt_By_Ruined_aaHe_lul = new TextBox();
		this.Get_Rekt_By_Ruined_fHcB_lul = new Panel();
		this.Get_Rekt_By_Ruined_FBDB_lul = new Panel();
		this.Get_Rekt_By_Ruined_CfHA_lul = new Panel();
		this.Get_Rekt_By_Ruined_deDe_lul = new Panel();
		this.Get_Rekt_By_Ruined_EdgH_lul = new Button();
		this.Get_Rekt_By_Ruined_BBdD_lul = new Panel();
		this.Get_Rekt_By_Ruined_bfhG_lul = new TextBox();
		this.Get_Rekt_By_Ruined_ABDb_lul = new Panel();
		this.Get_Rekt_By_Ruined_BEEd_lul = new Panel();
		this.Get_Rekt_By_Ruined_GCAb_lul = new Panel();
		this.Get_Rekt_By_Ruined_EFFg_lul = new Panel();
		this.Get_Rekt_By_Ruined_bgeB_lul = new Label();
		this.Get_Rekt_By_Ruined_cfdF_lul = new Panel();
		this.Get_Rekt_By_Ruined_BfAa_lul = new TextBox();
		this.Get_Rekt_By_Ruined_GDFA_lul = new Panel();
		this.Get_Rekt_By_Ruined_hEfC_lul = new Panel();
		this.Get_Rekt_By_Ruined_hbbC_lul = new Panel();
		this.Get_Rekt_By_Ruined_eFbb_lul = new Panel();
		this.Get_Rekt_By_Ruined_Bbcc_lul = new Label();
		this.Get_Rekt_By_Ruined_CgCD_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_fCdH_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_ecFe_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_GhgE_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_BBdD_lul.SuspendLayout();
		this.Get_Rekt_By_Ruined_cfdF_lul.SuspendLayout();
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
		this.Get_Rekt_By_Ruined_CgCD_lul.Size = new Size(387, 25);
		this.Get_Rekt_By_Ruined_CgCD_lul.TabIndex = 1;
		this.Get_Rekt_By_Ruined_aCDa_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_aCDa_lul.FlatAppearance.BorderSize = 0;
		this.Get_Rekt_By_Ruined_aCDa_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_aCDa_lul.Font = new Font("Webdings", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 2);
		this.Get_Rekt_By_Ruined_aCDa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aCDa_lul.Location = new Point(279, 0);
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
		this.Get_Rekt_By_Ruined_BFcG_lul.Location = new Point(315, 0);
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
		this.Get_Rekt_By_Ruined_CEac_lul.Location = new Point(351, 0);
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
		this.Get_Rekt_By_Ruined_CDea_lul.Size = new Size(387, 25);
		this.Get_Rekt_By_Ruined_CDea_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_CDea_lul.Text = "Delete Webhook with Message";
		this.Get_Rekt_By_Ruined_CDea_lul.TextAlign = ContentAlignment.MiddleLeft;
		this.Get_Rekt_By_Ruined_eFDb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eFDb_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_eFDb_lul.Location = new Point(0, 25);
		this.Get_Rekt_By_Ruined_eFDb_lul.Name = "panel2";
		this.Get_Rekt_By_Ruined_eFDb_lul.Size = new Size(3, 470);
		this.Get_Rekt_By_Ruined_eFDb_lul.TabIndex = 2;
		this.Get_Rekt_By_Ruined_hdFc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hdFc_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_hdFc_lul.Location = new Point(384, 25);
		this.Get_Rekt_By_Ruined_hdFc_lul.Name = "panel3";
		this.Get_Rekt_By_Ruined_hdFc_lul.Size = new Size(3, 470);
		this.Get_Rekt_By_Ruined_hdFc_lul.TabIndex = 3;
		this.Get_Rekt_By_Ruined_aFhf_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_aFhf_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_aFhf_lul.Location = new Point(3, 492);
		this.Get_Rekt_By_Ruined_aFhf_lul.Name = "panel4";
		this.Get_Rekt_By_Ruined_aFhf_lul.Size = new Size(381, 3);
		this.Get_Rekt_By_Ruined_aFhf_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_EFEB_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_BHba_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_bCEH_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_HDGB_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Controls.Add(this.Get_Rekt_By_Ruined_hbGd_lul);
		this.Get_Rekt_By_Ruined_fCdH_lul.Location = new Point(18, 59);
		this.Get_Rekt_By_Ruined_fCdH_lul.Name = "panel5";
		this.Get_Rekt_By_Ruined_fCdH_lul.Size = new Size(353, 21);
		this.Get_Rekt_By_Ruined_fCdH_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_EFEB_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_EFEB_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_EFEB_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_EFEB_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_EFEB_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_EFEB_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_EFEB_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_EFEB_lul.Name = "txtUsername";
		this.Get_Rekt_By_Ruined_EFEB_lul.Size = new Size(351, 19);
		this.Get_Rekt_By_Ruined_EFEB_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_EFEB_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_BHba_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BHba_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_BHba_lul.Location = new Point(352, 1);
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
		this.Get_Rekt_By_Ruined_HDGB_lul.Size = new Size(353, 1);
		this.Get_Rekt_By_Ruined_HDGB_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_hbGd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hbGd_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_hbGd_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_hbGd_lul.Name = "panel6";
		this.Get_Rekt_By_Ruined_hbGd_lul.Size = new Size(353, 1);
		this.Get_Rekt_By_Ruined_hbGd_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_cddf_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_cddf_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_cddf_lul.Location = new Point(15, 42);
		this.Get_Rekt_By_Ruined_cddf_lul.Name = "label1";
		this.Get_Rekt_By_Ruined_cddf_lul.Size = new Size(70, 14);
		this.Get_Rekt_By_Ruined_cddf_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_cddf_lul.Text = "Username:";
		this.Get_Rekt_By_Ruined_Bdfh_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_Bdfh_lul.Location = new Point(16, 95);
		this.Get_Rekt_By_Ruined_Bdfh_lul.Name = "label3";
		this.Get_Rekt_By_Ruined_Bdfh_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_Bdfh_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_Bdfh_lul.Text = "Avatar URL:";
		this.Get_Rekt_By_Ruined_HFEH_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_HFEH_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_HFEH_lul.Location = new Point(16, 152);
		this.Get_Rekt_By_Ruined_HFEH_lul.Name = "label4";
		this.Get_Rekt_By_Ruined_HFEH_lul.Size = new Size(49, 14);
		this.Get_Rekt_By_Ruined_HFEH_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_HFEH_lul.Text = "Title:";
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_BEHh_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_dgGd_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_gfaf_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_deFa_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Controls.Add(this.Get_Rekt_By_Ruined_HhFc_lul);
		this.Get_Rekt_By_Ruined_ecFe_lul.Location = new Point(18, 112);
		this.Get_Rekt_By_Ruined_ecFe_lul.Name = "panel10";
		this.Get_Rekt_By_Ruined_ecFe_lul.Size = new Size(353, 21);
		this.Get_Rekt_By_Ruined_ecFe_lul.TabIndex = 9;
		this.Get_Rekt_By_Ruined_BEHh_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_BEHh_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_BEHh_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_BEHh_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_BEHh_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_BEHh_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_BEHh_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_BEHh_lul.Name = "txtAvatar";
		this.Get_Rekt_By_Ruined_BEHh_lul.Size = new Size(351, 19);
		this.Get_Rekt_By_Ruined_BEHh_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_BEHh_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_dgGd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_dgGd_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_dgGd_lul.Location = new Point(352, 1);
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
		this.Get_Rekt_By_Ruined_deFa_lul.Size = new Size(353, 1);
		this.Get_Rekt_By_Ruined_deFa_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_HhFc_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_HhFc_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_HhFc_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_HhFc_lul.Name = "panel14";
		this.Get_Rekt_By_Ruined_HhFc_lul.Size = new Size(353, 1);
		this.Get_Rekt_By_Ruined_HhFc_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_aaHe_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_fHcB_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_FBDB_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_CfHA_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Controls.Add(this.Get_Rekt_By_Ruined_deDe_lul);
		this.Get_Rekt_By_Ruined_GhgE_lul.Location = new Point(20, 169);
		this.Get_Rekt_By_Ruined_GhgE_lul.Name = "panel15";
		this.Get_Rekt_By_Ruined_GhgE_lul.Size = new Size(351, 19);
		this.Get_Rekt_By_Ruined_GhgE_lul.TabIndex = 10;
		this.Get_Rekt_By_Ruined_aaHe_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_aaHe_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_aaHe_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_aaHe_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_aaHe_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_aaHe_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_aaHe_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_aaHe_lul.Name = "txtTitle";
		this.Get_Rekt_By_Ruined_aaHe_lul.Size = new Size(349, 17);
		this.Get_Rekt_By_Ruined_aaHe_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_aaHe_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_fHcB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_fHcB_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_fHcB_lul.Location = new Point(350, 1);
		this.Get_Rekt_By_Ruined_fHcB_lul.Name = "panel16";
		this.Get_Rekt_By_Ruined_fHcB_lul.Size = new Size(1, 17);
		this.Get_Rekt_By_Ruined_fHcB_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_FBDB_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_FBDB_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_FBDB_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_FBDB_lul.Name = "panel17";
		this.Get_Rekt_By_Ruined_FBDB_lul.Size = new Size(1, 17);
		this.Get_Rekt_By_Ruined_FBDB_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_CfHA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_CfHA_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_CfHA_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_CfHA_lul.Name = "panel18";
		this.Get_Rekt_By_Ruined_CfHA_lul.Size = new Size(351, 1);
		this.Get_Rekt_By_Ruined_CfHA_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_deDe_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_deDe_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_deDe_lul.Location = new Point(0, 18);
		this.Get_Rekt_By_Ruined_deDe_lul.Name = "panel19";
		this.Get_Rekt_By_Ruined_deDe_lul.Size = new Size(351, 1);
		this.Get_Rekt_By_Ruined_deDe_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatAppearance.BorderColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 49, 49);
		this.Get_Rekt_By_Ruined_EdgH_lul.FlatStyle = FlatStyle.Flat;
		this.Get_Rekt_By_Ruined_EdgH_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_EdgH_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_EdgH_lul.Location = new Point(18, 450);
		this.Get_Rekt_By_Ruined_EdgH_lul.Name = "btnDeleteWb";
		this.Get_Rekt_By_Ruined_EdgH_lul.Size = new Size(351, 29);
		this.Get_Rekt_By_Ruined_EdgH_lul.TabIndex = 11;
		this.Get_Rekt_By_Ruined_EdgH_lul.Text = "Save Message";
		this.Get_Rekt_By_Ruined_EdgH_lul.UseVisualStyleBackColor = true;
		this.Get_Rekt_By_Ruined_EdgH_lul.Click += this.Get_Rekt_By_Ruined_AfgF_lul;
		this.Get_Rekt_By_Ruined_BBdD_lul.Controls.Add(this.Get_Rekt_By_Ruined_bfhG_lul);
		this.Get_Rekt_By_Ruined_BBdD_lul.Controls.Add(this.Get_Rekt_By_Ruined_ABDb_lul);
		this.Get_Rekt_By_Ruined_BBdD_lul.Controls.Add(this.Get_Rekt_By_Ruined_BEEd_lul);
		this.Get_Rekt_By_Ruined_BBdD_lul.Controls.Add(this.Get_Rekt_By_Ruined_GCAb_lul);
		this.Get_Rekt_By_Ruined_BBdD_lul.Controls.Add(this.Get_Rekt_By_Ruined_EFFg_lul);
		this.Get_Rekt_By_Ruined_BBdD_lul.Location = new Point(21, 220);
		this.Get_Rekt_By_Ruined_BBdD_lul.Name = "panel20";
		this.Get_Rekt_By_Ruined_BBdD_lul.Size = new Size(351, 156);
		this.Get_Rekt_By_Ruined_BBdD_lul.TabIndex = 13;
		this.Get_Rekt_By_Ruined_bfhG_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_bfhG_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_bfhG_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_bfhG_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_bfhG_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_bfhG_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_bfhG_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_bfhG_lul.Name = "txtDescription";
		this.Get_Rekt_By_Ruined_bfhG_lul.Size = new Size(349, 154);
		this.Get_Rekt_By_Ruined_bfhG_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_bfhG_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_ABDb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_ABDb_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_ABDb_lul.Location = new Point(350, 1);
		this.Get_Rekt_By_Ruined_ABDb_lul.Name = "panel21";
		this.Get_Rekt_By_Ruined_ABDb_lul.Size = new Size(1, 154);
		this.Get_Rekt_By_Ruined_ABDb_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_BEEd_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_BEEd_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_BEEd_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_BEEd_lul.Name = "panel22";
		this.Get_Rekt_By_Ruined_BEEd_lul.Size = new Size(1, 154);
		this.Get_Rekt_By_Ruined_BEEd_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_GCAb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GCAb_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_GCAb_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_GCAb_lul.Name = "panel23";
		this.Get_Rekt_By_Ruined_GCAb_lul.Size = new Size(351, 1);
		this.Get_Rekt_By_Ruined_GCAb_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_EFFg_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_EFFg_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_EFFg_lul.Location = new Point(0, 155);
		this.Get_Rekt_By_Ruined_EFFg_lul.Name = "panel24";
		this.Get_Rekt_By_Ruined_EFFg_lul.Size = new Size(351, 1);
		this.Get_Rekt_By_Ruined_EFFg_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_bgeB_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_bgeB_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_bgeB_lul.Location = new Point(17, 203);
		this.Get_Rekt_By_Ruined_bgeB_lul.Name = "label5";
		this.Get_Rekt_By_Ruined_bgeB_lul.Size = new Size(84, 14);
		this.Get_Rekt_By_Ruined_bgeB_lul.TabIndex = 12;
		this.Get_Rekt_By_Ruined_bgeB_lul.Text = "Description";
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_BfAa_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_GDFA_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_hEfC_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_hbbC_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Controls.Add(this.Get_Rekt_By_Ruined_eFbb_lul);
		this.Get_Rekt_By_Ruined_cfdF_lul.Location = new Point(20, 411);
		this.Get_Rekt_By_Ruined_cfdF_lul.Name = "panel25";
		this.Get_Rekt_By_Ruined_cfdF_lul.Size = new Size(351, 21);
		this.Get_Rekt_By_Ruined_cfdF_lul.TabIndex = 15;
		this.Get_Rekt_By_Ruined_BfAa_lul.BackColor = Color.FromArgb(41, 41, 41);
		this.Get_Rekt_By_Ruined_BfAa_lul.BorderStyle = BorderStyle.None;
		this.Get_Rekt_By_Ruined_BfAa_lul.Dock = DockStyle.Fill;
		this.Get_Rekt_By_Ruined_BfAa_lul.Font = new Font("Consolas", 9.75f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_BfAa_lul.ForeColor = Color.Silver;
		this.Get_Rekt_By_Ruined_BfAa_lul.Location = new Point(1, 1);
		this.Get_Rekt_By_Ruined_BfAa_lul.Multiline = true;
		this.Get_Rekt_By_Ruined_BfAa_lul.Name = "txtThumbnail";
		this.Get_Rekt_By_Ruined_BfAa_lul.Size = new Size(349, 19);
		this.Get_Rekt_By_Ruined_BfAa_lul.TabIndex = 8;
		this.Get_Rekt_By_Ruined_BfAa_lul.TextAlign = HorizontalAlignment.Center;
		this.Get_Rekt_By_Ruined_GDFA_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_GDFA_lul.Dock = DockStyle.Right;
		this.Get_Rekt_By_Ruined_GDFA_lul.Location = new Point(350, 1);
		this.Get_Rekt_By_Ruined_GDFA_lul.Name = "panel26";
		this.Get_Rekt_By_Ruined_GDFA_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_GDFA_lul.TabIndex = 7;
		this.Get_Rekt_By_Ruined_hEfC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hEfC_lul.Dock = DockStyle.Left;
		this.Get_Rekt_By_Ruined_hEfC_lul.Location = new Point(0, 1);
		this.Get_Rekt_By_Ruined_hEfC_lul.Name = "panel27";
		this.Get_Rekt_By_Ruined_hEfC_lul.Size = new Size(1, 19);
		this.Get_Rekt_By_Ruined_hEfC_lul.TabIndex = 6;
		this.Get_Rekt_By_Ruined_hbbC_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_hbbC_lul.Dock = DockStyle.Top;
		this.Get_Rekt_By_Ruined_hbbC_lul.Location = new Point(0, 0);
		this.Get_Rekt_By_Ruined_hbbC_lul.Name = "panel28";
		this.Get_Rekt_By_Ruined_hbbC_lul.Size = new Size(351, 1);
		this.Get_Rekt_By_Ruined_hbbC_lul.TabIndex = 5;
		this.Get_Rekt_By_Ruined_eFbb_lul.BackColor = Color.Indigo;
		this.Get_Rekt_By_Ruined_eFbb_lul.Dock = DockStyle.Bottom;
		this.Get_Rekt_By_Ruined_eFbb_lul.Location = new Point(0, 20);
		this.Get_Rekt_By_Ruined_eFbb_lul.Name = "panel29";
		this.Get_Rekt_By_Ruined_eFbb_lul.Size = new Size(351, 1);
		this.Get_Rekt_By_Ruined_eFbb_lul.TabIndex = 4;
		this.Get_Rekt_By_Ruined_Bbcc_lul.AutoSize = true;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Font = new Font("Consolas", 9f, FontStyle.Bold);
		this.Get_Rekt_By_Ruined_Bbcc_lul.Location = new Point(16, 394);
		this.Get_Rekt_By_Ruined_Bbcc_lul.Name = "label6";
		this.Get_Rekt_By_Ruined_Bbcc_lul.Size = new Size(77, 14);
		this.Get_Rekt_By_Ruined_Bbcc_lul.TabIndex = 14;
		this.Get_Rekt_By_Ruined_Bbcc_lul.Text = "Thumbnail:";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.FromArgb(51, 51, 51);
		base.ClientSize = new Size(387, 495);
		base.Controls.Add(this.Get_Rekt_By_Ruined_cfdF_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_Bbcc_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_BBdD_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_bgeB_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_EdgH_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_GhgE_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_ecFe_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_HFEH_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_Bdfh_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_cddf_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_fCdH_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_aFhf_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_hdFc_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_eFDb_lul);
		base.Controls.Add(this.Get_Rekt_By_Ruined_CgCD_lul);
		this.ForeColor = Color.Silver;
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "formDelText";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Delete Webhook with Message";
		this.Get_Rekt_By_Ruined_CgCD_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fCdH_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_fCdH_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_ecFe_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_ecFe_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_GhgE_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_GhgE_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_BBdD_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_BBdD_lul.PerformLayout();
		this.Get_Rekt_By_Ruined_cfdF_lul.ResumeLayout(false);
		this.Get_Rekt_By_Ruined_cfdF_lul.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040000B0 RID: 176
	private IContainer Get_Rekt_By_Ruined_DgfB_lul = null;

	// Token: 0x040000B1 RID: 177
	private Panel Get_Rekt_By_Ruined_CgCD_lul;

	// Token: 0x040000B2 RID: 178
	private Button Get_Rekt_By_Ruined_aCDa_lul;

	// Token: 0x040000B3 RID: 179
	private Button Get_Rekt_By_Ruined_BFcG_lul;

	// Token: 0x040000B4 RID: 180
	private Button Get_Rekt_By_Ruined_CEac_lul;

	// Token: 0x040000B5 RID: 181
	private Label Get_Rekt_By_Ruined_CDea_lul;

	// Token: 0x040000B6 RID: 182
	private Panel Get_Rekt_By_Ruined_eFDb_lul;

	// Token: 0x040000B7 RID: 183
	private Panel Get_Rekt_By_Ruined_hdFc_lul;

	// Token: 0x040000B8 RID: 184
	private Panel Get_Rekt_By_Ruined_aFhf_lul;

	// Token: 0x040000B9 RID: 185
	private Panel Get_Rekt_By_Ruined_fCdH_lul;

	// Token: 0x040000BA RID: 186
	private TextBox Get_Rekt_By_Ruined_EFEB_lul;

	// Token: 0x040000BB RID: 187
	private Panel Get_Rekt_By_Ruined_BHba_lul;

	// Token: 0x040000BC RID: 188
	private Panel Get_Rekt_By_Ruined_bCEH_lul;

	// Token: 0x040000BD RID: 189
	private Panel Get_Rekt_By_Ruined_HDGB_lul;

	// Token: 0x040000BE RID: 190
	private Panel Get_Rekt_By_Ruined_hbGd_lul;

	// Token: 0x040000BF RID: 191
	private Label Get_Rekt_By_Ruined_cddf_lul;

	// Token: 0x040000C0 RID: 192
	private Label Get_Rekt_By_Ruined_Bdfh_lul;

	// Token: 0x040000C1 RID: 193
	private Label Get_Rekt_By_Ruined_HFEH_lul;

	// Token: 0x040000C2 RID: 194
	private Panel Get_Rekt_By_Ruined_ecFe_lul;

	// Token: 0x040000C3 RID: 195
	private TextBox Get_Rekt_By_Ruined_BEHh_lul;

	// Token: 0x040000C4 RID: 196
	private Panel Get_Rekt_By_Ruined_dgGd_lul;

	// Token: 0x040000C5 RID: 197
	private Panel Get_Rekt_By_Ruined_gfaf_lul;

	// Token: 0x040000C6 RID: 198
	private Panel Get_Rekt_By_Ruined_deFa_lul;

	// Token: 0x040000C7 RID: 199
	private Panel Get_Rekt_By_Ruined_HhFc_lul;

	// Token: 0x040000C8 RID: 200
	private Panel Get_Rekt_By_Ruined_GhgE_lul;

	// Token: 0x040000C9 RID: 201
	private TextBox Get_Rekt_By_Ruined_aaHe_lul;

	// Token: 0x040000CA RID: 202
	private Panel Get_Rekt_By_Ruined_fHcB_lul;

	// Token: 0x040000CB RID: 203
	private Panel Get_Rekt_By_Ruined_FBDB_lul;

	// Token: 0x040000CC RID: 204
	private Panel Get_Rekt_By_Ruined_CfHA_lul;

	// Token: 0x040000CD RID: 205
	private Panel Get_Rekt_By_Ruined_deDe_lul;

	// Token: 0x040000CE RID: 206
	private Button Get_Rekt_By_Ruined_EdgH_lul;

	// Token: 0x040000CF RID: 207
	private Panel Get_Rekt_By_Ruined_BBdD_lul;

	// Token: 0x040000D0 RID: 208
	private TextBox Get_Rekt_By_Ruined_bfhG_lul;

	// Token: 0x040000D1 RID: 209
	private Panel Get_Rekt_By_Ruined_ABDb_lul;

	// Token: 0x040000D2 RID: 210
	private Panel Get_Rekt_By_Ruined_BEEd_lul;

	// Token: 0x040000D3 RID: 211
	private Panel Get_Rekt_By_Ruined_GCAb_lul;

	// Token: 0x040000D4 RID: 212
	private Panel Get_Rekt_By_Ruined_EFFg_lul;

	// Token: 0x040000D5 RID: 213
	private Label Get_Rekt_By_Ruined_bgeB_lul;

	// Token: 0x040000D6 RID: 214
	private Panel Get_Rekt_By_Ruined_cfdF_lul;

	// Token: 0x040000D7 RID: 215
	private TextBox Get_Rekt_By_Ruined_BfAa_lul;

	// Token: 0x040000D8 RID: 216
	private Panel Get_Rekt_By_Ruined_GDFA_lul;

	// Token: 0x040000D9 RID: 217
	private Panel Get_Rekt_By_Ruined_hEfC_lul;

	// Token: 0x040000DA RID: 218
	private Panel Get_Rekt_By_Ruined_hbbC_lul;

	// Token: 0x040000DB RID: 219
	private Panel Get_Rekt_By_Ruined_eFbb_lul;

	// Token: 0x040000DC RID: 220
	private Label Get_Rekt_By_Ruined_Bbcc_lul;
}
