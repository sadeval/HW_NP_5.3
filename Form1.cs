using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamletViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            string url = "https://www.gutenberg.org/files/1524/1524-0.txt"; 

            try
            {
                string hamletText = await LoadHamletTextAsync(url);
                textBoxHamlet.Text = hamletText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке текста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> LoadHamletTextAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string textContent = await response.Content.ReadAsStringAsync();
                return textContent;
            }
        }
    }
}
