using Pokedex_C_Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class Data : Form
    {
        Conexion miConexion = new Conexion();
        private VentanaPrincipal mainForm = null;
        public Data(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();
            dataGridView1.DataSource = miConexion.getTodos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            VentanaPrincipal.idActual = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.mainForm.pokeInf(VentanaPrincipal.idActual);
            //this.Hide(); //con esto puedes hacer que despues
            //de seleccionar al pokemon vuelvas a la ventana
            //principal
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
