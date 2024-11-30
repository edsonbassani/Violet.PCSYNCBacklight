using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace Violet.PCSYNCBacklight
{
    public partial class Main : Form
    {
        private SerialPort _serialPort; // Class-level field for SerialPort

        public Main()
        {
            InitializeComponent();
            this.FormClosing += Main_FormClosing;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillPorts();
        }

        private void FillPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            ddlPort.Items.AddRange(ports);

            // Preselect COM4 if available
            ddlPort.SelectedItem = ports.FirstOrDefault(_ => _ == "COM4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenCommunication();

            if (_serialPort != null && _serialPort.IsOpen)
            {
                TurnOn(_serialPort);
            }
        }

        private void OpenCommunication()
        {
            if (ddlPort.SelectedItem != null)
            {
                try
                {
                    // Check if the port is already open
                    if (_serialPort == null || !_serialPort.IsOpen)
                    {
                        // Initialize and open the SerialPort
                        _serialPort = new SerialPort(
                            ddlPort.SelectedItem.ToString(),
                            9600,
                            Parity.None,
                            8,
                            StopBits.One
                        );
                        _serialPort.Open();
                        tslInfo.Text = "Connected to " + ddlPort.SelectedItem.ToString();
                    }
                }
                catch (UnauthorizedAccessException)
                {
                }
                catch (Exception)
                {
                }
            }
        }

        private static void SendCommand(SerialPort port, byte[] command, string action)
        {
            if (port != null && port.IsOpen)
            {
                try
                {
                    port.Write(command, 0, command.Length);
                    System.Threading.Thread.Sleep(500); // Wait for device response
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send command '{action}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Cannot send command '{action}': Port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseCommunication()
        {
            if (_serialPort != null)
            {
                try
                {
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.Close(); // Close the port
                    }
                }
                catch
                {
                    // Ignore exceptions during cleanup
                }
                finally
                {
                    _serialPort.Dispose(); // Always dispose the port
                    _serialPort = null;
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    // Send the TurnOff command
                    TurnOff(_serialPort);

                    // Wait to ensure the command is processed before closing the port
                    System.Threading.Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while turning off the backlight: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Safely close and clean up the serial port
                CloseCommunication();
            }
        }

        private static void TurnOn(SerialPort port)
        {
            if (port != null && port.IsOpen)
            {
                byte[] command = { 0x52, 0x42, 0x10, 0x9e, 0x86, 0x01, 0x55, 0x55, 0x55, 0x4b, 0x4c, 0x55, 0x55, 0x55, 0xfe, 0x5c };
                SendCommand(port, command, "Turn ON");
            }
        }

        private static void TurnOff(SerialPort port)
        {
            if (port != null && port.IsOpen)
            {
                try
                {
                    // TurnOff command bytes (customize for your LED device)
                    byte[] command = { 0x52, 0x42, 0x10, 0x8f, 0x86, 0x01, 0x00, 0x00, 0x00, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x4f };

                    // Send the TurnOff command
                    port.Write(command, 0, command.Length);

                    // Force the command to transmit
                    port.BaseStream.Flush();

                    // Delay to ensure the device processes the command
                    System.Threading.Thread.Sleep(1000); // 1 second delay
                }
                catch
                {
                }
            }
        }

        private void btn_TurnOff_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                TurnOff(_serialPort);
            }
            else
            {
                MessageBox.Show("The port is not open or initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SetColor(string color, SerialPort port)
        {
            byte[] command;

            switch (color.ToLower())
            {
                case "red":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x3c, 0x86, 0x01, 0xff, 0x00, 0x00, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0xfb };
                    break;
                case "green":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x6e, 0x86, 0x01, 0x00, 0xff, 0x00, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x2d };
                    break;
                case "blue":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x74, 0x86, 0x01, 0x00, 0x00, 0xff, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x33 };
                    break;
                case "yellow":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x76, 0x86, 0x01, 0x7f, 0x7f, 0x00, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x34 };
                    break;
                case "magenta":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x78, 0x86, 0x01, 0x7f, 0x00, 0x7f, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x36 };
                    break;
                case "cyan":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x7e, 0x86, 0x01, 0x00, 0x7f, 0x7f, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x3c };
                    break;
                case "white":
                    command = new byte[] { 0x52, 0x42, 0x10, 0x9e, 0x86, 0x01, 0x55, 0x55, 0x55, 0x4b, 0x4c, 0x55, 0x55, 0x55, 0xfe, 0x5c };
                    break;
                default:
                    command = new byte[] { 0x52, 0x42, 0x10, 0x89, 0x86, 0x01, 0x55, 0x55, 0x55, 0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, 0x48 };
                    break;
            }
            SendCommand(port, command, $"Set Color: {color}");
        }

        private void btn_Red_Click(object sender, EventArgs e)
        {
            SetColor("red", _serialPort);
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            SetColor("green", _serialPort);
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            SetColor("blue", _serialPort);
        }

        private void btn_Yellow_Click(object sender, EventArgs e)
        {
            SetColor("yellow", _serialPort);
        }

        private void btn_Magenta_Click(object sender, EventArgs e)
        {
            SetColor("magenta", _serialPort);
        }

        private void btn_Cyan_Click(object sender, EventArgs e)
        {
            SetColor("cyan", _serialPort);
        }

        private void btn_White_Click(object sender, EventArgs e)
        {
            SetColor("white", _serialPort);
        }

        private void btn_ColorPicker_Click(object sender, EventArgs e)
        {
            // Open the Color Picker dialog
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    ApplyColorToLED(selectedColor);
                }
            }
        }

        private void ApplyColorToLED(Color color)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                try
                {
                    // Convert Color to RGB byte values
                    byte red = color.R;
                    byte green = color.G;
                    byte blue = color.B;

                    // Send RGB values to the LED
                    byte[] command = CreateColorCommand(red, green, blue);
                    SendCommand(_serialPort, command, $"Set Color: {color}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send color to LED: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serial port is not open. Please connect to the device first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private byte[] CreateColorCommand(byte red, byte green, byte blue)
        {
            // Example command structure: [Header, Red, Green, Blue, Footer]
            return new byte[]
            {
                0x52, 0x42, 0x10, 0x9e, 0x86, 0x01, // Command header
                red, green, blue, // RGB values
                0x4b, 0x4c, 0x00, 0x00, 0x00, 0xfe, // Command footer
                CalculateChecksum(red, green, blue) // Add checksum if necessary
            };
        }

        private byte CalculateChecksum(byte red, byte green, byte blue)
        {
            // Simple checksum calculation example (can be replaced with actual checksum logic)
            return (byte)((red + green + blue) % 256);
        }
    }
}
