/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 01/03/2022
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lB = new System.Windows.Forms.ListBox();
			this.tB1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lB
			// 
			this.lB.FormattingEnabled = true;
			this.lB.ItemHeight = 16;
			this.lB.Location = new System.Drawing.Point(26, 204);
			this.lB.Name = "lB";
			this.lB.Size = new System.Drawing.Size(431, 148);
			this.lB.TabIndex = 0;
			// 
			// tB1
			// 
			this.tB1.Location = new System.Drawing.Point(139, 93);
			this.tB1.Name = "tB1";
			this.tB1.Size = new System.Drawing.Size(270, 22);
			this.tB1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nama Instansi";
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(209, 157);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 29);
			this.btn1.TabIndex = 3;
			this.btn1.Text = "Kirim";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(183, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Pendataan";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(503, 372);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tB1);
			this.Controls.Add(this.lB);
			this.Name = "MainForm";
			this.Text = "Tugas 2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tB1;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lB;
	}
}
