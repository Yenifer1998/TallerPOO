using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadPOO;
using ProyectoPOO;
using NegocioPOO;

namespace ProyectoPOO
{
    public partial class Form1 : Form
    {
        double PrecioRevista = 10000;
        double PrecioLibro = 20000;
        double PrecioCapitulo = 30000;
      

        Articulo myArticulo = new Articulo();
        ArticuloCongreso myArticuloCongreso = new ArticuloCongreso();
        ArticuloRevista myArticuloRevista = new ArticuloRevista();
        Empleado myEmpleado = new Empleado();
        Libro myLibro = new Libro();
        CapituloLibro myCapituloLibro = new CapituloLibro();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButRegistrarUsuario_Click(object sender, EventArgs e)
        {
            myEmpleado.Nombre = txtNombreEmpleado.Text;
            myEmpleado.Direccion = txtDireccion.Text;
            myEmpleado.Identificacion = txtIdentificacion.Text;
            myArticulo.Autor = txtNombreArticulo.Text;
            //myArticulo.FechaPublicacion = dateTimePicker1;
            myArticulo.Titulo = txtTitulo.Text;


            MessageBox.Show("se han guardado los datos exitosamente");
        }

        private void ButRegistrar_Click(object sender, EventArgs e)
        {

             double PrecioFinalRevista = (PrecioRevista*0.14);
                double PrecioFinalLibro = (PrecioLibro*0.10);
                double PrecioFinalCapitulo = (PrecioCapitulo*0.12);


             if (cboArticulo.Text == "CLibro")

                 {
                     MessageBox.Show("se realiza un pago de comision del 10%: " + PrecioFinalLibro);

                 }
                 else if (cboArticulo.Text == "ACapitulo")

                 {
                     MessageBox.Show("se realiza un pago de comision del 12%: " + PrecioFinalCapitulo);

                 }
               else  if (cboArticulo.Text == "ARevista")

                 {
                     MessageBox.Show("se realiza un pago de comision del 14%: " + PrecioFinalRevista );

                 }
                 else 
                 { MessageBox.Show("el campo esta vacio");
                     return;
                 } 
                 
        }

        private void TxtNombreEmpleado_Validated(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreEmpleado, "Introducir nombre");
                txtNombreEmpleado.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtIdentificacion, "Introducir identificacion");
                txtIdentificacion.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TxtDireccion_Validated(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDireccion, "Introducir direccion");
                txtDireccion.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TxtNombreArticulo_Validated(object sender, EventArgs e)
        {
            if (txtNombreArticulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreArticulo, "Introducir nombre del articulo");
                txtNombreArticulo.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TxtTitulo_Validated(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTitulo, "Introducir titulo");
                txtTitulo.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }

        }
    }
}
