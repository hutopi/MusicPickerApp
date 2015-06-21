﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPickerApp.ViewModels;
using Xamarin.Forms;

namespace MusicPickerApp.Views {
    public partial class DevicePage : TabbedPage {
        public DevicePage() {
            InitializeComponent();
            this.BindingContext = new DeviceViewModel();
        }
    }
}
