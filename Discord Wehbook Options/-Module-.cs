using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x000043CC File Offset: 0x000025CC
	static <Module>()
	{
		/*
An exception occurred when decompiling this method (06000001)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void <Module>::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000002 RID: 2
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000003 RID: 3 RVA: 0x000043E0 File Offset: 0x000025E0
	internal static byte[] Get_Rekt_By_Ruined_HbDb_lul(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		<Module>.Get_Rekt_By_Ruined_BaEd_lul get_Rekt_By_Ruined_BaEd_lul = new <Module>.Get_Rekt_By_Ruined_BaEd_lul();
		byte[] array = new byte[5];
		memoryStream.Read(array, 0, 5);
		get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_hebh_lul(array);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array2 = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array2, true);
		long long_ = memoryStream.Length - 13L;
		get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_afBE_lul(memoryStream, stream_, long_, num);
		return array2;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00004478 File Offset: 0x00002678
	internal static byte[] Get_Rekt_By_Ruined_HcDh_lul(byte[] A_0)
	{
		uint num = 400U;
		uint[] array = new uint[16];
		uint num2 = 2069228073U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array2 = new uint[16];
		byte[] array3 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array2[j] = (uint)A_0[num3 + j];
			}
			uint num5 = array2[1] & 746829887U;
			array2[1] = (array2[1] & 3548137408U);
			array2[4] = (array2[4] ^ array2[8]);
			array2[15] = (array2[15] ^ array[15]);
			array2[1] = (array2[1] | (array2[12] & 746829887U));
			array2[12] = (array2[12] & 3548137408U);
			num5 *= 294775665U;
			uint num6 = array2[15] << 1;
			array2[10] = (array2[10] ^ array[10]);
			array2[7] = (array2[7] ^ 2745775921U);
			array2[12] = (array2[12] | num5 * 1110406545U);
			num5 = array2[3] >> 4;
			array2[3] = array2[3] << 28;
			array2[3] = (array2[3] | num5);
			num6 += array2[15];
			array2[10] = array2[10] - array2[6];
			num6 += array2[14] * 19U;
			num5 = array2[12] * 3192659499U;
			array2[0] = array2[0] - array2[8];
			uint num7 = array2[15];
			num6 += array2[3] * 37U;
			array2[12] = array2[9];
			num7 += array2[14] << 3;
			num6 += array2[1] * 44U;
			array2[9] = num5 * 1450029187U;
			num5 = array2[15];
			num5 += array2[14] << 1;
			uint num8 = 0U + (array2[3] << 1);
			num7 += array2[14];
			num5 += array2[14] << 2;
			num7 += array2[3] << 1;
			num5 += array2[3] << 1;
			array2[11] = (array2[11] ^ 1003545886U);
			num5 += array2[3] << 3;
			array2[14] = num6;
			num7 += array2[3] << 5;
			num6 = array2[10] * 1040331377U;
			array2[2] = (array2[2] ^ array2[0]);
			array2[5] = (array2[5] ^ ~array2[6]);
			num5 += array2[1] << 3;
			num5 += array2[1];
			array2[15] = num5;
			num8 += array2[3] << 3;
			num7 += array2[1] * 71U;
			num8 += array2[1] * 37U;
			array2[9] = (array2[9] ^ 4287715820U);
			array2[10] = array2[13];
			array2[1] = num8;
			num8 = array2[6] * 3305279063U;
			array2[6] = array2[11];
			array2[6] = (array2[6] ^ array[6]);
			array2[3] = num7;
			array2[4] = (array2[4] ^ array[4]);
			num7 = array2[6] * 73U;
			array2[13] = num6 * 1729318545U;
			array2[11] = num8 * 1000488295U;
			array2[14] = (array2[14] ^ array[14]);
			num5 = array2[6] * 60U;
			num8 = array2[6] << 4;
			num5 += array2[2] * 223U;
			num7 += array2[2] * 277U;
			num5 += array2[4] * 228U;
			num8 += array2[2] * 59U;
			num8 += array2[4] * 60U;
			num5 += array2[8] * 357U;
			array2[11] = (array2[11] ^ array[11]);
			array2[13] = (array2[13] ^ array[13]);
			array2[0] = array2[0] - array2[13];
			num6 = array2[6] * 56U;
			array2[10] = (array2[10] ^ 2558869593U);
			array2[12] = array2[12] * 2943693545U;
			num7 += array2[4] * 286U;
			num7 += array2[8] * 471U;
			num6 += array2[2] * 215U;
			num6 += array2[4] * 221U;
			array2[0] = (array2[0] ^ array[0]);
			array2[4] = num7;
			array2[2] = num5;
			num7 = array2[5] * 38U;
			num8 += array2[8] * 92U;
			array2[12] = (array2[12] ^ array[12]);
			num5 = array2[11] >> 16;
			array2[6] = num8;
			num7 += array2[15] * 141U;
			array2[11] = array2[11] << 16;
			num6 += array2[8] * 373U;
			array2[11] = (array2[11] | num5);
			array2[3] = (array2[3] ^ array[3]);
			array2[7] = (array2[7] ^ 2421446490U);
			num5 = array2[5] * 7U;
			array2[8] = num6;
			num6 = array2[5] << 3;
			num5 += array2[15] * 26U;
			array2[1] = (array2[1] ^ array[1]);
			num8 = array2[5] << 1;
			num8 += array2[5] << 4;
			num8 += array2[15] * 67U;
			num5 += array2[1] << 1;
			array2[3] = array2[3] * 2591716275U;
			num8 += array2[1] * 47U;
			num6 += array2[5] << 4;
			num5 += array2[1] << 4;
			num8 += array2[7] * 27U;
			num6 += array2[15] * 89U;
			num6 += array2[1] * 62U;
			num7 += array2[1] * 100U;
			array2[10] = array2[10] - 701318455U;
			array2[2] = (array2[2] ^ array[2]);
			num5 += array2[7] << 1;
			num6 += array2[7] << 2;
			num7 += array2[7] * 63U;
			array2[9] = (array2[9] ^ array[9]);
			array2[6] = (array2[6] ^ ~array2[2]);
			array2[15] = num8;
			num5 += array2[7] << 3;
			num8 = array2[4] * 605432165U;
			num6 += array2[7] << 5;
			array2[14] = array2[14] * 4126410751U;
			array2[4] = array2[8];
			array2[7] = num7;
			num7 = array2[6] >> 17;
			array2[1] = num6;
			array2[6] = array2[6] << 15;
			array2[5] = num5;
			array2[8] = num8 * 2339954797U;
			array2[3] = (array2[3] ^ array2[12]);
			array2[7] = (array2[7] ^ array[7]);
			array2[6] = (array2[6] | num7);
			num8 = array2[1] << 24;
			array2[1] = array2[1] >> 8;
			num6 = array2[5] << 1;
			num5 = array2[5] << 3;
			array2[1] = (array2[1] | num8);
			num5 += array2[5];
			num7 = array2[5] << 1;
			num8 = array2[9] >> 29;
			num5 += array2[7] * 45U;
			array2[0] = array2[0] * 3855964693U;
			array2[9] = array2[9] << 3;
			num7 += array2[5];
			num7 += array2[7] * 14U;
			array2[9] = (array2[9] | num8);
			num8 = array2[5] << 2;
			num7 += array2[8] * 19U;
			num6 += array2[7] << 3;
			array2[1] = array2[1] - 3879386507U;
			num8 += array2[5];
			num7 += array2[11] * 25U;
			num6 += array2[7];
			array2[4] = array2[4] - array2[14];
			num6 += array2[8] << 2;
			array2[5] = num7;
			num8 += array2[7] * 25U;
			num8 += array2[8] * 38U;
			num8 += array2[11] * 51U;
			num6 += array2[8] << 3;
			num6 += array2[11] << 4;
			num7 = array2[15] >> 3;
			num5 += array2[8] << 2;
			array2[15] = array2[15] << 29;
			num6 += array2[11];
			num5 += array2[8] << 6;
			array2[8] = num6;
			array2[15] = (array2[15] | num7);
			num5 += array2[11] * 90U;
			array2[8] = (array2[8] ^ array[8]);
			num6 = (array2[2] & 1477770382U);
			num6 *= 745869187U;
			array2[5] = (array2[5] ^ array[5]);
			array2[7] = num5;
			array2[2] = (array2[2] & 2817196913U);
			array2[2] = (array2[2] | (array2[13] & 1477770382U));
			array2[0] = array2[0] - array2[1];
			array2[13] = (array2[13] & 2817196913U);
			array2[13] = (array2[13] | num6 * 3941988139U);
			array2[11] = num8;
			for (int k = 0; k < 16; k++)
			{
				uint num9 = array2[k];
				array3[num4++] = (byte)num9;
				array3[num4++] = (byte)(num9 >> 8);
				array3[num4++] = (byte)(num9 >> 16);
				array3[num4++] = (byte)(num9 >> 24);
				array[k] ^= num9;
			}
			num3 += 16;
		}
		return array3;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00004D80 File Offset: 0x00002F80
	internal static T Get_Rekt_By_Ruined_DCac_lul<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.Get_Rekt_By_Ruined_BHHC_lul((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, count)));
		}
		else if ((ulong)num != 3UL)
		{
			if ((ulong)num == 2UL)
			{
				int num2 = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array2, 0, sizeof(T));
			result = array2[0];
		}
		return result;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00034834 File Offset: 0x00034834
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int Get_Rekt_By_Ruined_BHHC_lul(int int_0);

	// Token: 0x06000007 RID: 7 RVA: 0x00004F18 File Offset: 0x00003118
	internal static T Get_Rekt_By_Ruined_AAGD_lul<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.Get_Rekt_By_Ruined_HAEF_lul((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, count)));
		}
		else if ((ulong)num != 2UL)
		{
			if ((ulong)num == 1UL)
			{
				int num2 = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array2, 0, sizeof(T));
			result = array2[0];
		}
		return result;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0003486C File Offset: 0x0003486C
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int Get_Rekt_By_Ruined_HAEF_lul(int int_0);

	// Token: 0x06000009 RID: 9 RVA: 0x000050B0 File Offset: 0x000032B0
	internal static T Get_Rekt_By_Ruined_Abba_lul<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.Get_Rekt_By_Ruined_FaHb_lul((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, count)));
		}
		else if ((ulong)num != 3UL)
		{
			if ((ulong)num == 2UL)
			{
				int num2 = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array2, 0, sizeof(T));
			result = array2[0];
		}
		return result;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000348B8 File Offset: 0x000348B8
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int Get_Rekt_By_Ruined_FaHb_lul(int int_0);

	// Token: 0x0600000B RID: 11 RVA: 0x0000524C File Offset: 0x0000344C
	internal static T Get_Rekt_By_Ruined_cCaC_lul<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.Get_Rekt_By_Ruined_dFgB_lul((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		if ((ulong)num == 1UL)
		{
			int count = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, count)));
		}
		else if ((ulong)num != 0UL)
		{
			if ((ulong)num == 2UL)
			{
				int num2 = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array2, 0, sizeof(T));
			result = array2[0];
		}
		return result;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00034904 File Offset: 0x00034904
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int Get_Rekt_By_Ruined_dFgB_lul(int int_0);

	// Token: 0x0600000D RID: 13 RVA: 0x000053E4 File Offset: 0x000035E4
	internal static T Get_Rekt_By_Ruined_ADHf_lul<T>(uint uint_0)
	{
		uint_0 = (uint)<Module>.Get_Rekt_By_Ruined_hFaf_lul((int)uint_0);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		if ((ulong)num == 2UL)
		{
			int count = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, count)));
		}
		else if ((ulong)num == 0UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 3UL)
		{
			int num2 = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			int length = (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.Get_Rekt_By_Ruined_HdeF_lul[(int)((UIntPtr)(uint_0++))] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.Get_Rekt_By_Ruined_HdeF_lul, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00034930 File Offset: 0x00034930
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern int Get_Rekt_By_Ruined_hFaf_lul(int int_0);

	// Token: 0x0600000F RID: 15 RVA: 0x00005580 File Offset: 0x00003780
	internal static byte[] Get_Rekt_By_Ruined_aGdb_lul()
	{
		uint num = 1440U;
		uint[] array = new uint[]
		{
			2896497497U,
			526881077U,
			1423479129U,
			1514599910U,
			1921287609U,
			4230236152U,
			726997956U,
			2082391949U,
			1450743373U,
			6641596U,
			2235773107U,
			661332312U,
			2651769194U,
			2633798386U,
			2046168813U,
			339931482U,
			2239272814U,
			3970883586U,
			3170551386U,
			3161469402U,
			2906616109U,
			132494545U,
			3935894907U,
			515336542U,
			2064283254U,
			3811921301U,
			835650340U,
			425158343U,
			2101108974U,
			1698475138U,
			2047986506U,
			218876396U,
			3215770389U,
			3233898987U,
			2519539383U,
			426805708U,
			2375104068U,
			487232384U,
			1237643102U,
			2952403030U,
			981477529U,
			2771338282U,
			3955755031U,
			328134976U,
			1511599550U,
			4273736824U,
			1361601883U,
			2095652729U,
			1026740228U,
			3750767718U,
			3449434378U,
			3046147978U,
			910200657U,
			2090242304U,
			1884346386U,
			1809244510U,
			2770536060U,
			2355814415U,
			1237287862U,
			3972491027U,
			4154961432U,
			1015037293U,
			3557157889U,
			1208183295U,
			3935706072U,
			1108634832U,
			1572441902U,
			3943239551U,
			3248461055U,
			2718042325U,
			2734100558U,
			3903356941U,
			2306708231U,
			1671906480U,
			3369508201U,
			1420224548U,
			2474764201U,
			653912043U,
			277731927U,
			1204262718U,
			3635091897U,
			2363926236U,
			2360620307U,
			1719792881U,
			8739299U,
			3446895967U,
			2013461051U,
			1179420090U,
			2165266242U,
			3685886986U,
			236024653U,
			3608814522U,
			3893080325U,
			272392806U,
			4107370578U,
			3453016771U,
			792385778U,
			3531282240U,
			1805564939U,
			1610819708U,
			2553282568U,
			2509285159U,
			4137411564U,
			2194680464U,
			4165095296U,
			91013195U,
			2465811436U,
			2336019409U,
			797087875U,
			2909994631U,
			1341418255U,
			1745973571U,
			1692442996U,
			26003639U,
			3296089906U,
			3535345498U,
			1232959173U,
			1344870515U,
			2554445157U,
			3307074915U,
			696750212U,
			2150579638U,
			2538069762U,
			2631248618U,
			3218336917U,
			3525620614U,
			1429886159U,
			2220235287U,
			2002147515U,
			4046868977U,
			2525324191U,
			3703797679U,
			825686969U,
			154177193U,
			4028898189U,
			2079121332U,
			1030001894U,
			1726441667U,
			3170490004U,
			4223877763U,
			3397610735U,
			4238532236U,
			3047454411U,
			2849491520U,
			26722106U,
			2322341548U,
			371476630U,
			1541944346U,
			1680899171U,
			2816872887U,
			365604972U,
			3617994629U,
			1387883978U,
			2876521193U,
			3349599434U,
			3517710011U,
			1018884789U,
			3718103229U,
			2240397775U,
			530418930U,
			3562912331U,
			826649034U,
			4128656204U,
			3839246337U,
			2372134305U,
			1739552873U,
			3448319020U,
			1059277299U,
			770177092U,
			2846060613U,
			2100205824U,
			2508768696U,
			1386195954U,
			1168216762U,
			3368863086U,
			2981088133U,
			4178688144U,
			3279073584U,
			2790196317U,
			4014320835U,
			3558729732U,
			855458420U,
			3079412493U,
			1014986946U,
			4193848571U,
			3003165591U,
			1711469431U,
			1156707472U,
			792462866U,
			2782494533U,
			1536890077U,
			2051359441U,
			3154363989U,
			3751788290U,
			1514923074U,
			1424318282U,
			1003778689U,
			3396704596U,
			595986423U,
			290887944U,
			2821817784U,
			4185223457U,
			3748272212U,
			1456537098U,
			4290985886U,
			961397305U,
			1164967198U,
			2571743853U,
			2421454423U,
			2628392381U,
			1774489731U,
			3424550723U,
			669477460U,
			54838952U,
			45167239U,
			1570401078U,
			152522121U,
			1194019271U,
			1646787861U,
			2407238153U,
			189688354U,
			1813366826U,
			3876882094U,
			40116117U,
			2984576777U,
			38528561U,
			490054858U,
			1280242578U,
			2105798500U,
			3349025232U,
			898347680U,
			3570250102U,
			129415143U,
			3782890785U,
			1104249605U,
			3143376458U,
			3718530907U,
			2139649909U,
			2175527525U,
			67242048U,
			1769354506U,
			1579929987U,
			1788252664U,
			2056245194U,
			2576756422U,
			3691081295U,
			891645508U,
			495271520U,
			273717947U,
			2648054638U,
			3342221917U,
			3545602235U,
			2440062830U,
			1226541285U,
			1864221293U,
			353122715U,
			3951375966U,
			1518883464U,
			1965141756U,
			2654606117U,
			2043068171U,
			3258567867U,
			4152672776U,
			1607359240U,
			977750873U,
			3537088112U,
			2947415134U,
			1397986914U,
			3668451343U,
			1613677457U,
			4002917246U,
			3974447881U,
			3231729473U,
			847882612U,
			1875457087U,
			3496768392U,
			1099637424U,
			4211291138U,
			1625097061U,
			3014727391U,
			1930350453U,
			2557374452U,
			1712802559U,
			3906418649U,
			1048894654U,
			3879764046U,
			1165579582U,
			4045255599U,
			1736368173U,
			1724976845U,
			1486221773U,
			2010212820U,
			3579149244U,
			1431103018U,
			3982983550U,
			1694290558U,
			2609417446U,
			1530370000U,
			2609946828U,
			3703657349U,
			3336749562U,
			3929752680U,
			1781915980U,
			2612633853U,
			1020826409U,
			3790915897U,
			4254201228U,
			2601141917U,
			1936152385U,
			2563665018U,
			1741204875U,
			2541514391U,
			4162557384U,
			1736428688U,
			2457142048U,
			1560087996U,
			4232023976U,
			1102579896U,
			601238209U,
			1741607182U,
			3260021506U,
			2107527917U,
			3171681768U,
			3407041817U,
			2123088057U,
			30979285U,
			3512789843U,
			2130187479U,
			674870444U,
			3523225076U,
			836685799U,
			2200158483U,
			2739700300U,
			2739404539U,
			1550092620U,
			3880513269U,
			3759619531U,
			3913633478U,
			1773292684U,
			3978288727U,
			613568050U,
			1451053201U,
			3597428869U,
			2005893456U,
			2810718544U,
			527409341U,
			3163539494U,
			3999063918U,
			1755797541U,
			62674844U,
			1825193849U,
			1069148089U,
			3903288606U,
			1929333872U,
			942574144U,
			2440457668U,
			2386671513U,
			2122984091U,
			1252167667U,
			4273211744U,
			692335293U,
			2815793795U,
			1442950366U,
			1348592321U,
			313733342U,
			3173648535U,
			1165105137U,
			4181569478U,
			2702998789U,
			2852493830U,
			916354366U,
			2405943388U,
			2216222896U,
			416647939U,
			881680708U,
			4106463319U,
			4001195718U,
			4265744104U,
			3978719480U,
			952243436U,
			456084912U,
			2307868823U,
			2807520004U,
			1175026426U,
			211531181U,
			2474583024U,
			2685109375U,
			2185901583U,
			3148862816U,
			1629588375U,
			2631629141U,
			1758446831U,
			513210258U,
			1032443201U,
			1521969261U,
			2220206892U,
			2516450804U,
			557190700U,
			928833166U,
			1665072957U,
			911921077U,
			1742023993U,
			3102940336U,
			1679608930U,
			3383791136U,
			3239776874U,
			3796038071U,
			2722925636U,
			1437375897U,
			4105926314U,
			1533982635U,
			3941666856U,
			3796332049U,
			925866550U,
			1264783363U,
			3725133960U,
			639787646U,
			1400355679U,
			1601929907U,
			3289545736U,
			1861224682U,
			2651877531U,
			2718955640U,
			2060127377U,
			4270961208U,
			2795998107U,
			1528418021U,
			2328585526U,
			4012405669U,
			2088820591U,
			2127167642U,
			1021433528U,
			682821091U,
			1926888129U,
			3105044588U,
			2577221134U,
			3055244893U,
			3809595595U,
			3669603692U,
			3464453182U,
			1371041123U,
			1436868759U,
			1431237598U,
			2924293199U,
			3406705260U,
			3309158057U,
			3372845975U,
			2898539181U,
			2744139439U,
			2201822261U,
			2628803629U,
			2728663536U,
			2706475139U,
			536940911U,
			4003083432U,
			2692869981U,
			817304871U,
			1529800941U,
			3838773447U,
			1664054001U,
			509668994U,
			2466623342U,
			235046817U,
			2838521063U,
			310469696U,
			1719920853U,
			3541426U,
			29454941U,
			726563876U,
			1960677934U,
			2054985957U,
			52420785U,
			2311898178U,
			2217359606U,
			248455211U,
			3562672326U,
			1698372920U,
			4113834920U,
			1295146678U,
			661280249U,
			3897340804U,
			1778162158U,
			3814037353U,
			554427508U,
			1502078842U,
			2212862186U,
			3504463536U,
			3660481779U,
			3739867729U,
			1268305759U,
			3910188809U,
			4162231129U,
			793782351U,
			2994645531U,
			965563435U,
			3633146438U,
			2933283467U,
			1950183514U,
			4021751041U,
			1626626778U,
			913450126U,
			779614736U,
			1889036011U,
			3865720719U,
			1574070436U,
			3852900792U,
			4045610646U,
			3188597387U,
			443299023U,
			4203089165U,
			3716867153U,
			2499142618U,
			1506456222U,
			2115334213U,
			2704893589U,
			2031564093U,
			2412577818U,
			659115907U,
			2471988817U,
			1537224321U,
			619670583U,
			243090737U,
			1676971687U,
			2933613452U,
			1844084336U,
			4053250064U,
			2565539779U,
			632128111U,
			3753381524U,
			2475022906U,
			365476804U,
			2189311280U,
			2549454420U,
			1691789879U,
			1650889657U,
			3370325737U,
			1389089828U,
			2143109192U,
			2342159389U,
			1916095641U,
			894392328U,
			1021786741U,
			3179555461U,
			3793254592U,
			3113134737U,
			2198243201U,
			4203664241U,
			1445680442U,
			1440704824U,
			267803545U,
			3395344674U,
			387365194U,
			1841803773U,
			700959025U,
			710546529U,
			1893838363U,
			1320404192U,
			2429869154U,
			1018508611U,
			3362043556U,
			3795265390U,
			1361857464U,
			331647052U,
			3437579929U,
			4214759278U,
			1236499116U,
			2419908029U,
			3376330056U,
			146025467U,
			935073449U,
			401075955U,
			3877297270U,
			1970144043U,
			1503532854U,
			1890761290U,
			2697109064U,
			1249830237U,
			822647496U,
			1716521443U,
			3740582144U,
			902888372U,
			2929804475U,
			932418463U,
			2790273040U,
			1070622070U,
			1637599106U,
			1962881736U,
			358692483U,
			298452913U,
			2731421976U,
			1334934558U,
			2117267107U,
			319185815U,
			3740016166U,
			2431667052U,
			2186912687U,
			2587793224U,
			3086668376U,
			1835126851U,
			2344153444U,
			4280217150U,
			1174983896U,
			2395767518U,
			2036044945U,
			4089203291U,
			236430106U,
			3384249762U,
			737987137U,
			2184685970U,
			987903501U,
			2424431089U,
			2514822227U,
			2490914092U,
			1063246644U,
			3652595698U,
			707768696U,
			865404270U,
			3800718684U,
			3011917649U,
			4187686353U,
			869520264U,
			2709533152U,
			2440041466U,
			638903661U,
			861833566U,
			2266842193U,
			152154275U,
			4009106469U,
			1619433074U,
			2374540011U,
			141828468U,
			898741400U,
			1878685639U,
			234600832U,
			2814946831U,
			3584072957U,
			68324078U,
			2992622567U,
			2753248304U,
			1099261214U,
			44537336U,
			1996748060U,
			3018222229U,
			3984506620U,
			3692338222U,
			2779484293U,
			3341898984U,
			587753738U,
			4219744582U,
			3825999261U,
			1372432815U,
			3304087871U,
			3569942257U,
			2853942619U,
			2480838550U,
			960075290U,
			216540333U,
			776498385U,
			1389654143U,
			4065151453U,
			2540459138U,
			3883500268U,
			1925263947U,
			3549821636U,
			3687731059U,
			2182829195U,
			2848621520U,
			1523252340U,
			285703794U,
			2546936865U,
			1159619503U,
			111198225U,
			3783336439U,
			164167786U,
			2724594144U,
			4137726623U,
			1248939594U,
			1742770082U,
			836668815U,
			632481189U,
			3345450291U,
			3802482503U,
			786178194U,
			267515060U,
			2906909403U,
			799663635U,
			3576906896U,
			173819660U,
			3467785031U,
			4114944952U,
			2859919201U,
			491460987U,
			1223872618U,
			1902479782U,
			1651290915U,
			2001637302U,
			1241571851U,
			3226208166U,
			447056168U,
			2600361843U,
			943428827U,
			1078503537U,
			4039236210U,
			4048845525U,
			2609150251U,
			4279299696U,
			1803850676U,
			1785797413U,
			1764930862U,
			3484500845U,
			1481672171U,
			4212772714U,
			87642119U,
			4257238195U,
			3326914770U,
			2779947654U,
			2807941358U,
			1910880214U,
			328265519U,
			1197070331U,
			4014598561U,
			4048831664U,
			604904494U,
			2865095321U,
			1246995332U,
			2478386971U,
			953502352U,
			2730665301U,
			2660648386U,
			3902986828U,
			2881866918U,
			3245593112U,
			2365811757U,
			604270454U,
			3042603755U,
			2933633347U,
			1523864525U,
			3286966128U,
			2349629668U,
			3695343806U,
			1039069645U,
			2980033440U,
			999014916U,
			3266064361U,
			3658838260U,
			2480043440U,
			1951700908U,
			3918032784U,
			3772978304U,
			1584953619U,
			1319284647U,
			3431757320U,
			371680335U,
			238212139U,
			4000600100U,
			16028566U,
			1824621305U,
			2031680081U,
			2497539264U,
			3743932980U,
			2519248362U,
			2443184054U,
			2193986486U,
			1112390468U,
			2209265991U,
			986874998U,
			2306431212U,
			1793324368U,
			783649550U,
			3285903427U,
			2401317268U,
			3616203265U,
			1991481170U,
			3791383691U,
			3007306322U,
			1235932670U,
			3797616616U,
			3138540263U,
			4135866215U,
			2217000580U,
			2671272824U,
			3706151030U,
			1721041796U,
			999114647U,
			2198590053U,
			4126061740U,
			2208860811U,
			3504527656U,
			3496197726U,
			1901699584U,
			2753574737U,
			1331860442U,
			3584269161U,
			3229084642U,
			4189372423U,
			2334059292U,
			1800025702U,
			2754183567U,
			1236285578U,
			46363874U,
			2799885994U,
			227023366U,
			897746035U,
			2764743616U,
			1388620925U,
			519697417U,
			256096043U,
			175520380U,
			1216990515U,
			376820737U,
			1750350333U,
			2676517379U,
			3316502817U,
			3418807509U,
			520900085U,
			928713912U,
			944555632U,
			74943459U,
			3867928743U,
			2921164604U,
			263012775U,
			2744921058U,
			1650793385U,
			2090910476U,
			4259188328U,
			2392656229U,
			3171397952U,
			3936720940U,
			1485913188U,
			4265084446U,
			3260933877U,
			2851507632U,
			1471987323U,
			3080253664U,
			2199063789U,
			2226915525U,
			3315028850U,
			876670191U,
			2633662569U,
			1299297492U,
			1328534470U,
			1339062478U,
			1316165777U,
			2435146794U,
			3896793959U,
			2481609520U,
			1926580610U,
			1174120704U,
			3009579103U,
			3946193990U,
			1372105391U,
			2516638221U,
			2691016866U,
			2435470198U,
			4006856502U,
			723188915U,
			1316542928U,
			2593669227U,
			3915654670U,
			69307448U,
			895907803U,
			32539272U,
			2200501655U,
			3726122929U,
			146887960U,
			2790680849U,
			1533191980U,
			2220143628U,
			4205326321U,
			506297141U,
			956482065U,
			4081854577U,
			2129706804U,
			2252412756U,
			1034374386U,
			1137321527U,
			2513421605U,
			1845523858U,
			1159790148U,
			3667684408U,
			1722835435U,
			422173480U,
			3646911770U,
			277318468U,
			791195948U,
			754952266U,
			3053996437U,
			3425547607U,
			3934933478U,
			3942199168U,
			584057921U,
			3293342005U,
			4235783820U,
			59257378U,
			3590828559U,
			98509777U,
			3911966107U,
			2838326703U,
			2097315645U,
			1903087032U,
			3061329668U,
			1224226568U,
			2387495637U,
			1222999513U,
			583426192U,
			3036392915U,
			135087925U,
			2710163363U,
			2126614178U,
			3786423570U,
			667977930U,
			2498832269U,
			3885088398U,
			3525769991U,
			3931968716U,
			2988759870U,
			1605805251U,
			4013037979U,
			2212582224U,
			1300085928U,
			3477210506U,
			810566812U,
			3696495846U,
			1858412959U,
			3651080834U,
			4044069046U,
			3172052445U,
			2917558549U,
			1026605725U,
			3777567442U,
			934209458U,
			1938091944U,
			3249526135U,
			2681688901U,
			3828935637U,
			2114612428U,
			2810678894U,
			4117391365U,
			798146284U,
			1644957297U,
			1900014117U,
			972083083U,
			50756318U,
			3047017320U,
			1134008931U,
			3042272127U,
			3576168273U,
			562465849U,
			2540564899U,
			1562299948U,
			786350258U,
			3811546213U,
			23444946U,
			3129206344U,
			734387910U,
			2617219942U,
			3895683436U,
			1451267283U,
			1865141503U,
			788112217U,
			3116716089U,
			564150612U,
			3434867896U,
			2902833712U,
			1823323004U,
			1079281201U,
			2686686635U,
			2600725919U,
			922035283U,
			2460172200U,
			3571219660U,
			4180231612U,
			2217853062U,
			3710880589U,
			1205275670U,
			3777574112U,
			2345921390U,
			367326387U,
			2972362469U,
			785125469U,
			2480940663U,
			4177029113U,
			493774978U,
			1761255075U,
			2458955552U,
			1254143365U,
			24146850U,
			1884778943U,
			152107875U,
			4191069769U,
			259993373U,
			2579161244U,
			114508508U,
			4071426377U,
			1639281332U,
			2128082133U,
			117979972U,
			3076310203U,
			3019329239U,
			1865817508U,
			2243422335U,
			2741389103U,
			3831915023U,
			4103836263U,
			2285456411U,
			3782779723U,
			1775436293U,
			2816685772U,
			2410304507U,
			862306584U,
			816267191U,
			1470969513U,
			3246860238U,
			972479938U,
			1488078416U,
			362231978U,
			2844382766U,
			1960230584U,
			1161233751U,
			2277591275U,
			1918172727U,
			2858940005U,
			2218420858U,
			1325888102U,
			1111564961U,
			1155688887U,
			2341640621U,
			3090848895U,
			3391023368U,
			3120066771U,
			952788362U,
			2437623468U,
			226206882U,
			2355934615U,
			868951506U,
			5966337U,
			2469671806U,
			2548584383U,
			513044525U,
			1883817252U,
			2705357681U,
			3656298520U,
			59180927U,
			4043368991U,
			530866773U,
			724783325U,
			3148282236U,
			2592317424U,
			3977153607U,
			1486439266U,
			3976882393U,
			1935437040U,
			2296943521U,
			1008178809U,
			1803843130U,
			11188753U,
			650623548U,
			2147012159U,
			2977019889U,
			688685251U,
			3459847042U,
			434695700U,
			4156732254U,
			1757061739U,
			3303123817U,
			1791935474U,
			27362530U,
			3740959429U,
			3625662199U,
			4175949730U,
			3134833953U,
			1724685478U,
			1163485439U,
			942198633U,
			75050365U,
			3404921038U,
			1933930038U,
			355957284U,
			3252256300U,
			191533522U,
			1950610613U,
			1123397139U,
			2215645834U,
			2691492888U,
			1237564546U,
			797495469U,
			2940697226U,
			2285919857U,
			4141695793U,
			824148416U,
			1629764745U,
			2040908637U,
			781538732U,
			1113089993U,
			36850888U,
			1232707704U,
			2705505128U,
			489278783U,
			3109531868U,
			1036641233U,
			3330364409U,
			3970987976U,
			3532197805U,
			3736789448U,
			2892891498U,
			1337303410U,
			660982197U,
			1938529425U,
			3625121091U,
			169020265U,
			3177217203U,
			855420252U,
			2332574557U,
			4235789965U,
			1038903045U,
			1018298492U,
			2672458588U,
			3586278806U,
			3044406799U,
			3132299958U,
			4120402392U,
			2895183169U,
			3830598108U,
			349448225U,
			3767590176U,
			2570184973U,
			1941544865U,
			2402621519U,
			405842642U,
			3457242803U,
			797713615U,
			618372472U,
			1688738170U,
			1697097860U,
			2616404989U,
			2045086497U,
			3957009322U,
			2845655384U,
			3916626095U,
			556105214U,
			3773679685U,
			435631019U,
			1730558956U,
			2257525425U,
			3127677627U,
			892875064U,
			3443110568U,
			4125978948U,
			4154157418U,
			1844513291U,
			1957389870U,
			1391301753U,
			1960237551U,
			552405079U,
			4193414722U,
			3091324429U,
			3388410356U,
			2843427403U,
			1082212131U,
			3116605930U,
			381381339U,
			3345545810U,
			2772380885U,
			2490329133U,
			1044297578U,
			3707913438U,
			3272806157U,
			3816685280U,
			2257150814U,
			4026012258U,
			14799190U,
			4154698276U,
			3826122919U,
			863641094U,
			624623337U,
			2826694126U,
			3922752147U,
			2399668095U,
			3445688037U,
			4252706463U,
			2574426895U,
			1271671317U,
			3935423635U,
			222211370U,
			119665725U,
			3209462704U,
			174725741U,
			1721475079U,
			1119429096U,
			976514940U,
			1072529264U,
			1140883364U,
			2626071314U,
			1329723484U,
			2817795525U,
			1278286819U,
			2457003670U,
			2809500069U,
			1821987335U,
			1778630727U,
			1954885142U,
			3789541082U,
			3874865384U,
			1493180678U,
			1499425613U,
			3663014075U,
			2960282833U,
			1381807572U,
			682809561U,
			2854705247U,
			1506964897U,
			851147879U,
			568062662U,
			1769505885U,
			3087939221U,
			2446991926U,
			4223736419U,
			3764524602U,
			2076972209U,
			4164679562U,
			354320553U,
			2747893067U,
			1778277247U,
			2770324210U,
			3216754212U,
			3354734024U,
			1105268014U,
			1295799353U,
			1376053575U,
			1194776702U,
			1468207427U,
			3654039214U,
			1963801564U,
			41582253U,
			3915189406U,
			410916310U,
			3700806934U,
			2832924237U,
			2552363710U,
			3636830941U,
			1330748417U,
			1930211955U,
			1277836578U,
			1029336408U,
			736425248U,
			2583961174U,
			4124156637U,
			566912529U,
			4228227530U,
			1285159637U,
			2331952030U,
			783322879U,
			2390880906U,
			1764139328U,
			2373686150U,
			1858141438U,
			3758640161U,
			130286698U,
			1127495922U,
			295689568U,
			1546428307U,
			599266891U,
			3350441916U,
			1537989661U,
			2513267109U,
			1823465170U,
			1119072873U,
			4015124859U,
			1578262806U,
			1938939146U,
			1628071114U,
			4213027952U,
			2029144082U,
			2105431494U,
			1133917503U,
			86613559U,
			1197612785U,
			1257148275U,
			904579052U,
			832454818U,
			1822444112U,
			2852065494U,
			1945273829U,
			4074190102U,
			2355305712U,
			242326867U,
			114138387U,
			1749550735U,
			2003358199U,
			2810747907U,
			3467487254U,
			177508169U,
			2599123699U,
			342007085U,
			2571164302U,
			2487130259U,
			1301877914U,
			1240667006U,
			4282228038U,
			1384159965U,
			2213108970U,
			1583018141U,
			1282834151U,
			2905446540U,
			1653732191U,
			4244461779U,
			201368383U,
			3965581440U,
			1968735439U,
			183084315U,
			2108843924U,
			802705735U,
			3977211938U,
			848196729U,
			3418196933U,
			1085787949U,
			262405381U,
			2037624358U,
			2898482632U,
			2987331279U,
			4059283374U,
			904398140U,
			2489635963U,
			3030505597U,
			170149986U,
			4011372794U,
			855930423U,
			1108879861U,
			4261588433U,
			1614233140U,
			1867038295U,
			2340706605U,
			3389269340U,
			2711370427U,
			733803263U,
			1797882404U,
			643014849U,
			3551386652U,
			1846879622U,
			1153871424U,
			1014023795U,
			3237002852U,
			4273535306U,
			2033619254U,
			2190690584U,
			3279628045U,
			3744268783U,
			2725644048U,
			1205033131U,
			4108318351U,
			2238354480U,
			4276403324U,
			2902741979U,
			3549616716U,
			2270164133U,
			3548852208U,
			2868967523U,
			2122919334U,
			165383533U,
			1574960659U,
			1775829350U,
			1664693797U,
			2204827382U,
			1291048898U,
			3424554541U,
			1571617398U,
			1369733128U,
			4028574305U,
			1404679398U,
			3131336023U,
			3473339263U,
			3115598867U,
			2708656756U,
			2115695387U,
			2018586048U,
			4264151187U,
			978441073U,
			2878041180U,
			1189203715U,
			2757051132U,
			3691335799U,
			1853794786U,
			912604147U,
			3879170326U,
			1843522129U,
			3417547707U,
			2782416725U,
			3862238357U,
			5688764U,
			1855994644U,
			586779406U,
			4147232645U,
			3861551315U,
			3445126297U,
			1779132635U,
			797109780U,
			2175288413U,
			231623961U,
			2270616299U,
			1000597541U,
			2618620162U,
			3765417173U,
			1875369286U,
			2085868187U,
			450793101U,
			1517805640U,
			680284803U,
			2945940822U,
			1524862801U,
			920030887U,
			3882714113U,
			343567781U,
			2791222028U,
			3058557454U,
			971885899U,
			50580408U,
			403887061U,
			3620270880U,
			4045671735U,
			513659733U,
			3127761144U,
			1150385168U,
			687326155U,
			1171537945U,
			3716610817U,
			3259295993U,
			3460638825U,
			3259312171U,
			3326961703U,
			3721230441U,
			1115486313U,
			1178990649U,
			1188769775U,
			3259299867U,
			2128558105U,
			3460683887U,
			3268114489U,
			1111877673U,
			3261016103U,
			1204496441U
		};
		uint[] array2 = new uint[16];
		uint num2 = 3414648509U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		return <Module>.Get_Rekt_By_Ruined_HbDb_lul(array4);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00003D10 File Offset: 0x00001F10
	internal static Assembly Get_Rekt_By_Ruined_FeFG_lul(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (<Module>.Get_Rekt_By_Ruined_fGaA_lul.FullName == resolveEventArgs_0.Name)
		{
			return <Module>.Get_Rekt_By_Ruined_fGaA_lul;
		}
		return null;
	}

	// Token: 0x06000011 RID: 17
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x04000001 RID: 1
	internal static byte[] Get_Rekt_By_Ruined_HdeF_lul;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Get_Rekt_By_Ruined_ebBb_lul Get_Rekt_By_Ruined_Ecbg_lul;

	// Token: 0x04000003 RID: 3
	internal static Assembly Get_Rekt_By_Ruined_fGaA_lul;

	// Token: 0x04000004 RID: 4 RVA: 0x00002690 File Offset: 0x00000890
	internal static <Module>.Get_Rekt_By_Ruined_DEfB_lul Get_Rekt_By_Ruined_BFag_lul;

	// Token: 0x02000002 RID: 2
	internal struct Get_Rekt_By_Ruined_bHBb_lul
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00003D30 File Offset: 0x00001F30
		internal void Get_Rekt_By_Ruined_CaAC_lul()
		{
			this.Get_Rekt_By_Ruined_Ecba_lul = 1024U;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005778 File Offset: 0x00003978
		internal uint Get_Rekt_By_Ruined_GbFe_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0)
		{
			uint num = (get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul >> 11) * this.Get_Rekt_By_Ruined_Ecba_lul;
			if (get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_hAFc_lul < num)
			{
				get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul = num;
				this.Get_Rekt_By_Ruined_Ecba_lul += 2048U - this.Get_Rekt_By_Ruined_Ecba_lul >> 5;
				if (get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul < 16777216U)
				{
					get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_hAFc_lul = (get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_hAFc_lul << 8 | (uint)((byte)get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_DFDA_lul.ReadByte()));
					get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul <<= 8;
				}
				return 0U;
			}
			get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul -= num;
			get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_hAFc_lul -= num;
			this.Get_Rekt_By_Ruined_Ecba_lul -= this.Get_Rekt_By_Ruined_Ecba_lul >> 5;
			if (get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul < 16777216U)
			{
				get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_hAFc_lul = (get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_hAFc_lul << 8 | (uint)((byte)get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_DFDA_lul.ReadByte()));
				get_Rekt_By_Ruined_eCCH_lul_0.Get_Rekt_By_Ruined_AFCG_lul <<= 8;
			}
			return 1U;
		}

		// Token: 0x04000005 RID: 5
		internal uint Get_Rekt_By_Ruined_Ecba_lul;
	}

	// Token: 0x02000003 RID: 3
	internal struct Get_Rekt_By_Ruined_hChh_lul
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00003D3D File Offset: 0x00001F3D
		internal Get_Rekt_By_Ruined_hChh_lul(int int_0)
		{
			this.Get_Rekt_By_Ruined_gDfc_lul = int_0;
			this.Get_Rekt_By_Ruined_hFCh_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[1 << int_0];
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005864 File Offset: 0x00003A64
		internal void Get_Rekt_By_Ruined_CBbd_lul()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.Get_Rekt_By_Ruined_gDfc_lul & 31)))
			{
				this.Get_Rekt_By_Ruined_hFCh_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CaAC_lul();
				num += 1U;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000589C File Offset: 0x00003A9C
		internal uint Get_Rekt_By_Ruined_cBFB_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0)
		{
			uint num = 1U;
			for (int i = this.Get_Rekt_By_Ruined_gDfc_lul; i > 0; i--)
			{
				num = (num << 1) + this.Get_Rekt_By_Ruined_hFCh_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0);
			}
			return num - (1U << this.Get_Rekt_By_Ruined_gDfc_lul);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000058E4 File Offset: 0x00003AE4
		internal uint Get_Rekt_By_Ruined_BBbb_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.Get_Rekt_By_Ruined_gDfc_lul; i++)
			{
				uint num3 = this.Get_Rekt_By_Ruined_hFCh_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000592C File Offset: 0x00003B2C
		internal static uint Get_Rekt_By_Ruined_FbDb_lul(<Module>.Get_Rekt_By_Ruined_bHBb_lul[] get_Rekt_By_Ruined_bHBb_lul_0, uint uint_0, <Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0, int int_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_0; i++)
			{
				uint num3 = get_Rekt_By_Ruined_bHBb_lul_0[(int)((UIntPtr)(uint_0 + num))].Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000006 RID: 6
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_hFCh_lul;

		// Token: 0x04000007 RID: 7
		internal readonly int Get_Rekt_By_Ruined_gDfc_lul;
	}

	// Token: 0x02000004 RID: 4
	internal class Get_Rekt_By_Ruined_eCCH_lul
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000596C File Offset: 0x00003B6C
		internal void Get_Rekt_By_Ruined_dgdD_lul(Stream stream_0)
		{
			this.Get_Rekt_By_Ruined_DFDA_lul = stream_0;
			this.Get_Rekt_By_Ruined_hAFc_lul = 0U;
			this.Get_Rekt_By_Ruined_AFCG_lul = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.Get_Rekt_By_Ruined_hAFc_lul = (this.Get_Rekt_By_Ruined_hAFc_lul << 8 | (uint)((byte)this.Get_Rekt_By_Ruined_DFDA_lul.ReadByte()));
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003D57 File Offset: 0x00001F57
		internal void Get_Rekt_By_Ruined_HHdc_lul()
		{
			this.Get_Rekt_By_Ruined_DFDA_lul = null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003D60 File Offset: 0x00001F60
		internal void Get_Rekt_By_Ruined_GCCg_lul()
		{
			while (this.Get_Rekt_By_Ruined_AFCG_lul < 16777216U)
			{
				this.Get_Rekt_By_Ruined_hAFc_lul = (this.Get_Rekt_By_Ruined_hAFc_lul << 8 | (uint)((byte)this.Get_Rekt_By_Ruined_DFDA_lul.ReadByte()));
				this.Get_Rekt_By_Ruined_AFCG_lul <<= 8;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000059B8 File Offset: 0x00003BB8
		internal uint Get_Rekt_By_Ruined_BHFC_lul(int int_0)
		{
			uint num = this.Get_Rekt_By_Ruined_AFCG_lul;
			uint num2 = this.Get_Rekt_By_Ruined_hAFc_lul;
			uint num3 = 0U;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1U);
				num3 = (num3 << 1 | 1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8 | (uint)((byte)this.Get_Rekt_By_Ruined_DFDA_lul.ReadByte()));
					num <<= 8;
				}
			}
			this.Get_Rekt_By_Ruined_AFCG_lul = num;
			this.Get_Rekt_By_Ruined_hAFc_lul = num2;
			return num3;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal Get_Rekt_By_Ruined_eCCH_lul()
		{
		}

		// Token: 0x04000008 RID: 8
		internal uint Get_Rekt_By_Ruined_hAFc_lul;

		// Token: 0x04000009 RID: 9
		internal uint Get_Rekt_By_Ruined_AFCG_lul;

		// Token: 0x0400000A RID: 10
		internal Stream Get_Rekt_By_Ruined_DFDA_lul;
	}

	// Token: 0x02000005 RID: 5
	internal class Get_Rekt_By_Ruined_BaEd_lul
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00005A2C File Offset: 0x00003C2C
		internal Get_Rekt_By_Ruined_BaEd_lul()
		{
			this.Get_Rekt_By_Ruined_Hgfd_lul = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.Get_Rekt_By_Ruined_bceD_lul[num] = new <Module>.Get_Rekt_By_Ruined_hChh_lul(6);
				num++;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005B2C File Offset: 0x00003D2C
		internal void Get_Rekt_By_Ruined_GdDE_lul(uint uint_0)
		{
			if (this.Get_Rekt_By_Ruined_Hgfd_lul != uint_0)
			{
				this.Get_Rekt_By_Ruined_Hgfd_lul = uint_0;
				this.Get_Rekt_By_Ruined_cFcF_lul = Math.Max(this.Get_Rekt_By_Ruined_Hgfd_lul, 1U);
				uint uint_ = Math.Max(this.Get_Rekt_By_Ruined_cFcF_lul, 4096U);
				this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_Efdc_lul(uint_);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003DA3 File Offset: 0x00001FA3
		internal void Get_Rekt_By_Ruined_dHhd_lul(int int_0, int int_1)
		{
			this.Get_Rekt_By_Ruined_ffDe_lul.Get_Rekt_By_Ruined_hHae_lul(int_0, int_1);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005B78 File Offset: 0x00003D78
		internal void Get_Rekt_By_Ruined_bDee_lul(int int_0)
		{
			uint num = 1U << int_0;
			this.Get_Rekt_By_Ruined_FGEf_lul.Get_Rekt_By_Ruined_fBDb_lul(num);
			this.Get_Rekt_By_Ruined_DDaf_lul.Get_Rekt_By_Ruined_fBDb_lul(num);
			this.Get_Rekt_By_Ruined_eEfa_lul = num - 1U;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005BB0 File Offset: 0x00003DB0
		internal void Get_Rekt_By_Ruined_HEgA_lul(Stream stream_0, Stream stream_1)
		{
			this.Get_Rekt_By_Ruined_fEbg_lul.Get_Rekt_By_Ruined_dgdD_lul(stream_0);
			this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_eAde_lul(stream_1, this.Get_Rekt_By_Ruined_Cedd_lul);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.Get_Rekt_By_Ruined_eEfa_lul; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.Get_Rekt_By_Ruined_GcDc_lul[(int)((UIntPtr)num3)].Get_Rekt_By_Ruined_CaAC_lul();
					this.Get_Rekt_By_Ruined_DGAb_lul[(int)((UIntPtr)num3)].Get_Rekt_By_Ruined_CaAC_lul();
				}
				this.Get_Rekt_By_Ruined_hChB_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CaAC_lul();
				this.Get_Rekt_By_Ruined_CeFE_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CaAC_lul();
				this.Get_Rekt_By_Ruined_CeaC_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CaAC_lul();
				this.Get_Rekt_By_Ruined_fhDa_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CaAC_lul();
			}
			this.Get_Rekt_By_Ruined_ffDe_lul.Get_Rekt_By_Ruined_AChg_lul();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.Get_Rekt_By_Ruined_bceD_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CBbd_lul();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.Get_Rekt_By_Ruined_GcdD_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CaAC_lul();
			}
			this.Get_Rekt_By_Ruined_FGEf_lul.Get_Rekt_By_Ruined_aaEh_lul();
			this.Get_Rekt_By_Ruined_DDaf_lul.Get_Rekt_By_Ruined_aaEh_lul();
			this.Get_Rekt_By_Ruined_aDEC_lul.Get_Rekt_By_Ruined_CBbd_lul();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005CDC File Offset: 0x00003EDC
		internal void Get_Rekt_By_Ruined_afBE_lul(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.Get_Rekt_By_Ruined_HEgA_lul(stream_0, stream_1);
			<Module>.Get_Rekt_By_Ruined_hEcH_lul get_Rekt_By_Ruined_hEcH_lul = default(<Module>.Get_Rekt_By_Ruined_hEcH_lul);
			get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_BBBg_lul();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.Get_Rekt_By_Ruined_GcDc_lul[(int)((UIntPtr)(get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul << 4))].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul);
				get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_DgBG_lul();
				byte byte_ = this.Get_Rekt_By_Ruined_ffDe_lul.Get_Rekt_By_Ruined_GAGD_lul(this.Get_Rekt_By_Ruined_fEbg_lul, 0U, 0);
				this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_cefH_lul(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.Get_Rekt_By_Ruined_eEfa_lul;
				if (this.Get_Rekt_By_Ruined_GcDc_lul[(int)((UIntPtr)((get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul << 4) + num6))].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul) == 0U)
				{
					byte byte_2 = this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_BcaC_lul(0U);
					byte byte_3;
					if (!get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_GeHf_lul())
					{
						byte_3 = this.Get_Rekt_By_Ruined_ffDe_lul.Get_Rekt_By_Ruined_fheB_lul(this.Get_Rekt_By_Ruined_fEbg_lul, (uint)num5, byte_2, this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_BcaC_lul(num));
					}
					else
					{
						byte_3 = this.Get_Rekt_By_Ruined_ffDe_lul.Get_Rekt_By_Ruined_GAGD_lul(this.Get_Rekt_By_Ruined_fEbg_lul, (uint)num5, byte_2);
					}
					this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_cefH_lul(byte_3);
					get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_DgBG_lul();
					num5 += 1UL;
				}
				else
				{
					uint num8;
					if (this.Get_Rekt_By_Ruined_hChB_lul[(int)((UIntPtr)get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul)].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul) == 1U)
					{
						if (this.Get_Rekt_By_Ruined_CeFE_lul[(int)((UIntPtr)get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul)].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul) != 0U)
						{
							uint num7;
							if (this.Get_Rekt_By_Ruined_CeaC_lul[(int)((UIntPtr)get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul)].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul) == 0U)
							{
								num7 = num2;
							}
							else
							{
								if (this.Get_Rekt_By_Ruined_fhDa_lul[(int)((UIntPtr)get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul)].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul) == 0U)
								{
									num7 = num3;
								}
								else
								{
									num7 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						else if (this.Get_Rekt_By_Ruined_DGAb_lul[(int)((UIntPtr)((get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_aBbf_lul << 4) + num6))].Get_Rekt_By_Ruined_GbFe_lul(this.Get_Rekt_By_Ruined_fEbg_lul) == 0U)
						{
							get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_gbEh_lul();
							this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_cefH_lul(this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_BcaC_lul(num));
							num5 += 1UL;
							continue;
						}
						num8 = this.Get_Rekt_By_Ruined_DDaf_lul.Get_Rekt_By_Ruined_caHa_lul(this.Get_Rekt_By_Ruined_fEbg_lul, num6) + 2U;
						get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_gbeE_lul();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2U + this.Get_Rekt_By_Ruined_FGEf_lul.Get_Rekt_By_Ruined_caHa_lul(this.Get_Rekt_By_Ruined_fEbg_lul, num6);
						get_Rekt_By_Ruined_hEcH_lul.Get_Rekt_By_Ruined_EEFD_lul();
						uint num9 = this.Get_Rekt_By_Ruined_bceD_lul[(int)((UIntPtr)<Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_DGha_lul(num8))].Get_Rekt_By_Ruined_cBFB_lul(this.Get_Rekt_By_Ruined_fEbg_lul);
						if (num9 >= 4U)
						{
							int num10 = (int)((num9 >> 1) - 1U);
							num = (2U | (num9 & 1U)) << num10;
							if (num9 < 14U)
							{
								num += <Module>.Get_Rekt_By_Ruined_hChh_lul.Get_Rekt_By_Ruined_FbDb_lul(this.Get_Rekt_By_Ruined_GcdD_lul, num - num9 - 1U, this.Get_Rekt_By_Ruined_fEbg_lul, num10);
							}
							else
							{
								num += this.Get_Rekt_By_Ruined_fEbg_lul.Get_Rekt_By_Ruined_BHFC_lul(num10 - 4) << 4;
								num += this.Get_Rekt_By_Ruined_aDEC_lul.Get_Rekt_By_Ruined_BBbb_lul(this.Get_Rekt_By_Ruined_fEbg_lul);
							}
						}
						else
						{
							num = num9;
						}
					}
					if (((ulong)num >= num5 || num >= this.Get_Rekt_By_Ruined_cFcF_lul) && num == 4294967295U)
					{
						break;
					}
					this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_EBec_lul(num, num8);
					num5 += (ulong)num8;
				}
			}
			this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_EgCH_lul();
			this.Get_Rekt_By_Ruined_cAbE_lul.Get_Rekt_By_Ruined_CEah_lul();
			this.Get_Rekt_By_Ruined_fEbg_lul.Get_Rekt_By_Ruined_HHdc_lul();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006050 File Offset: 0x00004250
		internal void Get_Rekt_By_Ruined_hebh_lul(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			int num = (int)(byte_0[0] / 9);
			int int_2 = num % 5;
			int int_3 = num / 5;
			uint num2 = 0U;
			for (int i = 0; i < 4; i++)
			{
				num2 += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.Get_Rekt_By_Ruined_GdDE_lul(num2);
			this.Get_Rekt_By_Ruined_dHhd_lul(int_2, int_);
			this.Get_Rekt_By_Ruined_bDee_lul(int_3);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003DB2 File Offset: 0x00001FB2
		internal static uint Get_Rekt_By_Ruined_DGha_lul(uint uint_0)
		{
			uint_0 -= 2U;
			if (uint_0 < 4U)
			{
				return uint_0;
			}
			return 3U;
		}

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_GcDc_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[192];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_DGAb_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[192];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_hChB_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_CeFE_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_CeaC_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[12];

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_fhDa_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[12];

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FAdc_lul Get_Rekt_By_Ruined_FGEf_lul = new <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FAdc_lul();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FeEA_lul Get_Rekt_By_Ruined_ffDe_lul = new <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FeEA_lul();

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Get_Rekt_By_Ruined_AhcC_lul Get_Rekt_By_Ruined_cAbE_lul = new <Module>.Get_Rekt_By_Ruined_AhcC_lul();

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_GcdD_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[114];

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Get_Rekt_By_Ruined_hChh_lul[] Get_Rekt_By_Ruined_bceD_lul = new <Module>.Get_Rekt_By_Ruined_hChh_lul[4];

		// Token: 0x04000016 RID: 22
		internal readonly <Module>.Get_Rekt_By_Ruined_eCCH_lul Get_Rekt_By_Ruined_fEbg_lul = new <Module>.Get_Rekt_By_Ruined_eCCH_lul();

		// Token: 0x04000017 RID: 23
		internal readonly <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FAdc_lul Get_Rekt_By_Ruined_DDaf_lul = new <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FAdc_lul();

		// Token: 0x04000018 RID: 24
		internal bool Get_Rekt_By_Ruined_Cedd_lul;

		// Token: 0x04000019 RID: 25
		internal uint Get_Rekt_By_Ruined_Hgfd_lul;

		// Token: 0x0400001A RID: 26
		internal uint Get_Rekt_By_Ruined_cFcF_lul;

		// Token: 0x0400001B RID: 27
		internal <Module>.Get_Rekt_By_Ruined_hChh_lul Get_Rekt_By_Ruined_aDEC_lul = new <Module>.Get_Rekt_By_Ruined_hChh_lul(4);

		// Token: 0x0400001C RID: 28
		internal uint Get_Rekt_By_Ruined_eEfa_lul;

		// Token: 0x02000006 RID: 6
		internal class Get_Rekt_By_Ruined_FAdc_lul
		{
			// Token: 0x06000026 RID: 38 RVA: 0x000060B0 File Offset: 0x000042B0
			internal void Get_Rekt_By_Ruined_fBDb_lul(uint uint_0)
			{
				for (uint num = this.Get_Rekt_By_Ruined_ccec_lul; num < uint_0; num += 1U)
				{
					this.Get_Rekt_By_Ruined_Hbeg_lul[(int)((UIntPtr)num)] = new <Module>.Get_Rekt_By_Ruined_hChh_lul(3);
					this.Get_Rekt_By_Ruined_BGge_lul[(int)((UIntPtr)num)] = new <Module>.Get_Rekt_By_Ruined_hChh_lul(3);
				}
				this.Get_Rekt_By_Ruined_ccec_lul = uint_0;
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00006108 File Offset: 0x00004308
			internal void Get_Rekt_By_Ruined_aaEh_lul()
			{
				this.Get_Rekt_By_Ruined_GDdF_lul.Get_Rekt_By_Ruined_CaAC_lul();
				for (uint num = 0U; num < this.Get_Rekt_By_Ruined_ccec_lul; num += 1U)
				{
					this.Get_Rekt_By_Ruined_Hbeg_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CBbd_lul();
					this.Get_Rekt_By_Ruined_BGge_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_CBbd_lul();
				}
				this.Get_Rekt_By_Ruined_HBCg_lul.Get_Rekt_By_Ruined_CaAC_lul();
				this.Get_Rekt_By_Ruined_BHbD_lul.Get_Rekt_By_Ruined_CBbd_lul();
			}

			// Token: 0x06000028 RID: 40 RVA: 0x0000616C File Offset: 0x0000436C
			internal uint Get_Rekt_By_Ruined_caHa_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0, uint uint_0)
			{
				if (this.Get_Rekt_By_Ruined_GDdF_lul.Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0) == 0U)
				{
					return this.Get_Rekt_By_Ruined_Hbeg_lul[(int)((UIntPtr)uint_0)].Get_Rekt_By_Ruined_cBFB_lul(get_Rekt_By_Ruined_eCCH_lul_0);
				}
				uint num = 8U;
				if (this.Get_Rekt_By_Ruined_HBCg_lul.Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0) == 0U)
				{
					num += this.Get_Rekt_By_Ruined_BGge_lul[(int)((UIntPtr)uint_0)].Get_Rekt_By_Ruined_cBFB_lul(get_Rekt_By_Ruined_eCCH_lul_0);
				}
				else
				{
					num += 8U;
					num += this.Get_Rekt_By_Ruined_BHbD_lul.Get_Rekt_By_Ruined_cBFB_lul(get_Rekt_By_Ruined_eCCH_lul_0);
				}
				return num;
			}

			// Token: 0x06000029 RID: 41 RVA: 0x000061D8 File Offset: 0x000043D8
			internal Get_Rekt_By_Ruined_FAdc_lul()
			{
			}

			// Token: 0x0400001D RID: 29
			internal readonly <Module>.Get_Rekt_By_Ruined_hChh_lul[] Get_Rekt_By_Ruined_Hbeg_lul = new <Module>.Get_Rekt_By_Ruined_hChh_lul[16];

			// Token: 0x0400001E RID: 30
			internal readonly <Module>.Get_Rekt_By_Ruined_hChh_lul[] Get_Rekt_By_Ruined_BGge_lul = new <Module>.Get_Rekt_By_Ruined_hChh_lul[16];

			// Token: 0x0400001F RID: 31
			internal <Module>.Get_Rekt_By_Ruined_bHBb_lul Get_Rekt_By_Ruined_GDdF_lul = default(<Module>.Get_Rekt_By_Ruined_bHBb_lul);

			// Token: 0x04000020 RID: 32
			internal <Module>.Get_Rekt_By_Ruined_bHBb_lul Get_Rekt_By_Ruined_HBCg_lul = default(<Module>.Get_Rekt_By_Ruined_bHBb_lul);

			// Token: 0x04000021 RID: 33
			internal <Module>.Get_Rekt_By_Ruined_hChh_lul Get_Rekt_By_Ruined_BHbD_lul = new <Module>.Get_Rekt_By_Ruined_hChh_lul(8);

			// Token: 0x04000022 RID: 34
			internal uint Get_Rekt_By_Ruined_ccec_lul;
		}

		// Token: 0x02000007 RID: 7
		internal class Get_Rekt_By_Ruined_FeEA_lul
		{
			// Token: 0x0600002A RID: 42 RVA: 0x0000622C File Offset: 0x0000442C
			internal void Get_Rekt_By_Ruined_hHae_lul(int int_0, int int_1)
			{
				if (this.Get_Rekt_By_Ruined_AAEf_lul != null && this.Get_Rekt_By_Ruined_cfcd_lul == int_1)
				{
					if (this.Get_Rekt_By_Ruined_dCAE_lul == int_0)
					{
						return;
					}
				}
				this.Get_Rekt_By_Ruined_dCAE_lul = int_0;
				this.Get_Rekt_By_Ruined_DFCG_lul = (1U << int_0) - 1U;
				this.Get_Rekt_By_Ruined_cfcd_lul = int_1;
				uint num = 1U << this.Get_Rekt_By_Ruined_cfcd_lul + this.Get_Rekt_By_Ruined_dCAE_lul;
				this.Get_Rekt_By_Ruined_AAEf_lul = new <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FeEA_lul.Get_Rekt_By_Ruined_dgbg_lul[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.Get_Rekt_By_Ruined_AAEf_lul[(int)((UIntPtr)num2)].Get_Rekt_By_Ruined_AdCh_lul();
				}
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000062B0 File Offset: 0x000044B0
			internal void Get_Rekt_By_Ruined_AChg_lul()
			{
				uint num = 1U << this.Get_Rekt_By_Ruined_cfcd_lul + this.Get_Rekt_By_Ruined_dCAE_lul;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.Get_Rekt_By_Ruined_AAEf_lul[(int)((UIntPtr)num2)].Get_Rekt_By_Ruined_AFED_lul();
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00003DC0 File Offset: 0x00001FC0
			internal uint Get_Rekt_By_Ruined_aahD_lul(uint uint_0, byte byte_0)
			{
				return ((uint_0 & this.Get_Rekt_By_Ruined_DFCG_lul) << this.Get_Rekt_By_Ruined_cfcd_lul) + (uint)(byte_0 >> 8 - this.Get_Rekt_By_Ruined_cfcd_lul);
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00003DE2 File Offset: 0x00001FE2
			internal byte Get_Rekt_By_Ruined_GAGD_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0, uint uint_0, byte byte_0)
			{
				return this.Get_Rekt_By_Ruined_AAEf_lul[(int)((UIntPtr)this.Get_Rekt_By_Ruined_aahD_lul(uint_0, byte_0))].Get_Rekt_By_Ruined_EAaa_lul(get_Rekt_By_Ruined_eCCH_lul_0);
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00003DFE File Offset: 0x00001FFE
			internal byte Get_Rekt_By_Ruined_fheB_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0, uint uint_0, byte byte_0, byte byte_1)
			{
				return this.Get_Rekt_By_Ruined_AAEf_lul[(int)((UIntPtr)this.Get_Rekt_By_Ruined_aahD_lul(uint_0, byte_0))].Get_Rekt_By_Ruined_GeAA_lul(get_Rekt_By_Ruined_eCCH_lul_0, byte_1);
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00003D9B File Offset: 0x00001F9B
			internal Get_Rekt_By_Ruined_FeEA_lul()
			{
			}

			// Token: 0x04000023 RID: 35
			internal <Module>.Get_Rekt_By_Ruined_BaEd_lul.Get_Rekt_By_Ruined_FeEA_lul.Get_Rekt_By_Ruined_dgbg_lul[] Get_Rekt_By_Ruined_AAEf_lul;

			// Token: 0x04000024 RID: 36
			internal int Get_Rekt_By_Ruined_dCAE_lul;

			// Token: 0x04000025 RID: 37
			internal int Get_Rekt_By_Ruined_cfcd_lul;

			// Token: 0x04000026 RID: 38
			internal uint Get_Rekt_By_Ruined_DFCG_lul;

			// Token: 0x02000008 RID: 8
			internal struct Get_Rekt_By_Ruined_dgbg_lul
			{
				// Token: 0x06000030 RID: 48 RVA: 0x00003E1C File Offset: 0x0000201C
				internal void Get_Rekt_By_Ruined_AdCh_lul()
				{
					this.Get_Rekt_By_Ruined_AhCb_lul = new <Module>.Get_Rekt_By_Ruined_bHBb_lul[768];
				}

				// Token: 0x06000031 RID: 49 RVA: 0x00003E2E File Offset: 0x0000202E
				internal void Get_Rekt_By_Ruined_AFED_lul()
				{
					this.Get_Rekt_By_Ruined_AhCb_lul[0].Get_Rekt_By_Ruined_CaAC_lul();
				}

				// Token: 0x06000032 RID: 50 RVA: 0x000062F0 File Offset: 0x000044F0
				internal byte Get_Rekt_By_Ruined_EAaa_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0)
				{
					uint num = 2U | this.Get_Rekt_By_Ruined_AhCb_lul[(int)((UIntPtr)1)].Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0);
					if (num < 256U)
					{
					}
					return (byte)num;
				}

				// Token: 0x06000033 RID: 51 RVA: 0x00006320 File Offset: 0x00004520
				internal byte Get_Rekt_By_Ruined_GeAA_lul(<Module>.Get_Rekt_By_Ruined_eCCH_lul get_Rekt_By_Ruined_eCCH_lul_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.Get_Rekt_By_Ruined_AhCb_lul[(int)((UIntPtr)((1U + num2 << 8) + num))].Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5E;
						}
					}
					while (num < 256U)
					{
						num = (num << 1 | this.Get_Rekt_By_Ruined_AhCb_lul[(int)((UIntPtr)num)].Get_Rekt_By_Ruined_GbFe_lul(get_Rekt_By_Ruined_eCCH_lul_0));
					}
					IL_5E:
					return (byte)num;
				}

				// Token: 0x04000027 RID: 39
				internal <Module>.Get_Rekt_By_Ruined_bHBb_lul[] Get_Rekt_By_Ruined_AhCb_lul;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Get_Rekt_By_Ruined_AhcC_lul
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00003E41 File Offset: 0x00002041
		internal void Get_Rekt_By_Ruined_Efdc_lul(uint uint_0)
		{
			if (this.Get_Rekt_By_Ruined_bbGd_lul != uint_0)
			{
				this.Get_Rekt_By_Ruined_CagG_lul = new byte[uint_0];
			}
			this.Get_Rekt_By_Ruined_bbGd_lul = uint_0;
			this.Get_Rekt_By_Ruined_dFBc_lul = 0U;
			this.Get_Rekt_By_Ruined_aGFc_lul = 0U;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003E6E File Offset: 0x0000206E
		internal void Get_Rekt_By_Ruined_eAde_lul(Stream stream_0, bool bool_0)
		{
			this.Get_Rekt_By_Ruined_CEah_lul();
			this.Get_Rekt_By_Ruined_Daac_lul = stream_0;
			if (!bool_0)
			{
				this.Get_Rekt_By_Ruined_aGFc_lul = 0U;
				this.Get_Rekt_By_Ruined_dFBc_lul = 0U;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003E8E File Offset: 0x0000208E
		internal void Get_Rekt_By_Ruined_CEah_lul()
		{
			this.Get_Rekt_By_Ruined_EgCH_lul();
			this.Get_Rekt_By_Ruined_Daac_lul = null;
			Buffer.BlockCopy(new byte[this.Get_Rekt_By_Ruined_CagG_lul.Length], 0, this.Get_Rekt_By_Ruined_CagG_lul, 0, this.Get_Rekt_By_Ruined_CagG_lul.Length);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006390 File Offset: 0x00004590
		internal void Get_Rekt_By_Ruined_EgCH_lul()
		{
			uint num = this.Get_Rekt_By_Ruined_dFBc_lul - this.Get_Rekt_By_Ruined_aGFc_lul;
			if (num == 0U)
			{
				return;
			}
			this.Get_Rekt_By_Ruined_Daac_lul.Write(this.Get_Rekt_By_Ruined_CagG_lul, (int)this.Get_Rekt_By_Ruined_aGFc_lul, (int)num);
			if (this.Get_Rekt_By_Ruined_dFBc_lul >= this.Get_Rekt_By_Ruined_bbGd_lul)
			{
				this.Get_Rekt_By_Ruined_dFBc_lul = 0U;
			}
			this.Get_Rekt_By_Ruined_aGFc_lul = this.Get_Rekt_By_Ruined_dFBc_lul;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000063E8 File Offset: 0x000045E8
		internal void Get_Rekt_By_Ruined_EBec_lul(uint uint_0, uint uint_1)
		{
			uint num = this.Get_Rekt_By_Ruined_dFBc_lul - uint_0 - 1U;
			if (num >= this.Get_Rekt_By_Ruined_bbGd_lul)
			{
				num += this.Get_Rekt_By_Ruined_bbGd_lul;
			}
			while (uint_1 > 0U)
			{
				if (num >= this.Get_Rekt_By_Ruined_bbGd_lul)
				{
					num = 0U;
				}
				this.Get_Rekt_By_Ruined_CagG_lul[(int)((UIntPtr)(this.Get_Rekt_By_Ruined_dFBc_lul++))] = this.Get_Rekt_By_Ruined_CagG_lul[(int)((UIntPtr)(num++))];
				if (this.Get_Rekt_By_Ruined_dFBc_lul >= this.Get_Rekt_By_Ruined_bbGd_lul)
				{
					this.Get_Rekt_By_Ruined_EgCH_lul();
				}
				uint_1 -= 1U;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006464 File Offset: 0x00004664
		internal void Get_Rekt_By_Ruined_cefH_lul(byte byte_0)
		{
			this.Get_Rekt_By_Ruined_CagG_lul[(int)((UIntPtr)(this.Get_Rekt_By_Ruined_dFBc_lul++))] = byte_0;
			if (this.Get_Rekt_By_Ruined_dFBc_lul >= this.Get_Rekt_By_Ruined_bbGd_lul)
			{
				this.Get_Rekt_By_Ruined_EgCH_lul();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000064A0 File Offset: 0x000046A0
		internal byte Get_Rekt_By_Ruined_BcaC_lul(uint uint_0)
		{
			uint num = this.Get_Rekt_By_Ruined_dFBc_lul - uint_0 - 1U;
			if (num >= this.Get_Rekt_By_Ruined_bbGd_lul)
			{
				num += this.Get_Rekt_By_Ruined_bbGd_lul;
			}
			return this.Get_Rekt_By_Ruined_CagG_lul[(int)((UIntPtr)num)];
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal Get_Rekt_By_Ruined_AhcC_lul()
		{
		}

		// Token: 0x04000028 RID: 40
		internal byte[] Get_Rekt_By_Ruined_CagG_lul;

		// Token: 0x04000029 RID: 41
		internal uint Get_Rekt_By_Ruined_dFBc_lul;

		// Token: 0x0400002A RID: 42
		internal Stream Get_Rekt_By_Ruined_Daac_lul;

		// Token: 0x0400002B RID: 43
		internal uint Get_Rekt_By_Ruined_aGFc_lul;

		// Token: 0x0400002C RID: 44
		internal uint Get_Rekt_By_Ruined_bbGd_lul;
	}

	// Token: 0x0200000A RID: 10
	internal struct Get_Rekt_By_Ruined_hEcH_lul
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003EBF File Offset: 0x000020BF
		internal void Get_Rekt_By_Ruined_BBBg_lul()
		{
			this.Get_Rekt_By_Ruined_aBbf_lul = 0U;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003EC8 File Offset: 0x000020C8
		internal void Get_Rekt_By_Ruined_DgBG_lul()
		{
			if (this.Get_Rekt_By_Ruined_aBbf_lul < 4U)
			{
				this.Get_Rekt_By_Ruined_aBbf_lul = 0U;
				return;
			}
			if (this.Get_Rekt_By_Ruined_aBbf_lul >= 10U)
			{
				this.Get_Rekt_By_Ruined_aBbf_lul -= 6U;
				return;
			}
			this.Get_Rekt_By_Ruined_aBbf_lul -= 3U;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003F02 File Offset: 0x00002102
		internal void Get_Rekt_By_Ruined_EEFD_lul()
		{
			this.Get_Rekt_By_Ruined_aBbf_lul = ((this.Get_Rekt_By_Ruined_aBbf_lul < 7U) ? 7U : 10U);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003F18 File Offset: 0x00002118
		internal void Get_Rekt_By_Ruined_gbeE_lul()
		{
			this.Get_Rekt_By_Ruined_aBbf_lul = ((this.Get_Rekt_By_Ruined_aBbf_lul < 7U) ? 8U : 11U);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003F2E File Offset: 0x0000212E
		internal void Get_Rekt_By_Ruined_gbEh_lul()
		{
			this.Get_Rekt_By_Ruined_aBbf_lul = ((this.Get_Rekt_By_Ruined_aBbf_lul < 7U) ? 9U : 11U);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003F45 File Offset: 0x00002145
		internal bool Get_Rekt_By_Ruined_GeHf_lul()
		{
			return this.Get_Rekt_By_Ruined_aBbf_lul < 7U;
		}

		// Token: 0x0400002D RID: 45
		internal uint Get_Rekt_By_Ruined_aBbf_lul;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 1600)]
	internal struct Get_Rekt_By_Ruined_ebBb_lul
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5760)]
	internal struct Get_Rekt_By_Ruined_DEfB_lul
	{
	}
}
