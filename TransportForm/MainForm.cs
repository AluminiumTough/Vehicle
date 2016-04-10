using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Newtonsoft.Json;
using System.IO;

namespace TransportForm
{
    /// <summary>
    /// Представляет информацию о транспорте в форме
    /// </summary>
    public partial class MainForm : Form
    {
        public List<IVehicle> Vehicle;
        public MainForm()
        {
            InitializeComponent();
            Vehicle = new List<IVehicle>();
        }
        /// <summary>
        /// Добавление сведений при нажатии на кнопку add
        /// </summary>

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTransport_Click(object sender, EventArgs e)
        {
            AddTransportForm form = new AddTransportForm();
            form.Owner = this;
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var vehicle = form.Vehicle;
                DataGridViewRow row = (DataGridViewRow)TransportGrid.Rows[0].Clone();
                row.Cells[1].Value = vehicle.ModelName;
                row.Cells[2].Value = vehicle.Distance;
                row.Cells[3].Value = vehicle.DateOfManufacture;
                if (vehicle is Car)
                    row.Cells[0].Value = "Car";
                if (vehicle is Helicopter)
                    row.Cells[0].Value = "Helicopter";
                if (vehicle is Hybrid)
                    row.Cells[0].Value = "Hybrid";
                TransportGrid.Rows.Add(row);
            }
        }

        /// <summary>
        /// Удаление сведений при нажатии на кнопку remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveTransport_Click(object sender, EventArgs e)
        {
            if (TransportGrid.SelectedRows.Count == 1)
            {
       
                    DataGridViewRow row = TransportGrid.SelectedRows[0];

                    if (row.Index == TransportGrid.Rows.Count - 1)
                        return;

                    Vehicle.RemoveAt(row.Index);

                    TransportGrid.Rows.RemoveAt(row.Index);
                
            }
        }
        /// <summary>
        /// Заполнение таблицы
        /// </summary>
        private void FillingTable()
        {
            TransportGrid.Rows.Clear(); // Очищаем таблицу
            foreach (IVehicle transport in Vehicle) // Заполнение таблицы
            {
                int number = TransportGrid.RowCount;
                TransportGrid.Rows.Add(transport.GetType().ToString().Split('.').Last(), transport.ModelName,  transport.Distance, transport.DateOfManufacture);
            }
        }
       


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
       
       

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Дессериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle.Clear();
            

                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Vehicle (*.Vehicle.dtb)|*.Vehicle|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = openFileDialog.FileName;
                    var deserializer = new JsonSerializer()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        TypeNameHandling = TypeNameHandling.Auto,
                        Formatting = Formatting.Indented
                    };

                    using (StreamReader sr = new StreamReader(filename))
                    {
                        using (JsonReader reader = new JsonTextReader(sr))
                        {
                            Vehicle = deserializer.Deserialize<List<IVehicle>>(reader);
                        }
                    }
                }
                FillingTable(); // Заполняем таблицу
            }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Vehicle (*.Vehicle.dtb)|*.Vehicle|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = saveFileDialog.FileName;
                    var serializer = new JsonSerializer()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        TypeNameHandling = TypeNameHandling.Auto,
                        Formatting = Formatting.Indented
                    };

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, Vehicle);
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }



    /// <summary>
    /// Сериализация
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
 
    }

