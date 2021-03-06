﻿/**
 * Copyright (c) David-John Miller AKA Anoyomouse 2014
 *
 * See LICENCE in the project directory for licence information
 **/
namespace GCodePlotter
{
	partial class frmLayerEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdOk = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txLayerDepth = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(291, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Insert a list of Z heights, one per line";
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(174, 236);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(82, 33);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			// 
			// cmdOk
			// 
			this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOk.Location = new System.Drawing.Point(59, 236);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(82, 33);
			this.cmdOk.TabIndex = 6;
			this.cmdOk.Text = "Ok";
			this.cmdOk.UseVisualStyleBackColor = true;
			this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Location = new System.Drawing.Point(13, 36);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(289, 110);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "0.1\r\n0.15\r\n0.2";
			this.textBox1.WordWrap = false;
			// 
			// txLayerDepth
			// 
			this.txLayerDepth.Location = new System.Drawing.Point(15, 168);
			this.txLayerDepth.Name = "txLayerDepth";
			this.txLayerDepth.Size = new System.Drawing.Size(287, 20);
			this.txLayerDepth.TabIndex = 11;
			this.txLayerDepth.Text = "0.1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(291, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Depth of Layer";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(15, 210);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(287, 20);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(291, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Total Depth";
			// 
			// frmLayerEditor
			// 
			this.AcceptButton = this.cmdOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(316, 278);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txLayerDepth);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLayerEditor";
			this.Text = "Layer Editor";
			this.Load += new System.EventHandler(this.frmLayerEditor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txLayerDepth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
	}
}