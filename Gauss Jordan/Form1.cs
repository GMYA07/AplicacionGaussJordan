using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gauss_Jordan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            try
            {
                Matrizes.Rows.Clear();
                inputX.Text = "";
                inputY.Text = "";
                inputZ.Text = "";
                //Rellenamos la Matriz Aumentada para resolver el problema
                double[,] matrizExtendida = {
                    { double.Parse(inputPosicion11.Text),double.Parse(inputPosicion12.Text),double.Parse(inputPosicion13.Text),double.Parse(inputPosicion14.Text)},
                    { double.Parse(inputPosicion21.Text),double.Parse(inputPosicion22.Text),double.Parse(inputPosicion23.Text),double.Parse(inputPosicion24.Text)},
                    { double.Parse(inputPosicion31.Text),double.Parse(inputPosicion32.Text),double.Parse(inputPosicion33.Text),double.Parse(inputPosicion34.Text)}
                };

                if (calcular_determinante(matrizExtendida) == 0)
                {
                    //Primero convertimos la posicion [0,0] en 1 y si ya lo es solo se obvia
                    matrizExtendida = calcularPosicionPivot(matrizExtendida);
                    //Ahora convertiremos 0 los terminos de la matriz triangular inferior
                    convertir0TriangularInferior(matrizExtendida, 1);
                    impresionMatriz(matrizExtendida);
                    //Ahora realizaremos la transformacion de la diagonal a valores de 1
                    convertirDiagonalAunos(matrizExtendida, 2);
                    impresionMatriz(matrizExtendida);
                    //Ahora Calcularemos el ultimo 0 de la diagonal inferior de la matriz
                    convertir0TriangularInferior(matrizExtendida, 2);
                    impresionMatriz(matrizExtendida);
                    //Ahora realizaremos la transformacion de la diagonal a valores de 1 de la ultima posicion que falta
                    convertirDiagonalAunos(matrizExtendida, 3);
                    impresionMatriz(matrizExtendida);
                    //Ahora Calcularemos el ultimo 0 de la diagonal Superior de la matriz
                    convertir0TriangularSuperior(matrizExtendida);
                    impresionMatriz(matrizExtendida);

                    inputX.Text = matrizExtendida[0,3].ToString();
                    inputY.Text = matrizExtendida[1,3].ToString();
                    inputZ.Text = matrizExtendida[2,3].ToString();
                }
                else
                {
                    MessageBox.Show("No se puede realizar dado que su determinante es 0");
                    inputPosicion11.Text = "";
                    inputPosicion12.Text = "";
                    inputPosicion13.Text = "";
                    inputPosicion14.Text = "";
                    inputPosicion21.Text = "";
                    inputPosicion22.Text = "";
                    inputPosicion23.Text = "";
                    inputPosicion24.Text = "";
                    inputPosicion31.Text = "";
                    inputPosicion32.Text = "";
                    inputPosicion33.Text = "";
                    inputPosicion34.Text = "";
                }

            }
            catch (Exception ex) { 
                MessageBox.Show("Por favor Ingresar en los campos solo valores numericos");
            }
        }

        private int calcular_determinante(double[,] matriz) {
            //       D[A]       =      a         *      (( e      *    i )     - (   f           *      h  ) )    -      b       * (   d          *      i        -      f        *      g      )   +     c         * (  d           *     h         -      e        *     g      )      
            double determinante = (matriz[0, 0] * ((matriz[1, 1] * matriz[2, 2]) - (matriz[1, 2] * matriz[2,1]))) - (matriz[0,1] * ((matriz[1, 0] * matriz[2, 2]) - (matriz[1, 2] * matriz[2, 0]))) + (matriz[0, 2] * ((matriz[1, 0] * matriz[2, 1]) - (matriz[1, 1] * matriz[2, 0])));
            if (determinante == 0)
            {
                return 1; //si el return no es 0 es por no tiene determinanate y no se puede realizar el metodo de gauss jordan
                
                
            }
            else
            {
                return 0; //si el return es 0 es por q lo tiene y se puede realizar el metodo de gauss jordan
            }
            
        }

        private double[,] calcularPosicionPivot(double[,] matriz)
        {
            if (matriz[0, 0] == 1)
            {
                impresionMatriz(matriz);

            }
            else if (matriz[0, 0] == -1)
            {
                for (int i = 0; i < 4; i++)
                {
                    matriz[0, i] = matriz[0, i] * -1;
                }

                impresionMatriz(matriz);
            }
            else
            {
                double denominador = matriz[0, 0];

                for (int i = 0; i < 4; i++)
                {
                    matriz[0, i] /= denominador;

                }

                impresionMatriz(matriz);
            }

            return matriz;

        }
      
        private double[,] convertir0TriangularInferior(double[,] matriz,int diagonalSeleccionada)
        {
            if (diagonalSeleccionada == 1)//con esto sacamos los 0 debajo del 1
            {
                //estos 2 se ocupan para la formula F2 = -(posicionprimerafila)*(F1)+F2 na la otra compuesta asi F3 = -(posicionprimerafila)*(F1)+F3
                double z = matriz[1, 0];
                double z2 = matriz[2, 0];

                for (int i = 1; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 1) //esta condicion es para saber a q fila le trabajremos los cambios de 0
                        {
                            matriz[i, j] = ((-1 * z) * matriz[0, j]) + matriz[1, j];
                        }
                        else
                        {
                            matriz[i, j] = ((-1 * z2) * matriz[0, j]) + matriz[2, j];
                        }
                    }
                }
            }
            else //aqui sacamos el 0 a la par del primera columna de la izquierda
            {
                double z = matriz[2,1]; //seleccionamos la posicion 3,1 de la matriz para encontrar ese ultimo 0

                for (int j = 1; j < 4; j++)
                {
                    matriz[2, j] = ((-1 * z) * matriz[1, j]) + matriz[2, j]; // F3 = -primeraPosicionDespuesDelCero(F2)+F3
                }

            }

            return matriz;
        }
        private double[,] convertir0TriangularSuperior(double[,] matriz)
        {

            double z3 = matriz[1, 2]; //se ocupara para el 0 de la 2 da fila
            double z4 = matriz[0, 1];
            for (int j = 1; j < 4; j++)
            {
                 matriz[0, j] = ((-1 * z4) * matriz[1, j]) + matriz[0,j]; //en este caso se coloca + 1 por que la posicion de pivot ya esta calculada y no la queremos alterar
                                                                                                        //y solo queremos trabajar los numeros faltantes de la fila para hacerlos 0
            }
            double z5 = matriz[0, 2];

            for (int j = 2; j < 4; j++)
            {
                matriz[0, j] = ((-1 * z5) * matriz[2, j]) + matriz[0, j]; //en este caso se coloca + 1 por que la posicion de pivot ya esta calculada y no la queremos alterar
                                                                          //y solo queremos trabajar los numeros faltantes de la fila para hacerlos 0
            }

            impresionMatriz(matriz);

            //Calculamos el 0 de la 2da fila
            for (int i = 2; i < 4;  i++)
            {
                matriz[1, i] = ((-1 * z3) * matriz[2, i]) + matriz[1, i];
            }

            return matriz;
        }
        private double[,] convertirDiagonalAunos(double[,] matriz,int diagonalConvertir) 
        {
            int x = 0; //este nos ayudara a saber en q fila estamos o vamos a hacer la diagonal a 1 y sus siguientes calculos
            int z = 0; //este nos ayudara a saber en q columna estamos o vamos a hacer la diagonal a 1 y sus siguientes calculos
            double denominador = 0; // nos ayudara para saber el valor que se le pondra en el denominador del calculo de la diagonal principal

            if (diagonalConvertir == 2)
            {
                denominador = matriz[1, 1]; //posicion 2,1
                x = 1;
                z = 1;
            }
            else
            {
                denominador = matriz[2, 2]; //posicion 3,3
                x= 2;
                z = 2;
            }

            for (int i = x ; i < 3; i++)
            {
                for(int j = z ;j < 4; j++)
                {
                    matriz[i,j] = (matriz[i,j])/denominador;
                }

                if (diagonalConvertir == 2) //esto es para romper el ciclo dado que cuando se calcula el 2do "1" de la diagonal principal falta un 0 de la triangular inferior
                {
                    break;
                }
            }
            
            return matriz;
        }
        private void impresionMatriz(double[,] matriz)
        {
            Matrizes.Rows.Add("//////", "//////", "//////", "//////");
            for (int i = 0; i < 3; i++)
            {
                Matrizes.Rows.Add(matriz[i, 0], matriz[i, 1], matriz[i, 2], matriz[i, 3]);
            }
            Matrizes.Rows.Add("//////", "//////", "//////", "//////");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
