using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWindowsApp
{
    public partial class Form1 : Form
    {
        private HubConnection connection;
        string urlSignalR = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.InvokeAsync("SendMessageToAll",
                     txt_message.Text,txt_user.Text);
            }
            catch (Exception ex)
            {
                message_list.Items.Add(ex.Message);
            }
        }

        private async void btConnect_Click(object sender, EventArgs e)
        {

            urlSignalR = txt_urlHost.Text;
            connection = new HubConnectionBuilder()
                .WithUrl(urlSignalR)
                .Build();

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
            };

            connection.On<string, string>("ReceiveMessage", (message, user) =>
            {
                this.Invoke((Action)(() =>
                {
                    var newMessage = $"{user}: {message}";
                    message_list.Items.Add(newMessage);
                }));
            });

            try
            {
                await connection.StartAsync();
                message_list.Items.Add("Connection started");
                //connectButton.IsEnabled = false;
               // btSend.IsEnabled = true;
            }
            catch (Exception ex)
            {
                message_list.Items.Add(ex.Message);
            }
        }

        private void btn_connect_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
