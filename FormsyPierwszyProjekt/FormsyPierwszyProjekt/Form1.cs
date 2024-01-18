using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsyPierwszyProjekt
{

    public partial class Form1 : Form
    {
        public string path;
        public TextBox textBoxcss = new TextBox(), textBoxJs = new TextBox();
        public Label labelBoxcss = new Label(), labelBoxJs = new Label();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(text + "\\index.html");
            var a = File.Create(path + "\\" + textBoxNazwa.Text + ".txt");
            a.Dispose();
            string[] array_do_css = {
                "<!DOCTYPE html>",
                "<html lang=\"en\">",
                "<head>",
                "    <meta charset=\"UTF - 8\">",
                "    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">",
                "    <title>Document</title>" };
            string[] array_po_css = {
                    "</head>",
                    "<body>",
                    "    <Header>",
                    "        <h1>",
                    "            Sans",
                    "        </h1>",
                    "    </Header>" };
            string[] array_do_js = {
                    "</body>",
                    "</html>"};
            string filename = path + "\\" + textBoxNazwa.Text + ".txt";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach(var ralsei in array_do_css)
                {
                    sw.WriteLine(ralsei);
                }
                if(checkBoxcss.Checked == true)
                {
                    var b = File.Create(path + "\\" + textBoxcss.Text + ".css");
                    b.Dispose();
                    FileInfo sans = new FileInfo(path + "\\" + textBoxcss.Text + ".css");
                    sans.MoveTo(Path.ChangeExtension(path + "\\" + textBoxcss.Text + ".css", ".css"));
                    sw.WriteLine("    <link rel=\"stylesheet\" href=\""+textBoxcss.Text+".css\">");
                }
                foreach(var sans in array_po_css)
                {
                    sw.WriteLine(sans);
                }
                if (checkBoxJs.Checked == true)
                {
                    var Js = File.Create(path + "\\" + textBoxJs.Text + ".js");
                    Js.Dispose();
                    FileInfo sans = new FileInfo(path + "\\" + textBoxJs.Text + ".js");
                    sans.MoveTo(Path.ChangeExtension(path + "\\" + textBoxJs.Text + ".js", ".js"));
                    sw.WriteLine("    <script src=\""+textBoxJs.Text+".js\"></script>");
                }
                foreach(var orroro in array_do_js)
                {
                    sw.WriteLine(orroro);
                }
                if(php.Checked == true)
                {
                    sw.WriteLine("<?PHP");
                    sw.WriteLine(" ");
                    sw.WriteLine("?>");
                }
            };
            FileInfo f = new FileInfo(filename);
            if(php.Checked == true)
            {
                f.MoveTo(Path.ChangeExtension(filename, ".php"));
            }
            else
            {
                f.MoveTo(Path.ChangeExtension(filename, ".html"));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxcss.Checked == true)
            {
                textBoxcss.Text = "Css";
                textBoxcss.Name = "textBox";
                textBoxcss.Location = new Point(checkBoxcss.Location.X + 60, checkBoxcss.Location.Y + 20);
                textBoxcss.TabIndex = 5;
                Controls.Add(textBoxcss);
                labelBoxcss.Text = "Nazwa pliku css";
                labelBoxcss.Font = new Font("Microsoft Sans Serif", 15);
                labelBoxcss.Name = "labelBox";
                labelBoxcss.Location = new Point (checkBoxcss.Location.X+75,checkBoxcss.Location.Y-50);
                Controls.Add(labelBoxcss);
            }
            else
            {
                Controls.Remove(labelBoxcss);
                Controls.Remove(textBoxcss);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxofDirection1.Text = folder.SelectedPath;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            path = textBoxofDirection1.Text + "\\" + textBoxofNewFolderName.Text;
            System.IO.Directory.CreateDirectory(path);
            System.IO.Directory.CreateDirectory(path + "\\" + "Assets");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxJs.Checked == true)
            {
                textBoxJs.Text = "JavaScript";
                textBoxJs.Name = "textBoxJs";
                textBoxJs.Location = new Point(checkBoxJs.Location.X + 60, checkBoxJs.Location.Y + 20);
                textBoxJs.TabIndex = 5;
                Controls.Add(textBoxJs);
                labelBoxJs.Text = "Nazwa pliku Js";
                labelBoxJs.Font = new Font("Microsoft Sans Serif", 15);
                labelBoxJs.Name = "labelBoxJs";
                labelBoxJs.Location = new Point(checkBoxJs.Location.X + 75, checkBoxJs.Location.Y - 50);
                Controls.Add(labelBoxJs);
            }
            else
            {
                Controls.Remove(labelBoxJs);
                Controls.Remove(textBoxJs);
            }
        }
    }
}