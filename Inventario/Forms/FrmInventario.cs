using AppCore.Services;
using Domain.Entities.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Forms
{
    public partial class FrmInventario : Form
    {
        public ProductService productService;
        public FrmInventario()
        {
            this.productService = productService;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = (int)txtId.Text,
                Nombre = txtNombre
            };

            productService.Create(p);
        }
    }
}
