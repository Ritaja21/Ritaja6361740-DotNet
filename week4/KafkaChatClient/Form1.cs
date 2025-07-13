using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace KafkaChatClient
{
    public partial class Form1 : Form
    {
        private TextBox txtUsername;
        private TextBox txtMessage;
        private Button btnSend;
        private ListBox lstChat;

        private readonly HttpClient _http = new HttpClient();

        public Form1()
        {
            InitializeComponent();

            // Create UI
            txtUsername = new TextBox { Top = 20, Left = 20, Width = 200, PlaceholderText = "Username" };
            txtMessage = new TextBox { Top = 60, Left = 20, Width = 300, Height = 100, Multiline = true };
            btnSend = new Button { Text = "Send", Top = 170, Left = 20, Height = 40 };
            lstChat = new ListBox { Top = 210, Left = 20, Width = 400, Height = 200 };

            btnSend.Click += BtnSend_Click;

            Controls.Add(txtUsername);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(lstChat);
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var message = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Enter both user and message.");
                return;
            }

            var chatMessage = new
            {
                User = user,
                Message = message,
                Timestamp = DateTime.Now
            };

            try
            {
                var response = await _http.PostAsJsonAsync("http://localhost:5244/api/chat", chatMessage);

                if (response.IsSuccessStatusCode)
                {
                    lstChat.Items.Add($"{user}: {message}");
                    txtMessage.Clear();
                }
                else
                {
                    MessageBox.Show("Message failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
