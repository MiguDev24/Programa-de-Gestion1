using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using BusinessLogicLayer;
using DataAccsessLogic;
using Entity;

namespace UserInterface
{
    public partial class frmPrincipal : Form
    { private Bll_Inventario bll_Inventario= new Bll_Inventario();
        public frmPrincipal()
        {
            InitializeComponent();
            this.Load += frmPrincipal_Load;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DataTable datos = bll_Inventario.Mostrar_Inventario();
            if (datos != null)
            {
                dataGridView1.DataSource = datos;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (CamposEstanCompletos())
            {
                int idArticulo = Convert.ToInt32(txtid.Text);

                // Verificar si ya existe un artículo con la misma clave primaria
                if (bll_Inventario.ArticuloRepetido(idArticulo))
                {
                    MessageBox.Show("YA EXISTE UN ARTÍCULO CON LA MISMA CLAVE PRIMARIA. NO SE PUEDE AGREGAR EL MISMO ARTÍCULO.");
                    return;
                }

                Inventario inventario = new Inventario
                {
                    id_articulo = Convert.ToInt32(txtid.Text),
                    Nombre_Articulo = txtnombre.Text,
                    Descripccion = txtdescripcion.Text,
                    Marca = txtmarca.Text,
                    Precio = txtprecio.Text,
                    Stock = Convert.ToInt32(txtstock.Text)
                };
                if (bll_Inventario.Agregar_Articulo(inventario))
                {
                    MessageBox.Show("ARTICULO CARGADO EXITOSAMENTE");
                    RefrescarTabla();
                    LimpiarTextBoxs();
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE CARGAR EL ARTICULO");
                }
            }
            else
            {
                MessageBox.Show("TODOS LOS CAMPOS SON OBLIGATORIOS. POR FAVOR, LLENE TODOS LOS CAMPOS ANTES DE DAR DE ALTA UN ARTÍCULO.");
            }
        }
        private void RefrescarTabla()
        {
            dataGridView1.DataSource = bll_Inventario.Mostrar_Inventario();
        }
        private void LimpiarTextBoxs()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtmarca.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
        }
        private bool CamposEstanCompletos()
        {
            return !string.IsNullOrEmpty(txtid.Text)
                && !string.IsNullOrEmpty(txtnombre.Text)
                && !string.IsNullOrEmpty(txtdescripcion.Text)
                && !string.IsNullOrEmpty(txtmarca.Text)
                && !string.IsNullOrEmpty(txtprecio.Text)
                && !string.IsNullOrEmpty(txtstock.Text);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_articulo"].Value);
                if (bll_Inventario.Eliminar_Articulo(id))
                {
                    MessageBox.Show("ARTICULO ELIMINADO");
                    RefrescarTabla();
                }
                else 
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL ARTICULO");
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ARTICULO ANTES DE DAR LA BAJA");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text)) // Aseguramos que se haya seleccionado una fila
            {
                Inventario inventario = new Inventario
                {
                    id_articulo = Convert.ToInt32(txtid.Text),
                    Nombre_Articulo = txtnombre.Text,
                    Descripccion = txtdescripcion.Text,
                    Marca = txtmarca.Text,
                    Precio = txtprecio.Text,
                    Stock = Convert.ToInt32(txtstock.Text)
                };

                if (bll_Inventario.Modificar_Articulo(inventario))
                {
                    MessageBox.Show("ARTICULO MODIFICADO EXITOSAMENTE");
                    RefrescarTabla();
                    LimpiarTextBoxs();
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE MODIFICAR EL ARTICULO");
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ARTICULO ANTES DE MODIFICAR");
            }
        }
    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtid.Text = row.Cells["id_articulo"].Value.ToString();
                txtnombre.Text = row.Cells["Nombre_Articulo"].Value.ToString();
                txtdescripcion.Text = row.Cells["Descripccion"].Value.ToString();
                txtmarca.Text = row.Cells["Marca"].Value.ToString();
                txtprecio.Text = row.Cells["Precio"].Value.ToString();
                txtstock.Text = row.Cells["Stock"].Value.ToString();
            }
        }
    }
}



