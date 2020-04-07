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

namespace Pokedex_C_Sharp
{
    public partial class VentanaPrincipal : Form
    {

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1;//el pokemon que estamos viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
            pokeInf(1);   
        }
        public void pokeInf(int id)
        {
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            numero.Text = misPokemons.Rows[0]["id"].ToString() + "º";
            tipo.Text = "Tipo: " + misPokemons.Rows[0]["tipo1"].ToString() + (!"".Equals(misPokemons.Rows[0]["tipo2"].ToString())
            ? (" / " + misPokemons.Rows[0]["tipo2"].ToString()) : "");
            especie.Text = "Especie: " + misPokemons.Rows[0]["especie"].ToString();
            habitat.Text = "Habitat: " + misPokemons.Rows[0]["habitat"].ToString();
            proporciones.Text = "Tamaño: " + misPokemons.Rows[0]["peso"].ToString() + " kg " + " / " + misPokemons.Rows[0]["altura"].ToString() + " m";
            habilidad.Text = "Habilidad: " + misPokemons.Rows[0]["habilidad"].ToString();
            movimiento.Text = misPokemons.Rows[0]["movimiento1"].ToString() + (!"".Equals(misPokemons.Rows[0]["movimiento2"].ToString())
            ? (" / " + misPokemons.Rows[0]["movimiento2"].ToString()) : "");
            movimiento1.Text = misPokemons.Rows[0]["movimiento3"].ToString() + (!"".Equals(misPokemons.Rows[0]["movimiento4"].ToString())
            ? (" / " + misPokemons.Rows[0]["movimiento4"].ToString()) : "");
            pictureBox1.Image = ConvierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
        }
            private Image ConvierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));

        }
        private void izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0)
            {
                idActual = 1;
            }
            pokeInf(idActual);
        }

        private void der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            pokeInf(idActual);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void izq2_Click(object sender, EventArgs e)
        {
            idActual -= 7;
            if (idActual <= 0)
            {
                idActual = 1;
            }
            pokeInf(idActual);
        }
        private void der2_Click(object sender, EventArgs e)
        {
            idActual += 7;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            pokeInf(idActual);
        }

        
    }
}
