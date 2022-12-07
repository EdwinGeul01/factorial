using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class factorialservices
    {

    public static void Main(string[] args)
    {




    }




    public int calcularFactorial(int numeroACalcular)
    {

        if(numeroACalcular == 0)
        {
            return 1;
        }

        return numeroACalcular * calcularFactorial(numeroACalcular - 1) ;

    }



}
