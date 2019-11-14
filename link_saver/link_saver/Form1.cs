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

namespace link_saver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void write_to_file(string line)
        {
            string file = @"D:\franz\OneDrive\Escritorio\links.txt";
            FileStream fileStream = File.Open(file, FileMode.Append, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);
            fileWriter.WriteLine(line);
            fileWriter.Flush();
            fileWriter.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string url = url_textbox.Text;
            string organization = organization_textbox.Text;
            string tags = tags_textbox.Text;

            string line = url + "|" + organization + "|" + tags;

            write_to_file(line);
        }

        private void url_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
