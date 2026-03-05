namespace Vue_Icons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // تفعيل DPI Scaling
            // يمنع الـ WinForms من إعادة القياس تلقائيًا
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader nr = new StreamReader(Application.StartupPath + "\\" + "ip.ini");
            textBoxIP.Text = nr.ReadLine();
            textBoxPort.Text = nr.ReadLine();
            nr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter nw = new StreamWriter(Application.StartupPath + "\\" + "ip.ini");
            nw.WriteLine(textBoxIP.Text);
            nw.WriteLine(textBoxPort.Text);
            nw.Close();
            MessageBox.Show("Save IP");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_0.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_02.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_03.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_04.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_05.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_06.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_07.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_08.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_09.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\vue_icon_10.elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = comboBox1.Text; // مثال: Img_01r

                string path = $@"vue\Img\{selected}.png";

                if (File.Exists(path))
                {
                    pictureBox12.Image = Image.FromFile(path);
                    pictureBox12.Size = new Size(105, 105);
                }
                else
                {
                    MessageBox.Show("The image does not exist: " + path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            StreamWriter swa = new StreamWriter(Application.StartupPath + "\\vue.bat");
            swa.WriteLine("@echo off\nvue\\socat\\socat.exe -t 99999999 - TCP:" + textBoxIP.Text + ":" + textBoxPort.Text + "< vue\\payloads\\" + comboBox1.Text + ".elf" + "\npause");
            swa.Close();
            System.Diagnostics.Process.Start(@"vue.bat");
        }
    }
}
