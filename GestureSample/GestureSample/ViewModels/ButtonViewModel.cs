﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GestureSample.ViewModels
{
	public class ButtonViewModel : CustomEventArgsViewModel
	{
		public ICommand ClickedCommand { get; protected set; }

		public ButtonViewModel()
		{
			ClickedCommand = new Command<object>(OnClicked);
		}

		private void OnClicked(object obj)
		{
			AddText("{0} was clicked.", obj);
		}
	}
}
