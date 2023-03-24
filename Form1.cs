using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarPersonaje_Click(object sender, EventArgs e)
        {
            Personaje p1 = new Personaje();
            p1.Nombre = txbNombre.Text;
            p1.FechaNacimiento = dtpFechaNacimiento.Value;
            p1.Origen = cbbOrigen.SelectedItem.ToString();
            string raza;
            if (rdbElfo.Checked)
                raza = "Elfo";
            else if (rdbHumano.Checked)
                raza = "Humano";
            else
                raza = "Vampiro";

            p1.Raza = raza;
            p1.Magia = ckbMagia.Checked;
            p1.Territorios = numTerritorios.Value.ToString();

            
            string info = "El nombre del personaje es " + p1.Nombre + ", nació el " + p1.FechaNacimiento + ", su origen es " + p1.Origen + ". Es de raza " + p1.Raza + " y posee " + p1.Territorios + " territorios" + " Posee magia: " + p1.Magia;
            MessageBox.Show(info);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbOrigen.Items.Add("Terrenal");
            cbbOrigen.Items.Add("Dimensional");
            cbbOrigen.Items.Add("Místico");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar la app");
        }
    }
}
