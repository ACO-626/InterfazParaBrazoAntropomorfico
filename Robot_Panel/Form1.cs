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
        Brush colorBrush2;
        Pen pen;
        Pen pen2;
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
            colorBrush2 = new SolidBrush(Color.Orange);
            pen = new Pen(colorBrush, 5);
            pen2 = new Pen(colorBrush2,8);

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

            ImprimirEntradas();



        }
        #endregion

        #region MetodoValidar-Imprimir

        private bool ImprimirEntradas()
        {
            int x1;
            int x2;
            int y1;
            int y2;

            //Si es un entero
            if (Int32.TryParse(textBoxX1.Text, out x1) && Int32.TryParse(textBoxX2.Text, out x2) && Int32.TryParse(textBoxY1.Text, out y1) && Int32.TryParse(textBoxY2.Text, out y2))
            {
                //Si está en el intervalo de medidas de la hoja
                if (x1 >= 0 && x1 <= 220 && x2 >= 0 && x2 <= 220 && y1 >= 0 && y1 <= 280 && y2 >= 0 && y2 <= 280)
                {
                    //Si está en el intervalo de medida mayor a 5 
                    //ifdistaciaPuntos>=150 para distancias menores a 15
                    double d = distanciaPuntos(x1, x2, y1, y2);
                    if (d >= 50 && d <= 150)
                    {
                        //Paso de mm a pixeles
                        //Definimos los puntos
                        puntoInico = new Point(x1 * 3 / 2, y1 * 3 / 2);
                        puntoFin = new Point(x2 * 3 / 2, y2 * 3 / 2);

                        if (recta)
                        {
                            //Dibujar recta
                            grafico.DrawLine(pen, puntoInico, puntoFin);
                        }
                        else
                        {
                            //Dibujar arco
                            //1 Encontrar el centro del arco dado dos puntos
                            Point centroArco = new Point();
                            centroArco = findCenter(puntoInico, puntoFin);
                            grafico.DrawRectangle(pen2,centroArco.X-1,centroArco.Y-1, 3, 3);
                            //2) Encontrar el ángulo de rotación del sistema 2
                            double anguloRecta = AngleFinder(puntoInico,puntoFin);
                            double anguloRectaDegree = RadianToDegree(anguloRecta);
                            lbConsoleMensaje.Text = "θ: " + anguloRectaDegree.ToString() + " °" + "d(p1,p2): "+ d + " mm";
                            lbConsoleMensaje.Visible = true;
                            //3) Build Matriz de transformación




                        }
                        return true;



                    }
                    else
                    {
                        MessageBox.Show("Se generan trazos fuera del intervalo [50mm,150mm]", "Error de dimensiones de trazo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                else
                {
                    MessageBox.Show("Coordenadas fuera de la hoja", "Error de coordenadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Formato inválido de coordenadas", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion

        #region distanciaPuntos
        private double distanciaPuntos(int x1, int x2, int y1, int y2)
        {
            //Aplicamos la fórmula de distancia entre dos puntos
            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distancia;
        }
        #endregion

        #region ComportamientoCombo
        private void comboBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBTipo.SelectedIndex == 1)
            {
                //Caso en el que es línea recta
                recta = false;
            }
            else
            {
                recta = true;
            }
        }
        #endregion


        #region FunciónCentroArco
        //Función que encuentra el punto M entre dos puntos
        private Point findCenter( Point p1, Point p2)
        {
            Point m = new Point((p1.X+p2.X)/2,(p1.Y+p2.Y)/2);
            return m;

        }
        #endregion

        #region FunciónAnguloSistema2
        //Se busca el ángulo entre el eje X del sistema de referencia y la ecucación de la recta dados los dos puntos

        private double AngleFinder(Point p1,Point p2)
        {
            double angle = 0;//En radianes
            int x1 = p1.X;
            int x2 = p2.X;
            int y1 = p1.Y;
            int y2 = p2.Y;


            if(y2-y1==0)//Cuando está acostada
            {
                if(x1>x2)
                {
                    angle = Math.PI;
                    return angle;
                }
                else
                {
                    angle = 0;
                }
            }
            else
            {
                if(x2-x1==0)
                {
                    if(y1>y2)
                    {
                        
                        angle = 3*(Math.PI)/2; //270°
                        //MessageBox.Show(angle.ToString());
                        return angle;
                    }
                    else
                    {
                        angle = Math.PI/2; //90°
                        return angle;
                    }
                }
                else
                {                    
                    angle = Math.Atan((y2 - y1) / (x2 - x1)); //En radianes
                    

                }
            }


            return angle;

        }


        #endregion

        #region FunciónRadianToDegree

        private double RadianToDegree(double radianAngle)
        {
            double degreeAngle =0;

            degreeAngle = radianAngle * (180 / Math.PI);


            return degreeAngle;
        }

        #endregion

    }
}
