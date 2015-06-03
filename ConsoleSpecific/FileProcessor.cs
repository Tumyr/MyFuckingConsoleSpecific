using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleSpecific
{
    class FileProcessor
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public void SelectFile()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Выбран файл");
            }
            //Console.WriteLine(dr.ToString());


        }

    }
}
