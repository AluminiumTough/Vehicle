using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace TransportForm
{
    public partial class AddTransportForm : Form
    {
        public IVehicle Vehicle { 
            get 
        {
            if (Car.Checked)
            {
                var car = new Car();
                car.DateOfManufacture = Convert.ToInt32(date.Text);
                car.ModelName = Convert.ToString(model.Text);
                car.Distance = Convert.ToInt32(dist.Text);
                return car;
            }
            if (Hybrid.Checked)
            {
                var hybrid = new Hybrid();
                hybrid.DateOfManufacture = Convert.ToInt32(date.Text);
                hybrid.ModelName = Convert.ToString(model.Text);
                hybrid.Distance = Convert.ToInt32(dist.Text);
                return hybrid;
            }
                
            if (Helicopter.Checked)
            {
                var helicopter = new Helicopter();
                helicopter.DateOfManufacture = Convert.ToInt32(date.Text);
                helicopter.ModelName = Convert.ToString(model.Text);
                helicopter.Distance = Convert.ToInt32(dist.Text);
                return helicopter;
            }                
                throw new ArgumentException();
        } }

        private MainForm owner {get { return this.Owner as MainForm;} }

        public AddTransportForm()
        {
            InitializeComponent();
            Transport.Controls.Remove(TypeCar);
            Transport.Controls.Remove(TypeHybrid);
            Transport.Controls.Remove(TypeHelicopter);
            Car.Checked = true;
        }

        /// <summary>
        /// Добавление данных при нажатии кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e)
        {
            if(model.Text.Length==0)
            {
                MessageBox.Show("Введите название модели");
                return;
            }
            if(date.Text.Length==0)
            {
                MessageBox.Show("Введите год выпуска транспорта");
                return;
            }
            if(dist.Text.Length==0)
            {
                MessageBox.Show("Введите пробег транспорта");
                return;
            }
            try
            {
            }
            catch (FormatException) 
            {
                MessageBox.Show("Вводите только цифры без лишних символов");
                return;
            }
            DialogResult = DialogResult.OK;
            if (DialogResult == DialogResult.OK)
            {
               owner.Vehicle.Add(Vehicle);
            }
            Close();
        }

        /// <summary>
        /// Отмена при нажатии кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Car_CheckedChanged(object sender, EventArgs e)
        {

            TypeCar.Location = new Point(0, 130);
            if (Car.Checked)
            {
                Transport.Controls.Add(TypeCar);
            }
            else
            {
                Transport.Controls.Remove(TypeCar);
            }
            //Car.Checked = true;
            //TypeCar.Visible = Car.Checked;
            //TypeHybrid.Visible = !Car.Checked;
            //TypeHelicopter.Visible = !Car.Checked;
        }

        private void Hybrid_CheckedChanged(object sender, EventArgs e)
        {
            TypeHybrid.Location = new Point(0, 130);
            if (Hybrid.Checked)
            {
                Transport.Controls.Add(TypeHybrid);
            }
            else
            {
                Transport.Controls.Remove(TypeHybrid);
            }
            //Hybrid.Checked = true;
//            TypeHybrid.Visible = Hybrid.Checked;
            //TypeCar.Visible = !Hybrid.Checked;
            //TypeHelicopter.Visible = !Hybrid.Checked;
        }

        private void Helicopter_CheckedChanged(object sender, EventArgs e)
        {
            TypeHelicopter.Location = new Point(0, 130);
            if (Helicopter.Checked)
            {
                Transport.Controls.Add(TypeHelicopter);
            }
            else
            {
                Transport.Controls.Remove(TypeHelicopter);
            }
            //Helicopter.Checked = true;
//            TypeHelicopter.Visible = Helicopter.Checked;
            //TypeHybrid.Visible = false;
            //TypeCar.Visible = false;
        }
    }
}