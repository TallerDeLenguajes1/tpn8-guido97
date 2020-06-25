using System;
namespace gtkproject
{
    public class Calculadora
    {
        float Numero1;   //punto flotante
        float Numero2;   //punto flotante
        int operador=1;
        public string FechaDeLaOperacion;
        public string operacion;

        public Calculadora(string operacion)
        {
            this.operacion = operacion;
            float[] aux=HelperCalculadora.ExtraerValores(operacion);
            if (aux!=null)
            {

                Numero1 = aux[0];Numero2 = aux[1];operador = (int)aux[2];
                FechaDeLaOperacion = DateTime.Now.ToString();
            }
        }

        public float Suma()
        {
            return Numero1+Numero2;
        }
        public float Resta()
        {
            return Numero1 - Numero2;
        }
        public float Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        public float Division()
        {
            float resultado = Numero2!=0 ?Numero1/Numero2:0;
            return resultado;
        }



        public float Calcular()
        {
            float resp=0;
            switch (operador)
            {
                case 1://suma
                    resp = Suma();
                    break;
                case 2://resta
                    resp = Resta();
                    break;
                case 3://Multi
                    resp = Multiplicacion();
                    break;
                case 4://div
                    resp = Division();
                    break;
            }
            return resp;
        }


    }
    static public class HelperCalculadora
    {

        /*Devuelve un float[], ret[0] es el numero 1, ret[1] el numero2, ret[2] el operador*/
        static public float[] ExtraerValores(string operacion)
        {
            char[] operadores = { '+', '-', '*', '/' };
            try
            {

                int cont = 0;
                string[] valoresExtr=null;
                foreach (var item in operadores)
                {
                    valoresExtr = operacion.Split(operadores[cont]);
                    if (operacion.Contains(item.ToString()))
                        break;
                    cont++;
                }
                float[] ret = { float.Parse(valoresExtr[0]), float.Parse(valoresExtr[1]), cont + 1 };
                return ret;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
