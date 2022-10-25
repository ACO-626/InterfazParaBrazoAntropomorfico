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
                /*
                 * @daredliuth: Aquí deberíamos realizar la selección del tipo de trazo.
                 * recta = true/ false;
                */
                //recta = false; //Para probar el semicírculo.
                if (recta)
                {
                    MessageBox.Show("Recta seleccionada.", "Mensaje de selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grafico.DrawLine(pen, puntoInico, puntoFin);
                }
                else {
                    double diametro = Math.Sqrt(Math.Pow(puntoFin.X - puntoInico.X,2) + Math.Pow(puntoFin.Y - puntoInico.Y, 2));
                    int anguloInicial = obtenerAngulo();
                    grafico.DrawArc(pen, ((puntoInico.X + puntoFin.X)/2) - (float)(diametro/2), ((puntoInico.Y + puntoFin.Y) / 2) - (float)(diametro / 2), (float)diametro, (float)(diametro), anguloInicial-180, 135);
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Semicírculo seleccionado.\nDiámetro: "+diametro+"\nAltura: "+(diametro)+"\nÁngulo inicial: "+anguloInicial, "Mensaje de selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //grafico.DrawLine(pen, puntoInico, puntoFin);
                }

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

        #region MetodoObtenerAnuglo
        private int obtenerAngulo(){
            int angulo;
          
            if (puntoInico.X == puntoFin.X)//@Daredliuth: Si no hay cambio en X el arco es vertical.
            {
                
                if (puntoInico.Y < puntoFin.Y)//Determinamos la dirección de giro.
                {
                    angulo = 90;
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Es vertical.\nÁngulo inicial: " + angulo, "Aviso de ángulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    angulo = -90;
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Es vertical.\nÁngulo inicial: " + angulo, "Aviso de ángulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(puntoInico.Y == puntoFin.Y)//@Daredliuth: Si no hay cambio en Y el arco es horizontal.
            {
                if (puntoInico.X < puntoFin.X)//@Daredliuth: Determinamos el sentido de giro.
                {
                    angulo = 0;
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Es horizontal.\nÁngulo inicial: " + angulo, "Aviso de ángulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    angulo = 180;
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Es horizontal.\nÁngulo inicial: " + angulo, "Aviso de ángulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                float co = puntoFin.X - puntoInico.X; //@Daredliuth: Cateto opuesto.
                float ca = puntoFin.Y - puntoInico.Y; //@Daredliuth: Cateto adyacente.
                if ((co < 0 && ca < 0) || (co < 0 && ca > 0))//@Daredliuth: Determinamos el sentido de giro.
                {
                    angulo = (int)(Math.Atan(co / ca) * (180 / Math.PI)) + 180;
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Es diagonal (Invertido).\nÁngulo inicial: " + angulo + "\nC.O.: " + co + " C.A.: " + ca + "\nATAN: " + Math.Atan(co / ca) * (180 / Math.PI), "Aviso de ángulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    angulo = (int)(Math.Atan(co / ca) * (180 / Math.PI));
                    //@Daredliuth: Para debugging.
                    //MessageBox.Show("Es diagonal.\nÁngulo inicial: " + angulo + "\nC.O.: " + co + " C.A.: " + ca + "\nATAN: " + Math.Atan(co / ca) * (180 / Math.PI), "Aviso de ángulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            return angulo;//@Daredliuth: Devolvemos el ángulo.
        }
        #endregion
    }
}
