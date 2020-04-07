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
    public partial class Buscador : Form
    {
            Conexion miConexion = new Conexion();
            DataTable pokemonPorNombre = new DataTable();
            VentanaPrincipal VP = new VentanaPrincipal();
            private VentanaPrincipal mainForm = null;

        public Buscador(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //necesario poner la primera en mayuscula
            string buscar = busca.Text;
            pokemonPorNombre = miConexion.getBuscador(buscar);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                busca.Text = "Pokemon no encontrado";
            }
            else
            {
                VentanaPrincipal.idActual = int.Parse(pokemonPorNombre.Rows[0]["id"].ToString());
                this.mainForm.pokeInf(VentanaPrincipal.idActual);
                this.Hide();
            }
        }  
    }
}
