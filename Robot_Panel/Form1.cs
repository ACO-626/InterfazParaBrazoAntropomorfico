using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_Panel
{
    public partial class FormMain : Form
    {
        #region VariablesYobjGlobales

        Graphics grafico;
        Brush colorBrush;
        Pen pen;
        Point puntoInico = new Point(0, 0);
        Point puntoFin = new Point(10, 100);


        bool recta = true;

        #endregion

        #region Inicialización de FORM
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBTipo.Items.Add("Recta");
            comboBTipo.Items.Add("Medio arco");
            
            comboBTipo.SelectedIndex = 0;
            grafico = panelCanvas.CreateGraphics();
            colorBrush = new SolidBrush(Color.Black);
            pen = new Pen(colorBrush, 8);
            
        }
        #endregion


        #region Configuración de canva
        
        #endregion

        #region CleanslateSr
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanSlate(grafico);
        }

        private void cleanSlate(Graphics graf)
        {
            graf.Clear(Color.White);
        }
        #endregion

        #region Visualizador
        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            if(validarEntradas())
            {

                grafico.DrawLine(pen, puntoInico, puntoFin);
                
            }
            else
            {
                MessageBox.Show("Coordenadas inválidas", "Error de entrada",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }
        #endregion

        #region MetodoValidarPoints

        private bool validarEntradas()
        {
            int x1;
            int x2;
            int y1;
            int y2;

            if (Int32.TryParse(textBoxX1.Text,out x1) && Int32.TryParse(textBoxX2.Text, out x2) && Int32.TryParse(textBoxY1.Text, out y1)&& Int32.TryParse(textBoxY2.Text, out y2))
            {
                if( x1>=0 && x1<=220 && x2 >= 0 && x2 <= 220 && y1 >= 0 && y1 <= 280 && y2 >= 0 && y2 <= 280)
                {

                    //Paso de mm a pixeles
                    

                    //Definimos los puntos
                    puntoInico = new Point(x1*3/2, y1*3/2);
                    puntoFin = new Point(x2*3/2, y2*3/2);
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            else
            {
                return false;
            }
            
        }
        #endregion

        
    }
}
