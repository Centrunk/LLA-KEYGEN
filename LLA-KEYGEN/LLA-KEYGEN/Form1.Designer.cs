namespace LLA_KEYGEN
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Gen = new System.Windows.Forms.Button();
			this.outbox = new System.Windows.Forms.TextBox();
			this.IN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.en = new System.Windows.Forms.Label();
			this.RID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Gen
			// 
			this.Gen.Location = new System.Drawing.Point(347, 25);
			this.Gen.Name = "Gen";
			this.Gen.Size = new System.Drawing.Size(75, 23);
			this.Gen.TabIndex = 0;
			this.Gen.Text = "GO";
			this.Gen.UseVisualStyleBackColor = true;
			this.Gen.Click += new System.EventHandler(this.Gen_Click);
			// 
			// outbox
			// 
			this.outbox.Location = new System.Drawing.Point(579, 26);
			this.outbox.Name = "outbox";
			this.outbox.Size = new System.Drawing.Size(209, 23);
			this.outbox.TabIndex = 1;
			// 
			// IN
			// 
			this.IN.Location = new System.Drawing.Point(12, 26);
			this.IN.Name = "IN";
			this.IN.Size = new System.Drawing.Size(209, 23);
			this.IN.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Radio SN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(652, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Radio LLA Key";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(347, 54);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "CLEAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// en
			// 
			this.en.AutoSize = true;
			this.en.Location = new System.Drawing.Point(706, 91);
			this.en.Name = "en";
			this.en.Size = new System.Drawing.Size(0, 15);
			this.en.TabIndex = 6;
			// 
			// RID
			// 
			this.RID.Location = new System.Drawing.Point(241, 26);
			this.RID.Name = "RID";
			this.RID.Size = new System.Drawing.Size(90, 23);
			this.RID.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(258, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Radio ID";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LLA_KEYGEN.Properties.Resources.CENTEX_TRUNKED_RADIO_SYSTEM_v2_1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 115);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.RID);
			this.Controls.Add(this.en);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IN);
			this.Controls.Add(this.outbox);
			this.Controls.Add(this.Gen);
			this.Name = "Form1";
			this.Text = "v";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button Gen;
		private TextBox outbox;
		private TextBox IN;
		private Label label1;
		private Label label2;
		private Button button1;
		private Label en;
		private TextBox RID;
		private Label label3;
	}
}