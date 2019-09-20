using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SocketServerAndClient
{
    public partial class AnaForm : Form
    {
        Thread t;
        TcpClient baglantikur;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;
        public delegate void ricdegis(string text);
        public AnaForm()
        {
            InitializeComponent();
        }
        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                s = "Server: " +s;
                TxtDialog.AppendText(s + "\n");
            }
        }
        public void okumayabasla()
        {
            ag = baglantikur.GetStream();
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }
        public void baglanti_kur()
        {
            try
            {
                //Ben Lochalhos üzerinde deneme yapacagim icin 127.0.0.1 verdim
                baglantikur = new TcpClient("127.0.0.1", 80);
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
                TxtDialog.AppendText(DateTime.Now.ToString() + " Baglanti kuruldu…\n");
            }
            catch (Exception)
            {

                MessageBox.Show("Server ile baglanti kurulurken hata olustu !");
            }
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            if (TxtMessage.Text == "")//Burda bos alan göndermeyi önlüyoruz…
            {
                return;
            }
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(TxtMessage.Text);
                yaz.Flush();
                TxtDialog.AppendText(TxtMessage.Text + "\n");
                TxtMessage.Text = "";
            }
        }

        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            baglanti_kur();
        }

        private void BtnBaglantiKes_Click(object sender, EventArgs e)
        {
            baglantikur.Client.Close();
        }
    }
}
