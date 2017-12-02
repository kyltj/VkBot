using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using HtmlAgilityPack;
using VkNet.Model;

namespace vk.com
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        [STAThread]
        private void button1_Click(object sender, EventArgs e)
        {
            
            var vk = new VkApi();
            int appID = 4829177;                     	// ID приложения
            string email = "kulbit-dima@mail.ru";        	// email или телефон
            string pass = "доблесть";              	// пароль для авторизации
            VkNet.Enums.Filters.Settings scope = VkNet.Enums.Filters.Settings.Audio; 	// Права доступа приложения


            
            
            
            

        }
    }
}
