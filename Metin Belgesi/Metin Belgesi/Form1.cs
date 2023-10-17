using System.IO;
using System.Windows.Forms;

namespace Metin_Belgesi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        string belgeadi, belgeyolu;
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = belgeyolu.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            belgeadi = textBox1.Text;
            sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satýr = oku.ReadLine();
                while (satýr != null)
                {
                    listBox1.Items.Add(satýr);
                    satýr = oku.ReadLine();
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "Metin Belgesi(*txt | *.txt";
            ac.Multiselect = false;
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = ac.SafeFileName;
                try
                {
                    StreamReader oku = new StreamReader(ac.FileName);
                    richTextBox1.Text = oku.ReadToEnd();
                    oku.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bu dosyayý okurken bir hata oluþtu");
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayýt Yerini Seçin";
                saveFileDialog1.Filter= "Metin Belgesi(*txt | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet= new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox2.Text);
                kaydet.Close();
                MessageBox.Show("Kaynak metin belges" +
                    "ne yazdýrýldý");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluþtu iþlem gerçekleþmedi"); 
            }
        }
    }
}