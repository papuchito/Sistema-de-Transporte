using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;
using capaentidad;



namespace WindowsFormsApp1
{
    public partial class frmcategoria : Form
    {
        private string idtbfinal;

        private bool Editarse = false;

        E_tbfinal objEntidad = new E_tbfinal();
        N_tbfinal objNegocio = new N_tbfinal();
        public static object DataSource { get; private set; }

        public frmcategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_tbfinal objNegocio = new N_tbfinal();
            tablaCategoria.DataSource = objNegocio.Listartbfinal(buscar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCaja()
        {
            Editarse = false;
            textNombre.Text = "";
            textApellido.Text = "";
            textcarrera.Text = "";
            textentrada.Text = "";
            textsalida.Text = "";
            textNombre.Focus();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            {
                if (tablaCategoria.SelectedRows.Count > 0)
                {
                    Editarse = true;
                    idtbfinal = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                    textNombre.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                    textApellido.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                    textcarrera.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();
                    textentrada.Text = tablaCategoria.CurrentRow.Cells[6].Value.ToString();
                    textsalida.Text = tablaCategoria.CurrentRow.Cells[7].Value.ToString();
                   
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione la fila que desea editar");
                }
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.Nombre = textNombre.Text.ToUpper();
                    objEntidad.Apellido = textApellido.Text.ToUpper();
                    objEntidad.Carrera = textcarrera.Text.ToUpper();
                    objEntidad.Entrada = textentrada.Text.ToUpper();
                    objEntidad.Salida = textsalida.Text.ToUpper();
                    

                    objNegocio.Insertartbfinal(objEntidad);

                    MessageBox.Show("Registro guardado correctamente");
                    mostrarBuscarTabla("");
                    limpiarCaja();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if (Editarse == true)
            {
                try
                {
                    objEntidad.Nombre = textNombre.Text.ToUpper();
                    objEntidad.Apellido = textApellido.Text.ToUpper();
                    objEntidad.Carrera = textcarrera.Text.ToUpper();
                    objEntidad.Entrada = textentrada.Text.ToUpper();
                    objEntidad.Salida = textsalida.Text.ToUpper();
                    
                    

                    objNegocio.Insertartbfinal(objEntidad);

                    MessageBox.Show("Registro editado correctamente");
                    mostrarBuscarTabla("");
                    limpiarCaja();
                    Editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            if (tablaCategoria.SelectedRows.Count > 0)
            {
                objEntidad.Idtbfinal = Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                objNegocio.Eliminartbfinal(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione la lista que desea eliminar");
            }
        }

        private void tablaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
    }