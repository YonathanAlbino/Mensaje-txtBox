using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = "Los o el sigueinte campo se encuentran vacios: ";
            bool entroAlIf = false;

            List<TextBox> list = new List<TextBox>();
            list.Add(txtNombre);
            list.Add(txtApellido);
            list.Add(txtEdad);
            list.Add(txtDireccion);

            foreach (var item in list)
            {
                if (item.Text == "")
                {
                    mensaje += CampoVacio(item);
                    entroAlIf = true;
                }
            }
            
            if(entroAlIf)
                MessageBox.Show(mensaje);
        }
    
    
        private string CampoVacio(TextBox campo)
        {
            string txtBox = "";

            if (campo.Name.ToUpper().Contains("NOMBRE"))
            {
                txtBox = "Nombre, ";
            }
            else if (campo.Name.ToUpper().Contains("APELLIDO"))
            {
                txtBox = "Apellido, ";
            }
            else if ((campo.Name.ToUpper().Contains("EDAD")))
            {
                txtBox = "Edad, ";
            }
            else if ((campo.Name.ToUpper().Contains("DIRECCION")))
            {
                txtBox = "Direccion";
            }

            return txtBox;
        }
    
    }

}
