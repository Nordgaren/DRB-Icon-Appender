using Newtonsoft.Json;
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

namespace DRB_Icon_Appender
{
    public partial class BatchSave : Form
    {
        private List<SpriteShape> Shapes;

        public BatchSave(List<SpriteShape> shapes)
        {
            InitializeComponent();
            Shapes = shapes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var browserDialog = new SaveFileDialog()
            {
                AddExtension = true,
                FileName = $"DRBBatchSave {nudStart.Value}-{nudEnd.Value}",
                DefaultExt = ".json",
                Title = "Batch save location/filename",
                Filter = "Json(*.json) | *.json"
            };

            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                var batchSave = new List<SpriteShape>();
                for (int i = 0; i < Shapes.Count; i++)
                {
                    if (Shapes[i].ID >= nudStart.Value && Shapes[i].ID <= nudEnd.Value)
                    {
                        batchSave.Add(Shapes[i]);
                    }
                }
                var json = JsonConvert.SerializeObject(batchSave);

                File.WriteAllText(browserDialog.FileName, json);
            }
        }
    }
}
