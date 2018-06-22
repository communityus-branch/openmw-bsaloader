using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSALoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxM.Text = Properties.Settings.Default.pathM;
            textBoxO.Text = Properties.Settings.Default.pathO;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButtonM_Click(object sender, EventArgs e)
        {
            if (browserM.ShowDialog() == DialogResult.OK)
            {
                textBoxM.Text = browserM.SelectedPath;
            }
            Properties.Settings.Default.pathM = textBoxM.Text;
            Properties.Settings.Default.Save();
        }

        private void textBoxO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrowseO_Click(object sender, EventArgs e)
        {
            if (browserO.ShowDialog() == DialogResult.OK)
            {
                textBoxO.Text = browserO.SelectedPath;
            }
            Properties.Settings.Default.pathO = textBoxO.Text;
            Properties.Settings.Default.Save();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string pathmor = textBoxM.Text + @"\Data Files";
            string pathow = textBoxO.Text + @"\openmw.cfg";
            string file;
            IList<string> lines = new List<string>();
            string[] files = System.IO.Directory.GetFiles(pathmor, "*.bsa");
            IList<string> filesnames = new List<string>();
            string[] allLines;
            IList<string> allLinesL = new List<string>();
            foreach (string filedir in files)
            {
                file = "fallback-archive=" + Path.GetFileName(filedir);
                filesnames.Add(file);
                Console.WriteLine(file);
                foreach (string line in File.ReadLines(pathow))
                {
                    if (line.Contains(".bsa"))
                    {
                        lines.Add(line);
                        Console.WriteLine(line);
                    }
                    else
                    {
                    }
                }
            }
            lines.ToArray();
            filesnames.ToArray();

            Console.WriteLine(filesnames.Count);
            for (int i = 0; i < filesnames.Count; i++)
            {
                if (lines.Contains(filesnames[i]))
                {
                }
                else
                {
                    File.AppendAllText(pathow, (Environment.NewLine + filesnames[i]));
                    counter++;
                }
            }
            allLines = File.ReadAllLines(pathow);
            allLinesL = allLines.ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (filesnames.Contains(lines[i]))
                {
                    continue;
                }
                else
                {
                    allLinesL.Remove(lines[i]);
                }
            }
            File.Delete(pathow);
            File.AppendAllLines(pathow, allLinesL);
            allLinesL = File.ReadAllLines(pathow).Where(s => s.Trim() != string.Empty).ToArray();
            File.Delete(pathow);
            File.AppendAllLines(pathow, allLinesL);
        }
    }
}
