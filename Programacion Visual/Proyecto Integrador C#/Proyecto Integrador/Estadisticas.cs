using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_Integrador
{
    public partial class Estadisticas : Form
    {
        //Creamos una Tabla Temporal
        private DataTable Cuadro_Estadistico = new DataTable();

        public Estadisticas()
        {
            InitializeComponent();
        }
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            //Crear y asignar el nombre a las Columnas
            Cuadro_Estadistico.Columns.Add("Número de Clase");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Intervalo de Clase");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Frecuencia");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Frecuencia Acumulada");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Frecuencia Relativa");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Frecuencia Relativa Acumulada");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Marca de Clase");   //Se define el Nombre de la primera Columna
            Cuadro_Estadistico.Columns.Add("Grados");   //Se define el Nombre de la primera Columna
            dgvCuadro_Estadistico.DataSource = Cuadro_Estadistico;  //establece el origen de datos que DataGridView muestra los datos del DataTable

            //Establecer el ancho de las Columnas
            dgvCuadro_Estadistico.Columns[0].Width = 100;   //Primera Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[1].Width = 100;   //Seguna Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[2].Width = 100;   //Tercera Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[3].Width = 100;   //Cuarta Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[4].Width = 100;   //Quinta Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[5].Width = 100;   //Sexta Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[6].Width = 100;   //Septima Columna con 100 pts de ancho
            dgvCuadro_Estadistico.Columns[7].Width = 100;   //Octava Columna con 100 pts de ancho

            //Actualizar el DataGrid
            dgvCuadro_Estadistico.Update();

            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Environment.CurrentDirectory + @"\Proyecto Integrador.accdb'";
            //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Torby\Desktop\Proyecto Integrador C#\Proyecto Integrador.accdb'";
            cmd.Connection = cn;
            try
            {
                string q = "select * from Usuarios";
                cmd.CommandText = q;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lsbDesordenada.Items.Add(int.Parse(dr[21].ToString()));
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message.ToString());
            }

            //Declaracion de Variables
            int Elementos = 0, Inicializador2, Inicializador4, Inicializador3, Inicializador5, Frecuencia = 0, Frecuencia2 = 0;
            int Mediana, NumeroClase = 0, MarcaDeClase, Sumatoria = 0, Rango = 0, ValorMaximo = 0, UltimoValor = 0;
            int Intervalo = 0, IntervaloMenor, IntervaloMayor, FrecuenciaAcumulada = 0, Contador = 0;
            double Media = 0, FrecuenciaRelativa = 0, FrecuenciaRelativaAcumulada = 0, Grados, Mediana2, Varianza = 0;
            double Desviacion = 0, Intervalo2 = 0, CoeficiendeVariacion = 0, DesviacionMedia = 0;
            bool Indicador;

            //Declarar el Vector, del Tamaño de la Lista
            int[] Lista = new int[lsbDesordenada.Items.Count];

            //Declarar el Vector para la moda, del tamaño de la Lista
            int[] Moda = new int[lsbDesordenada.Items.Count];

            //Pasar los valores de la Lista Desordenada al Vector
            foreach (int Inicializador1 in lsbDesordenada.Items)   //Recorre todos los elementos de la Lista
            {
                Lista[Elementos] = Inicializador1;   //Cada valor se asigna en la correspondiente posición del Vector
                Elementos++;  //Aqui se determina cuantos Elementos Existen
            }
            //Calcular la Media
            Media = Math.Round(Lista.Average(), 3);  //Sacamos el promedio
            txtMedia.Text = Convert.ToString(Media); //Asignamos al cuadro de promedio

            //Ordenar el Vector
            Array.Sort(Lista);

            //Mostrar el Vector Ordenado
            lsbOrdenada.Items.Clear();   //Limpiar lo que tenga la Lista indicada
            for (Inicializador2 = 0; Inicializador2 < Lista.Length; Inicializador2++)  //Desde la posicion 0 has la ultima del Vector
            {
                lsbOrdenada.Items.Add(Lista[Inicializador2]);  //En la Lista Ordenada se imprime cada valor del Vector O
            }

            //Calcular el Tamaño de la Muestra
            txtMuestra.Text = Lista.Length.ToString();  //Saca la longitud del Vector

            //Calcular el Elemento Menor y Mañor
            txtMinimo.Text = Lista[0].ToString();   //Minimo
            txtMaximo.Text = Lista[Lista.Length - 1].ToString();   //Maximo

            //Calcular la Mediana
            if (Elementos > 1)   //Si el total de Elementos es Mayor a 1, entra
            {
                Mediana = Elementos / 2;   //Variable Mediana es igual al Total de Elementos entre 2
                if (Elementos % 2 == 0)   //Si el residuo de la divicion de el Tota de elementos entre 2 es Igual a 0, entra
                {
                    Mediana2 = Lista[Mediana - 1] + Lista[Mediana]; //Variable Mediana2 es igual a la suma de la primera posicion del vector + la posicion de la mitad del vector
                    Mediana2 = Mediana2 / 2;   //Mediana2 es igual
                    txtMediana.Text = Convert.ToString(Mediana2);    //Asignamar la Mediana a la Caja de Texto Correspondiente
                }
                else   //Si el residuo de la divicion de el Tota de elementos entre 2 es diferente a 0, entra
                {
                    txtMediana.Text = Convert.ToString(Lista[Mediana]);   //Asignamar la Mediana a la Caja de Texto Correspondiente
                }
            }
            else  //Si el Total de Elementos es Menor a 1, entra
            {
                txtMediana.Text = Convert.ToString(Lista[0]);   //Asignamar la Mediana a la Caja de Texto Correspondiente
            }

            //Calcular la Varianza
            if (Elementos != 1)  //Si el total de Elementos es Diferente a 1, entra
            {
                foreach (int i in Lista)  //Recorremos cada elemento del Vector
                {
                    Varianza += Math.Pow((i - Media), 2);  //Varianza es igual a la Elevacion al cuadrado de la primera posicion del vector menos la Media
                }
                Varianza /= (Elementos - 1);   //Varianza es igual a Varianza entre el total de Elementos menos 1
                Varianza = Math.Round(Varianza, 3);  //Determinar que nomas muestre 3 Decimales
                txtVarianza.Text = Convert.ToString(Varianza);   //Asignamar la Varianza a la Caja de Texto Correspondiente
            }
            else   //Si el total de Elementos es Igual a 1, entra
                txtVarianza.Clear();  //Borra lo que tenga la caja de Texto de Varianza

            //Calcular Desviacion Estandar
            if (Elementos != 1)   //Si el total de Elementos es Diferente a 1, entra
            {
                Desviacion = Math.Sqrt(Varianza);  //Sacar Raiz Cuadrada a la Varianza
                Desviacion = Math.Round(Desviacion, 3);  //Determinar que nomas muestre 3 Decimales
                txtDesviacion.Text = Desviacion.ToString();   //Asignamar la Desviacion a la Caja de Texto Correspondiente
            }

            //Calcular la Desviación Media
            foreach (int w in Lista)  //Recorremos cada elemento del Vector
            {
                DesviacionMedia += Math.Abs((Media - w)); //Desviacion Media es igual al Valor absoluto de la Media menos el valor de la posicion del Vector
            }
            DesviacionMedia /= lsbDesordenada.Items.Count;   //Desviación Media es igual a Desviacion Media entre el Total de Elementos
            DesviacionMedia = Math.Round(DesviacionMedia, 3);  //Determinar que nomas muestre 3 Decimales
            txtDesviacionMedia.Text = Convert.ToString(DesviacionMedia);   //Asignamar la Varianza a la Caja de Texto Correspondiente

            //Calcular la sumatoria
            for (Inicializador3 = 0; Inicializador3 < Lista.Length; Inicializador3++)     //Desde la posicion 0 has la ultima del Vector
            {
                Sumatoria = Lista[Inicializador3] + Sumatoria;   //Sumatoria es Igual al Valor del Vector en la posicion Correspondiente + Sumatoria
            }
            txtSumatoria.Text = Convert.ToString(Sumatoria);  //Asignamar la Sumatoria a la Caja de Texto Correspondiente

            //Calcular la Moda
            for (Inicializador4 = 0; Inicializador4 < Lista.Length; Inicializador4++)   // Busqueda de la serie de valores identicos mas larga.
            {
                for (Frecuencia2 = 0; Frecuencia2 < Lista.Length; Frecuencia2++)     //Desde la posicion 0 has la ultima del Vector
                {
                    if (Lista[Inicializador4] == Lista[Frecuencia2])  //Si es el mismo valor, entra
                    {
                        Moda[Inicializador4]++;  //En el segundo vector se Agrega 1
                    }
                }
            }
            for (Inicializador5 = 0; Inicializador5 < Moda.Length; Inicializador5++)//ciclo para localizar la o las modas
            {
                if (Moda[Inicializador5] > ValorMaximo) //Si el Valor en la posicion indicada del vector Moda es Mayor a Maximo, entra
                {
                    txtModa.Clear();   //Borra lo que tenga el TextBox Correspondiente
                    txtModa.Text += Lista[Inicializador5].ToString() + " ";   //Imprime el valor del vector Lista en la posicion indicada + Espacio en Blanco
                    ValorMaximo = Moda[Inicializador5];  //Maximo toma el valor del vector Moda en la Posicion indicada
                    UltimoValor = Lista[Inicializador5]; //Acabado toma el valor del vector Lista en la posicion indicada
                }
                //Si el valos en la posicion indicada del Vector moda es igual a maximo y maximo en mayor a 1 y acabado diferente al valor del vector Lista en la posicion indicasa
                if (Moda[Inicializador5] == ValorMaximo && ValorMaximo > 1 && UltimoValor != Lista[Inicializador5]) //Entra
                {
                    txtModa.Text += Lista[Inicializador5].ToString() + " "; ////Imprime el valor del vector Lista en la posicion indicada + Espacio en Blanco
                    UltimoValor = Lista[Inicializador5];   //Acabado toma el valor del vector Lista en la posicion indicada
                }
                if (txtModa.Text == "")  //Si no existe nada en el TextBox, entra
                {
                    txtModa.Text = "No hay moda";  //Imprime en el TextBox correspondiente que no hay nada
                }
            }

            //Calculamos el Coeficiente de Variación
            CoeficiendeVariacion = Desviacion / Media;   //Se obtiene dividiendo el valor de la Desviacion Estandar entre el valor de la Media
            txtCoeficiente.Text = Convert.ToString(Math.Round(CoeficiendeVariacion, 3)); //Asigna el Coeficiente de Variacion al TextBox Correspondiente, pero solo con 3 Decimales

            //Calcular el Alcance
            txtAlcance.Text = (Elementos - 1).ToString();   //Tamaño del Vector menos 1

            //Calcular el Rango
            Rango = Lista[Lista.Length - 1] - Lista[0];  //Calcular el Rango: Elemento Mayor menos Elemento Menor
            txtRango.Text = Rango.ToString();   //Asignamar el Rango a la Caja de Texto Correspondiente

            //Calcular Numero de Clases
            if (Elementos >= 50)  //Primera Regla, si Elementos es menor que 50
            {
                double NumeroClaseTotal = 3 + 3.3 * Math.Log10(Elementos) + 0.5; ;   //Multiplicacion del Logaritmo del Total de Elementos por 3.3 mas 3
                NumeroClase = (int)NumeroClaseTotal; //Conversion Explisita a Enteros
            }
            else  //Segunda Regla, si Elementos es menor que 50
            {
                double NumeroClaseTotal = 1 + 3.3 * Math.Log10(Elementos) + 0.5; ;   //Multiplicacion del Logaritmo del Total de Elementos por 3.3 mas 1
                NumeroClase = (int)NumeroClaseTotal; //Conversion Explisita a Enteros
            }

            txtIntervalo.Clear();
            //Calcular el Intervalo de Clases
            Intervalo2 = Rango / NumeroClase + 0.5;
            Intervalo = (int)Intervalo2; //Conversion Explisita a Enteros
            txtIntervalo.Text = Convert.ToString(Intervalo);

            //Comenzamos a llegar el datagrid
            IntervaloMenor = Lista[0]; ;   //Variable Baja con valores del Rango
            for (int NumeroDeClase = 1; NumeroDeClase <= NumeroClase; NumeroDeClase++)  //Ejemplo de como agregar 
            {
                Frecuencia = 0; FrecuenciaRelativa = 0;   //Inicializamos variables
                IntervaloMayor = IntervaloMenor + Intervalo;  //Indicamos el valor del Intervalo Mayor
                Indicador = false;   //Inicializamos la Bandera
                DataRow row = Cuadro_Estadistico.NewRow(); //Crear un Registro

                //LLenar conforme a sus Columnas
                row["Número de Clase"] = NumeroDeClase.ToString(); //Agregar lo valores de cada Columna
                row["Intervalo de Clase"] = IntervaloMenor.ToString() + " - " + IntervaloMayor.ToString();
                while (Indicador == false)
                {
                    if (Contador != Lista.Length)
                    {
                        if (Lista[Contador] >= IntervaloMenor && Lista[Contador] <= IntervaloMayor)
                        {
                            Frecuencia++;  //Aqui se determina cuantos Elementos Existen dentro del Intervalo
                            Contador++;
                        }
                        else
                        {
                            Indicador = true;
                        }
                    }
                    else
                    {
                        Indicador = true;
                    }
                }

                //Calcular la Frecuencia Acumulada
                FrecuenciaAcumulada += Frecuencia;   //Se suma cada vez las veces la cantidad de Elementos Existentes dentro del Intervalo

                //Calcular la Frecuencia Relativa
                FrecuenciaRelativa = Convert.ToDouble(Frecuencia) / Convert.ToDouble(Elementos);   //Elementos Existentes dentro del Intervalo entre Total de Elementos

                //Calcular la Frecuencia Relativa Acumulada                    
                FrecuenciaRelativaAcumulada += FrecuenciaRelativa;

                //Calcular la Marca de Clase
                MarcaDeClase = (IntervaloMayor + IntervaloMenor) / 2;

                //Calcular los Grados
                Grados = Math.Round((FrecuenciaRelativa * 360), 3);

                //Calcular el Intervalo Menor
                IntervaloMenor = IntervaloMayor + 1;
                row["Frecuencia"] = Frecuencia.ToString();
                row["Frecuencia Acumulada"] = FrecuenciaAcumulada.ToString();
                row["Frecuencia Relativa"] = Math.Round((FrecuenciaRelativa * 100), 3).ToString();
                row["Frecuencia Relativa Acumulada"] = Math.Round((FrecuenciaRelativaAcumulada * 100), 3).ToString();
                row["Marca de Clase"] = MarcaDeClase.ToString();
                row["Grados"] = Grados.ToString() + " °";
                Cuadro_Estadistico.Rows.Add(row); //Añadir un Registro a la Tabla
                dgvCuadro_Estadistico.DataSource = Cuadro_Estadistico; //Añadir la Tabla al DataGrid
                dgvCuadro_Estadistico.Update(); //Actualizar la Tabla
                //Imprimir en las Graficas
                this.GraficaHistograma.Series["Frecuencia"].Points.AddXY(NumeroDeClase, Frecuencia); //X=Numero de Clase y Y=Frecuencia
                this.GraficaPasteles.Series["Grados"].Points.AddXY(NumeroDeClase, Grados);   //X=Numero de Clase y Y=Grados
                this.GraficaPoligonal.Series["Frecuencia"].Points.AddXY(MarcaDeClase, Frecuencia);   // X=Marca de Clase y Y=Frecuencia
            }
        }
    }
}
