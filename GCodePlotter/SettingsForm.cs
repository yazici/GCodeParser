﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodePlotter
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			cpRapidMove.SelectedColor = ColorHelper.GetColor(PenColorList.RapidMove);
			cpCWArc.SelectedColor = ColorHelper.GetColor(PenColorList.CWArc);
			cpCCWArc.SelectedColor = ColorHelper.GetColor(PenColorList.CCWArc);
			cpRapidMoveHighlight.SelectedColor = ColorHelper.GetColor(PenColorList.RapidMoveHilight);
			cpLineHighlight.SelectedColor = ColorHelper.GetColor(PenColorList.LineHighlight);
			cpBackground.SelectedColor = ColorHelper.GetColor(PenColorList.Background);
			cpGridLines.SelectedColor = ColorHelper.GetColor(PenColorList.GridLines);
		}

		private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ColorHelper.SetColor(PenColorList.RapidMove, cpRapidMove.SelectedColor);
			ColorHelper.SetColor(PenColorList.NormalMove, cpNormalMove.SelectedColor);
			ColorHelper.SetColor(PenColorList.CWArc, cpCWArc.SelectedColor);
			ColorHelper.SetColor(PenColorList.CCWArc, cpCCWArc.SelectedColor);
			ColorHelper.SetColor(PenColorList.RapidMoveHilight, cpRapidMoveHighlight.SelectedColor);
			ColorHelper.SetColor(PenColorList.LineHighlight, cpLineHighlight.SelectedColor);
			ColorHelper.SetColor(PenColorList.Background, cpBackground.SelectedColor);
			ColorHelper.SetColor(PenColorList.GridLines, cpGridLines.SelectedColor);
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
