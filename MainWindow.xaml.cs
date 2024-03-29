using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Transparent_app {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            var waveOutEvent = new WaveOutEvent();
            var waveInEvent = new WaveInEvent();
            var waveFormat = new WaveFormat(384000, 32, 2);
            var samples = new BufferedWaveProvider(waveFormat);
            var stream = new SampleChannel(samples);

            waveOutEvent.DesiredLatency = 250;
            waveInEvent.WaveFormat = waveFormat;
            waveInEvent.DataAvailable += (object? sender, WaveInEventArgs e) => {
                samples.AddSamples(e.Buffer, 0, e.BytesRecorded);
            };

            inputDeviceSlider.Maximum = WaveIn.DeviceCount - 1;
            inputDeviceName.Content = "Input: " + WaveIn.GetCapabilities((int)inputDeviceSlider.Value).ProductName;
            inputDeviceSlider.ValueChanged += (object sender, RoutedPropertyChangedEventArgs<double> e) => {
                inputDeviceName.Content = "Input: " + WaveIn.GetCapabilities((int)inputDeviceSlider.Value).ProductName;
            };

            outputDeviceSlider.Maximum = WaveOut.DeviceCount - 1;
            outputDeviceName.Content = "Output: " + WaveOut.GetCapabilities((int)outputDeviceSlider.Value).ProductName;
            outputDeviceSlider.ValueChanged += (object sender, RoutedPropertyChangedEventArgs<double> e) => {
                outputDeviceName.Content = "Output: " + WaveOut.GetCapabilities((int)outputDeviceSlider.Value).ProductName;
            };

            stream.Volume = (float)volumeSlider.Value / 100;
            volumeName.Content = "Volume: " + (int)volumeSlider.Value + "%";
            volumeSlider.ValueChanged += (object sender, RoutedPropertyChangedEventArgs<double> e) => {
                stream.Volume = (float)volumeSlider.Value / 100;
                volumeName.Content = "Volume: " + (int)volumeSlider.Value + "%";
            };

            xPosBox.TextChanged += (object sender, TextChangedEventArgs e) => {
                try {
                    if (xPosBox.Text.ToLower() == "auto") {
                        Left = 0;
                    } else {
                        Left = int.Parse(xPosBox.Text);
                    };
                } catch { };
            };
            yPosBox.TextChanged += (object sender, TextChangedEventArgs e) => {
                try {
                    if (yPosBox.Text.ToLower() == "auto") {
                        Top = 0;
                    } else {
                        Top = int.Parse(yPosBox.Text);
                    };
                } catch { };
            };
            widthBox.TextChanged += (object sender, TextChangedEventArgs e) => {
                try {
                    if (widthBox.Text.ToLower() == "auto") {
                        Width = SystemParameters.WorkArea.Width;
                    } else {
                        Width = int.Parse(widthBox.Text);
                    };
                } catch { };
            };
            heigthBox.TextChanged += (object sender, TextChangedEventArgs e) => {
                try {
                    if (heigthBox.Text.ToLower() == "auto") {
                        Height = Height = SystemParameters.WorkArea.Height - 1;
                    } else {
                        Height = int.Parse(heigthBox.Text);
                    };
                } catch { };
            };
            Left = 0;
            Top = 0;
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height - 1;

            startButton.Click += (object sender, RoutedEventArgs e) => {
                waveOutEvent.Stop();
                waveInEvent.StopRecording();
                samples.ClearBuffer();
                waveOutEvent.Dispose();
                waveInEvent.Dispose();
                GC.Collect(0, GCCollectionMode.Forced, true);

                waveOutEvent.DeviceNumber = (int)outputDeviceSlider.Value;
                waveInEvent.DeviceNumber = (int)inputDeviceSlider.Value;
                waveInEvent.StartRecording();
                waveOutEvent.Init(stream);
                waveOutEvent.Play();
            };
            showButton.Click += (object sender, RoutedEventArgs e) => { config.Opacity = 1; };
            hideButton.Click += (object sender, RoutedEventArgs e) => { config.Opacity = 0; };
            closeButton.Click += (object sender, RoutedEventArgs e) => { window.Close(); };
        }
    }
}
