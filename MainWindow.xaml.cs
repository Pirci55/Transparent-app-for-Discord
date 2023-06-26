using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Numerics;
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
            var waveFormat = new WaveFormat(96000, 32, 2);
            var samples = new BufferedWaveProvider(waveFormat);
            var stream = new SampleChannel(samples);
            waveInEvent.WaveFormat = waveFormat;
            waveInEvent.DataAvailable += (sender, e) => {
                samples.AddSamples(e.Buffer, 0, e.BytesRecorded);
                if (samples.BufferedBytes > 2000 && waveOutEvent.PlaybackState != PlaybackState.Playing) {
                    waveOutEvent.Init(stream);
                    waveOutEvent.Play();
                };
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

            volumeName.Content = "Volume: " + (int)volumeSlider.Value + "%";
            waveOutEvent.Volume = (float)volumeSlider.Value / 100;
            volumeSlider.ValueChanged += (object sender, RoutedPropertyChangedEventArgs<double> e) => {
                waveOutEvent.Volume = (float)volumeSlider.Value / 100;
                volumeName.Content = "Volume: " + (int)volumeSlider.Value + "%";
            };

            startButton.Click += (object sender, RoutedEventArgs e) => {
                waveOutEvent.DeviceNumber = (int)outputDeviceSlider.Value;
                waveInEvent.DeviceNumber = (int)inputDeviceSlider.Value;
                waveInEvent.StopRecording();
                waveInEvent.StartRecording();
            };
            showButton.Click += (object sender, RoutedEventArgs e) => { config.Opacity = 1; };
            hideButton.Click += (object sender, RoutedEventArgs e) => { config.Opacity = 0; };
            closeButton.Click += (object sender, RoutedEventArgs e) => { window.Close(); };

            Top = 0;
            Left = 0;
            Width = SystemParameters.WorkArea.Width;
            Height = SystemParameters.WorkArea.Height - 1;
        }
    }
}
