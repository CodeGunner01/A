using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ARCH_PRODUCTO
{
    public partial class Form1 : Form
    {
        ArchProduc ap1, ap2;

        int codigo, nr, nr1 = 0;
        int cod, cod1 = 0;
        string desc = "";
        char tipo = ' ';
        byte conti = 0;
        double cant, precio =0;
        bool est = false;
        string r1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ap1 = new ArchProduc();
            ap2 = new ArchProduc();
        }


        // Limpiar
        public void limpiar()
        {
            dataGridView1.Rows.Clear();
            textBox1.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //Crear
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            ap1.Abrir_Grabar(saveFileDialog1.FileName);
            do
            {
                codigo = Convert.ToInt32(Interaction.InputBox("Codigo Base multiplo de 1000"));
            } while (codigo % 1000 != 0);
            nr = 1;
            dataGridView1.Rows[0].Cells[0].Value = codigo + nr;
        }
        // Grabar
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ap1.Grabar(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
                            Convert.ToString(dataGridView1.Rows[0].Cells[1].Value),
                            Convert.ToChar(dataGridView1.Rows[0].Cells[2].Value),
                            Convert.ToByte(dataGridView1.Rows[0].Cells[3].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value),
                            Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value),true);
                limpiar();
                nr++;
                dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(codigo + nr);
                dataGridView1.Rows[0].Cells[0].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        // Terminar
        private void button2_Click(object sender, EventArgs e)
        {
            if (nr > 0)
                ap1.Cerrar_Grabar();
            else
                Interaction.MsgBox("Grabar al menos 1 registro");
        }
        // Accesar - Menu
        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ap1.Abrir_Leer(openFileDialog1.FileName);
            nr = -1;
            while(!ap1.Verif_Fin())
            {
                ap1.Leer(ref cod, ref desc, ref tipo, ref conti, ref cant, ref precio, ref est);
                if (est == true)
                {
                    nr++;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[nr].Cells[0].Value = cod;
                    dataGridView1.Rows[nr].Cells[1].Value = desc;
                    dataGridView1.Rows[nr].Cells[2].Value = tipo;
                    dataGridView1.Rows[nr].Cells[3].Value = conti;
                    dataGridView1.Rows[nr].Cells[4].Value = cant;
                    dataGridView1.Rows[nr].Cells[5].Value = precio;
                }
               
            }
            ap1.Cerrar_Leer();
        }

        // Altas - Menu
        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ap1.Abrir_Leer(openFileDialog1.FileName);
            ap1.Leer(ref cod, ref desc, ref tipo, ref conti, ref cant, ref precio, ref est);
            codigo = cod - 1;
            ap1.Cerrar_Leer();
            ap1.Abrir_Adicionar(openFileDialog1.FileName);
            nr = ap1.Nreg()+1;
            dataGridView1.Rows[0].Cells[0].Value = codigo +nr;
        }
        //Bajas - Menu
        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ap1.Abrir_OpRandom(openFileDialog1.FileName);
            ap1.LeerR(ref cod, ref desc, ref tipo, ref conti, ref cant, ref precio, ref est, 1);
            codigo = cod - 1;
            nr = ap1.Nreg();
        }

        // Operacion Bajas
        private void button4_Click(object sender, EventArgs e)
        {
            cod1 = Convert.ToInt32(Interaction.InputBox("Codigo de Baja: "));
            if ((cod1 >= codigo + 1) && (cod1 <= codigo + nr))
            {
                nr1 = cod1 - codigo;
                ap1.LeerR(ref cod, ref desc, ref tipo, ref conti, ref cant, ref precio, ref est, nr1);
                if (est == true)
                {
                    dataGridView1.Rows[0].Cells[0].Value = cod;
                    dataGridView1.Rows[0].Cells[1].Value = desc;
                    dataGridView1.Rows[0].Cells[2].Value = tipo;
                    dataGridView1.Rows[0].Cells[3].Value = conti;
                    dataGridView1.Rows[0].Cells[4].Value = cant;
                    dataGridView1.Rows[0].Cells[5].Value = precio;
                }
                else
                {
                    Interaction.MsgBox("Codigo Inactivo.....");
                }
            }
            else
            {
                Interaction.MsgBox("Codigo no Existente");
            }
        }
        // Confirmar Bajas
        private void button5_Click(object sender, EventArgs e)
        {
            int r1;
            r1 = Convert.ToInt32(Interaction.InputBox("Confirma Baja 1/2 (SI/NO)"));
            if (r1 == 1)
            {
                ap1.GrabarR(cod, desc, tipo, conti, cant, precio, false, nr1);
                dataGridView1.Rows.Clear();
            }
            else
            {
                Interaction.MsgBox("No se dio de Baja");
            }
            dataGridView1.Rows.Clear();
        }

        // Cerrar bajas 
        private void button6_Click(object sender, EventArgs e)
        {
            ap1.Cerrar_OpRan();
        }

        //Modificaciones - Menu
        private void modificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ap1.Abrir_Bajas(openFileDialog1.FileName);

            ap1.LeerR(ref cod, ref desc, ref tipo, ref conti, ref cant, ref precio, ref est, 1);
            codigo = cod - 1;
            nr = ap1.Nreg();

            cod1 = int.Parse(Interaction.InputBox("N° Codigo a Modificar:"));
            if ((cod1 >= codigo + 1) && (cod1 <= codigo + nr))
            {
                nr1 = cod1 - codigo;
                ap1.LeerR(ref cod, ref desc, ref tipo, ref conti, ref cant, ref precio, ref est, nr1);
                if (est == true)
                {
                    dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(cod);
                    dataGridView1.Rows[0].Cells[1].Value = Convert.ToString(desc);
                    dataGridView1.Rows[0].Cells[2].Value = Convert.ToString(tipo);
                    dataGridView1.Rows[0].Cells[3].Value = Convert.ToString(conti);
                    dataGridView1.Rows[0].Cells[4].Value = Convert.ToString(cant);
                    dataGridView1.Rows[0].Cells[5].Value = Convert.ToString(precio);
                }
                else
                {
                    MessageBox.Show("El codigo esta con baja");
                }
            }
            else
            {
                MessageBox.Show("Codigo no Valido");
            }
        }
        // Operacion Modificacion
        //private void button9_Click(object sender, EventArgs e)
        //{
        //    //altasToolStripMenuItem_Click(sender, e);
        //}



        // Confirmar Modificacion
        private void button8_Click(object sender, EventArgs e)
        {
            r1 = Interaction.InputBox("Esta seguro: 1= Si o 2= No");

            if (r1 == "1")
            {
                ap1.GrabarR(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value),
                    Convert.ToString(dataGridView1.Rows[0].Cells[1].Value),
                    Convert.ToChar(dataGridView1.Rows[0].Cells[2].Value),
                    Convert.ToByte(dataGridView1.Rows[0].Cells[3].Value),
                    Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value),
                    Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value), true, nr1);
            }
            else
            {
                MessageBox.Show("No se modifico");
            }
            ap1.Cerrar_Bajas();
            limpiar();
        }

        

        ///  OPERACIONES
        ///  1.  Seleccionar productos con tipo. Parámetro TipO (A, B, C)
        private void seleccionPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char tipo = ' ';
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            tipo = char.Parse(Interaction.InputBox("Ingresar Tipo: "));
            ap1.Seleccionar_productos_con_tipo(tipo, openFileDialog1.FileName, saveFileDialog1.FileName, ap2);
        }

        

        ///  2.  Obtener el costo total de productos
        private void calcularCostoTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = "El costo total de productos es: " + string.Concat(ap1.Calcular_el_costo_total_de_productos(openFileDialog1.FileName));
        }



        ///  3.  Ordenamiento especial ascendente por Continente
        private void ordContinenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            ap1.OrdContinente(openFileDialog1.FileName, ap2, saveFileDialog1.FileName);
            Interaction.MsgBox("Operacion Completada");
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void seleccionPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ordPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            ap1.OrdPrecio(openFileDialog1.FileName, ap2, saveFileDialog1.FileName);
            Interaction.MsgBox("Operacion Completada");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Seleccionar archivo de entrada
            saveFileDialog1.ShowDialog(); // Seleccionar archivo de salida

            ap1.OrdTipoDescripcion(openFileDialog1.FileName, ap2, saveFileDialog1.FileName); // Llamada al método
            Interaction.MsgBox("Operación Completada"); // Mostrar mensaje de confirmación
        }





    }
}
