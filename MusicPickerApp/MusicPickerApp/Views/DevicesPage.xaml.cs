﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MusicPickerApp.Views {
    public partial class DevicesPage : ContentPage {

        public static List<DeviceView> DevicesView {
            get;
            set;
        }
        public DevicesPage(List<DeviceView> Devices) {

            //Devices.Sort<>()...
            DevicesView = Devices;

            InitializeComponent();
            
            
            
        }
    }
}
