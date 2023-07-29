using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace Whatsapp_Automation__app
{
    public partial class Form1 : Form
    {
        

        public IWebDriver driver;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sndBtn.BackColor = Color.Green;
            sndBtn.ForeColor = Color.White;

        }

        private void snd_Button(object sender, EventArgs e)
        {

            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                options.AddArgument(@"--user-data-dir=C:\Users\ASM El Masrya\AppData\Local\Google\Chrome\User Data\Person 1");
                IWebDriver driver = new ChromeDriver(options);
                MessageBox.Show("Please scan the QR code using Mobile When it appears , press ok to proceed");
                string windowHandle = driver.CurrentWindowHandle;
                IntPtr hwnd = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(windowHandle);
                // Minimize the browser window
                ShowWindow(hwnd, 6);
                driver.Url = "https://web.whatsapp.com/";
                driver.Manage().Window.Minimize();
                Thread.Sleep(30000);
                var searchtxt = driver.FindElement(By.XPath("//div[@title='Search input textbox']"));
                searchtxt.SendKeys(cntctNmbr.Text);
                searchtxt.SendKeys(Keys.Enter);
                var attach = driver.FindElement(By.XPath("//div[@title='Attach']"));
                attach.Click();
                var attachPdf = driver.FindElement(By.XPath("(//li[@class='_1LsXI Iaqxu FCS6Q'])[4]"));
                var fileButton = driver.FindElement(By.CssSelector("input[type = 'file']"));
                fileButton.SendKeys(linkLabel.Text);
                Thread.Sleep(5000);
                var chat = driver.FindElement(By.CssSelector("div[title='Type a message']"));
                chat.SendKeys(MsgField.Text);
                var SendButton = driver.FindElement(By.CssSelector("span[data-testid='send']"));
                SendButton.Click();
                 
              
               
               
            }
            catch (NoSuchElementException)
            {

                driver.Close();
                
            }
        }

            private void attachFiles(object sender, LinkLabelLinkClickedEventArgs e)
            {
                openFileDialog1.ShowDialog();
                linkLabel.Text = openFileDialog1.FileName;
            }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

