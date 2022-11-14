/*
*   Copyright (C) 2022 by N5UWU
*   This program is distributed WITHOUT WARRANTY.
*/

using System.Security.Cryptography;
using System.Text;

namespace LLA_KEYGEN
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void Gen_Click(object sender, EventArgs e)
		{
			try
			{
				AesManaged Aes = new AesManaged();
				Aes.KeySize = 128;
				Aes.GenerateKey();
				string KI = IN.Text;
				byte[] KIb = Encoding.Unicode.GetBytes(KI);
				int KIbI = BitConverter.ToInt32(KIb);
				Random RND = new Random(KIbI);
				Random RNDi = new Random();
				string LEY;
				byte[] LEYb;
				int i = RNDi.Next(1, 10000);
				do
				{
					LEY = RND.Next().ToString();
					i--;
				} while (i != 0);

				LEYb = Encoding.Unicode.GetBytes(LEY);
				if (LEYb.Length <= 16)
				{
					do
					{
						LEY = LEY + RND.Next().ToString();
						LEYb = Encoding.Unicode.GetBytes(LEY);
					}
					while (LEYb.Length != 16);
				}
				outbox.Text = ComputeMd5Hash(LEY);
				int end = outbox.Text.Length;
				if (end == 32)
				{
					en.ForeColor = Color.Green;
					en.BackColor = Color.Green;
				}
				else
				{
					en.ForeColor = Color.Red;
					en.BackColor = Color.Red;
				}
				en.Text = end.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static string ComputeMd5Hash(string message)
		{
			using (MD5 md5 = MD5.Create())
			{
				byte[] input = Encoding.Unicode.GetBytes(message);
				byte[] hash = md5.ComputeHash(input);

				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hash.Length; i++)
				{
					sb.Append(hash[i].ToString("X2"));
				}
				return sb.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IN.Text = "";
			outbox.Text = "";
		}
	}
}