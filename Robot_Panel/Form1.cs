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

        float recorridoAngular = 180.0f;
        float recorrido;
        bool recta = true;
        bool trazoPosible = true;

        #region TransformMATRIX
        //Declaración de la matriz
        double[,] matrizHomogenea = new double[4, 4];


        /*
        //Matriz de transformación homogénea 
        
        //Matriz                      //Posición

        |COS(θ) -SIN(θ) 0  M.x | |(0,0) (0,1) (0,2) (0,3) | 
        |SEN(θ)  COS(θ) 0  M.y | |(1,0) (1,1) (1,2) (1,3) | 
        | 0        0    0   0  | |(2.0) (2,1) (2,2) (2,3) | 
        | 0        0    0   1  | |(3,0) (3,1) (3,2) (3,3) | 
         
         */

        private void IniciaMatrixT(double tetaRadian, Point transVector)
        {
            matrizHomogenea[0, 0] =  Math.Cos(tetaRadian);
            matrizHomogenea[0, 1] = -Math.Sin(tetaRadian);
            matrizHomogenea[0, 2] = 0;
            matrizHomogenea[0, 3] = transVector.X;
            matrizHomogenea[1, 0] = Math.Sin(tetaRadian);
            matrizHomogenea[1, 1] = Math.Cos(tetaRadian);
            matrizHomogenea[1, 2] = 0;
            matrizHomogenea[1, 3] = transVector.Y;
            for(int i =0; i<4;i++)
            {
                matrizHomogenea[2, i] = 0;
                matrizHomogenea[3, i] = 0;
            }
            matrizHomogenea[3, 3] = 1;

        }

        #endregion
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
            pen = new Pen(colorBrush, 3);
            pen2 = new Pen(colorBrush2,3);

        }
        #endregion


        #region Configuración de canva

        #endregion

        #region CleanslateSr
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanSlate(grafico);
            labelSimpleVistaPrevia.Text = "Vista previa";
            lbConsoleMensaje.Text = "";
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
                        //puntoInico = new Point(x1 * 3 / 2, y1 * 3 / 2);
                        //puntoFin = new Point(x2 * 3 / 2, y2 * 3 / 2);
                        puntoInico = TransformToPixel(x1, y1);
                        puntoFin = TransformToPixel(x2, y2);

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
                            centroArco = findCenter(new Point(x1,y1), new Point(x2,y2));
                            Point centroArcoPixel = new Point();
                            centroArcoPixel = TransformToPixel(centroArco.X, centroArco.Y);
                            //rafico.DrawRectangle(pen2, centroArcoPixel.X-1, centroArcoPixel.Y-1, 3, 3);
                            
                            //2) Encontrar el ángulo de rotación del sistema 2
                            double anguloRecta = AngleFinder(new Point(x1, y1), new Point(x2, y2));
                            double anguloRectaDegree = RadianToDegree(anguloRecta);
                            lbConsoleMensaje.Text = "θ: " + anguloRectaDegree.ToString() + " °" + "d(p1,p2): "+ d + " mm";
                            lbConsoleMensaje.Visible = true;                    
                            //3) Build    Matriz de transformación
                            //Se manda a formar la matriz
                            IniciaMatrixT(anguloRecta,centroArco);
                            // 4) Encontrar la ecuación de circunferencia
                            //Ecuación canónica (x-h)^2 + (y-k)^2 = r^2
                            //Para S2 h=0 y k=0 & y Ɛ [0,r] & x  Ɛ [-r,r], número de puntos 2r
                            //Entonces (x)^2 + (y)^2 = r^2  -> y = sqrt(r^2-x^2) donde xƐ[-r,r]

                            //5) Generar los puntos de prueba
                            int dInt = (int)d;  //dInt es el diametro en entero
                            int rInt = dInt / 2;
                            Point[] puntosS2 = new Point[dInt+1]; //Se hace un arreglo con 2*r puntos los cuales se verificarán
                            //Se guardan los puntos en S2
                            for (int i = 0; i <= dInt; i++)
                            {
                                puntosS2[i] = new Point(-rInt+i,-(int)Math.Sqrt(Math.Pow(rInt, 2) -Math.Pow(-rInt + i, 2)));
                            }
                            //6)Transformar a S1 y 7)Verificar puntos
                            //S1(X,Y) = H S2(X,Y)
                            //Presuponemos que el se puede realizar el trazo
                            trazoPosible = true;
                            Point[] puntosS1 = new Point[dInt+1];//se suma uno por el cero
                            for(int i = 0; i <= dInt; i++)
                            {
                                /*
                                puntosS1[i].X = ((int)matrizHomogenea[0, 0] * puntosS2[i].X) + ((int)matrizHomogenea[0, 1] * puntosS2[i].Y) + ((int)matrizHomogenea[0,3]);
                                puntosS1[i].Y = ((int)matrizHomogenea[1, 0] * puntosS2[i].X) + ((int)matrizHomogenea[1, 1] * puntosS2[i].Y) + ((int)matrizHomogenea[1,3]);
                                */
                                puntosS1[i].X = (int)((matrizHomogenea[0, 0] * puntosS2[i].X) + (matrizHomogenea[0, 1] * puntosS2[i].Y) + (matrizHomogenea[0, 3]));
                                puntosS1[i].Y = (int)((matrizHomogenea[1, 0] * puntosS2[i].X) + (matrizHomogenea[1, 1] * puntosS2[i].Y) + (matrizHomogenea[1, 3]));


                                //Verificamos
                                if (!Verificador3000(puntosS1[i]))
                                {
                                    trazoPosible = false;
                                    MessageBox.Show("Se generan trazos fuera de la hoja", "Semicírculo fuera de hoja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    labelSimpleVistaPrevia.Text = puntosS1[i].ToString();
                                    break;
                                }
                            }
                            //8) Calcular el rectángulo contenedor
                            Point puntoRect = new Point();
                            puntoRect = TransformToPixel(centroArco.X-rInt,centroArco.Y-rInt);
                            Rectangle rect = new Rectangle(puntoRect.X, puntoRect.Y, TransformToPixelValue(dInt), TransformToPixelValue(dInt));
                            //grafico.DrawRectangle(pen2,rect);
                            //9) Dibujamos el semicírculo
                            if (trazoPosible)
                            {
                                //grafico.DrawArc(pen,rect,)
                                if(x1>x2 && anguloRectaDegree!=180)
                                {
                                    recorrido = recorridoAngular * -1;
                                }
                                else
                                {
                                    recorrido = recorridoAngular;
                                }
                                grafico.DrawArc(pen, rect, (float)anguloRectaDegree+180.0f, recorrido);
                                grafico.DrawRectangle(pen2, centroArcoPixel.X - 1, centroArcoPixel.Y - 1, 1, 1);
                            }

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
                    angle = Math.Atan((double)(y2-y1)/(double)(x2-x1)); //En radianes
                    

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

        #region TransformToPixel
        private Point TransformToPixel(int xmm, int ymm)
        {
            Point puntoPixel = new Point();
            puntoPixel = new Point(xmm * 3 / 2, ymm * 3 / 2);
            return puntoPixel;
        }

        private int TransformToPixelValue(int mm)
        {
            int valuePixel = 0;
            valuePixel = mm * 3 / 2;
            return valuePixel;
        }


        private Point TransformPointToPixel(Point mmPoint)
        {
            Point puntoPixel = new Point();
            puntoPixel = new Point(mmPoint.X * 3 / 2, mmPoint.Y * 3 / 2);
            return puntoPixel;
        }
        #endregion

        #region VerificaPuntoEnHoja
        private bool Verificador3000(Point punto)
        {
            bool dentro = false;

            if(punto.X >= 0 && punto.X <= 220 && punto.Y >= 0 && punto.Y <= 280)
            {
                dentro = true;
            }
            return dentro;
        }
        #endregion
    }
}
