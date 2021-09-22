using Newtonsoft.Json;
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

namespace DRB_Icon_Appender
{
    public partial class BatchLoad : Form
    {
        private static List<SpriteShape> Shapes;

        private int Range { get; set; }

        public BatchLoad(List<SpriteShape> shapes)
        {
            InitializeComponent();
            nudStart.Maximum = int.MaxValue;
            nudEnd.Maximum = int.MaxValue;
            Shapes = null;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                Shapes = JsonConvert.DeserializeObject<List<SpriteShape>>(File.ReadAllText(txtPath.Text));
                if (cbxNewRange.Checked)
                {
                    int newID = (int)nudStart.Value;

                    foreach (var item in Shapes)
                    {
                        item.SetID(newID);
                        newID++;
                    }
                }
                Close();
            }
        }

        public static List<SpriteShape> GetShapes()
        {
            return Shapes;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var browseDialog = new OpenFileDialog()
            {
                AddExtension = true,
                FileName = "",
                DefaultExt = ".json",
                Title = "Batch load file",
                Filter = "Json(*.json) | *.json"
            };

            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = browseDialog.FileName;
                string[] numbers = Regex.Split(Path.GetFileName(txtPath.Text), @"\D+").Where(s => !string.IsNullOrEmpty(s)).ToArray();
                if (numbers.Count() != 2)
                {
                    ShowMessage("Invalid Json name format. There needs to be a range. Ex: 1500 - 1631");
                    return;
                }

                nudStart.Value = decimal.Parse(numbers[0]);
                nudEnd.Value = decimal.Parse(numbers[1]);
                Range = (int)(nudEnd.Value - nudStart.Value);
            }
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxNewRange_CheckedChanged(object sender, EventArgs e)
        {
            nudStart.Enabled = cbxNewRange.Checked;
        }

        private void nudStart_ValueChanged(object sender, EventArgs e)
        {
            nudEnd.Value = nudStart.Value + Range;
        }
    }
}
